Public Class Form1
    Dim bin As New ToolTip
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcome.Visible = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressLoad.Value += 1
        percent.Text = progressLoad.Value & "%"
        If progressLoad.Value <= 10 Then
            progressInfo.Text = "Initializing System ..."
            welcome.Visible = False
        ElseIf progressLoad.Value <= 30 Then
            progressInfo.Text = "Loading System Files and Components ..."
            welcome.Visible = False
        ElseIf progressLoad.Value <= 50 Then
            progressInfo.Text = "Integrating Databases ..."
            welcome.Visible = False
        ElseIf progressLoad.Value <= 70 Then
            progressInfo.Text = "Loading System Requirements"
            welcome.Visible = False
        ElseIf progressLoad.Value <= 75 Then
            progressInfo.Text = "Getting Done! -< Leave eveything to us >- ..."
            GunaLabel3.Visible = False
            GunaLabel5.Visible = False
            welcome.Visible = True
        ElseIf progressLoad.Value <= 100 Then
            progressInfo.Text = "Please Wait!..."
            If progressLoad.Value = 100 Then
                Timer1.Stop()
                Form2.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub letGo_Click(sender As Object, e As EventArgs) Handles letGo.Click
        Timer1.Enabled = True
        Timer1.Start()
        GunaLabel5.Visible = True
        GunaLabel3.Visible = True
        GunaPictureBox1.Visible = True
        welcome.Visible = True
        GunaLabel1.Visible = True
        GunaLabel2.Visible = True
        GunaLabel4.Visible = True
        progressInfo.Visible = True
        progressLoad.Visible = True
        letGo.Visible = False
        percent.Visible = True
        started1.Visible = False
        started2.Visible = False
    End Sub

    Private Sub letGo_KeyDown(sender As Object, e As KeyEventArgs) Handles letGo.KeyDown
        Select Case e.KeyCode
            Case Keys.Return
                letGo.PerformClick()
        End Select
    End Sub

    Private Sub letGo_MouseHover(sender As Object, e As EventArgs) Handles letGo.MouseHover
        bin.ToolTipTitle = "Prompt"
        bin.UseFading = True
        bin.UseAnimation = True
        bin.IsBalloon = True
        bin.ShowAlways = True
        bin.AutoPopDelay = 5000
        bin.InitialDelay = 500
        bin.ReshowDelay = 100
        bin.SetToolTip(letGo, "Click here to Open Up")
    End Sub
End Class