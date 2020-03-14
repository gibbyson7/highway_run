Public Class Ren
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Bern.Show()
        Me.Hide()
        My.Computer.Audio.Play("J:\KathangBern.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Jed.Show()
        Me.Hide()
    End Sub
End Class