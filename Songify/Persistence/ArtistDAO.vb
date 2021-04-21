Public Class ArtistDAO
    Public ReadOnly Property allArtists As Collection
    Public ReadOnly Property artistsSortedCol As Collection

    Public Sub New()
        allArtists = New Collection
        artistsSortedCol = New Collection
    End Sub
    Public Sub readAll()
        Dim artist As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT IdArtist, aName FROM ARTISTS")
        For Each aux In col
            artist = New Artist(Integer.Parse(aux(1).ToString), aux(2).ToString)
            Me.allArtists.Add(artist)
        Next
    End Sub
    Public Sub read(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM ARTISTS WHERE IdArtist=" & a.idArtist & ";")

        For Each aux In col
            a.aCountry = aux(3).ToString
            a.aImage = aux(4).ToString

        Next
    End Sub
    Public Function insert(a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO ARTISTS (aName, country, [image]) VALUES ('" & a.aName & "', '" & a.aCountry & "', '" & a.aImage & "');")
    End Function
    Public Function update(a As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE ARTISTS SET aName='" & a.aName & "',country='" & a.aCountry & "',[image]='" & a.aImage & "' WHERE IdArtist=" & a.idArtist & ";")
    End Function
    Public Function delete(a As Artist) As Integer
        Dim albumAux As Album
        For Each albumAux In a.aAlbums
            albumAux.deleteAlbum()
        Next
        DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE artist=" & a.idArtist & ";")
        Return DBBroker.GetBroker.Change("DELETE FROM ARTISTS WHERE IdArtist=" & a.idArtist & ";")
    End Function
    Public Sub readMyAlbums(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        Dim album As Album
        col = DBBroker.GetBroker().Read("SELECT IdAlbum, aName FROM ALBUMS WHERE artist=" & a.idArtist & ";")

        For Each aux In col
            album = New Album(Integer.Parse(aux(1).ToString), aux(2).ToString)
            album.readAlbum()
            a.aAlbums.Add(album)
        Next
    End Sub
    Public Function fav(us As User, a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO FAV_ARTISTS VALUES ('" & us.email & "', " & a.idArtist & ",'" & Date.Today & "');")
    End Function
    Public Function not_fav(us As User, a As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE user='" & us.email & "'AND artist=" & a.idArtist & ";")
    End Function

    Public Sub artistsSorted(ar As Artist)

    End Sub
End Class
