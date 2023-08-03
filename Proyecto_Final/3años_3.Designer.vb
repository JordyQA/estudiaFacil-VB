<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _3años_3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_3años_3))
        Me.bttSiguiente = New System.Windows.Forms.Button()
        Me.bttO = New System.Windows.Forms.Button()
        Me.bttU = New System.Windows.Forms.Button()
        Me.bttI = New System.Windows.Forms.Button()
        Me.bttE = New System.Windows.Forms.Button()
        Me.bttA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttSiguiente
        '
        Me.bttSiguiente.Location = New System.Drawing.Point(374, 402)
        Me.bttSiguiente.Name = "bttSiguiente"
        Me.bttSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.bttSiguiente.TabIndex = 65
        Me.bttSiguiente.Text = "Siguiente"
        Me.bttSiguiente.UseVisualStyleBackColor = True
        '
        'bttO
        '
        Me.bttO.BackgroundImage = CType(resources.GetObject("bttO.BackgroundImage"), System.Drawing.Image)
        Me.bttO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttO.Location = New System.Drawing.Point(232, 251)
        Me.bttO.Name = "bttO"
        Me.bttO.Size = New System.Drawing.Size(139, 126)
        Me.bttO.TabIndex = 64
        Me.bttO.UseVisualStyleBackColor = True
        '
        'bttU
        '
        Me.bttU.BackgroundImage = CType(resources.GetObject("bttU.BackgroundImage"), System.Drawing.Image)
        Me.bttU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttU.Location = New System.Drawing.Point(458, 251)
        Me.bttU.Name = "bttU"
        Me.bttU.Size = New System.Drawing.Size(139, 126)
        Me.bttU.TabIndex = 63
        Me.bttU.UseVisualStyleBackColor = True
        '
        'bttI
        '
        Me.bttI.BackgroundImage = CType(resources.GetObject("bttI.BackgroundImage"), System.Drawing.Image)
        Me.bttI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttI.Location = New System.Drawing.Point(552, 87)
        Me.bttI.Name = "bttI"
        Me.bttI.Size = New System.Drawing.Size(139, 126)
        Me.bttI.TabIndex = 62
        Me.bttI.UseVisualStyleBackColor = True
        '
        'bttE
        '
        Me.bttE.BackgroundImage = CType(resources.GetObject("bttE.BackgroundImage"), System.Drawing.Image)
        Me.bttE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttE.Location = New System.Drawing.Point(336, 87)
        Me.bttE.Name = "bttE"
        Me.bttE.Size = New System.Drawing.Size(139, 126)
        Me.bttE.TabIndex = 61
        Me.bttE.UseVisualStyleBackColor = True
        '
        'bttA
        '
        Me.bttA.BackgroundImage = CType(resources.GetObject("bttA.BackgroundImage"), System.Drawing.Image)
        Me.bttA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttA.Location = New System.Drawing.Point(110, 87)
        Me.bttA.Name = "bttA"
        Me.bttA.Size = New System.Drawing.Size(139, 126)
        Me.bttA.TabIndex = 60
        Me.bttA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(341, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 35)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "VOWELS"
        '
        '_3años_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttSiguiente)
        Me.Controls.Add(Me.bttO)
        Me.Controls.Add(Me.bttU)
        Me.Controls.Add(Me.bttI)
        Me.Controls.Add(Me.bttE)
        Me.Controls.Add(Me.bttA)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_3años_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_3años_3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttSiguiente As Button
    Friend WithEvents bttO As Button
    Friend WithEvents bttU As Button
    Friend WithEvents bttI As Button
    Friend WithEvents bttE As Button
    Friend WithEvents bttA As Button
    Friend WithEvents Label1 As Label
End Class
