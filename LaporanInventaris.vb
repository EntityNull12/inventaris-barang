Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LaporanInventaris

    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public strcon As String
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Dim kondisi As String
    Dim id_item_inventaris As String

    Sub kondisiinventaris()
        If kondisi = "Baik" Then
            RadioButton1.Enabled = True
        ElseIf kondisi = "kurang Baik" Then
            RadioButton2.Enabled = True
        Else
            RadioButton3.Enabled = True
        End If
    End Sub

    Sub koneksi()
        strcon = "Driver={MySQL ODBC 3.51 Driver};database=inventaris-sbd;server=localhost;uid=root"
        conn = New OdbcConnection(strcon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub tampildata()
        koneksi()
        da = New OdbcDataAdapter("select * from laporan_inventaris;", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "laporan_inventaris")
        DataGridView2.DataSource = (ds.Tables("laporan_inventaris"))
    End Sub

    Sub tampilnamabarang()
        koneksi()
        ComboBox1.Items.Clear()
        cmd = New OdbcCommand("SELECT * FROM barang_inventaris", conn)
        rd = cmd.ExecuteReader

        While rd.Read
            ComboBox1.Items.Add(rd.Item(1))
        End While

    End Sub

    Sub tampilmerek()
        koneksi()
        ComboBox2.Items.Clear()
        cmd = New OdbcCommand("SELECT * FROM barang_inventaris", conn)
        rd = cmd.ExecuteReader

        While rd.Read
            ComboBox2.Items.Add(rd.Item(2))
        End While

    End Sub

    Sub tampilmeja()
        koneksi()
        ComboBox3.Items.Clear()

        cmd = New OdbcCommand("SELECT * FROM meja", conn)
        rd = cmd.ExecuteReader

        While rd.Read
            ComboBox3.Items.Add(rd.Item(0))
        End While

    End Sub
    Private Sub LaporanInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        tampilnamabarang()
        tampilmerek()
        tampilmeja()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New OdbcCommand("SELECT * FROM barang_inventaris WHERE Id_barang_inventaris = '" & TextBox1.Text & "' ", conn)
        rd = cmd.ExecuteReader

        If rd.Read Then
            TextBox1.Text = rd.Item(0)
        End If




        If ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MsgBox("Kosong")

        ElseIf TextBox5.Text = "" Then
            Dim keterangan As String = " "
            cmd = New OdbcCommand("INSERT INTO laporan_inventaris (Id_item_inventaris, Meja, Nama_barang, Merek, Kondisi, Keterangan) VALUES ('" & TextBox1.Text & "', '" & ComboBox3.SelectedItem & "', '" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "', '" & kondisi & "', '" & keterangan & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Sukses!!!")
            tampildata()
        Else
            cmd = New OdbcCommand("INSERT INTO laporan_inventaris (Id_item_inventaris, Meja, Nama_barang, Merek, Kondisi, Keterangan) VALUES ('" & TextBox1.Text & "', '" & ComboBox3.SelectedItem & "', '" & ComboBox1.SelectedItem & "', '" & ComboBox2.SelectedItem & "', '" & kondisi & "', '" & TextBox5.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Sukses!!!")
            tampildata()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        kondisi = "Baik"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        kondisi = "kurang Baik"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        kondisi = "Rusak"
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah anda yakin untuk keluar dari sini?", "konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MenuAdmin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cmd = New OdbcCommand("UPDATE laporan_inventaris SET Id_item_inventaris = '" & id_item_inventaris & "', Meja = '" & ComboBox3.SelectedItem & "', Nama_barang = '" & ComboBox1.SelectedItem & "', Merek = '" & ComboBox2.SelectedItem & "', Kondisi = '" & kondisi & "', Keterangan = '" & TextBox5.Text & "' WHERE Id_item_inventaris = '" & TextBox1.Text & "' ", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Sukses!!!")
        tampildata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data ini?", "Kofirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM laporan_inventaris WHERE Id_item_inventaris =  '" & TextBox1.Text & "'  ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Hapus Data sukses!")
            tampildata()
        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM laporan_inventaris WHERE Id_item_inventaris = '" & TextBox1.Text & "' ", conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                id_item_inventaris = rd.Item(0)
                ComboBox1.Text = rd.Item(2)
                ComboBox2.Text = rd.Item(3)
                ComboBox3.Text = rd.Item(1)
                kondisi = rd.Item(4)
                TextBox5.Text = rd.Item(5)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Inventaris.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tampildata()
        tampilnamabarang()
        tampilmerek()
        tampilmeja()
    End Sub


End Class