Public Class UserDAO
    Public ReadOnly Property usersByTime As Collection
    Public ReadOnly Property allUsers As Collection
    Public Sub New()
        usersByTime = New Collection
        allUsers = New Collection
    End Sub
    Public Sub readAll()

    End Sub
    Public Sub readAllByTime()

    End Sub
    Public Sub read(ByRef u As User, path As String)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM USERS WHERE Email='" & u.email & "';")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthday = aux(4).ToString

        Next
    End Sub
    Public Sub insert(u As User)
        DBBroker.GetBroker.Change("INSERT INTO USERS VALUES ('" & u.email & "', '" & u.uName & "','" & u.uSurname & "','" & u.birthday & "');")
    End Sub
    Public Sub update(u As User)
        DBBroker.GetBroker.Change("UPDATE USERS SET uName='" & u.uName & "'uSurname='" & u.uSurname & "'birthdate='" & u.birthday & "' WHERE Email='" & u.email & "';")
    End Sub
    Public Sub delete(u As User)
        DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.email & "';")
    End Sub
    Public Sub readMyArtists(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        Dim artist As Artist
        col = DBBroker.GetBroker().Read("SELECT artist FROM FAV_ARTISTS WHERE user='" & u.email & "';")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            artist = New Artist(Integer.Parse(aux(1).ToString))
            u.fav_artists.Add(artist)
        Next



    End Sub
    Public Sub usersSortedByTime()

    End Sub

    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)

    End Sub
    Public Sub playbackFavArtists(u As User)

    End Sub

End Class
