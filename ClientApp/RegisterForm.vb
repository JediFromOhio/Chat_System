Imports System.Text.Json

Public Class RegisterForm

    Private ReadOnly _client As ChatClient

    Public Sub New(client As ChatClient)
        InitializeComponent()
        _client = client
    End Sub

    Private Async Sub createAccountbutton_Click(sender As Object, e As EventArgs) Handles createAccountbutton.Click
        Dim email = txtEmail.Text.Trim().ToLowerInvariant()
        Dim password = txtPassword.Text
        Dim confirmPassword = txtConfirmPassword.Text

        ' Validation
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Email and password required", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not email.Contains("@") OrElse Not email.Contains(".") Then
            MessageBox.Show("Enter valid email", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords don't match", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password must be 6+ characters", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Send register request
        Dim msg As New ChatClient.NetMessage With {.Type = "register"}
        msg.Data("email") = JsonDocument.Parse($"""{email.Replace("""", "")}""").RootElement
        msg.Data("password") = JsonDocument.Parse($"""{password.Replace("""", "")}""").RootElement

        Await _client.SendAsync(msg)
        MessageBox.Show("Check your email for OTP! Close this form and click 'Enter OTP' on LoginForm.", "OTP Sent")

        ' DIRECTLY open OTPForm after register request
        Dim otpForm As New OTPForm(_client)
        Dim result = otpForm.ShowDialog()

        If result = DialogResult.OK Then
            MessageBox.Show("Account activated! Close this and login.", "Success")
        End If
    End Sub

End Class
