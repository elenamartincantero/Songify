Public Class UserDAO
    Private Property usersByTime As Collection
    Public Sub readAllByTime()

    End Sub
    Public Sub read(ByRef u As User, path As String)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM USERS WHERE Email='" & u.email & "';")
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthday = aux(4).ToString

        Next
    End Sub
    Public Sub insert(u As User)

    End Sub
    Public Sub update(u As User)

    End Sub
    Public Sub delete(u As User)

    End Sub
    Public Sub readMyArtists(ByRef u As User)

    End Sub
    Public Sub usersSortedByTime()

    End Sub

    Public Sub readArtistsMostListened(beginDate As Date, endDate As Date, user As User)

    End Sub
    Public Sub playbackFavArtists(u As User)

    End Sub

End Class
