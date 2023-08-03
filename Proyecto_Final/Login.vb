Public Class Login
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim usuarioEsperado As String = "jordy"
        Dim contraseñaEsperado As String = "jeanpieR22"

        Dim usuarioIngresado As String = txtUsuario.Text
        Dim contraseñaIngresada As String = txtPassword.Text

        If (usuarioIngresado = usuarioEsperado And contraseñaIngresada = contraseñaEsperado) Then
            aulasDisponibles.Show()
            Me.Hide()
            txtUsuario.Text = ""
            txtPassword.Text = ""
        Else
            MessageBox.Show("El usuario o la contraseña esta mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        ventanPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Enabled = False
        txtUsuario.Focus()

    End Sub
    Private Sub txtUsuario_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Text = "" Then
            txtPassword.Enabled = False
        Else
            txtPassword.Enabled = True
        End If

    End Sub
End Class