Public Class _3años_3
    Private Sub bttA_Click(sender As Object, e As EventArgs) Handles bttA.Click
        My.Computer.Audio.Play(My.Resources.A, AudioPlayMode.Background)
    End Sub

    Private Sub bttE_Click(sender As Object, e As EventArgs) Handles bttE.Click
        My.Computer.Audio.Play(My.Resources.E, AudioPlayMode.Background)
    End Sub

    Private Sub bttI_Click(sender As Object, e As EventArgs) Handles bttI.Click
        My.Computer.Audio.Play(My.Resources.I, AudioPlayMode.Background)
    End Sub

    Private Sub bttO_Click(sender As Object, e As EventArgs) Handles bttO.Click
        My.Computer.Audio.Play(My.Resources.O, AudioPlayMode.Background)
    End Sub

    Private Sub bttU_Click(sender As Object, e As EventArgs) Handles bttU.Click
        My.Computer.Audio.Play(My.Resources.U, AudioPlayMode.Background)
    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _3años_4.Show()
        Visible = False
    End Sub
End Class