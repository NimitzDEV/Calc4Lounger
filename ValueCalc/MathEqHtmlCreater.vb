'本模块用于生成HTML页面
Module MathEqHtmlCreater
    Dim pubOperate As String
    Public returnCounter As Integer
    Public v2 As Double
    Public v3 As Double
    Dim tmpStr As String
    Dim serverStr As String
    Public Sub outputHtmlFile()
        pubOperate = Application.StartupPath & "\eq.html"
        serverStr = "<img src=""" & Application.StartupPath
        If Dir(pubOperate) <> "" Then
            Kill(pubOperate)
        End If
        FileOpen(1, pubOperate, OpenMode.Output)
        Print(1, "求平均值：")
        Print(1, "<br>")
        Print(1, "<br>")
        'First
        Shell(Application.StartupPath & "\mimetex.exe ""\overline{a}" & "=\frac{1}{" & returnCounter & "}\sum_{i=" & returnCounter & "}^{a}" & "}a_{i}"" -e eqp1.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, serverStr & "\eqp1.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        tmpStr = "\left ("
        For i = 0 To returnCounter - 1
            tmpStr &= Split(frmMain.txtInputData.Text, ";")(i) & "+"
        Next
        tmpStr = Strings.Left(tmpStr, Len(tmpStr) - 1)
        tmpStr &= "\right )"
        'Second
        Shell(Application.StartupPath & "\mimetex.exe ""=\frac{1}{" & returnCounter & "}\times" & tmpStr & """ -e eqp2.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;" & serverStr & "\eqp2.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        'Third
        Shell(Application.StartupPath & "\mimetex.exe ""=\color{Red}" & v2 & """ -e eqp3.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;" & serverStr & "\eqp3.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "求平均偏差:")
        Print(1, "<br>")
        Print(1, "<br>")
        'forth
        Shell(Application.StartupPath & "\mimetex.exe ""\Delta\overline{a}" & "=\frac{1}{" & returnCounter & "}\sum_{i=" & returnCounter & "}^{\overline{a}}\left [\left |{a}_{i}-\overline{a}\right |\right ]"" -e eqp4.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, serverStr & "\eqp4.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        tmpStr = "\left ["
        For i = 0 To returnCounter - 1
            tmpStr &= "\left |" & Split(frmMain.txtInputData.Text, ";")(i) & "-" & v2 & "\right |" & "+"
        Next
        tmpStr = Strings.Left(tmpStr, Len(tmpStr) - 1)
        tmpStr &= "\right ]"
        'fifth
        Shell(Application.StartupPath & "\mimetex.exe ""=\frac{1}{" & returnCounter & "}\times" & tmpStr & """ -e eqp5.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;&nbsp;&nbsp;" & serverStr & "\eqp5.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        'last
        Shell(Application.StartupPath & "\mimetex.exe ""=\color{Red}" & v3 & """ -e eqp6.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;&nbsp;&nbsp;" & serverStr & "\eqp6.gif"" />")
        FileClose(1)
    End Sub
End Module
