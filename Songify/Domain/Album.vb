Public Class Album
    Public Property idAlbum As Integer
    Public Property aName As String
    Public Property aReleaseDate As Date
    Public Property aArtist As Artist
    Public Property aCover As String
    Public Property aLength As Integer
    Public Property aSongs As Collection

    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New()
        Me.AlbumDAO = New AlbumDAO
        Me.aSongs = New Collection
    End Sub

    Public Sub New(albumID As Integer, name As String)
        Me.AlbumDAO = New AlbumDAO
        Me.aName = name.Replace("'", "''")
        Me.idAlbum = albumID
        Me.aSongs = New Collection
    End Sub
    Public Sub New(aName As String)
        Me.AlbumDAO = New AlbumDAO
        Me.aName = aName.Replace("'", "''")
        Me.aSongs = New Collection
    End Sub
    Public Sub readAllAlbums()
        Me.AlbumDAO.readAll()
    End Sub
    Public Sub readAlbum()
        Me.AlbumDAO.read(Me)
    End Sub

    Public Function insertAlbum() As Integer
        Me.aArtist.readArtist()
        Return Me.AlbumDAO.insert(Me)
    End Function
    Public Function updateAlbum() As Integer
        Me.aArtist.readArtist()
        Return Me.AlbumDAO.update(Me)
    End Function
    Public Function deleteAlbum() As Integer
        Me.AlbumDAO.readMySongs(Me)
        Return Me.AlbumDAO.delete(Me)
    End Function
    Public Function convertLength() As String
        Return Me.AlbumDAO.convertLength(Me)
    End Function

    Public Sub readMySongs()
        Me.AlbumDAO.readMySongs(Me)
    End Sub
    Public Sub calculateTotalLength()
        Me.AlbumDAO.calculateTotalLength(Me)
    End Sub

End Class
