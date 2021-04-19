<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ofdDB = New System.Windows.Forms.OpenFileDialog()
        Me.LoginBox = New System.Windows.Forms.TextBox()
        Me.DatabaseButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdDB
        '
        Me.ofdDB.FileName = "OpenFileDialog1"
        Me.ofdDB.Filter = "MS Database | *accdb"
        '
        'LoginBox
        '
        Me.LoginBox.Enabled = False
        Me.LoginBox.Location = New System.Drawing.Point(79, 141)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(244, 20)
        Me.LoginBox.TabIndex = 0
        '
        'DatabaseButton
        '
        Me.DatabaseButton.Location = New System.Drawing.Point(38, 191)
        Me.DatabaseButton.Name = "DatabaseButton"
        Me.DatabaseButton.Size = New System.Drawing.Size(87, 42)
        Me.DatabaseButton.TabIndex = 1
        Me.DatabaseButton.Text = "Choose Database"
        Me.DatabaseButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Enabled = False
        Me.LoginButton.Location = New System.Drawing.Point(264, 191)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(86, 40)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Log in"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Songify! Please select the database and log in"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 112)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ConnectButton
        '
        Me.ConnectButton.Enabled = False
        Me.ConnectButton.Location = New System.Drawing.Point(159, 191)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 42)
        Me.ConnectButton.TabIndex = 5
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(395, 278)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.DatabaseButton)
        Me.Controls.Add(Me.LoginBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.Text = "Songify - Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginBox As TextBox
    Friend WithEvents DatabaseButton As Button
    Friend WithEvents LoginButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ofdDB As OpenFileDialog
    Friend WithEvents ConnectButton As Button
End Class
