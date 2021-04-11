Public Class ArtistDAO
    Private Property artists As Collection
    Private Property artistsSortedCol As Collection

    Public Sub New()
        artists = New Collection
        artistsSortedCol = New Collection
    End Sub
    Public Sub readAll()

    End Sub
    Public Sub read(ByRef a As Artist)

    End Sub
    Public Sub insert(a As Artist)
        DBBroker.GetBroker.Change("INSERT INTO ARTISTS VALUES ('" & a.name & "', '" & a.country & "','" & a.image & "');")
    End Sub
    Public Sub update(a As Artist)

    End Sub
    Public Sub delete(a As Artist)

    End Sub
    Public Sub readMyAlbums(ByRef a As Artist)

    End Sub
    Public Sub fav(us As User, a As Artist)

    End Sub
    Public Sub not_fav(us As User, a As Artist)

    End Sub

    Public Sub artistsSorted(ar As Artist)

    End Sub
End Class
