Public Class Aplicacion15

    Function Limpiar()
        txtnum.Text = ""
        lblpartent.Text = ""
        lblpartdec.Text = ""
        lblvalabs.Text = ""
        lblraizcuad.Text = ""
        lblsigno.Text = ""
        lblvaloct.Text = ""
        lblvalhex.Text = ""
        txtnum.Focus()
    End Function

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        Limpiar()
    End Sub

    Private Sub Aplicacion15_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Limpiar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question.YesNo,
"Ejemplo de Funciones Numéricas") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub btnmuestra_Click(sender As Object, e As EventArgs) Handles btnmuestra.Click
        If IsNumeric(txtnum.Text) = False Then
            MsgBox("Debe de Ingresar un valor numérico", MsgBoxStyle.Information,
            "Ejemplo de Funciones Numéricas")
            txtnum.Text = ""
            txtnum.Focus()
            Exit Sub
        End If
        Dim num As Double
        num = Val(txtnum.Text)
        lblpartent.Text = (Int(num)).ToString
        lblpartdec.Text = (Format(num - Val(lblpartent.Text), "0.#####")).ToString
        lblvalabs.Text = (Math.Abs(num)).ToString
        If num > 0 Then
            lblraizcuad.Text = (Format(Math.Sqrt(num), "###.#######")).ToString
        Else
            lblraizcuad.Text = "No Existe"
        End If
        If Math.Sign(num).ToString = "-1" Then
            lblsigno.Text = "Negativo"
        Else
            lblsigno.Text = "Positivo"
        End If
        lblvaloct.Text = (Oct(num)).ToString
        lblvalhex.Text = (Hex(num)).ToString
    End Sub
End Class
