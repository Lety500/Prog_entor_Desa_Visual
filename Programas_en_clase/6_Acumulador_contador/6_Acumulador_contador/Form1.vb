Public Class Form1
    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        Try
            Dim precio, total, totalPagar, orden As Integer
            orden = txtorden.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingrese el precio del platillo No." & i, "^Precio del platillo")
                totalPagar += precio

            Next
            total = totalPagar / orden
            txtTotal.Text = totalPagar
            txtIndividual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtorden.Clear()
        txtTotal.Clear()
        txtIndividual.Clear()
    End Sub
End Class
