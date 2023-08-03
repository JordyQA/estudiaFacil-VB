Public Class _5años_2
    Private Sub bttCarne_Click(sender As Object, e As EventArgs) Handles bttCarne.Click
        My.Computer.Audio.Play(My.Resources.Meat, AudioPlayMode.Background)

    End Sub

    Private Sub bttHuevo_Click(sender As Object, e As EventArgs) Handles bttHuevo.Click
        My.Computer.Audio.Play(My.Resources.Eggs, AudioPlayMode.Background)

    End Sub

    Private Sub bttLeche_Click(sender As Object, e As EventArgs) Handles bttLeche.Click
        My.Computer.Audio.Play(My.Resources.Milk, AudioPlayMode.Background)

    End Sub

    Private Sub bttPescado_Click(sender As Object, e As EventArgs) Handles bttPescado.Click
        My.Computer.Audio.Play(My.Resources.Fish, AudioPlayMode.Background)

    End Sub

    Private Sub bttPollo_Click(sender As Object, e As EventArgs) Handles bttPollo.Click
        My.Computer.Audio.Play(My.Resources.Chicken, AudioPlayMode.Background)

    End Sub

    Private Sub bttQueso_Click(sender As Object, e As EventArgs) Handles bttQueso.Click
        My.Computer.Audio.Play(My.Resources.Cheese, AudioPlayMode.Background)

    End Sub

    Private Sub bttTrigo_Click(sender As Object, e As EventArgs) Handles bttTrigo.Click
        My.Computer.Audio.Play(My.Resources.Wheat, AudioPlayMode.Background)

    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _5años_3.Show()
        Visible = False
    End Sub
End Class