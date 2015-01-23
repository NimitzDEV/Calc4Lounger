Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdSettings
    Public pref_autoshowproui As Boolean = False
    Public pref_dots1 As Integer = 2
    Public pref_dots2 As Integer = 2
    Public pref_lasttab As Integer = 0
    Public folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\懒人计算器\"
    '====
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), folderPath & iniName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, folderPath & iniName)
    End Function
    Public Sub ReadSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        If FileExists(folderPath & "config.ini") = False Then Exit Sub
        pref_autoshowproui = GetINI("pref", "ASPUI", pref_autoshowproui)
        pref_dots1 = GetINI("pref", "dots1", pref_dots1)
        pref_dots2 = GetINI("pref", "dots2", pref_dots2)
        pref_lasttab = GetINI("pref", "lasttab", pref_lasttab)
    End Sub
    Public Sub SaveSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        WriteINI("pref", "ASPUI", pref_autoshowproui)
        WriteINI("pref", "dots1", pref_dots1)
        WriteINI("pref", "dots2", pref_dots2)
        WriteINI("pref", "lasttab", pref_lasttab)
    End Sub
End Module
