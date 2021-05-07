Public Class Form1
    Dim Bar = New BarangModel()
    Dim tran = New TransaksiModel()
    Dim index As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView.GridLines = True
        ListView.View = View.Details
        ListView.Columns.Add("No")
        ListView.Columns.Add("Kode Barang", 155)
        ListView.Columns.Add("Nama Barang", 155)
        ListView.Columns.Add("Harga", 155)
        KodeText.Text = String.Concat("bar", Bar.getIndex() + 1)
        NamaTran.ReadOnly = True
        HargaTran.ReadOnly = True
        ListTransaksi.GridLines = True
        ListTransaksi.View = View.Details
        ListTransaksi.Columns.Add("No")
        ListTransaksi.Columns.Add("Kode Barang", 155)
        ListTransaksi.Columns.Add("Nama Barang", 155)
        ListTransaksi.Columns.Add("Harga", 155)
        ListTransaksi.Columns.Add("Nama Pembeli", 155)
        ListTransaksi.Columns.Add("Bayar", 155)
        ListTransaksi.Columns.Add("Kembali", 155)
        data_statis()
    End Sub
    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        ListView.Items.Clear()
        Dim kode As String
        Dim nama As String
        Dim harga As Integer
        kode = KodeText.Text
        nama = NamaText.Text
        harga = HargaText.Text
        Bar.store(kode, nama, harga)
        tampil()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        ListView.Items.Clear()
        Dim search As String
        Dim nama As String
        Dim harga As String
        search = KodeText.Text
        nama = NamaText.Text
        harga = HargaText.Text
        Bar.update_barang(search, nama, harga)
        tampil()
    End Sub

    Private Sub Btndel_Click(sender As Object, e As EventArgs) Handles Btndel.Click
        ListView.Items.Clear()
        Dim kode As String
        kode = hapus.Text
        Bar.delete_barang(kode)
        tampil()
        hapus.Text = ""
    End Sub

    Sub tampil()
        Dim list_item As ListViewItem
        list_item = New ListViewItem
        For num As Integer = 0 To Bar.getIndex() - 1
            list_item = ListView.Items.Add(num + 1)
            list_item.SubItems.Add(Bar.getKode()(num))
            list_item.SubItems.Add(Bar.getNama()(num))
            list_item.SubItems.Add(Bar.getHarga()(num))
        Next

        KodeText.Text = String.Concat("bar", Bar.getIndex() + 1)
        NamaText.Text = ""
        HargaText.Text = ""
        NamaText.Focus()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim kode As String
        Dim indexBarang As Integer
        Dim oComp As New CaseInsensitiveComparer
        kode = KodeTran.Text
        indexBarang = Array.BinarySearch(Bar.getKode(), kode, oComp)
        For num As Integer = 0 To Bar.getIndex() - 1
            If (kode = Bar.getKode()(num)) Then
                indexBarang = num
            End If
        Next
        NamaTran.Text = Bar.getNama()(indexBarang)
        HargaTran.Text = Bar.getHarga()(indexBarang)
        index = indexBarang
    End Sub
    Public Sub data_statis()
        Dim kode() As String = {"bar1", "bar2", "bar3", "bar4", "bar5", "bar6", "bar7", "bar8", "bar9", "bar10",
            "bar11", "bar12", "bar13", "bar14", "bar15", "bar16", "bar17", "bar18", "bar19", "bar20"}
        Dim nama() As String = {"tv", "radio", "laptop", "printer", "monitor", "mouse", "keyboard", "flashdisk", "ssd", "hdd",
            "mouse pad", "motherboard", "cpu", "gpu", "headphone", "smarthphone", "case", "charger", "sd card", "kulkas"}
        Dim harga() As Integer = {"5000000", "500000", "8000000", "1000000", "3000000", "200000", "1500000", "100000", "500000", "300000",
            "50000", "4000000", "7000000", "9000000", "300000", "2400000", "20000", "40000", "60000", "6500000"}
        For num As Integer = 0 To kode.Length - 1
            Bar.store(kode(num), nama(num), harga(num))
        Next
        tampil()
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        Dim cek As Integer
        Dim harga As Integer
        Dim bayar As Integer
        harga = HargaTran.Text
        bayar = BayarText.Text
        cek = tran.cek(harga, bayar)
        If (cek < 0) Then
            MessageBox.Show("Maaf Uang anda kurang")
        Else
            KembaliText.Text = cek
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        ListTransaksi.Items.Clear()
        Dim indeks As Integer
        Dim nama As String
        Dim bayar As Integer
        Dim kembali As Integer
        indeks = index
        nama = NamaPelanggan.Text
        bayar = BayarText.Text
        kembali = KembaliText.Text
        tran.store(indeks, nama, bayar, kembali)
        tampil_transaksi()
    End Sub
    Sub tampil_transaksi()
        Dim list_item As ListViewItem
        list_item = New ListViewItem
        For num As Integer = 0 To tran.getIndex() - 1
            list_item = ListTransaksi.Items.Add(num + 1)
            list_item.SubItems.Add(Bar.getKode()(tran.getIndexBarang()(num)))
            list_item.SubItems.Add(Bar.getNama()(tran.getIndexBarang()(num)))
            list_item.SubItems.Add(Bar.getHarga()(tran.getIndexBarang()(num)))
            list_item.SubItems.Add(tran.getNamaPembeli()(num))
            list_item.SubItems.Add(tran.getBayar()(num))
            list_item.SubItems.Add(tran.getKembali()(num))
        Next
        KodeTran.Text = ""
        NamaTran.Text = ""
        HargaTran.Text = ""
        NamaPelanggan.Text = ""
        BayarText.Text = ""
        KembaliText.Text = ""
    End Sub
End Class
