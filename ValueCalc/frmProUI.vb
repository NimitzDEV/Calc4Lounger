Public Class frmProUI
    Private Sub frmProUI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Kill(Application.StartupPath & "\eq.html")
    End Sub

    Private Sub frmProUI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WebBrowser1.Navigate(Application.StartupPath & "\eq.html")
        Me.Icon = frmMain.Icon
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Visible = True
        ProgressBar1.Visible = False
    End Sub

End Class