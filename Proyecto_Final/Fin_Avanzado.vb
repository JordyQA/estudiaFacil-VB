Public Class Fin_Avanzado
    Private Sub btnSegirEstudiando_Click(sender As Object, e As EventArgs) Handles btnSegirEstudiando.Click
        contador = 0
        seleccionGrado.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCertificado_Click(sender As Object, e As EventArgs) Handles btnCertificado.Click
        nombresApellidosCertificado.Show()
        Me.Hide()
    End Sub
End Class