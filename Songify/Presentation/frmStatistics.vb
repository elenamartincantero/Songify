Public Class frmStatistics
    Public Property myUser As User
    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.myUser = frmMainMenu.user
    End Sub
    Private Sub ArtistSorted_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()
        Dim artistAux As Artist = New Artist
        Me.artist = New Artist
        Try
            artist.artistsSorted()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each artistAux In Me.user.UserDAO.usersByTime
            Me.ListBox1.Items.Add(artistAux.aName)
        Next
    End Sub

    Private Sub UserSorted_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()
        Dim userAux As User = New User
        Me.user = New User(Me.myUser.uName)
        Try
            user.usersSortedByTime()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each userAux In Me.user.UserDAO.usersByTime
            Me.ListBox1.Items.Add(userAux.uName)
        Next
    End Sub

    Private Sub SongSorted_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()
        Dim songAux As Song = New Song
        Me.song = New Song
        Try
            song.songsSorted()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        ' For Each userAux In Me.song
        'Me.ListBox1.Items.Add(songAux.sName)
        'Next
    End Sub

    Private Sub ListenedArtist_Click(sender As Object, e As EventArgs)
        If frmDate.DateTimeBegin IsNot String.Empty And frmDate.DateTimeEnd IsNot String.Empty Then
            ListBox1.Items.Clear()
            Dim userAux As User = New User
            Me.user = New User
            Try
                user.readArtistsMostListened(frmDate.DateTimeBegin.Value, frmDate.DateTimeEnd.Value, Me.myUser)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            'For Each userAux In Me.user
            'Me.ListBox1.Items.Add(userAux.uName)
            ' Next
        End If
    End Sub

    Private Sub Playbacktime_Click(sender As Object, e As EventArgs)
        Dim txt As String = ""
        Me.user = New User
        ListBox1.Items.Clear()
        Try
            txt = user.playbackFavArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        ListBox1.Items.Add(txt)
    End Sub
End Class