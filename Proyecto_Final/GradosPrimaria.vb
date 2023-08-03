Public Class GradosPrimaria
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        seleccionGrado.Show()
        Me.Hide()
        primeroPrimaria.Checked = False
        segundoPrimaria.Checked = False
        terceroPrimaria.Checked = False
        cuartoPrimaria.Checked = False
        quintoPrimaria.Checked = False
        sextoPrimaria.Checked = False

    End Sub

    Private Sub primeroPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles primeroPrimaria.CheckedChanged
        If primeroPrimaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub segundoPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles segundoPrimaria.CheckedChanged
        If segundoPrimaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub terceroPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles terceroPrimaria.CheckedChanged
        If terceroPrimaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub cuartoPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles cuartoPrimaria.CheckedChanged
        If cuartoPrimaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub quintoPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles quintoPrimaria.CheckedChanged
        If quintoPrimaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub sextoPrimaria_CheckedChanged(sender As Object, e As EventArgs) Handles sextoPrimaria.CheckedChanged
        If sextoPrimaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim opcion As Integer

        If primeroPrimaria.Checked Then
            opcion = 1
        End If

        If segundoPrimaria.Checked Then
            opcion = 2
        End If

        If terceroPrimaria.Checked Then
            opcion = 3
        End If

        If cuartoPrimaria.Checked Then
            opcion = 4
        End If

        If quintoPrimaria.Checked Then
            opcion = 5
        End If

        If sextoPrimaria.Checked Then
            opcion = 6
        End If


        Select Case opcion
            Case 1
                preguntasPrimaria_Principiante.Show()
                Me.Hide()
                grado = 1
            Case 2
                preguntasPrimaria_Principiante3.Show()
                Me.Hide()
                grado = 2
            Case 3
                preguntasPrimaria_Principiante5.Show()
                Me.Hide()
                grado = 3
            Case 4
                preguntasPrimaria_Medio2.Show()
                Me.Hide()
                grado = 4
            Case 5
                preguntasPrimaria_Medio4.Show()
                Me.Hide()
                grado = 5
            Case 6
                preguntasPrimaria_Avanzado.Show()
                Me.Hide()
                grado = 6

        End Select
    End Sub

End Class