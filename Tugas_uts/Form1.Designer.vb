<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Save = New System.Windows.Forms.Button()
        Me.ListTransaksi = New System.Windows.Forms.ListView()
        Me.check = New System.Windows.Forms.Button()
        Me.KembaliText = New System.Windows.Forms.TextBox()
        Me.BayarText = New System.Windows.Forms.TextBox()
        Me.NamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        Me.HargaTran = New System.Windows.Forms.TextBox()
        Me.NamaTran = New System.Windows.Forms.TextBox()
        Me.KodeTran = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KodeText = New System.Windows.Forms.TextBox()
        Me.Btndel = New System.Windows.Forms.Button()
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.HargaText = New System.Windows.Forms.TextBox()
        Me.NamaText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(935, 449)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.Save)
        Me.TabPage1.Controls.Add(Me.ListTransaksi)
        Me.TabPage1.Controls.Add(Me.check)
        Me.TabPage1.Controls.Add(Me.KembaliText)
        Me.TabPage1.Controls.Add(Me.BayarText)
        Me.TabPage1.Controls.Add(Me.NamaPelanggan)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Search)
        Me.TabPage1.Controls.Add(Me.HargaTran)
        Me.TabPage1.Controls.Add(Me.NamaTran)
        Me.TabPage1.Controls.Add(Me.KodeTran)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(927, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaksi"
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.LawnGreen
        Me.Save.Location = New System.Drawing.Point(798, 124)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 15
        Me.Save.Text = "Simpan"
        Me.Save.UseVisualStyleBackColor = False
        '
        'ListTransaksi
        '
        Me.ListTransaksi.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ListTransaksi.HideSelection = False
        Me.ListTransaksi.Location = New System.Drawing.Point(0, 153)
        Me.ListTransaksi.Name = "ListTransaksi"
        Me.ListTransaksi.Size = New System.Drawing.Size(924, 267)
        Me.ListTransaksi.TabIndex = 14
        Me.ListTransaksi.UseCompatibleStateImageBehavior = False
        '
        'check
        '
        Me.check.BackColor = System.Drawing.Color.LawnGreen
        Me.check.Location = New System.Drawing.Point(798, 42)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(75, 23)
        Me.check.TabIndex = 13
        Me.check.Text = "Cek"
        Me.check.UseVisualStyleBackColor = False
        '
        'KembaliText
        '
        Me.KembaliText.Location = New System.Drawing.Point(612, 80)
        Me.KembaliText.Name = "KembaliText"
        Me.KembaliText.Size = New System.Drawing.Size(161, 23)
        Me.KembaliText.TabIndex = 12
        '
        'BayarText
        '
        Me.BayarText.Location = New System.Drawing.Point(613, 42)
        Me.BayarText.Name = "BayarText"
        Me.BayarText.Size = New System.Drawing.Size(160, 23)
        Me.BayarText.TabIndex = 11
        '
        'NamaPelanggan
        '
        Me.NamaPelanggan.Location = New System.Drawing.Point(613, 10)
        Me.NamaPelanggan.Name = "NamaPelanggan"
        Me.NamaPelanggan.Size = New System.Drawing.Size(160, 23)
        Me.NamaPelanggan.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(505, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Kembali"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(505, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(505, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nama Pelanggan"
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LawnGreen
        Me.Search.Location = New System.Drawing.Point(315, 10)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(71, 23)
        Me.Search.TabIndex = 6
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = False
        '
        'HargaTran
        '
        Me.HargaTran.Location = New System.Drawing.Point(107, 77)
        Me.HargaTran.Name = "HargaTran"
        Me.HargaTran.Size = New System.Drawing.Size(157, 23)
        Me.HargaTran.TabIndex = 5
        '
        'NamaTran
        '
        Me.NamaTran.Location = New System.Drawing.Point(107, 43)
        Me.NamaTran.Name = "NamaTran"
        Me.NamaTran.Size = New System.Drawing.Size(157, 23)
        Me.NamaTran.TabIndex = 4
        '
        'KodeTran
        '
        Me.KodeTran.Location = New System.Drawing.Point(107, 10)
        Me.KodeTran.Name = "KodeTran"
        Me.KodeTran.Size = New System.Drawing.Size(157, 23)
        Me.KodeTran.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kode Barang"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.KodeText)
        Me.TabPage2.Controls.Add(Me.Btndel)
        Me.TabPage2.Controls.Add(Me.Btnupdate)
        Me.TabPage2.Controls.Add(Me.hapus)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Btnadd)
        Me.TabPage2.Controls.Add(Me.HargaText)
        Me.TabPage2.Controls.Add(Me.NamaText)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.ListView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(927, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inventaris"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Harga"
        '
        'KodeText
        '
        Me.KodeText.Location = New System.Drawing.Point(269, 11)
        Me.KodeText.Name = "KodeText"
        Me.KodeText.Size = New System.Drawing.Size(185, 23)
        Me.KodeText.TabIndex = 10
        '
        'Btndel
        '
        Me.Btndel.BackColor = System.Drawing.Color.Red
        Me.Btndel.Location = New System.Drawing.Point(653, 104)
        Me.Btndel.Name = "Btndel"
        Me.Btndel.Size = New System.Drawing.Size(63, 23)
        Me.Btndel.TabIndex = 9
        Me.Btndel.Text = "Delete"
        Me.Btndel.UseVisualStyleBackColor = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.LawnGreen
        Me.Btnupdate.Location = New System.Drawing.Point(379, 150)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.Btnupdate.TabIndex = 8
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(603, 60)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(170, 23)
        Me.hapus.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kode Barang"
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.LawnGreen
        Me.Btnadd.Location = New System.Drawing.Point(269, 150)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(75, 23)
        Me.Btnadd.TabIndex = 5
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'HargaText
        '
        Me.HargaText.Location = New System.Drawing.Point(268, 101)
        Me.HargaText.Name = "HargaText"
        Me.HargaText.Size = New System.Drawing.Size(186, 23)
        Me.HargaText.TabIndex = 4
        '
        'NamaText
        '
        Me.NamaText.Location = New System.Drawing.Point(269, 52)
        Me.NamaText.Name = "NamaText"
        Me.NamaText.Size = New System.Drawing.Size(185, 23)
        Me.NamaText.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Barang"
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(127, 193)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(655, 232)
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 447)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents HargaText As TextBox
    Friend WithEvents NamaText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView As ListView
    Friend WithEvents Btnadd As Button
    Friend WithEvents n As Button
    Friend WithEvents Btnupdate As Button
    Friend WithEvents hapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents del As Button
    Friend WithEvents Btndel As Button
    Friend WithEvents har As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents KodeText As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents HargaTran As TextBox
    Friend WithEvents NamaTran As TextBox
    Friend WithEvents KodeTran As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents KembaliText As TextBox
    Friend WithEvents BayarText As TextBox
    Friend WithEvents NamaPelanggan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListTransaksi As ListView
    Friend WithEvents check As Button
    Friend WithEvents Save As Button
End Class
