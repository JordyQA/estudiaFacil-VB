Public Class _4años_4
    Private Sub bttEnero_Click(sender As Object, e As EventArgs) Handles bttEnero.Click
        My.Computer.Audio.Play(My.Resources.January, AudioPlayMode.Background)

    End Sub

    Private Sub bttFebrero_Click(sender As Object, e As EventArgs) Handles bttFebrero.Click
        My.Computer.Audio.Play(My.Resources.February, AudioPlayMode.Background)

    End Sub

    Private Sub bttMarzo_Click(sender As Object, e As EventArgs) Handles bttMarzo.Click
        My.Computer.Audio.Play(My.Resources.March, AudioPlayMode.Background)

    End Sub

    Private Sub bttAbril_Click(sender As Object, e As EventArgs) Handles bttAbril.Click
        My.Computer.Audio.Play(My.Resources.April, AudioPlayMode.Background)

    End Sub

    Private Sub bttMayo_Click(sender As Object, e As EventArgs) Handles bttMayo.Click
        My.Computer.Audio.Play(My.Resources.May, AudioPlayMode.Background)

    End Sub

    Private Sub bttJunio_Click(sender As Object, e As EventArgs) Handles bttJunio.Click
        My.Computer.Audio.Play(My.Resources.June, AudioPlayMode.Background)

    End Sub

    Private Sub bttJulio_Click(sender As Object, e As EventArgs) Handles bttJulio.Click
        My.Computer.Audio.Play(My.Resources.July, AudioPlayMode.Background)

    End Sub

    Private Sub bttAgosto_Click(sender As Object, e As EventArgs) Handles bttAgosto.Click
        My.Computer.Audio.Play(My.Resources.August, AudioPlayMode.Background)

    End Sub

    Private Sub bttSeptiembre_Click(sender As Object, e As EventArgs) Handles bttSeptiembre.Click
        My.Computer.Audio.Play(My.Resources.September, AudioPlayMode.Background)

    End Sub

    Private Sub bttOctubre_Click(sender As Object, e As EventArgs) Handles bttOctubre.Click
        My.Computer.Audio.Play(My.Resources.October, AudioPlayMode.Background)

    End Sub

    Private Sub ButtonNoviembre_Click(sender As Object, e As EventArgs) Handles ButtonNoviembre.Click
        My.Computer.Audio.Play(My.Resources.November, AudioPlayMode.Background)

    End Sub

    Private Sub ButtonDiciembre_Click(sender As Object, e As EventArgs) Handles ButtonDiciembre.Click
        My.Computer.Audio.Play(My.Resources.December, AudioPlayMode.Background)

    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _4años_5.Show()
        Visible = False
    End Sub
End Class