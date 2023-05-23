<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Copy
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
        Me.Login_page = New System.Windows.Forms.TabPage()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Regis_page = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.username1 = New System.Windows.Forms.TextBox()
        Me.cbstatus1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.Login_page.SuspendLayout()
        Me.Regis_page.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Login_page)
        Me.TabControl1.Controls.Add(Me.Regis_page)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 234)
        Me.TabControl1.TabIndex = 18
        '
        'Login_page
        '
        Me.Login_page.Controls.Add(Me.cbstatus)
        Me.Login_page.Controls.Add(Me.Label1)
        Me.Login_page.Controls.Add(Me.btnlogin)
        Me.Login_page.Controls.Add(Me.username)
        Me.Login_page.Controls.Add(Me.Label3)
        Me.Login_page.Controls.Add(Me.Label2)
        Me.Login_page.Controls.Add(Me.password)
        Me.Login_page.Location = New System.Drawing.Point(4, 22)
        Me.Login_page.Name = "Login_page"
        Me.Login_page.Padding = New System.Windows.Forms.Padding(3)
        Me.Login_page.Size = New System.Drawing.Size(332, 208)
        Me.Login_page.TabIndex = 0
        Me.Login_page.Text = "Login"
        Me.Login_page.UseVisualStyleBackColor = True
        '
        'cbstatus
        '
        Me.cbstatus.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Location = New System.Drawing.Point(132, 40)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(121, 23)
        Me.cbstatus.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Status"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnlogin.Font = New System.Drawing.Font("News706 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogin.Location = New System.Drawing.Point(239, 169)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(79, 33)
        Me.btnlogin.TabIndex = 14
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(132, 83)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(162, 21)
        Me.username.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(22, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(19, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Username"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(132, 128)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(162, 21)
        Me.password.TabIndex = 12
        '
        'Regis_page
        '
        Me.Regis_page.Controls.Add(Me.Label4)
        Me.Regis_page.Controls.Add(Me.email)
        Me.Regis_page.Controls.Add(Me.Label5)
        Me.Regis_page.Controls.Add(Me.nama)
        Me.Regis_page.Controls.Add(Me.btnregister)
        Me.Regis_page.Controls.Add(Me.Label6)
        Me.Regis_page.Controls.Add(Me.password1)
        Me.Regis_page.Controls.Add(Me.Label7)
        Me.Regis_page.Controls.Add(Me.username1)
        Me.Regis_page.Controls.Add(Me.cbstatus1)
        Me.Regis_page.Controls.Add(Me.Label8)
        Me.Regis_page.Location = New System.Drawing.Point(4, 22)
        Me.Regis_page.Name = "Regis_page"
        Me.Regis_page.Padding = New System.Windows.Forms.Padding(3)
        Me.Regis_page.Size = New System.Drawing.Size(332, 208)
        Me.Regis_page.TabIndex = 1
        Me.Regis_page.Text = "Register"
        Me.Regis_page.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(25, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Email"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(98, 155)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(162, 21)
        Me.email.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(23, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Nama"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(98, 118)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(162, 21)
        Me.nama.TabIndex = 27
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnregister.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnregister.Location = New System.Drawing.Point(245, 185)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(75, 23)
        Me.btnregister.TabIndex = 26
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(23, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Password"
        '
        'password1
        '
        Me.password1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password1.Location = New System.Drawing.Point(98, 83)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(162, 21)
        Me.password1.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(23, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Username"
        '
        'username1
        '
        Me.username1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username1.Location = New System.Drawing.Point(98, 47)
        Me.username1.Name = "username1"
        Me.username1.Size = New System.Drawing.Size(162, 21)
        Me.username1.TabIndex = 22
        '
        'cbstatus1
        '
        Me.cbstatus1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus1.FormattingEnabled = True
        Me.cbstatus1.Location = New System.Drawing.Point(98, 13)
        Me.cbstatus1.Name = "cbstatus1"
        Me.cbstatus1.Size = New System.Drawing.Size(121, 23)
        Me.cbstatus1.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(25, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Status"
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Location = New System.Drawing.Point(369, 79)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(143, 125)
        Me.logo.TabIndex = 19
        Me.logo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 193)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Login_Copy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 264)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login_Copy"
        Me.TabControl1.ResumeLayout(False)
        Me.Login_page.ResumeLayout(False)
        Me.Login_page.PerformLayout()
        Me.Regis_page.ResumeLayout(False)
        Me.Regis_page.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Login_page As TabPage
    Friend WithEvents cbstatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Regis_page As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents btnregister As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents password1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents username1 As TextBox
    Friend WithEvents cbstatus1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
