Public Class Form4
    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Dim ventas As Integer
        Dim sumaVentas As Integer
        Dim media As Double
        Dim arreglo(9) As Integer
        sumaVentas = 0

        For i = 0 To 9 Step 1
            ventas = InputBox("Ingrese las  ventas del almacen" & i, "Ventas")
            arreglo(i) = ventas
            sumaVentas = sumaVentas + ventas
        Next

        media = sumaVentas / 10

        For i = 0 To 9 Step 1

            If arreglo(i) > media Then

                txtSuperior.Text = arreglo(i)
            Else
                txtSuperior.Text = ""
            End If
        Next




        media = sumaVentas / 10
        txtMedia.Text = media



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class