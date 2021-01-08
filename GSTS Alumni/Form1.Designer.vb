<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.backgroundPlate = New Guna.UI.WinForms.GunaGradientPanel()
        Me.percent = New Guna.UI.WinForms.GunaLabel()
        Me.started2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.started1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.letGo = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.welcome = New Guna.UI.WinForms.GunaLabel()
        Me.progressInfo = New Guna.UI.WinForms.GunaLabel()
        Me.progressLoad = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.exitBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.backgroundPlate.SuspendLayout()
        CType(Me.started2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.started1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'backgroundPlate
        '
        Me.backgroundPlate.AllowDrop = True
        Me.backgroundPlate.BackgroundImage = CType(resources.GetObject("backgroundPlate.BackgroundImage"), System.Drawing.Image)
        Me.backgroundPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backgroundPlate.Controls.Add(Me.percent)
        Me.backgroundPlate.Controls.Add(Me.started2)
        Me.backgroundPlate.Controls.Add(Me.started1)
        Me.backgroundPlate.Controls.Add(Me.letGo)
        Me.backgroundPlate.Controls.Add(Me.welcome)
        Me.backgroundPlate.Controls.Add(Me.progressInfo)
        Me.backgroundPlate.Controls.Add(Me.progressLoad)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel5)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel3)
        Me.backgroundPlate.Controls.Add(Me.exitBtn)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel4)
        Me.backgroundPlate.Controls.Add(Me.GunaPictureBox1)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel2)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel1)
        Me.backgroundPlate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backgroundPlate.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.backgroundPlate.GradientColor2 = System.Drawing.Color.White
        Me.backgroundPlate.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.backgroundPlate.GradientColor4 = System.Drawing.Color.White
        Me.backgroundPlate.Location = New System.Drawing.Point(0, 0)
        Me.backgroundPlate.Name = "backgroundPlate"
        Me.backgroundPlate.Size = New System.Drawing.Size(924, 545)
        Me.backgroundPlate.TabIndex = 2
        Me.backgroundPlate.Text = "GunaGradientPanel1"
        '
        'percent
        '
        Me.percent.AutoSize = True
        Me.percent.BackColor = System.Drawing.Color.Transparent
        Me.percent.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.percent.ForeColor = System.Drawing.Color.DarkRed
        Me.percent.Location = New System.Drawing.Point(791, 460)
        Me.percent.Name = "percent"
        Me.percent.Size = New System.Drawing.Size(65, 28)
        Me.percent.TabIndex = 17
        Me.percent.Text = "100%"
        Me.percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.percent.Visible = False
        '
        'started2
        '
        Me.started2.BackColor = System.Drawing.Color.Transparent
        Me.started2.BaseColor = System.Drawing.Color.White
        Me.started2.Image = CType(resources.GetObject("started2.Image"), System.Drawing.Image)
        Me.started2.Location = New System.Drawing.Point(317, 229)
        Me.started2.Name = "started2"
        Me.started2.Size = New System.Drawing.Size(62, 61)
        Me.started2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.started2.TabIndex = 16
        Me.started2.TabStop = False
        '
        'started1
        '
        Me.started1.BackColor = System.Drawing.Color.Transparent
        Me.started1.BaseColor = System.Drawing.Color.White
        Me.started1.Image = CType(resources.GetObject("started1.Image"), System.Drawing.Image)
        Me.started1.Location = New System.Drawing.Point(576, 229)
        Me.started1.Name = "started1"
        Me.started1.Size = New System.Drawing.Size(62, 61)
        Me.started1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.started1.TabIndex = 15
        Me.started1.TabStop = False
        '
        'letGo
        '
        Me.letGo.Animated = True
        Me.letGo.AnimationHoverSpeed = 0.19!
        Me.letGo.AnimationSpeed = 0.09!
        Me.letGo.BackColor = System.Drawing.Color.Transparent
        Me.letGo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.letGo.BorderColor = System.Drawing.Color.Transparent
        Me.letGo.BorderSize = 2
        Me.letGo.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.letGo.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.letGo.CheckedForeColor = System.Drawing.Color.White
        Me.letGo.CheckedImage = Nothing
        Me.letGo.CheckedLineColor = System.Drawing.Color.Transparent
        Me.letGo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.letGo.FocusedColor = System.Drawing.Color.Empty
        Me.letGo.Font = New System.Drawing.Font("Sriracha", 17.0!)
        Me.letGo.ForeColor = System.Drawing.Color.White
        Me.letGo.Image = Nothing
        Me.letGo.ImageSize = New System.Drawing.Size(0, 0)
        Me.letGo.LineColor = System.Drawing.Color.Transparent
        Me.letGo.Location = New System.Drawing.Point(385, 232)
        Me.letGo.Name = "letGo"
        Me.letGo.OnHoverBaseColor = System.Drawing.Color.White
        Me.letGo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.letGo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.letGo.OnHoverImage = Nothing
        Me.letGo.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.letGo.OnPressedColor = System.Drawing.Color.Maroon
        Me.letGo.Radius = 8
        Me.letGo.Size = New System.Drawing.Size(188, 51)
        Me.letGo.TabIndex = 14
        Me.letGo.Text = "Get Started !"
        Me.letGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Font = New System.Drawing.Font("Concert One", 40.0!, System.Drawing.FontStyle.Bold)
        Me.welcome.ForeColor = System.Drawing.Color.White
        Me.welcome.Location = New System.Drawing.Point(432, 102)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(332, 64)
        Me.welcome.TabIndex = 13
        Me.welcome.Text = "WELCOME TO"
        Me.welcome.Visible = False
        '
        'progressInfo
        '
        Me.progressInfo.AutoSize = True
        Me.progressInfo.BackColor = System.Drawing.Color.Transparent
        Me.progressInfo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.progressInfo.ForeColor = System.Drawing.Color.White
        Me.progressInfo.Location = New System.Drawing.Point(71, 460)
        Me.progressInfo.Name = "progressInfo"
        Me.progressInfo.Size = New System.Drawing.Size(123, 28)
        Me.progressInfo.TabIndex = 12
        Me.progressInfo.Text = "GunaLabel6"
        Me.progressInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.progressInfo.Visible = False
        '
        'progressLoad
        '
        Me.progressLoad.BackColor = System.Drawing.Color.Transparent
        Me.progressLoad.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressLoad.BorderSize = 1
        Me.progressLoad.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.progressLoad.IdleColor = System.Drawing.Color.White
        Me.progressLoad.Location = New System.Drawing.Point(70, 491)
        Me.progressLoad.Name = "progressLoad"
        Me.progressLoad.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressLoad.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressLoad.Radius = 3
        Me.progressLoad.Size = New System.Drawing.Size(786, 13)
        Me.progressLoad.TabIndex = 11
        Me.progressLoad.Visible = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Playball", 30.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(434, 19)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(194, 50)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "ALUMNI"
        Me.GunaLabel5.Visible = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Playball", 30.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(298, 19)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(121, 50)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "GSTS"
        Me.GunaLabel3.Visible = False
        '
        'exitBtn
        '
        Me.exitBtn.AnimationHoverSpeed = 0.07!
        Me.exitBtn.AnimationSpeed = 0.03!
        Me.exitBtn.BackColor = System.Drawing.Color.Transparent
        Me.exitBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitBtn.BorderColor = System.Drawing.Color.Transparent
        Me.exitBtn.BorderSize = 2
        Me.exitBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.exitBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.exitBtn.CheckedForeColor = System.Drawing.Color.White
        Me.exitBtn.CheckedImage = Nothing
        Me.exitBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exitBtn.FocusedColor = System.Drawing.Color.Empty
        Me.exitBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.White
        Me.exitBtn.Image = Nothing
        Me.exitBtn.ImageSize = New System.Drawing.Size(0, 0)
        Me.exitBtn.LineColor = System.Drawing.Color.Transparent
        Me.exitBtn.Location = New System.Drawing.Point(464, 686)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.OnHoverBaseColor = System.Drawing.Color.White
        Me.exitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitBtn.OnHoverImage = Nothing
        Me.exitBtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.exitBtn.OnPressedColor = System.Drawing.Color.Black
        Me.exitBtn.Radius = 8
        Me.exitBtn.Size = New System.Drawing.Size(75, 31)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Playball", 25.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(522, 306)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(165, 42)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "The Giants"
        Me.GunaLabel4.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(77, 85)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 2
        Me.GunaPictureBox1.TabStop = False
        Me.GunaPictureBox1.Visible = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Concert One", 40.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(383, 231)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(480, 64)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "TECHNICAL SCHOOL"
        Me.GunaLabel2.Visible = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Concert One", 40.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(383, 166)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(473, 64)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "GHANA SECONDARY"
        Me.GunaLabel1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 545)
        Me.Controls.Add(Me.backgroundPlate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.backgroundPlate.ResumeLayout(False)
        Me.backgroundPlate.PerformLayout()
        CType(Me.started2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.started1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents backgroundPlate As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents progressInfo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents progressLoad As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents exitBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents welcome As Guna.UI.WinForms.GunaLabel
    Friend WithEvents letGo As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents started2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents started1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents percent As Guna.UI.WinForms.GunaLabel
End Class
