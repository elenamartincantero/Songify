Public Class Artist
    Public Property id As Integer
    Public Property name As String
    Public Property country As String
    Public Property image As String
    Public Property albums As Collection

    Public ReadOnly Property ArtistDAO As ArtistDAO

    Public Sub New()
        Me.ArtistDAO = New ArtistDAO
    End Sub
    Public Sub New(name As String)
        Me.ArtistDAO = New ArtistDAO
        Me.name = name
    End Sub
    Public Sub New(id As Integer)
        Me.ArtistDAO = New ArtistDAO
        Me.id = id
        Me.albums = New Collection
    End Sub

    Public Sub New(name As String, country As String, image As String)
        Me.ArtistDAO = New ArtistDAO
        Me.name = name
        Me.country = country
        Me.image = image
        Me.albums = New Collection

    End Sub

    Public Sub readAllArtists()
        Me.ArtistDAO.readAll()
    End Sub
    Public Sub readArtist()
        Me.ArtistDAO.read(Me)
    End Sub
    Public Sub insertArtist()
        Me.ArtistDAO.insert(Me)
    End Sub
    Public Sub updateArtist()
        Me.ArtistDAO.update(Me)
    End Sub
    Public Sub deleteArtist()
        Me.ArtistDAO.delete(Me)
    End Sub
    Public Sub favArtist(us As User)
        Me.ArtistDAO.fav(us, Me)
    End Sub
    Public Sub not_favArtist(us As User)
        Me.ArtistDAO.not_fav(us, Me)
    End Sub
    Public Sub artistsSorted()
        Me.ArtistDAO.artistsSorted(Me)
    End Sub

    Public Sub readMyAlbums()
        Me.ArtistDAO.readMyAlbums(Me)
    End Sub
End Class
