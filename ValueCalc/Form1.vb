Public Class Form1
    Dim dividerCounter As Integer
    Dim divStr As String
    Dim sumUp As Double
    '引入函数 用于网络连接的检查
    Private Declare Function InternetCheckConnection Lib "wininet.dll" Alias "InternetCheckConnectionA" (ByVal lpszUrl As String, ByVal dwFlags As Integer, ByVal dwReserved As Integer) As Integer
    '检测网络是否连接，是否可以访问CGI服务器
    Public Shared Function IfOnline() As Boolean
        Const FLAG_ICC_FORCE_CONNECTION As Integer = &H1
        Return InternetCheckConnection("http://www.forkosh.com/", FLAG_ICC_FORCE_CONNECTION, 0)
    End Function
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Form2.Close()
        LinkLabel7.Visible = False
        '检测数据是否为空
        If TextBox1.Text = "" Then
            Label6.Text = "没有任何数据输入哦，不能进行计算。。"
            SlidePanel2.IsOpen = True
            Exit Sub
        End If
        '数据纠正
        TextBox1.Text = TextBox1.Text.Trim()
        TextBox1.Text = TextBox1.Text.Replace("；", ";")
        TextBox1.Text = TextBox1.Text.Replace("。", ".")
        '为了防止数据末尾出现；而不添加数据造成平均值计算错误
        '在这里添加判断，截取最后一位，如果为分号则去掉
        If Microsoft.VisualBasic.Right(TextBox1.Text, 1) = ";" Then
            TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, Len(TextBox1.Text) - 1)
        End If
        '求计数
        returnCounter = countNum(TextBox1.Text)
        '求平均值
        sumUp = 0
        For i = 0 To returnCounter - 1
            sumUp += Val(Split(TextBox1.Text, ";")(i))
        Next
        sumUp /= returnCounter
        sumUp = Math.Round(sumUp, Slider1.Value)
        Label1.Text = "平均值：" & sumUp
        '求偏差值
        v2 = sumUp
        sumUp = 0
        For i = 0 To returnCounter - 1
            sumUp += Math.Abs(Val(Split(TextBox1.Text, ";")(i)) - v2)
        Next
        sumUp /= returnCounter
        sumUp = Math.Round(sumUp, Slider1.Value)
        v3 = sumUp
        '数据显示排版
        Label2.Text = "偏差值：" & sumUp
        Label2.Left = Label1.Left + Label1.Width + 5
        LinkLabel7.Top = Label1.Top
        LinkLabel7.Left = Label1.Left + Label1.Width + 5 + Label2.Width + 5
        LinkLabel7.Visible = True
        If CheckBoxItem1.Checked = True Then showProUI()
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
    Private Sub Slider1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slider1.ValueChanged
        Label3.Text = "小数位：" & Slider1.Value & "位"
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        Me.Width = 453
        Me.Height = 184
        '滑动界面排版
        SlidePanel1.Width = Me.Width
        SlidePanel1.Height = Me.Height
        SlidePanel1.Top = 0
        SlidePanel1.Left = 0
        SlidePanel1.IsOpen = False
        SlidePanel2.Width = Me.Width
        SlidePanel2.Height = Me.Height
        SlidePanel2.Top = 0
        SlidePanel2.Left = 0
        SlidePanel2.IsOpen = False
        SlidePanel2.BackColor = Color.RoyalBlue
        Label5.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label5.BackColor = Color.RoyalBlue
        Label6.BackColor = Color.RoyalBlue
        LinkLabel6.BackColor = Color.RoyalBlue
        LinkLabel6.ForeColor = Color.White
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SlidePanel1.IsOpen = True
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        SlidePanel1.IsOpen = False
    End Sub
    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        TextBox1.Text = ""
        Label1.Text = "平均值"
        Label2.Text = "偏差值"
        LinkLabel7.Visible = False
        Label2.Left = Label1.Left + Label2.Width + 5
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://weibo.com/NimitzDEV")
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://t.qq.com/hwl809436524")
    End Sub
    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        SlidePanel2.IsOpen = False
    End Sub
    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        'outputHtmlFile()
        'Form2.Show(Me)
        'Exit Sub
        showProUI()
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("http://www.zhihu.com/people/NimitzDEV")
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start("https://plus.google.com/u/0/106518320171687145550/posts")
    End Sub

    Private Sub showProUI()
        If IfOnline() = True Then
            outputHtmlFile()
            Form2.Show()
        Else
            Label6.Text = "当前没有网络连接，无法显示演算过程。。" & vbCrLf & vbCrLf & "（演算过程显示需要依赖在线mimetex服务）"
            SlidePanel2.IsOpen = True
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Process.Start("https://me.alipay.com/nimitzdev")
    End Sub
End Class