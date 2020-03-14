Public Class startup
    Private Sub startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("J:\Startup.wav",
        AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Console.ReadLine()
        TitleScreen.Show()
        Me.Hide()
        My.Computer.Audio.Play("J:\SelectSound.wav",
        AudioPlayMode.Background)
    End Sub
End Class