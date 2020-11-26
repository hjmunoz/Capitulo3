<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion16
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
        Me.btncalcelct = New System.Windows.Forms.Button()
        Me.btnword = New System.Windows.Forms.Button()
        Me.btnexcel = New System.Windows.Forms.Button()
        Me.btnexplorador = New System.Windows.Forms.Button()
        Me.btndos = New System.Windows.Forms.Button()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncalcelct
        '
        Me.btncalcelct.Location = New System.Drawing.Point(112, 48)
        Me.btncalcelct.Name = "btncalcelct"
        Me.btncalcelct.Size = New System.Drawing.Size(189, 41)
        Me.btncalcelct.TabIndex = 0
        Me.btncalcelct.Text = "CALCULADORA ELECTRONICA"
        Me.btncalcelct.UseVisualStyleBackColor = True
        '
        'btnword
        '
        Me.btnword.Location = New System.Drawing.Point(112, 95)
        Me.btnword.Name = "btnword"
        Me.btnword.Size = New System.Drawing.Size(189, 41)
        Me.btnword.TabIndex = 1
        Me.btnword.Text = "MICROSOFT WORD"
        Me.btnword.UseVisualStyleBackColor = True
        '
        'btnexcel
        '
        Me.btnexcel.Location = New System.Drawing.Point(112, 142)
        Me.btnexcel.Name = "btnexcel"
        Me.btnexcel.Size = New System.Drawing.Size(189, 41)
        Me.btnexcel.TabIndex = 2
        Me.btnexcel.Text = "MICROSOFT EXCEL"
        Me.btnexcel.UseVisualStyleBackColor = True
        '
        'btnexplorador
        '
        Me.btnexplorador.Location = New System.Drawing.Point(112, 189)
        Me.btnexplorador.Name = "btnexplorador"
        Me.btnexplorador.Size = New System.Drawing.Size(189, 41)
        Me.btnexplorador.TabIndex = 3
        Me.btnexplorador.Text = "EXPLORADOR DE WINDOWS"
        Me.btnexplorador.UseVisualStyleBackColor = True
        '
        'btndos
        '
        Me.btndos.Location = New System.Drawing.Point(112, 236)
        Me.btndos.Name = "btndos"
        Me.btndos.Size = New System.Drawing.Size(189, 41)
        Me.btndos.TabIndex = 4
        Me.btndos.Text = "SALIR AL D.O.S"
        Me.btndos.UseVisualStyleBackColor = True
        '
        'btnfinalizar
        '
        Me.btnfinalizar.Location = New System.Drawing.Point(138, 361)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(143, 41)
        Me.btnfinalizar.TabIndex = 5
        Me.btnfinalizar.Text = "&Finalizar"
        Me.btnfinalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PROGRAMA A EJECUTAR"
        '
        'Aplicacion16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnfinalizar)
        Me.Controls.Add(Me.btndos)
        Me.Controls.Add(Me.btnexplorador)
        Me.Controls.Add(Me.btnexcel)
        Me.Controls.Add(Me.btnword)
        Me.Controls.Add(Me.btncalcelct)
        Me.Name = "Aplicacion16"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncalcelct As Button
    Friend WithEvents btnword As Button
    Friend WithEvents btnexcel As Button
    Friend WithEvents btnexplorador As Button
    Friend WithEvents btndos As Button
    Friend WithEvents btnfinalizar As Button
    Friend WithEvents Label1 As Label
End Class
