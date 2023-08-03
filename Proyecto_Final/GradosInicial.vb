Public Class GradosInicial


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        seleccionGrado.Show()
        Me.Hide()
        rb3Años.Checked = False
        rb4Años.Checked = False
        rb5Años.Checked = False
    End Sub

    Private Sub nivelPreguntas_Inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb3Años.Checked = False
        rb4Años.Checked = False
        rb5Años.Checked = False
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If rb3Años.Checked Then
            'pagina ala que va a dirigirse
            'se le redirige a los formularios de principiantes
            _3años.Show()
            Me.Hide()

        Else
            If rb4Años.Checked Then
                'pagina a la que se dirigira
                _4años.Show()
                Me.Hide()

            Else
                'pagina a la que dirigira
                _5años.Show()
                Me.Hide()
            End If

        End If


    End Sub

    Private Sub rb3Años_CheckedChanged(sender As Object, e As EventArgs) Handles rb3Años.CheckedChanged
        If rb3Años.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub rb4Años_CheckedChanged(sender As Object, e As EventArgs) Handles rb4Años.CheckedChanged
        If rb4Años.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub rb5Años_CheckedChanged(sender As Object, e As EventArgs) Handles rb5Años.CheckedChanged
        If rb5Años.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

End Class