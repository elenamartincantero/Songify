Public Class User
    Public Property email As String
    Public Property uName As String
    Public Property uSurname As String
    Public Property birthday As String
    Public Property fav_artists As Collection
    Public ReadOnly Property UserDAO As UserDAO

    Public Sub New(email As String)
        Me.UserDAO = New UserDAO
        Me.email = email
    End Sub

    Public Sub New(email As String, uName As String, uSurname As String, birthday As String)
        Me.UserDAO = New UserDAO
        Me.email = email
        Me.uName = uName
        Me.uSurname = uSurname
        Me.birthday = birthday
        Me.UserDAO.readMyArtists(Me)
    End Sub

    Public Sub readUser(path As String)
        Me.UserDAO.read(Me, path)
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
        Me.UserDAO.readAllByTime()
    End Sub

    Public Sub playbackFavArtists()
        Me.UserDAO.playbackFavArtists(Me)
    End Sub
    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)
        Me.UserDAO.readArtistsMostListened(beginDate, endDate, Me)
    End Sub
End Class
