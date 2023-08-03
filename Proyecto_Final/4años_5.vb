Public Class _4años_5
    Private Sub bttLunes_Click(sender As Object, e As EventArgs) Handles bttLunes.Click
        My.Computer.Audio.Play(My.Resources.Monday, AudioPlayMode.Background)

    End Sub

    Private Sub bttMartes_Click(sender As Object, e As EventArgs) Handles bttMartes.Click
        My.Computer.Audio.Play(My.Resources.Tuesday, AudioPlayMode.Background)

    End Sub

    Private Sub bttMiercoles_Click(sender As Object, e As EventArgs) Handles bttMiercoles.Click
        My.Computer.Audio.Play(My.Resources.Wednesday, AudioPlayMode.Background)

    End Sub

    Private Sub bttJueves_Click(sender As Object, e As EventArgs) Handles bttJueves.Click
        My.Computer.Audio.Play(My.Resources.Thursday, AudioPlayMode.Background)

    End Sub

    Private Sub bttViernes_Click(sender As Object, e As EventArgs) Handles bttViernes.Click
        My.Computer.Audio.Play(My.Resources.Friday, AudioPlayMode.Background)

    End Sub

    Private Sub bttSabado_Click(sender As Object, e As EventArgs) Handles bttSabado.Click
        My.Computer.Audio.Play(My.Resources.Saturday, AudioPlayMode.Background)

    End Sub

    Private Sub bttDomingo_Click(sender As Object, e As EventArgs) Handles bttDomingo.Click
        My.Computer.Audio.Play(My.Resources.Sunday, AudioPlayMode.Background)

    End Sub

    Private Sub bttFinalizar_Click_1(sender As Object, e As EventArgs) Handles bttFinalizar.Click
        Fin_Avanzado.Show()
        Me.Hide()
    End Sub
End Class