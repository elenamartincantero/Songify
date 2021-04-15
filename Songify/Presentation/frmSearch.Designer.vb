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
        Me.List.ItemHeight = 16
        Me.List.Location = New System.Drawing.Point(62, 57)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(306, 308)
        Me.List.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(561, 57)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(29, 16)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Info"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(62, 385)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(79, 38)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'HistoryButton
        '
        Me.HistoryButton.Location = New System.Drawing.Point(192, 387)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(176, 35)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "Show playbacks history"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'FavButton
        '
        Me.FavButton.Location = New System.Drawing.Point(416, 387)
        Me.FavButton.Name = "FavButton"
        Me.FavButton.Size = New System.Drawing.Size(64, 35)
        Me.FavButton.TabIndex = 4
        Me.FavButton.Text = "Fav"
        Me.FavButton.UseVisualStyleBackColor = True
        '
        'HistoryLabel
        '
        Me.HistoryLabel.AutoSize = True
        Me.HistoryLabel.Location = New System.Drawing.Point(563, 245)
        Me.HistoryLabel.Name = "HistoryLabel"
        Me.HistoryLabel.Size = New System.Drawing.Size(50, 16)
        Me.HistoryLabel.TabIndex = 5
        Me.HistoryLabel.Text = "History"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 480)
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

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
