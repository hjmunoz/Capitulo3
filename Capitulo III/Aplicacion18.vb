Public Class Aplicacion18
    Dim D(6) As String

    Private Sub Aplicacion18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        D(0) = "Lunes"
        D(1) = "Martes"
        D(2) = "Miercoles"
        D(3) = "Jueves"
        D(4) = "Viernes"
        D(5) = "Sábado"
        D(6) = "Domingo"
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtnum.Text = "" Or Val(txtnum.Text) < 1 Or Val(txtnum.Text) > 7 Then
            MsgBox("Ingrese un número correcto del 1 al 7", MsgBoxStyle.Information,
            "Ejemplo de Arreglos")
            txtnum.Text = ""
            txtnum.Focus()
            Exit Sub
        End If
        Dim N As Integer
        N = Val(txtnum.Text) - 1
        lbldia.Text = "El número ingresado representa el día " + D(N)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir del programa?", MsgBoxStyle.Question.YesNo,
"Ejemplo de Arrays") = MsgBoxResult.Yes Then Me.Close()
    End Sub
End Class
