Public Class frmManage
    Public Property myUser As User
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
        InfoTextBox3.Enabled = True
        SelectionComboBox.Text = String.Empty
        DateBox.ResetText()
        ImageBox.ImageLocation = String.Empty
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InfoListBox.SelectedIndexChanged
        If InfoListBox.SelectedItem IsNot Nothing Then
            ClearButton.Enabled = True
            DeleteButton.Enabled = True
            UpdateButton.Enabled = True
            If DataTypeComboBox.SelectedItem.ToString() = "Users" Then
                listUser()
            ElseIf DataTypeComboBox.SelectedItem.ToString() = "Artists" Then
                ImageButton.Visible = True
                ImageButton.Text = "Change image"
                listArtist()
            ElseIf DataTypeComboBox.SelectedItem.ToString() = "Albums" Then
                ImageButton.Visible = True
                ImageButton.Text = "Change cover"
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
        ImageBox.ImageLocation = String.Empty
        ClearButton.Enabled = False
        UpdateButton.Enabled = False
        DeleteButton.Enabled = False
        DateBox.ResetText()
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
        For Each artistAux In Me.artist.ArtistDAO.allArtists
            Me.InfoListBox.Items.Add(artistAux.aName)
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
        For Each albumAux In Me.album.AlbumDAO.allAlbums
            Me.InfoListBox.Items.Add(albumAux.aName)
        Next
    End Sub

    Private Sub listUser()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Me.user = New User(InfoListBox.SelectedItem.ToString) 'email
            Try
                Me.user.readUser()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            InfoTextBox3.Enabled = False
            NameTextBox.Text = Me.user.uName
            InfoTextBox2.Text = Me.user.uSurname
            InfoTextBox3.Text = Me.user.email
            DateBox.Value = Me.user.birthday
        End If

    End Sub

    Private Sub listArtist()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Dim artistAux As Artist = CType(Me.artist.ArtistDAO.allArtists(InfoListBox.SelectedIndex + 1), Artist)
            Try
                artistAux.readArtist()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            NameTextBox.Text = artistAux.aName
            InfoTextBox2.Text = artistAux.aCountry
            InfoTextBox3.Text = artistAux.aImage
            ImageBox.ImageLocation = artistAux.aImage
            ImageBox.Visible = True
        End If

    End Sub

    Private Sub listAlbum()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Dim albumAux As Album = CType(Me.album.AlbumDAO.allAlbums(InfoListBox.SelectedIndex + 1), Album)
            Try
                albumAux.readAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            NameTextBox.Text = albumAux.aName
            InfoTextBox2.Text = albumAux.aCover
            DateBox.Value = albumAux.aReleaseDate
            ImageBox.ImageLocation = albumAux.aCover
            ImageBox.Visible = True
            SelectionComboBox.SelectedItem = albumAux.aArtist.aName.ToString
        End If


    End Sub

    Private Sub listSong()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Dim songAux As Song = CType(Me.song.SongDAO.allSongs(InfoListBox.SelectedIndex + 1), Song)

            Try
                songAux.readSong()
                songAux.sAlbum.readAlbum()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            NameTextBox.Text = songAux.sName
            InfoTextBox2.Text = songAux.sLength.ToString
            SelectionComboBox.SelectedItem = songAux.sAlbum.aName
        End If

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
            DeleteUser()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            DeleteArtist()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            DeleteAlbum()
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Songs" Then
            DeleteSong()
        End If
    End Sub

    Private Sub DeleteSong()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Dim songAux As Song = CType(Me.song.SongDAO.allSongs(InfoListBox.SelectedIndex + 1), Song)
            Try
                If songAux.deleteSong() <> 1 Then
                    MessageBox.Show("DELETE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readSongs()
            readAlbumInSong()
        End If
    End Sub

    Private Sub DeleteAlbum()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Dim albumAux As Album = CType(Me.album.AlbumDAO.allAlbums(InfoListBox.SelectedIndex + 1), Album)
            Try
                If albumAux.deleteAlbum() <> 1 Then
                    MessageBox.Show("DELETE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readAlbums()
            readArtistInAlbum()
        End If
    End Sub

    Private Sub DeleteArtist()
        If InfoListBox.SelectedItem IsNot Nothing Then
            Dim artistAux As Artist = CType(Me.artist.ArtistDAO.allArtists(InfoListBox.SelectedIndex + 1), Artist)
            Try
                If artistAux.deleteArtist() <> 1 Then
                    MessageBox.Show("DELETE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readArtists()

        End If
    End Sub

    Private Sub DeleteUser()

        If InfoListBox.SelectedItem IsNot Nothing Then
            If user.email = myUser.email Then
                MessageBox.Show("You cannot delete yourself", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    If Me.user.deleteUser() <> 1 Then
                        MessageBox.Show("DELETE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                InfoListBox.Items.Remove(InfoListBox.SelectedItem.ToString)
                NameTextBox.Text = String.Empty
                InfoTextBox2.Text = String.Empty
                InfoTextBox3.Text = String.Empty
                InfoTextBox3.Enabled = True
                DateBox.ResetText()
            End If

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
                If Me.user.insertUser() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.InfoListBox.Items.Add(Me.user.email)
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub insertArtist()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Dim artistAux As Artist = New Artist(NameTextBox.Text)
            artistAux.aCountry = InfoTextBox2.Text
            artistAux.aImage = ImageFileDialog.FileName
            Try
                If artistAux.insertArtist() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readArtists()
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub insertAlbum()
        If NameTextBox.Text IsNot String.Empty And SelectionComboBox.SelectedItem IsNot Nothing Then
            Dim albumAux As Album = New Album(NameTextBox.Text)
            albumAux.aCover = ImageFileDialog.FileName
            Dim artist As Artist = CType(Me.artist.ArtistDAO.allArtists(SelectionComboBox.SelectedIndex + 1), Artist)
            albumAux.aArtist = artist
            albumAux.aReleaseDate = Date.Parse(DateBox.Value.ToShortDateString)
            Try
                If albumAux.insertAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readAlbums()
            readArtistInAlbum()
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub insertSong()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And SelectionComboBox.SelectedItem IsNot Nothing Then
            Dim songAux As Song = New Song(NameTextBox.Text)
            songAux.sLength = Integer.Parse(InfoTextBox2.Text)
            Dim album As Album = CType(Me.album.AlbumDAO.allAlbums(SelectionComboBox.SelectedIndex + 1), Album)
            songAux.sAlbum = album
            Try
                If songAux.insertSong() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readSongs()
            readAlbumInSong()
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        For Each artistAux In Me.artist.ArtistDAO.allArtists()
            Me.SelectionComboBox.Items.Add(artistAux.aName.ToString)
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
        For Each albumAux In Me.album.AlbumDAO.allAlbums()
            Me.SelectionComboBox.Items.Add(albumAux.aName.ToString)
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
                If userAux.updateUser() <> 1 Then
                    MessageBox.Show("UPDATE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub updateAlbum()
        If NameTextBox.Text IsNot String.Empty And SelectionComboBox.SelectedItem IsNot Nothing Then
            Dim albumAux As Album = CType(Me.album.AlbumDAO.allAlbums(InfoListBox.SelectedIndex + 1), Album)
            albumAux.aName = NameTextBox.Text
            albumAux.aCover = ImageFileDialog.FileName
            Dim artist As Artist = CType(Me.artist.ArtistDAO.allArtists(SelectionComboBox.SelectedIndex + 1), Artist)
            albumAux.aArtist = artist
            albumAux.aReleaseDate = Date.Parse(DateBox.Value.ToShortDateString)
            Try
                If albumAux.updateAlbum() <> 1 Then
                    MessageBox.Show("UPDATE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readAlbums()
            readArtistInAlbum()
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub updateArtist()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty Then
            Dim artistAux As Artist = CType(Me.artist.ArtistDAO.allArtists(InfoListBox.SelectedIndex + 1), Artist)
            artistAux.aName = NameTextBox.Text
            artistAux.aCountry = InfoTextBox2.Text
            artistAux.aImage = ImageFileDialog.FileName.ToString
            Try
                If artistAux.updateArtist() <> 1 Then
                    MessageBox.Show("UPDATE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ImageBox.ImageLocation = artistAux.aImage
            resetElements()
            readArtists()
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub updateSong()
        If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And SelectionComboBox.SelectedItem IsNot Nothing Then
            Dim songAux As Song = CType(Me.song.SongDAO.allSongs(InfoListBox.SelectedIndex + 1), Song)
            songAux.sName = NameTextBox.Text
            songAux.sLength = Integer.Parse(InfoTextBox2.Text)
            Dim album As Album = CType(Me.album.AlbumDAO.allAlbums(SelectionComboBox.SelectedIndex + 1), Album)
            songAux.sAlbum = album
            Try
                If songAux.updateSong() <> 1 Then
                    MessageBox.Show("UPDATE <> 1", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            resetElements()
            readSongs()
            readAlbumInSong()
        Else
            MessageBox.Show("Please introduce all the values", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        If DataTypeComboBox.SelectedItem.ToString = "Artists" Then
            ImageFileDialog.InitialDirectory = Application.StartupPath.ToString + "\ArtistsImages"
        ElseIf DataTypeComboBox.SelectedItem.ToString = "Albums" Then
            ImageFileDialog.InitialDirectory = Application.StartupPath.ToString + "\AlbumsImages"
        End If
        ImageFileDialog.ShowDialog()
        ImageBox.ImageLocation = ImageFileDialog.FileName
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, InfoTextBox2.TextChanged, InfoTextBox3.TextChanged
        ClearButton.Enabled = True
    End Sub

    Private Sub ChangeUserButton_Click(sender As Object, e As EventArgs) Handles ChangeUserButton.Click
        If MessageBox.Show("Are you sure you want to change user?", "Change user", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmLogin.Show()
            frmLogin.user = Me.user
            frmLogin.LoginButton.Enabled = True
            frmLogin.ConnectButton.Enabled = False
            frmLogin.LoginBox.Enabled = True
            Me.Close()
        End If
    End Sub

End Class