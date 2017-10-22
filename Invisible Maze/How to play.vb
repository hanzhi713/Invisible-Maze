Public Class How_to_play
    Private Sub How_to_play_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Space) Then
            Tutorial.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub How_to_play_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class