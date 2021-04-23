Public Class User
    Public Property email As String
    Public Property uName As String
    Public Property uSurname As String
    Public Property birthday As Date
    Public Property fav_artists As Collection
    Public ReadOnly Property UserDAO As UserDAO

    Public Sub New()
        Me.UserDAO = New UserDAO
    End Sub
    Public Sub New(email As String)
        Me.UserDAO = New UserDAO
        Me.email = email
        Me.fav_artists = New Collection
    End Sub

    Public Sub readAllUsers()
        Me.UserDAO.readAll()
    End Sub
    Public Sub connect(path As String)
        Me.UserDAO.connect(path)
    End Sub
    Public Sub readUser()
        Me.UserDAO.read(Me)
    End Sub
    Public Function insertUser() As Integer
        Return Me.UserDAO.insert(Me)
    End Function
    Public Function updateUser() As Integer
        Return Me.UserDAO.update(Me)
    End Function
    Public Function deleteUser() As Integer
        Return Me.UserDAO.delete(Me)
    End Function

    Public Sub usersSortedByTime()
        Me.UserDAO.usersSortedByTime()
    End Sub

    Public Sub playbackFavArtists()
        Me.UserDAO.playbackFavArtists(Me)
    End Sub
    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date)
        Me.UserDAO.readArtistsMostListened(beginDate, endDate, Me)
    End Sub

    Public Sub readMyArtists()
        Me.UserDAO.readMyArtists(Me)
    End Sub

End Class
