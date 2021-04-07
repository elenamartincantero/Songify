<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.BeginLabel = New System.Windows.Forms.Label()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"List of artists sorted by number of playbacks", "List of songs sorted by number of playbacks", "List of artists most listened to by a user", "List of users sorted by time using the application", "Playback time of a user's favorite artists"})
        Me.ComboBox1.Location = New System.Drawing.Point(64, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'DateTimeBegin
        '
        Me.DateTimeBegin.Location = New System.Drawing.Point(64, 124)
        Me.DateTimeBegin.Name = "DateTimeBegin"
        Me.DateTimeBegin.Size = New System.Drawing.Size(246, 23)
        Me.DateTimeBegin.TabIndex = 1
        '
        'BeginLabel
        '
        Me.BeginLabel.AutoSize = True
        Me.BeginLabel.Location = New System.Drawing.Point(64, 87)
        Me.BeginLabel.Name = "BeginLabel"
        Me.BeginLabel.Size = New System.Drawing.Size(64, 15)
        Me.BeginLabel.TabIndex = 2
        Me.BeginLabel.Text = "Begin Date"
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Location = New System.Drawing.Point(369, 87)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(54, 15)
        Me.EndLabel.TabIndex = 3
        Me.EndLabel.Text = "End Date"
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Location = New System.Drawing.Point(369, 124)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(244, 23)
        Me.DateTimeEnd.TabIndex = 4
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(64, 171)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(41, 15)
        Me.InfoLabel.TabIndex = 5
        Me.InfoLabel.Text = "Label1"
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.DateTimeEnd)
        Me.Controls.Add(Me.EndLabel)
        Me.Controls.Add(Me.BeginLabel)
        Me.Controls.Add(Me.DateTimeBegin)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmStatistics"
        Me.Text = "End Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimeBegin As DateTimePicker
    Friend WithEvents BeginLabel As Label
    Friend WithEvents EndLabel As Label
    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents InfoLabel As Label
End Class
