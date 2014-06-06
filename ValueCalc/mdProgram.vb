Module mdProgram
    '设置相关
    Public Sub ReadSettings()
        With frmMain
            .tbDigi1.Value = My.Settings.dots1
            .tbDigi2.Value = My.Settings.dots2
            .cbAutoShowProUI.Checked = My.Settings.autoShowProUI
        End With
    End Sub
    Public Sub SaveSettings()
        With frmMain
            My.Settings.dots1 = .tbDigi1.Value
            My.Settings.dots2 = .tbDigi2.Value
            My.Settings.autoShowProUI = .cbAutoShowProUI.Checked
            My.Settings.Save()
        End With
    End Sub
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
        Return keyChar
    End Function
End Module
