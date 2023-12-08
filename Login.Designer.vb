<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.judul = New System.Windows.Forms.Label()
        Me.TextBox_NimNip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_login = New System.Windows.Forms.Button()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.judul.Location = New System.Drawing.Point(115, 69)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(110, 40)
        Me.judul.TabIndex = 0
        Me.judul.Text = "Login"
        '
        'TextBox_NimNip
        '
        Me.TextBox_NimNip.Location = New System.Drawing.Point(422, 104)
        Me.TextBox_NimNip.Name = "TextBox_NimNip"
        Me.TextBox_NimNip.Size = New System.Drawing.Size(297, 26)
        Me.TextBox_NimNip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIM/NIP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Button_login
        '
        Me.Button_login.Location = New System.Drawing.Point(412, 230)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(307, 34)
        Me.Button_login.TabIndex = 5
        Me.Button_login.Text = "Login"
        Me.Button_login.UseVisualStyleBackColor = True
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(422, 182)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(297, 26)
        Me.TextBox_Password.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.inventaris_barang.My.Resources.Resources.logo_polman__3_
        Me.PictureBox1.Location = New System.Drawing.Point(85, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 204)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_NimNip)
        Me.Controls.Add(Me.judul)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents judul As Label
    Friend WithEvents TextBox_NimNip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_login As Button
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
