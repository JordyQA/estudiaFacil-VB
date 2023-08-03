Public Class preguntasPrimaria_Avanzado5

    Private Sub preguntasPrimaria_Avanzado5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSiguietne.Enabled = False
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim p1, p2, p3, p4, p5, p6 As Integer
        If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Then
            p1 = 1
        Else
            p1 = 0
        End If

        If RadioButton4.Checked Or RadioButton5.Checked Or RadioButton6.Checked Then
            p2 = 1
        Else
            p2 = 0
        End If

        If RadioButton7.Checked Or RadioButton8.Checked Or RadioButton9.Checked Then
            p3 = 1
        Else
            p3 = 0
        End If

        If RadioButton10.Checked Or RadioButton11.Checked Or RadioButton12.Checked Then
            p4 = 1
        Else
            p4 = 0
        End If

        If RadioButton13.Checked Or RadioButton14.Checked Or RadioButton15.Checked Then
            p5 = 1
        Else
            p5 = 0
        End If

        If RadioButton16.Checked Or RadioButton17.Checked Or RadioButton18.Checked Then
            p6 = 1
        Else
            p6 = 0
        End If


        If p1 = 1 And p2 = 1 And p3 = 1 And p4 = 1 And p5 = 1 And p6 = 1 Then
            'Panel 1
            If RadioButton1.Checked Then
                lbl_Incorrecta.Visible = True
                lbl_Correcta.Visible = False
            End If

            If RadioButton2.Checked Then
                lbl_Correcta.Visible = False
                lbl_Incorrecta.Visible = True
            End If

            If RadioButton3.Checked Then
                lbl_Incorrecta.Visible = False
                lbl_Correcta.Visible = True
            End If

            'Panel 2
            If RadioButton4.Checked Then
                lbl_Correcta2.Visible = True
                lbl_Incorrecta2.Visible = False
            End If

            If RadioButton5.Checked Then
                lbl_Incorrecta2.Visible = True
                lbl_Correcta2.Visible = False
            End If

            If RadioButton6.Checked Then
                lbl_Incorrecta2.Visible = True
                lbl_Correcta2.Visible = False
            End If

            'Panel 3
            If RadioButton7.Checked Then
                lbl_Incorrecta3.Visible = True
                lbl_Correcta3.Visible = False
            End If

            If RadioButton8.Checked Then
                lbl_Incorrecta3.Visible = False
                lbl_Correcta3.Visible = True
            End If

            If RadioButton9.Checked Then
                lbl_Incorrecta3.Visible = True
                lbl_Correcta3.Visible = False
            End If

            'Panel 4
            If RadioButton10.Checked Then
                lbl_Incorrecta4.Visible = True
                lbl_Correcta4.Visible = False
            End If

            If RadioButton11.Checked Then
                lbl_Incorrecta4.Visible = False
                lbl_Correcta4.Visible = True
            End If

            If RadioButton12.Checked Then
                lbl_Incorrecta4.Visible = True
                lbl_Correcta4.Visible = False
            End If

            'Panel 5
            If RadioButton13.Checked Then
                lbl_Incorrecta5.Visible = True
                lbl_Correcta5.Visible = False
            End If

            If RadioButton14.Checked Then
                lbl_Incorrecta5.Visible = False
                lbl_Correcta5.Visible = True
            End If

            If RadioButton15.Checked Then
                lbl_Incorrecta5.Visible = True
                lbl_Correcta5.Visible = False
            End If

            'Panel 6
            If RadioButton16.Checked Then
                lbl_Incorrecta6.Visible = False
                lbl_Correcta6.Visible = True
            End If

            If RadioButton17.Checked Then
                lbl_Incorrecta6.Visible = True
                lbl_Correcta6.Visible = False
            End If

            If RadioButton18.Checked Then
                lbl_Incorrecta6.Visible = True
                lbl_Correcta6.Visible = False
            End If
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel4.Enabled = False
            Panel5.Enabled = False
            Panel6.Enabled = False
            btnSiguietne.Enabled = True
            btnValidar.Enabled = False
            contador = contador + 1
            

        Else

            MessageBox.Show("ERROR: tienes que seleccionar una opcion pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
            RadioButton14.Checked = False
            RadioButton15.Checked = False
            RadioButton16.Checked = False
            RadioButton17.Checked = False
            RadioButton18.Checked = False
        End If

    End Sub

    Private Sub btnSiguietne_Click(sender As Object, e As EventArgs) Handles btnSiguietne.Click
        Select Case grado
            Case 1
                If contador = 6 Then
                    Fin_Avanzado.Show()
                    Me.Hide()
                Else
                    preguntasSecundaria_Principiante.Show()
                    Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                    RadioButton5.Checked = False
                    RadioButton6.Checked = False
                    RadioButton7.Checked = False
                    RadioButton8.Checked = False
                    RadioButton9.Checked = False
                    RadioButton10.Checked = False
                    RadioButton11.Checked = False
                    RadioButton12.Checked = False
                    RadioButton13.Checked = False
                    RadioButton14.Checked = False
                    RadioButton15.Checked = False
                    RadioButton16.Checked = False
                    RadioButton17.Checked = False
                    RadioButton18.Checked = False
                End If
            Case 2
                If contador = 6 Then
                    Fin_Avanzado.Show()
                    Me.Hide()
                Else
                    preguntasSecundaria_Principiante.Show()
                    Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                    RadioButton5.Checked = False
                    RadioButton6.Checked = False
                    RadioButton7.Checked = False
                    RadioButton8.Checked = False
                    RadioButton9.Checked = False
                    RadioButton10.Checked = False
                    RadioButton11.Checked = False
                    RadioButton12.Checked = False
                    RadioButton13.Checked = False
                    RadioButton14.Checked = False
                    RadioButton15.Checked = False
                    RadioButton16.Checked = False
                    RadioButton17.Checked = False
                    RadioButton18.Checked = False
                End If
            Case 3
                If contador = 6 Then
                    Fin_Avanzado.Show()
                    Me.Hide()
                Else
                    preguntasSecundaria_Principiante.Show()
                    Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                    RadioButton5.Checked = False
                    RadioButton6.Checked = False
                    RadioButton7.Checked = False
                    RadioButton8.Checked = False
                    RadioButton9.Checked = False
                    RadioButton10.Checked = False
                    RadioButton11.Checked = False
                    RadioButton12.Checked = False
                    RadioButton13.Checked = False
                    RadioButton14.Checked = False
                    RadioButton15.Checked = False
                    RadioButton16.Checked = False
                    RadioButton17.Checked = False
                    RadioButton18.Checked = False

                End If
            Case 4
                If contador = 6 Then
                    Fin_Avanzado.Show()
                    Me.Hide()
                Else
                    preguntasSecundaria_Principiante.Show()
                    Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                    RadioButton5.Checked = False
                    RadioButton6.Checked = False
                    RadioButton7.Checked = False
                    RadioButton8.Checked = False
                    RadioButton9.Checked = False
                    RadioButton10.Checked = False
                    RadioButton11.Checked = False
                    RadioButton12.Checked = False
                    RadioButton13.Checked = False
                    RadioButton14.Checked = False
                    RadioButton15.Checked = False
                    RadioButton16.Checked = False
                    RadioButton17.Checked = False
                    RadioButton18.Checked = False
                End If
            Case 5
                If contador = 6 Then
                    Fin_Avanzado.Show()
                    Me.Hide()
                Else
                    preguntasSecundaria_Principiante.Show()
                    Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                    RadioButton5.Checked = False
                    RadioButton6.Checked = False
                    RadioButton7.Checked = False
                    RadioButton8.Checked = False
                    RadioButton9.Checked = False
                    RadioButton10.Checked = False
                    RadioButton11.Checked = False
                    RadioButton12.Checked = False
                    RadioButton13.Checked = False
                    RadioButton14.Checked = False
                    RadioButton15.Checked = False
                    RadioButton16.Checked = False
                    RadioButton17.Checked = False
                    RadioButton18.Checked = False
                End If
            Case 6
                If contador = 6 Then
                    Fin_Avanzado.Show()
                    Me.Hide()
                Else
                    preguntasSecundaria_Principiante.Show()
                    Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    RadioButton4.Checked = False
                    RadioButton5.Checked = False
                    RadioButton6.Checked = False
                    RadioButton7.Checked = False
                    RadioButton8.Checked = False
                    RadioButton9.Checked = False
                    RadioButton10.Checked = False
                    RadioButton11.Checked = False
                    RadioButton12.Checked = False
                    RadioButton13.Checked = False
                    RadioButton14.Checked = False
                    RadioButton15.Checked = False
                    RadioButton16.Checked = False
                    RadioButton17.Checked = False
                    RadioButton18.Checked = False
                End If
        End Select
    End Sub
End Class