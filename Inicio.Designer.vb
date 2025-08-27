<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.attendance_label = New System.Windows.Forms.Label()
        Me.btn_preferencial = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'attendance_label
        '
        Me.attendance_label.AutoSize = True
        Me.attendance_label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendance_label.ForeColor = System.Drawing.Color.DodgerBlue
        Me.attendance_label.Location = New System.Drawing.Point(-53, 15)
        Me.attendance_label.Name = "attendance_label"
        Me.attendance_label.Size = New System.Drawing.Size(591, 37)
        Me.attendance_label.TabIndex = 0
        Me.attendance_label.Text = "ESCOLHA O TIPO DE ATENDIMENTO"
        '
        'btn_preferencial
        '
        Me.btn_preferencial.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_preferencial.Location = New System.Drawing.Point(68, 143)
        Me.btn_preferencial.Name = "btn_preferencial"
        Me.btn_preferencial.Size = New System.Drawing.Size(282, 76)
        Me.btn_preferencial.TabIndex = 1
        Me.btn_preferencial.Text = "PREFERENCIAL"
        Me.btn_preferencial.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.attendance_label)
        Me.Panel1.Controls.Add(Me.btn_preferencial)
        Me.Panel1.Location = New System.Drawing.Point(141, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 350)
        Me.Panel1.TabIndex = 2
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(728, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents attendance_label As Label
    Friend WithEvents btn_preferencial As Button
    Friend WithEvents Panel1 As Panel
End Class
