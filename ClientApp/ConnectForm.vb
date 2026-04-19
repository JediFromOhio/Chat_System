Public Class ConnectForm

    Private chatClient1 As New ChatClient

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler chatClient1.Connected, AddressOf OnConnected
        AddHandler chatClient1.ErrorOccurred, AddressOf OnError

        txtServerIP.Text = My.Settings.ServerIP  ' YOUR SERVER IP
        txtPort.Text = My.Settings.ServerPort.ToString()
        lblStatus.Text = "Status: Not connected"
    End Sub

    Private Async Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        lblStatus.Text = "Status: Connecting..."

        ' SAVE SETTINGS FIRST
        My.Settings.ServerIP = txtServerIP.Text
        My.Settings.ServerPort = CInt(txtPort.Text)
        My.Settings.Save() ' CRITICAL - persists!

        Dim port As Integer
        If Integer.TryParse(txtPort.Text, port) Then
            chatClient1.ServerPort = port
        End If

        Await chatClient1.ConnectAsync()
    End Sub

    Private Sub OnConnected(sender As Object, e As EventArgs)

        If InvokeRequired Then
            Invoke(Sub() OnConnected(sender, e))
            Return
        End If

        lblStatus.Text = "Status: Connected ✓"
        btnConnect.Text = "Connected"
        btnConnect.Enabled = False

        ' Show LoginForm and reuse this connected ChatClient
        Dim login As New LoginForm(chatClient1)
        AddHandler login.FormClosed, Sub()
                                         ' If login is closed, show connect form again
                                         Me.Show()
                                         btnConnect.Enabled = True
                                         btnConnect.Text = "Connect"
                                     End Sub

        login.Show()
        Me.Hide()

    End Sub


    Private Sub OnError(sender As Object, errorMsg As String)
        If InvokeRequired Then
            Invoke(Sub() OnError(sender, errorMsg))
            Return
        End If
        lblStatus.Text = $"Error: {errorMsg}"
    End Sub

    Private Sub txtServerIP_TextChanged(sender As Object, e As EventArgs) Handles txtServerIP.TextChanged

    End Sub
End Class