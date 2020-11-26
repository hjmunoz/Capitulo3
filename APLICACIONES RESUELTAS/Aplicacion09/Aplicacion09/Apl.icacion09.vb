Public Class Aplicacion09

    Function Limpia()
        txtapenom.Text = ""
        txtfecing.Text = ""
        txtturno.Text = ""
        txtpromedio.Text = ""
        btnnuevo.Enabled = False
        btnsalir.Enabled = False
        txtapenom.Focus()
    End Function

    Function Limpiar()
        txtapenom.Text = ""
        txtfecing.Text = ""
        txtturno.Text = ""
        txtpromedio.Text = ""
        btnnuevo.Enabled = False
        btnsalir.Enabled = False
        txtapenom.Focus()
    End Function

    Function Mayuscula(ByVal v)
        If (v >= 65 And v <= 90) Then
            Mayuscula = True
        Else
            Mayuscula = False
        End If
    End Function

    Function Numero(ByVal v)
        If (v < 48 Or v > 57) Then
            Numero = False
        Else
            Numero = True
        End If
    End Function

    Function Especial(ByVal v)
        If (v = 13 Or v = 32 Or v = 8 Or v = 225 Or v = 233 Or v = 237 Or v = 243 Or v = 250 Or v = 241 Or v = 209) Then
            Especial = True
        Else
            Especial = False
        End If
    End Function

    Function Ingresados()
        If Trim(txtapenom.Text) <> "" And IsDate(txtfecing.Text) And
        Trim(txtturno.Text) <> "" And Trim(txtpromedio.Text) <> "" Then
            btnnuevo.Enabled = True
            btnsalir.Enabled = True
        Else
            btnnuevo.Enabled = False
            btnsalir.Enabled = False
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpia()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Limpia()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question.YesNo,
"Cuidado") = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub txtapenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapenom.KeyPress
        Dim a, b, Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        If Asc(e.KeyChar) = 13 Then
            txtfecing.Focus()
        End If
        Longitud = (txtapenom.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(txtapenom.Text, 1)
            Caracter = UCase(Caracter)
            txtapenom.Text = ""
            txtapenom.Text = Caracter
            txtapenom.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(txtapenom.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(txtapenom.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(txtapenom.Text, 1)
            Caracter = UCase(Caracter)
            txtapenom.Text = ""
            txtapenom.Text = Temp + Caracter
            txtapenom.SelectionStart = Longitud + 1
        End If
    End Sub

    Private Sub txtfecing_Leave(sender As Object, e As EventArgs) Handles txtfecing.Leave
        If IsDate(txtfecing.Text) Then
            Ingresados()
        Else
            MsgBox("Debe de ingresar una fecha correcta", MsgBoxStyle.Information,
            "Cuidado")
            txtfecing.SelectionStart = 0
            txtfecing.SelectionLength = Len(txtfecing.Text)
            txtfecing.Text = txtfecing.SelectedText
            txtfecing.Focus()
        End If
    End Sub

    Private Sub txtfecing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfecing.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtturno.Focus()
        End If
    End Sub

    Private Sub txtturno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtturno.KeyPress
        Dim Letra As String
        Dim Caracter As Char
        Letra = UCase(e.KeyChar)
        If Asc(e.KeyChar) = 13 Then
            Caracter = Microsoft.VisualBasic.Left(txtturno.Text, 1)
            If Caracter <> "M" And Caracter <> "T" And Caracter <> "N" Then
                MsgBox("Debe de Ingresar sólo letras M, T o N",
                MsgBoxStyle.Information, "Error")
                txtturno.Text = ""
                txtturno.Focus()
                Exit Sub
            Else
                txtpromedio.Focus()
            End If
        Else
            txtturno.Text = ""
            If Letra <> "M" And Letra <> "T" And Letra <> "N" Then
                MsgBox("Debe de Ingresar sólo letras M, T o N",
                MsgBoxStyle.Information, "Error")
                txtturno.Focus()
                btnnuevo.Enabled = False
                btnsalir.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtpromedio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpromedio.KeyPress
        If Numero(Asc(e.KeyChar)) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            Ingresados()
        Else
            MsgBox("Debe de Ingresar sólo número", MsgBoxStyle.Information, "Error")
            txtpromedio.Text = ""
            txtpromedio.Focus()
            btnnuevo.Enabled = False
            btnsalir.Enabled = False
        End If
    End Sub

    Private Sub txtpromedio_TextChanged(sender As Object, e As EventArgs) Handles txtpromedio.TextChanged
        If Val(txtpromedio.Text) < 0 Or Val(txtpromedio.Text) > 20 Then
            MsgBox("El promedio debe estar entre 0 y 20", MsgBoxStyle.Information,
            "Error")
            txtpromedio.SelectionStart = 0
            txtpromedio.SelectionLength = Len(txtpromedio.Text)
            txtpromedio.Text = txtpromedio.SelectedText
            txtpromedio.Focus()
            btnnuevo.Enabled = False
            btnsalir.Enabled = False
        Else
            Ingresados()
        End If
    End Sub

    Private Sub txtapenom_TextChanged(sender As Object, e As EventArgs) Handles txtapenom.TextChanged
        Ingresados()
    End Sub

    Private Sub txtturno_TextChanged(sender As Object, e As EventArgs) Handles txtturno.TextChanged
        Ingresados()
    End Sub

    Private Sub txtturno_Leave(sender As Object, e As EventArgs) Handles txtturno.Leave
        Dim Caracter As Char
        Caracter = Microsoft.VisualBasic.Left(txtturno.Text, 1)
        If Caracter <> "M" And Caracter <> "T" And Caracter <> "N" Then
            MsgBox("Debe de Ingresar sólo letras M, T o N", MsgBoxStyle.Information,
            "Error")
            txtturno.Text = ""
            txtturno.Focus()
            Exit Sub
        Else
            txtpromedio.Focus()
        End If
    End Sub
End Class
