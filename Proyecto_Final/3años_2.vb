Public Class _3años_2
    Private Sub bttMono_Click(sender As Object, e As EventArgs) Handles bttMono.Click
        My.Computer.Audio.Play(My.Resources.Monkey, AudioPlayMode.Background)
    End Sub

    Private Sub bttTigre_Click(sender As Object, e As EventArgs) Handles bttTigre.Click
        My.Computer.Audio.Play(My.Resources.Tiger, AudioPlayMode.Background)
    End Sub

    Private Sub bttElefante_Click(sender As Object, e As EventArgs) Handles bttElefante.Click
        My.Computer.Audio.Play(My.Resources.Elephant, AudioPlayMode.Background)
    End Sub

    Private Sub bttHipopotamo_Click(sender As Object, e As EventArgs) Handles bttHipopotamo.Click
        My.Computer.Audio.Play(My.Resources.Hippopotamus, AudioPlayMode.Background)
    End Sub

    Private Sub bttOso_Click(sender As Object, e As EventArgs) Handles bttOso.Click
        My.Computer.Audio.Play(My.Resources.Bear, AudioPlayMode.Background)
    End Sub

    Private Sub bttTortuga_Click(sender As Object, e As EventArgs) Handles bttTortuga.Click
        My.Computer.Audio.Play(My.Resources.Turtle, AudioPlayMode.Background)
    End Sub

    Private Sub bttSiguiente_Click(sender As Object, e As EventArgs) Handles bttSiguiente.Click
        _3años_3.Show()
        Visible = False
    End Sub
End Class