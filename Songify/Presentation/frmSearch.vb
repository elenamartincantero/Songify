Public Class frmSearch
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
            Me.InfoList.Items.Add(artistAux.country)
        Next
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
            Me.InfoList.Items.Add(albumAux.releaseDate)
            Me.InfoList.Items.Add(albumAux.artist)
        Next
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
            InfoLabel.Text = "Info son"
            Me.InfoList.Items.Add(songAux.album)
            Me.InfoList.Items.Add(songAux.length)
        Next
        ShowButtons()
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
        HistoryLabel.Visible = False
    End Sub
    Private Sub ShowButtons()
        PlayButton.Visible = True
        HistoryButton.Visible = True
        FavButton.Visible = True
        InfoLabel.Visible = True
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
