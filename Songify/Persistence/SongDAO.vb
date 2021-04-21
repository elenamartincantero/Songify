Public Class SongDAO
    Public ReadOnly Property sortedSongs As Collection
    Public ReadOnly Property allSongs As Collection

    Public Sub New()
        sortedSongs = New Collection
        allSongs = New Collection
    End Sub
    Public Sub readAll()
        Dim song As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT IdSong, sName FROM SONGS")
        For Each aux In col
            song = New Song(Integer.Parse(aux(1).ToString), aux(2).ToString)
            Me.allSongs.Add(song)
        Next
    End Sub
    Public Sub read(ByRef s As Song)
        Dim col1 As Collection : Dim aux1 As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        col1 = DBBroker.GetBroker().Read("SELECT * FROM SONGS WHERE IdSong=" & s.idSong & ";")

        For Each aux1 In col1
            s.idSong = Integer.Parse(aux1(1).ToString)
            s.sLength = Integer.Parse(aux1(4).ToString)
            col2 = DBBroker.GetBroker().Read("SELECT IdAlbum, aName FROM ALBUMS WHERE IdAlbum=" & aux1(3).ToString & ";")
            For Each aux2 In col2
                s.sAlbum = New Album(Integer.Parse(aux2(1).ToString), aux2(2).ToString)
            Next

        Next
    End Sub
    Public Function insert(s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO SONGS (sName, Album, length) VALUES ('" & s.sName & "', " & s.sAlbum.idAlbum & "," & s.sLength & ");")
    End Function
    Public Function update(s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE SONGS SET sName='" & s.sName & "',Album=" & s.sAlbum.idAlbum & ",length=" & s.sLength & " WHERE IdSong=" & s.idSong & ";")
    End Function
    Public Function delete(s As Song) As Integer
        DBBroker.GetBroker.Change("DELETE FROM PLAYBACKS WHERE song=" & s.idSong & ";")
        Return DBBroker.GetBroker.Change("DELETE FROM SONGS WHERE IdSong=" & s.idSong & ";")
    End Function
    Public Function convertLength(s As Song) As String
        Dim seg As Integer
        Dim min As Double
        seg = s.sLength Mod 60
        min = Integer.Parse(((s.sLength - seg) / 60).ToString)

        Return min.ToString() & ":" & seg.ToString()
    End Function
    Public Function play(us As User, s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO PLAYBACKS ([user], song, [plDate]) VALUES ('" & us.email & "', " & s.idSong & ", '" & Date.Today & "');")
    End Function
    Public Function readPlayblacks(s As Song) As String
        Dim col1 As Collection : Dim aux1 As Collection
        Dim txt As String = ""
        col1 = DBBroker.GetBroker().Read("SELECT * FROM PLAYBACKS WHERE song=" & s.idSong & ";")

        For Each aux1 In col1
            txt += aux1(2).ToString + " played it on " + aux1(4).ToString + vbCrLf
        Next
        Return txt
    End Function
    Public Sub songsSorted()

    End Sub
End Class
