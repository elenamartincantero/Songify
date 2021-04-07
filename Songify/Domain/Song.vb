Public Class Song
    Public Property idSong As Integer
    Public Property sName As String
    Public Property length As Double
    Public Property playbacks As Collection
    Public ReadOnly Property SongDAO As SongDAO

    Public Sub New(sName As String)
        Me.SongDAO = new SongDAO 
        Me.sName = sName
    End Sub

End Class
