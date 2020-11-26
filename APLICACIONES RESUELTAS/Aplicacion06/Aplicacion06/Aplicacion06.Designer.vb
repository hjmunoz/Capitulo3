<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplicacion06
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
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblb = New System.Windows.Forms.Label()
        Me.btnincrementa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor de A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor de B"
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbla.Location = New System.Drawing.Point(93, 82)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(39, 15)
        Me.lbla.TabIndex = 2
        Me.lbla.Text = "          "
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblb.Location = New System.Drawing.Point(261, 82)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(39, 15)
        Me.lblb.TabIndex = 3
        Me.lblb.Text = "          "
        '
        'btnincrementa
        '
        Me.btnincrementa.Location = New System.Drawing.Point(121, 159)
        Me.btnincrementa.Name = "btnincrementa"
        Me.btnincrementa.Size = New System.Drawing.Size(153, 23)
        Me.btnincrementa.TabIndex = 4
        Me.btnincrementa.Text = "Incrementa la variable A y B"
        Me.btnincrementa.UseVisualStyleBackColor = True
        '
        'Aplicacion06
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(398, 229)
        Me.Controls.Add(Me.btnincrementa)
        Me.Controls.Add(Me.lblb)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Aplicacion06"
        Me.Text = "Diferencia entre Dim y Static"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbla As Label
    Friend WithEvents lblb As Label
    Friend WithEvents btnincrementa As Button
End Class
