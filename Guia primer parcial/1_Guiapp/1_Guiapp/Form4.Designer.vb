<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSuperior = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventas de almacenes"
        '
        'btnComenzar
        '
        Me.btnComenzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.Location = New System.Drawing.Point(222, 121)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(95, 46)
        Me.btnComenzar.TabIndex = 1
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Media de ventas mensual"
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(73, 302)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtMedia.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Almacenes cn ventas superior a la media"
        '
        'txtSuperior
        '
        Me.txtSuperior.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.txtSuperior.Location = New System.Drawing.Point(295, 284)
        Me.txtSuperior.Multiline = True
        Me.txtSuperior.Name = "txtSuperior"
        Me.txtSuperior.Size = New System.Drawing.Size(265, 150)
        Me.txtSuperior.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSuperior)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Almacenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnComenzar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSuperior As TextBox
    Friend WithEvents Button1 As Button
End Class
