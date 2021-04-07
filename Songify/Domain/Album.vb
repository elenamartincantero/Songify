Public Class Album
    Public Property albumID As Integer
    Public Property name As String
    Public Property releaseDate As String
    Public Property artist As Artist
    Public Property cover As String
    Public Property length As Integer
    Public Property songs As Collection

    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New(name As String, releaseDate As String, artist As String, cover As String)
        Me.AlbumDAO = New AlbumDAO
        Me.name = name
        Me.releaseDate = releaseDate
        Me.artist = New Artist(artist)
        Me.cover = cover
        Me.AlbumDAO.readMySongs(Me)
    End Sub

    Public Sub New(name As String)
        Me.AlbumDAO = New AlbumDAO
        Me.name = name
    End Sub

    Public Sub readAllAlbums()
        Me.AlbumDAO.readAll()
    End Sub
    Public Sub readAlbum()
        Me.AlbumDAO.read(Me)
    End Sub
    Public Sub insertAlbum()
        Me.AlbumDAO.insert(Me)
    End Sub
    Public Sub updateAlbum()
        Me.AlbumDAO.update(Me)
    End Sub
    Public Sub deleteAlbum()
        Me.AlbumDAO.delete(Me)
    End Sub
    Public Function convertLength() As String
        Return Me.AlbumDAO.convertLength(Me)
    End Function
    Public Sub calculateTotalLength()
        Me.AlbumDAO.calculateTotalLength(Me)
    End Sub

End Class
