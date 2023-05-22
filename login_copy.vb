Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Login_Copy
    Public id_login As Integer
    Public text, status_, username_, pass_, email_ As String
    Public Sub Tampilsepeda(grid As DataGridView, bools As Boolean, bools2 As Boolean, add1 As String, add2 As String)
        Dim header As String()
        DA = New MySqlDataAdapter("Select " & add1 & add2, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "sepeda")
        grid.DataSource = DS.Tables("sepeda")
        grid.Refresh()
        header = {"ID SEPEDA", "MERK", "HARGA", "JMLH", "GAMBAR"}
        For i = 0 To 4
            grid.Columns(i).HeaderText = header(i)
        Next
        insidetools(bools, bools2, grid)
    End Sub
    Public Sub insidetools(bools As Boolean, bools2 As Boolean, grid As DataGridView)
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.AutoGenerateColumns = False
        grid.AllowUserToResizeColumns = False
        grid.AllowUserToResizeRows = False
        grid.ReadOnly = bools
        grid.AllowUserToDeleteRows = bools2
        grid.AllowUserToAddRows = False
    End Sub
    Public Sub Tampilriwayat(grid As DataGridView, Jenis As Integer)
        If Jenis = 1 Then
            DA = New MySqlDataAdapter("Select id_terbeli, nama_barang, jumlah_barang, total, pembeli, penjual From terbeli", CONN)
        ElseIf Jenis = 2 Then
            DA = New MySqlDataAdapter("Select id_terbeli, nama_barang, jumlah_barang, total, pembeli From terbeli where penjual = '" & id_login & "'", CONN)
        Else
            DA = New MySqlDataAdapter("Select nama_barang, jumlah_barang, total, Username From terbeli INNER JOIN akun on terbeli.penjual=akun.id_akun where pembeli = " & id_login, CONN)
        End If
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "terbeli")
        grid.DataSource = DS.Tables("terbeli")
        grid.Refresh()
        grid.RowHeadersVisible = False
        If Jenis > 0 Then
            grid.Columns(0).HeaderText = "ID"
            grid.Columns(1).HeaderText = "MERK"
            grid.Columns(2).HeaderText = "JMLH"
            grid.Columns(3).HeaderText = "Total"
            grid.Columns(4).HeaderText = "PEMBELI"
            If Jenis = 1 Then
                grid.Columns(5).HeaderText = "PENJUAL"
            End If
        Else
            grid.Columns(0).HeaderText = "MERK"
            grid.Columns(1).HeaderText = "JMLH"
            grid.Columns(2).HeaderText = "Total"
            grid.Columns(3).HeaderText = "PENJUAL"
        End If
        insidetools(True, False, grid)
    End Sub
    Public Sub noeditplace(forms As Form)
        forms.Icon = My.Resources.bike1
        forms.BackgroundImage = My.Resources.bike
        forms.BackgroundImageLayout = BackgroundImageLayout.Stretch
        forms.MaximizeBox = False
        forms.MinimizeBox = False
        forms.AutoSizeMode = False
        forms.Top = (Screen.PrimaryScreen.Bounds.Height - forms.Height) / 2
        forms.Left = (Screen.PrimaryScreen.Bounds.Width - forms.Width) / 2
    End Sub
    Public Sub clears(page As TabPage)
        For Each ctl As TextBox In page.Controls.OfType(Of TextBox)()
            ctl.Text = ""
        Next
        For Each ctl As ComboBox In page.Controls.OfType(Of ComboBox)()
            ctl.SelectedItem = Nothing
        Next
    End Sub
    Public Sub login(tl1 As ToolStripLabel, tl2 As ToolStripLabel, tl3 As ToolStripLabel)
        tl1.Text = id_login
        tl2.Text = text
        tl3.Text = status_
    End Sub
    Public Function error_string(items As Array, kind As Integer)
        Dim ints As Integer
        If kind = 1 Then
            For Each texts In items
                If Integer.TryParse(texts, ints) Or texts.length < 3 Then
                    MessageBox.Show("Sesuaikan Jenis Masukan" & vbCrLf & "Minimal 3 Karakter!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return 1
                End If
            Next
        Else
            For Each ctl As TextBox In items
                If Integer.TryParse(ctl.Text, ints) Or ctl.TextLength < 3 Then
                    ctl.Focus()
                    MessageBox.Show("Sesuaikan Jenis Masukan" & vbCrLf & "Minimal 3 Karakter!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return 1
                Else
                End If
            Next
        End If
        Return 0
    End Function
    Public Function error_integer(items As Array)
        Dim ints As Integer
        For Each ctl As TextBox In items
            If Integer.TryParse(ctl.Text, ints) And ints >= 0 Then

            Else
                ctl.Focus()
                MessageBox.Show("Sesuaikan Jenis Masukan!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return 1
            End If
        Next
        Return 0
    End Function
    Public Function empty(page As TabPage)
        For Each ctl As TextBox In page.Controls.OfType(Of TextBox)()
            If ctl.Text = "" Then
                ctl.Focus()
                MessageBox.Show("Lengkapi Semua Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return 1
            End If
        Next
        Return 0
    End Function
    Public Sub connect()
        DA = New MySqlDataAdapter("Select * From akun", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "akun")
    End Sub
    Public Sub Login_Load(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        clears(Regis_page)
        clears(Login_page)
        connect()
    End Sub

    Private Sub Login_page_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim log_in = False
        If empty(Login_page) = 0 Then
            connect()
            For Each rows As DataRow In DS.Tables("akun").Rows
                If rows(1) = UCase(username.Text) And rows(2).ToString = UCase(password.Text.ToString) And rows(5) = UCase(cbstatus.Text) Then
                    log_in = True
                    id_login = rows(0)
                    username_ = rows(1)
                    pass_ = rows(2).ToString
                    text = rows(3)
                    email_ = rows(4)
                    status_ = rows(5)
                    If status_ = "PEMBELI" Then
                        Pembeli.Show()
                    ElseIf status_ = "PENJUAL" Then
                        Penjual.Show()
                    ElseIf status_ = "ADMIN" Then
                        Admin.Show()
                    End If
                    Me.Hide()
                    clears(Login_page)
                    Exit Sub
                End If
            Next
            If log_in = False Then
                MessageBox.Show("Username/Password/Status Salah", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            clears(Login_page)
        End If
    End Sub
    Private Sub Regis_page_Click(sender As Object, e As EventArgs) Handles Regis_page.Click
        noeditplace(Me)
        koneksi()
    End Sub
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If (empty(Regis_page) = 0) And (error_string({username1, nama, email}, 0) = 0) Then
            If password1.Text.Length > 5 Then
                CMD = New MySqlCommand("Select * From akun where Username = '" & UCase(username1.Text) & "'", CONN)
                    RD = CMD.ExecuteReader
                If RD.Read() = False Then
                    RD.Close()
                    CMD = New MySqlCommand("insert into akun " & "(Username, Password , Nama, Email,Status) values ('" & UCase(username1.Text) & "','" & UCase(password1.Text) & "','" & UCase(nama.Text) & "','" & (email.Text) & "','" & UCase(cbstatus1.Text) & "')", CONN)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Registrasi Berhasil", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Username Tidak Tersedia", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                RD.Close()
                clears(Regis_page)
            Else
                MessageBox.Show("Minimal Password Terdiri Dari 6 Karakter", "Input Password Salah", MessageBoxButtons.OK, MessageBoxIcon.Information)
                password1.Focus()
            End If
        End If
    End Sub
    Private Sub Login_Copy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        noeditplace(Me)
        koneksi()
        connect()
        cbstatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbstatus1.DropDownStyle = ComboBoxStyle.DropDownList
        For Each item In {"PEMBELI", "PENJUAL"}
            cbstatus1.Items.Add(item)
        Next
        For Each item In {"PEMBELI", "PENJUAL", "ADMIN"}
            cbstatus.Items.Add(item)
        Next
    End Sub
End Class