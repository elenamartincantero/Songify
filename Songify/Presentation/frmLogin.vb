Public Class frmLogin
    Private Sub DatabaseButton_Click(sender As Object, e As EventArgs) Handles DatabaseButton.Click
        If Me.ofdDB.ShowDialog = DialogResult.OK Then
            DatabaseButton.Enabled = True
        End If
    End Sub

    Private Sub frmPersons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ofdDB.InitialDirectory = Application.StartupPath
    End Sub
End Class