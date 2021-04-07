Public Class User
    Public Property email As String
    Public Property uName As String
    Public Property uSurname As String
    Public Property birthday As String
    Public Property playbacks As Collection
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
    End Sub

    Public Sub ReadUser(path As String)
        Me.UserDAO.read(Me, path)
    End Sub
    Public Sub InsertUser()
        Me.UserDAO.insert()
    End Sub
    Public Sub UpdateUser()
        Me.UserDAO.update()
    End Sub
    Public Sub DeleteUser()
        Me.UserDAO.delete()
    End Sub

End Class
