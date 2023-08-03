<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nivelPreguntas_Primaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nivelPreguntas_Primaria))
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbAvanzado = New System.Windows.Forms.RadioButton()
        Me.rbMedio = New System.Windows.Forms.RadioButton()
        Me.rbPrincipiante = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.White
        Me.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegresar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(482, 231)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(118, 32)
        Me.btnRegresar.TabIndex = 24
        Me.btnRegresar.Text = "REGRESAR"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.White
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(472, 177)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(138, 32)
        Me.btnSeleccionar.TabIndex = 25
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 27)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "*NIVELES*"
        '
        'rbAvanzado
        '
        Me.rbAvanzado.AutoSize = True
        Me.rbAvanzado.CausesValidation = False
        Me.rbAvanzado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAvanzado.Location = New System.Drawing.Point(284, 262)
        Me.rbAvanzado.Name = "rbAvanzado"
        Me.rbAvanzado.Size = New System.Drawing.Size(99, 23)
        Me.rbAvanzado.TabIndex = 19
        Me.rbAvanzado.Text = "AVANZADO"
        Me.rbAvanzado.UseVisualStyleBackColor = True
        '
        'rbMedio
        '
        Me.rbMedio.AutoSize = True
        Me.rbMedio.CausesValidation = False
        Me.rbMedio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMedio.Location = New System.Drawing.Point(284, 217)
        Me.rbMedio.Name = "rbMedio"
        Me.rbMedio.Size = New System.Drawing.Size(72, 23)
        Me.rbMedio.TabIndex = 18
        Me.rbMedio.Text = "MEDIO"
        Me.rbMedio.UseVisualStyleBackColor = True
        '
        'rbPrincipiante
        '
        Me.rbPrincipiante.AutoSize = True
        Me.rbPrincipiante.CausesValidation = False
        Me.rbPrincipiante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbPrincipiante.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrincipiante.Location = New System.Drawing.Point(284, 172)
        Me.rbPrincipiante.Name = "rbPrincipiante"
        Me.rbPrincipiante.Size = New System.Drawing.Size(135, 23)
        Me.rbPrincipiante.TabIndex = 17
        Me.rbPrincipiante.Text = "PRINCIPIANTE"
        Me.rbPrincipiante.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SELECCIONEMOS EL NIVEL DE DIFICULTAD "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(585, 35)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "BIENVENIDO ESTIMADO ESTUDIANTE"
        '
        'nivelPreguntas_Primaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 321)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbAvanzado)
        Me.Controls.Add(Me.rbMedio)
        Me.Controls.Add(Me.rbPrincipiante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "nivelPreguntas_Primaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nivelPreguntas_Primaria"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbAvanzado As RadioButton
    Friend WithEvents rbMedio As RadioButton
    Friend WithEvents rbPrincipiante As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
