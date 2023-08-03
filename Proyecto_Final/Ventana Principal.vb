Public Class ventanPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If rbAlumno.Checked Then
            seleccionGrado.Show()
            Me.Hide()
        End If
        If rbProfesor.Checked Then
            Login.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub rbAlumno_CheckedChanged(sender As Object, e As EventArgs) Handles rbAlumno.CheckedChanged
        If rbAlumno.Checked Then
            btnAceptar.Enabled = True

        Else
            btnAceptar.Enabled = False

        End If
    End Sub

    Private Sub rbProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProfesor.CheckedChanged
        If rbProfesor.Checked Then
            btnAceptar.Enabled = True

        Else
            btnAceptar.Enabled = False

        End If
    End Sub

    Private Sub ventanPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbProfesor.Checked = False
        rbAlumno.Checked = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class