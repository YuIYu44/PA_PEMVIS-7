Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Penjual
    Dim image_file As String
    Private Sub Penjual_Load() Handles Me.Load
        Login_Copy.login(ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3)
        Login_Copy.Tampilsepeda(barang, True, False, " id_sepeda,nama_sepeda,harga ,total,gambar from sepeda", (" where id_penjual = " & Login_Copy.id_login))
        Login_Copy.noeditplace(Me)
        barang.RowHeadersVisible = False
        Login_Copy.Tampilriwayat(gridlaporan, 2)
        btnclear_Click()
        pb.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Login_Copy.Show()
    End Sub
    Private Sub button_rules(bools As Boolean)
        btnhapus.Enabled = bools
        btnedit.Enabled = bools
        nama_brg.Enabled = Not bools
        btntambah.Enabled = Not bools
    End Sub

    Private Sub btnclear_Click() Handles btnclear.Click
        Login_Copy.clears(manajemenbarang)
        ID.Text = ""
        pb.Image = Nothing
        pb.BackColor = Color.Empty
        pb.Invalidate()
        barang.ClearSelection()
        button_rules(False)
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If pb.Image IsNot Nothing Then
            If Login_Copy.empty(manajemenbarang) = 0 And Login_Copy.error_integer({harga, jumlah}) = 0 And Login_Copy.error_string({nama_brg}, 0) = 0 Then
                Dim di As DirectoryInfo = New DirectoryInfo("image_sepeda")
                If di.Exists = False Then
                    di.Create()
                End If
                Dim FileToSaveAs As String = "image_sepeda\" & UCase(nama_brg.Text) & Login_Copy.id_login & ".jpeg"
                pb.Image.Save(FileToSaveAs)
                CMD = New MySqlCommand("insert into sepeda " & "(nama_sepeda, harga, total, id_penjual, gambar) values ('" & UCase(nama_brg.Text) & "'," & CInt(harga.Text) & "," & CInt(jumlah.Text) & "," & CInt(Login_Copy.id_login) & ",'" & UCase(nama_brg.Text) & Login_Copy.id_login & ".jpeg')", CONN)
                CMD.ExecuteNonQuery()
                Penjual_Load()
                btnclear_Click()
            End If
        Else
            MessageBox.Show("Masukan Gambar Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub Login_Load(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Login_Copy.Tampilsepeda(barang, True, False, " id_sepeda,nama_sepeda,harga ,total,gambar from sepeda", (" where id_penjual = " & Login_Copy.id_login))
        Login_Copy.Tampilriwayat(gridlaporan, 2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        OpenFileDialog1.Title = "Please Select A Picture"
        OpenFileDialog1.Filter = "Image files (*.jpeg) |*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pb.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(OpenFileDialog1.FileName)))
            image_file = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub barang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles barang.CellContentClick
        button_rules(True)
        ID.Text = barang.Rows(e.RowIndex).Cells(0).Value.ToString
        nama_brg.Text = barang.Rows(e.RowIndex).Cells(1).Value.ToString
        harga.Text = barang.Rows(e.RowIndex).Cells(2).Value.ToString
        jumlah.Text = barang.Rows(e.RowIndex).Cells(3).Value.ToString
        image_file = barang.Rows(e.RowIndex).Cells(4).Value.ToString
        pb.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes("image_sepeda\" & image_file)))
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If Login_Copy.empty(manajemenbarang) = 0 And Login_Copy.error_integer({harga, jumlah}) = 0 And Login_Copy.error_string({nama_brg}, 0) = 0 Then
            Dim Filenames = UCase(nama_brg.Text) & Login_Copy.id_login & ".jpeg"
            If Path.GetFileName(image_file) <> Filenames Then
                File.Copy(image_file, "image_sepeda\" & Filenames, True)
            End If
            CMD = New MySqlCommand("Update sepeda set nama_sepeda = '" & UCase(nama_brg.Text) & "',harga = " & CInt(harga.Text) & ", total = " & CInt(jumlah.Text) & " where id_sepeda = " & ID.Text, CONN)
            CMD.ExecuteNonQuery()
            Penjual_Load()
        End If
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If Login_Copy.empty(manajemenbarang) = 0 Then
            CMD = New MySqlCommand("Delete From sepeda Where id_sepeda = " & ID.Text, CONN)
            pb.Image = Nothing
            File.Delete("image_sepeda\" & UCase(nama_brg.Text) & Login_Copy.id_login & ".jpeg")
            CMD.ExecuteNonQuery()
            Penjual_Load()
        End If
    End Sub

End Class