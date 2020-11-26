<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacionpro03
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtalumno = New System.Windows.Forms.TextBox()
        Me.txtespecialidad = New System.Windows.Forms.TextBox()
        Me.txtciclo = New System.Windows.Forms.TextBox()
        Me.txtturno = New System.Windows.Forms.TextBox()
        Me.txtaula = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnalumno = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Especialidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ciclo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Aula"
        '
        'txtalumno
        '
        Me.txtalumno.Location = New System.Drawing.Point(149, 54)
        Me.txtalumno.Name = "txtalumno"
        Me.txtalumno.Size = New System.Drawing.Size(218, 20)
        Me.txtalumno.TabIndex = 5
        '
        'txtespecialidad
        '
        Me.txtespecialidad.Location = New System.Drawing.Point(149, 92)
        Me.txtespecialidad.Name = "txtespecialidad"
        Me.txtespecialidad.Size = New System.Drawing.Size(218, 20)
        Me.txtespecialidad.TabIndex = 6
        '
        'txtciclo
        '
        Me.txtciclo.Location = New System.Drawing.Point(149, 130)
        Me.txtciclo.Name = "txtciclo"
        Me.txtciclo.Size = New System.Drawing.Size(100, 20)
        Me.txtciclo.TabIndex = 7
        '
        'txtturno
        '
        Me.txtturno.Location = New System.Drawing.Point(149, 168)
        Me.txtturno.Name = "txtturno"
        Me.txtturno.Size = New System.Drawing.Size(100, 20)
        Me.txtturno.TabIndex = 8
        '
        'txtaula
        '
        Me.txtaula.Location = New System.Drawing.Point(149, 206)
        Me.txtaula.Name = "txtaula"
        Me.txtaula.Size = New System.Drawing.Size(100, 20)
        Me.txtaula.TabIndex = 9
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(199, 269)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(39, 13)
        Me.Fecha.TabIndex = 10
        Me.Fecha.Text = "Label6"
        '
        'Timer1
        '
        '
        'btnalumno
        '
        Me.btnalumno.Location = New System.Drawing.Point(292, 166)
        Me.btnalumno.Name = "btnalumno"
        Me.btnalumno.Size = New System.Drawing.Size(75, 23)
        Me.btnalumno.TabIndex = 11
        Me.btnalumno.Text = "Otro alumno"
        Me.btnalumno.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(292, 204)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Aplicacionpro03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 319)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnalumno)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.txtaula)
        Me.Controls.Add(Me.txtturno)
        Me.Controls.Add(Me.txtciclo)
        Me.Controls.Add(Me.txtespecialidad)
        Me.Controls.Add(Me.txtalumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacionpro03"
        Me.Text = "Datos del alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtalumno As TextBox
    Friend WithEvents txtespecialidad As TextBox
    Friend WithEvents txtciclo As TextBox
    Friend WithEvents txtturno As TextBox
    Friend WithEvents txtaula As TextBox
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnalumno As Button
    Friend WithEvents btnsalir As Button
End Class
