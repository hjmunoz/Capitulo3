Public Class Aplicacion13
    Function Limpiar(ByVal condicion As Boolean)
        txtfrase.Text = ""
        lbllongitud.Text = ""
        lblprimer.Text = ""
        lblultimo.Text = ""
        lblsegasexto.Text = ""
        lblposA.Text = ""
        lblminusculas.Text = ""
        lblmayusculas.Text = ""
        lbltitulo.Text = ""
        btnmuestra.Enabled = condicion
        btnnueva.Enabled = Not condicion
        txtfrase.Focus()
    End Function

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

        If MsgBox("¿Deseas salir de la aplicación?", MsgBoxStyle.Question.YesNo,
"Ejemplo de Cadenas") = MsgBoxResult.Yes Then Me.Close()

    End Sub

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        Limpiar(True)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar(False)
    End Sub

    Private Sub btnmuestra_Click(sender As Object, e As EventArgs) Handles btnmuestra.Click

        lbllongitud.Text = (Len(Trim(txtfrase.Text))).ToString
        lblprimer.Text = Microsoft.VisualBasic.Left(Trim(txtfrase.Text), 1)
        lblultimo.Text = Microsoft.VisualBasic.Right(Trim(txtfrase.Text), 1)
        lblsegasexto.Text = Mid(Trim(txtfrase.Text), 2, 5)
        lblposA.Text = InStr(txtfrase.Text, "a")
        lblminusculas.Text = LCase(txtfrase.Text)
        lblmayusculas.Text = UCase(txtfrase.Text)
        lbltitulo.Text = StrConv(txtfrase.Text, VbStrConv.ProperCase)

    End Sub
End Class
