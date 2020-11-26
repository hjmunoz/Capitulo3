Public Class Aplicacion07
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnom.Text = ""
        txthtn.Text = ""
        txthe.Text = ""
        txtpxhn.Text = ""
        txtpxhe.Text = ""
        lbltxhn.Text = ""
        lbltxhe.Text = ""
        lblsubtotal.Text = ""
        lbldescuento.Text = ""
        lbltp.Text = ""
        txtnom.Focus()
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim hnt, het, phn, phe, thn, the, st, des, tp As Single
        Const descuento = 10
        hnt = Val(txthtn.Text) 'Horas Normales Trabajadas
        het = Val(txthe.Text) 'Horas Extras Trabajadas
        phn = Val(txtpxhn.Text) 'Pago por Horas Normales
        phe = Val(txtpxhe.Text) 'Pago por Horas Extras
        thn = hnt * phn 'Total de Pago por las Horas Normales
        the = het * phe 'Total de Pago por las Horas Extras
        st = thn - the 'Sub Total
        des = st * descuento / 100 'Descuento
        tp = st - des 'Total a Pagar
        lbltxhn.Text = Format(thn, "### ###.##")
        lbltxhe.Text = Format(the, "### ###.##")
        lblsubtotal.Text = Format(st, "### ###.##")
        lbldescuento.Text = Format(des, "### ###.##")
        lbltp.Text = Format(tp, "### ###.##")
    End Sub
End Class
