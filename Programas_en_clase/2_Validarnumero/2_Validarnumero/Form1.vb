Public Class Form1
    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

        Dim valor As Int16

        If txtNumero.Text = "" Then
            MsgBox("Ingrese un valor en la casilla", vbInformation)

        ElseIf Not IsNumeric(txtNumero.text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtNumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNumero.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)

            ElseIf valor > 0 Then
                MsgBox("Numero positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero Negativo")
            End If

        End If
    End Sub
End Class
