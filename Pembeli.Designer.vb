<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pembeli
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
        Me.components = New System.ComponentModel.Container()
        Me.pembeli_control = New System.Windows.Forms.TabControl()
        Me.Pembelian = New System.Windows.Forms.TabPage()
        Me.LISTPIC = New System.Windows.Forms.ListView()
        Me.btntutorial = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.btnbeli = New System.Windows.Forms.Button()
        Me.pesanan = New System.Windows.Forms.DataGridView()
        Me.riwayat = New System.Windows.Forms.TabPage()
        Me.gridriwayat = New System.Windows.Forms.DataGridView()
        Me.profilepage = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.editpass = New System.Windows.Forms.Button()
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oldpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pembeli_control.SuspendLayout()
        Me.Pembelian.SuspendLayout()
        CType(Me.pesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.riwayat.SuspendLayout()
        CType(Me.gridriwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.profilepage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pembeli_control
        '
        Me.pembeli_control.Controls.Add(Me.Pembelian)
        Me.pembeli_control.Controls.Add(Me.riwayat)
        Me.pembeli_control.Controls.Add(Me.profilepage)
        Me.pembeli_control.Location = New System.Drawing.Point(0, 1)
        Me.pembeli_control.Name = "pembeli_control"
        Me.pembeli_control.SelectedIndex = 0
        Me.pembeli_control.Size = New System.Drawing.Size(603, 437)
        Me.pembeli_control.TabIndex = 1
        '
        'Pembelian
        '
        Me.Pembelian.Controls.Add(Me.LISTPIC)
        Me.Pembelian.Controls.Add(Me.btntutorial)
        Me.Pembelian.Controls.Add(Me.btnsearch)
        Me.Pembelian.Controls.Add(Me.search)
        Me.Pembelian.Controls.Add(Me.total)
        Me.Pembelian.Controls.Add(Me.btnbeli)
        Me.Pembelian.Controls.Add(Me.pesanan)
        Me.Pembelian.Location = New System.Drawing.Point(4, 22)
        Me.Pembelian.Name = "Pembelian"
        Me.Pembelian.Padding = New System.Windows.Forms.Padding(3)
        Me.Pembelian.Size = New System.Drawing.Size(595, 411)
        Me.Pembelian.TabIndex = 0
        Me.Pembelian.Text = "Pembelian"
        Me.Pembelian.UseVisualStyleBackColor = True
        '
        'LISTPIC
        '
        Me.LISTPIC.HideSelection = False
        Me.LISTPIC.Location = New System.Drawing.Point(9, 30)
        Me.LISTPIC.Name = "LISTPIC"
        Me.LISTPIC.Size = New System.Drawing.Size(580, 226)
        Me.LISTPIC.TabIndex = 15
        Me.LISTPIC.UseCompatibleStateImageBehavior = False
        '
        'btntutorial
        '
        Me.btntutorial.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btntutorial.Location = New System.Drawing.Point(6, 387)
        Me.btntutorial.Name = "btntutorial"
        Me.btntutorial.Size = New System.Drawing.Size(75, 23)
        Me.btntutorial.TabIndex = 14
        Me.btntutorial.Text = "Tutorial"
        Me.btntutorial.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnsearch.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(515, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(74, 23)
        Me.btnsearch.TabIndex = 13
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(295, 6)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(214, 21)
        Me.search.TabIndex = 12
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(347, 389)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(145, 21)
        Me.total.TabIndex = 11
        '
        'btnbeli
        '
        Me.btnbeli.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnbeli.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbeli.Location = New System.Drawing.Point(498, 389)
        Me.btnbeli.Name = "btnbeli"
        Me.btnbeli.Size = New System.Drawing.Size(91, 23)
        Me.btnbeli.TabIndex = 10
        Me.btnbeli.Text = "BELI"
        Me.btnbeli.UseVisualStyleBackColor = False
        '
        'pesanan
        '
        Me.pesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pesanan.Location = New System.Drawing.Point(8, 262)
        Me.pesanan.Name = "pesanan"
        Me.pesanan.Size = New System.Drawing.Size(581, 121)
        Me.pesanan.TabIndex = 9
        '
        'riwayat
        '
        Me.riwayat.Controls.Add(Me.gridriwayat)
        Me.riwayat.Location = New System.Drawing.Point(4, 22)
        Me.riwayat.Margin = New System.Windows.Forms.Padding(99, 3, 3, 3)
        Me.riwayat.Name = "riwayat"
        Me.riwayat.Padding = New System.Windows.Forms.Padding(3)
        Me.riwayat.Size = New System.Drawing.Size(595, 411)
        Me.riwayat.TabIndex = 1
        Me.riwayat.Text = "Riwayat Pembelian"
        Me.riwayat.UseVisualStyleBackColor = True
        '
        'gridriwayat
        '
        Me.gridriwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridriwayat.Location = New System.Drawing.Point(18, 6)
        Me.gridriwayat.Name = "gridriwayat"
        Me.gridriwayat.Size = New System.Drawing.Size(556, 398)
        Me.gridriwayat.TabIndex = 4
        '
        'profilepage
        '
        Me.profilepage.BackColor = System.Drawing.Color.Transparent
        Me.profilepage.Controls.Add(Me.GroupBox1)
        Me.profilepage.Location = New System.Drawing.Point(4, 22)
        Me.profilepage.Name = "profilepage"
        Me.profilepage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.profilepage.Size = New System.Drawing.Size(595, 411)
        Me.profilepage.TabIndex = 2
        Me.profilepage.Text = "Profile"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.editpass)
        Me.GroupBox1.Controls.Add(Me.newpass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.oldpass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 309)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'editpass
        '
        Me.editpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editpass.Location = New System.Drawing.Point(242, 266)
        Me.editpass.Name = "editpass"
        Me.editpass.Size = New System.Drawing.Size(75, 28)
        Me.editpass.TabIndex = 10
        Me.editpass.Text = "UBAH"
        Me.editpass.UseVisualStyleBackColor = True
        '
        'newpass
        '
        Me.newpass.Location = New System.Drawing.Point(121, 224)
        Me.newpass.Name = "newpass"
        Me.newpass.Size = New System.Drawing.Size(196, 20)
        Me.newpass.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "New Password"
        '
        'oldpass
        '
        Me.oldpass.Location = New System.Drawing.Point(121, 182)
        Me.oldpass.Name = "oldpass"
        Me.oldpass.Size = New System.Drawing.Size(196, 20)
        Me.oldpass.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Old Password"
        '
        'txtusername
        '
        Me.txtusername.Enabled = False
        Me.txtusername.Location = New System.Drawing.Point(121, 137)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(196, 20)
        Me.txtusername.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'txtemail
        '
        Me.txtemail.Enabled = False
        Me.txtemail.Location = New System.Drawing.Point(121, 97)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(196, 20)
        Me.txtemail.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Email"
        '
        'txtnama
        '
        Me.txtnama.Enabled = False
        Me.txtnama.Location = New System.Drawing.Point(121, 57)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(196, 20)
        Me.txtnama.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(25, 57)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(39, 13)
        Me.label.TabIndex = 0
        Me.label.Text = "Nama"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 465)
        Me.Controls.Add(Me.pembeli_control)
        Me.Name = "Pembeli"
        Me.Text = "Menu"
        Me.pembeli_control.ResumeLayout(False)
        Me.Pembelian.ResumeLayout(False)
        Me.Pembelian.PerformLayout()
        CType(Me.pesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.riwayat.ResumeLayout(False)
        CType(Me.gridriwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.profilepage.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pembeli_control As TabControl
    Friend WithEvents Pembelian As TabPage
    Friend WithEvents btnsearch As Button
    Friend WithEvents search As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents btnbeli As Button
    Friend WithEvents pesanan As DataGridView
    Friend WithEvents riwayat As TabPage
    Friend WithEvents gridriwayat As DataGridView
    Friend WithEvents btntutorial As Button
    Friend WithEvents profilepage As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label As Label
    Friend WithEvents editpass As Button
    Friend WithEvents newpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents oldpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents LISTPIC As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
