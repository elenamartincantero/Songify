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
    Public Sub New(name As String, releaseDate As String, artist As String, cover As String)
        Me.AlbumDAO = New AlbumDAO
        Me.name = name
        Me.releaseDate = Date.Parse(releaseDate)
        Me.artist = New Artist(artist)
        Me.cover = cover
        Me.songs = New Collection
    End Sub

    Public Sub New(name As String)
        Me.AlbumDAO = New AlbumDAO
        Me.name = name
        Me.songs = New Collection
    End Sub
    Public Sub readbyArtist(name As String)
        Me.AlbumDAO.readbyArtist(name, Me)
    End Sub
    Public Sub readAllAlbums()
        Me.AlbumDAO.readAll()
    End Sub
    Public Sub readAlbum()
        Me.AlbumDAO.read(Me)
        Me.AlbumDAO.readMySongs(Me)
        Me.AlbumDAO.calculateTotalLength(Me)
    End Sub
    Public Sub insertAlbum()
        Me.artist.readArtist()
        Me.AlbumDAO.insert(Me)
    End Sub
    Public Sub updateAlbum()
        Me.artist.readArtist()
        Me.AlbumDAO.update(Me)
    End Sub
    Public Sub deleteAlbum()
        Me.AlbumDAO.delete(Me)
    End Sub
    Public Function convertLength() As String
        Return Me.AlbumDAO.convertLength(Me)
    End Function

    Public Sub readMySongs()
        Me.AlbumDAO.readMySongs(Me)
    End Sub

End Class
