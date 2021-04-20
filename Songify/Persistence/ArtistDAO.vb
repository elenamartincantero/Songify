Public Class ArtistDAO
    Public ReadOnly Property artists As Collection
    Public ReadOnly Property artistsSortedCol As Collection

    Public Sub New()
        artists = New Collection
        artistsSortedCol = New Collection
    End Sub
    Public Sub readAll()
        Dim artist As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT IdArtist, aName FROM ARTISTS")
        For Each aux In col
            artist = New Artist(Integer.Parse(aux(1).ToString), aux(2).ToString)
            Me.artists.Add(artist)
        Next
    End Sub
    Public Sub read(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM ARTISTS WHERE IdArtist=" & a.id & ";")

        For Each aux In col
            a.country = aux(3).ToString
            a.image = aux(4).ToString

        Next
    End Sub
    Public Function insert(a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO ARTISTS (aName, country, [image]) VALUES ('" & a.name & "', '" & a.country & "', '" & a.image & "');")
    End Function
    Public Function update(a As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE ARTISTS SET aName='" & a.name & "',country='" & a.country & "',[image]='" & a.image & "' WHERE IdArtist=" & a.id & ";")
    End Function
    Public Function delete(a As Artist) As Integer
        Dim albumAux As Album
        For Each albumAux In a.albums
            albumAux.deleteAlbum()
        Next
        DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE artist=" & a.id & ";")
        Return DBBroker.GetBroker.Change("DELETE FROM ARTISTS WHERE IdArtist=" & a.id & ";")
    End Function
    Public Sub readMyAlbums(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        Dim album As Album
        col = DBBroker.GetBroker().Read("SELECT aName FROM ALBUMS WHERE artist=" & a.id & ";")

        For Each aux In col
            album = New Album()
            album.readAlbum()
            a.albums.Add(album)
        Next
    End Sub
    Public Function fav(us As User, a As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO FAV_ARTISTS VALUES ('" & us.email & "', " & a.id & "," & Date.Today & ");")
    End Function
    Public Function not_fav(us As User, a As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE user='" & us.email & "'AND artist=" & a.id & ";")
    End Function

    Public Sub artistsSorted(ar As Artist)

    End Sub
End Class
