Public Class Aplicacion10

    Dim td, cd, tr, cr, saldo As Integer

    Private Sub btnretiro_Click(sender As Object, e As EventArgs) Handles btnretiro.Click

        If txtmonto.Text = "" Or txtmonto.Text = "0" Or IsNumeric(txtmonto.Text) =
False Then
            MsgBox("Debe ingresar solo números mayor a 0",
            MsgBoxStyle.Information, "Banco - El Amigo")
            txtmonto.Focus()
            Exit Sub
        End If
        Dim retiro As Integer
        retiro = Val(txtmonto.Text)
        saldo = Val(lblsaldo.Text)
        If saldo < retiro Then
            MsgBox("La cantidad que desea retirar excede a su saldo actual",
            MsgBoxStyle.Information, "Lo sentimos")
            txtmonto.Text = ""
            txtmonto.Focus()
        Else
            tr = tr + retiro
            cr = cr + 1
            lblcretiro.Text = (cr.ToString)
            lbltretiro.Text = (tr.ToString)
            lblsaldo.Text = ((saldo - retiro).ToString)
        End If

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir de la Aplicacion?", MsgBoxStyle.Question.YesNo,
                  "Banco - El Amigo") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Iniciar()
    End Sub

    Private Sub btndeposito_Click(sender As Object, e As EventArgs) Handles btndeposito.Click

        If txtmonto.Text = "" Or txtmonto.Text = "0" Or IsNumeric(txtmonto.Text) =
False Then
            MsgBox("Debe ingresar solo números mayor a 0",
            MsgBoxStyle.Information, "Banco - El Amigo")
            txtmonto.Focus()
            Exit Sub
        End If
        Dim deposito As Integer
        deposito = Val(txtmonto.Text)
        td = td + deposito
        cd = cd + 1
        'Estas tres líneas de código no es necesario, por que solo le asignaríamos
        'a lblsaldo el valor de la variable td
        'lblsaldo.Text=(td.ToString)
        saldo = Val(lblsaldo.Text)
        saldo = saldo + deposito
        lblsaldo.Text = (saldo.ToString)
        lblcdeposito.Text = (cd.ToString)
        lbltdeposito.Text = (td.ToString)

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If txtcliente.Text = "" Or IsNumeric(txtcliente.Text) = True Then
            MsgBox("Debe de ingresar un nombre, con solo letras",
            MsgBoxStyle.Information, "Banco - El Amigo")
            txtcliente.Text = ""
            txtcliente.Focus()
            Exit Sub
        End If
        txtcliente.ReadOnly = True
        txtmonto.ReadOnly = False
        btnok.Visible = False
        btndeposito.Enabled = True
        btnretiro.Enabled = True
        saldo = Val(InputBox("Monto de Apertura: La cuenta se apertura con
cualquier monto", "Monto de la Nueva Cuenta", 350))
        lblsaldo.Text = (saldo.ToString)
        td = saldo
        cd = 1
        lblcdeposito.Text = (cd.ToString)
        lbltdeposito.Text = (td.ToString)
        txtmonto.Focus()

    End Sub

    Function Iniciar()
        td = 0
        cd = 0
        tr = 0
        cr = 0
        txtcliente.Text = ""
        txtmonto.Text = ""
        lblcdeposito.Text = ""
        lblcretiro.Text = ""
        lbltdeposito.Text = ""
        lbltretiro.Text = ""
        lblsaldo.Text = ""
        btnok.Visible = True
        btndeposito.Enabled = False
        btnretiro.Enabled = False
        txtcliente.ReadOnly = False
        txtmonto.ReadOnly = True
        txtcliente.Focus()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Iniciar()

    End Sub


End Class
