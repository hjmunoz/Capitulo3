Public Class Aplicacion06
    Private Sub btnincrementa_Click(sender As Object, e As EventArgs) Handles btnincrementa.Click

        Dim a As Integer
        Static b As Integer
        a = a + 1
        b = b + 1
        lbla.Text = a
        lblb.Text = b

    End Sub
End Class
