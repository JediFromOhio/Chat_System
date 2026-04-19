Imports System.Text.Json
Imports System.IO

Public Class UserProfileForm
    Private ReadOnly _client As ChatClient
    Private ReadOnly _meEmail As String
    Private _currentAvatarBase64 As String = ""

    Public Sub New(client As ChatClient, meEmail As String)
        InitializeComponent()
        _client = client
        _meEmail = meEmail
        UserEmailLabel.Text = _meEmail
        StatusCmbBox.Items.AddRange({"Online", "Busy", "Away", "Offline"})
        StatusCmbBox.SelectedIndex = 0
        ThemeHelper.ApplyThemeToForm(Me, My.Settings.DarkThemeEnabled)
    End Sub

    Private Sub UploadAvatarButton_Click(sender As Object, e As EventArgs) Handles UploadAvatarButton.Click
        Using dlg As New OpenFileDialog With {
                .Filter = "Images|*.jpg;*.png;*.jpeg;*.bmp",
                .Title = "Profile Photo"
        }
            If dlg.ShowDialog() = DialogResult.OK Then
                ProfilePicture.Image = Image.FromFile(dlg.FileName)
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage

                Using ms As New MemoryStream()
                    ProfilePicture.Image.Save(ms, ProfilePicture.Image.RawFormat)
                    _currentAvatarBase64 = Convert.ToBase64String(ms.ToArray())
                End Using
            End If
        End Using
    End Sub

    Private Async Sub SaveProfileButton_Click(sender As Object, e As EventArgs) Handles SaveProfileButton.Click
        If BioTextBox.TextLength > 500 Then
            MessageBox.Show("Bio max 500 chars")
            Return
        End If
        Dim bioValue = If(String.IsNullOrEmpty(BioTextBox.Text), "", BioTextBox.Text)
        Dim statusValue = If(String.IsNullOrEmpty(StatusCmbBox.Text), "", StatusCmbBox.Text)

        Dim data As New Dictionary(Of String, JsonElement) From {
            {"bio", JsonSerializer.SerializeToElement(bioValue)},
            {"status", JsonSerializer.SerializeToElement(statusValue)}
        }
        If Not String.IsNullOrEmpty(_currentAvatarBase64) Then
            data("avatar") = JsonSerializer.SerializeToElement(_currentAvatarBase64)
        End If

        Dim msg As New ChatClient.NetMessage With {
        .Type = "profileupdate",
        .Data = data
        }
        Await _client.SendAsync(msg)
        MessageBox.Show("Profile updated!")
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelProfileButton.Click
        Me.Close()
    End Sub

    Private Async Sub UserProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg As New ChatClient.NetMessage With {.Type = "profile"}
        Await _client.SendAsync(msg)
    End Sub
End Class