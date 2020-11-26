Public Class Aplicacion11

    Function Iniciar(ByVal activar As Boolean)
        txtproducto.Text = ""
        txtprecuni.Text = ""
        txtcantcomp.Text = ""
        lblsubtotal.Text = ""
        lbldescp.Text = ""
        lbldescs.Text = ""
        lbltotal.Text = ""
        btncalcular.Enabled = activar
        btnnuevo.Enabled = Not activar
        txtproducto.Focus()
    End Function

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Iniciar(True)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar(False)
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question.YesNo,
                  "Venta de Productos") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        Dim desc As Single
        lblsubtotal.Text = (Format(Val(txtprecuni.Text) * Val(txtcantcomp.Text),
        "### ###.##")).ToString
        Select Case Val(lblsubtotal.Text)
            Case 100 Or 101
                desc = 0.02
            Case 101.1 To 200
                desc = 0.04
            Case 200.1 To 500
                desc = 0.06
            Case Is > 501
                desc = 0.1
            Case Is < 0
                MsgBox("Error: No se permiten cantidades y precios negativos",
                MsgBoxStyle.Information, "Venta de Productos")
        End Select
        lbldescp.Text = (desc * 100).ToString + " %"
        lbldescs.Text = (Format(desc * Val(lblsubtotal.Text), "###
##0.##")).ToString
        lbltotal.Text = (Format(Val(lblsubtotal.Text) - Val(lbldescs.Text), "###
##0.##")).ToString
        btncalcular.Enabled = False
        btnnuevo.Enabled = True
    End Sub
End Class
