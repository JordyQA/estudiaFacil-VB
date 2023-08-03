<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _5años_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_5años_3))
        Me.bttSiguiente = New System.Windows.Forms.Button()
        Me.bttOlfato = New System.Windows.Forms.Button()
        Me.bttTacto = New System.Windows.Forms.Button()
        Me.bttOido = New System.Windows.Forms.Button()
        Me.bttGusto = New System.Windows.Forms.Button()
        Me.bttVista = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttSiguiente
        '
        Me.bttSiguiente.Location = New System.Drawing.Point(374, 402)
        Me.bttSiguiente.Name = "bttSiguiente"
        Me.bttSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.bttSiguiente.TabIndex = 72
        Me.bttSiguiente.Text = "Siguiente"
        Me.bttSiguiente.UseVisualStyleBackColor = True
        '
        'bttOlfato
        '
        Me.bttOlfato.BackgroundImage = CType(resources.GetObject("bttOlfato.BackgroundImage"), System.Drawing.Image)
        Me.bttOlfato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttOlfato.Location = New System.Drawing.Point(232, 251)
        Me.bttOlfato.Name = "bttOlfato"
        Me.bttOlfato.Size = New System.Drawing.Size(139, 126)
        Me.bttOlfato.TabIndex = 71
        Me.bttOlfato.UseVisualStyleBackColor = True
        '
        'bttTacto
        '
        Me.bttTacto.BackgroundImage = CType(resources.GetObject("bttTacto.BackgroundImage"), System.Drawing.Image)
        Me.bttTacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttTacto.Location = New System.Drawing.Point(458, 251)
        Me.bttTacto.Name = "bttTacto"
        Me.bttTacto.Size = New System.Drawing.Size(139, 126)
        Me.bttTacto.TabIndex = 70
        Me.bttTacto.UseVisualStyleBackColor = True
        '
        'bttOido
        '
        Me.bttOido.BackgroundImage = CType(resources.GetObject("bttOido.BackgroundImage"), System.Drawing.Image)
        Me.bttOido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttOido.Location = New System.Drawing.Point(552, 87)
        Me.bttOido.Name = "bttOido"
        Me.bttOido.Size = New System.Drawing.Size(139, 126)
        Me.bttOido.TabIndex = 69
        Me.bttOido.UseVisualStyleBackColor = True
        '
        'bttGusto
        '
        Me.bttGusto.BackgroundImage = CType(resources.GetObject("bttGusto.BackgroundImage"), System.Drawing.Image)
        Me.bttGusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttGusto.Location = New System.Drawing.Point(336, 87)
        Me.bttGusto.Name = "bttGusto"
        Me.bttGusto.Size = New System.Drawing.Size(139, 126)
        Me.bttGusto.TabIndex = 68
        Me.bttGusto.UseVisualStyleBackColor = True
        '
        'bttVista
        '
        Me.bttVista.BackgroundImage = CType(resources.GetObject("bttVista.BackgroundImage"), System.Drawing.Image)
        Me.bttVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttVista.Location = New System.Drawing.Point(110, 87)
        Me.bttVista.Name = "bttVista"
        Me.bttVista.Size = New System.Drawing.Size(139, 126)
        Me.bttVista.TabIndex = 67
        Me.bttVista.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(309, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 35)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "FIVE SENSES"
        '
        '_5años_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttSiguiente)
        Me.Controls.Add(Me.bttOlfato)
        Me.Controls.Add(Me.bttTacto)
        Me.Controls.Add(Me.bttOido)
        Me.Controls.Add(Me.bttGusto)
        Me.Controls.Add(Me.bttVista)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_5años_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_5años_3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttSiguiente As Button
    Friend WithEvents bttOlfato As Button
    Friend WithEvents bttTacto As Button
    Friend WithEvents bttOido As Button
    Friend WithEvents bttGusto As Button
    Friend WithEvents bttVista As Button
    Friend WithEvents Label1 As Label
End Class
