<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion15
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblpartent = New System.Windows.Forms.Label()
        Me.lblpartdec = New System.Windows.Forms.Label()
        Me.lblvalabs = New System.Windows.Forms.Label()
        Me.lblraizcuad = New System.Windows.Forms.Label()
        Me.lblsigno = New System.Windows.Forms.Label()
        Me.lblvaloct = New System.Windows.Forms.Label()
        Me.lblvalhex = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnmuestra = New System.Windows.Forms.Button()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese un numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Parte entera"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Parte decimal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor absoluto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Raiz cuadrada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Signo del numero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Valor orctal base 8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Valor hexadecimal base 16"
        '
        'lblpartent
        '
        Me.lblpartent.AutoSize = True
        Me.lblpartent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpartent.Location = New System.Drawing.Point(217, 90)
        Me.lblpartent.Name = "lblpartent"
        Me.lblpartent.Size = New System.Drawing.Size(135, 15)
        Me.lblpartent.TabIndex = 8
        Me.lblpartent.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblpartdec
        '
        Me.lblpartdec.AutoSize = True
        Me.lblpartdec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpartdec.Location = New System.Drawing.Point(217, 127)
        Me.lblpartdec.Name = "lblpartdec"
        Me.lblpartdec.Size = New System.Drawing.Size(135, 15)
        Me.lblpartdec.TabIndex = 9
        Me.lblpartdec.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblvalabs
        '
        Me.lblvalabs.AutoSize = True
        Me.lblvalabs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvalabs.Location = New System.Drawing.Point(217, 164)
        Me.lblvalabs.Name = "lblvalabs"
        Me.lblvalabs.Size = New System.Drawing.Size(135, 15)
        Me.lblvalabs.TabIndex = 10
        Me.lblvalabs.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblraizcuad
        '
        Me.lblraizcuad.AutoSize = True
        Me.lblraizcuad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblraizcuad.Location = New System.Drawing.Point(217, 201)
        Me.lblraizcuad.Name = "lblraizcuad"
        Me.lblraizcuad.Size = New System.Drawing.Size(135, 15)
        Me.lblraizcuad.TabIndex = 11
        Me.lblraizcuad.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblsigno
        '
        Me.lblsigno.AutoSize = True
        Me.lblsigno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsigno.Location = New System.Drawing.Point(217, 238)
        Me.lblsigno.Name = "lblsigno"
        Me.lblsigno.Size = New System.Drawing.Size(135, 15)
        Me.lblsigno.TabIndex = 12
        Me.lblsigno.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblvaloct
        '
        Me.lblvaloct.AutoSize = True
        Me.lblvaloct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvaloct.Location = New System.Drawing.Point(217, 275)
        Me.lblvaloct.Name = "lblvaloct"
        Me.lblvaloct.Size = New System.Drawing.Size(135, 15)
        Me.lblvaloct.TabIndex = 13
        Me.lblvaloct.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblvalhex
        '
        Me.lblvalhex.AutoSize = True
        Me.lblvalhex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvalhex.Location = New System.Drawing.Point(217, 312)
        Me.lblvalhex.Name = "lblvalhex"
        Me.lblvalhex.Size = New System.Drawing.Size(135, 15)
        Me.lblvalhex.TabIndex = 14
        Me.lblvalhex.Text = "                                          " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(220, 50)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(100, 20)
        Me.txtnum.TabIndex = 15
        '
        'btnmuestra
        '
        Me.btnmuestra.Location = New System.Drawing.Point(390, 127)
        Me.btnmuestra.Name = "btnmuestra"
        Me.btnmuestra.Size = New System.Drawing.Size(75, 23)
        Me.btnmuestra.TabIndex = 16
        Me.btnmuestra.Text = "Muestra"
        Me.btnmuestra.UseVisualStyleBackColor = True
        '
        'btnnueva
        '
        Me.btnnueva.Location = New System.Drawing.Point(390, 164)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(75, 23)
        Me.btnnueva.TabIndex = 17
        Me.btnnueva.Text = "Nueva"
        Me.btnnueva.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(390, 201)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 18
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Aplicacion15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnueva)
        Me.Controls.Add(Me.btnmuestra)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lblvalhex)
        Me.Controls.Add(Me.lblvaloct)
        Me.Controls.Add(Me.lblsigno)
        Me.Controls.Add(Me.lblraizcuad)
        Me.Controls.Add(Me.lblvalabs)
        Me.Controls.Add(Me.lblpartdec)
        Me.Controls.Add(Me.lblpartent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacion15"
        Me.Text = "Ejemplo de funciones numericas"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents lblpartent As Label
    Friend WithEvents lblpartdec As Label
    Friend WithEvents lblvalabs As Label
    Friend WithEvents lblraizcuad As Label
    Friend WithEvents lblsigno As Label
    Friend WithEvents lblvaloct As Label
    Friend WithEvents lblvalhex As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnmuestra As Button
    Friend WithEvents btnnueva As Button
    Friend WithEvents btnsalir As Button
End Class
