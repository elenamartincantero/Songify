<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.InfoLabel2 = New System.Windows.Forms.Label()
        Me.InfoLabel3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.InfoTextBox2 = New System.Windows.Forms.TextBox()
        Me.InfoTextBox3 = New System.Windows.Forms.TextBox()
        Me.InfoListBox = New System.Windows.Forms.ListBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ArtistImage = New System.Windows.Forms.PictureBox()
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.DateLabel = New System.Windows.Forms.Label()
        CType(Me.ArtistImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InsertButton
        '
        Me.InsertButton.Enabled = False
        Me.InsertButton.Location = New System.Drawing.Point(349, 228)
        Me.InsertButton.Margin = New System.Windows.Forms.Padding(2)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(54, 41)
        Me.InsertButton.TabIndex = 0
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(349, 282)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(54, 41)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(406, 282)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(54, 41)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'TypeComboBox
        '
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"Users", "Songs", "Albums", "Artists"})
        Me.TypeComboBox.Location = New System.Drawing.Point(36, 24)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(173, 21)
        Me.TypeComboBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(190, 67)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        Me.NameLabel.Visible = False
        '
        'InfoLabel2
        '
        Me.InfoLabel2.AutoSize = True
        Me.InfoLabel2.Location = New System.Drawing.Point(190, 98)
        Me.InfoLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InfoLabel2.Name = "InfoLabel2"
        Me.InfoLabel2.Size = New System.Drawing.Size(39, 13)
        Me.InfoLabel2.TabIndex = 5
        Me.InfoLabel2.Text = "Label2"
        Me.InfoLabel2.Visible = False
        '
        'InfoLabel3
        '
        Me.InfoLabel3.AutoSize = True
        Me.InfoLabel3.Location = New System.Drawing.Point(190, 128)
        Me.InfoLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InfoLabel3.Name = "InfoLabel3"
        Me.InfoLabel3.Size = New System.Drawing.Size(39, 13)
        Me.InfoLabel3.TabIndex = 6
        Me.InfoLabel3.Text = "Label3"
        Me.InfoLabel3.Visible = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(275, 65)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.NameTextBox.TabIndex = 8
        Me.NameTextBox.Visible = False
        '
        'InfoTextBox2
        '
        Me.InfoTextBox2.Location = New System.Drawing.Point(275, 95)
        Me.InfoTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoTextBox2.Name = "InfoTextBox2"
        Me.InfoTextBox2.Size = New System.Drawing.Size(170, 20)
        Me.InfoTextBox2.TabIndex = 9
        Me.InfoTextBox2.Visible = False
        '
        'InfoTextBox3
        '
        Me.InfoTextBox3.Location = New System.Drawing.Point(275, 125)
        Me.InfoTextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoTextBox3.Name = "InfoTextBox3"
        Me.InfoTextBox3.Size = New System.Drawing.Size(170, 20)
        Me.InfoTextBox3.TabIndex = 10
        Me.InfoTextBox3.Visible = False
        '
        'InfoListBox
        '
        Me.InfoListBox.FormattingEnabled = True
        Me.InfoListBox.Location = New System.Drawing.Point(36, 67)
        Me.InfoListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoListBox.Name = "InfoListBox"
        Me.InfoListBox.Size = New System.Drawing.Size(125, 303)
        Me.InfoListBox.TabIndex = 13
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Location = New System.Drawing.Point(349, 342)
        Me.MainMenuButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(118, 27)
        Me.MainMenuButton.TabIndex = 14
        Me.MainMenuButton.Text = "Return to main menu"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Location = New System.Drawing.Point(406, 228)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(54, 41)
        Me.ClearButton.TabIndex = 15
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ArtistImage
        '
        Me.ArtistImage.Location = New System.Drawing.Point(187, 227)
        Me.ArtistImage.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtistImage.Name = "ArtistImage"
        Me.ArtistImage.Size = New System.Drawing.Size(136, 146)
        Me.ArtistImage.TabIndex = 16
        Me.ArtistImage.TabStop = False
        Me.ArtistImage.Visible = False
        '
        'DateBox
        '
        Me.DateBox.Location = New System.Drawing.Point(275, 161)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(200, 20)
        Me.DateBox.TabIndex = 18
        Me.DateBox.Visible = False
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(190, 161)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(39, 13)
        Me.DateLabel.TabIndex = 19
        Me.DateLabel.Text = "Label1"
        Me.DateLabel.Visible = False
        '
        'frmManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 390)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.DateBox)
        Me.Controls.Add(Me.ArtistImage)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Controls.Add(Me.InfoListBox)
        Me.Controls.Add(Me.InfoTextBox3)
        Me.Controls.Add(Me.InfoTextBox2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.InfoLabel3)
        Me.Controls.Add(Me.InfoLabel2)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmManage"
        Me.Text = "frmManage"
        CType(Me.ArtistImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InsertButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents InfoLabel2 As Label
    Friend WithEvents InfoLabel3 As Label
    Friend WithEvents InfoLabel4 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents InfoTextBox2 As TextBox
    Friend WithEvents InfoTextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents InfoListBox As ListBox
    Friend WithEvents InfoTextBox4 As TextBox
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ArtistImage As PictureBox
    Friend WithEvents DateBox As DateTimePicker
    Friend WithEvents DateLabel As Label
End Class
