Imports System.ComponentModel

Public Class Alumno
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Me.ValidateChildren And txtNombre2.Text <> String.Empty And txtApellido2.Text <> String.Empty And Val(txtIdentidad2.Text) - Int(Val(txtIdentidad2.Text)) = 0 And Val(txtEdad2.Text) - Int(Val(txtEdad2.Text)) = 0 Then
                MessageBox.Show("Datos registrados correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Proceso finalizado satisfactoriamente ", "Finalizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else
                MessageBox.Show("Ingrese correctamente los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNombre2.Clear()
                txtApellido2.Clear()
                txtIdentidad2.Clear()
                txtEdad2.Clear()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtNombre2_TextChanged(sender As Object, e As EventArgs) Handles txtNombre2.TextChanged

    End Sub

    Private Sub txtNombre2_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono2.SetError(sender, "")
        Else
            Me.erroricono2.SetError(sender, "Este el Nombre, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtApellido2_TextChanged(sender As Object, e As EventArgs) Handles txtApellido2.TextChanged

    End Sub

    Private Sub txtApellido2_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono2.SetError(sender, "")
        Else
            Me.erroricono2.SetError(sender, "Este el Apellido, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtIdentidad2_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad2.TextChanged

    End Sub

    Private Sub txtIdentidad2_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono2.SetError(sender, "")
        Else
            Me.erroricono2.SetError(sender, "Este el Numero de identidad, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtEdad2_TextChanged(sender As Object, e As EventArgs) Handles txtEdad2.TextChanged

    End Sub

    Private Sub txtEdad2_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad2.Validating
        If (Val(txtEdad2.Text) - Int(Val(txtEdad2.Text)) = 0) Then
            Me.erroricono2.SetError(sender, "")
        Else
            Me.erroricono2.SetError(sender, "Ingrese una Edad valida")
        End If
    End Sub

    Private Sub txtPago_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged


    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Select Case ComboBox2.SelectedIndex
            Case = 0
                txtPago.Text = "L.1000"
            Case = 1
                txtPago.Text = "L.2000"
            Case = 2
                txtPago.Text = "L3000"
            Case = 3
                txtPago.Text = "L.4000"
            Case = 4
                txtPago.Text = "L.5000"
            Case = 5
                txtPago.Text = "L.6000"
            Case = 6
                txtPago.Text = "L.7000"
            Case = 7
                txtPago.Text = "L.8000"
            Case = 8
                txtPago.Text = "L.9000"
        End Select
    End Sub
End Class