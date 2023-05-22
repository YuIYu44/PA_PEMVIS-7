Public Class detail
    Private Sub btnpesan_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        Try
            Dim jumlah = CInt(jmlh.Text)
            If jumlah > 0 Then
                pembeli.index += 1
                pembeli.pesanan.Rows.Add(labelmerk.Text, CInt(labelharga.Text), CInt(jmlh.Text), CInt(labelharga.Text) * CInt(jmlh.Text), labelpenjual.Text)
                pembeli.total_jumlah()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Inputan Tidak Sesuai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_Copy.noeditplace(Me)
        image_bike.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

End Class