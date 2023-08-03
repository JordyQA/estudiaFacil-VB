Public Class seleccionGrado
    Private Sub btnInicial_Click(sender As Object, e As EventArgs) Handles btnInicial.Click
        GradosInicial.rb3Años.Checked = False
        GradosInicial.rb4Años.Checked = False
        GradosInicial.rb5Años.Checked = False
        GradosInicial.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrimaria_Click(sender As Object, e As EventArgs) Handles btnPrimaria.Click
        GradosPrimaria.primeroPrimaria.Checked = False
        GradosPrimaria.segundoPrimaria.Checked = False
        GradosPrimaria.terceroPrimaria.Checked = False
        GradosPrimaria.cuartoPrimaria.Checked = False
        GradosPrimaria.quintoPrimaria.Checked = False
        GradosPrimaria.sextoPrimaria.Checked = False
        GradosPrimaria.Show()
        Me.Hide()
    End Sub

    Private Sub btnSecundaria_Click(sender As Object, e As EventArgs) Handles btnSecundaria.Click
        GradosSecundaria.primeroSecundaria.Checked = False
        GradosSecundaria.segundoSecundaria.Checked = False
        GradosSecundaria.terceroSecundaria.Checked = False
        GradosSecundaria.cuartoSecundaria.Checked = False
        GradosSecundaria.quintoSecundaria.Checked = False

        GradosSecundaria.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ventanPrincipal.Show()
        Me.Hide()
    End Sub


End Class