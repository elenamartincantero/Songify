Public Class SongDAO
    Private Property sortedSongs As Collection
    Private Property allSongs As Collection

    Public Sub New()
        sortedSongs = New Collection
        allSongs = New Collection
    End Sub
    Public Sub readAll()

    End Sub
    Public Sub read(ByRef s As Song)

    End Sub
    Public Sub insert(s As Song)

    End Sub
    Public Sub update(s As Song)

    End Sub
    Public Sub delete(s As Song)

    End Sub
    Public Function convertLength(s As Song) As String
        Dim seg As Integer
        Dim min As Double
        seg = s.length Mod 60
        min = Integer.Parse(((s.length - seg) / 60).ToString)

        Return min.ToString() & ":" & seg.ToString()
    End Function
    Public Sub play(us As User, s As Song)
        'Insert playback
    End Sub
    Public Function readPlayblacks(s As Song) As String
        Return "tengo que hacer el código"
    End Function
    Public Sub songsSorted()

    End Sub
End Class
