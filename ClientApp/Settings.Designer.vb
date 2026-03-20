<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        SignOutButton = New Button()
        ProfileButton = New Button()
        SettingsLabel = New Label()
        DarkThemeChkBox = New CheckBox()
        NotificationsChkBox = New CheckBox()
        FontSizeCmbBox = New ComboBox()
        SaveButton = New Button()
        SuspendLayout()
        ' 
        ' SignOutButton
        ' 
        SignOutButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOutButton.Location = New Point(20, 396)
        SignOutButton.Name = "SignOutButton"
        SignOutButton.Size = New Size(99, 42)
        SignOutButton.TabIndex = 0
        SignOutButton.Text = "Sign Out"
        SignOutButton.UseVisualStyleBackColor = True
        ' 
        ' ProfileButton
        ' 
        ProfileButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileButton.Location = New Point(314, 79)
        ProfileButton.Name = "ProfileButton"
        ProfileButton.Size = New Size(137, 45)
        ProfileButton.TabIndex = 1
        ProfileButton.Text = "My Profile"
        ProfileButton.UseVisualStyleBackColor = True
        ' 
        ' SettingsLabel
        ' 
        SettingsLabel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SettingsLabel.Location = New Point(12, 9)
        SettingsLabel.Name = "SettingsLabel"
        SettingsLabel.Size = New Size(107, 33)
        SettingsLabel.TabIndex = 2
        SettingsLabel.Text = "Settings"
        ' 
        ' DarkThemeChkBox
        ' 
        DarkThemeChkBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DarkThemeChkBox.Location = New Point(314, 157)
        DarkThemeChkBox.Name = "DarkThemeChkBox"
        DarkThemeChkBox.Size = New Size(137, 35)
        DarkThemeChkBox.TabIndex = 3
        DarkThemeChkBox.Text = "Dark Theme"
        DarkThemeChkBox.UseVisualStyleBackColor = True
        ' 
        ' NotificationsChkBox
        ' 
        NotificationsChkBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NotificationsChkBox.Location = New Point(314, 223)
        NotificationsChkBox.Name = "NotificationsChkBox"
        NotificationsChkBox.Size = New Size(137, 37)
        NotificationsChkBox.TabIndex = 4
        NotificationsChkBox.Text = "Notifications"
        NotificationsChkBox.UseVisualStyleBackColor = True
        ' 
        ' FontSizeCmbBox
        ' 
        FontSizeCmbBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FontSizeCmbBox.FormattingEnabled = True
        FontSizeCmbBox.Location = New Point(314, 283)
        FontSizeCmbBox.Name = "FontSizeCmbBox"
        FontSizeCmbBox.Size = New Size(137, 29)
        FontSizeCmbBox.TabIndex = 5
        FontSizeCmbBox.Text = "Font Size"
        ' 
        ' SaveButton
        ' 
        SaveButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveButton.Location = New Point(314, 348)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(137, 36)
        SaveButton.TabIndex = 6
        SaveButton.Text = "Save Settings"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' SettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SaveButton)
        Controls.Add(FontSizeCmbBox)
        Controls.Add(NotificationsChkBox)
        Controls.Add(DarkThemeChkBox)
        Controls.Add(SettingsLabel)
        Controls.Add(ProfileButton)
        Controls.Add(SignOutButton)
        Name = "SettingsForm"
        Text = "Settings Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents SignOutButton As Button
    Friend WithEvents ProfileButton As Button
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents DarkThemeChkBox As CheckBox
    Friend WithEvents NotificationsChkBox As CheckBox
    Friend WithEvents FontSizeCmbBox As ComboBox
    Friend WithEvents SaveButton As Button
End Class
