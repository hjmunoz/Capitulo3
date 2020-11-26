Public Class Aplicacion08
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtce.Text = ""
        txtobservaciones.Text = ""
        txtnombre.Focus()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea Salir de la Aplicación?", MsgBoxStyle.Question.YesNo,
"Aplicación N° 08") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdireccion.Focus()
        End If
    End Sub

    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txttelefono.Focus()
        End If
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtce.Focus()
        End If
    End Sub

    Private Sub txtce_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtce.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtobservaciones.Focus()
        End If
    End Sub

    Private Sub txtobservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtobservaciones.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnsalir.Focus()
        End If
    End Sub
End Class
