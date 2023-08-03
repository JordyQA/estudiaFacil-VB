<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradosInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradosInicial))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rb5Años = New System.Windows.Forms.RadioButton()
        Me.rb4Años = New System.Windows.Forms.RadioButton()
        Me.rb3Años = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(382, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 35)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "*EDAD*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SELECCIONEMOS EL NIVEL DE DIFICULTAD "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(719, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BIENVENIDO ESTIMADO ESTUDIANTE"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.White
        Me.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRegresar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(544, 267)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(136, 38)
        Me.btnRegresar.TabIndex = 15
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
        Me.btnSeleccionar.Location = New System.Drawing.Point(529, 210)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(173, 41)
        Me.btnSeleccionar.TabIndex = 16
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 287)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'rb5Años
        '
        Me.rb5Años.CausesValidation = False
        Me.rb5Años.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5Años.Image = CType(resources.GetObject("rb5Años.Image"), System.Drawing.Image)
        Me.rb5Años.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rb5Años.Location = New System.Drawing.Point(353, 290)
        Me.rb5Años.Name = "rb5Años"
        Me.rb5Años.Size = New System.Drawing.Size(136, 44)
        Me.rb5Años.TabIndex = 3
        Me.rb5Años.Text = "5 Años"
        Me.rb5Años.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb5Años.UseVisualStyleBackColor = True
        '
        'rb4Años
        '
        Me.rb4Años.CausesValidation = False
        Me.rb4Años.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4Años.Image = CType(resources.GetObject("rb4Años.Image"), System.Drawing.Image)
        Me.rb4Años.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rb4Años.Location = New System.Drawing.Point(353, 240)
        Me.rb4Años.Name = "rb4Años"
        Me.rb4Años.Size = New System.Drawing.Size(136, 44)
        Me.rb4Años.TabIndex = 2
        Me.rb4Años.Text = " 4 Años"
        Me.rb4Años.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb4Años.UseVisualStyleBackColor = True
        '
        'rb3Años
        '
        Me.rb3Años.CausesValidation = False
        Me.rb3Años.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb3Años.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3Años.Image = CType(resources.GetObject("rb3Años.Image"), System.Drawing.Image)
        Me.rb3Años.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rb3Años.Location = New System.Drawing.Point(353, 190)
        Me.rb3Años.Name = "rb3Años"
        Me.rb3Años.Size = New System.Drawing.Size(136, 44)
        Me.rb3Años.TabIndex = 1
        Me.rb3Años.Text = "3 Años"
        Me.rb3Años.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb3Años.UseVisualStyleBackColor = True
        '
        'GradosInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(798, 451)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rb5Años)
        Me.Controls.Add(Me.rb4Años)
        Me.Controls.Add(Me.rb3Años)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GradosInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rb5Años As RadioButton
    Friend WithEvents rb4Años As RadioButton
    Friend WithEvents rb3Años As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
