
Imports System.Data.Odbc

Public Class Login
    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        If TextBox_NimNip.Text = "" Then
            MsgBox("Nim / Nip tidak boleh kosong!!!")
        Else
            If TextBox_Password.Text = "" Then
                MsgBox("Password tidak boleh kosong!!")
            Else
                If TextBox_NimNip.Text = "" And TextBox_Password.Text = "" Then

                    MsgBox("Mohon untuk diisi!")
                Else
                    Call koneksi()
                    cmd = New OdbcCommand("Select * from petugas_inventaris where Nim_Nip ='" & TextBox_NimNip.Text & "' and password ='" & TextBox_Password.Text & "' ", conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        Dim form2 As New MenuAdmin()
                        form2.Show()

                    Else
                        MsgBox("Nim/NIP atau Password salah!")
                    End If
                End If
                End If
        End If
    End Sub
End Class
