Module SettingsManager
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
End Module
