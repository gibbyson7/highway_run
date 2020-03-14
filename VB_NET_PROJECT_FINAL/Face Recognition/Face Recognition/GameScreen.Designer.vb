<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy4_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCar4 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.Right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.Left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.BusCar = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Score_Text = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.EnemyCar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.SeaGreen
        Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(12, 330)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(251, 36)
        Me.button1.TabIndex = 2
        Me.button1.Text = "S t a r t"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Enemy4_Mover
        '
        Me.Enemy4_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("HP Simplified", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(396, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 64)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "GAME OVER"
        Me.Label2.Visible = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Interval = 10
        '
        'EnemyCar4
        '
        Me.EnemyCar4.Image = CType(resources.GetObject("EnemyCar4.Image"), System.Drawing.Image)
        Me.EnemyCar4.Location = New System.Drawing.Point(699, 25)
        Me.EnemyCar4.Name = "EnemyCar4"
        Me.EnemyCar4.Size = New System.Drawing.Size(63, 104)
        Me.EnemyCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar4.TabIndex = 35
        Me.EnemyCar4.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), System.Drawing.Image)
        Me.EnemyCar3.Location = New System.Drawing.Point(562, 25)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(63, 104)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 34
        Me.EnemyCar3.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), System.Drawing.Image)
        Me.EnemyCar2.Location = New System.Drawing.Point(419, 21)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(63, 104)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 33
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar1
        '
        Me.EnemyCar1.BackColor = System.Drawing.Color.Transparent
        Me.EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), System.Drawing.Image)
        Me.EnemyCar1.Location = New System.Drawing.Point(269, 25)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(63, 104)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 32
        Me.EnemyCar1.TabStop = False
        '
        'Right_mover
        '
        Me.Right_mover.Interval = 10
        '
        'Left_mover
        '
        Me.Left_mover.Interval = 10
        '
        'BusCar
        '
        Me.BusCar.Image = CType(resources.GetObject("BusCar.Image"), System.Drawing.Image)
        Me.BusCar.Location = New System.Drawing.Point(412, 347)
        Me.BusCar.Margin = New System.Windows.Forms.Padding(0)
        Me.BusCar.Name = "BusCar"
        Me.BusCar.Size = New System.Drawing.Size(70, 100)
        Me.BusCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BusCar.TabIndex = 31
        Me.BusCar.TabStop = False
        Me.BusCar.Tag = ""
        '
        'RoadMover
        '
        Me.RoadMover.Interval = 10
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Location = New System.Drawing.Point(653, 491)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox12.TabIndex = 30
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Location = New System.Drawing.Point(512, 491)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox11.TabIndex = 29
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.Location = New System.Drawing.Point(371, 491)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox10.TabIndex = 28
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.White
        Me.PictureBox9.Location = New System.Drawing.Point(653, 312)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox9.TabIndex = 27
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(512, 312)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox8.TabIndex = 26
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(371, 312)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox7.TabIndex = 25
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(653, 142)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox6.TabIndex = 24
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(512, 142)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(371, 142)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(653, -34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(512, -34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 135)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(369, -34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 135)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Score_Text
        '
        Me.Score_Text.AutoSize = True
        Me.Score_Text.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Text.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Score_Text.Location = New System.Drawing.Point(769, 6)
        Me.Score_Text.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Score_Text.Name = "Score_Text"
        Me.Score_Text.Size = New System.Drawing.Size(65, 22)
        Me.Score_Text.TabIndex = 37
        Me.Score_Text.Text = "Score: 0"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(251, 36)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "B a c k"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(12, 0)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(251, 324)
        Me.imageBoxFrameGrabber.TabIndex = 13
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("HP Simplified", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(478, 235)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 42)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Restart"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(834, 451)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Score_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EnemyCar4)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.BusCar)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.imageBoxFrameGrabber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        CType(Me.EnemyCar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy4_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents EnemyCar4 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents Right_mover As Timer
    Friend WithEvents Left_mover As Timer
    Friend WithEvents BusCar As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Score_Text As Label
    Public WithEvents Button2 As Button
    Public WithEvents imageBoxFrameGrabber As ImageBox
    Friend WithEvents Button4 As Button
End Class
