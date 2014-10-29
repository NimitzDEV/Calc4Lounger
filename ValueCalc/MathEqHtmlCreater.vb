'本模块用于生成HTML页面
Module MathEqHtmlCreater
    Dim pubOperate As String
    Public returnCounter As Integer
    Public v2 As Double
    Public v3 As Double
    Dim tmpStr As String
    Dim serverStr As String
    Public Sub outputHtmlFile()

        pubOperate = folderPath & "eq.html"
        serverStr = "<img src=""" & folderPath
        If Dir(pubOperate) <> "" Then
            Kill(pubOperate)
        End If
        FileOpen(1, pubOperate, OpenMode.Output)
        Print(1, "求平均值：")
        Print(1, "<br>")
        Print(1, "<br>")
        'First
        Shell(folderPath & "mimetex.exe ""\overline{a}" & "=\frac{1}{" & returnCounter & "}\sum_{i=" & returnCounter & "}^{a}" & "}a_{i}"" -e " & folderPath & "eqp1.gif -s 5", AppWinStyle.Hide, True, -1)
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
        Shell(folderPath & "mimetex.exe ""=\frac{1}{" & returnCounter & "}\times" & tmpStr & """ -e " & folderPath & "eqp2.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;" & serverStr & "\eqp2.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        'Third
        Shell(folderPath & "mimetex.exe ""=\color{Red}" & v2 & """ -e " & folderPath & "eqp3.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;" & serverStr & "\eqp3.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "求平均偏差:")
        Print(1, "<br>")
        Print(1, "<br>")
        'forth
        Shell(folderPath & "mimetex.exe ""\Delta\overline{a}" & "=\frac{1}{" & returnCounter & "}\sum_{i=" & returnCounter & "}^{\overline{a}}\left [\left |{a}_{i}-\overline{a}\right |\right ]"" -e " & folderPath & "eqp4.gif -s 5", AppWinStyle.Hide, True, -1)
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
        Shell(folderPath & "mimetex.exe ""=\frac{1}{" & returnCounter & "}\times" & tmpStr & """ -e " & folderPath & "eqp5.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;&nbsp;&nbsp;" & serverStr & "\eqp5.gif"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        'last
        Shell(folderPath & "mimetex.exe ""=\color{Red}" & v3 & """ -e " & folderPath & "eqp6.gif -s 5", AppWinStyle.Hide, True, -1)
        Print(1, "&nbsp;&nbsp;&nbsp;&nbsp;" & serverStr & "\eqp6.gif"" />")
        FileClose(1)
    End Sub
End Module
