Public Class FrmLoading

    Private progressValue As Integer = 0

    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nilai awal progress
        progressValue = 0
        ProgLogin.Value = 0

        ' Jalankan timer
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Tambahkan progress
        progressValue += 3

        ' Update ForeverProgressBar
        ProgLogin.Value = progressValue

        ' Jika sudah 100%
        If progressValue >= 100 Then

            Timer1.Stop()

            ' Pindah ke form berikutnya
            Dim frm As New FormLogin()
            frm.Show()

            Me.Hide()

        End If

    End Sub

End Class