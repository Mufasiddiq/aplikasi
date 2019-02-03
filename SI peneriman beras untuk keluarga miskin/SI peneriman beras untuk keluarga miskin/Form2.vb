Public Class Form2
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
        sql = "select * from account"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttabel.Clear()
        dtadapter.Fill(ttabel)
        dgmasteraccount.DataSource = ttabel
        conn.Close()
    End Sub

    Sub Simpan()
        conn.Open()
        Dim a, b As String
        a = txtid.Text
        b = txtpassword.Text

        sql = "insert into account values('" & a & "','" & b & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtpassword.Text = ""
    End Sub

    Sub cari()
        conn.Open()
        sql = "select * from account where [user id]='" & txtid.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        dtreader = cmd.ExecuteReader
        If dtreader.Read Then
            txtid.Text = dtreader(0)
            txtpassword.Text = dtreader(1)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
        conn.Close()
    End Sub

    Sub Ubah()
        conn.Open()
        Dim a, b As String
        a = txtid.Text
        b = txtpassword.Text

        sql = "update account set pwd='" & b & "' where [user id]='" & a & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub hapus()
        conn.Open()
        sql = "delete from account where [user id]='" & txtid.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek_db()
        Daftar()
    End Sub


    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        bersih()
    End Sub

    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        Simpan()
        Daftar()
        bersih()
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

    Private Sub bttutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttutup.Click
        Close()
    End Sub
End Class