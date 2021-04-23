Public Class UserDAO
    Public ReadOnly Property usersByTime As Collection
    Public ReadOnly Property artistsMostListened As Collection
    Public ReadOnly Property allUsers As Collection
    Public ReadOnly Property playbacksFav As Collection
    Public Sub New()
        usersByTime = New Collection
        artistsMostListened = New Collection
        allUsers = New Collection
        playbacksFav = New Collection
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
    Public Function insert(u As User) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO USERS VALUES ('" & u.email & "', '" & u.uName & "','" & u.uSurname & "', '" & u.birthday & "');")
    End Function
    Public Function update(u As User) As Integer
        Return DBBroker.GetBroker.Change("UPDATE USERS SET uName='" & u.uName & "',uSurname='" & u.uSurname & "',birthdate='" & u.birthday & "' WHERE Email='" & u.email & "';")
    End Function
    Public Function delete(u As User) As Integer
        DBBroker.GetBroker.Change("DELETE FROM PLAYBACKS WHERE user='" & u.email & "';")
        DBBroker.GetBroker.Change("DELETE FROM FAV_ARTISTS WHERE user='" & u.email & "';")
        Return DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.email & "';")
    End Function
    Public Sub readMyArtists(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        Dim artist As Artist
        col = DBBroker.GetBroker().Read("SELECT IdArtist, aName FROM ARTISTS WHERE IdArtist In (Select artist FROM FAV_ARTISTS WHERE user='" & u.email & "');")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            artist = New Artist(Integer.Parse(aux(1).ToString), aux(2).ToString)
            artist.readArtist()
            u.fav_artists.Add(artist, aux(1).ToString)
        Next
    End Sub
    Public Sub usersSortedByTime()
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("select p.user, sum(s.length) from playbacks p, songs s where p.song = s.IdSong group by p.user order by sum(s.length);")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            usersByTime.Add(aux(1).ToString + ": " + aux(2).ToString + " seconds")
        Next
    End Sub

    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("select a.[aName] from artists a, playbacks p, songs s, albums al where p.[plDate] between #" & beginDate & "# and #" & endDate & "# and p.song = s.IdSong and s.album = al.IdAlbum and al.artist = a.IdArtist and [user]='" & user.email & "' group by a.[aName] order by count(a.idartist) desc;")
        For Each aux In col
            artistsMostListened.Add(aux(1).ToString)
        Next
    End Sub
    Public Sub playbackFavArtists(u As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker().Read("select a.aName, sum(s.length) from artists a, songs s, albums al, playbacks p where (a.IdArtist in (select artist from fav_artists where user like '" & u.email & "')) and s.IdSong = p.song and s.album = al.IdAlbum and al.artist = a.IdArtist group by a.aName;")
        For Each aux In col
            playbacksFav.Add(aux(1).ToString & ": " & aux(2).ToString & " seconds")
        Next
    End Sub
End Class