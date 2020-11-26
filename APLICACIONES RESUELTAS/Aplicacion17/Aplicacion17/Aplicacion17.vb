Public Class Aplicacion17
    Function Binario(ByVal num As Integer)
        Dim ValorBin As String
        Dim resto As Integer
        Do While num > 1
            resto = num Mod 2
            num = num / 2
            ValorBin = Trim(Str(resto)) + Trim(ValorBin)
        Loop
        ValorBin = Trim(Str(num)) + ValorBin
        Binario = ValorBin
    End Function

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim Texto, Letra As String
        Dim x, Valor As Integer
        Dim t As Single
        Texto = Trim(txttexto.Text)
        Label8.Visible = True
        For x = 1 To Len(txttexto.Text)
            lblbinario.Text = ""
            Letra = Microsoft.VisualBasic.Mid(txttexto.Text, x, 1)
            lblletra.Text = Letra
            Valor = Asc(Letra)
            lblascii.Text = Valor.ToString
            lblbinario.Text = Binario(Valor)
            Label8.Text = lblbinario.Text
            For t = 1 To 5000 Step 0.1
                Label8.Left = t
            Next
        Next
    End Sub
End Class
