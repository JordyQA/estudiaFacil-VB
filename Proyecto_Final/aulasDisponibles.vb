Public Class aulasDisponibles
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NOM As String
        'NOM = ("BIENVENIDO ESTIMADO DOCENTE
        '   INGRESE SU NOMBRE")

        NOM = Login.txtUsuario.Text


        If NOM <> "" Then
            MessageBox.Show("Hola profesor " & NOM & " Bienvenido a su portal ")
        Else
            MessageBox.Show("LA OPERACION FUE CANCELADA")
        End If

        txtNombre.Text = NOM
        txtNombre.Enabled = False

    End Sub



End Class