<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserProfileForm))
        UserEmailLabel = New Label()
        ProfilePicture = New PictureBox()
        BioTextBox = New TextBox()
        BioLabel = New Label()
        StatusCmbBox = New ComboBox()
        StatusLabel = New Label()
        SaveProfileButton = New Button()
        CancelProfileButton = New Button()
        UploadAvatarButton = New Button()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UserEmailLabel
        ' 
        UserEmailLabel.Location = New Point(301, 37)
        UserEmailLabel.Name = "UserEmailLabel"
        UserEmailLabel.Size = New Size(166, 23)
        UserEmailLabel.TabIndex = 0
        UserEmailLabel.Text = "Email"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Image = CType(resources.GetObject("ProfilePicture.Image"), Image)
        ProfilePicture.Location = New Point(312, 63)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(144, 119)
        ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
        ProfilePicture.TabIndex = 1
        ProfilePicture.TabStop = False
        ' 
        ' BioTextBox
        ' 
        BioTextBox.Location = New Point(312, 236)
        BioTextBox.Multiline = True
        BioTextBox.Name = "BioTextBox"
        BioTextBox.Size = New Size(144, 23)
        BioTextBox.TabIndex = 2
        ' 
        ' BioLabel
        ' 
        BioLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BioLabel.Location = New Point(185, 236)
        BioLabel.Name = "BioLabel"
        BioLabel.Size = New Size(100, 23)
        BioLabel.TabIndex = 3
        BioLabel.Text = "Bio"
        ' 
        ' StatusCmbBox
        ' 
        StatusCmbBox.FormattingEnabled = True
        StatusCmbBox.Location = New Point(312, 297)
        StatusCmbBox.Name = "StatusCmbBox"
        StatusCmbBox.Size = New Size(144, 23)
        StatusCmbBox.TabIndex = 4
        ' 
        ' StatusLabel
        ' 
        StatusLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLabel.Location = New Point(185, 297)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(100, 23)
        StatusLabel.TabIndex = 5
        StatusLabel.Text = "Status"
        ' 
        ' SaveProfileButton
        ' 
        SaveProfileButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveProfileButton.Location = New Point(407, 369)
        SaveProfileButton.Name = "SaveProfileButton"
        SaveProfileButton.Size = New Size(109, 34)
        SaveProfileButton.TabIndex = 6
        SaveProfileButton.Text = "Save Profile"
        SaveProfileButton.UseVisualStyleBackColor = True
        ' 
        ' CancelProfileButton
        ' 
        CancelProfileButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelProfileButton.Location = New Point(252, 369)
        CancelProfileButton.Name = "CancelProfileButton"
        CancelProfileButton.Size = New Size(106, 34)
        CancelProfileButton.TabIndex = 7
        CancelProfileButton.Text = "Cancel"
        CancelProfileButton.UseVisualStyleBackColor = True
        ' 
        ' UploadAvatarButton
        ' 
        UploadAvatarButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UploadAvatarButton.Location = New Point(322, 188)
        UploadAvatarButton.Name = "UploadAvatarButton"
        UploadAvatarButton.Size = New Size(125, 29)
        UploadAvatarButton.TabIndex = 8
        UploadAvatarButton.Text = "Upload Photo"
        UploadAvatarButton.UseVisualStyleBackColor = True
        ' 
        ' UserProfileForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(UploadAvatarButton)
        Controls.Add(CancelProfileButton)
        Controls.Add(SaveProfileButton)
        Controls.Add(StatusLabel)
        Controls.Add(StatusCmbBox)
        Controls.Add(BioLabel)
        Controls.Add(BioTextBox)
        Controls.Add(ProfilePicture)
        Controls.Add(UserEmailLabel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "UserProfileForm"
        Text = "UserProfile"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserEmailLabel As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents BioTextBox As TextBox
    Friend WithEvents BioLabel As Label
    Friend WithEvents StatusCmbBox As ComboBox
    Friend WithEvents StatusLabel As Label
    Friend WithEvents SaveProfileButton As Button
    Friend WithEvents CancelProfileButton As Button
    Friend WithEvents UploadAvatarButton As Button
End Class
