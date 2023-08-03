Public Class _5años_5
    Private Sub bttAvion_Click(sender As Object, e As EventArgs) Handles bttAvion.Click
        My.Computer.Audio.Play(My.Resources.Airplane, AudioPlayMode.Background)
    End Sub

    Private Sub bttBarco_Click(sender As Object, e As EventArgs) Handles bttBarco.Click
        My.Computer.Audio.Play(My.Resources.Ship, AudioPlayMode.Background)
    End Sub

    Private Sub bttBus_Click(sender As Object, e As EventArgs) Handles bttBus.Click
        My.Computer.Audio.Play(My.Resources.Bus, AudioPlayMode.Background)
    End Sub

    Private Sub bttAuto_Click(sender As Object, e As EventArgs) Handles bttAuto.Click
        My.Computer.Audio.Play(My.Resources.Car, AudioPlayMode.Background)
    End Sub

    Private Sub bttTren_Click(sender As Object, e As EventArgs) Handles bttTren.Click
        My.Computer.Audio.Play(My.Resources.Train, AudioPlayMode.Background)
    End Sub

    Private Sub bttFinalizar_Click(sender As Object, e As EventArgs) Handles bttFinalizar.Click
        Fin_Avanzado.Show()
        Me.Hide()
    End Sub
End Class