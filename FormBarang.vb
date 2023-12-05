Imports System.Data.Odbc

Public Class FormBarang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        Dim query As String = "INSERT INTO barang_inventaris (Id_barang_inventaris,Nama_barang,Merk) VALUES ('" & Id_barang.Text & "', '" & nama_barang.Text & "', '" & merek.Text & "')"
        
    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class