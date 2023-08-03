<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccionGrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(seleccionGrado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInicial = New System.Windows.Forms.Button()
        Me.btnPrimaria = New System.Windows.Forms.Button()
        Me.btnSecundaria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SELECCIONE SU GRADO DE APRENDIZAJE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Button1.Location = New System.Drawing.Point(12, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnInicial
        '
        Me.btnInicial.BackgroundImage = CType(resources.GetObject("btnInicial.BackgroundImage"), System.Drawing.Image)
        Me.btnInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInicial.Location = New System.Drawing.Point(303, 37)
        Me.btnInicial.Name = "btnInicial"
        Me.btnInicial.Size = New System.Drawing.Size(368, 52)
        Me.btnInicial.TabIndex = 14
        Me.btnInicial.UseVisualStyleBackColor = True
        '
        'btnPrimaria
        '
        Me.btnPrimaria.BackgroundImage = CType(resources.GetObject("btnPrimaria.BackgroundImage"), System.Drawing.Image)
        Me.btnPrimaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrimaria.Location = New System.Drawing.Point(303, 95)
        Me.btnPrimaria.Name = "btnPrimaria"
        Me.btnPrimaria.Size = New System.Drawing.Size(368, 52)
        Me.btnPrimaria.TabIndex = 15
        Me.btnPrimaria.UseVisualStyleBackColor = True
        '
        'btnSecundaria
        '
        Me.btnSecundaria.BackgroundImage = CType(resources.GetObject("btnSecundaria.BackgroundImage"), System.Drawing.Image)
        Me.btnSecundaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSecundaria.Location = New System.Drawing.Point(303, 153)
        Me.btnSecundaria.Name = "btnSecundaria"
        Me.btnSecundaria.Size = New System.Drawing.Size(368, 52)
        Me.btnSecundaria.TabIndex = 16
        Me.btnSecundaria.UseVisualStyleBackColor = True
        '
        'seleccionGrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 418)
        Me.Controls.Add(Me.btnSecundaria)
        Me.Controls.Add(Me.btnPrimaria)
        Me.Controls.Add(Me.btnInicial)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "seleccionGrado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInicial As Button
    Friend WithEvents btnPrimaria As Button
    Friend WithEvents btnSecundaria As Button
End Class
