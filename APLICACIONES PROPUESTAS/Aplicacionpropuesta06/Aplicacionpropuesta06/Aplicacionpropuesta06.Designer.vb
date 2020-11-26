<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacionpropuesta06
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbledad = New System.Windows.Forms.Label()
        Me.lblobservacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblaño = New System.Windows.Forms.Label()
        Me.lbletapa = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnresultado = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Años"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observacion"
        '
        'lbledad
        '
        Me.lbledad.AutoSize = True
        Me.lbledad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbledad.Location = New System.Drawing.Point(174, 126)
        Me.lbledad.Name = "lbledad"
        Me.lbledad.Size = New System.Drawing.Size(69, 15)
        Me.lbledad.TabIndex = 4
        Me.lbledad.Text = "                    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblobservacion
        '
        Me.lblobservacion.AutoSize = True
        Me.lblobservacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblobservacion.Location = New System.Drawing.Point(174, 164)
        Me.lblobservacion.Name = "lblobservacion"
        Me.lblobservacion.Size = New System.Drawing.Size(168, 15)
        Me.lblobservacion.TabIndex = 5
        Me.lblobservacion.Text = "                                                     "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Etapa"
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblaño.Location = New System.Drawing.Point(174, 202)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(168, 15)
        Me.lblaño.TabIndex = 7
        Me.lblaño.Text = "                                                     "
        '
        'lbletapa
        '
        Me.lbletapa.AutoSize = True
        Me.lbletapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbletapa.Location = New System.Drawing.Point(99, 287)
        Me.lbletapa.Name = "lbletapa"
        Me.lbletapa.Size = New System.Drawing.Size(243, 15)
        Me.lbletapa.TabIndex = 8
        Me.lbletapa.Text = "                                                                              "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Año de nacimiento"
        '
        'btnresultado
        '
        Me.btnresultado.Location = New System.Drawing.Point(362, 118)
        Me.btnresultado.Name = "btnresultado"
        Me.btnresultado.Size = New System.Drawing.Size(75, 23)
        Me.btnresultado.TabIndex = 10
        Me.btnresultado.Text = "Resultado"
        Me.btnresultado.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(362, 154)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 11
        Me.btnnew.Text = "Nuevo "
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(362, 192)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "Salir"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(174, 43)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(263, 20)
        Me.txtnombre.TabIndex = 13
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(174, 82)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(112, 20)
        Me.txtaño.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Año Actual"
        '
        'Timer1
        '
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(88, 328)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(2, 15)
        Me.lblfecha.TabIndex = 16
        '
        'Aplicacionpropuesta06
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 353)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnresultado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbletapa)
        Me.Controls.Add(Me.lblaño)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblobservacion)
        Me.Controls.Add(Me.lbledad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacionpropuesta06"
        Me.Text = "Edades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbledad As Label
    Friend WithEvents lblobservacion As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblaño As Label
    Friend WithEvents lbletapa As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnresultado As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtaño As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblfecha As Label
End Class
