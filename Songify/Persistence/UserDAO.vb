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
        If col.Count = 0 Then
            Throw New Exception()
        End If
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
                u.fav_artists.Add(artist, artist.name)
            Next
        Next
    End Sub
    Public Sub usersSortedByTime()
        Dim col1 As Collection : Dim aux1 As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        Dim song As Song = Nothing
        Dim user As User = Nothing
        Dim i As Integer = 0, total = 0
        col1 = DBBroker.GetBroker().Read("SELECT user, song FROM PLAYBACKS;")
        If col1.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux1 In col1
            i += 1
            If i = 1 Then
                user = New User(aux1(1).ToString)
            End If
            col2 = DBBroker.GetBroker().Read("SELECT sName FROM SONGS WHERE IdSong=" & aux1(2).ToString & ";")
            For Each aux2 In col2
                song = New Song(aux2(1).ToString)
                song.readSong()
                If user.email.Equals(aux1(1).ToString) Then
                    total += song.length
                Else
                    If total = 0 Then
                        Me.usersByTime.Add(user, song.length.ToString)
                    Else
                        Me.usersByTime.Add(user, total.ToString)
                    End If
                    total = 0
                    user = New User(aux1(1).ToString)
                End If
            Next
        Next
        If usersByTime.Count < col1.Count Then
            Me.usersByTime.Add(user, song.length.ToString)
        End If
        'FALTA ORDENARLOS


    End Sub

    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)

    End Sub
    Public Function playbackFavArtists(u As User) As String
        Dim col1 As Collection : Dim aux1 As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        Dim song As Song = Nothing
        Dim txt As String = ""
        Dim artist As Artist = Nothing
        Dim i As Integer = 0, total = 0
        col1 = DBBroker.GetBroker().Read("SELECT song FROM PLAYBACKS WHERE user='" & u.email & "';")
        If col1.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux1 In col1
            i += 1
            col2 = DBBroker.GetBroker().Read("SELECT sName FROM SONGS WHERE IdSong=" & aux1(1).ToString & ";")
            For Each aux2 In col2
                song = New Song(aux2(1).ToString)
                song.readSong()
                song.album.readAlbum()
                If i = 1 Then
                    artist = song.album.artist
                End If

                If u.fav_artists.Contains(song.album.artist.name) Then
                    If song.album.artist.Equals(artist) Then
                        total += song.length
                    Else
                        txt += song.album.artist.name + ": " + total.ToString + "s"
                        total = 0
                        artist = song.album.artist
                    End If
                End If

            Next

        Next
        txt += song.album.artist.name + ": " + total.ToString + "s"
        Return txt
    End Function
End Class