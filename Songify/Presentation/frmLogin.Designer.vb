﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.ofdDB = New System.Windows.Forms.OpenFileDialog()
        Me.LoginBox = New System.Windows.Forms.TextBox()
        Me.DatabaseButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ofdDB
        '
        Me.ofdDB.FileName = "OpenFileDialog1"
        Me.ofdDB.Filter = """MS Database .accdb | *.accdb"""
        '
        'LoginBox
        '
        Me.LoginBox.Location = New System.Drawing.Point(44, 112)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(284, 23)
        Me.LoginBox.TabIndex = 0
        '
        'DatabaseButton
        '
        Me.DatabaseButton.Location = New System.Drawing.Point(44, 167)
        Me.DatabaseButton.Name = "DatabaseButton"
        Me.DatabaseButton.Size = New System.Drawing.Size(101, 49)
        Me.DatabaseButton.TabIndex = 1
        Me.DatabaseButton.Text = "Choose Database"
        Me.DatabaseButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(228, 167)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(100, 46)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Log in"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.DatabaseButton)
        Me.Controls.Add(Me.LoginBox)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofdDB As OpenFileDialog
    Friend WithEvents LoginBox As TextBox
    Friend WithEvents DatabaseButton As Button
    Friend WithEvents LoginButton As Button
End Class
