Public Class Form_Login
    Private Sub Btn_Keluar_Click(sender As Object, e As EventArgs) Handles Btn_Keluar.Click
        Dim Pesan As Byte
        Pesan = MsgBox("Apakah anda ingin keluar dari aplikasi?", vbYesNo)
        If Pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Btn_Masuk_Click(sender As Object, e As EventArgs) Handles Btn_Masuk.Click
        If Tb_Username.Text = "" Then
            MsgBox("User tidak dapat ditemukan!")
        ElseIf Tb_Password.Text = "" Then
            MsgBox("User tidak dapat ditemukan!")
        Else
            If Tb_Username.Text = "admin" And Tb_Password.Text = "admin" Then
                Dim FR_Utama As New Form_Utama
                FR_Utama.Show()
                Me.Hide()
            Else
                MsgBox("Username atau password salah!")
            End If
        End If
    End Sub
End Class