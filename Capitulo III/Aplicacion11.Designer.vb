<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion11
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbldescp = New System.Windows.Forms.Label()
        Me.lbldescs = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtprecuni = New System.Windows.Forms.TextBox()
        Me.txtcantcomp = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Unitario S/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad Comprada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal S/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descuento %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descuento  S/"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TOTAL A PAGAR S/ ===>"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsubtotal.Location = New System.Drawing.Point(192, 204)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(84, 15)
        Me.lblsubtotal.TabIndex = 7
        Me.lblsubtotal.Text = "                         "
        '
        'lbldescp
        '
        Me.lbldescp.AutoSize = True
        Me.lbldescp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldescp.Location = New System.Drawing.Point(192, 252)
        Me.lbldescp.Name = "lbldescp"
        Me.lbldescp.Size = New System.Drawing.Size(84, 15)
        Me.lbldescp.TabIndex = 8
        Me.lbldescp.Text = "                         "
        '
        'lbldescs
        '
        Me.lbldescs.AutoSize = True
        Me.lbldescs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldescs.Location = New System.Drawing.Point(192, 300)
        Me.lbldescs.Name = "lbldescs"
        Me.lbldescs.Size = New System.Drawing.Size(84, 15)
        Me.lbldescs.TabIndex = 9
        Me.lbldescs.Text = "                         "
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotal.Location = New System.Drawing.Point(239, 348)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(84, 15)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "                         "
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(195, 57)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtproducto.TabIndex = 11
        '
        'txtprecuni
        '
        Me.txtprecuni.Location = New System.Drawing.Point(195, 105)
        Me.txtprecuni.Name = "txtprecuni"
        Me.txtprecuni.Size = New System.Drawing.Size(100, 20)
        Me.txtprecuni.TabIndex = 12
        '
        'txtcantcomp
        '
        Me.txtcantcomp.Location = New System.Drawing.Point(195, 153)
        Me.txtcantcomp.Name = "txtcantcomp"
        Me.txtcantcomp.Size = New System.Drawing.Size(100, 20)
        Me.txtcantcomp.TabIndex = 13
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(445, 137)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 14
        Me.btncalcular.Text = "&Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(445, 202)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 15
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(445, 267)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtcantcomp)
        Me.Controls.Add(Me.txtprecuni)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lbldescs)
        Me.Controls.Add(Me.lbldescp)
        Me.Controls.Add(Me.lblsubtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "                         "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents lbldescp As Label
    Friend WithEvents lbldescs As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtprecuni As TextBox
    Friend WithEvents txtcantcomp As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
End Class
