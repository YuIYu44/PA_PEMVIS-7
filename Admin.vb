Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Admin
    Private Sub manajemen_akun_Load() Handles Me.Load
        Login_Copy.login(ToolStripStatusLabel1)
        Login_Copy.noeditplace(Me)
        connect()
    End Sub
    Public Sub connect()
        DA = New MySqlDataAdapter("Select * From akun where Status = 'PENJUAL'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "akun")
        akun.DataSource = DS.Tables("akun")
        akun.Refresh()
        Dim header = {"ID", "Username", "Password", "Nama", "Email", "Status"}
        For y = 0 To 5
            akun.Columns(y).HeaderText = header(y)
        Next
        Login_Copy.insidetools(False, True, akun)
        akun.Columns(0).ReadOnly = True
        akun.Columns(1).ReadOnly = True
        akun.Columns(5).ReadOnly = True
        Login_Copy.Tampilriwayat(laporan, 1)
        laporan.RowHeadersVisible = False
        Login_Copy.logos(My.Resources.admin, Me.logo)
    End Sub
    Private Sub manajemen_akun_closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login_Copy.Show()
    End Sub
    Private Sub gridvalues(sender As Object, e As DataGridViewCellEventArgs) Handles akun.CellEndEdit
        Dim idx = sender.CurrentCell.RowIndex
        If Login_Copy.error_string({sender.rows(idx).cells(2).value, sender.rows(idx).cells(3).value, sender.rows(idx).cells(4).value}, 1) = 0 Then
            If sender.rows(idx).cells(2).value.Length > 5 Then
                Dim id = CInt(sender.rows(idx).cells(0).value)
                CMD = New MySqlCommand("Update akun set Username = '" & UCase(sender.rows(idx).cells("Username").value) & "',Password = '" & UCase(sender.rows(idx).cells("Password").value) & "', Nama = '" & UCase(sender.rows(idx).cells("Nama").value) & "', Email = '" & sender.rows(idx).cells("Email").value & "', Status = '" & UCase(sender.rows(idx).cells("Status").value) & "' where id_akun = " & id, CONN)
                CMD.ExecuteNonQuery()
            Else
                MessageBox.Show("Minimal Password Terdiri Dari 6 Karakter", "Input Password Salah", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        connect()
    End Sub
    Private Sub deleted(sender As Object, e As DataGridViewRowCancelEventArgs) Handles akun.UserDeletingRow
        Dim id_deleted = CInt(sender.rows(sender.CurrentCell.RowIndex).cells(0).value)
        CMD = New MySqlCommand("Delete From akun Where id_akun = " & id_deleted, CONN)
        CMD.ExecuteNonQuery()
        DA = New MySqlDataAdapter("Select * From sepeda Where id_penjual = " & id_deleted, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "sepeda")
        If DS.Tables(0).Rows.Count > 0 Then
            For i = 0 To DS.Tables(0).Rows.Count - 1
                Dim pic = DS.Tables("sepeda").Rows(i)("gambar")
                File.Delete("image_sepeda\" & pic)
            Next
            CMD = New MySqlCommand("Delete From sepeda Where id_penjual = " & id_deleted, CONN)
            CMD.ExecuteNonQuery()
        End If
    End Sub
    Private Sub manajemenakun_Click(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        connect()
    End Sub
    Private Sub btntutorial_Click(sender As Object, e As EventArgs) Handles btntutorial.Click
        If File.Exists("Tutorial.txt") = True Then
            Process.Start("Tutorial.txt")
        Else
            MsgBox("Tutorial.txt tidak ada dalam folder")
        End If
    End Sub
End Class