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
            If TypeComboBox.SelectedItem.ToString() = "Users" Then
                listUsers()
            ElseIf TypeComboBox.SelectedItem.ToString() = "Artists" Then
                listArtists()
            ElseIf TypeComboBox.SelectedItem.ToString() = "Albums" Then
                listAlbums()
            ElseIf TypeComboBox.SelectedItem.ToString() = "Songs" Then
                listSongs()
            End If
        End If
    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged
        If TypeComboBox.SelectedItem IsNot Nothing Then
            invisibleElements()
            InsertButton.Enabled = True
        End If
        If TypeComboBox.SelectedItem.ToString() = "Users" Then
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
            InfoTextBox4.Visible = True
            InfoLabel4.Visible = True
            InfoLabel4.Text = "Birthdate"
            readUsers()

        ElseIf TypeComboBox.SelectedItem.ToString() = "Artists" Then
            clearTextBoxes()
            InfoListBox.Items.Clear()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Country"
            readArtists()

        ElseIf TypeComboBox.SelectedItem.ToString() = "Albums" Then
            clearTextBoxes()
            InfoListBox.Items.Clear()
            invisibleElements()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Release date"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Total length"
            readAlbums()

        ElseIf TypeComboBox.SelectedItem.ToString() = "Songs" Then
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
        InfoTextBox4.Text = String.Empty
    End Sub

    Private Sub invisibleElements()
        NameTextBox.Visible = False
        NameLabel.Visible = False
        InfoTextBox2.Visible = False
        InfoLabel2.Visible = False
        InfoTextBox3.Visible = False
        InfoLabel3.Visible = False
        InfoTextBox4.Visible = False
        InfoLabel4.Visible = False
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

    Private Sub listUsers()
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
        InfoTextBox4.Text = Me.user.birthday.ToString()
    End Sub

    Private Sub listArtists()
        Me.artist = New Artist(InfoListBox.SelectedItem.ToString)  'name
        Try
            Me.artist.readArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Text = Me.artist.name
        InfoTextBox2.Text = Me.artist.country

        ArtistImage.ImageLocation = Me.artist.image
    End Sub

    Private Sub listAlbums()
        Me.album = New Album(InfoListBox.SelectedItem.ToString) 'name
        Try
            Me.album.readAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        NameTextBox.Text = Me.album.name
        InfoTextBox2.Text = Me.album.releaseDate.ToString
        InfoTextBox3.Text = Me.album.convertLength()
    End Sub

    Private Sub listSongs()
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
        If TypeComboBox.SelectedItem.ToString = "Users" Then
            If NameTextBox.Text IsNot String.Empty And InfoTextBox2.Text IsNot String.Empty And
                InfoTextBox3.Text IsNot String.Empty And InfoTextBox4.Text IsNot String.Empty Then
                Me.user = New User(InfoTextBox3.Text)
                Me.user.uName = NameTextBox.Text
                Me.user.uSurname = InfoTextBox2.Text
                Me.user.birthday = Date.Parse(InfoTextBox4.Text)
                Try
                    Me.user.insertUser()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                InfoListBox.Items.Add(Me.user.email)
            End If
        End If

    End Sub
End Class