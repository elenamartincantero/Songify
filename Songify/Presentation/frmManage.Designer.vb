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
        Me.InfoLabel4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.InfoTextBox2 = New System.Windows.Forms.TextBox()
        Me.InfoTextBox3 = New System.Windows.Forms.TextBox()
        Me.InfoTextBox4 = New System.Windows.Forms.TextBox()
        Me.InfoListBox1 = New System.Windows.Forms.ListBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(465, 280)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(72, 50)
        Me.InsertButton.TabIndex = 0
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(465, 347)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(72, 50)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(541, 347)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(72, 50)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'TypeComboBox
        '
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"Users", "Songs", "Albums", "Artists"})
        Me.TypeComboBox.Location = New System.Drawing.Point(48, 30)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(229, 24)
        Me.TypeComboBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(253, 83)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 16)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        Me.NameLabel.Visible = False
        '
        'InfoLabel2
        '
        Me.InfoLabel2.AutoSize = True
        Me.InfoLabel2.Location = New System.Drawing.Point(253, 120)
        Me.InfoLabel2.Name = "InfoLabel2"
        Me.InfoLabel2.Size = New System.Drawing.Size(49, 16)
        Me.InfoLabel2.TabIndex = 5
        Me.InfoLabel2.Text = "Label2"
        Me.InfoLabel2.Visible = False
        '
        'InfoLabel3
        '
        Me.InfoLabel3.AutoSize = True
        Me.InfoLabel3.Location = New System.Drawing.Point(253, 157)
        Me.InfoLabel3.Name = "InfoLabel3"
        Me.InfoLabel3.Size = New System.Drawing.Size(49, 16)
        Me.InfoLabel3.TabIndex = 6
        Me.InfoLabel3.Text = "Label3"
        Me.InfoLabel3.Visible = False
        '
        'InfoLabel4
        '
        Me.InfoLabel4.AutoSize = True
        Me.InfoLabel4.Location = New System.Drawing.Point(253, 194)
        Me.InfoLabel4.Name = "InfoLabel4"
        Me.InfoLabel4.Size = New System.Drawing.Size(49, 16)
        Me.InfoLabel4.TabIndex = 7
        Me.InfoLabel4.Text = "Label4"
        Me.InfoLabel4.Visible = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(367, 80)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(226, 22)
        Me.NameTextBox.TabIndex = 8
        Me.NameTextBox.Visible = False
        '
        'InfoTextBox2
        '
        Me.InfoTextBox2.Location = New System.Drawing.Point(367, 117)
        Me.InfoTextBox2.Name = "InfoTextBox2"
        Me.InfoTextBox2.Size = New System.Drawing.Size(226, 22)
        Me.InfoTextBox2.TabIndex = 9
        Me.InfoTextBox2.Visible = False
        '
        'InfoTextBox3
        '
        Me.InfoTextBox3.Location = New System.Drawing.Point(367, 154)
        Me.InfoTextBox3.Name = "InfoTextBox3"
        Me.InfoTextBox3.Size = New System.Drawing.Size(226, 22)
        Me.InfoTextBox3.TabIndex = 10
        Me.InfoTextBox3.Visible = False
        '
        'InfoTextBox4
        '
        Me.InfoTextBox4.Location = New System.Drawing.Point(367, 191)
        Me.InfoTextBox4.Name = "InfoTextBox4"
        Me.InfoTextBox4.Size = New System.Drawing.Size(226, 22)
        Me.InfoTextBox4.TabIndex = 11
        Me.InfoTextBox4.Visible = False
        '
        'InfoListBox1
        '
        Me.InfoListBox1.FormattingEnabled = True
        Me.InfoListBox1.ItemHeight = 16
        Me.InfoListBox1.Location = New System.Drawing.Point(48, 83)
        Me.InfoListBox1.Name = "InfoListBox1"
        Me.InfoListBox1.Size = New System.Drawing.Size(165, 372)
        Me.InfoListBox1.TabIndex = 13
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Location = New System.Drawing.Point(465, 421)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(158, 33)
        Me.MainMenuButton.TabIndex = 14
        Me.MainMenuButton.Text = "Return to main menu"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(541, 280)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(72, 50)
        Me.ClearButton.TabIndex = 15
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(249, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 180)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'frmManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 480)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Controls.Add(Me.InfoListBox1)
        Me.Controls.Add(Me.InfoTextBox4)
        Me.Controls.Add(Me.InfoTextBox3)
        Me.Controls.Add(Me.InfoTextBox2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.InfoLabel4)
        Me.Controls.Add(Me.InfoLabel3)
        Me.Controls.Add(Me.InfoLabel2)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Name = "frmManage"
        Me.Text = "frmManage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents InfoListBox1 As ListBox
    Friend WithEvents InfoTextBox4 As TextBox
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
