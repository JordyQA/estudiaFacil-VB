Public Class _3años
    Private Sub bttBlue_Click(sender As Object, e As EventArgs) Handles bttBlue.Click
        My.Computer.Audio.Play(My.Resources.Blue, AudioPlayMode.Background)
    End Sub

    Private Sub bttGray_Click(sender As Object, e As EventArgs) Handles bttGray.Click
        My.Computer.Audio.Play(My.Resources.Gray, AudioPlayMode.Background)
    End Sub

    Private Sub bttBlack_Click(sender As Object, e As EventArgs) Handles bttBlack.Click
        My.Computer.Audio.Play(My.Resources.Black, AudioPlayMode.Background)
    End Sub

    Private Sub bttOrange_Click(sender As Object, e As EventArgs) Handles bttOrange.Click
        My.Computer.Audio.Play(My.Resources.Orange, AudioPlayMode.Background)
    End Sub

    Private Sub bttRed_Click(sender As Object, e As EventArgs) Handles bttRed.Click
        My.Computer.Audio.Play(My.Resources.Red, AudioPlayMode.Background)
    End Sub

    Private Sub bttYellow_Click(sender As Object, e As EventArgs) Handles bttYellow.Click
        My.Computer.Audio.Play(My.Resources.Yellow, AudioPlayMode.Background)
    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _3años_2.Show()
        Visible = False
    End Sub
End Class