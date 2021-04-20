Public Class frmSearch
    Public Property myUser As User
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User
    Property allArtists As Collection

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hiddebuttons()
        Me.myUser = frmMainMenu.user
        Me.allArtists = New Collection
        readArtists()
    End Sub
    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        AlbumList.Items.Clear()
        Me.artist = CType(Me.allArtists(List.SelectedIndex + 1), Artist)
        If Me.myUser.fav_artists.Contains(Me.artist.idArtist.ToString) Then
            FavButton.Text = "Un Fav"
        Else
            FavButton.Text = "Fav"
        End If
        FavButton.Visible = True
        readAlbum()
        infoArtist()
    End Sub
    Private Sub AlbumList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlbumList.SelectedIndexChanged
        SongList.Items.Clear()
        readSongs()
        infoAlbum()
    End Sub
    Private Sub readArtists()
        Dim artistAux As Artist = New Artist
        Me.artist = New Artist
        Try
            artist.readAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each artistAux In Me.artist.ArtistDAO.allArtists
            Me.List.Items.Add(artistAux.aName)
            Me.allArtists.Add(artistAux)
        Next
    End Sub
    Private Sub readAlbum()
        Dim albumAux As Album
        Try
            Me.artist.readArtist()
            Me.artist.readMyAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        For Each albumAux In Me.artist.aAlbums
            Me.AlbumList.Items.Add(albumAux.aName)
        Next
        InfoLabel.Text = "Info album"
    End Sub
    Private Sub readSongs()
        Dim songAux As Song = New Song
        Me.album = CType(Me.artist.aAlbums(AlbumList.SelectedIndex + 1), Album)
        Try
            Me.album.readAlbum()
            Me.album.readMySongs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each songAux In Me.album.aSongs
            Me.SongList.Items.Add(songAux.sName)
        Next
    End Sub
    Private Sub ShowInfo()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Me.TextBox.Visible = True
        Me.TextBox1.Visible = True
        Me.TextBox2.Visible = True
    End Sub
    Private Sub infoSong()
        Try
            song.readSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoLabel.Text = "Song info"
        Me.InfoLabel.Visible = True
        Me.Label3.Visible = True
        Me.TextBox2.Visible = True
        Me.Label1.Text = "Title"
        Me.Label2.Text = "Duration"
        Me.Label3.Text = "Album"
        Me.TextBox.Text = Me.song.sName
        Me.TextBox1.Text = Me.song.convertLength
        Me.TextBox2.Text = Me.song.sAlbum.aName
    End Sub
    Private Sub infoAlbum()
        Try
            album.calculateTotalLength()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoLabel.Text = "Album info"
        Me.InfoLabel.Visible = True
        Me.Label3.Visible = True
        Me.TextBox2.Visible = True
        Me.Label5.Visible = True
        Me.Label1.Text = "Name"
        Me.Label2.Text = "Release date"
        Me.Label3.Text = "Total length"
        Me.Label4.Text = "Artist"
        Me.Label5.Text = "Cover"
        Me.TextBox.Text = Me.album.aName
        Me.TextBox1.Text = Me.album.aReleaseDate.ToString
        Me.TextBox2.Text = Me.album.convertLength()
        Me.TextBox3.Text = Me.album.aArtist.aName
        Me.PictureBox1.ImageLocation = Me.album.aCover
    End Sub
    Private Sub infoArtist()
        ShowInfo()
        Me.InfoLabel.Text = "Artist info"
        Me.InfoLabel.Visible = True
        Me.Label1.Text = "Name"
        Me.Label2.Text = "Country"
        Me.Label3.Visible = False
        Me.Label5.Text = "Image"
        Me.PictureBox1.ImageLocation = Me.artist.aImage
        Me.TextBox2.Visible = False
        Me.TextBox.Text = Me.artist.aName
        Me.TextBox1.Text = Me.artist.aCountry
    End Sub
    Private Sub Hiddebuttons()
        PlayButton.Visible = False
        PlaybackList.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        HistoryButton.Visible = False
        InfoLabel.Visible = False
        HistoryLabel.Visible = False
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
        If SongList.SelectedItem IsNot String.Empty Then
            Try
                song.play(Me.myUser)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        If SongList.SelectedItem IsNot String.Empty Then
            Dim txt As String = ""
            'Dim songAux As Song = New Song(SongList.SelectedItem.ToString)
            Try
                'songAux.readSong()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            'Me.song = New Song(songAux.idSong)
            Try
                txt = song.readPlayblacks()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Question)
                Exit Sub
            End Try
            HistoryLabel.Text = "Info Playbacks"
            PlaybackList.Items.Add(txt)
        End If
    End Sub

    Private Sub FavButton_Click(sender As Object, e As EventArgs) Handles FavButton.Click
        If List.SelectedItem IsNot String.Empty Then
            Dim artistAux As Artist = New Artist(Me.List.SelectedItem.ToString)
            Try
                artistAux.readArtist()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.artist = New Artist(artistAux.idArtist, artistAux.aName)
            Try
                artist.favArtist(Me.myUser)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub SongList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SongList.SelectedIndexChanged
        Me.song = CType(Me.album.aSongs(SongList.SelectedIndex + 1), Song)
        infoSong()
        ShowButtons()
    End Sub

    Private Sub BACK_TO_MENU_Click(sender As Object, e As EventArgs) Handles BACK_TO_MENU.Click
        frmMainMenu.Show()
        frmMainMenu.user = Me.myUser
        Me.Close()
    End Sub
End Class