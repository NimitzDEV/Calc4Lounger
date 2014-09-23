Public Class frmLeadDownload

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://pan.baidu.com/s/1sjIz8rr")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(folderPath)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Dir(folderPath & "mimetex.exe") = "" Then
            MsgBox("您还没有将文件拷贝进入程序文件夹？")
        Else
            MsgBox("完成，现在您可以使用演算步骤功能了")
            Me.Close()
        End If
    End Sub
End Class