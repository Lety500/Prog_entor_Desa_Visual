Public Class Form5
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumeros.Clear()
        txtPares.Clear()
        txtImpares.Clear()
        txtPositivos.Clear()
        txtNegativos.Clear()
        txtCantidad.Clear()
        txtSuma.Clear()
        ComboBox1.Items.Clear()

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim numeros, num, pares, impares, positivos, negativos, cantidad, suma As Integer
        impares = 0
        pares = 0
        positivos = 0
        negativos = 0
        cantidad = 0
        suma = 0
        numeros = txtNumeros.Text

        For i = 1 To numeros Step 1
            num = InputBox("Ingrese  un numero", "Ingresar numero")
            Me.ComboBox1.Items.Add(num)

            If num Mod 2 = 0 Then
                pares = pares + 1
            Else
                impares = impares + 1
            End If

            If num > 0 Then
                positivos = positivos + 1
            Else
                negativos = negativos + 1
            End If

            cantidad = cantidad + 1
            suma = suma + num

        Next

        txtPares.Text = pares
        txtImpares.Text = impares
        txtPositivos.Text = positivos
        txtNegativos.Text = negativos
        txtCantidad.Text = cantidad
        txtSuma.Text = suma
    End Sub
End Class