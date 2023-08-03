Public Class _4años
    Private Sub bttSilla_Click(sender As Object, e As EventArgs) Handles bttSilla.Click
        My.Computer.Audio.Play(My.Resources.Chair, AudioPlayMode.Background)
    End Sub

    Private Sub bttEscritorio_Click(sender As Object, e As EventArgs) Handles bttEscritorio.Click
        My.Computer.Audio.Play(My.Resources.Desk, AudioPlayMode.Background)
    End Sub

    Private Sub bttPuerta_Click(sender As Object, e As EventArgs) Handles bttPuerta.Click
        My.Computer.Audio.Play(My.Resources.Door, AudioPlayMode.Background)
    End Sub

    Private Sub bttReloj_Click(sender As Object, e As EventArgs) Handles bttReloj.Click
        My.Computer.Audio.Play(My.Resources.Clock, AudioPlayMode.Background)
    End Sub

    Private Sub bttPelota_Click(sender As Object, e As EventArgs) Handles bttPelota.Click
        My.Computer.Audio.Play(My.Resources.Ball, AudioPlayMode.Background)
    End Sub

    Private Sub bttBasurero_Click(sender As Object, e As EventArgs) Handles bttBasurero.Click
        My.Computer.Audio.Play(My.Resources.Wastebasket, AudioPlayMode.Background)
    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _4años_2.Show()
        Visible = False
    End Sub
End Class