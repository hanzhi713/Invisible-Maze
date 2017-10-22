Public Class Intermediate
    Public frm As String

    Private Sub Intermediate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Space) Then
            If frm = "Tutorial" Then Tutorial.Show()
            If frm = "Level1" Then Level_1.Show()
            If frm = "Level2" Then Level_2.Show()
            If frm = "Level3" Then Level_3.Show()
            If frm = "Level4" Then Level_4.Show()
            If frm = "Level5" Then Level_5.Show()
            If frm = "Win1" Then Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Intermediate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class