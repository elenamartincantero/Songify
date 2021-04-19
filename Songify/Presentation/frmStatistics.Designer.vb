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
        Me.DateTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.BeginLabel = New System.Windows.Forms.Label()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ArtistSorted = New System.Windows.Forms.Button()
        Me.UserSorted = New System.Windows.Forms.Button()
        Me.SongSorted = New System.Windows.Forms.Button()
        Me.ListenedArtist = New System.Windows.Forms.Button()
        Me.Playbacktime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimeBegin
        '
        Me.DateTimeBegin.Location = New System.Drawing.Point(73, 132)
        Me.DateTimeBegin.Name = "DateTimeBegin"
        Me.DateTimeBegin.Size = New System.Drawing.Size(281, 22)
        Me.DateTimeBegin.TabIndex = 1
        '
        'BeginLabel
        '
        Me.BeginLabel.AutoSize = True
        Me.BeginLabel.Location = New System.Drawing.Point(73, 93)
        Me.BeginLabel.Name = "BeginLabel"
        Me.BeginLabel.Size = New System.Drawing.Size(78, 17)
        Me.BeginLabel.TabIndex = 2
        Me.BeginLabel.Text = "Begin Date"
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Location = New System.Drawing.Point(422, 93)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(67, 17)
        Me.EndLabel.TabIndex = 3
        Me.EndLabel.Text = "End Date"
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Location = New System.Drawing.Point(422, 132)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(278, 22)
        Me.DateTimeEnd.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(88, 204)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(230, 212)
        Me.ListBox1.TabIndex = 5
        '
        'ArtistSorted
        '
        Me.ArtistSorted.Location = New System.Drawing.Point(76, 26)
        Me.ArtistSorted.Name = "ArtistSorted"
        Me.ArtistSorted.Size = New System.Drawing.Size(75, 31)
        Me.ArtistSorted.TabIndex = 6
        Me.ArtistSorted.Text = "ArtistSorted"
        Me.ArtistSorted.UseVisualStyleBackColor = True
        '
        'UserSorted
        '
        Me.UserSorted.Location = New System.Drawing.Point(435, 26)
        Me.UserSorted.Name = "UserSorted"
        Me.UserSorted.Size = New System.Drawing.Size(99, 31)
        Me.UserSorted.TabIndex = 7
        Me.UserSorted.Text = "UserSorted"
        Me.UserSorted.UseVisualStyleBackColor = True
        '
        'SongSorted
        '
        Me.SongSorted.Location = New System.Drawing.Point(187, 26)
        Me.SongSorted.Name = "SongSorted"
        Me.SongSorted.Size = New System.Drawing.Size(94, 31)
        Me.SongSorted.TabIndex = 8
        Me.SongSorted.Text = "SongSorted"
        Me.SongSorted.UseVisualStyleBackColor = True
        '
        'ListenedArtist
        '
        Me.ListenedArtist.Location = New System.Drawing.Point(310, 26)
        Me.ListenedArtist.Name = "ListenedArtist"
        Me.ListenedArtist.Size = New System.Drawing.Size(104, 31)
        Me.ListenedArtist.TabIndex = 9
        Me.ListenedArtist.Text = "ListenedArtist"
        Me.ListenedArtist.UseVisualStyleBackColor = True
        '
        'Playbacktime
        '
        Me.Playbacktime.Location = New System.Drawing.Point(567, 26)
        Me.Playbacktime.Name = "Playbacktime"
        Me.Playbacktime.Size = New System.Drawing.Size(118, 31)
        Me.Playbacktime.TabIndex = 10
        Me.Playbacktime.Text = "PlaybackTime"
        Me.Playbacktime.UseVisualStyleBackColor = True
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 480)
        Me.Controls.Add(Me.Playbacktime)
        Me.Controls.Add(Me.ListenedArtist)
        Me.Controls.Add(Me.SongSorted)
        Me.Controls.Add(Me.UserSorted)
        Me.Controls.Add(Me.ArtistSorted)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DateTimeEnd)
        Me.Controls.Add(Me.EndLabel)
        Me.Controls.Add(Me.BeginLabel)
        Me.Controls.Add(Me.DateTimeBegin)
        Me.Name = "frmStatistics"
        Me.Text = "End Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimeBegin As DateTimePicker
    Friend WithEvents BeginLabel As Label
    Friend WithEvents EndLabel As Label
    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ArtistSorted As Button
    Friend WithEvents UserSorted As Button
    Friend WithEvents SongSorted As Button
    Friend WithEvents ListenedArtist As Button
    Friend WithEvents Playbacktime As Button
End Class
