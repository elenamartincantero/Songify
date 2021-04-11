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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdDB
        '
        Me.ofdDB.FileName = "OpenFileDialog1"
        '
        'LoginBox
        '
        Me.LoginBox.Location = New System.Drawing.Point(105, 174)
        Me.LoginBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(324, 22)
        Me.LoginBox.TabIndex = 0
        '
        'DatabaseButton
        '
        Me.DatabaseButton.Location = New System.Drawing.Point(51, 235)
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
        Me.LoginButton.Location = New System.Drawing.Point(352, 235)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(115, 49)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Log in"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 303)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Songify! Please select the database and log in"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 138)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(527, 342)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.DatabaseButton)
        Me.Controls.Add(Me.LoginBox)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
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
End Class
