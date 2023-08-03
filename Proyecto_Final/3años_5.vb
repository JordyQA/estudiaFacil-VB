Public Class _3años_5
    Private Sub bttFeliz_Click(sender As Object, e As EventArgs) Handles bttFeliz.Click
        My.Computer.Audio.Play(My.Resources.Happy, AudioPlayMode.Background)
    End Sub

    Private Sub bttTriste_Click(sender As Object, e As EventArgs) Handles bttTriste.Click
        My.Computer.Audio.Play(My.Resources.Sad, AudioPlayMode.Background)
    End Sub

    Private Sub bttEnfadado_Click(sender As Object, e As EventArgs) Handles bttEnfadado.Click
        My.Computer.Audio.Play(My.Resources.Angry, AudioPlayMode.Background)
    End Sub

    Private Sub bttAsustado_Click(sender As Object, e As EventArgs) Handles bttAsustado.Click
        My.Computer.Audio.Play(My.Resources.Scared, AudioPlayMode.Background)
    End Sub

    Private Sub bttSorprendido_Click(sender As Object, e As EventArgs) Handles bttSorprendido.Click
        My.Computer.Audio.Play(My.Resources.Surprised, AudioPlayMode.Background)
    End Sub

    Private Sub bttEnfermo_Click(sender As Object, e As EventArgs) Handles bttEnfermo.Click
        My.Computer.Audio.Play(My.Resources.Sick, AudioPlayMode.Background)
    End Sub

    Private Sub bttFinalizar_Click(sender As Object, e As EventArgs) Handles bttFinalizar.Click
        Fin_Avanzado.Show()
        Me.Hide()
    End Sub
End Class