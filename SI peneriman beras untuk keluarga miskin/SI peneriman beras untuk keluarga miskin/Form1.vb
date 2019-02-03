Public Class Form1

    Private Sub AccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
    End Sub

    Private Sub KriteriaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KriteriaToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub WargaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WargaToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub KriteriaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles KriteriaToolStripMenuItem1.Click
        Form5.Show()
    End Sub

    Private Sub WargaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles WargaToolStripMenuItem1.Click
        Form6.Show()
    End Sub
End Class
