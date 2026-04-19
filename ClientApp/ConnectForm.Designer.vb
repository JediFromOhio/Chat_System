<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConnectForm))
        lblStatus = New Label()
        lblServerIp = New Label()
        txtServerIP = New TextBox()
        txtPort = New TextBox()
        btnConnect = New Button()
        lblTitle = New Label()
        CardPanel = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        SubLabel = New Label()
        TitleLabel = New Label()
        PictureBox1 = New PictureBox()
        CardPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(25, 338)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(151, 20)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Status: not connected"
        ' 
        ' lblServerIp
        ' 
        lblServerIp.AutoSize = True
        lblServerIp.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServerIp.ForeColor = Color.White
        lblServerIp.Location = New Point(25, 190)
        lblServerIp.Name = "lblServerIp"
        lblServerIp.Size = New Size(64, 15)
        lblServerIp.TabIndex = 1
        lblServerIp.Text = "SERVER IP"
        ' 
        ' txtServerIP
        ' 
        txtServerIP.BackColor = Color.Black
        txtServerIP.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtServerIP.ForeColor = Color.White
        txtServerIP.Location = New Point(25, 224)
        txtServerIP.Name = "txtServerIP"
        txtServerIP.Size = New Size(160, 29)
        txtServerIP.TabIndex = 3
        txtServerIP.Text = "192.168.92.186"
        ' 
        ' txtPort
        ' 
        txtPort.BackColor = Color.Black
        txtPort.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPort.ForeColor = Color.White
        txtPort.Location = New Point(305, 226)
        txtPort.Name = "txtPort"
        txtPort.Size = New Size(97, 27)
        txtPort.TabIndex = 4
        txtPort.Text = "5000"
        ' 
        ' btnConnect
        ' 
        btnConnect.BackColor = Color.Black
        btnConnect.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConnect.ForeColor = Color.White
        btnConnect.Location = New Point(25, 392)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(377, 52)
        btnConnect.TabIndex = 5
        btnConnect.Text = "->  Connect"
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(305, 190)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(38, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "PORT"
        ' 
        ' CardPanel
        ' 
        CardPanel.BackColor = Color.MidnightBlue
        CardPanel.Controls.Add(Label1)
        CardPanel.Controls.Add(Panel1)
        CardPanel.Controls.Add(SubLabel)
        CardPanel.Controls.Add(lblStatus)
        CardPanel.Controls.Add(btnConnect)
        CardPanel.Controls.Add(lblTitle)
        CardPanel.Controls.Add(TitleLabel)
        CardPanel.Controls.Add(txtPort)
        CardPanel.Controls.Add(lblServerIp)
        CardPanel.Controls.Add(PictureBox1)
        CardPanel.Controls.Add(txtServerIP)
        CardPanel.Location = New Point(94, 35)
        CardPanel.Name = "CardPanel"
        CardPanel.Size = New Size(437, 515)
        CardPanel.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(25, 476)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 20)
        Label1.TabIndex = 7
        Label1.Text = "Make sure the server is running before connecting"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(25, 291)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(377, 10)
        Panel1.TabIndex = 9
        ' 
        ' SubLabel
        ' 
        SubLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubLabel.ForeColor = Color.White
        SubLabel.Location = New Point(25, 146)
        SubLabel.Name = "SubLabel"
        SubLabel.Size = New Size(318, 44)
        SubLabel.TabIndex = 8
        SubLabel.Text = "Enter the address of your ChatApp server to get started."
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TitleLabel.ForeColor = Color.White
        TitleLabel.Location = New Point(25, 116)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(186, 30)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "Connect to server"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 59)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ConnectForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        CancelButton = btnConnect
        ClientSize = New Size(604, 581)
        Controls.Add(CardPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlDarkDark
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "ConnectForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Connect to Server"
        CardPanel.ResumeLayout(False)
        CardPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblServerIp As Label
    Friend WithEvents txtServerIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents CardPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SubLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label

End Class
