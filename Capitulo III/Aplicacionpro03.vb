Public Class Aplicacionpro03

    Function limpiar()
        txtalumno.Text = ""
        txtespecialidad.Text = ""
        txtciclo.Text = ""
        txtturno.Text = ""
        txtaula.Text = ""
    End Function






    Private Sub txtalumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtalumno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtespecialidad.Focus()
        End If
    End Sub

    Private Sub txtespecialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtespecialidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtciclo.Focus()
        End If
    End Sub

    Private Sub txtciclo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtciclo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtturno.Focus()
        End If
    End Sub

    Private Sub txtturno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtturno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtaula.Focus()
        End If
    End Sub

    Private Sub txtaula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaula.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnsalir.Focus()
        End If
    End Sub

    Private Sub btnalumno_Click(sender As Object, e As EventArgs) Handles btnalumno.Click
        limpiar()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Aplicacionpro03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Fecha.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class
