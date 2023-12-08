Imports System.Data.Odbc
Public Class Daftar_petugas
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
    Private Sub Daftar_petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        da = New OdbcDataAdapter("select Nim_NIP, Nama_petugas, Kelas, Petugas from petugas_inventaris;", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "petugas_inventaris")
        DataGridView1.DataSource = (ds.Tables("petugas_inventaris"))
    End Sub
End Class