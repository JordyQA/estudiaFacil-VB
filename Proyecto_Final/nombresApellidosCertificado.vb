Public Class nombresApellidosCertificado
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        nombre = txtNombre.Text
        'gneramos intanciar el form certificado para poder asiganarle al label nombre
        certificado_original.lblNombre.Text = nombre
        'codigo para obtener la fecha actual del servicio
        Dim fechaActual As DateTime = DateTime.Now

        Dim dia As Integer = fechaActual.Day
        Dim mes As String = fechaActual.ToString("MMMM")
        Dim año As Integer = fechaActual.Year
        'Left asignamos el lña fecha a diaActual
        Dim diaActual As String = dia.ToString() & " de " & mes & " de " & año.ToString()
        'pasamos como paramtro a certificado
        certificado_original.lblFecha.Text = diaActual

        certificado_original.Show()
        Me.Hide()
    End Sub
End Class