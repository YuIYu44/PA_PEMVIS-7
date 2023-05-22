<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detail
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
        Me.image_bike = New System.Windows.Forms.PictureBox()
        Me.labelmerk = New System.Windows.Forms.Label()
        Me.labelharga = New System.Windows.Forms.Label()
        Me.labelpenjual = New System.Windows.Forms.Label()
        Me.btnpesan = New System.Windows.Forms.Button()
        Me.jmlh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stok = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.image_bike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'image_bike
        '
        Me.image_bike.Location = New System.Drawing.Point(16, 12)
        Me.image_bike.Name = "image_bike"
        Me.image_bike.Size = New System.Drawing.Size(276, 175)
        Me.image_bike.TabIndex = 0
        Me.image_bike.TabStop = False
        '
        'labelmerk
        '
        Me.labelmerk.AutoSize = True
        Me.labelmerk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelmerk.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelmerk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelmerk.Location = New System.Drawing.Point(12, 213)
        Me.labelmerk.Name = "labelmerk"
        Me.labelmerk.Size = New System.Drawing.Size(55, 21)
        Me.labelmerk.TabIndex = 1
        Me.labelmerk.Text = "Nama"
        '
        'labelharga
        '
        Me.labelharga.AutoSize = True
        Me.labelharga.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelharga.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelharga.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelharga.Location = New System.Drawing.Point(12, 244)
        Me.labelharga.Name = "labelharga"
        Me.labelharga.Size = New System.Drawing.Size(61, 22)
        Me.labelharga.TabIndex = 3
        Me.labelharga.Text = "Harga"
        '
        'labelpenjual
        '
        Me.labelpenjual.AutoSize = True
        Me.labelpenjual.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelpenjual.Font = New System.Drawing.Font("Modern No. 20", 13.0!)
        Me.labelpenjual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelpenjual.Location = New System.Drawing.Point(207, 272)
        Me.labelpenjual.Name = "labelpenjual"
        Me.labelpenjual.Size = New System.Drawing.Size(68, 21)
        Me.labelpenjual.TabIndex = 4
        Me.labelpenjual.Text = "Penjual"
        '
        'btnpesan
        '
        Me.btnpesan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnpesan.Font = New System.Drawing.Font("Swis721 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpesan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnpesan.Location = New System.Drawing.Point(105, 325)
        Me.btnpesan.Name = "btnpesan"
        Me.btnpesan.Size = New System.Drawing.Size(75, 31)
        Me.btnpesan.TabIndex = 5
        Me.btnpesan.Text = "Pesan"
        Me.btnpesan.UseVisualStyleBackColor = False
        '
        'jmlh
        '
        Me.jmlh.Font = New System.Drawing.Font("Swis721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jmlh.Location = New System.Drawing.Point(176, 297)
        Me.jmlh.Name = "jmlh"
        Me.jmlh.Size = New System.Drawing.Size(122, 22)
        Me.jmlh.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Swis721 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(121, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jumlah"
        '
        'stok
        '
        Me.stok.AutoSize = True
        Me.stok.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.stok.Font = New System.Drawing.Font("Modern No. 20", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stok.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stok.Location = New System.Drawing.Point(231, 192)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(57, 20)
        Me.stok.TabIndex = 8
        Me.stok.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(173, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tersisa :"
        '
        'detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 359)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jmlh)
        Me.Controls.Add(Me.btnpesan)
        Me.Controls.Add(Me.labelpenjual)
        Me.Controls.Add(Me.labelharga)
        Me.Controls.Add(Me.labelmerk)
        Me.Controls.Add(Me.image_bike)
        Me.Name = "detail"
        Me.Text = "Detail Barang"
        CType(Me.image_bike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents image_bike As PictureBox
    Friend WithEvents labelmerk As Label
    Friend WithEvents labelharga As Label
    Friend WithEvents labelpenjual As Label
    Friend WithEvents btnpesan As Button
    Friend WithEvents jmlh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents stok As Label
    Friend WithEvents Label1 As Label
End Class
