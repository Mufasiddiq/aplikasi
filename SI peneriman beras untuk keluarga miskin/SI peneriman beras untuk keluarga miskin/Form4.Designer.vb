<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.MASTER = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.txtnamakk = New System.Windows.Forms.TextBox()
        Me.txtttl = New System.Windows.Forms.TextBox()
        Me.dgmasterwarga = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtagama = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.txtkecamatan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdesa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkabupaten = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprovinsi = New System.Windows.Forms.TextBox()
        Me.txtrw = New System.Windows.Forms.TextBox()
        Me.txtrt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.dgmasterwarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btubah
        '
        Me.btubah.Location = New System.Drawing.Point(570, 353)
        Me.btubah.Name = "btubah"
        Me.btubah.Size = New System.Drawing.Size(85, 33)
        Me.btubah.TabIndex = 31
        Me.btubah.Text = "Ubah"
        Me.btubah.UseVisualStyleBackColor = True
        '
        'bttutup
        '
        Me.bttutup.Location = New System.Drawing.Point(871, 353)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(85, 33)
        Me.bttutup.TabIndex = 30
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(661, 353)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(85, 33)
        Me.bthapus.TabIndex = 29
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btcari
        '
        Me.btcari.Location = New System.Drawing.Point(479, 353)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(85, 33)
        Me.btcari.TabIndex = 28
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(388, 353)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(85, 33)
        Me.btsimpan.TabIndex = 27
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(297, 353)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(85, 33)
        Me.btbaru.TabIndex = 26
        Me.btbaru.Text = "Baru"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'MASTER
        '
        Me.MASTER.AutoSize = True
        Me.MASTER.BackColor = System.Drawing.SystemColors.Control
        Me.MASTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTER.ForeColor = System.Drawing.Color.Black
        Me.MASTER.Location = New System.Drawing.Point(495, 47)
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(236, 31)
        Me.MASTER.TabIndex = 32
        Me.MASTER.Text = "MASTER WARGA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(292, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(294, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nama Kepala keluarga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(294, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tempat/Tgl Lahit"
        '
        'txtnik
        '
        Me.txtnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.Location = New System.Drawing.Point(457, 143)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(178, 24)
        Me.txtnik.TabIndex = 42
        '
        'txtnamakk
        '
        Me.txtnamakk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamakk.Location = New System.Drawing.Point(457, 181)
        Me.txtnamakk.Name = "txtnamakk"
        Me.txtnamakk.Size = New System.Drawing.Size(134, 24)
        Me.txtnamakk.TabIndex = 43
        '
        'txtttl
        '
        Me.txtttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtttl.Location = New System.Drawing.Point(457, 255)
        Me.txtttl.Name = "txtttl"
        Me.txtttl.Size = New System.Drawing.Size(134, 24)
        Me.txtttl.TabIndex = 44
        '
        'dgmasterwarga
        '
        Me.dgmasterwarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgmasterwarga.Location = New System.Drawing.Point(297, 412)
        Me.dgmasterwarga.Name = "dgmasterwarga"
        Me.dgmasterwarga.Size = New System.Drawing.Size(659, 170)
        Me.dgmasterwarga.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(294, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Agama"
        '
        'txtagama
        '
        Me.txtagama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtagama.Location = New System.Drawing.Point(457, 290)
        Me.txtagama.Name = "txtagama"
        Me.txtagama.Size = New System.Drawing.Size(134, 24)
        Me.txtagama.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(294, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 18)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Jenis Kelamin"
        '
        'cbjenis
        '
        Me.cbjenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Items.AddRange(New Object() {"Laki-laki", "Wanita"})
        Me.cbjenis.Location = New System.Drawing.Point(457, 219)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(134, 24)
        Me.cbjenis.TabIndex = 62
        '
        'txtkecamatan
        '
        Me.txtkecamatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkecamatan.Location = New System.Drawing.Point(834, 255)
        Me.txtkecamatan.Name = "txtkecamatan"
        Me.txtkecamatan.Size = New System.Drawing.Size(122, 24)
        Me.txtkecamatan.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(724, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 18)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Kecamatan"
        '
        'txtdesa
        '
        Me.txtdesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesa.Location = New System.Drawing.Point(834, 225)
        Me.txtdesa.Name = "txtdesa"
        Me.txtdesa.Size = New System.Drawing.Size(122, 24)
        Me.txtdesa.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(724, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Kabupaten"
        '
        'txtkabupaten
        '
        Me.txtkabupaten.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkabupaten.Location = New System.Drawing.Point(834, 285)
        Me.txtkabupaten.Name = "txtkabupaten"
        Me.txtkabupaten.Size = New System.Drawing.Size(122, 24)
        Me.txtkabupaten.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(724, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Desa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(724, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Provinsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(830, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "/"
        '
        'txtprovinsi
        '
        Me.txtprovinsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprovinsi.Location = New System.Drawing.Point(834, 314)
        Me.txtprovinsi.Name = "txtprovinsi"
        Me.txtprovinsi.Size = New System.Drawing.Size(122, 24)
        Me.txtprovinsi.TabIndex = 58
        '
        'txtrw
        '
        Me.txtrw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrw.Location = New System.Drawing.Point(849, 195)
        Me.txtrw.Name = "txtrw"
        Me.txtrw.Size = New System.Drawing.Size(29, 24)
        Me.txtrw.TabIndex = 49
        '
        'txtrt
        '
        Me.txtrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrt.Location = New System.Drawing.Point(796, 195)
        Me.txtrt.Name = "txtrt"
        Me.txtrt.Size = New System.Drawing.Size(28, 24)
        Me.txtrt.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(724, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "RT / RW"
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(727, 143)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(232, 46)
        Me.txtalamat.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(668, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Alamat"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1313, 637)
        Me.ShapeContainer1.TabIndex = 63
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(186, 110)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(875, 507)
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_peneriman_beras_untuk_keluarga_miskin.My.Resources.Resources._231061764
        Me.ClientSize = New System.Drawing.Size(1313, 637)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtagama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtprovinsi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtkabupaten)
        Me.Controls.Add(Me.txtdesa)
        Me.Controls.Add(Me.txtkecamatan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtrw)
        Me.Controls.Add(Me.txtrt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgmasterwarga)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtttl)
        Me.Controls.Add(Me.txtnamakk)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MASTER)
        Me.Controls.Add(Me.btubah)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btcari)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.dgmasterwarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btubah As System.Windows.Forms.Button
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btcari As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents MASTER As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents txtnamakk As System.Windows.Forms.TextBox
    Friend WithEvents txtttl As System.Windows.Forms.TextBox
    Friend WithEvents dgmasterwarga As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtagama As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents txtkecamatan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdesa As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtkabupaten As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprovinsi As System.Windows.Forms.TextBox
    Friend WithEvents txtrw As System.Windows.Forms.TextBox
    Friend WithEvents txtrt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
