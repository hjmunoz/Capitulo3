Public Class Aplicacion16
    Private Sub btncalcelct_Click(sender As Object, e As EventArgs) Handles btncalcelct.Click
        Shell("D:\Windows\System32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnword_Click(sender As Object, e As EventArgs) Handles btnword.Click
        Shell("D:\Archivos de programa\Microsoft Office\OFFICE11\winword.exe",
AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub btnexcel_Click(sender As Object, e As EventArgs) Handles btnexcel.Click
        Shell("D:\Archivos de programa\Microsoft Office\OFFICE11\excel.exe",
AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub btnexplorador_Click(sender As Object, e As EventArgs) Handles btnexplorador.Click
        Shell("D:\WINDOWS\explorer.exe", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        Shell("D:\WINDOWS\system32\cmd.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnfinalizar_Click(sender As Object, e As EventArgs) Handles btnfinalizar.Click
        If MsgBox("¿Deseas salir de la aplicación?", MsgBoxStyle.Question.YesNo,
"Uso de Shell") = MsgBoxResult.Yes Then Me.Close()
    End Sub
End Class
