Imports RestSharp
Imports Newtonsoft.Json.Linq

Public Class FormLogin

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ExitApplication()
    End Sub

    Private Sub txtIdLogin_TextChanged(sender As Object, e As EventArgs) Handles txtIdLogin.TextChanged
    End Sub

    Private Sub txtPassLogin_TextChanged(sender As Object, e As EventArgs) Handles txtPassLogin.TextChanged
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtIdLogin.Text = "" Or txtPassLogin.Text = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        btnLogin.Text = "Loading..."
        btnLogin.Enabled = False

        Try
            Dim client = GetApiClient()
            Dim request = New RestRequest("api/Auth/login", Method.Post)

            request.AddJsonBody(New With {
                .username = txtIdLogin.Text,
                .password = txtPassLogin.Text
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                'MessageBox.Show(response.Content, "hasil json")
                Dim json = JObject.Parse(response.Content)

                Dim isSuccess As Boolean = False
                If json("success") IsNot Nothing Then
                    isSuccess = json("success").Value(Of Boolean)()
                End If

                If isSuccess Then
                    If json("data") IsNot Nothing Then
                        Dim userId = If(json("data")("id") IsNot Nothing, Convert.ToInt32(json("data")("id")), 1)
                        Dim username = If(json("data")("username") IsNot Nothing, json("data")("username").ToString(), "user")
                        Dim fullName = If(json("data")("fullName") IsNot Nothing, json("data")("fullName").ToString(), "User")
                        Dim roleName = If(json("data")("roleName") IsNot Nothing, json("data")("roleName").ToString(), "Unknown")

                        ' Simpan sesi ke FormHelper
                        FormHelper.LoggedInUserId = userId
                        FormHelper.LoggedInUsername = username
                        FormHelper.LoggedInFullName = fullName
                        FormHelper.LoggedInRole = roleName

                        MessageBox.Show("Selamat Datang, " & fullName & vbCrLf & "Role: " & roleName, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        FormDashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Login berhasil, tapi format data tidak sesuai.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Dim errorMsg = If(json("message") IsNot Nothing, json("message").ToString(), "Login gagal.")
                    MessageBox.Show(errorMsg, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If response.StatusCode = Net.HttpStatusCode.Unauthorized Then
                    MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Gagal terhubung ke Server API. Status: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnLogin.Text = "LOGIN"
            btnLogin.Enabled = True
        End Try
    End Sub

End Class