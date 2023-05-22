<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penjual
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
        Me.manajemenbarang = New System.Windows.Forms.TabPage()
        Me.ID = New System.Windows.Forms.Label()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barang = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.nama_brg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ttx = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Laporan = New System.Windows.Forms.TabPage()
        Me.gridlaporan = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.manajemenbarang.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Laporan.SuspendLayout()
        CType(Me.gridlaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.manajemenbarang)
        Me.TabControl1.Controls.Add(Me.Laporan)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 344)
        Me.TabControl1.TabIndex = 1
        '
        'manajemenbarang
        '
        Me.manajemenbarang.Controls.Add(Me.ID)
        Me.manajemenbarang.Controls.Add(Me.btnhapus)
        Me.manajemenbarang.Controls.Add(Me.btnedit)
        Me.manajemenbarang.Controls.Add(Me.btnsearch)
        Me.manajemenbarang.Controls.Add(Me.pb)
        Me.manajemenbarang.Controls.Add(Me.btnclear)
        Me.manajemenbarang.Controls.Add(Me.Label1)
        Me.manajemenbarang.Controls.Add(Me.barang)
        Me.manajemenbarang.Controls.Add(Me.btntambah)
        Me.manajemenbarang.Controls.Add(Me.nama_brg)
        Me.manajemenbarang.Controls.Add(Me.Label2)
        Me.manajemenbarang.Controls.Add(Me.ttx)
        Me.manajemenbarang.Controls.Add(Me.Label5)
        Me.manajemenbarang.Controls.Add(Me.jumlah)
        Me.manajemenbarang.Controls.Add(Me.harga)
        Me.manajemenbarang.Location = New System.Drawing.Point(4, 22)
        Me.manajemenbarang.Name = "manajemenbarang"
        Me.manajemenbarang.Padding = New System.Windows.Forms.Padding(3)
        Me.manajemenbarang.Size = New System.Drawing.Size(753, 318)
        Me.manajemenbarang.TabIndex = 0
        Me.manajemenbarang.Text = "Manajemen Barang"
        Me.manajemenbarang.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ID.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ID.Location = New System.Drawing.Point(514, 36)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(22, 15)
        Me.ID.TabIndex = 41
        Me.ID.Text = "ID"
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnhapus.Font = New System.Drawing.Font("News706 BT", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnhapus.Location = New System.Drawing.Point(666, 260)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 40
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnedit.Font = New System.Drawing.Font("News706 BT", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnedit.Location = New System.Drawing.Point(585, 260)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 39
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("News701 BT", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(623, 202)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(73, 23)
        Me.btnsearch.TabIndex = 38
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'pb
        '
        Me.pb.BackColor = System.Drawing.Color.White
        Me.pb.Location = New System.Drawing.Point(517, 159)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(100, 66)
        Me.pb.TabIndex = 37
        Me.pb.TabStop = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnclear.Font = New System.Drawing.Font("News706 BT", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnclear.Location = New System.Drawing.Point(585, 231)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 36
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(539, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Form Tambah Barang"
        '
        'barang
        '
        Me.barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.barang.Location = New System.Drawing.Point(18, 6)
        Me.barang.Name = "barang"
        Me.barang.Size = New System.Drawing.Size(483, 309)
        Me.barang.TabIndex = 27
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btntambah.Font = New System.Drawing.Font("News706 BT", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btntambah.Location = New System.Drawing.Point(666, 231)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 35
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'nama_brg
        '
        Me.nama_brg.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_brg.Location = New System.Drawing.Point(579, 58)
        Me.nama_brg.Name = "nama_brg"
        Me.nama_brg.Size = New System.Drawing.Size(162, 21)
        Me.nama_brg.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(514, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama"
        '
        'ttx
        '
        Me.ttx.AutoSize = True
        Me.ttx.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ttx.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttx.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ttx.Location = New System.Drawing.Point(514, 97)
        Me.ttx.Name = "ttx"
        Me.ttx.Size = New System.Drawing.Size(44, 15)
        Me.ttx.TabIndex = 31
        Me.ttx.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(514, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Jumlah"
        '
        'jumlah
        '
        Me.jumlah.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(579, 132)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(81, 21)
        Me.jumlah.TabIndex = 32
        '
        'harga
        '
        Me.harga.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Location = New System.Drawing.Point(579, 97)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(141, 21)
        Me.harga.TabIndex = 30
        '
        'Laporan
        '
        Me.Laporan.Controls.Add(Me.gridlaporan)
        Me.Laporan.Location = New System.Drawing.Point(4, 22)
        Me.Laporan.Name = "Laporan"
        Me.Laporan.Padding = New System.Windows.Forms.Padding(3)
        Me.Laporan.Size = New System.Drawing.Size(753, 318)
        Me.Laporan.TabIndex = 1
        Me.Laporan.Text = "Laporan Pembelian"
        Me.Laporan.UseVisualStyleBackColor = True
        '
        'gridlaporan
        '
        Me.gridlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridlaporan.Location = New System.Drawing.Point(87, 6)
        Me.gridlaporan.Name = "gridlaporan"
        Me.gridlaporan.Size = New System.Drawing.Size(537, 310)
        Me.gridlaporan.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 360)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Penjual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 385)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Penjual"
        Me.Text = "Penjual"
        Me.TabControl1.ResumeLayout(False)
        Me.manajemenbarang.ResumeLayout(False)
        Me.manajemenbarang.PerformLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Laporan.ResumeLayout(False)
        CType(Me.gridlaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents manajemenbarang As TabPage
    Friend WithEvents btnclear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents barang As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents nama_brg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ttx As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents jumlah As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents Laporan As TabPage
    Friend WithEvents gridlaporan As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents btnsearch As Button
    Friend WithEvents pb As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents ID As Label
End Class
