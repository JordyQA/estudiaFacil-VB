Public Class GradosSecundaria
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        seleccionGrado.Show()
        Me.Hide()
        primeroSecundaria.Checked = False
        segundoSecundaria.Checked = False
        terceroSecundaria.Checked = False
        cuartoSecundaria.Checked = False
        quintoSecundaria.Checked = False

    End Sub

    Private Sub primeroSecundaria_CheckedChanged(sender As Object, e As EventArgs) Handles primeroSecundaria.CheckedChanged
        If primeroSecundaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub segundoSecundaria_CheckedChanged(sender As Object, e As EventArgs) Handles segundoSecundaria.CheckedChanged
        If segundoSecundaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub terceroSecundaria_CheckedChanged(sender As Object, e As EventArgs) Handles terceroSecundaria.CheckedChanged
        If terceroSecundaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub cuartoSecundaria_CheckedChanged(sender As Object, e As EventArgs) Handles cuartoSecundaria.CheckedChanged
        If cuartoSecundaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If

    End Sub

    Private Sub quintoSecundaria_CheckedChanged(sender As Object, e As EventArgs) Handles quintoSecundaria.CheckedChanged
        If quintoSecundaria.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim opcion As Integer
        If primeroSecundaria.Checked Then
            opcion = 1
        End If

        If segundoSecundaria.Checked Then
            opcion = 2
        End If

        If terceroSecundaria.Checked Then
            opcion = 3
        End If

        If cuartoSecundaria.Checked Then
            opcion = 4
        End If

        If quintoSecundaria.Checked Then
            opcion = 5
        End If

        Select Case opcion
            Case 1
                preguntasSecundaria_Principiante.Show()
                Me.Hide()
                grado2 = 1
            Case 2
                preguntasSecundaria_Principiante3.Show()
                Me.Hide()
                grado2 = 2
            Case 3
                preguntasSecundaria_Principiante5.Show()
                Me.Hide()
                grado2 = 3
            Case 4
                preguntasSecundaria_Medio2.Show()
                Me.Hide()
                grado2 = 4
            Case 5
                preguntasSecundaria_Medio5.Show()
                Me.Hide()
                grado2 = 5
        End Select

    End Sub
End Class