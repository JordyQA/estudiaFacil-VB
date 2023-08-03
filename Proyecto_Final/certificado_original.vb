Imports System.Drawing.Imaging
Imports System.IO

Public Class certificado_original
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        End
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click

        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        For Each control As Control In Me.Controls
            If TypeOf control Is Label Then
                Dim labelBitmap As New Bitmap(control.Width, control.Height)
                control.DrawToBitmap(labelBitmap, New Rectangle(0, 0, control.Width, control.Height))

                Dim labelLocation As Point = control.Location
                Dim finalLocation As Point = New Point(labelLocation.X, labelLocation.Y)

                Using g As Graphics = Graphics.FromImage(bmp)
                    g.DrawImage(labelBitmap, finalLocation)
                End Using
            End If
        Next

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"
            If sfd.ShowDialog() = DialogResult.OK Then
                bmp.Save(sfd.FileName, ImageFormat.Png)
                MessageBox.Show("CERTIFICADO DESCARGADO CORRECTAMENTE.")
            End If
        End Using

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class