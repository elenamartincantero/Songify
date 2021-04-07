Public Class UserDAO

    Public Sub read(ByRef u As User, path As String)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM USERS WHERE Email='" & u.email & "';")
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthday = aux(4).ToString


        Next
    End Sub
    Public Sub insert(ByVal u As User)

    End Sub
    Public Sub update(ByVal u As User)

    End Sub
    Public Sub delete(ByVal u As User)

    End Sub

End Class
