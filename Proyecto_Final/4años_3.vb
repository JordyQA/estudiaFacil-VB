Public Class _4años_3
    Private Sub bttUva_Click(sender As Object, e As EventArgs) Handles bttUva.Click
        My.Computer.Audio.Play(My.Resources.Grapes, AudioPlayMode.Background)

    End Sub

    Private Sub bttFresa_Click(sender As Object, e As EventArgs) Handles bttFresa.Click
        My.Computer.Audio.Play(My.Resources.Strawberry, AudioPlayMode.Background)

    End Sub

    Private Sub bttCereza_Click(sender As Object, e As EventArgs) Handles bttCereza.Click
        My.Computer.Audio.Play(My.Resources.Cherry, AudioPlayMode.Background)

    End Sub

    Private Sub bttManzana_Click(sender As Object, e As EventArgs) Handles bttManzana.Click
        My.Computer.Audio.Play(My.Resources.Apple, AudioPlayMode.Background)

    End Sub

    Private Sub bttPera_Click(sender As Object, e As EventArgs) Handles bttPera.Click
        My.Computer.Audio.Play(My.Resources.Pear, AudioPlayMode.Background)

    End Sub

    Private Sub bttPlatano_Click(sender As Object, e As EventArgs) Handles bttPlatano.Click
        My.Computer.Audio.Play(My.Resources.Banana, AudioPlayMode.Background)

    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _4años_4.Show()
        Visible = False
    End Sub
End Class