Public Class frmMain
    Dim sumUp As Double
    Dim dividerCounter As Integer
    Dim divStr As String
    '引入函数 用于网络连接的检查
    Private Declare Function InternetCheckConnection Lib "wininet.dll" Alias "InternetCheckConnectionA" (ByVal lpszUrl As String, ByVal dwFlags As Integer, ByVal dwReserved As Integer) As Integer
    '检测网络是否连接，是否可以访问CGI服务器
    Public Shared Function IfOnline() As Boolean
        Const FLAG_ICC_FORCE_CONNECTION As Integer = &H1
        Return InternetCheckConnection("http://latex.codecogs.com/", FLAG_ICC_FORCE_CONNECTION, 0)
    End Function
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        Randomize()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = -1 Then
            Label4.Text = "完整"
            Exit Sub
        End If
        Label4.Text = TrackBar1.Value & "位"
    End Sub
    Private Function countNum(ByVal inputStr As String) As Integer
        '计算有多少个数值需要计算
        dividerCounter = 0
        For i = 0 To Len(inputStr)
            divStr = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(inputStr, i), 1)
            If divStr = ";" Then dividerCounter += 1
        Next
        countNum = dividerCounter + 1
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmProUI.Close()
        LinkLabel7.Visible = False
        '检测数据是否为空
        If TextBox1.Text = "" Then
            MsgBox("没有任何数据输入哦，不能进行计算。。")
            Exit Sub
        End If
        '为了防止数据末尾出现；而不添加数据造成平均值计算错误
        '在这里添加判断，截取最后一位，如果为分号则去掉
        If Microsoft.VisualBasic.Right(TextBox1.Text, 1) = ";" Then
            TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, Len(TextBox1.Text) - 1)
        End If
        If Microsoft.VisualBasic.Left(TextBox1.Text, 1) = ";" Then
            TextBox1.Text = Microsoft.VisualBasic.Right(TextBox1.Text, Len(TextBox1.Text) - 1)
        End If
        '求计数
        returnCounter = countNum(TextBox1.Text)
        '求平均值
        sumUp = 0
        For i = 0 To returnCounter - 1
            sumUp += Val(Split(TextBox1.Text, ";")(i))
        Next
        sumUp /= returnCounter
        If TrackBar1.Value <> -1 Then
            sumUp = Math.Round(sumUp, TrackBar1.Value)
        End If
        Label1.Text = "平均值：" & sumUp
        '求偏差值
        v2 = sumUp
        sumUp = 0
        For i = 0 To returnCounter - 1
            sumUp += Math.Abs(Val(Split(TextBox1.Text, ";")(i)) - v2)
        Next
        sumUp /= returnCounter
        If TrackBar1.Value <> -1 Then
            sumUp = Math.Round(sumUp, TrackBar1.Value)
        End If
        v3 = sumUp
        '数据显示排版
        Label2.Text = "偏差值：" & sumUp
        Label2.Left = Label1.Left + Label1.Width + 5
        LinkLabel7.Top = Label1.Top
        LinkLabel7.Left = Label1.Left + Label1.Width + 5 + Label2.Width + 5
        LinkLabel7.Visible = True
        If CheckBox1.Checked = True Then showProUI()
    End Sub

    Private Sub resetData()
        Label1.Text = "平均值"
        Label2.Text = "偏差值"
        LinkLabel7.Visible = False
        Label2.Left = Label1.Left + Label2.Width + 5
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        TextBox1.Text = ""
        resetData()
    End Sub
    Private Sub showProUI()
        If frmProUI.ToString <> "" Then frmProUI.Close()
        If IfOnline() = True Then
            outputHtmlFile()
            frmProUI.Show()
        Else
            MsgBox("当前没有网络连接，无法显示演算过程。。" & vbCrLf & vbCrLf & "（演算过程显示需要依赖在线LaTeX服务）")
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        showProUI()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmAbout.Show(Me)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        '数据纠正
        TextBox1.Text = TextBox1.Text.Trim()
        TextBox1.Text = TextBox1.Text.Replace("；", ";")
        TextBox1.Text = TextBox1.Text.Replace("。", ".")
        TextBox1.SelectionStart = Len(TextBox1.Text)
        resetData()
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        If TrackBar2.Value = -1 Then
            Label5.Text = "完整"
            Exit Sub
        End If
        Label5.Text = TrackBar2.Value & "位"
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim finallyExpr As String
        finallyExpr = Calc.Calc.Compute(TextBox2.Text)
        If TrackBar2.Value <> -1 Then
            finallyExpr = System.Math.Round(Val(finallyExpr), TrackBar2.Value)
        End If
        TextBox3.Text = finallyExpr
    End Sub
End Class