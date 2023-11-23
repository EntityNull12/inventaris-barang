Imports System.Data.Odbc
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

    Private Sub BarangInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        da = New OdbcDataAdapter("select * from barang_inventaris;", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang_inventaris")
        DataGridView1.DataSource = (ds.Tables("barang_inventaris"))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class