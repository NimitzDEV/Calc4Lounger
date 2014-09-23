Public Class frmProUI
    Private Sub frmProUI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            Kill(folderPath & "eq.html")
            For i = 1 To 6
                Kill(folderPath & "eqp" & i & ".gif")
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmProUI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WebBrowser1.Navigate(folderPath & "eq.html")
        Me.Icon = frmMain.Icon
        'Me.Top = 0
        'Me.Left = 0
        'Me.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2
        'Me.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height
        'frmMain.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width * 3 / 4 - frmMain.Width / 2
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Visible = True
    End Sub

End Class