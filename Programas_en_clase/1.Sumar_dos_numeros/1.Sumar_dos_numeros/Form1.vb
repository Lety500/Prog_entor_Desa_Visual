Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Valor1, Valor2, Suma As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Suma = Valor1 + Valor2

        txtSuma.Text = Suma
    End Sub
End Class
