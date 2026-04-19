Imports System.Text.Json

Public Class ResetPasswordForm

    Private ReadOnly client As ChatClient
    Private ReadOnly forgotEmail As String

    Public Sub New(client As ChatClient, email As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.forgotEmail = email
        AddHandler client.MessageReceived, AddressOf OnMessage
        NewPasswordTxtBox.UseSystemPasswordChar = True
        ConfirmPasswordTxtBox.UseSystemPasswordChar = True
    End Sub

    Private Sub ResetPasswordForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RemoveHandler client.MessageReceived, AddressOf OnMessage
    End Sub
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        If NewPasswordTxtBox.Text <> ConfirmPasswordTxtBox.Text Then
            MessageBox.Show("Passwords don't match!")
            Return
        End If
        Dim msg As New ChatClient.NetMessage With {
            .Type = "resetpassword",
            .Data = New Dictionary(Of String, JsonElement) From {
                {"email", JsonSerializer.SerializeToElement(forgotEmail)},
                {"password", JsonSerializer.SerializeToElement(NewPasswordTxtBox.Text)}
            }
        }
        Await client.SendAsync(msg)
    End Sub
    Private Sub OnMessage(sender As Object, msg As ChatClient.NetMessage)
        If InvokeRequired Then
            Invoke(Sub() OnMessage(sender, msg))
            Return
        End If
        If msg.Type = "passwordreset" Then
            MessageBox.Show("Password reset! Login now.")
            Me.Close()  ' Back to LoginForm
        End If
    End Sub
    Private Sub NewPasswordLabel_Click(sender As Object, e As EventArgs) Handles NewPasswordLabel.Click

    End Sub

    Private Sub ResetPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewPasswordTxtBox_TextChanged(sender As Object, e As EventArgs) Handles NewPasswordTxtBox.TextChanged

    End Sub
End Class