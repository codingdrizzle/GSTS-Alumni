<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.backgroundPlate = New Guna.UI.WinForms.GunaGradientPanel()
        Me.loginAgain = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.signUpBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.closeBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.signUpPlate = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.viewPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.generateID = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ID = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.actualSignup = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.passwordMessage = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.yearGroup = New System.Windows.Forms.ComboBox()
        Me.newPassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.newUsername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.fullName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.loginPlate = New Guna.UI.WinForms.GunaGroupBox()
        Me.loadUp = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.CheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.passMessage = New Guna.UI.WinForms.GunaLabel()
        Me.passwordTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.usernameTextBox = New Guna.UI.WinForms.GunaLineTextBox()
        Me.loginBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.backgroundPlate.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signUpPlate.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginPlate.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backgroundPlate
        '
        Me.backgroundPlate.AllowDrop = True
        Me.backgroundPlate.BackgroundImage = CType(resources.GetObject("backgroundPlate.BackgroundImage"), System.Drawing.Image)
        Me.backgroundPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backgroundPlate.Controls.Add(Me.loginAgain)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel5)
        Me.backgroundPlate.Controls.Add(Me.signUpBtn)
        Me.backgroundPlate.Controls.Add(Me.closeBtn)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel4)
        Me.backgroundPlate.Controls.Add(Me.GunaPictureBox1)
        Me.backgroundPlate.Controls.Add(Me.signUpPlate)
        Me.backgroundPlate.Controls.Add(Me.loginPlate)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel2)
        Me.backgroundPlate.Controls.Add(Me.GunaLabel1)
        Me.backgroundPlate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backgroundPlate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backgroundPlate.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.backgroundPlate.GradientColor2 = System.Drawing.Color.White
        Me.backgroundPlate.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.backgroundPlate.GradientColor4 = System.Drawing.Color.White
        Me.backgroundPlate.Location = New System.Drawing.Point(0, 0)
        Me.backgroundPlate.Name = "backgroundPlate"
        Me.backgroundPlate.Size = New System.Drawing.Size(568, 767)
        Me.backgroundPlate.TabIndex = 1
        Me.backgroundPlate.Text = "GunaGradientPanel1"
        '
        'loginAgain
        '
        Me.loginAgain.AnimationHoverSpeed = 0.07!
        Me.loginAgain.AnimationSpeed = 0.03!
        Me.loginAgain.BackColor = System.Drawing.Color.Transparent
        Me.loginAgain.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginAgain.BorderColor = System.Drawing.Color.Transparent
        Me.loginAgain.BorderSize = 1
        Me.loginAgain.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.loginAgain.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.loginAgain.CheckedForeColor = System.Drawing.Color.White
        Me.loginAgain.CheckedImage = Nothing
        Me.loginAgain.CheckedLineColor = System.Drawing.Color.Transparent
        Me.loginAgain.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginAgain.FocusedColor = System.Drawing.Color.Empty
        Me.loginAgain.Font = New System.Drawing.Font("Sriracha", 12.0!)
        Me.loginAgain.ForeColor = System.Drawing.Color.White
        Me.loginAgain.Image = Nothing
        Me.loginAgain.ImageSize = New System.Drawing.Size(0, 0)
        Me.loginAgain.LineColor = System.Drawing.Color.Transparent
        Me.loginAgain.Location = New System.Drawing.Point(428, 718)
        Me.loginAgain.Name = "loginAgain"
        Me.loginAgain.OnHoverBaseColor = System.Drawing.Color.White
        Me.loginAgain.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginAgain.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginAgain.OnHoverImage = Nothing
        Me.loginAgain.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.loginAgain.OnPressedColor = System.Drawing.Color.Maroon
        Me.loginAgain.OnPressedDepth = 15
        Me.loginAgain.Radius = 8
        Me.loginAgain.Size = New System.Drawing.Size(86, 31)
        Me.loginAgain.TabIndex = 16
        Me.loginAgain.Text = "Login"
        Me.loginAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(406, 700)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(150, 15)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "Don't have a Giant account"
        '
        'signUpBtn
        '
        Me.signUpBtn.AnimationHoverSpeed = 0.07!
        Me.signUpBtn.AnimationSpeed = 0.03!
        Me.signUpBtn.BackColor = System.Drawing.Color.Transparent
        Me.signUpBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.signUpBtn.BorderColor = System.Drawing.Color.Transparent
        Me.signUpBtn.BorderSize = 1
        Me.signUpBtn.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.signUpBtn.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.signUpBtn.CheckedForeColor = System.Drawing.Color.White
        Me.signUpBtn.CheckedImage = Nothing
        Me.signUpBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.signUpBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.signUpBtn.FocusedColor = System.Drawing.Color.Empty
        Me.signUpBtn.Font = New System.Drawing.Font("Sriracha", 12.0!)
        Me.signUpBtn.ForeColor = System.Drawing.Color.White
        Me.signUpBtn.Image = Nothing
        Me.signUpBtn.ImageSize = New System.Drawing.Size(0, 0)
        Me.signUpBtn.LineColor = System.Drawing.Color.Transparent
        Me.signUpBtn.Location = New System.Drawing.Point(428, 718)
        Me.signUpBtn.Name = "signUpBtn"
        Me.signUpBtn.OnHoverBaseColor = System.Drawing.Color.White
        Me.signUpBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.signUpBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.signUpBtn.OnHoverImage = Nothing
        Me.signUpBtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.signUpBtn.OnPressedColor = System.Drawing.Color.Maroon
        Me.signUpBtn.OnPressedDepth = 15
        Me.signUpBtn.Radius = 8
        Me.signUpBtn.Size = New System.Drawing.Size(86, 31)
        Me.signUpBtn.TabIndex = 7
        Me.signUpBtn.Text = "SignUp"
        Me.signUpBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'closeBtn
        '
        Me.closeBtn.AnimationHoverSpeed = 0.07!
        Me.closeBtn.AnimationSpeed = 0.03!
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeBtn.BorderColor = System.Drawing.Color.Transparent
        Me.closeBtn.BorderSize = 1
        Me.closeBtn.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.closeBtn.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.closeBtn.CheckedForeColor = System.Drawing.Color.White
        Me.closeBtn.CheckedImage = Nothing
        Me.closeBtn.CheckedLineColor = System.Drawing.Color.Transparent
        Me.closeBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.closeBtn.FocusedColor = System.Drawing.Color.Empty
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.Image = Nothing
        Me.closeBtn.ImageSize = New System.Drawing.Size(0, 0)
        Me.closeBtn.LineColor = System.Drawing.Color.Transparent
        Me.closeBtn.Location = New System.Drawing.Point(519, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.OnHoverBaseColor = System.Drawing.Color.White
        Me.closeBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeBtn.OnHoverImage = Nothing
        Me.closeBtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.closeBtn.OnPressedColor = System.Drawing.Color.Maroon
        Me.closeBtn.OnPressedDepth = 15
        Me.closeBtn.Size = New System.Drawing.Size(37, 35)
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.Text = "X"
        Me.closeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Playball", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(314, 151)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(111, 28)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "The Giants"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(30, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(190, 190)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 2
        Me.GunaPictureBox1.TabStop = False
        '
        'signUpPlate
        '
        Me.signUpPlate.BackColor = System.Drawing.Color.Transparent
        Me.signUpPlate.BaseColor = System.Drawing.Color.White
        Me.signUpPlate.BorderColor = System.Drawing.Color.White
        Me.signUpPlate.BorderSize = 1
        Me.signUpPlate.Controls.Add(Me.GunaLabel15)
        Me.signUpPlate.Controls.Add(Me.GunaLabel14)
        Me.signUpPlate.Controls.Add(Me.GunaLabel13)
        Me.signUpPlate.Controls.Add(Me.viewPassword)
        Me.signUpPlate.Controls.Add(Me.generateID)
        Me.signUpPlate.Controls.Add(Me.ID)
        Me.signUpPlate.Controls.Add(Me.GunaLabel10)
        Me.signUpPlate.Controls.Add(Me.GunaAdvenceButton2)
        Me.signUpPlate.Controls.Add(Me.actualSignup)
        Me.signUpPlate.Controls.Add(Me.passwordMessage)
        Me.signUpPlate.Controls.Add(Me.GunaLabel9)
        Me.signUpPlate.Controls.Add(Me.yearGroup)
        Me.signUpPlate.Controls.Add(Me.newPassword)
        Me.signUpPlate.Controls.Add(Me.newUsername)
        Me.signUpPlate.Controls.Add(Me.fullName)
        Me.signUpPlate.Controls.Add(Me.GunaLabel8)
        Me.signUpPlate.Controls.Add(Me.GunaLabel7)
        Me.signUpPlate.Controls.Add(Me.GunaCirclePictureBox2)
        Me.signUpPlate.Controls.Add(Me.GunaLabel6)
        Me.signUpPlate.LineColor = System.Drawing.Color.Transparent
        Me.signUpPlate.Location = New System.Drawing.Point(91, 214)
        Me.signUpPlate.Name = "signUpPlate"
        Me.signUpPlate.Radius = 20
        Me.signUpPlate.Size = New System.Drawing.Size(367, 482)
        Me.signUpPlate.TabIndex = 15
        Me.signUpPlate.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel15.Location = New System.Drawing.Point(43, 256)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(76, 21)
        Me.GunaLabel15.TabIndex = 31
        Me.GunaLabel15.Text = "Password"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel14.Location = New System.Drawing.Point(43, 213)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(81, 21)
        Me.GunaLabel14.TabIndex = 30
        Me.GunaLabel14.Text = "Username"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel13.Location = New System.Drawing.Point(43, 174)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(81, 21)
        Me.GunaLabel13.TabIndex = 29
        Me.GunaLabel13.Text = "Full Name"
        '
        'viewPassword
        '
        Me.viewPassword.BaseColor = System.Drawing.Color.Transparent
        Me.viewPassword.CheckedOffColor = System.Drawing.Color.Maroon
        Me.viewPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.viewPassword.FillColor = System.Drawing.Color.White
        Me.viewPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.viewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.viewPassword.Location = New System.Drawing.Point(148, 290)
        Me.viewPassword.Name = "viewPassword"
        Me.viewPassword.Size = New System.Drawing.Size(104, 20)
        Me.viewPassword.TabIndex = 28
        Me.viewPassword.Text = "show password"
        '
        'generateID
        '
        Me.generateID.Animated = True
        Me.generateID.AnimationHoverSpeed = 0.07!
        Me.generateID.AnimationSpeed = 0.03!
        Me.generateID.BackColor = System.Drawing.Color.Transparent
        Me.generateID.BaseColor = System.Drawing.Color.White
        Me.generateID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.generateID.BorderSize = 1
        Me.generateID.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.generateID.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.generateID.CheckedForeColor = System.Drawing.Color.White
        Me.generateID.CheckedImage = Nothing
        Me.generateID.CheckedLineColor = System.Drawing.Color.Transparent
        Me.generateID.DialogResult = System.Windows.Forms.DialogResult.None
        Me.generateID.Enabled = False
        Me.generateID.FocusedColor = System.Drawing.Color.Empty
        Me.generateID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.generateID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.generateID.Image = Nothing
        Me.generateID.ImageSize = New System.Drawing.Size(0, 0)
        Me.generateID.LineColor = System.Drawing.Color.Transparent
        Me.generateID.Location = New System.Drawing.Point(152, 361)
        Me.generateID.Name = "generateID"
        Me.generateID.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.generateID.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.generateID.OnHoverForeColor = System.Drawing.Color.White
        Me.generateID.OnHoverImage = Nothing
        Me.generateID.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.generateID.OnPressedColor = System.Drawing.Color.Maroon
        Me.generateID.OnPressedDepth = 15
        Me.generateID.Size = New System.Drawing.Size(72, 21)
        Me.generateID.TabIndex = 27
        Me.generateID.Text = "Generate ID"
        Me.generateID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ID.ForeColor = System.Drawing.Color.White
        Me.ID.Location = New System.Drawing.Point(228, 361)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(25, 21)
        Me.ID.TabIndex = 26
        Me.ID.Text = "ID"
        Me.ID.Visible = False
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel10.Location = New System.Drawing.Point(40, 359)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(66, 21)
        Me.GunaLabel10.TabIndex = 25
        Me.GunaLabel10.Text = "Giant ID"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BorderSize = 1
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(273, 0)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Maroon
        Me.GunaAdvenceButton2.OnPressedDepth = 15
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(96, 23)
        Me.GunaAdvenceButton2.TabIndex = 21
        Me.GunaAdvenceButton2.Text = "Back to Login"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'actualSignup
        '
        Me.actualSignup.AnimationHoverSpeed = 0.07!
        Me.actualSignup.AnimationSpeed = 0.03!
        Me.actualSignup.BackColor = System.Drawing.Color.Transparent
        Me.actualSignup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.actualSignup.BorderColor = System.Drawing.Color.Transparent
        Me.actualSignup.BorderSize = 1
        Me.actualSignup.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.actualSignup.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.actualSignup.CheckedForeColor = System.Drawing.Color.White
        Me.actualSignup.CheckedImage = Nothing
        Me.actualSignup.CheckedLineColor = System.Drawing.Color.Transparent
        Me.actualSignup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.actualSignup.FocusedColor = System.Drawing.Color.Empty
        Me.actualSignup.Font = New System.Drawing.Font("Sriracha", 12.0!)
        Me.actualSignup.ForeColor = System.Drawing.Color.White
        Me.actualSignup.Image = Nothing
        Me.actualSignup.ImageSize = New System.Drawing.Size(0, 0)
        Me.actualSignup.LineColor = System.Drawing.Color.Transparent
        Me.actualSignup.Location = New System.Drawing.Point(132, 414)
        Me.actualSignup.Name = "actualSignup"
        Me.actualSignup.OnHoverBaseColor = System.Drawing.Color.White
        Me.actualSignup.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.actualSignup.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.actualSignup.OnHoverImage = Nothing
        Me.actualSignup.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.actualSignup.OnPressedColor = System.Drawing.Color.Maroon
        Me.actualSignup.OnPressedDepth = 15
        Me.actualSignup.Radius = 8
        Me.actualSignup.Size = New System.Drawing.Size(104, 43)
        Me.actualSignup.TabIndex = 20
        Me.actualSignup.Text = "SignUp"
        Me.actualSignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordMessage
        '
        Me.passwordMessage.AutoSize = True
        Me.passwordMessage.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.passwordMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.passwordMessage.Location = New System.Drawing.Point(114, 278)
        Me.passwordMessage.Name = "passwordMessage"
        Me.passwordMessage.Size = New System.Drawing.Size(196, 12)
        Me.passwordMessage.TabIndex = 17
        Me.passwordMessage.Text = "Password must be at least 6 characters long"
        Me.passwordMessage.Visible = False
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel9.Location = New System.Drawing.Point(7, 320)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(146, 21)
        Me.GunaLabel9.TabIndex = 16
        Me.GunaLabel9.Text = "Year Of Completion"
        '
        'yearGroup
        '
        Me.yearGroup.AutoCompleteCustomSource.AddRange(New String() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909"})
        Me.yearGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.yearGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.yearGroup.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.yearGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.yearGroup.FormatString = "N0"
        Me.yearGroup.FormattingEnabled = True
        Me.yearGroup.Items.AddRange(New Object() {"1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.yearGroup.Location = New System.Drawing.Point(154, 322)
        Me.yearGroup.MaxDropDownItems = 6
        Me.yearGroup.Name = "yearGroup"
        Me.yearGroup.Size = New System.Drawing.Size(126, 23)
        Me.yearGroup.Sorted = True
        Me.yearGroup.TabIndex = 15
        Me.yearGroup.Text = "Year Group"
        '
        'newPassword
        '
        Me.newPassword.Animated = True
        Me.newPassword.BackColor = System.Drawing.Color.White
        Me.newPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newPassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.newPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.newPassword.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.newPassword.LineColor = System.Drawing.Color.Silver
        Me.newPassword.Location = New System.Drawing.Point(126, 239)
        Me.newPassword.MaxLength = 12
        Me.newPassword.Name = "newPassword"
        Me.newPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.newPassword.Size = New System.Drawing.Size(155, 37)
        Me.newPassword.TabIndex = 14
        Me.newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.newPassword.UseSystemPasswordChar = True
        '
        'newUsername
        '
        Me.newUsername.Animated = True
        Me.newUsername.BackColor = System.Drawing.Color.White
        Me.newUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newUsername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.newUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.newUsername.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.newUsername.LineColor = System.Drawing.Color.Silver
        Me.newUsername.Location = New System.Drawing.Point(126, 198)
        Me.newUsername.Name = "newUsername"
        Me.newUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newUsername.Size = New System.Drawing.Size(155, 37)
        Me.newUsername.TabIndex = 13
        Me.newUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fullName
        '
        Me.fullName.Animated = True
        Me.fullName.BackColor = System.Drawing.Color.White
        Me.fullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fullName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fullName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.fullName.LineColor = System.Drawing.Color.Silver
        Me.fullName.Location = New System.Drawing.Point(125, 158)
        Me.fullName.Name = "fullName"
        Me.fullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullName.Size = New System.Drawing.Size(155, 37)
        Me.fullName.TabIndex = 12
        Me.fullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Concert One", 12.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel8.Location = New System.Drawing.Point(94, 130)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(178, 19)
        Me.GunaLabel8.TabIndex = 8
        Me.GunaLabel8.Text = "Provide user credentials"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Sriracha", 20.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(138, 69)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(190, 48)
        Me.GunaLabel7.TabIndex = 7
        Me.GunaLabel7.Text = "Giant Account"
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(7, 11)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(129, 121)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 6
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Sriracha", 20.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(146, 26)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(161, 48)
        Me.GunaLabel6.TabIndex = 4
        Me.GunaLabel6.Text = "Create your"
        '
        'loginPlate
        '
        Me.loginPlate.BackColor = System.Drawing.Color.Transparent
        Me.loginPlate.BaseColor = System.Drawing.Color.Transparent
        Me.loginPlate.BorderColor = System.Drawing.Color.White
        Me.loginPlate.BorderSize = 1
        Me.loginPlate.Controls.Add(Me.loadUp)
        Me.loginPlate.Controls.Add(Me.GunaLabel12)
        Me.loginPlate.Controls.Add(Me.GunaLabel11)
        Me.loginPlate.Controls.Add(Me.CheckBox1)
        Me.loginPlate.Controls.Add(Me.passMessage)
        Me.loginPlate.Controls.Add(Me.passwordTextBox)
        Me.loginPlate.Controls.Add(Me.usernameTextBox)
        Me.loginPlate.Controls.Add(Me.loginBtn)
        Me.loginPlate.Controls.Add(Me.GunaCirclePictureBox1)
        Me.loginPlate.Controls.Add(Me.GunaLabel3)
        Me.loginPlate.LineColor = System.Drawing.Color.Transparent
        Me.loginPlate.Location = New System.Drawing.Point(124, 229)
        Me.loginPlate.Name = "loginPlate"
        Me.loginPlate.Radius = 20
        Me.loginPlate.Size = New System.Drawing.Size(312, 460)
        Me.loginPlate.TabIndex = 3
        Me.loginPlate.TextLocation = New System.Drawing.Point(10, 8)
        '
        'loadUp
        '
        Me.loadUp.BackColor = System.Drawing.Color.Transparent
        Me.loadUp.BorderColor = System.Drawing.Color.Maroon
        Me.loadUp.BorderSize = 1
        Me.loadUp.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition
        Me.loadUp.IdleColor = System.Drawing.Color.Transparent
        Me.loadUp.Location = New System.Drawing.Point(99, 430)
        Me.loadUp.Name = "loadUp"
        Me.loadUp.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loadUp.ProgressMinColor = System.Drawing.Color.Maroon
        Me.loadUp.Radius = 4
        Me.loadUp.Size = New System.Drawing.Size(113, 10)
        Me.loadUp.TabIndex = 17
        Me.loadUp.Visible = False
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel12.Font = New System.Drawing.Font("Sriracha", 13.0!)
        Me.GunaLabel12.ForeColor = System.Drawing.Color.White
        Me.GunaLabel12.Location = New System.Drawing.Point(109, 264)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(88, 32)
        Me.GunaLabel12.TabIndex = 24
        Me.GunaLabel12.Text = "Password"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Sriracha", 13.0!)
        Me.GunaLabel11.ForeColor = System.Drawing.Color.White
        Me.GunaLabel11.Location = New System.Drawing.Point(109, 194)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(93, 32)
        Me.GunaLabel11.TabIndex = 23
        Me.GunaLabel11.Text = "Username"
        '
        'CheckBox1
        '
        Me.CheckBox1.BaseColor = System.Drawing.Color.White
        Me.CheckBox1.CheckedOffColor = System.Drawing.Color.White
        Me.CheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.FillColor = System.Drawing.Color.White
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(99, 351)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "show password"
        '
        'passMessage
        '
        Me.passMessage.AutoSize = True
        Me.passMessage.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.passMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.passMessage.Location = New System.Drawing.Point(57, 336)
        Me.passMessage.Name = "passMessage"
        Me.passMessage.Size = New System.Drawing.Size(196, 12)
        Me.passMessage.TabIndex = 21
        Me.passMessage.Text = "Password must be at least 6 characters long"
        Me.passMessage.Visible = False
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Animated = True
        Me.passwordTextBox.BackColor = System.Drawing.Color.White
        Me.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.passwordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.passwordTextBox.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.passwordTextBox.LineColor = System.Drawing.Color.Transparent
        Me.passwordTextBox.Location = New System.Drawing.Point(57, 296)
        Me.passwordTextBox.MaxLength = 12
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordTextBox.Size = New System.Drawing.Size(196, 37)
        Me.passwordTextBox.TabIndex = 11
        Me.passwordTextBox.TabStop = False
        Me.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passwordTextBox.UseSystemPasswordChar = True
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Animated = True
        Me.usernameTextBox.BackColor = System.Drawing.Color.White
        Me.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.usernameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.usernameTextBox.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.usernameTextBox.LineColor = System.Drawing.Color.Transparent
        Me.usernameTextBox.Location = New System.Drawing.Point(57, 226)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTextBox.Size = New System.Drawing.Size(196, 37)
        Me.usernameTextBox.TabIndex = 10
        Me.usernameTextBox.TabStop = False
        Me.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginBtn
        '
        Me.loginBtn.AnimationHoverSpeed = 0.19!
        Me.loginBtn.AnimationSpeed = 0.13!
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.BaseColor = System.Drawing.Color.Transparent
        Me.loginBtn.BorderColor = System.Drawing.Color.White
        Me.loginBtn.BorderSize = 2
        Me.loginBtn.CheckedBaseColor = System.Drawing.Color.Maroon
        Me.loginBtn.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.loginBtn.CheckedForeColor = System.Drawing.Color.White
        Me.loginBtn.CheckedImage = Nothing
        Me.loginBtn.CheckedLineColor = System.Drawing.Color.Transparent
        Me.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn.FocusedColor = System.Drawing.Color.Empty
        Me.loginBtn.Font = New System.Drawing.Font("Sriracha", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Image = Nothing
        Me.loginBtn.ImageOffsetX = 70
        Me.loginBtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.loginBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginBtn.Location = New System.Drawing.Point(89, 377)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.loginBtn.OnHoverImage = Nothing
        Me.loginBtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.loginBtn.OnPressedColor = System.Drawing.Color.Maroon
        Me.loginBtn.OnPressedDepth = 15
        Me.loginBtn.Radius = 20
        Me.loginBtn.Size = New System.Drawing.Size(129, 44)
        Me.loginBtn.TabIndex = 9
        Me.loginBtn.Text = "LOGIN"
        Me.loginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(68, 38)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(174, 156)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 6
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Sriracha", 25.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(51, -12)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(214, 60)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "Alumni Login"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Concert One", 25.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(226, 103)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(313, 40)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "TECHNICAL SCHOOL"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Concert One", 25.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(226, 57)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(308, 40)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "GHANA SECONDARY"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 767)
        Me.Controls.Add(Me.backgroundPlate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.backgroundPlate.ResumeLayout(False)
        Me.backgroundPlate.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signUpPlate.ResumeLayout(False)
        Me.signUpPlate.PerformLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginPlate.ResumeLayout(False)
        Me.loginPlate.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backgroundPlate As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents closeBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents loginPlate As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents passwordTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents usernameTextBox As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents loginBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents signUpBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents loginAgain As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents signUpPlate As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents passwordMessage As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents yearGroup As ComboBox
    Friend WithEvents newPassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents newUsername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents fullName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents actualSignup As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents generateID As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents passMessage As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents CheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents viewPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents loadUp As Guna.UI.WinForms.GunaProgressBar
End Class
