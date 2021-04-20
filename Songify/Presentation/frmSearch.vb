Public Class frmSearch
    Public Property myUser As User
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hiddebuttons()
        Me.myUser = frmMainMenu.user
        readArtists()
    End Sub
    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        AlbumList.Items.Clear()
        FavButton.Visible = True
        UnFav.Visible = True
        readAlbum()
        aArtist()
    End Sub
    Private Sub AlbumList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlbumList.SelectedIndexChanged
        SongList.Items.Clear()
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
        For Each artistAux In Me.artist.ArtistDAO.allArtists
            Me.List.Items.Add(artistAux.aName)
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
        Me.artist = New Artist(artistAux.idArtist, artistAux.aName)
        Try
            artist.readMyAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        For Each albumAux In Me.artist.aAlbums
            Me.AlbumList.Items.Add(albumAux.aName)
        Next
        InfoLabel.Text = "Info album"
    End Sub
    Private Sub readSong()
        Dim songAux As Song
        Dim albumAux As Album = New Album()
        Try
            albumAux.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.album = New Album(albumAux.idAlbum, albumAux.aName)
        Try
            album.readMySongs()
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
    Private Sub aSong()
        'Me.song = New Song(SongList.SelectedItem.ToString)
        Try
            song.readSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.Label3.Visible = True
        Me.TextBox2.Visible = True
        Me.Label1.Text = "Album"
        Me.Label2.Text = "Duration"
        Me.Label3.Text = "ID song"
        Me.TextBox.Text = Me.song.sAlbum.aName
        Me.TextBox1.Text = CStr(Me.song.sLength)
        Me.TextBox2.Text = CStr(Me.song.idSong)
    End Sub
    Private Sub aAlbum()
        Me.album = New Album()
        Try
            album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Try
            album.calculateTotalLength()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.Label3.Visible = True
        Me.TextBox2.Visible = True
        Me.Label1.Text = "Album ID"
        Me.Label2.Text = "Release date"
        Me.Label3.Text = "Cover"
        Me.TextBox.Text = CStr(Me.album.idAlbum)
        Me.TextBox1.Text = CStr(Me.album.aReleaseDate)
        Me.TextBox2.Text = Me.album.convertLength()
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
        Me.TextBox.Text = CStr(Me.artist.idArtist)
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
        UnFav.Visible = True
        HistoryLabel.Visible = True
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If SongList.SelectedItem IsNot String.Empty Then
            'Dim songAux As Song = New Song(SongList.SelectedItem.ToString)
            Try
                'songAux.readSong()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            'Me.song = New Song(songAux.idSong)
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


    Private Sub UnFav_Click(sender As Object, e As EventArgs) Handles UnFav.Click
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
                artist.not_favArtist(Me.myUser)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub SongList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SongList.SelectedIndexChanged
        aSong()
        ShowButtons()
    End Sub

    Private Sub BACK_TO_MENU_Click(sender As Object, e As EventArgs) Handles BACK_TO_MENU.Click
        frmMainMenu.user = Me.myUser
        frmMainMenu.Show()
        Me.Close()
    End Sub
End Class