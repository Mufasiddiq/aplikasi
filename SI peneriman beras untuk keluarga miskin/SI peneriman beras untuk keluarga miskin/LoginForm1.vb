Public Class LoginForm1
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

    Sub cari()
        conn.Open()
        sql = "select * from account where [user id]='" & txtuser.Text & "' and pwd='" & txtpassword.Text & "' "
        cmd = New OleDb.OleDbCommand(sql, conn)
        dtreader = cmd.ExecuteReader
        If dtreader.Read Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
        conn.Close()
    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        konek_db()
        cari()
        bersih()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub btdaftar_Click(sender As System.Object, e As System.EventArgs) Handles btdaftar.Click
        Form2.Show()
    End Sub
    Sub bersih()
        txtuser.Text = ""
        txtpassword.Text = ""
    End Sub

End Class
