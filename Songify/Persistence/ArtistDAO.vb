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
        col = DBBroker.GetBroker().Read("SELECT aName FROM ARTISTS")
        For Each aux In col
            artist = New Artist(aux(1).ToString)
            Me.artists.Add(artist)
        Next
    End Sub
    Public Sub read(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM ARTISTS WHERE aName='" & a.name & "';")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            a.id = Integer.Parse(aux(1).ToString)
            a.country = aux(3).ToString
            a.image = aux(4).ToString

        Next
    End Sub
    Public Sub insert(a As Artist)
        DBBroker.GetBroker.Change("INSERT INTO ARTISTS VALUES ('" & a.name & "', '" & a.country & "','" & a.image & "');")
    End Sub
    Public Sub update(a As Artist)
        DBBroker.GetBroker.Change("UPDATE ARTISTS SET aName='" & a.name & "',country='" & a.country & "',image=" & a.image & " WHERE IdArtist='" & a.id & "';")
    End Sub
    Public Sub delete(a As Artist)
        DBBroker.GetBroker.Change("DELETE FROM ARTISTS WHERE aName='" & a.name & "';")
    End Sub
    Public Sub readMyAlbums(ByRef a As Artist)
        Dim col As Collection : Dim aux As Collection
        Dim album As Album
        col = DBBroker.GetBroker().Read("SELECT aName FROM ALBUMS WHERE artist=" & a.id & ";")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            album = New Album(aux(1).ToString)
            a.albums.Add(album)
        Next
    End Sub
    Public Sub fav(us As User, a As Artist)
        DBBroker.GetBroker.Change("INSERT INTO FAV_ARTISTS VALUES ('" & us.email & "', " & a.id & "," & Date.Today & ");")
    End Sub
    Public Sub not_fav(us As User, a As Artist)
        DBBroker.GetBroker.Change("DELETE FROM PLAYABACKS WHERE user='" & us.email & "', artist=" & a.id & ");")
    End Sub

    Public Sub artistsSorted(ar As Artist)

    End Sub
End Class
