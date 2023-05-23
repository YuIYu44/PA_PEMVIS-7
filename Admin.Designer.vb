<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.manajemenakun = New System.Windows.Forms.TabPage()
        Me.btntutorial = New System.Windows.Forms.Button()
        Me.akun = New System.Windows.Forms.DataGridView()
        Me.laporanpembelian = New System.Windows.Forms.TabPage()
        Me.laporan = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.manajemenakun.SuspendLayout()
        CType(Me.akun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.laporanpembelian.SuspendLayout()
        CType(Me.laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.manajemenakun)
        Me.TabControl1.Controls.Add(Me.laporanpembelian)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(561, 414)
        Me.TabControl1.TabIndex = 1
        '
        'manajemenakun
        '
        Me.manajemenakun.Controls.Add(Me.btntutorial)
        Me.manajemenakun.Controls.Add(Me.akun)
        Me.manajemenakun.Location = New System.Drawing.Point(4, 22)
        Me.manajemenakun.Name = "manajemenakun"
        Me.manajemenakun.Padding = New System.Windows.Forms.Padding(3)
        Me.manajemenakun.Size = New System.Drawing.Size(553, 388)
        Me.manajemenakun.TabIndex = 0
        Me.manajemenakun.Text = "Manajemen Akun"
        Me.manajemenakun.UseVisualStyleBackColor = True
        '
        'btntutorial
        '
        Me.btntutorial.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btntutorial.Location = New System.Drawing.Point(413, 359)
        Me.btntutorial.Name = "btntutorial"
        Me.btntutorial.Size = New System.Drawing.Size(75, 23)
        Me.btntutorial.TabIndex = 5
        Me.btntutorial.Text = "Tutorial"
        Me.btntutorial.UseVisualStyleBackColor = True
        '
        'akun
        '
        Me.akun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.akun.Location = New System.Drawing.Point(19, 6)
        Me.akun.Name = "akun"
        Me.akun.Size = New System.Drawing.Size(509, 347)
        Me.akun.TabIndex = 4
        '
        'laporanpembelian
        '
        Me.laporanpembelian.Controls.Add(Me.laporan)
        Me.laporanpembelian.Location = New System.Drawing.Point(4, 22)
        Me.laporanpembelian.Name = "laporanpembelian"
        Me.laporanpembelian.Padding = New System.Windows.Forms.Padding(3)
        Me.laporanpembelian.Size = New System.Drawing.Size(553, 388)
        Me.laporanpembelian.TabIndex = 1
        Me.laporanpembelian.Text = "Laporan Pembelian"
        Me.laporanpembelian.UseVisualStyleBackColor = True
        '
        'laporan
        '
        Me.laporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.laporan.Location = New System.Drawing.Point(16, 6)
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(521, 376)
        Me.laporan.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 432)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(835, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Location = New System.Drawing.Point(588, 129)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(207, 178)
        Me.logo.TabIndex = 3
        Me.logo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(397, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 376)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.TabControl1.ResumeLayout(False)
        Me.manajemenakun.ResumeLayout(False)
        CType(Me.akun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.laporanpembelian.ResumeLayout(False)
        CType(Me.laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents manajemenakun As TabPage
    Friend WithEvents akun As DataGridView
    Friend WithEvents laporanpembelian As TabPage
    Friend WithEvents laporan As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btntutorial As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
