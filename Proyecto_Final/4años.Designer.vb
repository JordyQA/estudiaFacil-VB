<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4años
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_4años))
        Me.bttSiguiente = New System.Windows.Forms.Button()
        Me.bttBasurero = New System.Windows.Forms.Button()
        Me.bttPuerta = New System.Windows.Forms.Button()
        Me.bttPelota = New System.Windows.Forms.Button()
        Me.bttReloj = New System.Windows.Forms.Button()
        Me.bttEscritorio = New System.Windows.Forms.Button()
        Me.bttSilla = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttSiguiente
        '
        Me.bttSiguiente.Location = New System.Drawing.Point(367, 402)
        Me.bttSiguiente.Name = "bttSiguiente"
        Me.bttSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.bttSiguiente.TabIndex = 80
        Me.bttSiguiente.Text = "Siguiente"
        Me.bttSiguiente.UseVisualStyleBackColor = True
        '
        'bttBasurero
        '
        Me.bttBasurero.BackgroundImage = CType(resources.GetObject("bttBasurero.BackgroundImage"), System.Drawing.Image)
        Me.bttBasurero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttBasurero.Location = New System.Drawing.Point(552, 243)
        Me.bttBasurero.Name = "bttBasurero"
        Me.bttBasurero.Size = New System.Drawing.Size(139, 126)
        Me.bttBasurero.TabIndex = 79
        Me.bttBasurero.UseVisualStyleBackColor = True
        '
        'bttPuerta
        '
        Me.bttPuerta.BackgroundImage = CType(resources.GetObject("bttPuerta.BackgroundImage"), System.Drawing.Image)
        Me.bttPuerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttPuerta.Location = New System.Drawing.Point(552, 85)
        Me.bttPuerta.Name = "bttPuerta"
        Me.bttPuerta.Size = New System.Drawing.Size(139, 126)
        Me.bttPuerta.TabIndex = 78
        Me.bttPuerta.UseVisualStyleBackColor = True
        '
        'bttPelota
        '
        Me.bttPelota.BackgroundImage = CType(resources.GetObject("bttPelota.BackgroundImage"), System.Drawing.Image)
        Me.bttPelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttPelota.Location = New System.Drawing.Point(336, 243)
        Me.bttPelota.Name = "bttPelota"
        Me.bttPelota.Size = New System.Drawing.Size(139, 126)
        Me.bttPelota.TabIndex = 77
        Me.bttPelota.UseVisualStyleBackColor = True
        '
        'bttReloj
        '
        Me.bttReloj.BackgroundImage = CType(resources.GetObject("bttReloj.BackgroundImage"), System.Drawing.Image)
        Me.bttReloj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttReloj.Location = New System.Drawing.Point(110, 243)
        Me.bttReloj.Name = "bttReloj"
        Me.bttReloj.Size = New System.Drawing.Size(139, 126)
        Me.bttReloj.TabIndex = 76
        Me.bttReloj.UseVisualStyleBackColor = True
        '
        'bttEscritorio
        '
        Me.bttEscritorio.BackgroundImage = CType(resources.GetObject("bttEscritorio.BackgroundImage"), System.Drawing.Image)
        Me.bttEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttEscritorio.Location = New System.Drawing.Point(336, 85)
        Me.bttEscritorio.Name = "bttEscritorio"
        Me.bttEscritorio.Size = New System.Drawing.Size(139, 126)
        Me.bttEscritorio.TabIndex = 75
        Me.bttEscritorio.UseVisualStyleBackColor = True
        '
        'bttSilla
        '
        Me.bttSilla.BackgroundImage = CType(resources.GetObject("bttSilla.BackgroundImage"), System.Drawing.Image)
        Me.bttSilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttSilla.Location = New System.Drawing.Point(110, 85)
        Me.bttSilla.Name = "bttSilla"
        Me.bttSilla.Size = New System.Drawing.Size(139, 126)
        Me.bttSilla.TabIndex = 74
        Me.bttSilla.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(330, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 35)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "OBJECTS"
        '
        '_4años
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttSiguiente)
        Me.Controls.Add(Me.bttBasurero)
        Me.Controls.Add(Me.bttPuerta)
        Me.Controls.Add(Me.bttPelota)
        Me.Controls.Add(Me.bttReloj)
        Me.Controls.Add(Me.bttEscritorio)
        Me.Controls.Add(Me.bttSilla)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_4años"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_4años"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttSiguiente As Button
    Friend WithEvents bttBasurero As Button
    Friend WithEvents bttPuerta As Button
    Friend WithEvents bttPelota As Button
    Friend WithEvents bttReloj As Button
    Friend WithEvents bttEscritorio As Button
    Friend WithEvents bttSilla As Button
    Friend WithEvents Label1 As Label
End Class
