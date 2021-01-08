Imports MySql.Data.MySqlClient
Public Class Form2
    Dim connect As MySqlConnection
    Dim cmd As MySqlCommand
    Dim generator As Integer

    Dim bin As New ToolTip
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUp.Visible = False
        signUpBtn.Visible = True
        loginAgain.Visible = False
        GunaLabel5.Visible = True
        loginPlate.Visible = True
        signUpPlate.Visible = False
        Timer2.Enabled = True
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        MessageBox.Show("Are you sure you want to close this Application?", "Prompt!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = (500)
        loadUp.Value += 5
        If loadUp.Value = 100 Then
            Timer1.Stop()
            username_And_Password_Validate()
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If passwordTextBox.Text.Length <= 5 Then
            passMessage.Visible = True
            MessageBox.Show("Password length is too short", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf passwordTextBox.Text.Length >= 6 And passwordTextBox.Text.Length <= 12 Then
            passMessage.Visible = False
            Timer1.Start()
            loadUp.Visible = True
        End If
    End Sub

    Private Sub username_And_Password_Validate()
        connect = New MySqlConnection
        connect.ConnectionString = "server=localhost;userid=root;password=root; database=The_Giants"
        Dim reader As MySqlDataReader
        Try
            connect.Open()

            Dim query As String

            query = "select * from The_Giants.user_profiles where Username = '" & usernameTextBox.Text & "' And Password_ = '" & passwordTextBox.Text & "'"

            cmd = New MySqlCommand(query, connect)

            reader = cmd.ExecuteReader


            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While


            If count = 1 Then
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Hello, Welcome GIANT " & usernameTextBox.Text & ".", "User Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If dialog = DialogResult.OK Then
                    usernameTextBox.Text = ""
                    passwordTextBox.Text = ""
                    loadUp.Visible = False
                    Me.Hide()
                    Form3.ShowDialog()
                End If
            ElseIf count > 1 Then
                MessageBox.Show("Username or Password already used")
                usernameTextBox.Text = ""
                passwordTextBox.Text = ""
                loadUp.Visible = False
            Else
                MessageBox.Show("Username or Password is incorrect !!!" & ControlChars.NewLine & "Try AGAIN!")
                passwordTextBox.Text = ""
                loadUp.Visible = False
            End If

            connect.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
        usernameTextBox.Text = ""
        passwordTextBox.Text = ""
        loadUp.Value = 0
        loadUp.Visible = False
    End Sub

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        loginPlate.Visible = False
        signUpPlate.Visible = True
        signUpBtn.Visible = False
        loginAgain.Visible = True
        GunaLabel5.Text = "Log into my Account"
        usernameTextBox.Text = ""
        passwordTextBox.Text = ""
    End Sub

    Private Sub loginAgain_Click(sender As Object, e As EventArgs) Handles loginAgain.Click
        loginPlate.Visible = True
        signUpPlate.Visible = False
        signUpBtn.Visible = True
        loginAgain.Visible = False
        GunaLabel5.Text = "Don't have a Giant account"
        fullName.Text = ""
        newPassword.Text = ""
        newUsername.Text = ""
        yearGroup.Text = "Year Group"
        ID.Text = ""
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        loginPlate.Visible = True
        signUpPlate.Visible = False
        signUpBtn.Visible = True
        loginAgain.Visible = False
        GunaLabel5.Text = "Don't have a Giant account"
        fullName.Text = ""
        newPassword.Text = ""
        newUsername.Text = ""
        yearGroup.Text = "Year Group"
        ID.Text = ""
    End Sub

    Private Sub generateID_Click(sender As Object, e As EventArgs) Handles generateID.Click
        connect = New MySqlConnection
        connect.ConnectionString = "server=localhost;userid=root;password=root; database=The_Giants"
        Dim reader As MySqlDataReader

        Try
            connect.Open()

            Dim query As String

            query = "select * from The_Giants.user_profiles order by Giant_ID DESC LIMIT 1"

            cmd = New MySqlCommand(query, connect)

            reader = cmd.ExecuteReader

            While reader.Read
                Dim generated_ID = reader.GetString("Giant_ID")
                generator = Integer.Parse(generated_ID) + 1
                generator.ToString()
                ID.Text = "GT" & generator & yearGroup.Text.ToString()
            End While
            ID.Visible = True
            connect.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
        ID.Visible = True
    End Sub
    Private Sub actualSignup_Click(sender As Object, e As EventArgs) Handles actualSignup.Click
        If newPassword.Text.Length <= 5 Then
            passwordMessage.Visible = True
            MessageBox.Show("Password length is too short", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf newPassword.Text.Length >= 6 And newPassword.Text.Length <= 12 Then
            passwordMessage.Visible = False
            connect = New MySqlConnection
            connect.ConnectionString = "server=localhost;userid=root;password=root; database=The_Giants"
            Dim reader As MySqlDataReader

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            Try
                Dim query As String
                connect.Open()
                query = "insert into The_Giants.user_profiles(Giant_ID, Full_name, Username, Password_, Year_group)
                    values ('" & generator.ToString & "', '" & fullName.Text & "', '" & newUsername.Text & "', '" & newPassword.Text & "', '" & yearGroup.Text & "')"

                cmd = New MySqlCommand(query, connect)
                reader = cmd.ExecuteReader

                connect.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connect.Dispose()
            End Try
            newUsername.Text = ""
            fullName.Text = ""
            newPassword.Text = ""
            yearGroup.Text = "Year Group"
            MessageBox.Show("Giant account created successfully !", "SignUp Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If fullName.Text = "" Or newPassword.Text = "" Or newUsername.Text = "" Or yearGroup.Text = "Year Group" Or ID.Text = "ID" Then
            actualSignup.Enabled = False
        Else
            actualSignup.Enabled = True
        End If

        If fullName.Text = "" Or newPassword.Text = "" Or newUsername.Text = "" Or yearGroup.Text = "Year Group" Then
            generateID.Enabled = False
        Else
            generateID.Enabled = True
        End If

        If usernameTextBox.Text = "" Or passwordTextBox.Text = "" Then
            loginBtn.Enabled = False
        Else
            loginBtn.Enabled = True
        End If
    End Sub

    Private Sub viewPassword_CheckedChanged_1(sender As Object, e As EventArgs) Handles viewPassword.CheckedChanged
        If viewPassword.Checked Then
            newPassword.UseSystemPasswordChar = False
        Else
            newPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            passwordTextBox.UseSystemPasswordChar = False
        Else
            passwordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub newPassword_GotFocus(sender As Object, e As EventArgs) Handles newPassword.GotFocus
        newPassword.ForeColor = Color.DarkRed
    End Sub

    Private Sub fullName_GotFocus(sender As Object, e As EventArgs) Handles fullName.GotFocus
        fullName.ForeColor = Color.DarkRed
    End Sub

    Private Sub newUsername_GotFocus(sender As Object, e As EventArgs) Handles newUsername.GotFocus
        newUsername.ForeColor = Color.DarkRed
    End Sub

    Private Sub newPassword_LostFocus(sender As Object, e As EventArgs) Handles newPassword.LostFocus
        newPassword.ForeColor = Color.Gray
    End Sub

    Private Sub fullName_LostFocus(sender As Object, e As EventArgs) Handles fullName.LostFocus
        fullName.ForeColor = Color.Gray
    End Sub

    Private Sub newUsername_LostFocus(sender As Object, e As EventArgs) Handles newUsername.LostFocus
        newUsername.ForeColor = Color.Gray
    End Sub
    Private Sub usernameTextBox_GotFocus(sender As Object, e As EventArgs) Handles usernameTextBox.GotFocus
        usernameTextBox.ForeColor = Color.DarkRed
    End Sub

    Private Sub usernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles usernameTextBox.LostFocus
        usernameTextBox.ForeColor = Color.Gray
    End Sub
    Private Sub passwordTextBox_GotFocus(sender As Object, e As EventArgs) Handles passwordTextBox.GotFocus
        passwordTextBox.ForeColor = Color.DarkRed
    End Sub

    Private Sub passwordTextBox_LostFocus(sender As Object, e As EventArgs) Handles passwordTextBox.LostFocus
        passwordTextBox.ForeColor = Color.Gray
    End Sub

    Private Sub actualSignup_KeyDown(sender As Object, e As KeyEventArgs) Handles actualSignup.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                actualSignup.PerformClick()
        End Select
    End Sub

    Private Sub loginBtn_KeyDown(sender As Object, e As KeyEventArgs) Handles loginBtn.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                loginBtn.PerformClick()
        End Select
    End Sub

    Private Sub GunaAdvenceButton2_KeyDown(sender As Object, e As KeyEventArgs) Handles GunaAdvenceButton2.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                GunaAdvenceButton2.PerformClick()
        End Select
    End Sub

    Private Sub closeBtn_KeyDown(sender As Object, e As KeyEventArgs) Handles closeBtn.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                closeBtn.PerformClick()
        End Select
    End Sub

    Private Sub actualSignup_MouseHover(sender As Object, e As EventArgs) Handles actualSignup.MouseHover
        bin.ToolTipTitle = "SignUp"
        bin.UseFading = True
        bin.UseAnimation = True
        bin.IsBalloon = True
        bin.ShowAlways = True
        bin.AutoPopDelay = 5000
        bin.InitialDelay = 500
        bin.ReshowDelay = 100
        bin.SetToolTip(actualSignup, "Click to SignUp ")
    End Sub

    Private Sub loginBtn_MouseHover(sender As Object, e As EventArgs) Handles loginBtn.MouseHover
        bin.ToolTipTitle = "Login"
        bin.UseFading = True
        bin.UseAnimation = True
        bin.IsBalloon = True
        bin.ShowAlways = True
        bin.AutoPopDelay = 5000
        bin.InitialDelay = 500
        bin.ReshowDelay = 100
        bin.SetToolTip(loginBtn, "Click to Login into your Account.")
    End Sub

    Private Sub signUpBtn_MouseHover(sender As Object, e As EventArgs) Handles signUpBtn.MouseHover
        bin.UseFading = True
        bin.UseAnimation = True
        bin.IsBalloon = True
        bin.ShowAlways = True
        bin.AutoPopDelay = 5000
        bin.InitialDelay = 500
        bin.ReshowDelay = 100
        bin.SetToolTip(signUpBtn, "Create a user account!")
    End Sub

    Private Sub loginAgain_MouseHover(sender As Object, e As EventArgs) Handles loginAgain.MouseHover
        bin.UseFading = True
        bin.UseAnimation = True
        bin.IsBalloon = True
        bin.ShowAlways = True
        bin.AutoPopDelay = 5000
        bin.InitialDelay = 500
        bin.ReshowDelay = 100
        bin.SetToolTip(loginAgain, "Back to Login Page!")
    End Sub
End Class