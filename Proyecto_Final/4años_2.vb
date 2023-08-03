Public Class _4años_2
    Private Sub bttFutbol_Click(sender As Object, e As EventArgs) Handles bttFutbol.Click
        My.Computer.Audio.Play(My.Resources.Soccer, AudioPlayMode.Background)
    End Sub

    Private Sub bttBasquetball_Click(sender As Object, e As EventArgs) Handles bttBasquetball.Click
        My.Computer.Audio.Play(My.Resources.Basketball, AudioPlayMode.Background)
    End Sub

    Private Sub bttTenis_Click(sender As Object, e As EventArgs) Handles bttTenis.Click
        My.Computer.Audio.Play(My.Resources.Tennis, AudioPlayMode.Background)
    End Sub

    Private Sub bttBeisbol_Click(sender As Object, e As EventArgs) Handles bttBeisbol.Click
        My.Computer.Audio.Play(My.Resources.Baseball, AudioPlayMode.Background)
    End Sub

    Private Sub bttGolf_Click(sender As Object, e As EventArgs) Handles bttGolf.Click
        My.Computer.Audio.Play(My.Resources.Golf, AudioPlayMode.Background)
    End Sub

    Private Sub bttVoleibol_Click(sender As Object, e As EventArgs) Handles bttVoleibol.Click
        My.Computer.Audio.Play(My.Resources.Volleyball, AudioPlayMode.Background)
    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _4años_3.Show()
        Visible = False
    End Sub
End Class