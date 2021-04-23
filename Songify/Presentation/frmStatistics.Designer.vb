<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatistics
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Playbacktime = New System.Windows.Forms.Button()
        Me.ListenedArtist = New System.Windows.Forms.Button()
        Me.SongSorted = New System.Windows.Forms.Button()
        Me.UserSorted = New System.Windows.Forms.Button()
        Me.ArtistSorted = New System.Windows.Forms.Button()
        Me.LabelFrom = New System.Windows.Forms.Label()
        Me.BeginDate = New System.Windows.Forms.DateTimePicker()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelTo = New System.Windows.Forms.Label()
        Me.ButtoAccp = New System.Windows.Forms.Button()
        Me.ComboBoxCountry = New System.Windows.Forms.ComboBox()
        Me.LabelCountry = New System.Windows.Forms.Label()
        Me.ChangeUserButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(25, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(240, 334)
        Me.ListBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(406, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Return to main menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Playbacktime
        '
        Me.Playbacktime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playbacktime.Location = New System.Drawing.Point(292, 329)
        Me.Playbacktime.Name = "Playbacktime"
        Me.Playbacktime.Size = New System.Drawing.Size(212, 53)
        Me.Playbacktime.TabIndex = 16
        Me.Playbacktime.Text = "List my favorite artists playback time"
        Me.Playbacktime.UseVisualStyleBackColor = True
        '
        'ListenedArtist
        '
        Me.ListenedArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListenedArtist.Location = New System.Drawing.Point(292, 188)
        Me.ListenedArtist.Name = "ListenedArtist"
        Me.ListenedArtist.Size = New System.Drawing.Size(212, 53)
        Me.ListenedArtist.TabIndex = 15
        Me.ListenedArtist.Text = "List my most listened to artist"
        Me.ListenedArtist.UseVisualStyleBackColor = True
        '
        'SongSorted
        '
        Me.SongSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongSorted.Location = New System.Drawing.Point(292, 117)
        Me.SongSorted.Name = "SongSorted"
        Me.SongSorted.Size = New System.Drawing.Size(212, 53)
        Me.SongSorted.TabIndex = 14
        Me.SongSorted.Text = "Sort songs by number of playbacks"
        Me.SongSorted.UseVisualStyleBackColor = True
        '
        'UserSorted
        '
        Me.UserSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserSorted.Location = New System.Drawing.Point(292, 260)
        Me.UserSorted.Name = "UserSorted"
        Me.UserSorted.Size = New System.Drawing.Size(212, 53)
        Me.UserSorted.TabIndex = 13
        Me.UserSorted.Text = "List users by application time use"
        Me.UserSorted.UseVisualStyleBackColor = True
        '
        'ArtistSorted
        '
        Me.ArtistSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistSorted.Location = New System.Drawing.Point(292, 48)
        Me.ArtistSorted.Name = "ArtistSorted"
        Me.ArtistSorted.Size = New System.Drawing.Size(212, 53)
        Me.ArtistSorted.TabIndex = 12
        Me.ArtistSorted.Text = "Sort artist by number of playbacks"
        Me.ArtistSorted.UseVisualStyleBackColor = True
        '
        'LabelFrom
        '
        Me.LabelFrom.AutoSize = True
        Me.LabelFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.753846!)
        Me.LabelFrom.Location = New System.Drawing.Point(291, 399)
        Me.LabelFrom.Name = "LabelFrom"
        Me.LabelFrom.Size = New System.Drawing.Size(36, 15)
        Me.LabelFrom.TabIndex = 17
        Me.LabelFrom.Text = "From"
        Me.LabelFrom.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelFrom.Visible = False
        '
        'BeginDate
        '
        Me.BeginDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.753846!)
        Me.BeginDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BeginDate.Location = New System.Drawing.Point(330, 396)
        Me.BeginDate.Name = "BeginDate"
        Me.BeginDate.Size = New System.Drawing.Size(89, 21)
        Me.BeginDate.TabIndex = 18
        Me.BeginDate.Visible = False
        '
        'EndDate
        '
        Me.EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.753846!)
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(330, 421)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(89, 21)
        Me.EndDate.TabIndex = 20
        Me.EndDate.Visible = False
        '
        'LabelTo
        '
        Me.LabelTo.AutoSize = True
        Me.LabelTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.753846!)
        Me.LabelTo.Location = New System.Drawing.Point(301, 424)
        Me.LabelTo.Name = "LabelTo"
        Me.LabelTo.Size = New System.Drawing.Size(21, 15)
        Me.LabelTo.TabIndex = 19
        Me.LabelTo.Text = "To"
        Me.LabelTo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelTo.Visible = False
        '
        'ButtoAccp
        '
        Me.ButtoAccp.Location = New System.Drawing.Point(426, 396)
        Me.ButtoAccp.Name = "ButtoAccp"
        Me.ButtoAccp.Size = New System.Drawing.Size(78, 46)
        Me.ButtoAccp.TabIndex = 21
        Me.ButtoAccp.Text = "Accept"
        Me.ButtoAccp.UseVisualStyleBackColor = True
        Me.ButtoAccp.Visible = False
        '
        'ComboBoxCountry
        '
        Me.ComboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCountry.FormattingEnabled = True
        Me.ComboBoxCountry.Items.AddRange(New Object() {""})
        Me.ComboBoxCountry.Location = New System.Drawing.Point(25, 421)
        Me.ComboBoxCountry.Name = "ComboBoxCountry"
        Me.ComboBoxCountry.Size = New System.Drawing.Size(240, 21)
        Me.ComboBoxCountry.TabIndex = 22
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.753846!)
        Me.LabelCountry.Location = New System.Drawing.Point(22, 399)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(91, 15)
        Me.LabelCountry.TabIndex = 23
        Me.LabelCountry.Text = "Filter by country"
        Me.LabelCountry.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LabelCountry.Visible = False
        '
        'ChangeUserButton
        '
        Me.ChangeUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeUserButton.Location = New System.Drawing.Point(294, 7)
        Me.ChangeUserButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeUserButton.Name = "ChangeUserButton"
        Me.ChangeUserButton.Size = New System.Drawing.Size(98, 35)
        Me.ChangeUserButton.TabIndex = 24
        Me.ChangeUserButton.Text = "Change User"
        Me.ChangeUserButton.UseVisualStyleBackColor = True
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 471)
        Me.Controls.Add(Me.ChangeUserButton)
        Me.Controls.Add(Me.LabelCountry)
        Me.Controls.Add(Me.ComboBoxCountry)
        Me.Controls.Add(Me.ButtoAccp)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.LabelTo)
        Me.Controls.Add(Me.BeginDate)
        Me.Controls.Add(Me.LabelFrom)
        Me.Controls.Add(Me.Playbacktime)
        Me.Controls.Add(Me.ListenedArtist)
        Me.Controls.Add(Me.SongSorted)
        Me.Controls.Add(Me.UserSorted)
        Me.Controls.Add(Me.ArtistSorted)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStatistics"
        Me.Text = "Songify - Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Playbacktime As Button
    Friend WithEvents ListenedArtist As Button
    Friend WithEvents SongSorted As Button
    Friend WithEvents UserSorted As Button
    Friend WithEvents ArtistSorted As Button
    Friend WithEvents LabelFrom As Label
    Friend WithEvents BeginDate As DateTimePicker
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents LabelTo As Label
    Friend WithEvents ButtoAccp As Button
    Friend WithEvents ComboBoxCountry As ComboBox
    Friend WithEvents LabelCountry As Label
    Friend WithEvents ChangeUserButton As Button
End Class
