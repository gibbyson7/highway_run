Public Class Bern
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        My.Computer.Audio.Stop()
        TitleScreen.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Ren.Show()
        Me.Hide()
    End Sub
End Class