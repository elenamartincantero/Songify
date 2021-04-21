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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Playbacktime = New System.Windows.Forms.Button()
        Me.ListenedArtist = New System.Windows.Forms.Button()
        Me.SongSorted = New System.Windows.Forms.Button()
        Me.UserSorted = New System.Windows.Forms.Button()
        Me.ArtistSorted = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(27, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 404)
        Me.ListBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(304, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Return to main menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Playbacktime
        '
        Me.Playbacktime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playbacktime.Location = New System.Drawing.Point(300, 387)
        Me.Playbacktime.Name = "Playbacktime"
        Me.Playbacktime.Size = New System.Drawing.Size(164, 53)
        Me.Playbacktime.TabIndex = 16
        Me.Playbacktime.Text = "List my favorite artists playback time"
        Me.Playbacktime.UseVisualStyleBackColor = True
        '
        'ListenedArtist
        '
        Me.ListenedArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListenedArtist.Location = New System.Drawing.Point(300, 249)
        Me.ListenedArtist.Name = "ListenedArtist"
        Me.ListenedArtist.Size = New System.Drawing.Size(164, 53)
        Me.ListenedArtist.TabIndex = 15
        Me.ListenedArtist.Text = "List my most listened to artist"
        Me.ListenedArtist.UseVisualStyleBackColor = True
        '
        'SongSorted
        '
        Me.SongSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongSorted.Location = New System.Drawing.Point(300, 178)
        Me.SongSorted.Name = "SongSorted"
        Me.SongSorted.Size = New System.Drawing.Size(164, 53)
        Me.SongSorted.TabIndex = 14
        Me.SongSorted.Text = "Sort songs by number of playbacks"
        Me.SongSorted.UseVisualStyleBackColor = True
        '
        'UserSorted
        '
        Me.UserSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserSorted.Location = New System.Drawing.Point(300, 318)
        Me.UserSorted.Name = "UserSorted"
        Me.UserSorted.Size = New System.Drawing.Size(164, 53)
        Me.UserSorted.TabIndex = 13
        Me.UserSorted.Text = "List users by application time use"
        Me.UserSorted.UseVisualStyleBackColor = True
        '
        'ArtistSorted
        '
        Me.ArtistSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistSorted.Location = New System.Drawing.Point(300, 109)
        Me.ArtistSorted.Name = "ArtistSorted"
        Me.ArtistSorted.Size = New System.Drawing.Size(164, 53)
        Me.ArtistSorted.TabIndex = 12
        Me.ArtistSorted.Text = "Sort artist by number of playbacks"
        Me.ArtistSorted.UseVisualStyleBackColor = True
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 471)
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

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Playbacktime As Button
    Friend WithEvents ListenedArtist As Button
    Friend WithEvents SongSorted As Button
    Friend WithEvents UserSorted As Button
    Friend WithEvents ArtistSorted As Button
End Class
