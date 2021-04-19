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

    Public Sub New(email As String, uName As String, uSurname As String, birthday As String)
        Me.UserDAO = New UserDAO
        Me.email = email
        Me.uName = uName
        Me.uSurname = uSurname
        Me.birthday = CDate(birthday)
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
    Public Sub insertUser()
        Me.UserDAO.insert(Me)
    End Sub
    Public Sub updateUser()
        Me.UserDAO.update(Me)
    End Sub
    Public Sub deleteUser()
        Me.UserDAO.delete(Me)
    End Sub

    Public Sub usersSortedByTime()
        Me.UserDAO.usersSortedByTime()
    End Sub

    Public Function playbackFavArtists() As String
        Return Me.UserDAO.playbackFavArtists(Me)
    End Function
    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)
        Me.UserDAO.readArtistsMostListened(beginDate, endDate, Me)
    End Sub

    Public Sub readMyArtists()
        Me.UserDAO.readMyArtists(Me)
    End Sub

End Class
