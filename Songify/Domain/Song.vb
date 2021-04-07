Public Class Song
    Public Property idSong As Integer
    Public Property sName As String
    Public Property length As Integer
    Public Property album As Album
    Public ReadOnly Property SongDAO As SongDAO

    Public Sub New(sName As String)
        Me.SongDAO = New SongDAO
        Me.sName = sName
    End Sub

    Public Sub New(sName As String, length As Integer, album As String)
        Me.SongDAO = New SongDAO
        Me.sName = sName
        Me.length = length
        Me.album = New Album(album)
    End Sub

    Public Sub readSong()
        Me.SongDAO.read(Me)
    End Sub
    Public Sub insertSong()
        Me.SongDAO.insert(Me)
    End Sub
    Public Sub updateSong()
        Me.SongDAO.insert(Me)
    End Sub
    Public Sub deleteSong()
        Me.SongDAO.delete(Me)
    End Sub
    Public Function convertLength() As String
        Return Me.SongDAO.convertLength(Me)
    End Function
    Public Sub play(us As User)
        Me.SongDAO.play(us, Me)
    End Sub
    Public Function readPlayblacks() As String
        Return Me.SongDAO.readPlayblacks(Me)
    End Function
    Public Sub songsSorted()
        Me.SongDAO.songsSorted()
    End Sub
End Class
