<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnSeno = New System.Windows.Forms.Button()
        Me.btnTangente = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnRaizn = New System.Windows.Forms.Button()
        Me.btnRaizcua = New System.Windows.Forms.Button()
        Me.btnInverso = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESARROLLO DE PLATAFORMAS DE SOFTWARE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(22, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SERVICIO WEB - OPERACIONES ARITMÉTICAS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número 2:"
        '
        'txtNro1
        '
        Me.txtNro1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro1.Location = New System.Drawing.Point(141, 78)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(100, 23)
        Me.txtNro1.TabIndex = 4
        '
        'txtNro2
        '
        Me.txtNro2.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.txtNro2.Location = New System.Drawing.Point(141, 104)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(100, 23)
        Me.txtNro2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Seleccione la Operación"
        '
        'btnSumar
        '
        Me.btnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumar.Location = New System.Drawing.Point(62, 187)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(57, 37)
        Me.btnSumar.TabIndex = 7
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.Location = New System.Drawing.Point(62, 230)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(57, 37)
        Me.btnRestar.TabIndex = 8
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(62, 273)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(57, 37)
        Me.btnMultiplicar.TabIndex = 10
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(62, 316)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(57, 37)
        Me.btnDividir.TabIndex = 9
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnSeno
        '
        Me.btnSeno.Location = New System.Drawing.Point(151, 273)
        Me.btnSeno.Name = "btnSeno"
        Me.btnSeno.Size = New System.Drawing.Size(73, 37)
        Me.btnSeno.TabIndex = 14
        Me.btnSeno.Text = "Seno"
        Me.btnSeno.UseVisualStyleBackColor = True
        '
        'btnTangente
        '
        Me.btnTangente.Location = New System.Drawing.Point(151, 316)
        Me.btnTangente.Name = "btnTangente"
        Me.btnTangente.Size = New System.Drawing.Size(73, 37)
        Me.btnTangente.TabIndex = 13
        Me.btnTangente.Text = "Tangente"
        Me.btnTangente.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Location = New System.Drawing.Point(151, 230)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(73, 37)
        Me.btnPotencia.TabIndex = 12
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(151, 187)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(73, 37)
        Me.btnFactorial.TabIndex = 11
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnRaizn
        '
        Me.btnRaizn.Location = New System.Drawing.Point(243, 273)
        Me.btnRaizn.Name = "btnRaizn"
        Me.btnRaizn.Size = New System.Drawing.Size(88, 37)
        Me.btnRaizn.TabIndex = 16
        Me.btnRaizn.Text = "Raíz N-sima"
        Me.btnRaizn.UseVisualStyleBackColor = True
        '
        'btnRaizcua
        '
        Me.btnRaizcua.Location = New System.Drawing.Point(243, 187)
        Me.btnRaizcua.Name = "btnRaizcua"
        Me.btnRaizcua.Size = New System.Drawing.Size(88, 37)
        Me.btnRaizcua.TabIndex = 15
        Me.btnRaizcua.Text = "Raiz Cuadrada"
        Me.btnRaizcua.UseVisualStyleBackColor = True
        '
        'btnInverso
        '
        Me.btnInverso.Location = New System.Drawing.Point(243, 230)
        Me.btnInverso.Name = "btnInverso"
        Me.btnInverso.Size = New System.Drawing.Size(88, 37)
        Me.btnInverso.TabIndex = 17
        Me.btnInverso.Text = "Inverso"
        Me.btnInverso.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 375)
        Me.Controls.Add(Me.btnInverso)
        Me.Controls.Add(Me.btnRaizn)
        Me.Controls.Add(Me.btnRaizcua)
        Me.Controls.Add(Me.btnSeno)
        Me.Controls.Add(Me.btnTangente)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "GRUPO PICATECLAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnSeno As Button
    Friend WithEvents btnTangente As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnRaizn As Button
    Friend WithEvents btnRaizcua As Button
    Friend WithEvents btnInverso As Button
End Class
