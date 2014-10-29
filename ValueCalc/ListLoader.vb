Imports System.Reflection
Imports System.IO

Module ListLoader
    Public listName(0) As String
    Public listData(0) As String
    Public catListName(0) As String
    Public catListData(0) As String
    Dim catCount As Integer
    Private Function readFile(ByVal filePath As String) As String
        Dim assembly__1 = Assembly.GetExecutingAssembly()
        Dim resourceName = filePath
        Using stream As Stream = assembly__1.GetManifestResourceStream(resourceName)
            Using reader As New StreamReader(stream)
                Dim result As String = reader.ReadToEnd()
                Return result
            End Using
        End Using
    End Function

    Public Sub initCatList(ByVal listContainer As ComboBox)
        Dim listString As String
        Dim listCount As Integer
        listString = readFile("懒人计算器.catlist.txt")
        listCount = listString.Split(vbCrLf).Length - 1
        ReDim catListData(listCount), catListName(listCount)
        For i = 0 To listCount
            catListName(i) = Split(listString, vbCrLf)(i).Split("#")(0)
            catListData(i) = Split(listString, vbCrLf)(i).Split("#")(1)
        Next
        listContainer.Items.AddRange(catListName)
        listContainer.SelectedIndex = 0
    End Sub
End Module
