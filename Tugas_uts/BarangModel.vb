Public Class BarangModel
    Inherits Barang
    Public Overloads Sub store(ByVal kode As String, ByVal nama_barang As String, ByVal harga As Integer)
        add(kode, nama_barang, harga)
        index = getIndex() + 1
    End Sub
    Public Sub update_barang(ByVal kode As String, ByVal nama As String, ByVal harga As Integer)
        Dim cari As Integer = 0
        Do
            If (cari = getIndex()) Then
                MessageBox.Show("Data Tidak ada")
                Exit Do
            ElseIf (kode = getKode()(cari)) Then
                getKode()(cari) = kode
                getNama()(cari) = nama
                getHarga()(cari) = harga
                Exit Do
            Else
                cari = cari + 1
            End If
        Loop While True
    End Sub
    Public Sub delete_barang(ByVal kode As String)
        Dim cari As Integer = 0
        Do
            If (cari = getIndex()) Then
                MessageBox.Show("Data Tidak ada")
                Exit Do
            ElseIf (kode = getKode()(cari)) Then
                If (cari = getIndex() - 1) Then
                    index = getIndex() - 1
                Else
                    For num As Integer = cari To getIndex() - 1
                        getKode()(num) = getKode(num + 1)
                        getNama()(num) = getNama(num + 1)
                        getHarga()(num) = getHarga(num + 1)
                    Next
                    index = getIndex() - 1
                End If
                Exit Do
            Else
                cari = cari + 1
            End If
        Loop While True
    End Sub

End Class
