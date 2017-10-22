Public Class Level_4
    Public keychar As String = ""
    Dim labelnumber As Integer = 2
    Private Declare Function timeGetTime Lib "winmm.dll" Alias "timeGetTime" () As Long
    Public StartTime As Double = 0
    Public i As Integer = 1
    Private Sub Level_4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keychar = e.KeyValue.ToString
        Dim flag As Boolean = True
        If keychar = 87 Then
            Button1.Top -= 10
            If Button1.Bounds.IntersectsWith(Start1.Bounds) Then
                Button1.Left = 968
                Button1.Top = 65
            End If
            Dim ifout = Button1.Left < 0 Or Button1.Top < 0 Or Button1.Left > Me.Width - Button1.Width - 15 Or Button1.Top > Me.Height - Button1.Height - 15
            For Each PictureBox In Me.Controls
                If PictureBox IsNot Button1 And PictureBox IsNot Victory And Button1.Bounds.IntersectsWith(PictureBox.Bounds) Or ifout = True Then
                    flag = False
                    Exit For
                End If
            Next
            If flag = False Then Button1.Top += 10
        End If

        If keychar = 65 Then
            Button1.Left -= 10
            If Button1.Bounds.IntersectsWith(Start1.Bounds) Then
                Button1.Left = 968
                Button1.Top = 65
            End If
            Dim ifout = Button1.Left < 0 Or Button1.Top < 0 Or Button1.Left > Me.Width - Button1.Width - 15 Or Button1.Top > Me.Height - Button1.Height - 15
            For Each PictureBox In Me.Controls
                If PictureBox IsNot Button1 And PictureBox IsNot Victory And Button1.Bounds.IntersectsWith(PictureBox.Bounds) Or ifout = True Then
                    flag = False
                    Exit For
                End If
            Next
            If flag = False Then Button1.Left += 10
        End If
        If keychar = 68 Then
            Button1.Left += 10
            If Button1.Bounds.IntersectsWith(Start1.Bounds) Then
                Button1.Left = 968
                Button1.Top = 65
            End If
            Dim ifout = Button1.Left < 0 Or Button1.Top < 0 Or Button1.Left > Me.Width - Button1.Width - 15 Or Button1.Top > Me.Height - Button1.Height - 15
            For Each PictureBox In Me.Controls
                If PictureBox IsNot Button1 And PictureBox IsNot Victory And Button1.Bounds.IntersectsWith(PictureBox.Bounds) Or ifout = True Then
                    flag = False
                    Exit For
                End If
            Next
            If flag = False Then Button1.Left -= 10
        End If
        If keychar = 83 Then
            Button1.Top += 10
            If Button1.Bounds.IntersectsWith(Start1.Bounds) Then
                Button1.Left = 968
                Button1.Top = 65
            End If
            Dim ifout = Button1.Left < 0 Or Button1.Top < 0 Or Button1.Left > Me.Width - Button1.Width - 1 Or Button1.Top > Me.Height - Button1.Height - 15
            For Each PictureBox In Me.Controls
                If PictureBox IsNot Button1 And PictureBox IsNot Victory And Button1.Bounds.IntersectsWith(PictureBox.Bounds) Or ifout = True Then
                    flag = False
                    Exit For
                End If
            Next
            If flag = False Then Button1.Top -= 10
        End If
        If Victory.Bounds.IntersectsWith(Button1.Bounds) Then
            Intermediate.Show()
            Intermediate.frm = "Level5"
            Intermediate.Label1.Text = "You're safe!" & Chr(13) & "Press SPACE to enter next level" & Chr(13) & "Time spent: " & Label2.Text
            With Intermediate
                .Label1.Top = (.Height - .Label1.Height) / 2
            End With
            Me.Close()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = labelnumber
        labelnumber -= 1
        If labelnumber = -1 Then
            Me.BackColor = Color.White
            Timer2.Enabled = True
            Label1.Dispose()
            Timer4.Enabled = True
            StartTime = timeGetTime
            Label2.Visible = True
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BackColor = Color.Black
        Timer2.Enabled = False
    End Sub

    Private Sub Victory_Click(sender As Object, e As EventArgs) Handles Victory.Click

    End Sub

    Private Sub Level_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Level_4_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.Black
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox3.Top += 5
        If PictureBox3.Top > 300 Then
            PictureBox3.Top = 100
        End If
    End Sub

    Private Sub Level_4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Back) Then
            Intermediate.Label1.Text = "Press SPACE to start the level"
            Intermediate.Show()
            Intermediate.frm = "Level4"
            Me.Close()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label2.Text = Format((timeGetTime - StartTime) / 1000, "0.00s")
    End Sub
End Class