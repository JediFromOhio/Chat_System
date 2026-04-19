Imports System.Text.Json

Public Class ForgotPasswordOTPForm

    Private ReadOnly client As New ChatClient
    Private ReadOnly forgotEmail As String

    Public Sub New(client As ChatClient, email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.forgotEmail = email
        AddHandler client.MessageReceived, AddressOf OnMessage
    End Sub
    Private Sub ForgotPasswordOTPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ForgotPasswordOTPForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RemoveHandler client.MessageReceived, AddressOf OnMessage
    End Sub
    Private Async Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim otpInput = OTPTextBox.Text.Trim()
        If otpInput.Length <> 6 Then
            StatusLabel.Text = "Enter valid 6 - digit OTP"
            Exit Sub
        End If


        ValidateButton.Enabled = False ' Prevent Double-click

        Dim msg As New ChatClient.NetMessage With {
            .Type = "verifyresetotp",
            .Data = New Dictionary(Of String, JsonElement) From {{"otp", JsonSerializer.SerializeToElement(otpInput.Trim())}}
        }
        Await client.SendAsync(msg)
        Console.WriteLine("About to wait. Client.IsConnected = " & client.IsConnected)

        StatusLabel.Text = "Waiting for the server "

    End Sub
    Private Sub OnMessage(sender As Object, msg As ChatClient.NetMessage)
        If InvokeRequired Then
            Invoke(Sub() OnMessage(sender, msg))
            Return
        End If

        Console.WriteLine($"RECV: {msg.Type} | Error: {msg.ErrorMsg} | Form: {Me.Text}")

        Select Case msg.Type.ToLower()
            Case "resetverified"
                StatusLabel.Text = "OTP Verified!"
                MessageBox.Show("OTP Validated!")
                ValidateButton.Enabled = True
                RemoveHandler client.MessageReceived, AddressOf OnMessage
                Dim resetForm As New ResetPasswordForm(client, forgotEmail)
                Me.Close()
                resetForm.Show()
            Case "error"
                StatusLabel.Text = msg.ErrorMsg
                ValidateButton.Enabled = True
            Case Else
                StatusLabel.Text = $"Ignored: {msg.Type}" ' Debug
        End Select
    End Sub
End Class