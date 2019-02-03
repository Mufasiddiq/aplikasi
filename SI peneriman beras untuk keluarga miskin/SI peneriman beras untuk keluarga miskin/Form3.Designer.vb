<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.bttutup = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.MASTER = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpenghasilan = New System.Windows.Forms.TextBox()
        Me.txtpekerjaan = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtaset = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.dgmasterkriteria = New System.Windows.Forms.DataGridView()
        Me.cbkondisi = New System.Windows.Forms.ComboBox()
        Me.btcarinik = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnamakk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkodekriteria = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.dgmasterkriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttutup
        '
        Me.bttutup.Location = New System.Drawing.Point(836, 391)
        Me.bttutup.Name = "bttutup"
        Me.bttutup.Size = New System.Drawing.Size(85, 33)
        Me.bttutup.TabIndex = 24
        Me.bttutup.Text = "Tutup"
        Me.bttutup.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(472, 391)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(85, 33)
        Me.btsimpan.TabIndex = 21
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(381, 391)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(85, 33)
        Me.btbaru.TabIndex = 20
        Me.btbaru.Text = "Baru"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'MASTER
        '
        Me.MASTER.AutoSize = True
        Me.MASTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTER.Location = New System.Drawing.Point(490, 26)
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(261, 31)
        Me.MASTER.TabIndex = 26
        Me.MASTER.Text = "MASTER KRITERIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Kondisi Rumah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Penghasilan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(386, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Pekerjaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Jumlah Tanggungan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Aset Pribadi"
        '
        'txtpenghasilan
        '
        Me.txtpenghasilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpenghasilan.Location = New System.Drawing.Point(571, 250)
        Me.txtpenghasilan.Name = "txtpenghasilan"
        Me.txtpenghasilan.Size = New System.Drawing.Size(222, 26)
        Me.txtpenghasilan.TabIndex = 33
        '
        'txtpekerjaan
        '
        Me.txtpekerjaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpekerjaan.Location = New System.Drawing.Point(571, 286)
        Me.txtpekerjaan.Name = "txtpekerjaan"
        Me.txtpekerjaan.Size = New System.Drawing.Size(222, 26)
        Me.txtpekerjaan.TabIndex = 34
        '
        'txtjumlah
        '
        Me.txtjumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.Location = New System.Drawing.Point(571, 318)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(222, 26)
        Me.txtjumlah.TabIndex = 35
        '
        'txtaset
        '
        Me.txtaset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaset.Location = New System.Drawing.Point(570, 350)
        Me.txtaset.Name = "txtaset"
        Me.txtaset.Size = New System.Drawing.Size(223, 26)
        Me.txtaset.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "NIK"
        '
        'txtnik
        '
        Me.txtnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.Location = New System.Drawing.Point(570, 155)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(149, 26)
        Me.txtnik.TabIndex = 38
        '
        'dgmasterkriteria
        '
        Me.dgmasterkriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgmasterkriteria.Location = New System.Drawing.Point(381, 439)
        Me.dgmasterkriteria.Name = "dgmasterkriteria"
        Me.dgmasterkriteria.Size = New System.Drawing.Size(540, 136)
        Me.dgmasterkriteria.TabIndex = 39
        '
        'cbkondisi
        '
        Me.cbkondisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkondisi.FormattingEnabled = True
        Me.cbkondisi.Items.AddRange(New Object() {"Rusak ringan", "Rusak sedang", "Rusak berat"})
        Me.cbkondisi.Location = New System.Drawing.Point(571, 216)
        Me.cbkondisi.Name = "cbkondisi"
        Me.cbkondisi.Size = New System.Drawing.Size(222, 28)
        Me.cbkondisi.TabIndex = 40
        '
        'btcarinik
        '
        Me.btcarinik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcarinik.Location = New System.Drawing.Point(728, 151)
        Me.btcarinik.Name = "btcarinik"
        Me.btcarinik.Size = New System.Drawing.Size(68, 31)
        Me.btcarinik.TabIndex = 41
        Me.btcarinik.Text = "Cari NIK"
        Me.btcarinik.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Nama Kepala Keluarga"
        '
        'txtnamakk
        '
        Me.txtnamakk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamakk.Location = New System.Drawing.Point(570, 188)
        Me.txtnamakk.Name = "txtnamakk"
        Me.txtnamakk.Size = New System.Drawing.Size(223, 26)
        Me.txtnamakk.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(386, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Kode Kriteria"
        '
        'txtkodekriteria
        '
        Me.txtkodekriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodekriteria.Location = New System.Drawing.Point(571, 115)
        Me.txtkodekriteria.Name = "txtkodekriteria"
        Me.txtkodekriteria.Size = New System.Drawing.Size(223, 26)
        Me.txtkodekriteria.TabIndex = 45
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1320, 640)
        Me.ShapeContainer1.TabIndex = 46
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(266, 90)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(748, 519)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_peneriman_beras_untuk_keluarga_miskin.My.Resources.Resources._231061764
        Me.ClientSize = New System.Drawing.Size(1320, 640)
        Me.Controls.Add(Me.txtkodekriteria)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnamakk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btcarinik)
        Me.Controls.Add(Me.cbkondisi)
        Me.Controls.Add(Me.dgmasterkriteria)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtaset)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtpekerjaan)
        Me.Controls.Add(Me.txtpenghasilan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MASTER)
        Me.Controls.Add(Me.bttutup)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgmasterkriteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttutup As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents MASTER As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpenghasilan As System.Windows.Forms.TextBox
    Friend WithEvents txtpekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtaset As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents dgmasterkriteria As System.Windows.Forms.DataGridView
    Friend WithEvents cbkondisi As System.Windows.Forms.ComboBox
    Friend WithEvents btcarinik As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnamakk As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtkodekriteria As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
