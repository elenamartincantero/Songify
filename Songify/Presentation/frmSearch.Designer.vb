<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearch
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.List = New System.Windows.Forms.ListBox()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.FavButton = New System.Windows.Forms.Button()
        Me.HistoryLabel = New System.Windows.Forms.Label()
        Me.AlbumList = New System.Windows.Forms.ListBox()
        Me.SongList = New System.Windows.Forms.ListBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.UnFav = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.FormattingEnabled = True
        Me.List.ItemHeight = 16
        Me.List.Location = New System.Drawing.Point(62, 57)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(177, 308)
        Me.List.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(793, 23)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(31, 17)
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
        Me.FavButton.Location = New System.Drawing.Point(408, 385)
        Me.FavButton.Name = "FavButton"
        Me.FavButton.Size = New System.Drawing.Size(72, 37)
        Me.FavButton.TabIndex = 4
        Me.FavButton.Text = "Fav"
        Me.FavButton.UseVisualStyleBackColor = True
        '
        'HistoryLabel
        '
        Me.HistoryLabel.AutoSize = True
        Me.HistoryLabel.Location = New System.Drawing.Point(652, 305)
        Me.HistoryLabel.Name = "HistoryLabel"
        Me.HistoryLabel.Size = New System.Drawing.Size(52, 17)
        Me.HistoryLabel.TabIndex = 5
        Me.HistoryLabel.Text = "History"
        '
        'AlbumList
        '
        Me.AlbumList.FormattingEnabled = True
        Me.AlbumList.ItemHeight = 16
        Me.AlbumList.Location = New System.Drawing.Point(281, 57)
        Me.AlbumList.Name = "AlbumList"
        Me.AlbumList.Size = New System.Drawing.Size(155, 308)
        Me.AlbumList.TabIndex = 6
        '
        'SongList
        '
        Me.SongList.FormattingEnabled = True
        Me.SongList.ItemHeight = 16
        Me.SongList.Location = New System.Drawing.Point(478, 57)
        Me.SongList.Name = "SongList"
        Me.SongList.Size = New System.Drawing.Size(134, 308)
        Me.SongList.TabIndex = 7
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(62, 12)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(92, 39)
        Me.Start.TabIndex = 8
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'UnFav
        '
        Me.UnFav.Location = New System.Drawing.Point(516, 387)
        Me.UnFav.Name = "UnFav"
        Me.UnFav.Size = New System.Drawing.Size(75, 36)
        Me.UnFav.TabIndex = 9
        Me.UnFav.Text = "UnFav"
        Me.UnFav.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(705, 100)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(197, 22)
        Me.TextBox.TabIndex = 10
        Me.TextBox.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(705, 176)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 22)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(702, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(702, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Info"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(705, 270)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(197, 22)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(702, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Info"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 480)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.UnFav)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.SongList)
        Me.Controls.Add(Me.AlbumList)
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

    Friend WithEvents AlbumList As ListBox
    Friend WithEvents SongList As ListBox
    Friend WithEvents Start As Button
    Friend WithEvents UnFav As Button
    Friend WithEvents TextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
