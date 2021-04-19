Public Class frmManage
    Public Property myUser As User
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User


    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        frmMainMenu.Show()
        frmMainMenu.user = Me.myUser
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = String.Empty
        InfoTextBox2.Text = String.Empty
        InfoTextBox3.Text = String.Empty
        InfoTextBox3.Enabled = True
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InfoListBox.SelectedIndexChanged
        If InfoListBox IsNot Nothing Then
            ClearButton.Enabled = True
            DeleteButton.Enabled = True
            UpdateButton.Enabled = True
            If DataTypeComboBox.SelectedItem.ToString() = "Users" Then
                listUser()
            ElseIf DataTypeComboBox.SelectedItem.ToString() = "Artists" Then
                listArtist()
            ElseIf DataTypeComboBox.SelectedItem.ToString() = "Albums" Then
                listAlbum()
            ElseIf DataTypeComboBox.SelectedItem.ToString() = "Songs" Then
                listSong()
            End If
        End If
    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataTypeComboBox.SelectedIndexChanged
        If DataTypeComboBox.SelectedItem IsNot Nothing Then
            invisibleElements()
            InsertButton.Enabled = True
        End If
        If DataTypeComboBox.SelectedItem.ToString() = "Users" Then
            resetElements()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Surname"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Email"
            DateBox.Visible = True
            DateLabel.Visible = True
            DateLabel.Text = "Birthdate"
            readUsers()

        ElseIf DataTypeComboBox.SelectedItem.ToString() = "Artists" Then
            resetElements()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Country"
            ImageButton.Visible = True
            ImageButton.Text = "Change image"
            readArtists()

        ElseIf DataTypeComboBox.SelectedItem.ToString() = "Albums" Then
            resetElements()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            DateBox.Visible = True
            DateLabel.Visible = True
            DateLabel.Text = "Release date"
            SelectionComboBox.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Artist"
            ImageButton.Visible = True
            ImageButton.Text = "Change cover"
            readAlbums()
            readArtistInAlbum()

        ElseIf DataTypeComboBox.SelectedItem.ToString() = "Songs" Then
            resetElements()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Length"
            SelectionComboBox.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Belonging album"
            readSongs()
            readAlbumInSong()
        End If

    End Sub

    Private Sub resetElements()
        NameTextBox.Text = String.Empty
        InfoTextBox2.Text = String.Empty
        InfoTextBox3.Text = String.Empty
        InfoTextBox3.Enabled = True
        InfoListBox.Items.Clear()
        SelectionComboBox.Items.Clear()
        SelectionComboBox.Text = String.Empty
    End Sub

    Private Sub invisibleElements()
        NameTextBox.Visible = False
        NameLabel.Visible = False
        InfoTextBox2.Visible = False
        InfoLabel2.Visible = False
        InfoTextBox3.Visible = False
        InfoLabel3.Visible = False
        DateLabel.Visible = False
        DateBox.Visible = False
        SelectionComboBox.Visible = False
        ImageButton.Visible = False
    End Sub

    Private Sub readUsers()
        Dim uAux As User
        Me.user = New User
        Try
            user.readAllUsers()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each uAux In Me.user.UserDAO.allUsers
            Me.InfoListBox.Items.Add(uAux.email)
        Next
    End Sub

    Private Sub readArtists()
        Dim artistAux As Artist
        Me.artist = New Artist
        Try
            artist.readAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each artistAux In Me.artist.ArtistDAO.artists
            Me.InfoListBox.Items.Add(artistAux.name)
        Next
    End Sub

    Private Sub readSongs()
        Dim songAux As Song
        Me.song = New Song
        Try
            song.readAllSongs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each songAux In Me.song.SongDAO.allSongs
            Me.InfoListBox.Items.Add(songAux.sName)
        Next
    End Sub

    Private Sub readAlbums()
        Dim albumAux As Album
        Me.album = New Album
        Try
            album.readAllAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each albumAux In Me.album.AlbumDAO.albums
            Me.InfoListBox.Items.Add(albumAux.name)
        Next
    End Sub

    Private Sub listUser()
        Me.user = New User(InfoListBox.SelectedItem.ToString) 'email
        Try
            Me.user.readUser()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Enabled = False
        NameTextBox.Text = Me.user.uName
        InfoTextBox2.Text = Me.user.uSurname
        InfoTextBox3.Text = Me.user.email
        DateBox.Value = Me.user.birthday
    End Sub

    Private Sub listArtist()
        Me.artist = New Artist(InfoListBox.SelectedItem.ToString)  'name
        Try
            Me.artist.readArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Text = Me.artist.name
        InfoTextBox2.Text = Me.artist.country
        InfoTextBox3.Text = Me.artist.image
        ImageBox.ImageLocation = Me.artist.image
        ImageBox.Visible = True
    End Sub

    Private Sub listAlbum()
        Me.album = New Album(InfoListBox.SelectedItem.ToString) 'name
        Try
            Me.album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Text = Me.album.name
        InfoTextBox2.Text = Me.album.cover
        DateBox.Value = Me.album.releaseDate
        ImageBox.ImageLocation = Me.album.cover
        ImageBox.Visible = True
        SelectionComboBox.SelectedItem = Me.album.artist.name.ToString

    End Sub

    Private Sub listSong()
        Me.song = New Song(InfoListBox.SelectedItem.ToString)
        Try
            Me.song.readSong()
            Me.song.album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Text = Me.song.sName
        InfoTextBox2.Text = Me.song.length.ToString
        SelectionComboBox.SelectedItem = Me.song.album.name
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        If DataTypeComboBox.SelectedItem.ToString = "Users" Then
            insertUser()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            insertArtist()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            insertAlbum()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Songs" Then
            insertSong()
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If DataTypeComboBox.SelectedItem.ToString = "Users" Then
            updateUser()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            updateArtist()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            updateAlbum()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Songs" Then
            updateSong()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataTypeComboBox.SelectedItem.ToString = "Users" Then
            'deleteUser()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            'deleteArtist()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            'deleteAlbum()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Songs" Then
            'deleteSong()
        End If
    End Sub

    Private Sub insertUser()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And
                InfoTextBox3.Text IsNot String.Empty Then
            Me.user = New User(InfoTextBox3.Text)
            Me.user.uName = NameTextBox.Text
            Me.user.uSurname = InfoTextBox2.Text
            Me.user.birthday = Date.Parse(DateBox.Value.ToShortDateString)
            Try
                Me.user.insertUser()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.InfoListBox.Items.Add(Me.user.email)
        End If
    End Sub

    Private Sub insertArtist()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Me.artist = New Artist(NameTextBox.Text)
            Me.artist.country = InfoTextBox2.Text
            Me.artist.image = InfoTextBox3.Text
            Try
                Me.artist.insertArtist()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.InfoListBox.Items.Add(Me.artist.name)
        End If
    End Sub

    Private Sub insertAlbum()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Me.album = New Album(NameTextBox.Text)
            Me.album.cover = InfoTextBox2.Text
            Dim artist = New Artist(SelectionComboBox.SelectedItem.ToString())
            Me.album.artist = artist
            Me.album.releaseDate = Date.Parse(DateBox.Value.ToShortDateString)
            Try
                Me.album.insertAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            InfoListBox.Items.Add(Me.album.name)
        End If
    End Sub

    Private Sub insertSong()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Me.song = New Song(NameTextBox.Text)
            Me.song.length = Integer.Parse(InfoTextBox2.Text)
            Dim album = New Album(SelectionComboBox.SelectedItem.ToString())
            Me.song.album = album
            Try
                Me.song.insertSong()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            InfoListBox.Items.Add(Me.song.sName)
        End If
    End Sub

    Private Sub readArtistInAlbum()
        Me.artist = New Artist
        Dim artistAux As Artist
        Try
            artist.readAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each artistAux In Me.artist.ArtistDAO.artists()
            Me.SelectionComboBox.Items.Add(artistAux.name.ToString)
        Next
    End Sub

    Private Sub readAlbumInSong()
        Me.album = New Album
        Dim albumAux As Album
        Try
            Me.album.readAllAlbums()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each albumAux In Me.album.AlbumDAO.albums()
            Me.SelectionComboBox.Items.Add(albumAux.name.ToString)
        Next
    End Sub

    Private Sub frmManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.myUser = frmMainMenu.user
    End Sub

    Private Sub updateUser()
        Dim userAux As User
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And
                InfoTextBox3.Text IsNot String.Empty Then
            userAux = New User(InfoTextBox3.Text)
            userAux.uName = NameTextBox.Text
            userAux.uSurname = InfoTextBox2.Text
            userAux.birthday = Date.Parse(DateBox.Value.ToShortDateString)
            Try
                userAux.updateUser()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub updateAlbum()
        If NameTextBox.Text IsNot String.Empty Then
            Me.album.name = NameTextBox.Text
            Me.album.cover = ImageFileDialog.FileName
            Dim artist = New Artist(SelectionComboBox.SelectedItem.ToString())
            Me.album.artist = artist
            Me.album.releaseDate = Date.Parse(DateBox.Value.ToShortDateString)
            Try
                Me.album.updateAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readAlbums()
            readArtistInAlbum()
        End If
    End Sub

    Private Sub updateArtist()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Me.artist.name = NameTextBox.Text
            Me.artist.country = InfoTextBox2.Text
            Me.artist.image = ImageFileDialog.FileName.ToString
            Try
                Me.artist.updateArtist()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ImageBox.ImageLocation = Me.artist.image
            resetElements()
            readArtists()
        End If
    End Sub

    Private Sub updateSong()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Me.song.sName = NameTextBox.Text
            Me.song.length = Integer.Parse(InfoTextBox2.Text)
            Try
                Me.song.updateSong()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readSongs()
            readAlbumInSong()
        End If
    End Sub

    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        If DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            ImageFileDialog.InitialDirectory = Application.StartupPath.ToString + "\ArtistsImages"

        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            ImageFileDialog.InitialDirectory = Application.StartupPath.ToString + "\AlbumsImages"
        End If
        ImageFileDialog.ShowDialog()
    End Sub

End Class