<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        txtEmail = New TextBox()
        accountCreationBox = New GroupBox()
        confirmPasswordlabel = New Label()
        passwordLabel = New Label()
        emailLabel = New Label()
        createAccountbutton = New Button()
        txtConfirmPassword = New TextBox()
        txtPassword = New TextBox()
        accountCreationBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(121, 94)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(369, 23)
        txtEmail.TabIndex = 0
        ' 
        ' accountCreationBox
        ' 
        accountCreationBox.Controls.Add(confirmPasswordlabel)
        accountCreationBox.Controls.Add(passwordLabel)
        accountCreationBox.Controls.Add(emailLabel)
        accountCreationBox.Controls.Add(createAccountbutton)
        accountCreationBox.Controls.Add(txtConfirmPassword)
        accountCreationBox.Controls.Add(txtPassword)
        accountCreationBox.Controls.Add(txtEmail)
        accountCreationBox.Location = New Point(139, 76)
        accountCreationBox.Name = "accountCreationBox"
        accountCreationBox.Size = New Size(504, 427)
        accountCreationBox.TabIndex = 1
        accountCreationBox.TabStop = False
        accountCreationBox.Text = "Account Creation"
        ' 
        ' confirmPasswordlabel
        ' 
        confirmPasswordlabel.AutoSize = True
        confirmPasswordlabel.Location = New Point(11, 236)
        confirmPasswordlabel.Name = "confirmPasswordlabel"
        confirmPasswordlabel.Size = New Size(104, 15)
        confirmPasswordlabel.TabIndex = 6
        confirmPasswordlabel.Text = "Confirm Password"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(11, 175)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(57, 15)
        passwordLabel.TabIndex = 5
        passwordLabel.Text = "Password"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(11, 97)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(36, 15)
        emailLabel.TabIndex = 4
        emailLabel.Text = "Email"
        ' 
        ' createAccountbutton
        ' 
        createAccountbutton.Location = New Point(175, 337)
        createAccountbutton.Name = "createAccountbutton"
        createAccountbutton.Size = New Size(146, 32)
        createAccountbutton.TabIndex = 3
        createAccountbutton.Text = "Create Account"
        createAccountbutton.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(121, 233)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(275, 23)
        txtConfirmPassword.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(121, 172)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(275, 23)
        txtPassword.TabIndex = 1
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 617)
        Controls.Add(accountCreationBox)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        accountCreationBox.ResumeLayout(False)
        accountCreationBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents accountCreationBox As GroupBox
    Friend WithEvents createAccountbutton As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents confirmPasswordlabel As Label


End Class
