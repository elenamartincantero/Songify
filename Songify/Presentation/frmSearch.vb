ublic Class frmSearch
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User
    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        readAlbum()
    End Sub
    Private Sub AlbumList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlbumList.SelectedIndexChanged
        readSong()
    End Sub
    Private Sub readArtists()
        Dim artistAux As Artist
        Me.artist = New Artist
        Try
            artist.readAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each artistAux In Me.artist.ArtistDAO.artists
            Me.List.Items.Add(artistAux.name)
        Next
        aArtist()
    End Sub
    Private Sub readAlbum()
        Dim albumAux As Album
        Me.artist = New Artist
        Try
            artist.readmyAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each albumAux In Me.album.AlbumDAO.albums
            Me.AlbumList.Items.Add(albumAux.name)
            InfoLabel.Text = "Info album"
        Next
        aAlbum()
    End Sub
    Private Sub readSong()
        Dim songAux As Song
        Me.album = New Album
        Try
            album.readmySong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each songAux In Me.album.AlbumDAO.albums
            Me.SongList.Items.Add(songAux.sName)
            InfoLabel.Text = "Info song"
        Next
        aSong()
        ShowButtons()
    End Sub
    Private Sub aSong()
        Me.song = New Song(SongList.SelectedItem.ToString)
        Try
            Me.song.readSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoList.Items.Clear()
        Me.InfoList.Items.Add(Me.song.album)
        Me.InfoList.Items.Add(Me.song.length)
    End Sub
    Private Sub aAlbum()
        Me.album = New Album(AlbumList.SelectedItem.ToString)
        Try
            Me.album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoList.Items.Clear()
        Me.InfoList.Items.Add(Me.album.length)
        Me.InfoList.Items.Add(Me.album.releaseDate)
    End Sub
    Private Sub aArtist()
        Me.artist = New Artist(List.SelectedItem.ToString)
        Try
            Me.artist.readArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoList.Items.Clear()
        Me.InfoList.Items.Add(Me.artist.image)
        Me.InfoList.Items.Add(Me.artist.country)
    End Sub
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        readArtists()
        Hiddebuttons()
    End Sub
    Private Sub Hiddebuttons()
        PlayButton.Visible = False
        HistoryButton.Visible = False
        FavButton.Visible = False
        InfoLabel.Visible = False
        UnFav.Visible = False
        HistoryLabel.Visible = False
    End Sub
    Private Sub ShowButtons()
        PlayButton.Visible = True
        HistoryButton.Visible = True
        FavButton.Visible = True
        InfoLabel.Visible = True
        UnFav.Visible = True
        HistoryLabel.Visible = True
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Dim song As Song = New Song(Me.SongList.SelectedItem.ToString)
        song.play(Me.user)
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Dim song As Song = New Song(Me.SongList.SelectedItem.ToString)
        InfoLabel.Text = "Info Playbacks"
        InfoList.Items.Clear()
        InfoList.Items.Add(song.readPlayblacks)
    End Sub

    Private Sub FavButton_Click(sender As Object, e As EventArgs) Handles FavButton.Click
        Dim artist As Artist = New Artist(Me.List.SelectedItem.ToString)
        artist.favArtist(Me.user)
    End Sub


    Private Sub UnFav_Click(sender As Object, e As EventArgs) Handles UnFav.Click
        Dim artist As Artist = New Artist(Me.List.SelectedItem.ToString)
        artist.not_favArtist(Me.user)
    End Sub
End Class
