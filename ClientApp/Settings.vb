Imports System.Text.Json

Public Class SettingsForm
    Private ReadOnly client As ChatClient
    Private ReadOnly meEmail As String

    Public Sub New(client As ChatClient, meEmail As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.meEmail = meEmail
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load saved values
        DarkThemeChkBox.Checked = My.Settings.DarkThemeEnabled
        NotificationsChkBox.Checked = My.Settings.NotificationsEnabled
        FontSizeCmbBox.Items.AddRange({"Small", "Medium", "Large"})
        FontSizeCmbBox.SelectedIndex = My.Settings.FontSizeIndex


        ' Preview theme on load
        ApplyCurrentTheme()
    End Sub



    Private Sub DarkThemeChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles DarkThemeChkBox.CheckedChanged
        ApplyCurrentTheme()  ' Local preview only
    End Sub

    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
        Dim profile As New UserProfileForm(client, meEmail)
        profile.ShowDialog()
    End Sub

    Private Async Sub SignOutButton_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        SaveSettings() ' still saves on signout
        client.Disconnect()

        ' Close MainChatForm, show LoginForm
        Dim mainForm As MainChatForm = TryCast(Me.Owner, MainChatForm)
        mainForm?.Close()


        'Create new client for login
        Dim newClient As New ChatClient With { ' Uses My.Settings defaults 
            .ServerIP = My.Settings.ServerIP,
            .ServerPort = My.Settings.ServerPort
        }
        Await newClient.ConnectAsync() ' Connect before loginform

        Dim loginForm As New LoginForm(newClient)
        loginForm.Show()

        Me.DialogResult = DialogResult.Abort
        Me.Close()

    End Sub

    Private Sub ApplyCurrentTheme()
        Try
            Dim isDark = DarkThemeChkBox.Checked
            Me.BackColor = If(isDark, Color.FromArgb(32, 32, 32), Color.WhiteSmoke)
            Me.ForeColor = If(isDark, Color.White, Color.DimGray)
            StyleControls(Me.Controls, isDark)

        Catch ex As Exception
            ' silent fail - keep default theme
            Debug.WriteLine("Theme error: " & ex.Message)
        End Try
    End Sub

    Private Sub StyleControls(ctrls As Control.ControlCollection, isDark As Boolean)

        For Each ctrl As Control In ctrls
            Try
                If isDark Then
                    ctrl.BackColor = Color.FromArgb(45, 45, 48)
                    ctrl.ForeColor = Color.White
                Else
                    ctrl.BackColor = Color.White
                    ctrl.ForeColor = Color.FromArgb(50, 50, 50)
                End If

                If TypeOf ctrl Is Button Then
                    Dim btn = CType(ctrl, Button)
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderSize = 0
                End If
            Catch ex As Exception
                ' skip problematic controls
            End Try

            If ctrl.HasChildren Then StyleControls(ctrl.Controls, isDark)
        Next
    End Sub

    Private Sub SaveSettings()
        Try
            My.Settings.DarkThemeEnabled = DarkThemeChkBox.Checked
            My.Settings.NotificationsEnabled = NotificationsChkBox.Checked
            My.Settings.FontSizeIndex = FontSizeCmbBox.SelectedIndex
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show("Save failed: " & ex.Message)
        End Try
    End Sub

    Private Async Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveSettings() ' Save first

        ' SAVE DB THEME (per-user!)
        Dim themeValue = If(DarkThemeChkBox.Checked, "Dark", "Light")
        Dim msg As New ChatClient.NetMessage With {
        .Type = "updatetheme",
        .Data = New Dictionary(Of String, JsonElement) From {
            {"theme", JsonSerializer.SerializeToElement(themeValue)}
        }
    }
        Await client.SendAsync(msg)
        ' Apply theme to MainChatForm immediately

        Dim mainForm As MainChatForm = TryCast(Me.Owner, MainChatForm)
        If mainForm IsNot Nothing Then
            mainForm.RefreshTheme()
        End If

        MessageBox.Show("Settings Saved! Theme applied ")
        Me.Close()
    End Sub

    Private Sub SettingsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveSettings()
    End Sub

End Class


