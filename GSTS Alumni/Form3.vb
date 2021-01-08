Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homePlate.Visible = True

        marq.Left = marqueePanel.Width
        Timer1.Start()
    End Sub
    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            Me.Close()
            Form2.Show()
        End If
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        homePlate.Visible = True
        aboutPlate.Visible = False
        notificationPlate.Visible = False
        galleryPlate.Visible = False
        currentAffPlate.Visible = False
    End Sub
    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        aboutPlate.Visible = True
        homePlate.Visible = False
        notificationPlate.Visible = False
        galleryPlate.Visible = False
        currentAffPlate.Visible = False
        chooser.Visible = True
        programContent.Visible = False
        map.Visible = False
        contactsContent.Visible = False
        ourHistory.Visible = False
    End Sub
    Private Sub notificationsBtn_Click(sender As Object, e As EventArgs) Handles notificationsBtn.Click
        notificationPlate.Visible = True
        aboutPlate.Visible = False
        homePlate.Visible = False
        galleryPlate.Visible = False
        currentAffPlate.Visible = False
    End Sub
    Private Sub galleryBtn_Click(sender As Object, e As EventArgs) Handles galleryBtn.Click
        galleryPlate.Visible = True
        notificationPlate.Visible = False
        aboutPlate.Visible = False
        homePlate.Visible = False
        currentAffPlate.Visible = False
    End Sub
    Private Sub caBtn_Click(sender As Object, e As EventArgs) Handles caBtn.Click
        currentAffPlate.Visible = True
        galleryPlate.Visible = False
        notificationPlate.Visible = False
        aboutPlate.Visible = False
        homePlate.Visible = False
    End Sub
    Private Sub historyBtn_Click(sender As Object, e As EventArgs) Handles historyBtn.Click
        chooser.Visible = False
        programContent.Visible = False
        map.Visible = False
        contactsContent.Visible = False
        ourHistory.Visible = True
    End Sub

    Private Sub programsBtn_Click(sender As Object, e As EventArgs) Handles programsBtn.Click
        chooser.Visible = False
        programContent.Visible = True
        map.Visible = False
        contactsContent.Visible = False
        ourHistory.Visible = False
    End Sub

    Private Sub locationBtn_Click(sender As Object, e As EventArgs) Handles locationBtn.Click
        chooser.Visible = False
        programContent.Visible = False
        map.Visible = True
        contactsContent.Visible = False
        ourHistory.Visible = False
    End Sub

    Private Sub websiteBtn_Click(sender As Object, e As EventArgs) Handles websiteBtn.Click
        chooser.Visible = False
        programContent.Visible = False
        map.Visible = False
        contactsContent.Visible = True
        ourHistory.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        marq.Left -= 5
        If marq.Right = marqueePanel.Left Then
            marq.Left = marqueePanel.Width
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        logOutBtn.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim dialog As DialogResult
        MessageBox.Show("Are you sure you want to close the application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Me.Close()
            Form2.Show()
        End If
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        homeBtn.PerformClick()
    End Sub

    Private Sub ABoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABoutToolStripMenuItem.Click
        aboutBtn.PerformClick()
    End Sub

    Private Sub NotificationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationsToolStripMenuItem.Click
        notificationsBtn.PerformClick()
    End Sub

    Private Sub GalleryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalleryToolStripMenuItem.Click
        galleryBtn.PerformClick()
    End Sub

    Private Sub CurrentAffairsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentAffairsToolStripMenuItem.Click
        caBtn.PerformClick()
    End Sub

    Private Sub CloseApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseApplicationToolStripMenuItem.Click
        Dim dialog As DialogResult
        MessageBox.Show("Are you sure you want to close the application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Me.Close()
            Form2.Show()
        End If
    End Sub
End Class