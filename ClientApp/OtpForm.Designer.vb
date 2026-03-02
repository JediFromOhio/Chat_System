<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtpForm
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
        btnValidate = New Button()
        txtOTP = New TextBox()
        lblPrompt = New Label()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' btnValidate
        ' 
        btnValidate.Location = New Point(153, 287)
        btnValidate.Name = "btnValidate"
        btnValidate.Size = New Size(113, 23)
        btnValidate.TabIndex = 0
        btnValidate.Text = "Validate OTP"
        btnValidate.UseVisualStyleBackColor = True
        ' 
        ' txtOTP
        ' 
        txtOTP.Location = New Point(153, 204)
        txtOTP.Name = "txtOTP"
        txtOTP.Size = New Size(248, 23)
        txtOTP.TabIndex = 1
        ' 
        ' lblPrompt
        ' 
        lblPrompt.AutoSize = True
        lblPrompt.Location = New Point(55, 204)
        lblPrompt.Name = "lblPrompt"
        lblPrompt.Size = New Size(47, 15)
        lblPrompt.TabIndex = 2
        lblPrompt.Text = "Prompt"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(301, 287)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 23)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' OTPForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 471)
        Controls.Add(btnCancel)
        Controls.Add(lblPrompt)
        Controls.Add(txtOTP)
        Controls.Add(btnValidate)
        Name = "OTPForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OtpForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnValidate As Button
    Friend WithEvents txtOTP As TextBox
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnCancel As Button
End Class
