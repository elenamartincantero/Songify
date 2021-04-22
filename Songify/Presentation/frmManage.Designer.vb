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
        Me.DataTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.InfoLabel2 = New System.Windows.Forms.Label()
        Me.InfoLabel3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.InfoTextBox2 = New System.Windows.Forms.TextBox()
        Me.InfoTextBox3 = New System.Windows.Forms.TextBox()
        Me.InfoListBox = New System.Windows.Forms.ListBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.SelectionComboBox = New System.Windows.Forms.ComboBox()
        Me.ImageFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InsertButton
        '
        Me.InsertButton.Enabled = False
        Me.InsertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertButton.Location = New System.Drawing.Point(496, 322)
        Me.InsertButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(72, 53)
        Me.InsertButton.TabIndex = 0
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(496, 392)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(72, 53)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(572, 392)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(72, 53)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'DataTypeComboBox
        '
        Me.DataTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTypeComboBox.FormattingEnabled = True
        Me.DataTypeComboBox.Items.AddRange(New Object() {"Users", "Songs", "Albums", "Artists"})
        Me.DataTypeComboBox.Location = New System.Drawing.Point(26, 28)
        Me.DataTypeComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataTypeComboBox.Name = "DataTypeComboBox"
        Me.DataTypeComboBox.Size = New System.Drawing.Size(229, 28)
        Me.DataTypeComboBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(236, 87)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(48, 18)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.NameLabel.Visible = False
        '
        'InfoLabel2
        '
        Me.InfoLabel2.AutoSize = True
        Me.InfoLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLabel2.Location = New System.Drawing.Point(236, 129)
        Me.InfoLabel2.Name = "InfoLabel2"
        Me.InfoLabel2.Size = New System.Drawing.Size(51, 18)
        Me.InfoLabel2.TabIndex = 5
        Me.InfoLabel2.Text = "Label2"
        Me.InfoLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.InfoLabel2.Visible = False
        '
        'InfoLabel3
        '
        Me.InfoLabel3.AutoSize = True
        Me.InfoLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLabel3.Location = New System.Drawing.Point(236, 168)
        Me.InfoLabel3.Name = "InfoLabel3"
        Me.InfoLabel3.Size = New System.Drawing.Size(51, 18)
        Me.InfoLabel3.TabIndex = 6
        Me.InfoLabel3.Text = "Label3"
        Me.InfoLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.InfoLabel3.Visible = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(351, 85)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(293, 26)
        Me.NameTextBox.TabIndex = 8
        Me.NameTextBox.Visible = False
        '
        'InfoTextBox2
        '
        Me.InfoTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoTextBox2.Location = New System.Drawing.Point(351, 124)
        Me.InfoTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InfoTextBox2.Name = "InfoTextBox2"
        Me.InfoTextBox2.Size = New System.Drawing.Size(293, 26)
        Me.InfoTextBox2.TabIndex = 9
        Me.InfoTextBox2.Visible = False
        '
        'InfoTextBox3
        '
        Me.InfoTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoTextBox3.Location = New System.Drawing.Point(351, 164)
        Me.InfoTextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InfoTextBox3.Name = "InfoTextBox3"
        Me.InfoTextBox3.Size = New System.Drawing.Size(293, 26)
        Me.InfoTextBox3.TabIndex = 10
        Me.InfoTextBox3.Visible = False
        '
        'InfoListBox
        '
        Me.InfoListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoListBox.FormattingEnabled = True
        Me.InfoListBox.ItemHeight = 20
        Me.InfoListBox.Location = New System.Drawing.Point(26, 87)
        Me.InfoListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InfoListBox.Name = "InfoListBox"
        Me.InfoListBox.Size = New System.Drawing.Size(200, 384)
        Me.InfoListBox.TabIndex = 13
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(487, 22)
        Me.MainMenuButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(157, 35)
        Me.MainMenuButton.TabIndex = 14
        Me.MainMenuButton.Text = "Return to main menu"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(572, 322)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(72, 53)
        Me.ClearButton.TabIndex = 15
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DateBox
        '
        Me.DateBox.CustomFormat = "dd/mm/yyyy"
        Me.DateBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateBox.Location = New System.Drawing.Point(351, 205)
        Me.DateBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(293, 26)
        Me.DateBox.TabIndex = 18
        Me.DateBox.Value = New Date(2021, 4, 14, 18, 14, 42, 0)
        Me.DateBox.Visible = False
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(236, 210)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(39, 18)
        Me.DateLabel.TabIndex = 19
        Me.DateLabel.Text = "Date"
        Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.DateLabel.Visible = False
        '
        'SelectionComboBox
        '
        Me.SelectionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.861538!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectionComboBox.FormattingEnabled = True
        Me.SelectionComboBox.Location = New System.Drawing.Point(351, 164)
        Me.SelectionComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectionComboBox.Name = "SelectionComboBox"
        Me.SelectionComboBox.Size = New System.Drawing.Size(293, 28)
        Me.SelectionComboBox.TabIndex = 20
        Me.SelectionComboBox.Visible = False
        '
        'ImageFileDialog
        '
        Me.ImageFileDialog.Filter = "(Picture | *jpg, *.jpeg, *.png)"
        '
        'ImageButton
        '
        Me.ImageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageButton.Location = New System.Drawing.Point(256, 245)
        Me.ImageButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(120, 33)
        Me.ImageButton.TabIndex = 21
        Me.ImageButton.Text = "Button1"
        Me.ImageButton.UseVisualStyleBackColor = True
        Me.ImageButton.Visible = False
        '
        'ImageBox
        '
        Me.ImageBox.Location = New System.Drawing.Point(249, 296)
        Me.ImageBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(181, 177)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageBox.TabIndex = 16
        Me.ImageBox.TabStop = False
        Me.ImageBox.Visible = False
        '
        'frmManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 510)
        Me.Controls.Add(Me.ImageButton)
        Me.Controls.Add(Me.SelectionComboBox)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.DateBox)
        Me.Controls.Add(Me.ImageBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Controls.Add(Me.InfoListBox)
        Me.Controls.Add(Me.InfoTextBox3)
        Me.Controls.Add(Me.InfoTextBox2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.InfoLabel3)
        Me.Controls.Add(Me.InfoLabel2)
        Me.Controls.Add(Me.DataTypeComboBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.753846!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmManage"
        Me.Text = "Songify - Manage data"
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InsertButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents DataTypeComboBox As ComboBox
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
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents DateBox As DateTimePicker
    Friend WithEvents DateLabel As Label
    Friend WithEvents SelectionComboBox As ComboBox
    Friend WithEvents ImageFileDialog As OpenFileDialog
    Friend WithEvents ImageButton As Button
End Class
