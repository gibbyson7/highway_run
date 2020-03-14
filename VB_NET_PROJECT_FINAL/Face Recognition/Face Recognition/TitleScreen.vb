Public Class TitleScreen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        My.Computer.Audio.Play("J:\SelectSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Help.Show()
        My.Computer.Audio.Play("J:\SelectSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New TitleScreen
        frm.Show()

        Me.Close()
        startup.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play("J:\Faithfully.wav",
        AudioPlayMode.Background)
        Mtm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play("J:\SelectSound.wav",
        AudioPlayMode.Background)

        startup.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        My.Computer.Audio.Play("J:\HoverSound.wav",
        AudioPlayMode.Background)
    End Sub
End Class