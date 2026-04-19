Imports System.Text.Json

Public Class ForgotPasswordForm

    Private ReadOnly client As ChatClient
    Private forgotEmail As String

    Public Sub New(client As ChatClient)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        AddHandler client.MessageReceived, AddressOf OnMessage
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles EmailTextbox.TextChanged

    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub OTPRequestButton_Click(sender As Object, e As EventArgs) Handles OTPRequestButton.Click
        forgotEmail = EmailTextbox.Text.Trim().ToLower()
        Dim msg As New ChatClient.NetMessage With {
            .Type = "forgotpassword",
            .Data = New Dictionary(Of String, JsonElement) From {{"email", JsonSerializer.SerializeToElement(forgotEmail)}}
            }
        Await client.SendAsync(msg)
        StatusLabel.Text = "Check email for OTP"
    End Sub

    Private Sub OnMessage(sender As Object, msg As ChatClient.NetMessage)
        If InvokeRequired Then
            Invoke(Sub() OnMessage(sender, msg))
            Return
        End If
        If msg.Type = "otpsent" Then
            RemoveHandler client.MessageReceived, AddressOf OnMessage
            Dim otpForm As New ForgotPasswordOTPForm(Me.client, forgotEmail)
            Me.Close()
            otpForm.Show()

        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles StatusLabel.Click

    End Sub
End Class