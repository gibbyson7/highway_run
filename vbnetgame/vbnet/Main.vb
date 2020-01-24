Public Class Main

    Dim road(11) As PictureBox
    Dim Enemy(3) As PictureBox
    Dim time As Integer = 5
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            road(x).Top += 4
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If BusCar.Bounds.IntersectsWith(EnemyCar1.Bounds()) Then
            gameOver()
        End If
        If BusCar.Bounds.IntersectsWith(EnemyCar2.Bounds()) Then
            gameOver()
        End If
        If BusCar.Bounds.IntersectsWith(EnemyCar3.Bounds()) Then
            gameOver()
        End If
        If BusCar.Bounds.IntersectsWith(EnemyCar4.Bounds()) Then
            gameOver()
        End If
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
        If (BusCar.Location.X < 474) Then
            BusCar.Left += 5
        End If
    End Sub

    Private Sub Left_mover_Tick(sender As Object, e As EventArgs) Handles Left_mover.Tick
        If (BusCar.Location.X > 0) Then
            BusCar.Left -= 5
        End If
    End Sub

    Private Sub Main_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Right_mover.Stop()
        Left_mover.Stop()
    End Sub

    Private Sub Enemy1_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1_Mover.Tick
        EnemyCar1.Top += 3
        If EnemyCar1.Top >= Me.Height Then
            EnemyCar1.Top = -EnemyCar1.Height
        End If
    End Sub

    Private Sub Enemy2_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2_Mover.Tick
        EnemyCar2.Top += 2
        If EnemyCar2.Top >= Me.Height Then
            EnemyCar2.Top = -EnemyCar2.Height
        End If
    End Sub

    Private Sub Enemy3_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3_Mover.Tick
        EnemyCar3.Top += 5
        If EnemyCar3.Top >= Me.Height Then
            EnemyCar3.Top = -EnemyCar3.Height
        End If
    End Sub

    Private Sub Enemy4_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy4_Mover.Tick
        EnemyCar4.Top += 4
        If EnemyCar4.Top >= Me.Height Then
            EnemyCar4.Top = -EnemyCar4.Height
        End If
    End Sub

    Public Sub gameOver()
        RoadMover.Stop()
        Enemy1_Mover.Stop()
        Enemy2_Mover.Stop()
        Enemy3_Mover.Stop()
        Enemy4_Mover.Stop()
        Label2.Visible = True
        Left_mover.Stop()
        Right_mover.Stop()
    End Sub
End Class
