Public Class Aplicacionpropuesta06



    Function Limpiar()
        txtnombre.Text = ""
        txtaño.Text = ""
        lbledad.Text = ""
        lblobservacion.Text = ""
        lblaño.Text = ""
        lbletapa.Text = ""
        txtnombre.Focus()
    End Function

    Private Sub Aplicacionpropuesta06_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Limpiar()
        txtnombre.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblfecha.Text = Year(Now)
    End Sub

    Private Sub btnresultado_Click(sender As Object, e As EventArgs) Handles btnresultado.Click
        lbledad.Text = Val(lblfecha.Text) - Val(txtaño.Text)

        If lbledad.Text >= 18 Then

            lblobservacion.Text = "Mayor de edad"

        Else

            lblobservacion.Text = "Menor de edad"
        End If

        If lblobservacion.Text = "Menor de edad" Then

            lblaño.Text = 18 - Val(lbledad.Text)

        ElseIf lblobservacion.Text = "Mayor de edad" Then
            lblaño.Text = Val(lbledad.Text) - 18
        End If
        If lbledad.Text > 0 And lbledad.Text <= 12 Then
            lbletapa.Text = "Niño"
        ElseIf lbledad.Text > 13 And lbledad.Text <= 17 Then
            lbletapa.Text = "Adolecente"
        ElseIf lbledad.Text > 17 And lbledad.Text <= 30 Then
            lbletapa.Text = "Joven"
        ElseIf lbledad.Text > 30 And lbledad.Text <= 70 Then
            lbletapa.Text = "Adulto"
        ElseIf lbledad.Text > 71 Then
            lbletapa.Text = "Anciano"
        End If
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Limpiar()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MsgBox("Desea salir de la aplicacion", MsgBoxStyle.Question.YesNoCancel, "Cuidado") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtaño.Focus()
        End If
    End Sub

    Private Sub txtaño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaño.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnresultado.Focus()
        End If
    End Sub
End Class
