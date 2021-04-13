Public Class AlbumDAO
    Public ReadOnly Property albums As Collection
    Public Sub New()
        albums = New Collection
    End Sub
    Public Sub readAll()
        Dim album As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT aName FROM ALBUMS")
        For Each aux In col
            album = New Album(aux(1).ToString)
            Me.albums.Add(album)
        Next
    End Sub
    Public Sub read(ByRef a As Album)
        Dim col1 As Collection : Dim aux1 As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        col1 = DBBroker.GetBroker().Read("SELECT * FROM ALBUMS WHERE aName='" & a.name & "';")
        If col1.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux1 In col1
            a.albumID = Integer.Parse(aux1(1).ToString)
            a.releaseDate = Date.Parse(aux1(3).ToString)
            a.cover = aux1(5).ToString
            col2 = DBBroker.GetBroker().Read("SELECT aName FROM ARTISTS WHERE IdArtist=" & aux1(4).ToString & ";")
            For Each aux2 In col2
                a.artist = New Artist(aux2(1).ToString)
            Next

        Next
    End Sub
    Public Sub readbyArtist(name As String, ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        Dim col1 As Collection : Dim aux1 As Collection
        Dim artist As Artist
        Dim album As Album
        col = DBBroker.GetBroker().Read("SELECT aName FROM ARTISTs WHERE aName=" & name & ";")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            artist = New Artist(aux(1).ToString)
            col1 = DBBroker.GetBroker().Read("SELECT aName FROM ALBUMS WHERE artist=" & artist.id & ";")
            For Each aux1 In col1
                album = New Album(aux1(1).ToString)
                a.AlbumDAO.albums.Add(album)
            Next
        Next
     End Sub
    Public Sub insert(a As Album)
        DBBroker.GetBroker.Change("INSERT INTO ALBUMS VALUES ('" & a.name & "', " & a.releaseDate & "," & a.artist.id & ",'" & a.cover & ");")
    End Sub
    Public Sub update(a As Album)
        DBBroker.GetBroker.Change("UPDATE ALBUMS SET aName='" & a.name & "',releaseDate=" & a.releaseDate & ",artist=" & a.artist.id & ",cover=" & a.cover & "WHERE IdAlbum=" & a.albumID & ";")
    End Sub
    Public Sub delete(a As Album)
        DBBroker.GetBroker.Change("DELETE FROM ALBUMS WHERE aName='" & a.name & "';")
    End Sub
    Public Sub readMySongs(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        Dim song As Song
        col = DBBroker.GetBroker().Read("SELECT sName FROM SONGS WHERE Album=" & a.albumID & ";")
        If col.Count = 0 Then
            Throw New Exception()
        End If
        For Each aux In col
            song = New Song(aux(1).ToString)
            song.readSong()
            a.songs.Add(song)
        Next
    End Sub
    Public Function convertLength(a As Album) As String
        Dim seg As Integer
        Dim min As Double

        seg = a.length Mod 60
        min = Integer.Parse(((a.length - seg) / 60).ToString)

        Return min.ToString() & ":" & seg.ToString()
    End Function
    Public Sub calculateTotalLength(ByRef a As Album)
        Dim song As Song
        For Each song In a.songs
            a.length += song.length
        Next
    End Sub
End Class
