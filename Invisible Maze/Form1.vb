Public Class Form1
    Dim r As Int16 = 0
    Dim g As Int16 = 0
    Dim b As Int16 = 0
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Space) Then
            How_to_play.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If r <= 200 Then
            r += 50
            g += 50
            b += 50
            Me.BackColor = Color.FromArgb(r, g, b)
        Else
            r = 255
            g = 255
            b = 255
            Me.BackColor = Color.FromArgb(r, g, b)
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        r = 0
        b = 0
        g = 0
        Me.BackColor = Color.FromArgb(r, g, b)
        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class
