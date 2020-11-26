Public Class Aplicacion21

    Dim ArrayA(8), ArrayB(8) As Integer
    Dim ArrayResp(8) As String
    Dim Index As Integer

    Function AsignarControlA()
        txta_0.Text = ArrayA(0)
        txta_1.Text = ArrayA(1)
        txta_2.Text = ArrayA(2)
        txta_3.Text = ArrayA(3)
        txta_4.Text = ArrayA(4)
        txta_5.Text = ArrayA(5)
        txta_6.Text = ArrayA(6)
        txta_7.Text = ArrayA(7)
        txta_8.Text = ArrayA(8)
    End Function

    Function AsignarControlB()
        txtb_0.Text = ArrayB(0)
        txtb_1.Text = ArrayB(1)
        txtb_2.Text = ArrayB(2)
        txtb_3.Text = ArrayB(3)
        txtb_4.Text = ArrayB(4)
        txtb_5.Text = ArrayB(5)
        txtb_6.Text = ArrayB(6)
        txtb_7.Text = ArrayB(7)
        txtb_8.Text = ArrayB(8)
    End Function

    Function LlenarResultado()
        lblres_0.Text = ArrayResp(0)
        lblres_1.Text = ArrayResp(1)
        lblres_2.Text = ArrayResp(2)
        lblres_3.Text = ArrayResp(3)
        lblres_4.Text = ArrayResp(4)
        lblres_5.Text = ArrayResp(5)
        lblres_6.Text = ArrayResp(6)
        lblres_7.Text = ArrayResp(7)
        lblres_8.Text = ArrayResp(8)
    End Function

    Function LimpiarArrays()
        For Index = 0 To 8
            ArrayA(Index) = 0
            ArrayB(Index) = 0
            ArrayResp(Index) = 0
        Next
    End Function

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question.YesNo,
"Cuidado") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        Randomize()
        For Index = 0 To 8
            ArrayA(Index) = Int((10 - (-5) + 1) * Rnd() + (-5))
            ArrayB(Index) = Int((10 - (-5) + 1) * Rnd() + (-5))
        Next
        AsignarControlA()
        AsignarControlB()
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        For Index = 0 To 8
            ArrayResp(Index) = ArrayA(Index) + ArrayB(Index)
        Next
        LlenarResultado()
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        For Index = 0 To 8
            ArrayResp(Index) = ArrayA(Index) - ArrayB(Index)
        Next
        LlenarResultado()
    End Sub

    Private Sub btnmultiplica_Click(sender As Object, e As EventArgs) Handles btnmultiplica.Click
        For Index = 0 To 8
            ArrayResp(Index) = ArrayA(Index) * ArrayB(Index)
        Next
        LlenarResultado()
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        For Index = 0 To 8
            If ArrayB(Index) <> 0 Then
                ArrayResp(Index) = Format(ArrayA(Index) / ArrayB(Index), "###
##0.##")
            Else
                ArrayResp(Index) = "NE"
            End If
        Next
        LlenarResultado()
    End Sub

    Private Sub btnecuacion_Click(sender As Object, e As EventArgs) Handles btnecuacion.Click
        For Index = 0 To 8
            ArrayResp(Index) = (ArrayA(Index) * 2) + (ArrayB(Index) * 3)
        Next
        LlenarResultado()
    End Sub

    Private Sub Aplicacion21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        LimpiarControles()
        LimpiarArrays()
    End Sub

    Function LimpiarControles()
        txta_0.Text = ""
        txta_1.Text = ""
        txta_2.Text = ""
        txta_3.Text = ""
        txta_4.Text = ""
        txta_5.Text = ""
        txta_6.Text = ""
        txta_7.Text = ""
        txta_8.Text = ""
        txtb_0.Text = ""
        txtb_1.Text = ""
        txtb_2.Text = ""
        txtb_3.Text = ""
        txtb_4.Text = ""
        txtb_5.Text = ""
        txtb_6.Text = ""
        txtb_7.Text = ""
        txtb_8.Text = ""
        lblres_0.Text = ""
        lblres_1.Text = ""
        lblres_2.Text = ""
        lblres_3.Text = ""
        lblres_4.Text = ""
        lblres_5.Text = ""
        lblres_6.Text = ""
        lblres_7.Text = ""
        lblres_8.Text = ""
    End Function


End Class
