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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.btnNumeros = New System.Windows.Forms.Button()
        Me.btnSueldo = New System.Windows.Forms.Button()
        Me.btnCuadratica = New System.Windows.Forms.Button()
        Me.btnAlmacenes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ejercicios de guia primer parcial"
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadora.Location = New System.Drawing.Point(91, 121)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(117, 56)
        Me.btnCalculadora.TabIndex = 1
        Me.btnCalculadora.Text = "Calculadora"
        Me.btnCalculadora.UseVisualStyleBackColor = True
        '
        'btnNumeros
        '
        Me.btnNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumeros.Location = New System.Drawing.Point(91, 208)
        Me.btnNumeros.Name = "btnNumeros"
        Me.btnNumeros.Size = New System.Drawing.Size(114, 53)
        Me.btnNumeros.TabIndex = 2
        Me.btnNumeros.Text = "Numeros"
        Me.btnNumeros.UseVisualStyleBackColor = True
        '
        'btnSueldo
        '
        Me.btnSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSueldo.Location = New System.Drawing.Point(253, 208)
        Me.btnSueldo.Name = "btnSueldo"
        Me.btnSueldo.Size = New System.Drawing.Size(102, 53)
        Me.btnSueldo.TabIndex = 3
        Me.btnSueldo.Text = "Sueldo"
        Me.btnSueldo.UseVisualStyleBackColor = True
        '
        'btnCuadratica
        '
        Me.btnCuadratica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadratica.Location = New System.Drawing.Point(253, 121)
        Me.btnCuadratica.Name = "btnCuadratica"
        Me.btnCuadratica.Size = New System.Drawing.Size(102, 56)
        Me.btnCuadratica.TabIndex = 4
        Me.btnCuadratica.Text = "Formula Cuadratica"
        Me.btnCuadratica.UseVisualStyleBackColor = True
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacenes.Location = New System.Drawing.Point(418, 121)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(99, 56)
        Me.btnAlmacenes.TabIndex = 5
        Me.btnAlmacenes.Text = "Almacenes"
        Me.btnAlmacenes.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(419, 208)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 53)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 405)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAlmacenes)
        Me.Controls.Add(Me.btnCuadratica)
        Me.Controls.Add(Me.btnSueldo)
        Me.Controls.Add(Me.btnNumeros)
        Me.Controls.Add(Me.btnCalculadora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Guia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents btnNumeros As Button
    Friend WithEvents btnSueldo As Button
    Friend WithEvents btnCuadratica As Button
    Friend WithEvents btnAlmacenes As Button
    Friend WithEvents btnSalir As Button
End Class
