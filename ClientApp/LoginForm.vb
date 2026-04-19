Imports System.Text.Json

Public Class LoginForm

    Private ReadOnly _client As ChatClient

    Public Sub New(client As ChatClient)
        InitializeComponent()
        _client = client
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler _client.ErrorOccurred, AddressOf OnError
        AddHandler _client.MessageReceived, AddressOf OnMessageReceived

        statusLabel.Text = "Status: Enter email and click Login or Register"
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Not _client.IsConnected Then
            Await _client.ConnectAsync()
        End If

        Await LoginAsync()
    End Sub

    Private Async Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registerForm As New RegisterForm(_client)
        registerForm.ShowDialog()
    End Sub

    Private Async Function RegisterAsync() As Task
        Dim email = txtEmail.Text.Trim().ToLowerInvariant()
        Dim pwd = txtPassword.Text
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(pwd) Then
            statusLabel.Text = "Status: Email/Password required"
            Return
        End If

        statusLabel.Text = "Status: Registering..."

        Dim msg As New ChatClient.NetMessage With {.Type = "register"}
        msg.Data("email") = JsonDocument.Parse("""" & email.Replace("""", "") & """").RootElement
        msg.Data("password") = JsonDocument.Parse("""" & pwd.Replace("""", "") & """").RootElement

        Await _client.SendAsync(msg)
    End Function

    Private Async Function LoginAsync() As Task
        Dim email = txtEmail.Text.Trim().ToLowerInvariant()
        Dim pwd = txtPassword.Text
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(pwd) Then
            statusLabel.Text = "Status: Email/password required"
            Return
        End If

        statusLabel.Text = "Status: Logging in..."
        Dim msg As New ChatClient.NetMessage With {.Type = "login"}
        msg.Data("email") = JsonDocument.Parse($"""{email.Replace("""""", "")}""").RootElement
        msg.Data("password") = JsonDocument.Parse($"""{pwd.Replace("""""", "")}""").RootElement
        Await _client.SendAsync(msg)
    End Function
    Private Sub OnMessageReceived(sender As Object, msg As ChatClient.NetMessage)
        If InvokeRequired Then
            Invoke(Sub() OnMessageReceived(sender, msg))
            Return
        End If

        Dim t = (If(msg.Type, "")).ToLowerInvariant()
        Dim email = ""
        If msg.Data IsNot Nothing AndAlso msg.Data.ContainsKey("email") Then
            email = msg.Data("email").GetString()
        End If

        Select Case t
            Case "otp_sent"
                statusLabel.Text = "Status: Check your email for OTP"
            Case "activated"
                statusLabel.Text = "Status: Account activated, now login "
            Case "identified"
                ' Open MainChatForm and close this one
                Dim f As New MainChatForm(_client, email)
                f.Show()
                Me.Hide()
            Case "error"
                statusLabel.Text = "Status: " & msg.ErrorMsg
        End Select
    End Sub

    Private Sub OnError(sender As Object, errorMsg As String)
        If InvokeRequired Then
            Invoke(Sub() OnError(sender, errorMsg))
            Return
        End If

        statusLabel.Text = "Status: Error - " & errorMsg
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ForgotPasswordButton_Click(sender As Object, e As EventArgs) Handles ForgotPasswordButton.Click
        Dim forgotForm As New ForgotPasswordForm(_client)
        forgotForm.ShowDialog()
    End Sub
End Class
