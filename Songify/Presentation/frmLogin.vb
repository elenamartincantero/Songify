﻿Public Class frmLogin
    Public Property user As User
    Private Sub DatabaseButton_Click(sender As Object, e As EventArgs) Handles DatabaseButton.Click
        If Me.ofdDB.ShowDialog = DialogResult.OK Then
            LoginButton.Enabled = True
        End If

    End Sub

    Private Sub frmPersons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ofdDB.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.user = New User(LoginBox.Text.ToString)

        Try
            Me.user.readUser(ofdDB.FileName)
            frmMainMenu.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please introduce a valid user", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub


End Class