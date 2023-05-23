Imports System.Windows

Public Class logo_show
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackgroundImage = My.Resources.bike
        Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
        Dim a As Integer
        For a = 100 To 0 Step -1
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
        Me.Close()
    End Sub
End Class