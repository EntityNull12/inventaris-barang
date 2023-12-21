Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BarangInventaris

    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public strcon As String
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader

    Sub koneksi()
        strcon = "Driver={MySQL ODBC 3.51 Driver};database=inventaris-sbd;server=localhost;uid=root"
        conn = New OdbcConnection(strcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub tampildata()
        koneksi()
        da = New OdbcDataAdapter("select * from barang_inventaris;", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang_inventaris")
        DataGridView1.DataSource = (ds.Tables("barang_inventaris"))
    End Sub

    Private Sub BarangInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New OdbcCommand("SELECT * FROM barang_inventaris WHERE Id_barang_inventaris = '" & TextBox1.Text & "' ", conn)
        rd = cmd.ExecuteReader

        If rd.Read Then
            TextBox1.Text = rd.Item(0)
        End If

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("isi data secara lengkap")
           
        Else
            cmd = New OdbcCommand("INSERT INTO barang_inventaris (Id_barang_inventaris, Nama_barang, Merek) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Sukses!!!")
            tampildata()
        End If

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM barang_inventaris WHERE Id_barang_inventaris = '" & TextBox1.Text & "' ", conn)
            rd = cmd.ExecuteReader

            If rd.Read Then
                TextBox1.Text = rd.Item(0)
                TextBox2.Text = rd.Item(1)
                TextBox3.Text = rd.Item(2)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = New OdbcCommand("UPDATE barang_inventaris SET Id_barang_inventaris = '" & TextBox1.Text & "', Nama_barang = '" & TextBox2.Text & "', Merek = '" & TextBox3.Text & "' WHERE Id_barang_inventaris = '" & TextBox1.Text & "' ", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Sukses!!!")
        tampildata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            cmd = New OdbcCommand("DELETE FROM barang_inventaris WHERE Id_barang_inventaris = '" & TextBox1.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Sukses!!!")
            tampildata()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah anda yakin untuk keluar dari sini?", "konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MenuAdmin.Show()
            Me.Hide()
        End If
    End Sub
End Class