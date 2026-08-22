Imports RestSharp
Imports Newtonsoft.Json.Linq

Public Class UC_MasterData

    Private Sub UC_MasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan sapaan user yang sedang login
        lblWelcome.Text = "Selamat datang, " & FormHelper.LoggedInFullName & " (" & FormHelper.LoggedInRole & ")  |  " & DateTime.Now.ToString("dddd, dd MMMM yyyy")

        ' Muat semua data dashboard
        MuatSummary()
        MuatAktivitasTerakhir()
    End Sub

    ' ── 1. Muat Kartu Ringkasan ──────────────────────────────────────────────
    Private Sub MuatSummary()
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("/api/reports/dashboard-summary", Method.Get)
            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim json = JObject.Parse(response.Content)
                Dim data = json("data")

                lblJumTikMsk.Text = If(data("tiketMasukHariIni") IsNot Nothing, data("tiketMasukHariIni").ToString(), "0")
                lblTonMsk.Text = String.Format("{0:N0} Kg", If(data("tonaseMasuk") IsNot Nothing, Convert.ToDecimal(data("tonaseMasuk")), 0D))
                lblJumPending.Text = If(data("pendingQC") IsNot Nothing, data("pendingQC").ToString(), "0")
                lblJumTonKlr.Text = String.Format("{0:N0} Kg", If(data("tonaseKeluar") IsNot Nothing, Convert.ToDecimal(data("tonaseKeluar")), 0D))
                lblJumTotGudang.Text = String.Format("{0:N0} Kg", If(data("totalStokGudang") IsNot Nothing, Convert.ToDecimal(data("totalStokGudang")), 0D))
                lblJumSupplier.Text = If(data("supplierAktif") IsNot Nothing, data("supplierAktif").ToString(), "0")
            Else
                ' Tampilkan N/A kalau API belum aktif
                For Each lbl In {lblJumTikMsk, lblJumPending, lblJumSupplier}
                    lbl.Text = "N/A"
                Next
                For Each lbl In {lblTonMsk, lblJumTonKlr, lblJumTotGudang}
                    lbl.Text = "N/A Kg"
                Next
            End If
        Catch ex As Exception
            ' Silent fail — dashboard tidak crash jika API mati
            For Each lbl In {lblJumTikMsk, lblJumPending, lblJumSupplier}
                lbl.Text = "—"
            Next
            For Each lbl In {lblTonMsk, lblJumTonKlr, lblJumTotGudang}
                lbl.Text = "— Kg"
            Next
        End Try
    End Sub

    ' ── 2. Muat Tabel Aktivitas Terakhir ─────────────────────────────────────
    Private Sub MuatAktivitasTerakhir()
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("/api/reports/recent-activities?top=25", Method.Get)
            Dim response = client.Execute(request)

            dgvAktivitas.Columns.Clear()

            If response.IsSuccessful Then
                Dim json = JObject.Parse(response.Content)
                Dim dataArr = json("data")

                ' Definisi kolom manual agar urutan & header bisa diatur
                dgvAktivitas.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "colWaktu", .HeaderText = "Waktu", .DataPropertyName = "transactionDate"})
                dgvAktivitas.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "colTipe", .HeaderText = "Tipe", .DataPropertyName = "transactionType"})
                dgvAktivitas.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "colRef", .HeaderText = "Referensi", .DataPropertyName = "referenceNo"})
                dgvAktivitas.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "colGrade", .HeaderText = "Nama Grade", .DataPropertyName = "gradeName"})
                dgvAktivitas.Columns.Add(New DataGridViewTextBoxColumn() With {
                    .Name = "colQty", .HeaderText = "Jumlah (Kg)", .DataPropertyName = "quantity"})

                dgvAktivitas.Rows.Clear()

                For Each item In dataArr
                    Dim tipe = If(item("transactionType") IsNot Nothing, item("transactionType").ToString(), "")
                    Dim qty = If(item("quantity") IsNot Nothing, Convert.ToDecimal(item("quantity")), 0D)
                    Dim qtyStr = If(tipe = "IN", String.Format("+ {0:N0}", qty), String.Format("- {0:N0}", qty))

                    Dim dt As DateTime = DateTime.Now
                    If item("transactionDate") IsNot Nothing Then dt = Convert.ToDateTime(item("transactionDate"))

                    Dim rowIdx = dgvAktivitas.Rows.Add(
                        dt.ToString("HH:mm dd/MM"),
                        tipe,
                        If(item("referenceNo") IsNot Nothing, item("referenceNo").ToString(), ""),
                        If(item("gradeName") IsNot Nothing, item("gradeName").ToString(), ""),
                        qtyStr
                    )

                    ' Warnai baris IN vs OUT
                    If tipe = "IN" Then
                        dgvAktivitas.Rows(rowIdx).DefaultCellStyle.ForeColor = System.Drawing.Color.LightGreen
                    Else
                        dgvAktivitas.Rows(rowIdx).DefaultCellStyle.ForeColor = System.Drawing.Color.Salmon
                    End If
                Next
            Else
                ' Tampilkan pesan kalau kosong
                dgvAktivitas.Columns.Add("info", "Info")
                dgvAktivitas.Rows.Add("Tidak ada data aktivitas atau API belum aktif.")
            End If
        Catch ex As Exception
            ' Silent fail
            dgvAktivitas.Columns.Clear()
            dgvAktivitas.Columns.Add("info", "Info")
            dgvAktivitas.Rows.Add("Gagal memuat aktivitas: " & ex.Message)
        End Try
    End Sub

    Private Sub UC_MasterData_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            MuatSummary()
            MuatAktivitasTerakhir()
        End If
    End Sub

    Private Sub TimerJam_Tick(sender As Object, e As EventArgs) Handles TimerJam.Tick
        lblJamTanggal.Text = DateTime.Now.ToString(" HH:mm:ss")
    End Sub
End Class

