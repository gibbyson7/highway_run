Public Class Help
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
        My.Computer.Audio.Play("J:\SelectSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        My.Computer.Audio.Play("J:\BackSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub
End Class