﻿Public Class nivelPreguntas_Primaria
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        seleccionGrado.Show()
        Me.Hide()
    End Sub

    Private Sub nivelPreguntas_Primaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbPrincipiante.Checked() = False
        rbAvanzado.Checked = False
        rbMedio.Checked = False
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If rbPrincipiante.Checked Then
            'pagina ala que va a dirigirse
            Me.Hide()

        Else
            If rbMedio.Checked Then
                'pagina a la que se dirigira
                Me.Hide()

            Else
                'pagina a la que dirigira
                Me.Hide()
            End If

        End If
    End Sub

    Private Sub rbFacil_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrincipiante.CheckedChanged
        If rbPrincipiante.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub rbMedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedio.CheckedChanged
        If rbMedio.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    Private Sub rbAvanzado_CheckedChanged(sender As Object, e As EventArgs) Handles rbAvanzado.CheckedChanged
        If rbAvanzado.Checked Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub
End Class