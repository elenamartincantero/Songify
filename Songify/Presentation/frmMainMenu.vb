Public Class frmMainMenu
    Public Property user As User

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLogin.user IsNot Nothing Then
            Me.user = frmLogin.user
        ElseIf frmManage.myUser IsNot Nothing Then
            Me.user = frmManage.myUser
            'ElseIf frmSearch.user IsNot Nothing Then
            '    Me.user = frmSearch.user
        ElseIf frmStatistics.user IsNot Nothing Then
            Me.user = frmStatistics.user
        End If

        LoggedUserLbl.Text = "User logged as: " + Me.user.email.ToString
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