<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btubah = New System.Windows.Forms.Button()
        Me.bttutup = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btcari = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MASTER = New System.Windows.Forms.Label()
        Me.dgmasteraccount = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.dgmasteraccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btubah
        '
        Me.btubah.Location = New System.Drawing.Point(671, 312)
        Me.btubah.Name = "btubah"
        Me.btubah.Size = New System.Drawing.Size(85, 33)
        Me.btubah.TabIndex = 71
        Me.btubah.Text = "Ubah"
        Me.btubah.UseVisualStyleBackColor = True
        '
        'bttutup
        '
        Me.bttutup.Location = New System.Drawing.Point(859, 312)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(85, 33)
        Me.bttutup.TabIndex = 70
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(762, 312)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(85, 33)
        Me.bthapus.TabIndex = 69
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btcari
        '
        Me.btcari.Location = New System.Drawing.Point(580, 312)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(85, 33)
        Me.btcari.TabIndex = 68
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(477, 312)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(85, 33)
        Me.btsimpan.TabIndex = 67
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(371, 312)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(85, 33)
        Me.btbaru.TabIndex = 66
        Me.btbaru.Text = "Baru"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(597, 246)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(229, 29)
        Me.txtpassword.TabIndex = 65
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(597, 203)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(229, 29)
        Me.txtid.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(468, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(491, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "User ID"
        '
        'MASTER
        '
        Me.MASTER.AutoSize = True
        Me.MASTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTER.Location = New System.Drawing.Point(521, 108)
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(270, 31)
        Me.MASTER.TabIndex = 61
        Me.MASTER.Text = "MASTER ACCOUNT"
        '
        'dgmasteraccount
        '
        Me.dgmasteraccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgmasteraccount.Location = New System.Drawing.Point(369, 362)
        Me.dgmasteraccount.Name = "dgmasteraccount"
        Me.dgmasteraccount.Size = New System.Drawing.Size(575, 150)
        Me.dgmasteraccount.TabIndex = 72
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1316, 634)
        Me.ShapeContainer1.TabIndex = 73
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(259, 168)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(812, 380)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_peneriman_beras_untuk_keluarga_miskin.My.Resources.Resources._231061764
        Me.ClientSize = New System.Drawing.Size(1316, 634)
        Me.Controls.Add(Me.dgmasteraccount)
        Me.Controls.Add(Me.btubah)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btcari)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MASTER)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgmasteraccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btubah As System.Windows.Forms.Button
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btcari As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MASTER As System.Windows.Forms.Label
    Friend WithEvents dgmasteraccount As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
