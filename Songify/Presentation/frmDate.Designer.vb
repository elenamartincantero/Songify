<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDate
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
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.BeginLabel = New System.Windows.Forms.Label()
        Me.DateTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeEnd.Location = New System.Drawing.Point(318, 94)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(264, 23)
        Me.DateTimeEnd.TabIndex = 8
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndLabel.Location = New System.Drawing.Point(405, 67)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(69, 18)
        Me.EndLabel.TabIndex = 7
        Me.EndLabel.Text = "End Date"
        '
        'BeginLabel
        '
        Me.BeginLabel.AutoSize = True
        Me.BeginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginLabel.Location = New System.Drawing.Point(118, 67)
        Me.BeginLabel.Name = "BeginLabel"
        Me.BeginLabel.Size = New System.Drawing.Size(80, 18)
        Me.BeginLabel.TabIndex = 6
        Me.BeginLabel.Text = "Begin Date"
        '
        'DateTimeBegin
        '
        Me.DateTimeBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeBegin.Location = New System.Drawing.Point(35, 94)
        Me.DateTimeBegin.Name = "DateTimeBegin"
        Me.DateTimeBegin.Size = New System.Drawing.Size(264, 23)
        Me.DateTimeBegin.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.06154!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 36)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Choose a date interval"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(495, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Done!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 182)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimeEnd)
        Me.Controls.Add(Me.EndLabel)
        Me.Controls.Add(Me.BeginLabel)
        Me.Controls.Add(Me.DateTimeBegin)
        Me.Name = "frmDate"
        Me.Text = "Songify - Choose date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents EndLabel As Label
    Friend WithEvents BeginLabel As Label
    Friend WithEvents DateTimeBegin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
