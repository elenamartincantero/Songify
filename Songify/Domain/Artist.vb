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
    Public Sub New(id As Integer, name As String)
        Me.ArtistDAO = New ArtistDAO
        Me.name = name
        Me.id = id
        Me.albums = New Collection
    End Sub
    Public Sub New(id As Integer)
        Me.ArtistDAO = New ArtistDAO
        Me.id = id
        Me.albums = New Collection
    End Sub

    Public Sub readAllArtists()
        Me.ArtistDAO.readAll()
    End Sub
    Public Sub readArtist()
        Me.ArtistDAO.read(Me)
    End Sub
    Public Function insertArtist() As Integer
        Return Me.ArtistDAO.insert(Me)
    End Function
    Public Function updateArtist() As Integer
        Return Me.ArtistDAO.update(Me)
    End Function
    Public Function deleteArtist() As Integer
        Me.ArtistDAO.readMyAlbums(Me)
        Return Me.ArtistDAO.delete(Me)
    End Function
    Public Function favArtist(us As User) As Integer
        Return Me.ArtistDAO.fav(us, Me)
    End Function
    Public Function not_favArtist(us As User) As Integer
        Return Me.ArtistDAO.not_fav(us, Me)
    End Function
    Public Sub artistsSorted()
        Me.ArtistDAO.artistsSorted(Me)
    End Sub

    Public Sub readMyAlbums()
        Me.ArtistDAO.readMyAlbums(Me)
    End Sub
End Class
