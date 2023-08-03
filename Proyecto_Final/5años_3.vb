Public Class _5años_3
    Private Sub bttVista_Click(sender As Object, e As EventArgs) Handles bttVista.Click
        My.Computer.Audio.Play(My.Resources.Sight, AudioPlayMode.Background)

    End Sub

    Private Sub bttGusto_Click(sender As Object, e As EventArgs) Handles bttGusto.Click
        My.Computer.Audio.Play(My.Resources.Taste, AudioPlayMode.Background)

    End Sub

    Private Sub bttOido_Click(sender As Object, e As EventArgs) Handles bttOido.Click
        My.Computer.Audio.Play(My.Resources.Hearing, AudioPlayMode.Background)

    End Sub

    Private Sub bttOlfato_Click(sender As Object, e As EventArgs) Handles bttOlfato.Click
        My.Computer.Audio.Play(My.Resources.Smell, AudioPlayMode.Background)

    End Sub

    Private Sub bttTacto_Click(sender As Object, e As EventArgs) Handles bttTacto.Click
        My.Computer.Audio.Play(My.Resources.Touch, AudioPlayMode.Background)

    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _5años_4.Show()
        Visible = False
    End Sub
End Class