<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class certificado_original
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(certificado_original))
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.btnDescargar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFecha.Location = New System.Drawing.Point(659, 676)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(68, 23)
        Me.lblFecha.TabIndex = 82
        Me.lblFecha.Text = "Label1"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.MintCream
        Me.lblNombre.Font = New System.Drawing.Font("Times New Roman", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(193, 465)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(976, 87)
        Me.lblNombre.TabIndex = 81
        Me.lblNombre.Text = "SIN NOMBRE"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1328, 862)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'btnValidar
        '
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Image = CType(resources.GetObject("btnValidar.Image"), System.Drawing.Image)
        Me.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValidar.Location = New System.Drawing.Point(497, 869)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(136, 44)
        Me.btnValidar.TabIndex = 79
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'btnDescargar
        '
        Me.btnDescargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargar.Location = New System.Drawing.Point(697, 869)
        Me.btnDescargar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.Size = New System.Drawing.Size(215, 44)
        Me.btnDescargar.TabIndex = 83
        Me.btnDescargar.Text = "DESCARGAR "
        Me.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDescargar.UseVisualStyleBackColor = True
        '
        'certificado_original
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1328, 914)
        Me.Controls.Add(Me.btnDescargar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnValidar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "certificado_original"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "certificado_original"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents btnDescargar As Button
End Class
