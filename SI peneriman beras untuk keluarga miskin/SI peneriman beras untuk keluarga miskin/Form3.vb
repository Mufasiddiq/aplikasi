Public Class Form3
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
        sql = "select * from kriteria"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttabel.Clear()
        dtadapter.Fill(ttabel)
        dgmasterkriteria.DataSource = ttabel
        conn.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek_db()
        Daftar()
    End Sub

    Sub Simpan()
        conn.Open()
        Dim a, b, c, d, f, g, h, i As String
        a = txtnik.Text
        b = txtnamakk.Text
        c = txtkodekriteria.Text
        d = cbkondisi.Text
        f = txtpenghasilan.Text
        g = txtpekerjaan.Text
        h = txtjumlah.Text
        i = txtaset.Text

        sql = "insert into kriteria values('" & a & "','" & b & "','" & c & "','" & d & "','" & f & "','" & g & "','" & h & "','" & i & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub bersih()
        txtkodekriteria.Text = ""
        txtnik.Text = ""
        txtnamakk.Text = ""
        cbkondisi.Text = ""
        txtpenghasilan.Text = ""
        txtpekerjaan.Text = ""
        txtjumlah.Text = ""
        txtaset.Text = ""
    End Sub

    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        bersih()
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        Simpan()
        Daftar()
        bersih()
    End Sub

    Sub carinik()
        conn.Open()
        sql = "select * from warga where nik='" & txtnik.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        dtreader = cmd.ExecuteReader
        If dtreader.Read Then
            txtnamakk.Text = dtreader(1)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
        conn.Close()
    End Sub

    Private Sub btcarinik_Click(sender As System.Object, e As System.EventArgs) Handles btcarinik.Click
        carinik()
    End Sub

    Private Sub bttutup_Click(sender As System.Object, e As System.EventArgs) Handles bttutup.Click
        Close()
    End Sub
End Class