Public Class Transaksi
    Public indexbarang(100) As Integer
    Public index As Integer = 0
    Public nama_pembeli(100) As String
    Public bayar(100) As Integer
    Public kembali(100) As Integer

    Public Sub add(ByVal indeks As Integer, ByVal nama As String, ByVal bayar As Integer, ByVal kembali As Integer)
        Me.indexbarang(index) = indeks
        Me.nama_pembeli(index) = nama
        Me.bayar(index) = bayar
        Me.kembali(index) = kembali
    End Sub
    Public Function getIndexBarang()
        Return indexbarang
    End Function
    Public Function getNamaPembeli()
        Return nama_pembeli
    End Function
    Public Function getBayar()
        Return bayar
    End Function
    Public Function getKembali()
        Return kembali
    End Function
    Public Function getIndex()
        Return index
    End Function

End Class
