<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fin_Avanzado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fin_Avanzado))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCertificado = New System.Windows.Forms.Button()
        Me.btnSegirEstudiando = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECCIONA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(415, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "UNA DE LAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OPCIONES"
        '
        'btnCertificado
        '
        Me.btnCertificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCertificado.ForeColor = System.Drawing.Color.Black
        Me.btnCertificado.Image = CType(resources.GetObject("btnCertificado.Image"), System.Drawing.Image)
        Me.btnCertificado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCertificado.Location = New System.Drawing.Point(372, 128)
        Me.btnCertificado.Name = "btnCertificado"
        Me.btnCertificado.Size = New System.Drawing.Size(110, 89)
        Me.btnCertificado.TabIndex = 4
        Me.btnCertificado.Text = "CERTIFICADO"
        Me.btnCertificado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCertificado.UseVisualStyleBackColor = True
        '
        'btnSegirEstudiando
        '
        Me.btnSegirEstudiando.AutoEllipsis = True
        Me.btnSegirEstudiando.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSegirEstudiando.Image = CType(resources.GetObject("btnSegirEstudiando.Image"), System.Drawing.Image)
        Me.btnSegirEstudiando.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSegirEstudiando.Location = New System.Drawing.Point(508, 128)
        Me.btnSegirEstudiando.Name = "btnSegirEstudiando"
        Me.btnSegirEstudiando.Size = New System.Drawing.Size(118, 89)
        Me.btnSegirEstudiando.TabIndex = 5
        Me.btnSegirEstudiando.Text = "ESTUDIAR MAS"
        Me.btnSegirEstudiando.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSegirEstudiando.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(446, 229)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 34)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Fin_Avanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(638, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSegirEstudiando)
        Me.Controls.Add(Me.btnCertificado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fin_Avanzado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fin_Avanzado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCertificado As Button
    Friend WithEvents btnSegirEstudiando As Button
    Friend WithEvents btnSalir As Button
End Class
