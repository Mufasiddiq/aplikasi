Public Class Form4
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttabel As New DataTable
    Public dtreader As OleDb.OleDbDataReader

    Sub konek_db()
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SI Beras.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
    End Sub

    Sub Daftar()
        conn.Open()
        sql = "select * from warga"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttabel.Clear()
        dtadapter.Fill(ttabel)
        dgmasterwarga.DataSource = ttabel
        conn.Close()
    End Sub

    Sub Ubah()
        conn.Open()
        Dim a, b, c, d, f, g, h, i, j, k, l, m As String
        a = txtnik.Text
        b = txtnamakk.Text
        c = cbjenis.Text
        d = txtttl.Text
        f = txtagama.Text
        g = txtalamat.Text
        h = txtrt.Text
        i = txtrw.Text
        j = txtdesa.Text
        k = txtkecamatan.Text
        l = txtkabupaten.Text
        m = txtprovinsi.Text

        sql = "update warga set namakk='" & b & "',jenis='" & c & "',ttl='" & d & "',agama='" & f & "',alamat='" & g & "',rt='" & h & "',rw='" & i & "',desa='" & j & "',kecamatan='" & k & "',kabupaten='" & l & "',provinsi='" & m & "'where nik='" & a & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub hapus()
        conn.Open()
        sql = "delete from warga where nik='" & txtnik.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek_db()
        Daftar()
    End Sub
    Sub Simpan()
        conn.Open()
        Dim a, b, c, d, f, g, h, i, j, k, l, m As String
        a = txtnik.Text
        b = txtnamakk.Text
        c = cbjenis.Text
        d = txtttl.Text
        f = txtagama.Text
        g = txtalamat.Text
        h = txtrt.Text
        i = txtrw.Text
        j = txtdesa.Text
        k = txtkecamatan.Text
        l = txtkabupaten.Text
        m = txtprovinsi.Text

        sql = "insert into warga values('" & a & "','" & b & "','" & c & "','" & d & "','" & f & "','" & g & "','" & h & "','" & i & "','" & j & "','" & k & "','" & l & "','" & m & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub bersih()
        txtnik.Text = ""
        txtnamakk.Text = ""
        cbjenis.Text = ""
        txtttl.Text = ""
        txtagama.Text = ""
        txtalamat.Text = ""
        txtrt.Text = ""
        txtrw.Text = ""
        txtdesa.Text = ""
        txtkecamatan.Text = ""
        txtkabupaten.Text = ""
        txtprovinsi.Text = ""
    End Sub

    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        bersih()
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        Simpan()
        Daftar()
        bersih()
    End Sub

    Sub cari()
        conn.Open()
        sql = "select * from warga where nik='" & txtnik.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        dtreader = cmd.ExecuteReader
        If dtreader.Read Then
            txtnik.Text = dtreader(0)
            txtnamakk.Text = dtreader(1)
            cbjenis.Text = dtreader(2)
            txtttl.Text = dtreader(3)
            txtagama.Text = dtreader(4)
            txtalamat.Text = dtreader(5)
            txtrt.Text = dtreader(6)
            txtrw.Text = dtreader(7)
            txtdesa.Text = dtreader(8)
            txtkecamatan.Text = dtreader(9)
            txtkabupaten.Text = dtreader(10)
            txtprovinsi.Text = dtreader(11)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
        conn.Close()
    End Sub

    Private Sub btcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcari.Click
        cari()
    End Sub

    Private Sub btubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btubah.Click
        Ubah()
        Daftar()
        bersih()
    End Sub

    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        hapus()
        Daftar()
        bersih()
    End Sub

    Private Sub bttutup_Click(sender As System.Object, e As System.EventArgs) Handles bttutup.Click
        Close()
    End Sub
End Class