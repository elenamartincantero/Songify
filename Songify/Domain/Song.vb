Public Class Song
    Public Property idSong As Integer
    Public Property sName As String
    Public Property sLength As Integer
    Public Property sAlbum As Album
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

    Public Sub New(sname As String)
        Me.SongDAO = New SongDAO
        Me.sName = sname
        Me.sName = Me.sName.Replace("'", "''")
    End Sub

    Public Sub readAllSongs()
        Me.SongDAO.readAll()
    End Sub
    Public Sub readSong()
        Me.SongDAO.read(Me)
    End Sub
    Public Function insertSong() As Integer
        Me.sAlbum.readAlbum()
        Return Me.SongDAO.insert(Me)
    End Function
    Public Function updateSong() As Integer
        Me.sAlbum.readAlbum()
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
