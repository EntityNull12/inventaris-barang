Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Public Class Inventaris

    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public strcon As String
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Dim kondisi As String
    Dim id_item_inventaris As String

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
        DataGridView1.DataSource = (ds.Tables("laporan_inventaris"))
    End Sub

    Sub petugas()
        koneksi()
        ComboBox1.Items.Clear()
        cmd = New OdbcCommand("SELECT * FROM petugas_inventaris", conn)
        rd = cmd.ExecuteReader

        While rd.Read
            If rd.Item(4) = "Petugas" Then
                ComboBox1.Items.Add(rd.Item(1))
            End If
        End While

    End Sub


    Private Sub Inventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        petugas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Isi Petugas!")
        Else
            If MessageBox.Show("Apakah Anda Yakin untuk Menyimpan ini? Setelah menyimpan, tindakan ini tidak bisa di kembalikan", "Kofirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
                PrintPreviewDialog1.ShowDialog()
                koneksi()
                cmd = New OdbcCommand("INSERT INTO inventaris (Id_Inventaris,Tanggal_inventaris, Petugas) VALUES ('" & TextBox1.Text & "','" & DateTimePicker1.Value & "','" & ComboBox1.SelectedItem & "')", conn)
                cmd.ExecuteNonQuery()
                cmd = New OdbcCommand("DELETE FROM laporan_inventaris", conn)
                cmd.ExecuteNonQuery()
                MsgBox("sukses!")


            End If
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim image As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(image, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(image, 100, 200)
        e.Graphics.DrawString(ComboBox1.SelectedItem + " - " + DateTimePicker1.Value, New Font("Arial", 12), Brushes.Black, 0, 0)
    End Sub


End Class