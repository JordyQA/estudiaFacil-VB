<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradosPrimaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradosPrimaria))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sextoPrimaria = New System.Windows.Forms.RadioButton()
        Me.quintoPrimaria = New System.Windows.Forms.RadioButton()
        Me.cuartoPrimaria = New System.Windows.Forms.RadioButton()
        Me.terceroPrimaria = New System.Windows.Forms.RadioButton()
        Me.segundoPrimaria = New System.Windows.Forms.RadioButton()
        Me.primeroPrimaria = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 27)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "GRADOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 27)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SELECCIONE AL GRADO QUE USTED PERTENECE "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BIENVENIDO ESTIMADO ESTUDIANTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(513, 31)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ESTAMOS EN EL NIVEL DE PRIMARIA"
        '
        'sextoPrimaria
        '
        Me.sextoPrimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sextoPrimaria.Image = CType(resources.GetObject("sextoPrimaria.Image"), System.Drawing.Image)
        Me.sextoPrimaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sextoPrimaria.Location = New System.Drawing.Point(496, 300)
        Me.sextoPrimaria.Name = "sextoPrimaria"
        Me.sextoPrimaria.Size = New System.Drawing.Size(141, 43)
        Me.sextoPrimaria.TabIndex = 35
        Me.sextoPrimaria.Text = "6to GRADO"
        Me.sextoPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sextoPrimaria.UseVisualStyleBackColor = True
        '
        'quintoPrimaria
        '
        Me.quintoPrimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quintoPrimaria.Image = CType(resources.GetObject("quintoPrimaria.Image"), System.Drawing.Image)
        Me.quintoPrimaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.quintoPrimaria.Location = New System.Drawing.Point(320, 300)
        Me.quintoPrimaria.Name = "quintoPrimaria"
        Me.quintoPrimaria.Size = New System.Drawing.Size(141, 43)
        Me.quintoPrimaria.TabIndex = 34
        Me.quintoPrimaria.Text = "5to GRADO"
        Me.quintoPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.quintoPrimaria.UseVisualStyleBackColor = True
        '
        'cuartoPrimaria
        '
        Me.cuartoPrimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuartoPrimaria.Image = CType(resources.GetObject("cuartoPrimaria.Image"), System.Drawing.Image)
        Me.cuartoPrimaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cuartoPrimaria.Location = New System.Drawing.Point(496, 252)
        Me.cuartoPrimaria.Name = "cuartoPrimaria"
        Me.cuartoPrimaria.Size = New System.Drawing.Size(141, 43)
        Me.cuartoPrimaria.TabIndex = 33
        Me.cuartoPrimaria.Text = "4to GRADO"
        Me.cuartoPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cuartoPrimaria.UseVisualStyleBackColor = True
        '
        'terceroPrimaria
        '
        Me.terceroPrimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terceroPrimaria.Image = CType(resources.GetObject("terceroPrimaria.Image"), System.Drawing.Image)
        Me.terceroPrimaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.terceroPrimaria.Location = New System.Drawing.Point(320, 252)
        Me.terceroPrimaria.Name = "terceroPrimaria"
        Me.terceroPrimaria.Size = New System.Drawing.Size(141, 43)
        Me.terceroPrimaria.TabIndex = 32
        Me.terceroPrimaria.Text = "3ro GRADO"
        Me.terceroPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.terceroPrimaria.UseVisualStyleBackColor = True
        '
        'segundoPrimaria
        '
        Me.segundoPrimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundoPrimaria.Image = CType(resources.GetObject("segundoPrimaria.Image"), System.Drawing.Image)
        Me.segundoPrimaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.segundoPrimaria.Location = New System.Drawing.Point(496, 200)
        Me.segundoPrimaria.Name = "segundoPrimaria"
        Me.segundoPrimaria.Size = New System.Drawing.Size(141, 43)
        Me.segundoPrimaria.TabIndex = 31
        Me.segundoPrimaria.Text = "2do GRADO"
        Me.segundoPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.segundoPrimaria.UseVisualStyleBackColor = True
        '
        'primeroPrimaria
        '
        Me.primeroPrimaria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.primeroPrimaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.primeroPrimaria.Image = CType(resources.GetObject("primeroPrimaria.Image"), System.Drawing.Image)
        Me.primeroPrimaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.primeroPrimaria.Location = New System.Drawing.Point(320, 200)
        Me.primeroPrimaria.Name = "primeroPrimaria"
        Me.primeroPrimaria.Size = New System.Drawing.Size(141, 43)
        Me.primeroPrimaria.TabIndex = 30
        Me.primeroPrimaria.Text = "1ro GRADO"
        Me.primeroPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.primeroPrimaria.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 168)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.White
        Me.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegresar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(498, 361)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(118, 32)
        Me.btnRegresar.TabIndex = 26
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
        Me.btnSeleccionar.Location = New System.Drawing.Point(303, 361)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(138, 32)
        Me.btnSeleccionar.TabIndex = 27
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'GradosPrimaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 450)
        Me.Controls.Add(Me.sextoPrimaria)
        Me.Controls.Add(Me.quintoPrimaria)
        Me.Controls.Add(Me.cuartoPrimaria)
        Me.Controls.Add(Me.terceroPrimaria)
        Me.Controls.Add(Me.segundoPrimaria)
        Me.Controls.Add(Me.primeroPrimaria)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GradosPrimaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GradosPrimaria"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents primeroPrimaria As RadioButton
    Friend WithEvents segundoPrimaria As RadioButton
    Friend WithEvents terceroPrimaria As RadioButton
    Friend WithEvents cuartoPrimaria As RadioButton
    Friend WithEvents quintoPrimaria As RadioButton
    Friend WithEvents sextoPrimaria As RadioButton
End Class
