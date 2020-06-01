Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Integer

        If CheckSuma.Checked = True Then
            Label1.Text = "Suma"
            TextBox3.Text = Val(TextBox1.Text + TextBox2.Text)
        End If

        If CheckResta.Checked = True Then
            Label1.Text = "Suma"
            TextBox3.Text = Val(TextBox1.Text - TextBox2.Text)
        End If

        If CheckMultiplicacion.Checked = True Then
            Label1.Text = "Suma"
            TextBox3.Text = Val(TextBox1.Text * TextBox2.Text)
        End If

        If CheckDivision.Checked = True Then
            Label1.Text = "Suma"
            TextBox3.Text = Val(TextBox1.Text / TextBox2.Text)
        End If

        If CheckPotencia.Checked = True Then
            Label1.Text = "Suma"
            TextBox3.Text = Val(TextBox1.Text ^ TextBox2.Text)
        End If


        If CheckRaiz.Checked = True Then
            numero = Val(TextBox1.Text)
            If numero < 0 Then
                MsgBox("Numero Invalidopor ser negativo")
                TextBox1.Text = ""
            Else
                TextBox3.Text = numero ^ (1 / 2)
            End If

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
