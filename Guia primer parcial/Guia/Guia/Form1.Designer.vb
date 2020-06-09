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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulaTrigonometricaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CantidadDeNumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SueldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.FormulaTrigonometricaToolStripMenuItem, Me.AlmacenesToolStripMenuItem, Me.CantidadDeNumerosToolStripMenuItem, Me.SueldoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'FormulaTrigonometricaToolStripMenuItem
        '
        Me.FormulaTrigonometricaToolStripMenuItem.Name = "FormulaTrigonometricaToolStripMenuItem"
        Me.FormulaTrigonometricaToolStripMenuItem.Size = New System.Drawing.Size(148, 20)
        Me.FormulaTrigonometricaToolStripMenuItem.Text = "Formula Trigonometrica"
        '
        'AlmacenesToolStripMenuItem
        '
        Me.AlmacenesToolStripMenuItem.Name = "AlmacenesToolStripMenuItem"
        Me.AlmacenesToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AlmacenesToolStripMenuItem.Text = "Almacenes"
        '
        'CantidadDeNumerosToolStripMenuItem
        '
        Me.CantidadDeNumerosToolStripMenuItem.Name = "CantidadDeNumerosToolStripMenuItem"
        Me.CantidadDeNumerosToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.CantidadDeNumerosToolStripMenuItem.Text = "Cantidad de Numeros"
        '
        'SueldoToolStripMenuItem
        '
        Me.SueldoToolStripMenuItem.Name = "SueldoToolStripMenuItem"
        Me.SueldoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SueldoToolStripMenuItem.Text = "Sueldo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 354)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulaTrigonometricaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CantidadDeNumerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SueldoToolStripMenuItem As ToolStripMenuItem
End Class
