<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion10
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
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblcdeposito = New System.Windows.Forms.Label()
        Me.lblcretiro = New System.Windows.Forms.Label()
        Me.lbltdeposito = New System.Windows.Forms.Label()
        Me.lbltretiro = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btndeposito = New System.Windows.Forms.Button()
        Me.btnretiro = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto de movimiento"
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsaldo.Location = New System.Drawing.Point(187, 378)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(66, 15)
        Me.lblsaldo.TabIndex = 2
        Me.lblsaldo.Text = "                   "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SALDO ACTUAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Deposito"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Retiro"
        '
        'lblcdeposito
        '
        Me.lblcdeposito.AutoSize = True
        Me.lblcdeposito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcdeposito.Location = New System.Drawing.Point(98, 308)
        Me.lblcdeposito.Name = "lblcdeposito"
        Me.lblcdeposito.Size = New System.Drawing.Size(69, 15)
        Me.lblcdeposito.TabIndex = 8
        Me.lblcdeposito.Text = "                    "
        '
        'lblcretiro
        '
        Me.lblcretiro.AutoSize = True
        Me.lblcretiro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcretiro.Location = New System.Drawing.Point(98, 341)
        Me.lblcretiro.Name = "lblcretiro"
        Me.lblcretiro.Size = New System.Drawing.Size(69, 15)
        Me.lblcretiro.TabIndex = 9
        Me.lblcretiro.Text = "                    "
        '
        'lbltdeposito
        '
        Me.lbltdeposito.AutoSize = True
        Me.lbltdeposito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltdeposito.Location = New System.Drawing.Point(187, 308)
        Me.lbltdeposito.Name = "lbltdeposito"
        Me.lbltdeposito.Size = New System.Drawing.Size(69, 15)
        Me.lbltdeposito.TabIndex = 10
        Me.lbltdeposito.Text = "                    "
        '
        'lbltretiro
        '
        Me.lbltretiro.AutoSize = True
        Me.lbltretiro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltretiro.Location = New System.Drawing.Point(187, 341)
        Me.lbltretiro.Name = "lbltretiro"
        Me.lbltretiro.Size = New System.Drawing.Size(69, 15)
        Me.lbltretiro.TabIndex = 11
        Me.lbltretiro.Text = "                    "
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(179, 59)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtcliente.TabIndex = 12
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(179, 161)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 20)
        Me.txtmonto.TabIndex = 13
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(292, 56)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(29, 23)
        Me.btnok.TabIndex = 14
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btndeposito
        '
        Me.btndeposito.Location = New System.Drawing.Point(131, 208)
        Me.btndeposito.Name = "btndeposito"
        Me.btndeposito.Size = New System.Drawing.Size(75, 23)
        Me.btndeposito.TabIndex = 15
        Me.btndeposito.Text = "Deposito"
        Me.btndeposito.UseVisualStyleBackColor = True
        '
        'btnretiro
        '
        Me.btnretiro.Location = New System.Drawing.Point(246, 208)
        Me.btnretiro.Name = "btnretiro"
        Me.btnretiro.Size = New System.Drawing.Size(75, 23)
        Me.btnretiro.TabIndex = 16
        Me.btnretiro.Text = "Retiro"
        Me.btnretiro.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(340, 303)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 17
        Me.btnnuevo.Text = "Nuevo cliente"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(340, 373)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 18
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Aplicacion10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 422)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnretiro)
        Me.Controls.Add(Me.btndeposito)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.lbltretiro)
        Me.Controls.Add(Me.lbltdeposito)
        Me.Controls.Add(Me.lblcretiro)
        Me.Controls.Add(Me.lblcdeposito)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblsaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Aplicacion10"
        Me.Text = "Banco el amigo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblsaldo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblcdeposito As Label
    Friend WithEvents lblcretiro As Label
    Friend WithEvents lbltdeposito As Label
    Friend WithEvents lbltretiro As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents btndeposito As Button
    Friend WithEvents btnretiro As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
End Class
