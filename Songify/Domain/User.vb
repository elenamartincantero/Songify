Public Class User
    Public Property email As String
    Public Property uName As String
    Public Property uSurname As String
    Public Property birthdate As Date
    Public Property playbacks As Collection
    Public Property fav_artists As Collection

    Public Sub New(email As String)
        Me.email = email
    End Sub

End Class
