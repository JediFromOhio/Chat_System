Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.Json
Imports System.Collections.Concurrent
Imports System.IO
Imports System.Threading
Imports BCrypt.Net
Imports System.Net.Mail
Imports Microsoft.Data.SqlClient


Public Class ChatServer

    Private ReadOnly _port As Integer
    Private _listener As TcpListener
    Private _cts As CancellationTokenSource

    Private ReadOnly _clients As New ConcurrentDictionary(Of String, StreamWriter)()
    Private ReadOnly connStr As String = "Server=.\SQLEXPRESS;Database=ChatDB;Trusted_Connection=True;TrustServerCertificate=True;"
    Private ReadOnly _jsonOptions As New JsonSerializerOptions With {
        .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    }

    Public Sub New(port As Integer)
        _port = port
    End Sub

    Private Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Private Function VerifyPassword(password As String, hash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(password, hash)
    End Function

    Private Function GenerateOTP() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString("D6")
    End Function

    Private Async Function SendErrorAsync(writer As StreamWriter, errorMsg As String) As Task
        Dim replyJson = JsonSerializer.Serialize(New With {.type = "error", .errorMsg = errorMsg}, _jsonOptions)
        Await writer.WriteLineAsync(replyJson)
    End Function


    Private Async Function SendOTPAsync(email As String, otp As String) As Task
        Using smtp As New SmtpClient("smtp.gmail.com") With {
            .Port = 587,
            .EnableSsl = True,
            .Credentials = New Net.NetworkCredential("osundahunsiolamide@gmail.com", "qsbcsdmkywzczcrn")
            }
            Dim mail As New MailMessage("osundahunsiolamide@gmail.com", email, "Chat App OTP", $"Your OTP: {otp} (Valid for 5 mins)")
            Await smtp.SendMailAsync(mail)
        End Using
    End Function

    Private Function GetUser(email As String) As (Exists As Boolean, Hash As String)
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Using cmd = New SqlCommand("SELECT PasswordHash, IsActive FROM Users WHERE Email=@email;", conn)
                cmd.Parameters.AddWithValue("@email", email)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() AndAlso CBool(reader("IsActive")) Then
                        Return (True, reader("PasswordHash").ToString())
                    End If
                End Using
            End Using
        End Using
        Return (False, "")
    End Function

    Private Sub StoreMessage(fromEmail As String, toEmail As String, text As String)
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Using cmd = New SqlCommand("INSERT INTO Messages (FromEmail, ToEmail, [Text]) VALUES (@from, @to, @text)", conn)
                cmd.Parameters.AddWithValue("@from", fromEmail)
                cmd.Parameters.AddWithValue("@to", toEmail)
                cmd.Parameters.AddWithValue("@text", text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetQueuedMessages(email As String) As List(Of (From As String, Text As String))
        Dim queued As New List(Of (String, String))
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Using cmd = New SqlCommand("UPDATE Messages SET Delivered=1 WHERE ToEmail=@email AND Delivered=0; SELECT FromEmail, [Text] FROM Messages WHERE ToEmail=@email AND Delivered=1 ORDER BY Timestamp", conn)
                cmd.Parameters.AddWithValue("@email", email)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        queued.Add((reader("FromEmail").ToString(), reader("Text").ToString()))
                    End While
                End Using
            End Using
        End Using
        Return queued
    End Function
    Public Async Function StartAsync() As Task
        _cts = New CancellationTokenSource()
        _listener = New TcpListener(IPAddress.Any, _port)

        Try
            _listener.Start()
            Console.WriteLine("=== CHAT SERVER v3.0 (EMAILS) ===")
            Console.WriteLine($"Listening on 0.0.0.0:{_port}")
            Console.WriteLine("Press Ctrl+C to stop")
            Console.WriteLine("===============================")

            While Not _cts.Token.IsCancellationRequested
                Dim tcpClient = Await _listener.AcceptTcpClientAsync(_cts.Token)
                Dim clientEndPoint = tcpClient.Client.RemoteEndPoint.ToString()
                Console.WriteLine($"✓ Client connected: {clientEndPoint}")

                Task.Run(Function() HandleClient(tcpClient))
            End While

        Catch ex As Exception When ex.HResult = -532462766
            Console.WriteLine("✓ Shutdown complete (Socket 995 expected)")
        Catch ex As ObjectDisposedException
            Console.WriteLine("Listener disposed (normal)")
        Catch ex As Exception
            Console.WriteLine($"Unexpected error: {ex.Message}")
        Finally
            _listener?.Stop()
            Console.WriteLine("Server socket closed")
        End Try
    End Function

    Private Class NetMessage
        Public Property Type As String
        Public Property Data As Dictionary(Of String, JsonElement) = New Dictionary(Of String, JsonElement)()

        Public Property ErrorMsg As String
    End Class

    Private Sub BroadcastPresence()
        Dim users = _clients.Keys.OrderBy(Function(x) x).ToArray()

        Dim json = JsonSerializer.Serialize(New With {
        .type = "presence",
        .data = New With {.users = users}
    }, _jsonOptions)

        For Each kv In _clients
            Try
                kv.Value.WriteLine(json)   ' sync write (safe for VB: not in Catch/Finally Await issues)
            Catch
            End Try
        Next
    End Sub


    Private Async Function HandleClient(client As TcpClient) As Task
        Dim endPoint = client.Client.RemoteEndPoint.ToString()
        Dim email As String = Nothing

        Try
            Using stream = client.GetStream()
                Using reader = New StreamReader(stream, Encoding.UTF8)
                    Using writer = New StreamWriter(stream, Encoding.UTF8) With {.AutoFlush = True}

                        ' Welcome
                        Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {
                            .type = "welcome",
                            .data = New With {.message = "Send identify: {type:'identify', data:{email:'you@x.com'}}"}
                        }, _jsonOptions))

                        While Not _cts.Token.IsCancellationRequested
                            Dim line = Await reader.ReadLineAsync()
                            If line Is Nothing Then Exit While

                            Dim msg As NetMessage = Nothing
                            Dim replyJson As String = Nothing

                            Try
                                msg = JsonSerializer.Deserialize(Of NetMessage)(line, _jsonOptions)
                            Catch
                                replyJson = JsonSerializer.Serialize(New With {
                                    .type = "error",
                                    .errorMsg = "Invalid JSON"
                                }, _jsonOptions)
                            End Try

                            If replyJson IsNot Nothing Then
                                Await writer.WriteLineAsync(replyJson)
                                Continue While
                            End If


                            If msg Is Nothing OrElse String.IsNullOrWhiteSpace(msg.Type) Then Continue While

                            Select Case msg.Type.ToLowerInvariant()
                                Case "register"
                                    If msg.Data Is Nothing OrElse Not msg.Data.ContainsKey("email") OrElse Not msg.Data.ContainsKey("password") Then
                                        Await SendErrorAsync(writer, "Missing email/password")
                                        Continue While
                                    End If
                                    email = msg.Data("email").GetString().Trim().ToLowerInvariant()
                                    Dim password = msg.Data("password").GetString()
                                    Using conn As New SqlConnection(connStr)
                                        conn.Open()
                                        Using checkCmd = New SqlCommand("IF EXISTS(SELECT 1 FROM Users WHERE Email=@email) SELECT 1 ELSE SELECT 0", conn)
                                            checkCmd.Parameters.AddWithValue("@email", email)
                                            If CInt(checkCmd.ExecuteScalar()) = 1 Then
                                                Await SendErrorAsync(writer, "Email exists")
                                                Continue While
                                            End If
                                        End Using

                                        Dim otp = GenerateOTP()
                                        Using regCmd = New SqlCommand("INSERT INTO Users (Email, PasswordHash, OTP) VALUES (@email, @hash, @otp)", conn)
                                            regCmd.Parameters.AddWithValue("@email", email)
                                            regCmd.Parameters.AddWithValue("@hash", HashPassword(password))
                                            regCmd.Parameters.AddWithValue("@otp", otp)
                                            regCmd.ExecuteNonQuery()
                                        End Using

                                        Await SendOTPAsync(email, otp)
                                        Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {.type = "otp_sent"}))

                                    End Using
                                Case "profileupdate"
                                    Dim bio = msg.Data("bio").GetString()
                                    Dim avatar = msg.Data("avatar").GetString()
                                    Dim status = msg.Data("status").GetString()

                                    Using conn As New SqlConnection(connStr)
                                        conn.Open()
                                        Using cmd As New SqlCommand("UPDATE Users SET Bio=@bio, Avatar=@avatar, Status=@status WHERE Email=@email", conn)
                                            cmd.Parameters.AddWithValue("@bio", bio)
                                            cmd.Parameters.AddWithValue("@avatar", avatar)
                                            cmd.Parameters.AddWithValue("@status", status)
                                            cmd.Parameters.AddWithValue("@email", email)
                                            cmd.ExecuteNonQuery()
                                        End Using
                                    End Using
                                    Await writer.WriteLineAsync("""{""type"":""profileupdated""}")

                                Case "verify_otp"
                                    Dim inputOtp = msg.Data("otp").GetString()
                                    Using conn As New SqlConnection(connStr)
                                        conn.Open()
                                        Using cmd = New SqlCommand("UPDATE Users SET IsActive=1, OTP=NULL WHERE OTP=@otp; SELECT @@ROWCOUNT", conn)
                                            cmd.Parameters.AddWithValue("@otp", inputOtp)
                                            If CInt(cmd.ExecuteScalar()) = 1 Then
                                                Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {.type = "activated"}, _jsonOptions))
                                            Else
                                                Await SendErrorAsync(writer, "Invalid OTP")
                                            End If
                                        End Using

                                    End Using


                                Case "login"
                                    If msg.Data Is Nothing OrElse Not msg.Data.ContainsKey("email") OrElse Not msg.Data.ContainsKey("password") Then
                                        Await SendErrorAsync(writer, "Missing email/password")
                                        Continue While
                                    End If

                                    email = msg.Data("email").GetString().Trim().ToLowerInvariant()
                                    Dim password = msg.Data("password").GetString()
                                    Dim userInfo = GetUser(email)

                                    If Not userInfo.Exists OrElse Not VerifyPassword(password, userInfo.Hash) Then
                                        Await SendErrorAsync(writer, "Invalid Credentials")
                                        Continue While
                                    End If

                                    ' Success: add to clients 
                                    If Not _clients.TryAdd(email, writer) Then
                                        Await SendErrorAsync(writer, "Already Connected")
                                        Exit While
                                    End If

                                    Console.WriteLine($"LOGIN: {email} @ {endPoint}")

                                    Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {
                                        .type = "identified",
                                        .data = New With {.email = email}
                                    }, _jsonOptions))

                                    BroadcastPresence()

                                    'Deliver queued
                                    Dim queued = GetQueuedMessages(email)
                                    For Each q In queued
                                        Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {
                                                .type = "deliver",
                                                .data = New With {
                                                    .from = q.From,
                                                    .text = q.Text
                                                }
                                            }, _jsonOptions))

                                    Next




                                Case "msg"

                                    Dim toEmail = msg.Data("to").GetString().Trim().ToLowerInvariant()
                                    Dim text = msg.Data("text").GetString()
                                    Dim targetWriter As StreamWriter = Nothing
                                    If _clients.TryGetValue(toEmail, targetWriter) Then
                                        'Online: direct deliver
                                        Await targetWriter.WriteLineAsync(JsonSerializer.Serialize(New With {
                                            .type = "deliver",
                                            .data = New With {.from = email, .text = text}
                                        }, _jsonOptions))

                                        Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {
                                            .type = "sent",
                                            .data = New With {.to = toEmail}
                                        }, _jsonOptions))
                                    Else
                                        StoreMessage(email, toEmail, text)
                                        Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {
                                            .type = "sent",
                                            .errorMsg = "User offline/not found"
                                        }, _jsonOptions))
                                    End If

                                Case Else
                                    Await writer.WriteLineAsync(JsonSerializer.Serialize(New With {.type = "error", .errorMsg = "Unknown type"}, _jsonOptions))
                            End Select
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine($"[{endPoint}] ERROR: {ex.Message}")
        Finally
            If email IsNot Nothing Then
                Dim removed As StreamWriter = Nothing
                _clients.TryRemove(email, removed)
                BroadcastPresence()
            End If

            client.Close()
            Console.WriteLine($"✗ Client disconnected: {endPoint}")
        End Try
    End Function

    Public Sub StopServer()
        Console.WriteLine("Server stopping...")
        _cts?.Cancel()
        _listener?.Stop()
    End Sub

End Class
