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
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PlaybackList = New System.Windows.Forms.ListBox()
        Me.BACK_TO_MENU = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.FormattingEnabled = True
        Me.List.Location = New System.Drawing.Point(46, 46)
        Me.List.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(134, 251)
        Me.List.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(590, 17)
        Me.InfoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(25, 13)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Info"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(401, 7)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(59, 31)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'HistoryButton
        '
        Me.HistoryButton.Location = New System.Drawing.Point(177, 10)
        Me.HistoryButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(132, 28)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "Show playbacks history"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'FavButton
        '
        Me.FavButton.Location = New System.Drawing.Point(327, 8)
        Me.FavButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FavButton.Name = "FavButton"
        Me.FavButton.Size = New System.Drawing.Size(54, 30)
        Me.FavButton.TabIndex = 4
        Me.FavButton.Text = "Fav"
        Me.FavButton.UseVisualStyleBackColor = True
        '
        'HistoryLabel
        '
        Me.HistoryLabel.AutoSize = True
        Me.HistoryLabel.Location = New System.Drawing.Point(220, 335)
        Me.HistoryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HistoryLabel.Name = "HistoryLabel"
        Me.HistoryLabel.Size = New System.Drawing.Size(39, 13)
        Me.HistoryLabel.TabIndex = 5
        Me.HistoryLabel.Text = "History"
        '
        'AlbumList
        '
        Me.AlbumList.FormattingEnabled = True
        Me.AlbumList.Location = New System.Drawing.Point(211, 46)
        Me.AlbumList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AlbumList.Name = "AlbumList"
        Me.AlbumList.Size = New System.Drawing.Size(117, 251)
        Me.AlbumList.TabIndex = 6
        '
        'SongList
        '
        Me.SongList.FormattingEnabled = True
        Me.SongList.Location = New System.Drawing.Point(358, 46)
        Me.SongList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SongList.Name = "SongList"
        Me.SongList.Size = New System.Drawing.Size(102, 251)
        Me.SongList.TabIndex = 7
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(529, 72)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(149, 20)
        Me.TextBox.TabIndex = 10
        Me.TextBox.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(529, 111)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(526, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(526, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Info"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(529, 150)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 20)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Info"
        '
        'PlaybackList
        '
        Me.PlaybackList.FormattingEnabled = True
        Me.PlaybackList.Location = New System.Drawing.Point(46, 351)
        Me.PlaybackList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlaybackList.Name = "PlaybackList"
        Me.PlaybackList.Size = New System.Drawing.Size(414, 30)
        Me.PlaybackList.TabIndex = 16
        '
        'BACK_TO_MENU
        '
        Me.BACK_TO_MENU.Location = New System.Drawing.Point(561, 351)
        Me.BACK_TO_MENU.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BACK_TO_MENU.Name = "BACK_TO_MENU"
        Me.BACK_TO_MENU.Size = New System.Drawing.Size(114, 30)
        Me.BACK_TO_MENU.TabIndex = 17
        Me.BACK_TO_MENU.Text = "Back to menu"
        Me.BACK_TO_MENU.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(526, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Info"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(529, 189)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(149, 20)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(526, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(532, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.BACK_TO_MENU)
        Me.Controls.Add(Me.PlaybackList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.SongList)
        Me.Controls.Add(Me.AlbumList)
        Me.Controls.Add(Me.HistoryLabel)
        Me.Controls.Add(Me.FavButton)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.List)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmSearch"
        Me.Text = "frmSearch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PlaybackList As ListBox
    Friend WithEvents BACK_TO_MENU As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
