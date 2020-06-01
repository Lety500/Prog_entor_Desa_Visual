Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCliente.Clear()
        txtRTN.Clear()
        txtDireccion.Clear()
        txtFecha.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtdescuento.Clear()
        txtSubtotal.Clear()
        txtISV.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        txtSubtotal.Text = (Val(txtCantidad.Text) * Val(txtPrecio.Text))

        If txtSubtotal.Text >= 1500 Then
            txtdescuento.Text = (Val(txtSubtotal.Text) * 0.05)

        Else
            txtdescuento.Text = 0
        End If
        txtISV.Text = (Val(txtSubtotal.Text) * 0.015)
        txtTotal.Text = (Val(txtSubtotal.Text) - Val(txtdescuento.Text) + Val(txtISV.Text))
    End Sub
End Class
