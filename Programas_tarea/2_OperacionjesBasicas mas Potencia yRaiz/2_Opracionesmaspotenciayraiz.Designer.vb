<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckSuma = New System.Windows.Forms.CheckBox()
        Me.CheckResta = New System.Windows.Forms.CheckBox()
        Me.CheckMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.CheckDivision = New System.Windows.Forms.CheckBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckPotencia = New System.Windows.Forms.CheckBox()
        Me.CheckRaiz = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CheckSuma
        '
        Me.CheckSuma.AutoSize = True
        Me.CheckSuma.Location = New System.Drawing.Point(233, 21)
        Me.CheckSuma.Name = "CheckSuma"
        Me.CheckSuma.Size = New System.Drawing.Size(53, 17)
        Me.CheckSuma.TabIndex = 0
        Me.CheckSuma.Text = "Suma"
        Me.CheckSuma.UseVisualStyleBackColor = True
        '
        'CheckResta
        '
        Me.CheckResta.AutoSize = True
        Me.CheckResta.Location = New System.Drawing.Point(233, 56)
        Me.CheckResta.Name = "CheckResta"
        Me.CheckResta.Size = New System.Drawing.Size(54, 17)
        Me.CheckResta.TabIndex = 1
        Me.CheckResta.Text = "Resta"
        Me.CheckResta.UseVisualStyleBackColor = True
        '
        'CheckMultiplicacion
        '
        Me.CheckMultiplicacion.AutoSize = True
        Me.CheckMultiplicacion.Location = New System.Drawing.Point(233, 98)
        Me.CheckMultiplicacion.Name = "CheckMultiplicacion"
        Me.CheckMultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.CheckMultiplicacion.TabIndex = 2
        Me.CheckMultiplicacion.Text = "Multiplicacion"
        Me.CheckMultiplicacion.UseVisualStyleBackColor = True
        '
        'CheckDivision
        '
        Me.CheckDivision.AutoSize = True
        Me.CheckDivision.Location = New System.Drawing.Point(233, 140)
        Me.CheckDivision.Name = "CheckDivision"
        Me.CheckDivision.Size = New System.Drawing.Size(63, 17)
        Me.CheckDivision.TabIndex = 3
        Me.CheckDivision.Text = "Division"
        Me.CheckDivision.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(367, 75)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 126)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(53, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(367, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Valor1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "valor 2"
        '
        'CheckPotencia
        '
        Me.CheckPotencia.AutoSize = True
        Me.CheckPotencia.Location = New System.Drawing.Point(233, 180)
        Me.CheckPotencia.Name = "CheckPotencia"
        Me.CheckPotencia.Size = New System.Drawing.Size(68, 17)
        Me.CheckPotencia.TabIndex = 11
        Me.CheckPotencia.Text = "Potencia"
        Me.CheckPotencia.UseVisualStyleBackColor = True
        '
        'CheckRaiz
        '
        Me.CheckRaiz.AutoSize = True
        Me.CheckRaiz.Location = New System.Drawing.Point(233, 223)
        Me.CheckRaiz.Name = "CheckRaiz"
        Me.CheckRaiz.Size = New System.Drawing.Size(47, 17)
        Me.CheckRaiz.TabIndex = 12
        Me.CheckRaiz.Text = "Raiz"
        Me.CheckRaiz.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 261)
        Me.Controls.Add(Me.CheckRaiz)
        Me.Controls.Add(Me.CheckPotencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.CheckDivision)
        Me.Controls.Add(Me.CheckMultiplicacion)
        Me.Controls.Add(Me.CheckResta)
        Me.Controls.Add(Me.CheckSuma)
        Me.Name = "Form1"
        Me.Text = "operciones Basicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckSuma As CheckBox
    Friend WithEvents CheckResta As CheckBox
    Friend WithEvents CheckMultiplicacion As CheckBox
    Friend WithEvents CheckDivision As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckPotencia As CheckBox
    Friend WithEvents CheckRaiz As CheckBox
End Class
