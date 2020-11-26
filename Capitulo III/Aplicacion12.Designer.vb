<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion12
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
        Me.lblpromedio = New System.Windows.Forms.Label()
        Me.lblobservacion = New System.Windows.Forms.Label()
        Me.lblpuntos = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblcualidad = New System.Windows.Forms.Label()
        Me.txtalumno = New System.Windows.Forms.TextBox()
        Me.txtcurso = New System.Windows.Forms.TextBox()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.btnotro = New System.Windows.Forms.Button()
        Me.btnpromedio = New System.Windows.Forms.Button()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nota N 01"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nota N 02"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Promedio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Observacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Puntos"
        '
        'lblpromedio
        '
        Me.lblpromedio.AutoSize = True
        Me.lblpromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpromedio.Location = New System.Drawing.Point(101, 180)
        Me.lblpromedio.Name = "lblpromedio"
        Me.lblpromedio.Size = New System.Drawing.Size(81, 15)
        Me.lblpromedio.TabIndex = 7
        Me.lblpromedio.Text = "                        "
        '
        'lblobservacion
        '
        Me.lblobservacion.AutoSize = True
        Me.lblobservacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblobservacion.Location = New System.Drawing.Point(101, 212)
        Me.lblobservacion.Name = "lblobservacion"
        Me.lblobservacion.Size = New System.Drawing.Size(81, 15)
        Me.lblobservacion.TabIndex = 8
        Me.lblobservacion.Text = "                        "
        '
        'lblpuntos
        '
        Me.lblpuntos.AutoSize = True
        Me.lblpuntos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpuntos.Location = New System.Drawing.Point(101, 244)
        Me.lblpuntos.Name = "lblpuntos"
        Me.lblpuntos.Size = New System.Drawing.Size(81, 15)
        Me.lblpuntos.TabIndex = 9
        Me.lblpuntos.Text = "                        "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(152, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Cualidad"
        '
        'lblcualidad
        '
        Me.lblcualidad.AutoSize = True
        Me.lblcualidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcualidad.Location = New System.Drawing.Point(68, 316)
        Me.lblcualidad.Name = "lblcualidad"
        Me.lblcualidad.Size = New System.Drawing.Size(216, 15)
        Me.lblcualidad.TabIndex = 11
        Me.lblcualidad.Text = "                                                                     "
        '
        'txtalumno
        '
        Me.txtalumno.Location = New System.Drawing.Point(104, 45)
        Me.txtalumno.Name = "txtalumno"
        Me.txtalumno.Size = New System.Drawing.Size(100, 20)
        Me.txtalumno.TabIndex = 12
        '
        'txtcurso
        '
        Me.txtcurso.Location = New System.Drawing.Point(104, 77)
        Me.txtcurso.Name = "txtcurso"
        Me.txtcurso.Size = New System.Drawing.Size(100, 20)
        Me.txtcurso.TabIndex = 13
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(104, 109)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(100, 20)
        Me.txtn1.TabIndex = 14
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(104, 141)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(100, 20)
        Me.txtn2.TabIndex = 15
        '
        'btnotro
        '
        Me.btnotro.Location = New System.Drawing.Point(260, 106)
        Me.btnotro.Name = "btnotro"
        Me.btnotro.Size = New System.Drawing.Size(101, 23)
        Me.btnotro.TabIndex = 16
        Me.btnotro.Text = "Otro alumno"
        Me.btnotro.UseVisualStyleBackColor = True
        '
        'btnpromedio
        '
        Me.btnpromedio.AutoSize = True
        Me.btnpromedio.Location = New System.Drawing.Point(260, 148)
        Me.btnpromedio.Name = "btnpromedio"
        Me.btnpromedio.Size = New System.Drawing.Size(101, 23)
        Me.btnpromedio.TabIndex = 17
        Me.btnpromedio.Text = "Obtener promedio"
        Me.btnpromedio.UseVisualStyleBackColor = True
        '
        'btnfinalizar
        '
        Me.btnfinalizar.Location = New System.Drawing.Point(260, 189)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(101, 23)
        Me.btnfinalizar.TabIndex = 18
        Me.btnfinalizar.Text = "Finalizar"
        Me.btnfinalizar.UseVisualStyleBackColor = True
        '
        'Aplicacion12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 386)
        Me.Controls.Add(Me.btnfinalizar)
        Me.Controls.Add(Me.btnpromedio)
        Me.Controls.Add(Me.btnotro)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.txtcurso)
        Me.Controls.Add(Me.txtalumno)
        Me.Controls.Add(Me.lblcualidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblpuntos)
        Me.Controls.Add(Me.lblobservacion)
        Me.Controls.Add(Me.lblpromedio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacion12"
        Me.Text = "Informacion Academica          "
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
    Friend WithEvents lblpromedio As Label
    Friend WithEvents lblobservacion As Label
    Friend WithEvents lblpuntos As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblcualidad As Label
    Friend WithEvents txtalumno As TextBox
    Friend WithEvents txtcurso As TextBox
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents btnotro As Button
    Friend WithEvents btnpromedio As Button
    Friend WithEvents btnfinalizar As Button
End Class
