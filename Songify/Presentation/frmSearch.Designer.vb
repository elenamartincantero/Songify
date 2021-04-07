<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.List = New System.Windows.Forms.ListBox()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.FavButton = New System.Windows.Forms.Button()
        Me.HistoryLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.FormattingEnabled = True
        Me.List.ItemHeight = 15
        Me.List.Location = New System.Drawing.Point(54, 53)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(268, 289)
        Me.List.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(491, 53)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(28, 15)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Info"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(54, 361)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(69, 36)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'HistoryButton
        '
        Me.HistoryButton.Location = New System.Drawing.Point(168, 363)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(154, 33)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "Show playbacks history"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'FavButton
        '
        Me.FavButton.Location = New System.Drawing.Point(364, 363)
        Me.FavButton.Name = "FavButton"
        Me.FavButton.Size = New System.Drawing.Size(56, 33)
        Me.FavButton.TabIndex = 4
        Me.FavButton.Text = "Fav"
        Me.FavButton.UseVisualStyleBackColor = True
        '
        'HistoryLabel
        '
        Me.HistoryLabel.AutoSize = True
        Me.HistoryLabel.Location = New System.Drawing.Point(493, 230)
        Me.HistoryLabel.Name = "HistoryLabel"
        Me.HistoryLabel.Size = New System.Drawing.Size(45, 15)
        Me.HistoryLabel.TabIndex = 5
        Me.HistoryLabel.Text = "History"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HistoryLabel)
        Me.Controls.Add(Me.FavButton)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.List)
        Me.Name = "frmSearch"
        Me.Text = "frmSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents List As ListBox
    Friend WithEvents InfoLabel As Label
    Friend WithEvents PlayButton As Button
    Friend WithEvents HistoryButton As Button
    Friend WithEvents FavButton As Button
    Friend WithEvents HistoryLabel As Label
End Class
