<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPasswordForm
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
        NewPasswordLabel = New Label()
        NewPasswordTxtBox = New TextBox()
        ConfirmPasswordTxtBox = New TextBox()
        ConfirmPasswordLabel = New Label()
        ResetPasswordButton = New Button()
        Panel1 = New Panel()
        HeaderLabel = New Label()
        SubLabel = New Label()
        StatusLabel = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NewPasswordLabel
        ' 
        NewPasswordLabel.AutoSize = True
        NewPasswordLabel.BackColor = Color.Transparent
        NewPasswordLabel.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NewPasswordLabel.ForeColor = Color.White
        NewPasswordLabel.Location = New Point(34, 192)
        NewPasswordLabel.Name = "NewPasswordLabel"
        NewPasswordLabel.Size = New Size(101, 19)
        NewPasswordLabel.TabIndex = 0
        NewPasswordLabel.Text = "New Password"
        ' 
        ' NewPasswordTxtBox
        ' 
        NewPasswordTxtBox.BackColor = Color.Black
        NewPasswordTxtBox.ForeColor = Color.White
        NewPasswordTxtBox.Location = New Point(35, 230)
        NewPasswordTxtBox.Margin = New Padding(3, 2, 3, 2)
        NewPasswordTxtBox.Name = "NewPasswordTxtBox"
        NewPasswordTxtBox.Size = New Size(348, 23)
        NewPasswordTxtBox.TabIndex = 1
        ' 
        ' ConfirmPasswordTxtBox
        ' 
        ConfirmPasswordTxtBox.BackColor = Color.Black
        ConfirmPasswordTxtBox.ForeColor = Color.White
        ConfirmPasswordTxtBox.Location = New Point(34, 335)
        ConfirmPasswordTxtBox.Margin = New Padding(3, 2, 3, 2)
        ConfirmPasswordTxtBox.Name = "ConfirmPasswordTxtBox"
        ConfirmPasswordTxtBox.Size = New Size(349, 23)
        ConfirmPasswordTxtBox.TabIndex = 2
        ' 
        ' ConfirmPasswordLabel
        ' 
        ConfirmPasswordLabel.AutoSize = True
        ConfirmPasswordLabel.BackColor = Color.Transparent
        ConfirmPasswordLabel.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConfirmPasswordLabel.ForeColor = Color.White
        ConfirmPasswordLabel.Location = New Point(35, 281)
        ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        ConfirmPasswordLabel.Size = New Size(123, 19)
        ConfirmPasswordLabel.TabIndex = 3
        ConfirmPasswordLabel.Text = "Confirm Password"
        ' 
        ' ResetPasswordButton
        ' 
        ResetPasswordButton.BackColor = Color.Black
        ResetPasswordButton.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetPasswordButton.ForeColor = Color.White
        ResetPasswordButton.Location = New Point(154, 428)
        ResetPasswordButton.Margin = New Padding(3, 2, 3, 2)
        ResetPasswordButton.Name = "ResetPasswordButton"
        ResetPasswordButton.Size = New Size(122, 30)
        ResetPasswordButton.TabIndex = 4
        ResetPasswordButton.Text = "Reset Password"
        ResetPasswordButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(StatusLabel)
        Panel1.Controls.Add(SubLabel)
        Panel1.Controls.Add(HeaderLabel)
        Panel1.Controls.Add(ResetPasswordButton)
        Panel1.Controls.Add(ConfirmPasswordTxtBox)
        Panel1.Controls.Add(ConfirmPasswordLabel)
        Panel1.Controls.Add(NewPasswordTxtBox)
        Panel1.Controls.Add(NewPasswordLabel)
        Panel1.Location = New Point(90, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 517)
        Panel1.TabIndex = 5
        ' 
        ' HeaderLabel
        ' 
        HeaderLabel.BackColor = Color.Transparent
        HeaderLabel.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeaderLabel.ForeColor = Color.White
        HeaderLabel.Location = New Point(34, 92)
        HeaderLabel.Name = "HeaderLabel"
        HeaderLabel.Size = New Size(205, 37)
        HeaderLabel.TabIndex = 5
        HeaderLabel.Text = "Set a new password"
        ' 
        ' SubLabel
        ' 
        SubLabel.AutoSize = True
        SubLabel.BackColor = Color.Transparent
        SubLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubLabel.ForeColor = Color.White
        SubLabel.Location = New Point(35, 129)
        SubLabel.Name = "SubLabel"
        SubLabel.Size = New Size(348, 17)
        SubLabel.TabIndex = 6
        SubLabel.Text = "Choose something strong. It must be at least 6 characters."
        ' 
        ' StatusLabel
        ' 
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = Color.Transparent
        StatusLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StatusLabel.ForeColor = Color.White
        StatusLabel.Location = New Point(34, 484)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(268, 17)
        StatusLabel.TabIndex = 7
        StatusLabel.Text = "Status: OTP verified - set your new password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(34, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 50)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' ResetPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(604, 581)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ResetPasswordForm"
        Text = "ResetPasswordForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents NewPasswordLabel As Label
    Friend WithEvents NewPasswordTxtBox As TextBox
    Friend WithEvents ConfirmPasswordTxtBox As TextBox
    Friend WithEvents ConfirmPasswordLabel As Label
    Friend WithEvents ResetPasswordButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusLabel As Label
    Friend WithEvents SubLabel As Label
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
