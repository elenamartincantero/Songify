Public Class frmMainMenu
    Property user As User
    Private Sub ChangeUserButton_Click(sender As Object, e As EventArgs) Handles ChangeUserButton.Click
        frmLogin.Show()
        frmManage.Close()
        frmSearch.Close()
        frmStatistics.Close()
        Me.Hide()
    End Sub

    Private Sub ManageButton_Click(sender As Object, e As EventArgs) Handles ManageButton.Click
        Me.Hide()
        frmManage.Show()
    End Sub

    Private Sub StatisticsButton_Click(sender As Object, e As EventArgs) Handles StatisticsButton.Click
        Me.Hide()
        frmStatistics.Show()
    End Sub
End Class