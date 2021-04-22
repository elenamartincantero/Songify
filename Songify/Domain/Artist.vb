Public Class Artist
    Public Property idArtist As Integer
    Public Property aName As String
    Public Property aCountry As String
    Public Property aImage As String
    Public Property aAlbums As Collection

    Public ReadOnly Property ArtistDAO As ArtistDAO

    Public Sub New()
        Me.ArtistDAO = New ArtistDAO
    End Sub
    Public Sub New(id As Integer, name As String)
        Me.ArtistDAO = New ArtistDAO
        Me.aName = name
        Me.idArtist = id
        Me.aAlbums = New Collection
    End Sub
    Public Sub New(name As String)
        Me.ArtistDAO = New ArtistDAO
        Me.aName = name
        Me.aAlbums = New Collection
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
    Public Sub artistsSorted(filter As String)
        Me.ArtistDAO.artistsSorted(Me, filter)
    End Sub

    Public Sub readMyAlbums()
        Me.ArtistDAO.readMyAlbums(Me)
    End Sub
End Class
