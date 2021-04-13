Public Class frmMainMenu
    Public Property user As User

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.user = frmLogin.user
        LoggedUserLbl.Text = "User logged as: " + Me.user.email.ToString
    End Sub

    Private Sub ChangeUserButton_Click(sender As Object, e As EventArgs) Handles ChangeUserButton.Click
        frmLogin.Show()
        frmLogin.user = Me.user
        frmLogin.LoginButton.Enabled = True
        Me.Close()
    End Sub

    Private Sub ManageButton_Click(sender As Object, e As EventArgs) Handles ManageButton.Click
        frmManage.Show()
        Me.Close()
    End Sub

    Private Sub StatisticsButton_Click(sender As Object, e As EventArgs) Handles StatisticsButton.Click
        frmStatistics.Show()
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        frmSearch.Show()
        Me.Close()
    End Sub
End Class