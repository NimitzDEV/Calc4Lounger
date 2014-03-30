Public Class frmProUI
    Private Sub frmProUI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Kill(Application.StartupPath & "\eq.html")
    End Sub

    Private Sub frmProUI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WebBrowser1.Navigate(Application.StartupPath & "\eq.html")
        Me.Icon = frmMain.Icon
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub frmProUI_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Button1.Left = Me.Width - Button1.Width - 80
        Button1.Top = 12
    End Sub
End Class