Public Class Song
    Public Property idSong As Integer
    Public Property sName As String
    Public Property length As Double
    Public Property playbacks As Collection
    Public ReadOnly Property SongDAO As SongDAO

    Public Sub New(sName As String)
        Me.SongDAO = New SongDAO
        Me.sName = sName
    End Sub

    Public Sub readAllSongs(album As String)
        Me.SongDAO.readAll(album)
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
    Public Sub convertLength()
        Me.SongDAO.convertLength(Me)
    End Sub
    Public Sub play(us As User)
        Me.SongDAO.play(us, Me)
    End Sub

End Class
