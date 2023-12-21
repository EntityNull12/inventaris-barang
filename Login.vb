
Imports System.Data.Odbc

Public Class Login

    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public petugas As String
    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        If TextBox_NimNip.Text = "" Then
            MsgBox("Nip tidak boleh kosong!!!")
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
                    If (rd.Read()) Then
                        MenuAdmin.Show()
                        Me.Hide()
                    Else
                        MsgBox("NIP atau Password salah")
                    End If
                End If
            End If
        End If
    End Sub
End Class
