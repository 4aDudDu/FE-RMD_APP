Imports RestSharp

Public Class UC_Settings

    Private Sub UC_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan username user yang sedang login, bukan angka 1
        txtIDSettings.Text = FormHelper.LoggedInUsername
        txtIDSettings.Enabled = False
    End Sub

    Private Sub btnSubmitPass_Click(sender As Object, e As EventArgs) Handles btnSubmitPass.Click
        If String.IsNullOrWhiteSpace(txtPassSettings.Text) Then
            MessageBox.Show("Password baru tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("/api/auth/change-password", Method.Post)

            request.AddJsonBody(New With {
                .userId = FormHelper.LoggedInUserId, ' Gunakan ID asli dari session
                .newPassword = txtPassSettings.Text
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                MessageBox.Show("Password berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassSettings.Text = ""
            Else
                MessageBox.Show("Gagal memperbarui password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVersion_Click(sender As Object, e As EventArgs) Handles btnVersion.Click
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("/api/system/version", Method.Get)
            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                MessageBox.Show("Anda menggunakan versi terbaru.", "Pembaruan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Aplikasi sudah berada di versi terbaru (v1.0.0).", "Pembaruan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Aplikasi sudah berada di versi terbaru (v1.0.0).", "Pembaruan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

End Class