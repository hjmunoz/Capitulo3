<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacionpropuesta04
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtprecioanterior = New System.Windows.Forms.TextBox()
        Me.txtprecioactual = New System.Windows.Forms.TextBox()
        Me.lblalzasol = New System.Windows.Forms.Label()
        Me.lblalzapor = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio anterior S/."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio actual S/."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alza en soles S/."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alza en porcentajes"
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(233, 79)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(216, 20)
        Me.txtproducto.TabIndex = 5
        '
        'txtprecioanterior
        '
        Me.txtprecioanterior.Location = New System.Drawing.Point(233, 116)
        Me.txtprecioanterior.Name = "txtprecioanterior"
        Me.txtprecioanterior.Size = New System.Drawing.Size(100, 20)
        Me.txtprecioanterior.TabIndex = 6
        '
        'txtprecioactual
        '
        Me.txtprecioactual.Location = New System.Drawing.Point(233, 154)
        Me.txtprecioactual.Name = "txtprecioactual"
        Me.txtprecioactual.Size = New System.Drawing.Size(100, 20)
        Me.txtprecioactual.TabIndex = 7
        '
        'lblalzasol
        '
        Me.lblalzasol.AutoSize = True
        Me.lblalzasol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblalzasol.Location = New System.Drawing.Point(233, 195)
        Me.lblalzasol.Name = "lblalzasol"
        Me.lblalzasol.Size = New System.Drawing.Size(84, 15)
        Me.lblalzasol.TabIndex = 8
        Me.lblalzasol.Text = "                         "
        '
        'lblalzapor
        '
        Me.lblalzapor.AutoSize = True
        Me.lblalzapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblalzapor.Location = New System.Drawing.Point(233, 234)
        Me.lblalzapor.Name = "lblalzapor"
        Me.lblalzapor.Size = New System.Drawing.Size(84, 15)
        Me.lblalzapor.TabIndex = 9
        Me.lblalzapor.Text = "                         "
        '
        'btnnuevo
        '
        Me.btnnuevo.AutoSize = True
        Me.btnnuevo.Location = New System.Drawing.Point(98, 274)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(94, 23)
        Me.btnnuevo.TabIndex = 10
        Me.btnnuevo.Text = "Nuevo producto"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(233, 274)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(94, 23)
        Me.btncalcular.TabIndex = 11
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(355, 274)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(94, 23)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Aplicacionpropuesta04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 341)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.lblalzapor)
        Me.Controls.Add(Me.lblalzasol)
        Me.Controls.Add(Me.txtprecioactual)
        Me.Controls.Add(Me.txtprecioanterior)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacionpropuesta04"
        Me.Text = "Alza en soles y en porcentajes           "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtprecioanterior As TextBox
    Friend WithEvents txtprecioactual As TextBox
    Friend WithEvents lblalzasol As Label
    Friend WithEvents lblalzapor As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnsalir As Button
End Class
