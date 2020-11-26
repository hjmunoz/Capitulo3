Public Class Aplicacionpropuesta04

    Function limpiar()
        txtproducto.Text = ""
        txtprecioactual.Text = ""
        txtprecioanterior.Text = ""
        lblalzapor.Text = ""
        lblalzasol.Text = ""
        txtproducto.Focus()
    End Function

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        lblalzasol.Text = txtprecioactual.Text - txtprecioanterior.Text
        lblalzapor.Text = ((txtprecioactual.Text - txtprecioanterior.Text) * 100) / txtprecioanterior.Text
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea Salir de la Aplicación?", MsgBoxStyle.Question.YesNo,
"Aplicación N° 08") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtprecioanterior.Focus()
        End If
    End Sub

    Private Sub txtprecioanterior_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioanterior.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtprecioactual.Focus()
        End If
    End Sub

    Private Sub txtprecioactual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioactual.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btncalcular.Focus()
        End If
    End Sub
End Class
