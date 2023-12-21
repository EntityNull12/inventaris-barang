Public Class MenuAdmin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Daftar_petugas.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BarangInventaris.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LaporanInventaris.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RiwayatLaporan.Show()
        Me.Hide()
    End Sub

End Class