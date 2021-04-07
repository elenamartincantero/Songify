<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        '
        'LoginBox
        '
        Me.LoginBox.Location = New System.Drawing.Point(51, 119)
        Me.LoginBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(324, 22)
        Me.LoginBox.TabIndex = 0
        '
        'DatabaseButton
        '
        Me.DatabaseButton.Location = New System.Drawing.Point(51, 178)
        Me.DatabaseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatabaseButton.Name = "DatabaseButton"
        Me.DatabaseButton.Size = New System.Drawing.Size(116, 52)
        Me.DatabaseButton.TabIndex = 1
        Me.DatabaseButton.Text = "Choose Database"
        Me.DatabaseButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Enabled = False
        Me.LoginButton.Location = New System.Drawing.Point(260, 178)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(115, 49)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Log in"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 480)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.DatabaseButton)
        Me.Controls.Add(Me.LoginBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
