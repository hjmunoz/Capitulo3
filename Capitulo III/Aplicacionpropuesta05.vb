Public Class Aplicacionpropuesta05

    Function limpiar()
        txtnombre.Text = ""
        txthorat.Text = ""
        txthorae.Text = ""
        lblpagoho.Text = ""
        lbltotaln.Text = ""
        lbltotale.Text = ""
        lbltotalp.Text = ""
        txtnombre.Focus()
    End Function

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txthorat.Focus()
        End If
    End Sub

    Private Sub txthorat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthorat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txthorae.Focus()
        End If
    End Sub

    Private Sub txthorae_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthorae.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btncalcular.focus()
        End If
    End Sub

    Private Sub btnotro_Click(sender As Object, e As EventArgs) Handles btnotro.Click
        limpiar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Quiere sair de la aplicacion", MsgBoxStyle.Question.YesNoCancel, "Cuidado") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        If txthorat.Text > 48 Then

            lblpagoho.Text = 8.0

        ElseIf txthorat.Text <= 48 Then

            lblpagoho.Text = 7.0

        End If

        lbltotaln.Text = txthorat.Text * lblpagoho.Text
        lbltotale.Text = txthorae.Text * 9.5
        lbltotalp.Text = Val(lbltotaln.Text) + Val(lbltotale.Text)

    End Sub
End Class
