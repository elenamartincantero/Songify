Public Class frmSearch
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User
    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        readAlbum()
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
            Me.List.Items.Add(artistAux.name)
        Next
    End Sub
    Private Sub readAlbum()
        Dim albumAux As Album = New Album()
        Me.album = New Album
        Try
            album.readbyArtist(Me.List.SelectedItem.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each albumAux In Me.album.AlbumDAO.albums
            Me.List.Items.Add(albumAux.name)
        Next
    End Sub


    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        readArtists()
    End Sub
End Class
