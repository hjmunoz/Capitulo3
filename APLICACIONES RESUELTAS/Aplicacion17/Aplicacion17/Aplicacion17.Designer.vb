<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion17
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblletra = New System.Windows.Forms.Label()
        Me.lblascii = New System.Windows.Forms.Label()
        Me.lblbinario = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese un texto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Letra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor ascii"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor binario"
        '
        'lblletra
        '
        Me.lblletra.AutoSize = True
        Me.lblletra.Location = New System.Drawing.Point(191, 96)
        Me.lblletra.Name = "lblletra"
        Me.lblletra.Size = New System.Drawing.Size(39, 13)
        Me.lblletra.TabIndex = 4
        Me.lblletra.Text = "Label5"
        '
        'lblascii
        '
        Me.lblascii.AutoSize = True
        Me.lblascii.Location = New System.Drawing.Point(191, 140)
        Me.lblascii.Name = "lblascii"
        Me.lblascii.Size = New System.Drawing.Size(39, 13)
        Me.lblascii.TabIndex = 5
        Me.lblascii.Text = "Label6"
        '
        'lblbinario
        '
        Me.lblbinario.AutoSize = True
        Me.lblbinario.Location = New System.Drawing.Point(191, 185)
        Me.lblbinario.Name = "lblbinario"
        Me.lblbinario.Size = New System.Drawing.Size(39, 13)
        Me.lblbinario.TabIndex = 6
        Me.lblbinario.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(67, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "                     "
        '
        'txttexto
        '
        Me.txttexto.Location = New System.Drawing.Point(194, 52)
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(203, 20)
        Me.txttexto.TabIndex = 8
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(194, 238)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 9
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Aplicacion17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txttexto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblbinario)
        Me.Controls.Add(Me.lblascii)
        Me.Controls.Add(Me.lblletra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacion17"
        Me.Text = "Ejemplos de bucles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblletra As Label
    Friend WithEvents lblascii As Label
    Friend WithEvents lblbinario As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txttexto As TextBox
    Friend WithEvents btnok As Button
End Class
