<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion07
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
        Me.lbltxhe = New System.Windows.Forms.Label()
        Me.lbltxhn = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbldescuento = New System.Windows.Forms.Label()
        Me.lbltp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.txthtn = New System.Windows.Forms.TextBox()
        Me.txthe = New System.Windows.Forms.TextBox()
        Me.txtpxhe = New System.Windows.Forms.TextBox()
        Me.txtpxhn = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del trabajador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pago por hora normal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pago por hora extra"
        '
        'lbltxhe
        '
        Me.lbltxhe.AutoSize = True
        Me.lbltxhe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxhe.Location = New System.Drawing.Point(229, 274)
        Me.lbltxhe.Name = "lbltxhe"
        Me.lbltxhe.Size = New System.Drawing.Size(93, 15)
        Me.lbltxhe.TabIndex = 3
        Me.lbltxhe.Text = "                            "
        '
        'lbltxhn
        '
        Me.lbltxhn.AutoSize = True
        Me.lbltxhn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltxhn.Location = New System.Drawing.Point(229, 237)
        Me.lbltxhn.Name = "lbltxhn"
        Me.lbltxhn.Size = New System.Drawing.Size(93, 15)
        Me.lbltxhn.TabIndex = 4
        Me.lbltxhn.Text = "                            "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total a pagar"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsubtotal.Location = New System.Drawing.Point(229, 311)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(93, 15)
        Me.lblsubtotal.TabIndex = 6
        Me.lblsubtotal.Text = "                            "
        '
        'lbldescuento
        '
        Me.lbldescuento.AutoSize = True
        Me.lbldescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldescuento.Location = New System.Drawing.Point(229, 348)
        Me.lbldescuento.Name = "lbldescuento"
        Me.lbldescuento.Size = New System.Drawing.Size(93, 15)
        Me.lbldescuento.TabIndex = 7
        Me.lbldescuento.Text = "                            "
        '
        'lbltp
        '
        Me.lbltp.AutoSize = True
        Me.lbltp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltp.Location = New System.Drawing.Point(229, 385)
        Me.lbltp.Name = "lbltp"
        Me.lbltp.Size = New System.Drawing.Size(93, 15)
        Me.lbltp.TabIndex = 8
        Me.lbltp.Text = "                            "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Horas extras"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Horas trabajadas normales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Pago por horas normales"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(54, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Subtotal"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(54, 274)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Pago por horas extras"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(54, 348)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Descuento (10%)"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(229, 49)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(218, 20)
        Me.txtnom.TabIndex = 15
        '
        'txthtn
        '
        Me.txthtn.Location = New System.Drawing.Point(229, 86)
        Me.txthtn.Name = "txthtn"
        Me.txthtn.Size = New System.Drawing.Size(100, 20)
        Me.txthtn.TabIndex = 16
        '
        'txthe
        '
        Me.txthe.Location = New System.Drawing.Point(229, 123)
        Me.txthe.Name = "txthe"
        Me.txthe.Size = New System.Drawing.Size(100, 20)
        Me.txthe.TabIndex = 17
        '
        'txtpxhe
        '
        Me.txtpxhe.Location = New System.Drawing.Point(229, 197)
        Me.txtpxhe.Name = "txtpxhe"
        Me.txtpxhe.Size = New System.Drawing.Size(100, 20)
        Me.txtpxhe.TabIndex = 18
        '
        'txtpxhn
        '
        Me.txtpxhn.Location = New System.Drawing.Point(229, 160)
        Me.txtpxhn.Name = "txtpxhn"
        Me.txtpxhn.Size = New System.Drawing.Size(100, 20)
        Me.txtpxhn.TabIndex = 19
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(398, 120)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 20
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(398, 157)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 21
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(398, 190)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 22
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Aplicacion07
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 415)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtpxhn)
        Me.Controls.Add(Me.txtpxhe)
        Me.Controls.Add(Me.txthe)
        Me.Controls.Add(Me.txthtn)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbltp)
        Me.Controls.Add(Me.lbldescuento)
        Me.Controls.Add(Me.lblsubtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltxhn)
        Me.Controls.Add(Me.lbltxhe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacion07"
        Me.Text = "Pagos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltxhe As Label
    Friend WithEvents lbltxhn As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents lbldescuento As Label
    Friend WithEvents lbltp As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txthtn As TextBox
    Friend WithEvents txthe As TextBox
    Friend WithEvents txtpxhe As TextBox
    Friend WithEvents txtpxhn As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
End Class
