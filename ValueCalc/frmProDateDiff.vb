Public Class frmProDateDiff
    Dim date1 As Date
    Dim date2 As Date
    Dim switchBridge As Date
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProDateDiff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        date1 = (Split(frmMain.mcldA.SelectionStart, " ")(0))
        date2 = (Split(frmMain.mcldB.SelectionStart, " ")(0))
        If date2 < date1 Then
            switchBridge = date1
            date1 = date2
            date2 = switchBridge
        End If
        lbTip1.Text = "日期 " & date1 & " 到 " & date2
        rbDay.PerformClick()
    End Sub

    Private Sub rbDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDay.CheckedChanged
        lbResult.Text = DateDiff("d", date1, date2) & "天"
    End Sub

    Private Sub rbHour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHour.CheckedChanged
        lbResult.Text = DateDiff("h", date1, date2) & "小时"
    End Sub

    Private Sub rbWeek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWeek.CheckedChanged
        lbResult.Text = DateDiff("w", date1, date2) & "周"
    End Sub
End Class