Public Class Song
    Public Property idSong As Integer
    Public Property sName As String
    Public Property length As Integer
    Public Property album As Album
    Public ReadOnly Property SongDAO As SongDAO

    Public Sub New()

        Me.SongDAO = New SongDAO
    End Sub
    Public Sub New(id As Integer, sName As String)
        Me.SongDAO = New SongDAO
        Me.idSong = id
        Me.sName = sName
        Me.sName = Me.sName.Replace("'", "''")

    End Sub
    Public Sub New(id As Integer)
        Me.SongDAO = New SongDAO
        Me.idSong = id
    End Sub

    Public Sub New(sName As String, length As Integer, album As String)
        Me.SongDAO = New SongDAO
        Me.sName = sName
        Me.length = length
        Me.album = New Album(album)
    End Sub

    Public Sub readAllSongs()
        Me.SongDAO.readAll()
    End Sub
    Public Sub readSong()
        Me.SongDAO.read(Me)
    End Sub
    Public Function insertSong() As Integer
        Me.album.readAlbum()
        Return Me.SongDAO.insert(Me)
    End Function
    Public Function updateSong() As Integer
        Me.album.readAlbum()
        Return Me.SongDAO.update(Me)
    End Function
    Public Function deleteSong() As Integer
        Return Me.SongDAO.delete(Me)
    End Function
    Public Function convertLength() As String
        Return Me.SongDAO.convertLength(Me)
    End Function
    Public Function play(us As User) As Integer
        Return Me.SongDAO.play(us, Me)
    End Function
    Public Function readPlayblacks() As String
        Return Me.SongDAO.readPlayblacks(Me)
    End Function
    Public Sub songsSorted()
        Me.SongDAO.songsSorted()
    End Sub
End Class
