
Public Class Login
    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        If TextBox_NimNip.Text = "" Then
            MsgBox("Nim / Nip tidak boleh kosong!!!")
        Else
            If TextBox_Password.Text = "" Then
                MsgBox("Password tidak boleh kosong!!")
            Else
                If TextBox_NimNip.Text = "tes" And TextBox_Password.Text = "tes" Then
                    Dim form2 As New MenuAdmin()
                    Me.Close()
                    form2.Show()

                End If
            End If
        End If
    End Sub
End Class
