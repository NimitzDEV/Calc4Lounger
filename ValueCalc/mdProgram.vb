Module mdProgram
    '色环电阻
    Public shData(5) As Integer
    Dim mkString As String
    '设置相关
    'Public Sub ReadSettings()
    '    With frmMain
    '        .tbDigi1.Value = My.Settings.dots1
    '        .tbDigi2.Value = My.Settings.dots2
    '        .cbAutoShowProUI.Checked = My.Settings.autoShowProUI
    '        .TabControl1.SelectedIndex = My.Settings.tabIndex
    '    End With
    'End Sub
    'Public Sub SaveSettings()
    '    With frmMain
    '        My.Settings.dots1 = .tbDigi1.Value
    '        My.Settings.dots2 = .tbDigi2.Value
    '        My.Settings.autoShowProUI = .cbAutoShowProUI.Checked
    '        My.Settings.tabIndex = .TabControl1.SelectedIndex
    '        My.Settings.Save()
    '    End With
    'End Sub
    '程序
    Public Function keyFilter(ByVal keyChar As String) As String
        If keyChar = "[" Then Return "("
        If keyChar = "]" Then Return ")"
        If keyChar = "（" Then Return "("
        If keyChar = "）" Then Return ")"
        If keyChar = "】" Then Return ")"
        If keyChar = "【" Then Return "（"
        If keyChar = "{" Then Return "("
        If keyChar = "}" Then Return ")"
        If keyChar = "。" Then Return "."
        If keyChar = "、" Then Return "/"
        If keyChar = "；" Then Return ";"
        If keyChar = " " Then Return ""
        Debug.Print(keyChar)
        Return keyChar
    End Function
    '色环电阻
    Public Function composeResult(ByVal evnDec As Integer) As String
        Debug.Print(evnDec)
        mkString = ""
        Select Case shData(0)
            Case 1, 2, 13
                mkString &= vbCrLf & "第一位色环数据输入有误"
                Return mkString
        End Select
        Select Case shData(1)
            Case 1, 2, 13
                mkString &= vbCrLf & "第二位色环数据输入有误"
                Return mkString
        End Select
        '三、四环计算
        If evnDec = 3 Or evnDec = 4 Then
            mkString = "当前为：" & IIf(evnDec = 3, "三", "四") & "色环电阻 的计算"
            '错误拦截
            Select Case shData(2)
                Case 13
                    mkString &= vbCrLf & "数量级色环数据输入有误"
                    Return mkString
            End Select
            Select Case shData(3)
                Case 3, 6, 7, 12
                    mkString &= vbCrLf & "误差色环数据输入有误"
                    Return mkString
            End Select
            '运算
            mkString &= vbCrLf & "电阻值为：" & getNumber(shData(0)) * 10 + getNumber(shData(1)) & " × " & getTimes(shData(2)) & " Ω"
            If evnDec = 4 Then mkString &= " " & getAM(shData(3))
            Return mkString
        End If
        '五、六环计算
        If evnDec = 5 Or evnDec = 6 Then
            mkString = "当前为：" & IIf(evnDec = 5, "五", "六") & "色环电阻 的计算"
            '错误拦截
            Select Case shData(2)
                Case 1, 2, 13
                    mkString &= vbCrLf & "第三位色环数据输入有误"
                    Return mkString
            End Select
            Select Case shData(4)
                Case 3, 6, 7, 12
                    mkString &= vbCrLf & "误差色环数据输入有误"
                    Return mkString
            End Select
            '运算
            mkString &= vbCrLf & "电阻值为：" & getNumber(shData(0)) * 100 + getNumber(shData(1)) * 10 + getNumber(shData(2)) & " × " & getTimes(shData(3)) & " Ω " & getAM(shData(4))
            If evnDec = 6 Then
                Select Case shData(5)
                    Case 1, 2, 3, 8, 11, 13
                        mkString &= vbCrLf & "温度系数色环数据输入有误"
                        Return mkString
                End Select
                mkString &= vbCrLf & "温度系数：" & getTemp(shData(5)) & " （×10 / ℃）"
            End If
            Return mkString
        End If
        Return "请输入色环数据"
    End Function
    '数据导出
    Private Function getNumber(ByVal content As Integer) As Integer
        Return content - 3
    End Function
    Private Function getTimes(ByVal content As Integer) As String
        If content = 13 Then Return "E"
        Return "(10×" & content - 3 & ")"
    End Function
    Private Function getAM(ByVal content As Integer) As String
        Select Case content
            Case 1
                Return "±10"
            Case 2
                Return "±5"
            Case 4
                Return "±1"
            Case 5
                Return "±2"
            Case 8
                Return "±0.5"
            Case 9
                Return "±0.25"
            Case 10
                Return "±0.1"
            Case 11
                Return "±0.05"
            Case 13
                Return "±20"
        End Select
        Return "E"
    End Function
    Private Function getTemp(ByVal content As Integer) As Integer
        Select Case content
            Case 4
                Return 100
            Case 5
                Return 50
            Case 6
                Return 15
            Case 7
                Return 25
            Case 9
                Return 10
            Case 10
                Return 5
            Case 12
                Return 1
        End Select
        Return 0
    End Function
End Module
