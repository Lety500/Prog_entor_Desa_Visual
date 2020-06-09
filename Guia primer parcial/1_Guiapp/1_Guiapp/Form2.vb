Public Class Form2
    Dim operacion As Integer
    Dim respuesta As Nullable(Of Double) = Nothing
    Dim respuesta2 As Nullable(Of Double) = Nothing
    Dim presionaoperador As Boolean

    Private Sub btncero_Click(sender As Object, e As EventArgs) Handles btncero.Click
        evaluarestricciones()
        txtcalcu.Text &= "0"
    End Sub

    Private Sub btnambos_Click(sender As Object, e As EventArgs) Handles btnambos.Click

    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        evaluarestricciones()
        If InStr(txtcalcu.Text, ".", CompareMethod.Text) = 0 Then
            txtcalcu.Text &= "."
        End If
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        operacion = 11
        EvaluayOpera()

    End Sub

    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        evaluarestricciones()
        txtcalcu.Text &= "1"
    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        evaluarestricciones()
        txtcalcu.Text &= "2"
    End Sub

    Private Sub btntres_Click(sender As Object, e As EventArgs) Handles btntres.Click
        evaluarestricciones()
        txtcalcu.Text &= "3"
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        operacion = 12
        EvaluayOpera()

    End Sub

    Private Sub btncuatro_Click(sender As Object, e As EventArgs) Handles btncuatro.Click
        evaluarestricciones()
        txtcalcu.Text &= "4"
    End Sub

    Private Sub btncinco_Click(sender As Object, e As EventArgs) Handles btncinco.Click
        evaluarestricciones()
        txtcalcu.Text &= "5"
    End Sub

    Private Sub btnseis_Click(sender As Object, e As EventArgs) Handles btnseis.Click
        evaluarestricciones()
        txtcalcu.Text &= "6"
    End Sub

    Private Sub btnpor_Click(sender As Object, e As EventArgs) Handles btnpor.Click
        operacion = 13
        EvaluayOpera()

    End Sub

    Private Sub btnsiete_Click(sender As Object, e As EventArgs) Handles btnsiete.Click
        evaluarestricciones()
        txtcalcu.Text &= "7"
    End Sub

    Private Sub btnocho_Click(sender As Object, e As EventArgs) Handles btnocho.Click
        evaluarestricciones()
        txtcalcu.Text &= "8"
    End Sub

    Private Sub btnnueve_Click(sender As Object, e As EventArgs) Handles btnnueve.Click
        evaluarestricciones()
        txtcalcu.Text &= "9"
    End Sub

    Private Sub btnentre_Click(sender As Object, e As EventArgs) Handles btnentre.Click
        operacion = 14
        EvaluayOpera()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcalcu.Text = "0"
        respuesta2 = Nothing
        respuesta = Nothing
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        EvaluayOpera()

    End Sub


    Public Sub EvaluayOpera()
        presionaoperador = True
        respuesta2 = Val(txtcalcu.Text)
        If respuesta IsNot Nothing Then
            Select Case operacion
                Case 11
                    respuesta = respuesta + respuesta2
                Case 12
                    respuesta -= respuesta2
                Case 13
                    respuesta *= respuesta2
                Case 14
                    respuesta /= respuesta2
            End Select
            txtcalcu.Text = respuesta
        End If
    End Sub

    Public Sub evaluarestricciones()
        If presionaoperador = True Then
            txtcalcu.Text = ""
            presionaoperador = False
        ElseIf presionaoperador = "0" Then
            txtcalcu.Text = ""
        End If
    End Sub
End Class