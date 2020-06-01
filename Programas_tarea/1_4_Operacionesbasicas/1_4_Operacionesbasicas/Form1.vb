Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
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
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
