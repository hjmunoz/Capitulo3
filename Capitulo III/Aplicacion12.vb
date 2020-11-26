Public Class Aplicacion12

    Function Limpiar(ByVal condicion As Boolean)
        txtalumno.Text = ""
        txtcurso.Text = ""
        txtn1.Text = ""
        txtn2.Text = ""
        lblpromedio.Text = ""
        lblobservacion.Text = ""
        lblpuntos.Text = ""
        lblcualidad.Text = ""
        btnotro.Enabled = condicion
        btnpromedio.Enabled = Not condicion
        txtalumno.Focus()
    End Function

    Private Sub btnfinalizar_Click(sender As Object, e As EventArgs) Handles btnfinalizar.Click

        If MsgBox("¿Deseas salir del programa?", MsgBoxStyle.Question.YesNo,
                  "Información Académica") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnotro_Click(sender As Object, e As EventArgs) Handles btnotro.Click

        Limpiar(False)

    End Sub

    Private Sub Aplicacion12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Limpiar(False)

    End Sub

    Private Sub btnpromedio_Click(sender As Object, e As EventArgs) Handles btnpromedio.Click

        If txtn1.Text = "" Or Val(txtn1.Text) < 0 Or Val(txtn1.Text) > 20 Or
IsNumeric(txtn1.Text) = False Then
            MsgBox("Tiene que ingresar solo números entre 0 y 20 en la primera nota",
            MsgBoxStyle.Information, "Información Académica")
            txtn1.Text = ""
            txtn1.Focus()
            Exit Sub
        ElseIf txtn2.Text = "" Or Val(txtn2.Text) < 0 Or Val(txtn2.Text) > 20 Or
        IsNumeric(txtn2.Text) = False Then
            MsgBox("Tiene que ingresar solo números entre 0 y 20 en la segunda
nota", MsgBoxStyle.Information, "Información Académica")
            txtn2.Text = ""
            txtn2.Focus()
            Exit Sub
        End If
        Dim promedio As Single
        promedio = (Val(txtn1.Text) + Val(txtn2.Text)) / 2
        If promedio >= 0 And promedio < 10.5 Then
            lblpuntos.Text = "Le faltan " + (10.5 - promedio).ToString + " para se
aprobado(a)"
            lblpromedio.ForeColor = System.Drawing.Color.Red
            lblpromedio.Text = promedio.ToString
            lblobservacion.Text = "Desaprobado(a)"
        ElseIf promedio > 10.4 And promedio < 20.1 Then
            lblpuntos.Text = "Le faltan " + (20 - promedio).ToString + " para llegar a
20"
            lblpromedio.ForeColor = System.Drawing.Color.Blue
            lblpromedio.Text = promedio.ToString
            lblobservacion.Text = "Aprobado(a)"
        End If
        Select Case promedio
            Case 0 To 5
                lblcualidad.Text = "Pésimo"
            Case 5.1 To 10.4
                lblcualidad.Text = "Malo"
            Case 10.5 To 14.4
                lblcualidad.Text = "Regular"
            Case 14.5 To 17.4
                lblcualidad.Text = "Bueno"
            Case 17.5 To 20
                lblcualidad.Text = "Excelente"
        End Select
        btnotro.Enabled = True
        btnpromedio.Enabled = False

    End Sub
End Class
