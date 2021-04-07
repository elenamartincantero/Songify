<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ManageButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.StatisticsButton = New System.Windows.Forms.Button()
        Me.ChangeUserButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ManageButton
        '
        Me.ManageButton.Location = New System.Drawing.Point(123, 55)
        Me.ManageButton.Name = "ManageButton"
        Me.ManageButton.Size = New System.Drawing.Size(162, 74)
        Me.ManageButton.TabIndex = 0
        Me.ManageButton.Text = "Manage Data"
        Me.ManageButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(123, 166)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(168, 72)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search a song"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'StatisticsButton
        '
        Me.StatisticsButton.Location = New System.Drawing.Point(123, 268)
        Me.StatisticsButton.Name = "StatisticsButton"
        Me.StatisticsButton.Size = New System.Drawing.Size(168, 91)
        Me.StatisticsButton.TabIndex = 2
        Me.StatisticsButton.Text = "Statistics"
        Me.StatisticsButton.UseVisualStyleBackColor = True
        '
        'ChangeUserButton
        '
        Me.ChangeUserButton.Location = New System.Drawing.Point(10, 10)
        Me.ChangeUserButton.Name = "ChangeUserButton"
        Me.ChangeUserButton.Size = New System.Drawing.Size(117, 29)
        Me.ChangeUserButton.TabIndex = 3
        Me.ChangeUserButton.Text = "Change User"
        Me.ChangeUserButton.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChangeUserButton)
        Me.Controls.Add(Me.StatisticsButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ManageButton)
        Me.Name = "frmMainMenu"
        Me.Text = "frmMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManageButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents StatisticsButton As Button
    Friend WithEvents ChangeUserButton As Button
End Class
