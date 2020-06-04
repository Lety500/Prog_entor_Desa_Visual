Imports System.ComponentModel

Public Class Form2
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click

        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtApellido.Text <> String.Empty And Val(txtIdentidad.Text) - Int(Val(txtIdentidad.Text)) = 0 And Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 And txtProfesion.Text <> String.Empty And txtDireccion.Text <> String.Empty Then
                MessageBox.Show("Datos registrados correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese correctamente los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtNombre.Clear()
                txtApellido.Clear()
                txtIdentidad.Clear()
                txtEdad.Clear()
                txtDireccion.Clear()
                txtProfesion.Clear()


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este el Nombre, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este el Apellido, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este el Numero de identidad, este campo es obligatorio")
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If (Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0) Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese una Edad valida")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_Validating(sender As Object, e As CancelEventArgs) Handles ComboBox1.Validating

    End Sub

    Private Sub txtProfesion_TextChanged(sender As Object, e As EventArgs) Handles txtProfesion.TextChanged

    End Sub

    Private Sub txtProfesion_Validating(sender As Object, e As CancelEventArgs) Handles txtProfesion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este la Profesion, campo es obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este la Direccion, este  campo es obligatorio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formulario = New Alumno
        Me.Close()
        formulario.Show()
    End Sub
End Class