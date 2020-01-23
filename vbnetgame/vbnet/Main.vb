Public Class Main
    Dim speed As Integer
    Dim road(11) As PictureBox
    Dim Enemy(3) As PictureBox
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        road(8) = PictureBox9
        road(9) = PictureBox10
        road(10) = PictureBox11
        road(11) = PictureBox12

        Enemy(0) = EnemyCar1
        Enemy(1) = EnemyCar2
        Enemy(2) = EnemyCar3
        Enemy(3) = EnemyCar4
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 11
            road(x).Top += 5
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Right_mover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            Left_mover.Start()
        End If
    End Sub

    Private Sub Right_mover_Tick(sender As Object, e As EventArgs) Handles Right_mover.Tick
        If (Car.Location.X < 474) Then
            Car.Left += 5
        End If
    End Sub

    Private Sub Left_mover_Tick(sender As Object, e As EventArgs) Handles Left_mover.Tick
        If (Car.Location.X > 0) Then
            Car.Left -= 5
        End If
    End Sub

    Private Sub Main_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Right_mover.Stop()
        Left_mover.Stop()
    End Sub

    Private Sub Enemy1_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1_Mover.Tick
        For y = 0 To 3
            Enemy(y).Top += 10

            If Enemy(y).Top > Me.Height Then
                Enemy(y).Top = -Int(Rnd() * 500)
            End If
        Next

    End Sub

    Private Sub Enemy2_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2_Mover.Tick

    End Sub

    Private Sub Enemy3_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3_Mover.Tick

    End Sub

    Private Sub Enemy4_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy4_Mover.Tick

    End Sub
End Class
