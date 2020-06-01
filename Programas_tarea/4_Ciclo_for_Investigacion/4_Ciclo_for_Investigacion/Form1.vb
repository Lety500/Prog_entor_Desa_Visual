Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        For i = 1 To 10
            MsgBox("Este es el numero " & i)
        Next
        MsgBox("Fin del ciclo")
    End Sub


End Class
