Public Class _5años_4
    Private Sub bttJupiter_Click(sender As Object, e As EventArgs) Handles bttJupiter.Click
        My.Computer.Audio.Play(My.Resources.Jupiter, AudioPlayMode.Background)
    End Sub

    Private Sub bttMarte_Click(sender As Object, e As EventArgs) Handles bttMarte.Click
        My.Computer.Audio.Play(My.Resources.Mars, AudioPlayMode.Background)
    End Sub

    Private Sub bttMercurio_Click(sender As Object, e As EventArgs) Handles bttMercurio.Click
        My.Computer.Audio.Play(My.Resources.Mercury, AudioPlayMode.Background)
    End Sub

    Private Sub bttNeptuno_Click(sender As Object, e As EventArgs) Handles bttNeptuno.Click
        My.Computer.Audio.Play(My.Resources.Neptune, AudioPlayMode.Background)
    End Sub

    Private Sub bttPluton_Click(sender As Object, e As EventArgs) Handles bttPluton.Click
        My.Computer.Audio.Play(My.Resources.Pluto, AudioPlayMode.Background)
    End Sub

    Private Sub bttSaturno_Click(sender As Object, e As EventArgs) Handles bttSaturno.Click
        My.Computer.Audio.Play(My.Resources.Saturn, AudioPlayMode.Background)
    End Sub

    Private Sub bttTierra_Click(sender As Object, e As EventArgs) Handles bttTierra.Click
        My.Computer.Audio.Play(My.Resources.Earth, AudioPlayMode.Background)
    End Sub

    Private Sub bttUrano_Click(sender As Object, e As EventArgs) Handles bttUrano.Click
        My.Computer.Audio.Play(My.Resources.Uranus, AudioPlayMode.Background)
    End Sub

    Private Sub bttVenus_Click(sender As Object, e As EventArgs) Handles bttVenus.Click
        My.Computer.Audio.Play(My.Resources.Venus, AudioPlayMode.Background)
    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _5años_5.Show()
        Visible = False
    End Sub
End Class