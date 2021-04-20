Public Class AlbumDAO
    Public ReadOnly Property albums As Collection
    Public Sub New()
        albums = New Collection
    End Sub
    Public Sub readAll()
        Dim album As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT IdAlbum, aName FROM ALBUMS")
        For Each aux In col
            album = New Album(Integer.Parse(aux(1).ToString), aux(2).ToString)
            Me.albums.Add(album)
        Next
    End Sub
    Public Sub read(ByRef a As Album)
        Dim col1 As Collection : Dim aux1 As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        col1 = DBBroker.GetBroker().Read("SELECT * FROM ALBUMS WHERE IdAlbum=" & a.albumID & ";")

        For Each aux1 In col1
            a.releaseDate = Date.Parse(aux1(3).ToString)
            a.cover = aux1(5).ToString
            col2 = DBBroker.GetBroker().Read("SELECT IdArtist, aName FROM ARTISTS WHERE IdArtist=" & aux1(4).ToString & ";")
            For Each aux2 In col2
                a.artist = New Artist(Integer.Parse(aux2(1).ToString), aux2(2).ToString)
            Next

        Next
    End Sub
    Public Function insert(a As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO ALBUMS (aName, releaseDate, artist, cover) VALUES ('" & a.name & "', '" & a.releaseDate & "', " & a.artist.id & ",'" & a.cover & "');")
    End Function
    Public Function update(a As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE ALBUMS SET aName='" & a.name & "',releaseDate='" & a.releaseDate & "',artist=" & a.artist.id & ",[cover]='" & a.cover & "' WHERE IdAlbum=" & a.albumID & ";")
    End Function
    Public Function delete(a As Album) As Integer
        Dim songAux As Song
        For Each songAux In a.songs
            songAux.deleteSong()
        Next
        Return DBBroker.GetBroker.Change("DELETE FROM ALBUMS WHERE IdAlbum=" & a.albumID & ";")
    End Function
    Public Sub readMySongs(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        Dim song As Song
        col = DBBroker.GetBroker().Read("SELECT sName FROM SONGS WHERE Album=" & a.albumID & ";")

        For Each aux In col
            song = New Song()
            aux(1).ToString.Replace("'", "''")
            song = New Song()
            song.readSong()
            a.songs.Add(song)
        Next
    End Sub
    Public Function convertLength(a As Album) As String
        Dim seg As Integer
        Dim min As Integer
        Dim minAux As Integer
        Dim hour As Integer
        seg = a.length Mod 60
        minAux = Integer.Parse(((a.length - seg) / 60).ToString)
        If min > 60 Then
            min = minAux Mod 60
            hour = Integer.Parse(((minAux - min) / 60).ToString)
        Else
            min = minAux
        End If

        Return min.ToString() & ":" & seg.ToString()
    End Function
    Public Sub calculateTotalLength(ByRef a As Album)
        Dim song As Song
        For Each song In a.songs
            a.length += song.length
        Next
    End Sub
End Class
