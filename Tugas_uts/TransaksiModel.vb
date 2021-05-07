Public Class TransaksiModel
    Inherits Transaksi
    Public Overloads Sub store(ByVal indeks As Integer, ByVal nama As String, ByVal bayar As Integer, ByVal kembali As Integer)
        add(indeks, nama, bayar, kembali)
        index = getIndex() + 1
    End Sub
    Public Function cek(ByVal harga As Integer, ByVal bayar As Integer)
        Dim ceks As Integer = bayar - harga
        Return ceks
    End Function
End Class
