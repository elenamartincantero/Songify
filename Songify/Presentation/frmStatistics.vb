Public Class frmStatistics
    Public Property myUser As User
    Property artist As Artist
    Property song As Song
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetElements()
        Me.myUser = frmMainMenu.user
        Me.artist = New Artist
        Dim artistAux As Artist
        Me.artist.readAllArtists()
        For Each artistAux In Me.artist.ArtistDAO.allArtists
            artistAux.readArtist()
            ComboBoxCountry.Items.Add(artistAux.aCountry)
        Next
    End Sub
    Private Sub resetElements()
        LabelCountry.Visible = False
        ComboBoxCountry.Visible = False
        LabelFrom.Visible = False
        BeginDate.Visible = False
        LabelTo.Visible = False
        EndDate.Visible = False
        ButtoAccp.Visible = False
    End Sub
    Private Sub ArtistSorted_Click(sender As Object, e As EventArgs) Handles ArtistSorted.Click
        resetElements()
        ListBox1.Items.Clear()
        LabelCountry.Visible = True
        ComboBoxCountry.Visible = True
        Dim text As String
        Me.artist = New Artist
        Try
            If ComboBoxCountry.SelectedItem Is Nothing Then
                artist.artistsSorted(String.Empty)
            Else
                artist.artistsSorted(ComboBoxCountry.SelectedItem.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each text In Me.artist.ArtistDAO.artistsSortedCol
            Me.ListBox1.Items.Add(text)
        Next
    End Sub

    Private Sub SongSorted_Click(sender As Object, e As EventArgs) Handles SongSorted.Click
        resetElements()
        ListBox1.Items.Clear()
        Me.song = New Song
        Dim text As String
        Try
            song.songsSorted()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each text In Me.song.SongDAO.sortedSongs
            Me.ListBox1.Items.Add(text)
        Next
    End Sub

    Private Sub ListenedArtist_Click(sender As Object, e As EventArgs) Handles ListenedArtist.Click
        resetElements()
        ListBox1.Items.Clear()
        LabelFrom.Visible = True
        BeginDate.Visible = True
        LabelTo.Visible = True
        EndDate.Visible = True
        ButtoAccp.Visible = True

    End Sub
    Private Sub UserSorted_Click(sender As Object, e As EventArgs) Handles UserSorted.Click
        ListBox1.Items.Clear()
        resetElements()
        Dim text As String
        Try
            myUser.usersSortedByTime()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each text In Me.myUser.UserDAO.usersByTime
            Me.ListBox1.Items.Add(text)
        Next
    End Sub

    Private Sub Playbacktime_Click(sender As Object, e As EventArgs) Handles Playbacktime.Click
        Dim text As String
        ListBox1.Items.Clear()
        resetElements()
        Try
            myUser.playbackFavArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        For Each text In myUser.UserDAO.playbacksFav
            ListBox1.Items.Add(text)
        Next

    End Sub


    Private Sub ButtoAccp_Click(sender As Object, e As EventArgs) Handles ButtoAccp.Click
        If BeginDate.Value.Date <= EndDate.Value.Date Then
            Dim text As String
            Try
                Me.myUser.readArtistsMostListened(BeginDate.Value.Date, EndDate.Value.Date)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            For Each text In Me.myUser.UserDAO.artistsMostListened
                Me.ListBox1.Items.Add(text)
            Next
        End If
    End Sub

    Private Sub ComboBoxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCountry.SelectedIndexChanged
        ArtistSorted_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ChangeUserButton_Click(sender As Object, e As EventArgs) Handles ChangeUserButton.Click
        If MessageBox.Show("Are you sure you want to change user?", "Change user", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmLogin.Show()
            frmLogin.user = Me.user
            frmLogin.LoginButton.Enabled = True
            frmLogin.ConnectButton.Enabled = False
            frmLogin.LoginBox.Enabled = True
            Me.Close()
        End If
    End Sub
End Class