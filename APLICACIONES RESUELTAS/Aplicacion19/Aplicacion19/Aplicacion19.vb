Public Class Aplicacion19

    Dim ArrayText(15), ArrayTemp(15) As Integer

    Function Limpiar(ByVal Condicion As Boolean)
        Dim x As Integer
        For x = 0 To 15
            ArrayText(x) = 0
        Next
        txtarray_0.Text = ""
        txtarray_1.Text = ""
        txtarray_2.Text = ""
        txtarray_3.Text = ""
        txtarray_4.Text = ""
        txtarray_5.Text = ""
        txtarray_6.Text = ""
        txtarray_7.Text = ""
        txtarray_8.Text = ""
        txtarray_9.Text = ""
        txtarray_10.Text = ""
        txtarray_11.Text = ""
        txtarray_12.Text = ""
        txtarray_13.Text = ""
        txtarray_14.Text = ""
        txtarray_15.Text = ""
        btnordenar.Enabled = Condicion
        txtarray_0.Focus()
    End Function

    Private Sub btnordenar_Click(sender As Object, e As EventArgs) Handles btnordenar.Click
        Dim J, Index, Temp As Integer
        'almacenamos el ArrayText en ArrayTemp para guardar los datos
        'para después restaurarlo
        For J = 0 To 15
            ArrayTemp(J) = ArrayText(J)
        Next
        'Método de Ordenación llamada BURBUJA
        For J = 0 To 15
            For Index = 0 To 15
                If Index < 15 Then
                    If ArrayText(Index) > ArrayText(Index + 1) Then
                        Temp = ArrayText(Index)
                        ArrayText(Index) = ArrayText(Index + 1)
                        ArrayText(Index + 1) = Temp
                    End If
                End If
            Next
        Next
        LlenarControles()
        btnrestaurar.Enabled = True
    End Sub

    Private Sub btnrestaurar_Click(sender As Object, e As EventArgs) Handles btnrestaurar.Click
        Dim Index As Integer
        For Index = 0 To 15
            ArrayText(Index) = ArrayTemp(Index)
        Next
        LlenarControles()
    End Sub

    Private Sub btnllenar_Click(sender As Object, e As EventArgs) Handles btnllenar.Click
        Dim Index As Integer
        For Index = 0 To 15
            ArrayText(Index) = Int((50 - 1 + 1) * Rnd() + 1)
        Next
        LlenarControles()
        btnordenar.Enabled = True
        btnrestaurar.Enabled = False
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Limpiar(True)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir de al aplicación?", MsgBoxStyle.Question.YesNo,
"Cuidado") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Function LlenarControles()
        txtarray_0.Text = ArrayText(0)
        txtarray_1.Text = ArrayText(1)
        txtarray_2.Text = ArrayText(2)
        txtarray_3.Text = ArrayText(3)
        txtarray_4.Text = ArrayText(4)
        txtarray_5.Text = ArrayText(5)
        txtarray_6.Text = ArrayText(6)
        txtarray_7.Text = ArrayText(7)
        txtarray_8.Text = ArrayText(8)
        txtarray_9.Text = ArrayText(9)
        txtarray_10.Text = ArrayText(10)
        txtarray_11.Text = ArrayText(11)
        txtarray_12.Text = ArrayText(12)
        txtarray_13.Text = ArrayText(13)
        txtarray_14.Text = ArrayText(14)
        txtarray_15.Text = ArrayText(15)
    End Function

End Class
