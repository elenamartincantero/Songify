Public Class frmSearch
    Public Property myUser As User
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property allArtists As Collection

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HiddeAll()
        Me.myUser = frmMainMenu.user
        Me.allArtists = New Collection
        readArtists()
    End Sub
    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        If List.SelectedItem IsNot Nothing Then
            AlbumList.Items.Clear()
            SongList.Items.Clear()
            Me.artist = CType(Me.allArtists(List.SelectedIndex + 1), Artist)
            Me.artist.aAlbums.Clear()
            If Me.myUser.fav_artists.Contains(Me.artist.idArtist.ToString) Then
                FavButton.Text = "Un Fav"
            Else
                FavButton.Text = "Fav"
            End If
            readAlbum()
            infoArtist()
            FavButton.Enabled = True
        End If

    End Sub
    Private Sub AlbumList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AlbumList.SelectedIndexChanged
        If AlbumList.SelectedItem IsNot Nothing Then
            SongList.Items.Clear()
            readSongs()
            infoAlbum()
        End If

    End Sub
    Private Sub SongList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SongList.SelectedIndexChanged
        If SongList.SelectedItem IsNot Nothing Then
            Me.song = CType(Me.album.aSongs(SongList.SelectedIndex + 1), Song)
            infoSong()
            PlayButton.Enabled = True
            HistoryButton.Enabled = True
        End If

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
            Me.List.Items.Add(artistAux.aName.Replace("''", "'"))
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
            Me.AlbumList.Items.Add(albumAux.aName.Replace("''", "'"))
        Next
        InfoLabel.Text = "Info album"
    End Sub
    Private Sub readSongs()
        Dim songAux As Song = New Song
        Me.album = CType(Me.artist.aAlbums(AlbumList.SelectedIndex + 1), Album)
        Me.album.aSongs.Clear()
        Try
            Me.album.readAlbum()
            Me.album.readMySongs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each songAux In Me.album.aSongs
            Me.SongList.Items.Add(songAux.sName.Replace("''", "'"))
        Next
    End Sub

    Private Sub infoSong()
        HiddeAll()
        Try
            song.readSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoLabel.Text = "Song info"
        Me.Label1.Text = "Title"
        Me.Label2.Text = "Duration"
        Me.Label3.Text = "Album"
        Me.Label9.Text = Me.song.sName.Replace("''", "'")
        Me.Label10.Text = Me.song.convertLength
        Me.Label11.Text = Me.song.sAlbum.aName.Replace("''", "'")

        Me.InfoLabel.Visible = True
        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.Label11.Visible = True
        Me.Label9.Visible = True
        Me.Label10.Visible = True
        Me.Label11.Visible = True

    End Sub
    Private Sub infoAlbum()
        HiddeAll()
        Try
            album.calculateTotalLength()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.InfoLabel.Text = "Album info"
        Me.Label1.Text = "Title"
        Me.Label2.Text = "Release date"
        Me.Label3.Text = "Total length"
        Me.Label4.Text = "Artist"
        Me.Label5.Text = "Cover"
        Me.Label9.Text = Me.album.aName.Replace("''", "'")
        Me.Label10.Text = Me.album.aReleaseDate.ToShortDateString
        Me.Label11.Text = Me.album.convertLength()
        Me.Label12.Text = Me.album.aArtist.aName.Replace("''", "'")
        Me.PictureBox1.ImageLocation = Me.album.aCover

        Me.InfoLabel.Visible = True
        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.Label4.Visible = True
        Me.Label5.Visible = True
        Me.Label9.Visible = True
        Me.Label10.Visible = True
        Me.Label11.Visible = True
        Me.Label12.Visible = True
        Me.PictureBox1.Visible = True

    End Sub
    Private Sub infoArtist()
        HiddeAll()
        Me.InfoLabel.Text = "Artist info"
        Me.Label1.Text = "Name"
        Me.Label2.Text = "Country"
        Me.Label5.Text = "Image"
        Me.Label9.Text = Me.artist.aName.Replace("''", "'")
        Me.Label10.Text = Me.artist.aCountry.Replace("''", "'")
        Me.PictureBox1.ImageLocation = Me.artist.aImage

        Me.InfoLabel.Visible = True
        Me.Label1.Visible = True
        Me.Label2.Visible = True
        Me.Label5.Visible = True
        Me.Label9.Visible = True
        Me.Label10.Visible = True
        Me.PictureBox1.Visible = True
    End Sub
    Private Sub HiddeAll()
        PlayButton.Enabled = False
        HistoryButton.Enabled = False
        FavButton.Enabled = False
        InfoLabel.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        PictureBox1.Visible = False

    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If SongList.SelectedItem.ToString IsNot String.Empty Then
            Try
                If song.play(Me.myUser) <> 1 Then
                    MessageBox.Show("PLAY <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        If SongList.SelectedItem.ToString IsNot String.Empty Then
            Dim txt As String
            Dim songAux As Song = CType(Me.album.aSongs(SongList.SelectedIndex + 1), Song)
            Try
                txt = song.readPlayblacks()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Question)
                Exit Sub
            End Try
            Label5.Visible = True
            Label13.Visible = True
            Label5.Text = "Playbacks history"
            If txt Is String.Empty Then
                Label13.Text = "There are not playbacks of this song"
            Else
                Label13.Text = txt
            End If

        End If
    End Sub

    Private Sub FavButton_Click(sender As Object, e As EventArgs) Handles FavButton.Click
        If List.SelectedItem IsNot String.Empty Then
            If FavButton.Text = "Fav" Then
                Try
                    If artist.favArtist(Me.myUser) <> 1 Then
                        MessageBox.Show("FAV <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    FavButton.Text = "Un fav"
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
            Else
                Try
                    If artist.not_favArtist(Me.myUser) <> 1 Then
                        MessageBox.Show("UNFAV <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    FavButton.Text = "Fav"
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
            End If

        End If
    End Sub

    Private Sub BACK_TO_MENU_Click(sender As Object, e As EventArgs) Handles BACK_TO_MENU.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ChangeUserButton_Click(sender As Object, e As EventArgs) Handles ChangeUserButton.Click
        If MessageBox.Show("Are you sure you want to change user?", "Change user", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmLogin.Show()
            frmLogin.user = Me.myUser
            frmLogin.LoginButton.Enabled = True
            frmLogin.ConnectButton.Enabled = False
            frmLogin.LoginBox.Enabled = True
            Me.Close()
        End If
    End Sub
End Class