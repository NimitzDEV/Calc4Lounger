Imports System.Reflection
Imports System.IO

Module ListLoader
    Public listName(0) As String
    Public listData(0) As String
    Public catListName(0) As String
    Public catListData(0) As String
    Public detailListName(0) As String
    Public detailListData(0) As Double
    Dim catCount As Integer
    '----
    Public currentValueA As Double
    Public currentValueB As Double
    Private Function readFile(ByVal filePath As String) As String
        Dim assembly__1 = Assembly.GetExecutingAssembly()
        Using stream As Stream = assembly__1.GetManifestResourceStream(filePath)
            Using reader As New StreamReader(stream)
                Return reader.ReadToEnd()
            End Using
        End Using
    End Function

    Public Sub initCatList(ByVal listContainer As ContextMenuStrip)
        Dim listString As String
        Dim listCount As Integer
        listString = readFile("懒人计算器.catlist.txt")
        listCount = listString.Split(vbCrLf).Length - 1
        ReDim catListData(listCount), catListName(listCount)
        For i = 0 To listCount
            catListName(i) = Split(listString, vbCrLf)(i).Split("#")(0)
            catListData(i) = Split(listString, vbCrLf)(i).Split("#")(1)
            listContainer.Items.Add(catListName(i), Nothing, AddressOf catSelHandler).Tag = i
        Next
        frmMain.btnCatSel.Text = catListName(0)
        loadDetails(catListData(0))
        frmMain.tbOU.Text = 0
        frmMain.tbCU.Text = 0
    End Sub
    Public Sub loadDetails(ByVal listPath As String)
        Dim listString As String
        Dim listCount As Integer
        listString = readFile(listPath)
        listCount = listString.Split(vbCrLf).Length - 1
        ReDim detailListData(listCount), detailListName(listCount)
        For i = 0 To listCount
            detailListName(i) = Split(listString, vbCrLf)(i).Split("#")(0)
            detailListData(i) = Split(listString, vbCrLf)(i).Split("#")(1)
            frmMain.cmsOU.Items.Add(detailListName(i), Nothing, AddressOf valueAHandle).Tag = i
            frmMain.cmsCU.Items.Add(detailListName(i), Nothing, AddressOf valueBHandle).Tag = i
        Next
        frmMain.btnCU.Text = detailListName(0)
        frmMain.btnOU.Text = detailListName(0)
        currentValueA = detailListData(0)
        currentValueB = detailListData(0)
    End Sub
    Public Sub catSelHandler(sender As Object, e As EventArgs)
        Debug.Print(sender.tag)
        frmMain.btnCatSel.Text = catListName(sender.tag)
        frmMain.cmsCU.Items.Clear()
        frmMain.cmsOU.Items.Clear()
        loadDetails(catListData(sender.tag))
        frmMain.tbOU.Text = 0
        frmMain.tbCU.Text = 0
        redoUI()
    End Sub
    Public Sub valueAHandle(sender As Object, e As EventArgs)
        frmMain.btnOU.Text = detailListName(sender.tag)
        currentValueA = detailListData(sender.tag)
        doConver()
    End Sub
    Public Sub valueBHandle(sender As Object, e As EventArgs)
        frmMain.btnCU.Text = detailListName(sender.tag)
        currentValueB = detailListData(sender.tag)
        doConver()
    End Sub
    Public Sub doConver()
        redoUI()
        Try
            If frmMain.tbOU.Text = "" Then Exit Sub
            frmMain.tbCU.Text = frmMain.tbOU.Text * (currentValueB / currentValueA)
        Catch ex As Exception
            frmMain.tbCU.Text = "ERR!"
        End Try
    End Sub
    Private Sub redoUI()
        frmMain.btnOU.Left = frmMain.Width - frmMain.btnOU.Width - 22
        frmMain.tbOU.Width = frmMain.Width - 35 - frmMain.btnOU.Width
        frmMain.btnCU.Left = frmMain.Width - frmMain.btnCU.Width - 22
        frmMain.tbCU.Width = frmMain.Width - 35 - frmMain.btnCU.Width
    End Sub
End Module
