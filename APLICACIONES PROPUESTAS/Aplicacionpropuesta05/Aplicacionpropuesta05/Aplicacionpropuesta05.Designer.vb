<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacionpropuesta05
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
        Me.lblpagoho = New System.Windows.Forms.Label()
        Me.lbltotaln = New System.Windows.Forms.Label()
        Me.lbltotale = New System.Windows.Forms.Label()
        Me.lbltotalp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txthorat = New System.Windows.Forms.TextBox()
        Me.txthorae = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnotro = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del profesor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horas trabajadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horas extras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pago por horas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total por Hs, normales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total por Hs, extras"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total a pagar ===>"
        '
        'lblpagoho
        '
        Me.lblpagoho.AutoSize = True
        Me.lblpagoho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpagoho.Location = New System.Drawing.Point(145, 157)
        Me.lblpagoho.Name = "lblpagoho"
        Me.lblpagoho.Size = New System.Drawing.Size(111, 15)
        Me.lblpagoho.TabIndex = 7
        Me.lblpagoho.Text = "                                  "
        '
        'lbltotaln
        '
        Me.lbltotaln.AutoSize = True
        Me.lbltotaln.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotaln.Location = New System.Drawing.Point(145, 190)
        Me.lbltotaln.Name = "lbltotaln"
        Me.lbltotaln.Size = New System.Drawing.Size(111, 15)
        Me.lbltotaln.TabIndex = 8
        Me.lbltotaln.Text = "                                  "
        '
        'lbltotale
        '
        Me.lbltotale.AutoSize = True
        Me.lbltotale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotale.Location = New System.Drawing.Point(145, 223)
        Me.lbltotale.Name = "lbltotale"
        Me.lbltotale.Size = New System.Drawing.Size(111, 15)
        Me.lbltotale.TabIndex = 9
        Me.lbltotale.Text = "                                  "
        '
        'lbltotalp
        '
        Me.lbltotalp.AutoSize = True
        Me.lbltotalp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotalp.Location = New System.Drawing.Point(145, 256)
        Me.lbltotalp.Name = "lbltotalp"
        Me.lbltotalp.Size = New System.Drawing.Size(111, 15)
        Me.lbltotalp.TabIndex = 10
        Me.lbltotalp.Text = "                                  "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(105, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(229, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Programador:Hector Jefrey Muñoz Ortiz"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(148, 55)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(215, 20)
        Me.txtnombre.TabIndex = 12
        '
        'txthorat
        '
        Me.txthorat.Location = New System.Drawing.Point(148, 88)
        Me.txthorat.Name = "txthorat"
        Me.txthorat.Size = New System.Drawing.Size(108, 20)
        Me.txthorat.TabIndex = 13
        '
        'txthorae
        '
        Me.txthorae.Location = New System.Drawing.Point(148, 121)
        Me.txthorae.Name = "txthorae"
        Me.txthorae.Size = New System.Drawing.Size(108, 20)
        Me.txthorae.TabIndex = 14
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(288, 152)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 15
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnotro
        '
        Me.btnotro.Location = New System.Drawing.Point(288, 190)
        Me.btnotro.Name = "btnotro"
        Me.btnotro.Size = New System.Drawing.Size(75, 23)
        Me.btnotro.TabIndex = 16
        Me.btnotro.Text = "Otro"
        Me.btnotro.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(288, 223)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 17
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Aplicacionpropuesta05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 353)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnotro)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txthorae)
        Me.Controls.Add(Me.txthorat)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbltotalp)
        Me.Controls.Add(Me.lbltotale)
        Me.Controls.Add(Me.lbltotaln)
        Me.Controls.Add(Me.lblpagoho)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacionpropuesta05"
        Me.Text = "Honorarios"
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
    Friend WithEvents lblpagoho As Label
    Friend WithEvents lbltotaln As Label
    Friend WithEvents lbltotale As Label
    Friend WithEvents lbltotalp As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txthorat As TextBox
    Friend WithEvents txthorae As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnotro As Button
    Friend WithEvents btnsalir As Button
End Class
