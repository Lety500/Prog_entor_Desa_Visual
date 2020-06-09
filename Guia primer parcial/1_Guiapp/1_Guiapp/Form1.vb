Public Class Form1
    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click
        Dim formulario = New Form2
        formulario.Show()
    End Sub

    Private Sub btnCuadratica_Click(sender As Object, e As EventArgs) Handles btnCuadratica.Click
        Dim formulario = New Form3
        formulario.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAlmacenes_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        Dim formulario = New Form4
        formulario.Show()
    End Sub

    Private Sub btnNumeros_Click(sender As Object, e As EventArgs) Handles btnNumeros.Click
        Dim formulario = New Form5
        formulario.Show()
    End Sub
End Class
