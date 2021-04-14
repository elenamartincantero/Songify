Public Class frmManage

    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User


    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = String.Empty
        InfoTextBox2.Text = String.Empty
        InfoTextBox3.Text = String.Empty
        InfoTextBox4.Text = String.Empty
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
            clearTextBoxes()
            InfoListBox.Items.Clear()
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
            clearTextBoxes()
            InfoListBox.Items.Clear()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Country"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Image path"
            readArtists()

        ElseIf DataTypeComboBox.SelectedItem.ToString() = "Albums" Then
            clearTextBoxes()
            InfoListBox.Items.Clear()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Cover path"
            DateBox.Visible = True
            DateLabel.Visible = True
            DateLabel.Text = "Release date"
            SelectionComboBox.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Artist"
            readAlbums()

        ElseIf DataTypeComboBox.SelectedItem.ToString() = "Songs" Then
            clearTextBoxes()
            InfoListBox.Items.Clear()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Belonging album"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Length"
            readSongs()
        End If

    End Sub

    Private Sub clearTextBoxes()
        NameTextBox.Text = String.Empty
        InfoTextBox2.Text = String.Empty
        InfoTextBox3.Text = String.Empty
    End Sub

    Private Sub invisibleElements()
        NameTextBox.Visible = False
        NameLabel.Visible = False
        InfoTextBox2.Visible = False
        InfoLabel2.Visible = False
        InfoTextBox3.Visible = False
        InfoLabel3.Visible = False
        DateBox.Visible = False
        SelectionComboBox.Visible = False
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
    End Sub

    Private Sub listAlbum()
        Me.album = New Album(InfoListBox.SelectedItem.ToString) 'name
        Try
            Me.album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        readArtistInAlbum(Me.album)
        NameTextBox.Text = Me.album.name
        DateBox.Value = Me.album.releaseDate
        ImageBox.ImageLocation = Me.album.cover

    End Sub

    Private Sub listSong()
        Me.song = New Song(InfoListBox.SelectedItem.ToString)
        Try
            Me.song.readSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Text = Me.song.sName
        InfoTextBox2.Text = Me.song.album.ToString
        InfoTextBox3.Text = Me.song.length.ToString
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        If DataTypeComboBox.SelectedItem.ToString = "Users" Then
            insertUser()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            insertArtist()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            insertAlbum()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Songs" Then
            'insertSong()
        End If


    End Sub


    Private Sub insertUser()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And
                InfoTextBox3.Text IsNot String.Empty Then
            Me.user = New User(InfoTextBox3.Text)
            Me.user.uName = NameTextBox.Text
            Me.user.uSurname = InfoTextBox2.Text
            Me.user.birthday = DateBox.Value
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
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And
                InfoTextBox3.Text IsNot String.Empty Then
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
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And
                InfoTextBox3.Text IsNot String.Empty And InfoTextBox4.Text IsNot String.Empty Then
            Me.user = New User(InfoTextBox3.Text)
            Me.user.uName = NameTextBox.Text
            Me.user.uSurname = InfoTextBox2.Text
            Me.user.birthday = DateBox.Value
            Try
                Me.user.insertUser()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            InfoListBox.Items.Add(Me.user.email)
        End If
    End Sub

    Private Sub readArtistInAlbum(album As Album)
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
        SelectionComboBox.SelectedItem = album.artist.name.ToString
    End Sub

End Class