Public Class Album
    Public Property albumID As Integer
    Public Property name As String
    Public Property releaseDate As Date
    Public Property artist As Artist
    Public Property cover As String
    Public Property songs As Collection
    Public Property length As Integer

    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New()
        Me.AlbumDAO = New AlbumDAO
    End Sub

    Public Sub New(name As String)
        Me.AlbumDAO = New AlbumDAO
        Me.name = name
    End Sub



End Class
