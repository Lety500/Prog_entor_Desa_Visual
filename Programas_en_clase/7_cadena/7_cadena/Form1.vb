Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtcadena.Text
        txtLongitud.Text = cadena.Length
        txtultimo.Text = cadena.Substring(cadena.Length - 1, 1)
        txtprimer.Text = cadena.Substring(0, 1)
        txtposi.Text = cadena.Substring(2, 7)
        txtposicion.Text = cadena.IndexOf("B", 0) + 1
        txtMayuscula.Text = cadena.ToUpper
        txtMinuscula.Text = cadena.ToLower
        txtespacio.Text = cadena.Replace("", "")




    End Sub
End Class
