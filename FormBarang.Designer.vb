<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Id_barang = New System.Windows.Forms.TextBox()
        Me.nama_barang = New System.Windows.Forms.TextBox()
        Me.merek = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 37)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Form Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Merek :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 26)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nama Barang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 26)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Id Barang :"
        '
        'Id_barang
        '
        Me.Id_barang.Location = New System.Drawing.Point(283, 134)
        Me.Id_barang.Name = "Id_barang"
        Me.Id_barang.Size = New System.Drawing.Size(320, 26)
        Me.Id_barang.TabIndex = 32
        '
        'nama_barang
        '
        Me.nama_barang.Location = New System.Drawing.Point(283, 182)
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Size = New System.Drawing.Size(320, 26)
        Me.nama_barang.TabIndex = 33
        '
        'merek
        '
        Me.merek.Location = New System.Drawing.Point(283, 228)
        Me.merek.Name = "merek"
        Me.merek.Size = New System.Drawing.Size(320, 26)
        Me.merek.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(304, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.merek)
        Me.Controls.Add(Me.nama_barang)
        Me.Controls.Add(Me.Id_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBarang"
        Me.Text = "Form Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Id_barang As TextBox
    Friend WithEvents nama_barang As TextBox
    Friend WithEvents merek As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
