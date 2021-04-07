Public Class Artist
    Public Property id As Integer
    Public Property name As String
    Public Property country As String
    Public Property image As String

    Public ReadOnly Property ArtistDAO As ArtistDAO

    Public Sub New()
        Me.ArtistDAO = New ArtistDAO
    End Sub

    Public Sub New(name As String)
        Me.name = name
    End Sub

End Class
