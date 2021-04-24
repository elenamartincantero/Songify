Public Class frmLogin
    Public Property user As User

    Private Sub DatabaseButton_Click(sender As Object, e As EventArgs) Handles DatabaseButton.Click
        If Me.ofdDB.ShowDialog = DialogResult.OK Then
            ConnectButton.Enabled = True
            LoginButton.Enabled = False
        End If

    End Sub

    Private Sub frmPersons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ofdDB.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.user = New User(LoginBox.Text.ToString)

        Try
            Me.user.readUser()
            If Me.user.uName <> String.Empty Then
                frmMainMenu.Show()
                Me.Close()
            Else
                MessageBox.Show("Please, insert a valid user", "Custom Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("Please, choose a valid database", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        user = New User()
        Try
            Me.user.connect(ofdDB.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        Me.LoginBox.Enabled = True

    End Sub

    Private Sub LoginBox_TextChanged(sender As Object, e As EventArgs) Handles LoginBox.TextChanged
        LoginButton.Enabled = True
    End Sub
End Class