Imports System.Text.Json

Public Class OTPForm

    Private ReadOnly _client As ChatClient

    Public Sub New(client As ChatClient)
        InitializeComponent()
        _client = client
        txtOTP.MaxLength = 6
    End Sub

    Private Async Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim otp = txtOTP.Text.Trim()

        If otp.Length <> 6 OrElse Not IsNumeric(otp) Then
            MessageBox.Show("Enter 6-digit OTP", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim msg As New ChatClient.NetMessage With {.Type = "verify_otp"}
        msg.Data("otp") = JsonDocument.Parse($"""{otp}""").RootElement

        Await _client.SendAsync(msg)

        ' Wait briefly for server response, then check LoginForm status
        Await Task.Delay(500)
        Me.DialogResult = DialogResult.OK  ' Success signal
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Digits only
    Private Sub txtOTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOTP.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub lblPrompt_Click(sender As Object, e As EventArgs) Handles lblPrompt.Click

    End Sub
End Class
