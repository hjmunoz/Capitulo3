Public Class Aplicacion20
    Dim ArrayControl(15), ArrayTemp(3, 3), ArraySuma(3), Suma(3) As Integer
    Dim Index, Temp, X, Y As Integer

    Private Sub btnLimpRes_Click(sender As Object, e As EventArgs) Handles btnLimpRes.Click
        LimpiarResultados()
    End Sub

    Private Sub btnSumaC_Click(sender As Object, e As EventArgs) Handles btnSumaC.Click
        AsignarArray()
        For X = 0 To 3
            ArraySuma(X) = 0
            For Y = 0 To 3
                ArraySuma(X) = ArraySuma(X) + ArrayTemp(Y, X)
            Next
        Next
        For Index = 0 To 3
            Suma(Index) = ArraySuma(Index)
        Next
        lblresC1.Text = Suma(0)
        lblresC2.Text = Suma(1)
        lblresC3.Text = Suma(2)
        lblresC4.Text = Suma(3)
    End Sub

    Private Sub btnSumaF_Click(sender As Object, e As EventArgs) Handles btnSumaF.Click
        AsignarArray()
        For Y = 0 To 3
            ArraySuma(Y) = 0
            For X = 0 To 3
                ArraySuma(Y) = ArraySuma(Y) + ArrayTemp(Y, X)
            Next
        Next
        For Index = 0 To 3
            Suma(Index) = ArraySuma(Index)
        Next
        lblresF1.Text = Suma(0)
        lblresF2.Text = Suma(1)
        lblresF3.Text = Suma(2)
        lblresF4.Text = Suma(3)
    End Sub

    Private Sub btnColum1_Click(sender As Object, e As EventArgs) Handles btnColum1.Click
        AsignarArray()
        Temp = 0
        For X = 0 To 3
            Temp = Temp + ArrayTemp(X, 0)
        Next
        lblresC1.Text = Temp
    End Sub

    Private Sub btnColum2_Click(sender As Object, e As EventArgs) Handles btnColum2.Click
        AsignarArray()
        Temp = 0
        For X = 0 To 3
            Temp = Temp + ArrayTemp(X, 1)
        Next
        lblresC2.Text = Temp
    End Sub

    Private Sub btnColum3_Click(sender As Object, e As EventArgs) Handles btnColum3.Click
        AsignarArray()
        Temp = 0
        For X = 0 To 3
            Temp = Temp + ArrayTemp(X, 2)
        Next
        lblresC3.Text = Temp
    End Sub

    Private Sub btnColum4_Click(sender As Object, e As EventArgs) Handles btnColum4.Click
        AsignarArray()
        Temp = 0
        For X = 0 To 3
            Temp = Temp + ArrayTemp(X, 3)
        Next
        lblresC4.Text = Temp
    End Sub

    Private Sub btnFila1_Click(sender As Object, e As EventArgs) Handles btnFila1.Click
        AsignarArray()
        Temp = 0
        For Y = 0 To 3
            Temp = Temp + ArrayTemp(0, Y)
        Next
        lblresF1.Text = Temp
    End Sub

    Private Sub btnFila2_Click(sender As Object, e As EventArgs) Handles btnFila2.Click
        AsignarArray()
        Temp = 0
        For Y = 0 To 3
            Temp = Temp + ArrayTemp(1, Y)
        Next
        lblresF2.Text = Temp
    End Sub

    Private Sub btnFila3_Click(sender As Object, e As EventArgs) Handles btnFila3.Click
        AsignarArray()
        Temp = 0
        For Y = 0 To 3
            Temp = Temp + ArrayTemp(2, Y)
        Next
        lblresF3.Text = Temp
    End Sub

    Private Sub btnFila4_Click(sender As Object, e As EventArgs) Handles btnFila4.Click
        AsignarArray()
        Temp = 0
        For Y = 0 To 3
            Temp = Temp + ArrayTemp(3, Y)
        Next
        lblresF4.Text = Temp
    End Sub

    Private Sub btnDiagonal1_Click(sender As Object, e As EventArgs) Handles btnDiagonal1.Click
        AsignarArray()
        Temp = 0
        For Index = 0 To 3
            Temp = Temp + ArrayTemp(Index, 3 - Index)
        Next
        lblresD1.Text = Temp
    End Sub

    Private Sub btnDiagonal2_Click(sender As Object, e As EventArgs) Handles btnDiagonal2.Click
        AsignarArray()
        Temp = 0
        For Index = 0 To 3
            Temp = Temp + ArrayTemp(Index, Index)
        Next
        lblresD2.Text = Temp
    End Sub

    Private Sub btnLimpArray_Click(sender As Object, e As EventArgs) Handles btnLimpArray.Click
        LimpiarArray()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea Salir de la Aplicación?", MsgBoxStyle.Question.YesNo,
"Cuidado") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Function LimpiarArray()
        For Index = 0 To 15
            ArrayControl(Index) = 0
        Next
        For X = 0 To 3
            For Y = 0 To 3
                ArrayTemp(X, Y) = 0
            Next
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
        txtarray_0.Focus()
    End Function

    Function AsignarArray()
        ArrayControl(0) = Val(txtarray_0.Text)
        ArrayControl(1) = Val(txtarray_1.Text)
        ArrayControl(2) = Val(txtarray_2.Text)
        ArrayControl(3) = Val(txtarray_3.Text)
        ArrayControl(4) = Val(txtarray_4.Text)
        ArrayControl(5) = Val(txtarray_5.Text)
        ArrayControl(6) = Val(txtarray_6.Text)
        ArrayControl(7) = Val(txtarray_7.Text)
        ArrayControl(8) = Val(txtarray_8.Text)
        ArrayControl(9) = Val(txtarray_9.Text)
        ArrayControl(10) = Val(txtarray_10.Text)
        ArrayControl(11) = Val(txtarray_11.Text)
        ArrayControl(12) = Val(txtarray_12.Text)
        ArrayControl(13) = Val(txtarray_13.Text)
        ArrayControl(14) = Val(txtarray_14.Text)
        ArrayControl(15) = Val(txtarray_15.Text)
        Index = 0
        For X = 0 To 3
            For Y = 0 To 3
                ArrayTemp(X, Y) = ArrayControl(Index)
                Index = Index + 1
            Next
        Next
    End Function

    Function LimpiarResultados()
        lblresD1.Text = ""
        lblresD2.Text = ""
        lblresC1.Text = ""
        lblresC2.Text = ""
        lblresC3.Text = ""
        lblresC4.Text = ""
        lblresF1.Text = ""
        lblresF2.Text = ""
        lblresF3.Text = ""
        lblresF4.Text = ""
    End Function

    Function LimpiarArraySuma()
        For Index = 0 To 3
            Suma(Index) = 0
        Next
    End Function
End Class
