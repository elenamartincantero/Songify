﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoggedUserLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManageButton
        '
        Me.ManageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageButton.Location = New System.Drawing.Point(69, 230)
        Me.ManageButton.Name = "ManageButton"
        Me.ManageButton.Size = New System.Drawing.Size(157, 50)
        Me.ManageButton.TabIndex = 0
        Me.ManageButton.Text = "Manage Data"
        Me.ManageButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(309, 230)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(157, 50)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search a song"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'StatisticsButton
        '
        Me.StatisticsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.969231!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatisticsButton.Location = New System.Drawing.Point(543, 230)
        Me.StatisticsButton.Name = "StatisticsButton"
        Me.StatisticsButton.Size = New System.Drawing.Size(157, 50)
        Me.StatisticsButton.TabIndex = 2
        Me.StatisticsButton.Text = "Statistics"
        Me.StatisticsButton.UseVisualStyleBackColor = True
        '
        'ChangeUserButton
        '
        Me.ChangeUserButton.Location = New System.Drawing.Point(566, 306)
        Me.ChangeUserButton.Name = "ChangeUserButton"
        Me.ChangeUserButton.Size = New System.Drawing.Size(134, 31)
        Me.ChangeUserButton.TabIndex = 3
        Me.ChangeUserButton.Text = "Change User"
        Me.ChangeUserButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Songify.My.Resources.Resources.songify
        Me.PictureBox1.Location = New System.Drawing.Point(54, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(628, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LoggedUserLbl
        '
        Me.LoggedUserLbl.AutoSize = True
        Me.LoggedUserLbl.Location = New System.Drawing.Point(347, 313)
        Me.LoggedUserLbl.Name = "LoggedUserLbl"
        Me.LoggedUserLbl.Size = New System.Drawing.Size(49, 16)
        Me.LoggedUserLbl.TabIndex = 5
        Me.LoggedUserLbl.Text = "Label1"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 347)
        Me.Controls.Add(Me.LoggedUserLbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChangeUserButton)
        Me.Controls.Add(Me.StatisticsButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ManageButton)
        Me.Name = "frmMainMenu"
        Me.Text = "frmMainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ManageButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents StatisticsButton As Button
    Friend WithEvents ChangeUserButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoggedUserLbl As Label
End Class
