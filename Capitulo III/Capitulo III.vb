Public Class Form1
    Private Sub Aplicacion06ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Aplicacion06ToolStripMenuItem.Click
        Aplicacion06.Show()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Aplicacion07.Show()
    End Sub

    Private Sub IngresoDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeDatosToolStripMenuItem.Click
        Aplicacion08.Show()
    End Sub

    Private Sub IngresoDeDatosAp09ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeDatosAp09ToolStripMenuItem.Click
        Aplicacion09.Show()
    End Sub

    Private Sub BancoElAmigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancoElAmigoToolStripMenuItem.Click
        Aplicacion10.Show()
    End Sub

    Private Sub VentaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDeProductosToolStripMenuItem.Click
        Aplicacion11.Show()
    End Sub

    Private Sub InformacionAcademicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionAcademicaToolStripMenuItem.Click
        Aplicacion12.Show()
    End Sub

    Private Sub EjemploDeFuncionesDeCadenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemploDeFuncionesDeCadenaToolStripMenuItem.Click
        Aplicacion13.Show()
    End Sub

    Private Sub FuncionesTipoFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionesTipoFechaToolStripMenuItem.Click
        funciones.Show()
    End Sub

    Private Sub EjemploDeFuncionesNumericasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemploDeFuncionesNumericasToolStripMenuItem.Click
        Aplicacion15.Show()
    End Sub

    Private Sub UsoDeShellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsoDeShellToolStripMenuItem.Click
        Aplicacion16.Show()
    End Sub

    Private Sub EjemplosDeBuclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemplosDeBuclesToolStripMenuItem.Click
        Aplicacion17.Show()
    End Sub

    Private Sub EjemploDeArraysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjemploDeArraysToolStripMenuItem.Click
        Aplicacion18.Show()
    End Sub

    Private Sub OrdenacionDeUnArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenacionDeUnArrayToolStripMenuItem.Click
        Aplicacion19.Show()
    End Sub

    Private Sub ManejoDeArraysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManejoDeArraysToolStripMenuItem.Click
        Aplicacion20.Show()
    End Sub

    Private Sub OperacionesConArraysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesConArraysToolStripMenuItem.Click
        Aplicacion21.Show()
    End Sub

    Private Sub DatosDelAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelAlumnoToolStripMenuItem.Click
        Aplicacionpro03.Show()
    End Sub

    Private Sub AlzaEnSolesYPorcentajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlzaEnSolesYPorcentajesToolStripMenuItem.Click
        Aplicacionpropuesta04.Show()
    End Sub

    Private Sub HonorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HonorariosToolStripMenuItem.Click
        Aplicacionpropuesta05.Show()
    End Sub

    Private Sub EdadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdadesToolStripMenuItem.Click
        Aplicacionpropuesta06.Show()
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir de la aplicacion", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
