Public Class Form3
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPoruno.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim a, b, c, d As Double

        a = Val(txtValora.Text)
        b = Val(txtValorb.Text)
        c = Val(txtValorc.Text)
        d = ((b ^ 2) - 4 * a * c)

        If (a <> 0) Then
            If ((d) < 0) Then
                TextBox1.Text = "No hay solucion para esta ecuacion"
                txtPoruno.Text = ""
                txtPordos.Text = ""
            Else
                txtPoruno.Text = (-b + (d) ^ (1 / 2) / (2 * a))
                TextBox1.Text = ""
                txtPordos.Text = (-b - (d) ^ (1 / 2) / (2 * a))
                TextBox1.Text = ""

            End If
        Else
            TextBox1.Text = "(a) debe ser diferente de cero"
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtValora.Clear()
        txtValorb.Clear()
        txtValorc.Clear()
        txtPoruno.Clear()
        txtPordos.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class