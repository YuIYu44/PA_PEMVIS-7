Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Pembeli
    Public index As Integer = 0
    Public Sub total_jumlah()
        total.Text = 0
        For indexs = 0 To index - 1
            If pesanan.Rows(indexs).Cells(4).Value IsNot "" Then
                total.Text = CInt(total.Text) + CInt(pesanan.Rows(indexs).Cells(3).Value)
            End If
        Next
    End Sub
    Public Sub views(Names As String)
        LISTPIC.Items.Clear()
        LISTPIC.View = View.LargeIcon
        Dim imgs As New ImageList
        imgs.ImageSize = New Point(120, 105)
        Dim itemfolder As New List(Of ListViewItem)
        For Each fpath In Directory.GetFiles("image_sepeda")
            If (fpath.Contains(".jpeg") And Names = "") Or (fpath.Contains(Names) And Names <> "") Then
                imgs.Images.Add(Image.FromFile(fpath))
                itemfolder.Add(New ListViewItem(Path.GetFileNameWithoutExtension(fpath)) With {.ImageIndex = imgs.Images.Count - 1})
            End If
        Next
        LISTPIC.LargeImageList = imgs
        LISTPIC.Font = New Font(New FontFamily("Arial"), 10, FontStyle.Bold)
        LISTPIC.Items.AddRange(itemfolder.ToArray())
    End Sub
    Private Sub pembeli_Load() Handles MyBase.Load
        views("")
        Login_Copy.Tampilriwayat(gridriwayat, 0)
        Login_Copy.insidetools(False, True, pesanan)
        gridriwayat.RowHeadersVisible = False
        Login_Copy.noeditplace(Me)
        pesanan.ColumnCount = {"Nama Sepeda", "Harga", "Jumlah", "Total", "Penjual"}.Length
        For i = 0 To {"nama_sepeda", "harga", "jumlah", "total", "penjual"}.Length - 1
            pesanan.Columns(i).Name = UCase({"Nama sepeda", "Harga", "Jumlah", "Total", "Penjual"}(i))
        Next
        For Each item In {0, 1, 3, 4}
            pesanan.Columns(item).ReadOnly = True
        Next
    End Sub
    Private Sub closed(sender As Object, e As EventArgs) Handles Me.FormClosed
        Login_Copy.Show()
        detail.Close()
    End Sub
    Private Sub btnbeli_Click(sender As Object, e As EventArgs) Handles btnbeli.Click
        If pesanan.RowCount > 0 Then
            For rows = 0 To pesanan.Rows.Count - 1
                If pesanan.Rows(rows).Cells(2).Value > 0 Then
                    DA = New MySqlDataAdapter("Select * From sepeda INNER JOIN akun On sepeda.id_penjual=akun.id_akun where nama_sepeda = '" & pesanan.Rows(rows).Cells(0).Value & "'", CONN)
                    DS = New DataSet
                    DS.Clear()
                    DA.Fill(DS, "sepeda")
                    If CInt(DS.Tables("sepeda").Rows(0)("total")) >= CInt(pesanan.Rows(rows).Cells(2).Value) Then
                        CMD = New MySqlCommand("Update sepeda Set total = total -" & CInt(pesanan.Rows(rows).Cells(2).Value) & " where nama_sepeda = '" & pesanan.Rows(rows).Cells(0).Value & "'", CONN)
                        CMD.ExecuteNonQuery()
                        CMD = New MySqlCommand("insert into terbeli " & "(nama_barang, jumlah_barang, pembeli, penjual, total) values ('" & UCase(pesanan.Rows(rows).Cells(0).Value) & "'," & CInt(pesanan.Rows(rows).Cells(2).Value) & "," & CInt(Login_Copy.id_login) & ",'" & DS.Tables("sepeda").Rows(0)("id_penjual") & "'," & CInt(pesanan.Rows(rows).Cells(3).Value) & ")", CONN)
                        CMD.ExecuteNonQuery()
                    End If
                End If
            Next
            pesanan.Rows.Clear()
            pesanan.Refresh()
            index = 0
            total_jumlah()
            pembeli_Load()
            search.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub gridpesan_CellContentClick_1() Handles pesanan.UserDeletedRow
        index -= 1
        total_jumlah()
    End Sub
    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles btnsearch.Click
        If search.Text = "" Then
            views("")
        Else
            views(search.Text.ToUpper())
        End If
    End Sub
    Private Sub sepeda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            detail.image_bike.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(sender.Rows(e.RowIndex).Cells(4).Value.ToString)))
            detail.labelharga.Text = CInt(sender.Rows(e.RowIndex).Cells(1).Value)
            detail.labelmerk.Text = sender.Rows(e.RowIndex).Cells(0).Value.ToString
            detail.labelpenjual.Text = sender.Rows(e.RowIndex).Cells(3).Value.ToString
            detail.stok.Text = sender.Rows(e.RowIndex).Cells(2).Value.ToString
            detail.Show()
        End If
    End Sub
    Private Sub gridpesan_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles pesanan.CellEndEdit
        If e.ColumnIndex = 2 Then
            pesanan.Rows(e.RowIndex).Cells(3).Value = CInt(pesanan.Rows(e.RowIndex).Cells(2).Value) * CInt(pesanan.Rows(e.RowIndex).Cells(1).Value)
        End If
        total_jumlah()
    End Sub
    Public Sub Login_Load(sender As Object, e As EventArgs) Handles pembeli_control.SelectedIndexChanged
        oldpass.Focus()
        Login_Copy.Tampilriwayat(gridriwayat, 0)
        txtnama.Text = Login_Copy.text
        txtemail.Text = Login_Copy.email_
        txtusername.Text = Login_Copy.username_
    End Sub
    Private Sub btntutorial_Click(sender As Object, e As EventArgs) Handles btntutorial.Click
        If File.Exists("tutorial.txt") = True Then
            Process.Start("tutorial.txt")
        Else
            MessageBox.Show("Tutorial.txt tidak ada dalam folder", "NO FILE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles editpass.Click
        If UCase(oldpass.Text) = Login_Copy.pass_ And newpass.Text IsNot "" And newpass.Text.Length > 5 Then
            CMD = New MySqlCommand("Update akun" & " Set Password = '" & UCase(newpass.Text) & "' where Username = '" & txtusername.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Reset Password Berhasil", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login_Copy.pass_ = UCase(newpass.Text)
        Else
            MessageBox.Show("Password Lama/Baru Tidak Sesuai. Reset Password Gagal", "GAGAL RESET", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        oldpass.Text = ""
        newpass.Text = ""
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTPIC.MouseDoubleClick
        If LISTPIC.SelectedItems.Count > 0 Then
            detail.image_bike.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes("image_sepeda\" & LISTPIC.SelectedItems(0).SubItems(0).Text + ".jpeg")))
            DA = New MySqlDataAdapter("Select * From sepeda INNER JOIN akun On sepeda.id_penjual=akun.id_akun where gambar = '" & LISTPIC.SelectedItems(0).SubItems(0).Text & ".jpeg'", CONN)
            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "sepeda")
            detail.labelharga.Text = DS.Tables("sepeda").Rows(0)("harga")
            detail.labelmerk.Text = DS.Tables("sepeda").Rows(0)("nama_sepeda")
            detail.labelpenjual.Text = DS.Tables("sepeda").Rows(0)("Username")
            detail.stok.Text = DS.Tables("sepeda").Rows(0)("total")
            If CInt(DS.Tables("sepeda").Rows(0)("total")) > 0 Then
                detail.Show()
                detail.jmlh.Focus()
            Else
                MessageBox.Show("MOHON MAAF BARANG SEDANG RESTOCK", "BARANG TIDAK TERSEDIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class