<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        GroupBox1 = New GroupBox()
        ForgotPasswordButton = New Button()
        statusLabel = New Label()
        btnRegister = New Button()
        btnLogin = New Button()
        passwordLabel = New Label()
        emailLabel = New Label()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        HeaderLabel = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MidnightBlue
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(HeaderLabel)
        GroupBox1.Controls.Add(ForgotPasswordButton)
        GroupBox1.Controls.Add(statusLabel)
        GroupBox1.Controls.Add(btnRegister)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(passwordLabel)
        GroupBox1.Controls.Add(emailLabel)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(70, 28)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(437, 515)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Account"
        ' 
        ' ForgotPasswordButton
        ' 
        ForgotPasswordButton.BackColor = Color.Black
        ForgotPasswordButton.Location = New Point(242, 287)
        ForgotPasswordButton.Name = "ForgotPasswordButton"
        ForgotPasswordButton.Size = New Size(153, 29)
        ForgotPasswordButton.TabIndex = 6
        ForgotPasswordButton.Text = "Forgot Password"
        ForgotPasswordButton.UseVisualStyleBackColor = False
        ' 
        ' statusLabel
        ' 
        statusLabel.AutoSize = True
        statusLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusLabel.ForeColor = Color.White
        statusLabel.Location = New Point(33, 479)
        statusLabel.Margin = New Padding(4, 0, 4, 0)
        statusLabel.Name = "statusLabel"
        statusLabel.Size = New Size(60, 20)
        statusLabel.TabIndex = 1
        statusLabel.Text = "Status : "
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Black
        btnRegister.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(135, 424)
        btnRegister.Margin = New Padding(4)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(171, 32)
        btnRegister.TabIndex = 5
        btnRegister.Text = "Create an account"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Black
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(135, 351)
        btnLogin.Margin = New Padding(4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(171, 32)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.ForeColor = Color.White
        passwordLabel.Location = New Point(33, 213)
        passwordLabel.Margin = New Padding(4, 0, 4, 0)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(79, 21)
        passwordLabel.TabIndex = 3
        passwordLabel.Text = "Password"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.ForeColor = Color.White
        emailLabel.Location = New Point(33, 145)
        emailLabel.Margin = New Padding(4, 0, 4, 0)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(48, 21)
        emailLabel.TabIndex = 2
        emailLabel.Text = "Email"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Black
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(33, 238)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(362, 29)
        txtPassword.TabIndex = 1
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Black
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(33, 170)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(362, 29)
        txtEmail.TabIndex = 0
        ' 
        ' HeaderLabel
        ' 
        HeaderLabel.Location = New Point(158, 77)
        HeaderLabel.Name = "HeaderLabel"
        HeaderLabel.Size = New Size(126, 28)
        HeaderLabel.TabIndex = 7
        HeaderLabel.Text = "Welcome Back"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(168, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(135, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 15)
        Label1.TabIndex = 9
        Label1.Text = "Sign in to continue to ChatApp"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(604, 581)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents passwordLabel As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents ForgotPasswordButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HeaderLabel As Label
End Class
