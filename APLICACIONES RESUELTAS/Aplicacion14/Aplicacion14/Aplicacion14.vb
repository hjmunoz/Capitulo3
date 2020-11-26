Public Class funciones
    Private Sub funciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecact.Text = "Hoy es " + (Now()).ToString
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir del programa?", MsgBoxStyle.Question.YesNo,
"Funciones Tipo fecha") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim fecha As Date
        Dim nmes, diasemana As String
        Dim dia, mes, año, ndia As Integer
        If IsDate(txtfecnac.Text) = False Then
            MsgBox("Debe de ingresar un fecha válida, como se muestra en el ejemplo",
            MsgBoxStyle.Information, "Funciones Tipo Fecha")
            txtfecnac.Text = ""
            txtfecnac.Focus()
            Exit Sub
        End If
        fecha = CDate(txtfecnac.Text)
        dia = Microsoft.VisualBasic.Day(fecha)
        mes = Microsoft.VisualBasic.Month(fecha)
        año = Year(fecha)
        ndia = Weekday(fecha)
        lbldiaing.Text = dia.ToString
        lblmesing.Text = mes.ToString
        lblanioing.Text = año.ToString
        Select Case ndia
            Case 1 : diasemana = "Domingo"
            Case 2 : diasemana = "Lunes"
            Case 3 : diasemana = "Martes"
            Case 4 : diasemana = "Miercoles"
            Case 5 : diasemana = "Jueves"
            Case 6 : diasemana = "Viernes"
            Case 7 : diasemana = "Sábado"
        End Select
        lbldiasem.Text = diasemana
        Select Case mes
            Case 1 : nmes = "Enero"
            Case 2 : nmes = "Febrero"
            Case 3 : nmes = "Marzo"
            Case 4 : nmes = "Abril"
            Case 5 : nmes = "Mayo"
            Case 6 : nmes = "Junio"
            Case 7 : nmes = "Julio"
            Case 8 : nmes = "Agosto"
            Case 9 : nmes = "Septiembre"
            Case 10 : nmes = "Octubre"
            Case 11 : nmes = "Noviembre"
            Case 12 : nmes = "Diciembre"
        End Select
        lblfecing.Text = diasemana + ", " + dia.ToString + " de " + nmes + " de " +
        año.ToString
    End Sub
End Class
