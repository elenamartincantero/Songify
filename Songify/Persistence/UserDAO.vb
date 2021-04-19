Public Class UserDAO
    Public ReadOnly Property usersByTime As Collection
    Public ReadOnly Property allUsers As Collection
    Public Sub New()
        usersByTime = New Collection
        allUsers = New Collection
    End Sub
    Public Sub connect(path As String)
        DBBroker.GetBroker(path)
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

    Public Sub read(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM USERS WHERE Email='" & u.email & "';")
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthday = CDate(aux(4).ToString)

        Next
    End Sub
    Public Sub insert(u As User)
        DBBroker.GetBroker.Change("INSERT INTO USERS VALUES ('" & u.email & "', '" & u.uName & "','" & u.uSurname & "', '" & u.birthday & "');")
    End Sub
    Public Sub update(u As User)
        DBBroker.GetBroker.Change("UPDATE USERS SET uName='" & u.uName & "',uSurname='" & u.uSurname & "',birthdate='" & u.birthday & "' WHERE Email='" & u.email & "';")
    End Sub
    Public Sub delete(u As User)
        DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.email & "';")
    End Sub
    Public Sub readMyArtists(ByRef u As User)
        Dim col1 As Collection : Dim aux1 As Collection
        Dim artist As Artist
        col1 = DBBroker.GetBroker().Read("SELECT aName FROM ARTISTS WHERE IdArtist In (Select artist FROM FAV_ARTISTS WHERE user='" & u.email & "');")
        If col1.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux1 In col1
            artist = New Artist(aux1(1).ToString)
            u.fav_artists.Add(artist, artist.name)
        Next
    End Sub
    Public Sub usersSortedByTime()
        Dim col As Collection : Dim aux As Collection
        Dim user As User
        col = DBBroker.GetBroker().Read("select p.user, sum(s.length) from playbacks p, songs s where p.song = s.IdSong group by p.user order by sum(s.length);")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            user = New User(aux(1).ToString)
            usersByTime.Add(user, aux(2).ToString)
        Next
    End Sub

    Public Function readArtistsMostListened(beginDate As Date, endDate As Date, user As User) As String
        Dim col As Collection : Dim aux As Collection
        Dim txt As String = ""
        col = DBBroker.GetBroker().Read("select aName from artists where IdArtist in ( select artist from albums where IdAlbum in (select album from songs where IdSong in (select song from playbacks where user like '" & user.email & "' and plDate between" & beginDate & "and" & endDate & ")));")
        For Each aux In col
            txt += aux(1).ToString + "\n"
        Next
        Return txt
    End Function
    Public Function playbackFavArtists(u As User) As String
        Dim col As Collection : Dim aux As Collection
        Dim txt As String = ""
        Dim i As Integer = 0, total = 0
        col = DBBroker.GetBroker().Read("select a.aName, sum(s.length) from artists a, songs s where (a.IdArtist in (select artist from fav_artists where user like '" & u.email & "')) and s.album in (select IdAlbum from Albums where artist = a.IdArtist) and s.IdSong in (select song from playbacks where user like '" & u.email & "') group by a.aName;")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            txt += aux(1).ToString + ": " + aux(2).ToString + "s\n"
        Next

        Return txt
    End Function
End Class