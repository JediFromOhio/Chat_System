<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordOTPForm
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
        OTPLabel = New Label()
        ValidateButton = New Button()
        RequestOTP = New Button()
        OTPTextBox = New TextBox()
        StatusLabel = New Label()
        Panel1 = New Panel()
        HeadingLabel = New Label()
        SubLabel = New Label()
        SubLabel2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OTPLabel
        ' 
        OTPLabel.AutoSize = True
        OTPLabel.BackColor = Color.Transparent
        OTPLabel.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OTPLabel.ForeColor = Color.White
        OTPLabel.Location = New Point(32, 223)
        OTPLabel.Name = "OTPLabel"
        OTPLabel.Size = New Size(117, 19)
        OTPLabel.TabIndex = 0
        OTPLabel.Text = "ONE-TIME CODE"
        ' 
        ' ValidateButton
        ' 
        ValidateButton.BackColor = Color.Black
        ValidateButton.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ValidateButton.ForeColor = Color.White
        ValidateButton.Location = New Point(32, 351)
        ValidateButton.Margin = New Padding(3, 2, 3, 2)
        ValidateButton.Name = "ValidateButton"
        ValidateButton.Size = New Size(360, 29)
        ValidateButton.TabIndex = 2
        ValidateButton.Text = "Validate OTP"
        ValidateButton.UseVisualStyleBackColor = False
        ' 
        ' RequestOTP
        ' 
        RequestOTP.BackColor = Color.Black
        RequestOTP.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RequestOTP.ForeColor = Color.White
        RequestOTP.Location = New Point(32, 417)
        RequestOTP.Margin = New Padding(3, 2, 3, 2)
        RequestOTP.Name = "RequestOTP"
        RequestOTP.Size = New Size(360, 29)
        RequestOTP.TabIndex = 3
        RequestOTP.Text = "Request code"
        RequestOTP.UseVisualStyleBackColor = False
        ' 
        ' OTPTextBox
        ' 
        OTPTextBox.BackColor = Color.Black
        OTPTextBox.Location = New Point(32, 260)
        OTPTextBox.Margin = New Padding(3, 2, 3, 2)
        OTPTextBox.Name = "OTPTextBox"
        OTPTextBox.Size = New Size(360, 23)
        OTPTextBox.TabIndex = 4
        ' 
        ' StatusLabel
        ' 
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = Color.Transparent
        StatusLabel.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLabel.ForeColor = Color.White
        StatusLabel.Location = New Point(32, 480)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(46, 17)
        StatusLabel.TabIndex = 5
        StatusLabel.Text = "Status"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(SubLabel2)
        Panel1.Controls.Add(SubLabel)
        Panel1.Controls.Add(HeadingLabel)
        Panel1.Controls.Add(OTPTextBox)
        Panel1.Controls.Add(StatusLabel)
        Panel1.Controls.Add(RequestOTP)
        Panel1.Controls.Add(OTPLabel)
        Panel1.Controls.Add(ValidateButton)
        Panel1.Location = New Point(82, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 515)
        Panel1.TabIndex = 6
        ' 
        ' HeadingLabel
        ' 
        HeadingLabel.AutoSize = True
        HeadingLabel.BackColor = Color.Transparent
        HeadingLabel.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HeadingLabel.ForeColor = Color.White
        HeadingLabel.Location = New Point(32, 121)
        HeadingLabel.Name = "HeadingLabel"
        HeadingLabel.Size = New Size(160, 25)
        HeadingLabel.TabIndex = 6
        HeadingLabel.Text = "Check your email"
        ' 
        ' SubLabel
        ' 
        SubLabel.BackColor = Color.Transparent
        SubLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubLabel.ForeColor = Color.White
        SubLabel.Location = New Point(32, 146)
        SubLabel.Name = "SubLabel"
        SubLabel.Size = New Size(360, 65)
        SubLabel.TabIndex = 7
        SubLabel.Text = "We sent a 6-digit code to your email address. It expires in 5 minutes"
        ' 
        ' SubLabel2
        ' 
        SubLabel2.AutoSize = True
        SubLabel2.BackColor = Color.Transparent
        SubLabel2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubLabel2.ForeColor = Color.White
        SubLabel2.Location = New Point(163, 315)
        SubLabel2.Name = "SubLabel2"
        SubLabel2.Size = New Size(102, 17)
        SubLabel2.TabIndex = 8
        SubLabel2.Text = "Enter all 6 digits"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(32, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 48)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' ForgotPasswordOTPForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(604, 581)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ForgotPasswordOTPForm"
        Text = "ForgotPasswordOTPForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents OTPLabel As Label
    Friend WithEvents ValidateButton As Button
    Friend WithEvents RequestOTP As Button
    Friend WithEvents OTPTextBox As TextBox
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SubLabel2 As Label
    Friend WithEvents SubLabel As Label
    Friend WithEvents HeadingLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
