Public Class LoginForm1
    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            OK.Focus()
        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Static Intentos As Integer

        While (Intentos < 3)

            If UsernameTextBox.Text = "Hector" Or UsernameTextBox.Text = "HECTOR" Or UsernameTextBox.Text = "hector" Then

                If txtpassword.Text = "123456" Then

                    MsgBox("Bienvenido")
                    Form1.Show()
                    Me.Hide()

                Else

                    MsgBox("Usuario o contraseña invalida, usted lleva" & Intentos + 1 & " intento de 3", MsgBoxStyle.Information, "Acceso denegado")
                    UsernameTextBox.Text = ""
                    txtpassword.Text = ""
                    UsernameTextBox.Focus()
                    Intentos = Intentos + 1

                End If



            Else

                MsgBox("Usuario o contraseña invalida, usted lleva" & Intentos + 1 & " intento de 3", MsgBoxStyle.Information, "Acceso denegado")
                UsernameTextBox.Text = ""
                txtpassword.Text = ""
                UsernameTextBox.Focus()
                Intentos = Intentos + 1

                If Intentos = 3 Then
                    MsgBox("Detectado", MsgBoxStyle.Critical, "Cuidado")
                    Me.Close()
                End If


            End If

            Exit While

        End While
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        Me.Close()

    End Sub
End Class
