Imports System.Data.Odbc
Public Class RiwayatLaporan

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
        da = New OdbcDataAdapter("select * from inventaris", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "inventaris")
        DataGridView1.DataSource = (ds.Tables("inventaris"))
    End Sub
    Private Sub RiwayatLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampildata()
    End Sub
End Class