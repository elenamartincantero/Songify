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
        Me.AlbumList = New System.Windows.Forms.ListBox()
        Me.SongList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BACK_TO_MENU = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChangeUserButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.FormattingEnabled = True
        Me.List.HorizontalScrollbar = True
        Me.List.Location = New System.Drawing.Point(36, 75)
        Me.List.Margin = New System.Windows.Forms.Padding(2)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(117, 303)
        Me.List.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(478, 47)
        Me.InfoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(25, 13)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Info"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(198, 6)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(59, 40)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'HistoryButton
        '
        Me.HistoryButton.Location = New System.Drawing.Point(261, 6)
        Me.HistoryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(132, 40)
        Me.HistoryButton.TabIndex = 3
        Me.HistoryButton.Text = "Show playbacks history"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'FavButton
        '
        Me.FavButton.Location = New System.Drawing.Point(140, 6)
        Me.FavButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FavButton.Name = "FavButton"
        Me.FavButton.Size = New System.Drawing.Size(54, 40)
        Me.FavButton.TabIndex = 4
        Me.FavButton.Text = "Fav"
        Me.FavButton.UseVisualStyleBackColor = True
        '
        'AlbumList
        '
        Me.AlbumList.FormattingEnabled = True
        Me.AlbumList.HorizontalScrollbar = True
        Me.AlbumList.Location = New System.Drawing.Point(185, 75)
        Me.AlbumList.Margin = New System.Windows.Forms.Padding(2)
        Me.AlbumList.Name = "AlbumList"
        Me.AlbumList.Size = New System.Drawing.Size(117, 303)
        Me.AlbumList.TabIndex = 6
        '
        'SongList
        '
        Me.SongList.FormattingEnabled = True
        Me.SongList.HorizontalScrollbar = True
        Me.SongList.Location = New System.Drawing.Point(333, 75)
        Me.SongList.Margin = New System.Windows.Forms.Padding(2)
        Me.SongList.Name = "SongList"
        Me.SongList.Size = New System.Drawing.Size(117, 303)
        Me.SongList.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(478, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Info"
        '
        'BACK_TO_MENU
        '
        Me.BACK_TO_MENU.Location = New System.Drawing.Point(588, 6)
        Me.BACK_TO_MENU.Margin = New System.Windows.Forms.Padding(2)
        Me.BACK_TO_MENU.Name = "BACK_TO_MENU"
        Me.BACK_TO_MENU.Size = New System.Drawing.Size(86, 40)
        Me.BACK_TO_MENU.TabIndex = 17
        Me.BACK_TO_MENU.Text = "Return to main menu"
        Me.BACK_TO_MENU.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(478, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(481, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 60)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Artists"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Albums"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Songs"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(481, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(481, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(481, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 20)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(481, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(481, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 142)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Label13"
        '
        'ChangeUserButton
        '
        Me.ChangeUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeUserButton.Location = New System.Drawing.Point(481, 6)
        Me.ChangeUserButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeUserButton.Name = "ChangeUserButton"
        Me.ChangeUserButton.Size = New System.Drawing.Size(86, 38)
        Me.ChangeUserButton.TabIndex = 32
        Me.ChangeUserButton.Text = "Change User"
        Me.ChangeUserButton.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.ChangeUserButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BACK_TO_MENU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SongList)
        Me.Controls.Add(Me.AlbumList)
        Me.Controls.Add(Me.FavButton)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.List)
        Me.Margin = New System.Windows.Forms.Padding(2)
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

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents AlbumList As ListBox
    Friend WithEvents SongList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BACK_TO_MENU As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ChangeUserButton As Button
End Class
