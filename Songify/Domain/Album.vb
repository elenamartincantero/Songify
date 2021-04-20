Public Class Album
    Public Property albumID As Integer
    Public Property name As String
    Public Property releaseDate As Date
    Public Property artist As Artist
    Public Property cover As String
    Public Property length As Integer
    Public Property songs As Collection

    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New()
        Me.AlbumDAO = New AlbumDAO
    End Sub

    Public Sub New(albumID As Integer, name As String)
        Me.AlbumDAO = New AlbumDAO
        Me.name = name
        Me.albumID = albumID
        Me.songs = New Collection
    End Sub
    Public Sub New(albumID As Integer)
        Me.AlbumDAO = New AlbumDAO
        Me.albumID = albumID
        Me.songs = New Collection
    End Sub
    Public Sub readAllAlbums()
        Me.AlbumDAO.readAll()
    End Sub
    Public Sub readAlbum()
        Me.AlbumDAO.read(Me)
    End Sub

    Public Function insertAlbum() As Integer
        Me.artist.readArtist()
        Return Me.AlbumDAO.insert(Me)
    End Function
    Public Function updateAlbum() As Integer
        Me.artist.readArtist()
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
