Public Class frmSearch
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User
    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        readAlbum()
        aArtist()
    End Sub
    Private Sub AlbumList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlbumList.SelectedIndexChanged
        readSong()
        aAlbum()
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
    End Sub
    Private Sub readAlbum()
        Dim albumAux As Album
        Dim artistAux As Artist = New Artist(List.SelectedItem.ToString)
        Try
            artistAux.readArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        Me.artist = New Artist(artistAux.id)
        Try
            artist.readMyAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        For Each albumAux In Me.artist.albums
            Me.AlbumList.Items.Add(albumAux.name)
            InfoLabel.Text = "Info album"
        Next
    End Sub
    Private Sub readSong()
        Dim songAux As Song
        Dim albumAux As Album = New Album(AlbumList.SelectedItem.ToString)
        Try
            albumAux.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.album = New Album(albumAux.albumID)
        Try
            album.readMySongs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each songAux In Me.album.songs
            Me.SongList.Items.Add(songAux.sName)
        Next
        ShowButtons()
    End Sub
    Private Sub aSong()
        Me.song = New Song(SongList.SelectedItem.ToString)
        Try
            song.readSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        ShowInfo()
        Me.Label1.Text = "Album"
        Me.Label2.Text = "Duration"
        Me.Label3.Text = "ID song"
        Me.TextBox.Text = Me.song.album.name
        Me.TextBox1.Text = CStr(Me.song.length)
        Me.TextBox2.Text = CStr(Me.song.idSong)
    End Sub
    Private Sub HideINfo()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Me.TextBox.Visible = False
        Me.TextBox1.Visible = False
        Me.TextBox2.Visible = False
    End Sub
    Private Sub ShowInfo()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Me.TextBox.Visible = True
        Me.TextBox1.Visible = True
        Me.TextBox2.Visible = True
    End Sub
    Private Sub aAlbum()
        Me.album = New Album(AlbumList.SelectedItem.ToString)
        Try
            album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        ShowInfo()
        Me.Label1.Text = "Album ID"
        Me.Label2.Text = "Release date"
        Me.Label3.Text = "Cover"
        Me.TextBox.Text = CStr(Me.album.albumID)
        Me.TextBox1.Text = CStr(Me.album.releaseDate)
        Me.TextBox2.Text = Me.album.cover
    End Sub
    Private Sub aArtist()
        Me.artist = New Artist(List.SelectedItem.ToString)
        Try
            artist.readArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        ShowInfo()
        Me.Label1.Text = "Artist ID"
        Me.Label2.Text = "Release date"
        Me.Label3.Visible = False
        Me.TextBox2.Visible = False
        Me.TextBox.Text = CStr(Me.artist.id)
        Me.TextBox1.Text = Me.artist.country
    End Sub
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Start.Click
        readArtists()
        Hiddebuttons()
    End Sub
    Private Sub Hiddebuttons()
        PlayButton.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        HistoryButton.Visible = False
        FavButton.Visible = False
        InfoLabel.Visible = False
        UnFav.Visible = False
        HistoryLabel.Visible = False
        Start.Visible = False

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
    End Sub

    Private Sub FavButton_Click(sender As Object, e As EventArgs) Handles FavButton.Click
        Dim artist As Artist = New Artist(Me.List.SelectedItem.ToString)
        artist.favArtist(Me.user)
    End Sub


    Private Sub UnFav_Click(sender As Object, e As EventArgs) Handles UnFav.Click
        Dim artist As Artist = New Artist(Me.List.SelectedItem.ToString)
        artist.not_favArtist(Me.user)
    End Sub

    Private Sub SongList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SongList.SelectedIndexChanged
        aSong()
    End Sub
End Class