Public Class frmManage

    Property album As Album
    Property artist As Artist
    Property song As Song
    Property user As User


    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = String.Empty
        InfoTextBox2.Text = String.Empty
        InfoTextBox3.Text = String.Empty
        InfoTextBox4.Text = String.Empty
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InfoListBox1.SelectedIndexChanged

    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged
        If TypeComboBox.SelectedItem.ToString() = "Users" Then
            elementosInvisibles()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Surname"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Email"
            InfoTextBox4.Visible = True
            InfoLabel4.Visible = True
            InfoLabel4.Text = "Birthdate"

            readUsers()

        ElseIf TypeComboBox.SelectedItem.ToString() = "Artists" Then
            elementosInvisibles()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Country"

        ElseIf TypeComboBox.SelectedItem.ToString() = "Albums" Then
            elementosInvisibles()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Release date"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Total length"

        ElseIf TypeComboBox.SelectedItem.ToString() = "Songs" Then
            elementosInvisibles()
            NameTextBox.Visible = True
            NameLabel.Visible = True
            InfoTextBox2.Visible = True
            InfoLabel2.Visible = True
            InfoLabel2.Text = "Belonging album"
            InfoTextBox3.Visible = True
            InfoLabel3.Visible = True
            InfoLabel3.Text = "Length"
        End If

    End Sub

    Private Sub elementosInvisibles()
        NameTextBox.Visible = False
        NameLabel.Visible = False
        InfoTextBox2.Visible = False
        InfoLabel2.Visible = False
        InfoTextBox3.Visible = False
        InfoLabel3.Visible = False
        InfoTextBox4.Visible = False
        InfoLabel4.Visible = False
    End Sub

    Private Sub readUsers()
        Dim uAux As User
        Me.user = New User
        Try
            user.ReadUser(frmLogin.ofdDB.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub

End Class