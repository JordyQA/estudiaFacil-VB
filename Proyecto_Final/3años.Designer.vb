<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3años
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
        Me.bttSiguiente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttRed = New System.Windows.Forms.Button()
        Me.bttOrange = New System.Windows.Forms.Button()
        Me.bttBlack = New System.Windows.Forms.Button()
        Me.bttGray = New System.Windows.Forms.Button()
        Me.bttBlue = New System.Windows.Forms.Button()
        Me.bttYellow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttSiguiente
        '
        Me.bttSiguiente.Location = New System.Drawing.Point(369, 410)
        Me.bttSiguiente.Name = "bttSiguiente"
        Me.bttSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.bttSiguiente.TabIndex = 45
        Me.bttSiguiente.Text = "Siguiente"
        Me.bttSiguiente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(324, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 35)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "COLORS"
        '
        'bttRed
        '
        Me.bttRed.BackColor = System.Drawing.Color.Red
        Me.bttRed.ForeColor = System.Drawing.Color.Yellow
        Me.bttRed.Location = New System.Drawing.Point(564, 256)
        Me.bttRed.Name = "bttRed"
        Me.bttRed.Size = New System.Drawing.Size(142, 125)
        Me.bttRed.TabIndex = 43
        Me.bttRed.UseVisualStyleBackColor = False
        '
        'bttOrange
        '
        Me.bttOrange.BackColor = System.Drawing.Color.Orange
        Me.bttOrange.ForeColor = System.Drawing.Color.Yellow
        Me.bttOrange.Location = New System.Drawing.Point(324, 256)
        Me.bttOrange.Name = "bttOrange"
        Me.bttOrange.Size = New System.Drawing.Size(142, 125)
        Me.bttOrange.TabIndex = 42
        Me.bttOrange.UseVisualStyleBackColor = False
        '
        'bttBlack
        '
        Me.bttBlack.BackColor = System.Drawing.Color.Black
        Me.bttBlack.ForeColor = System.Drawing.Color.Yellow
        Me.bttBlack.Location = New System.Drawing.Point(95, 256)
        Me.bttBlack.Name = "bttBlack"
        Me.bttBlack.Size = New System.Drawing.Size(142, 125)
        Me.bttBlack.TabIndex = 41
        Me.bttBlack.UseVisualStyleBackColor = False
        '
        'bttGray
        '
        Me.bttGray.BackColor = System.Drawing.Color.Gray
        Me.bttGray.ForeColor = System.Drawing.Color.Yellow
        Me.bttGray.Location = New System.Drawing.Point(564, 78)
        Me.bttGray.Name = "bttGray"
        Me.bttGray.Size = New System.Drawing.Size(142, 125)
        Me.bttGray.TabIndex = 40
        Me.bttGray.UseVisualStyleBackColor = False
        '
        'bttBlue
        '
        Me.bttBlue.BackColor = System.Drawing.Color.Blue
        Me.bttBlue.ForeColor = System.Drawing.Color.Yellow
        Me.bttBlue.Location = New System.Drawing.Point(324, 78)
        Me.bttBlue.Name = "bttBlue"
        Me.bttBlue.Size = New System.Drawing.Size(142, 125)
        Me.bttBlue.TabIndex = 39
        Me.bttBlue.UseVisualStyleBackColor = False
        '
        'bttYellow
        '
        Me.bttYellow.BackColor = System.Drawing.Color.Yellow
        Me.bttYellow.ForeColor = System.Drawing.Color.Yellow
        Me.bttYellow.Location = New System.Drawing.Point(95, 78)
        Me.bttYellow.Name = "bttYellow"
        Me.bttYellow.Size = New System.Drawing.Size(142, 125)
        Me.bttYellow.TabIndex = 38
        Me.bttYellow.UseVisualStyleBackColor = False
        '
        '_3años
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttSiguiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttRed)
        Me.Controls.Add(Me.bttOrange)
        Me.Controls.Add(Me.bttBlack)
        Me.Controls.Add(Me.bttGray)
        Me.Controls.Add(Me.bttBlue)
        Me.Controls.Add(Me.bttYellow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_3años"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_3años"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttSiguiente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bttRed As Button
    Friend WithEvents bttOrange As Button
    Friend WithEvents bttBlack As Button
    Friend WithEvents bttGray As Button
    Friend WithEvents bttBlue As Button
    Friend WithEvents bttYellow As Button
End Class
