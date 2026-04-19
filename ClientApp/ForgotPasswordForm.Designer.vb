<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        EmailLabel = New Label()
        EmailTextbox = New TextBox()
        OTPRequestButton = New Button()
        StatusLabel = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmailLabel
        ' 
        EmailLabel.BackColor = Color.Transparent
        EmailLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmailLabel.ForeColor = Color.White
        EmailLabel.Location = New Point(22, 203)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(106, 19)
        EmailLabel.TabIndex = 0
        EmailLabel.Text = "Email Address"
        ' 
        ' EmailTextbox
        ' 
        EmailTextbox.BackColor = Color.Black
        EmailTextbox.ForeColor = Color.White
        EmailTextbox.Location = New Point(22, 241)
        EmailTextbox.Margin = New Padding(3, 2, 3, 2)
        EmailTextbox.Name = "EmailTextbox"
        EmailTextbox.Size = New Size(380, 23)
        EmailTextbox.TabIndex = 1
        ' 
        ' OTPRequestButton
        ' 
        OTPRequestButton.BackColor = Color.Black
        OTPRequestButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OTPRequestButton.ForeColor = Color.White
        OTPRequestButton.Location = New Point(54, 354)
        OTPRequestButton.Margin = New Padding(3, 2, 3, 2)
        OTPRequestButton.Name = "OTPRequestButton"
        OTPRequestButton.Size = New Size(311, 52)
        OTPRequestButton.TabIndex = 2
        OTPRequestButton.Text = "Send OTP"
        OTPRequestButton.UseVisualStyleBackColor = False
        ' 
        ' StatusLabel
        ' 
        StatusLabel.BackColor = Color.Transparent
        StatusLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLabel.ForeColor = Color.White
        StatusLabel.Location = New Point(22, 482)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(64, 23)
        StatusLabel.TabIndex = 3
        StatusLabel.Text = "Status"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(EmailLabel)
        Panel1.Controls.Add(EmailTextbox)
        Panel1.Controls.Add(OTPRequestButton)
        Panel1.Controls.Add(StatusLabel)
        Panel1.Location = New Point(77, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 515)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(22, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 51)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(22, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(380, 60)
        Label2.TabIndex = 6
        Label2.Text = "Enter the email address linked to your account and we'll send you a one-time code"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(22, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(238, 30)
        Label1.TabIndex = 5
        Label1.Text = "Forgot your password?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(22, 318)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(380, 10)
        Panel2.TabIndex = 4
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(604, 581)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ForgotPasswordForm"
        Text = "ForgotPasswordForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextbox As TextBox
    Friend WithEvents OTPRequestButton As Button
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
