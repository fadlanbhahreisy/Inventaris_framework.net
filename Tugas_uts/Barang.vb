Public Class Barang
    Public kode(100) As String
    Public nama(100) As String
    Public harga(100) As Integer
    Public index As Integer = 0

    Public Sub add(ByVal kode As String, ByVal nama As String, ByVal harga As Integer)
        Me.kode(index) = kode
        Me.nama(index) = nama
        Me.harga(index) = harga
    End Sub

    Public Function getKode()
        Return kode
    End Function
    Public Function getNama()
        Return nama
    End Function

    Public Function getHarga()
        Return harga
    End Function

    Public Function getIndex()
        Return index
    End Function
End Class
