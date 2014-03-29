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
        serverStr = "<img src=""http://latex.codecogs.com/gif.latex?"
        If Dir(pubOperate) <> "" Then
            Kill(pubOperate)
        End If
        FileOpen(1, pubOperate, OpenMode.Output)
        Print(1, "求平均值：")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, serverStr & "\overline{a}" & "=\sum_{i=" & returnCounter & "}^{a}" & "\frac{1}{" & returnCounter & "}a_{i}" & """ />")
        Print(1, "<br>")
        Print(1, "<br>")
        tmpStr = "\left ("
        For i = 0 To returnCounter - 1
            tmpStr &= Split(Form1.TextBox1.Text, ";")(i) & "+"
        Next
        tmpStr = Microsoft.VisualBasic.Left(tmpStr, Len(tmpStr) - 1)
        tmpStr &= "\right )"
        Print(1, "&nbsp;&nbsp;" & serverStr & "=\frac{1}{" & returnCounter & "}" & tmpStr & """ />")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "&nbsp;&nbsp;" & serverStr & "=\color{Red}" & v2 & """ />")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "求平均偏差:")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, serverStr & "\Delta\overline{a}" & "=\sum_{i=" & returnCounter & "}^{\overline{a}}" & "\frac{1}{" & returnCounter & "}\left [{a}_{i}-\overline{a}" & "\right ]"" />")
        Print(1, "<br>")
        Print(1, "<br>")
        tmpStr = "\left ["
        For i = 0 To returnCounter - 1
            tmpStr &= "\left |" & Split(Form1.TextBox1.Text, ";")(i) & "-" & v2 & "\right |" & "+"
        Next
        tmpStr = Microsoft.VisualBasic.Left(tmpStr, Len(tmpStr) - 1)
        tmpStr &= "\right ]"
        Print(1, "&nbsp;&nbsp;&nbsp;&nbsp;" & serverStr & "=\frac{1}{" & returnCounter & "}" & tmpStr & """ />")
        Print(1, "<br>")
        Print(1, "<br>")
        Print(1, "&nbsp;&nbsp;&nbsp;&nbsp;" & serverStr & "=\color{Red}" & v3 & """ />")
        FileClose(1)
    End Sub
End Module
