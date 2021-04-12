Public Class UserDAO
    Public ReadOnly Property usersByTime As Collection
    Public ReadOnly Property allUsers As Collection
    Public Sub New()
        usersByTime = New Collection
        allUsers = New Collection
    End Sub
    Public Sub readAll()
        Dim user As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT Email FROM USERS")
        For Each aux In col
            user = New User(aux(1).ToString)
            Me.allUsers.Add(user)
        Next
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
            u.birthday = CDate(aux(4).ToString)

        Next
    End Sub
    Public Sub read(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM USERS WHERE Email='" & u.email & "';")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthday = Date.Parse(aux(4).ToString)

        Next
    End Sub
    Public Sub insert(u As User)
        DBBroker.GetBroker.Change("INSERT INTO USERS VALUES ('" & u.email & "', '" & u.uName & "','" & u.uSurname & "'," & u.birthday & ");")
    End Sub
    Public Sub update(u As User)
        DBBroker.GetBroker.Change("UPDATE USERS SET uName='" & u.uName & "',uSurname='" & u.uSurname & "',birthdate=" & u.birthday & " WHERE Email='" & u.email & "';")
    End Sub
    Public Sub delete(u As User)
        DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.email & "';")
    End Sub
    Public Sub readMyArtists(ByRef u As User)
        Dim col1 As Collection : Dim aux1 As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        Dim artist As Artist
        col1 = DBBroker.GetBroker().Read("SELECT artist FROM FAV_ARTISTS WHERE user='" & u.email & "';")
        If col1.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux1 In col1
            col2 = DBBroker.GetBroker().Read("SELECT aName FROM ARTISTS WHERE IdArtist=" & aux1(1).ToString & ";")
            For Each aux2 In col2
                artist = New Artist(aux2(1).ToString)
                u.fav_artists.Add(artist)
            Next
        Next
    End Sub
    Public Sub usersSortedByTime()

    End Sub

    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)

    End Sub
    Public Sub playbackFavArtists(u As User)

    End Sub
    Public Sub readAllByTime()

    End Sub
End Class