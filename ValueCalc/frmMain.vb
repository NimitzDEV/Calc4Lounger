Public Class frmMain
    Dim sumUp As Double
    Dim dividerCounter As Integer
    Dim divStr As String
    Dim storeOrigPosition As Integer
    '引入函数 用于网络连接的检查
    Private Declare Function InternetCheckConnection Lib "wininet.dll" Alias "InternetCheckConnectionA" (ByVal lpszUrl As String, ByVal dwFlags As Integer, ByVal dwReserved As Integer) As Integer
    '检测网络是否连接，是否可以访问CGI服务器
    Public Shared Function IfOnline() As Boolean
        Const FLAG_ICC_FORCE_CONNECTION As Integer = &H1
        Return InternetCheckConnection("http://latex.codecogs.com/", FLAG_ICC_FORCE_CONNECTION, 0)
    End Function

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        Randomize()
        ReadSettings()
        Label4.Text = tbDigi1.Value & "位"
        Label5.Text = tbDigi2.Value & "位"
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDigi1.Scroll
        If tbDigi1.Value = -1 Then
            Label4.Text = "完整"
            Exit Sub
        End If
        Label4.Text = tbDigi1.Value & "位"
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcPhy.Click
        frmProUI.Close()
        llbProUI.Visible = False
        '检测数据是否为空
        If txtInputData.Text = "" Then
            MsgBox("没有任何数据输入哦，不能进行计算。。")
            Exit Sub
        End If
        '为了防止数据末尾出现；而不添加数据造成平均值计算错误
        '在这里添加判断，截取最后一位，如果为分号则去掉
        If Microsoft.VisualBasic.Right(txtInputData.Text, 1) = ";" Then
            txtInputData.Text = Microsoft.VisualBasic.Left(txtInputData.Text, Len(txtInputData.Text) - 1)
        End If
        If Microsoft.VisualBasic.Left(txtInputData.Text, 1) = ";" Then
            txtInputData.Text = Microsoft.VisualBasic.Right(txtInputData.Text, Len(txtInputData.Text) - 1)
        End If
        '求计数
        returnCounter = countNum(txtInputData.Text)
        '求平均值
        sumUp = 0
        For i = 0 To returnCounter - 1
            sumUp += Val(Split(txtInputData.Text, ";")(i))
        Next
        sumUp /= returnCounter
        If tbDigi1.Value <> -1 Then
            sumUp = Math.Round(sumUp, tbDigi1.Value)
        End If
        Label1.Text = "平均值：" & sumUp
        '求偏差值
        v2 = sumUp
        sumUp = 0
        For i = 0 To returnCounter - 1
            sumUp += Math.Abs(Val(Split(txtInputData.Text, ";")(i)) - v2)
        Next
        sumUp /= returnCounter
        If tbDigi1.Value <> -1 Then
            sumUp = Math.Round(sumUp, tbDigi1.Value)
        End If
        v3 = sumUp
        '数据显示排版
        Label2.Text = "偏差值：" & sumUp
        llbProUI.Visible = True
        If cbAutoShowProUI.Checked = True Then showProUI()
    End Sub

    Private Sub resetData()
        Label1.Text = "平均值"
        Label2.Text = "偏差值"
        llbProUI.Visible = False
        Label2.Left = Label1.Left + Label2.Width + 5
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClear1.LinkClicked
        txtInputData.Text = ""
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

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbProUI.LinkClicked
        showProUI()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbAbout.LinkClicked
        frmAbout.Show(Me)
    End Sub


    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDigi2.Scroll
        If tbDigi2.Value = -1 Then
            Label5.Text = "完整"
            Exit Sub
        End If
        Label5.Text = tbDigi2.Value & "位"
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClear2.LinkClicked
        txtInputMath.Text = ""
        tbResult.Text = "0"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcMath.Click
        Try
            Dim finallyExpr As String
            finallyExpr = Calc.Calc.Compute(txtInputMath.Text)
            If tbDigi2.Value <> -1 Then
                finallyExpr = System.Math.Round(Val(finallyExpr), tbDigi2.Value)
            End If
            tbResult.Text = finallyExpr
        Catch ex As Exception
            Debug.Print(ex.Message)
            tbResult.Text = "算式异常"
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbHelp.LinkClicked
        frmHelp.Show(Me)
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputMath.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCalcMath.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputMath.KeyPress
        If e.KeyChar = "[" Then e.KeyChar = "("
        If e.KeyChar = "]" Then e.KeyChar = ")"
        If e.KeyChar = "（" Then e.KeyChar = "("
        If e.KeyChar = "）" Then e.KeyChar = ")"
        If e.KeyChar = "】" Then e.KeyChar = ")"
        If e.KeyChar = "【" Then e.KeyChar = "（"
        If e.KeyChar = "{" Then e.KeyChar = "("
        If e.KeyChar = "}" Then e.KeyChar = ")"
        If e.KeyChar = "。" Then e.KeyChar = "."
        If e.KeyChar = "、" Then e.KeyChar = "/"
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputData.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCalcPhy.PerformClick()
        End If
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputData.KeyPress
        If e.KeyChar = "；" Then e.KeyChar = ";"
        If e.KeyChar = "。" Then e.KeyChar = "."
        If e.KeyChar = "+" Then e.KeyChar = ";"
    End Sub

    Private Sub 触摸板ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiTouchPanel.Click
        If TabControl1.SelectedIndex = 2 Then
            MsgBox("当前的功能不支持触摸板的输入")
            Exit Sub
        End If
        frmTouch.Show(Me)
        Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - (Me.Height + frmTouch.Height)) / 2
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInputData.TextChanged
        Debug.Print(txtInputData.SelectionStart)
    End Sub

    Private Sub quickFunctionInput(ByVal funcSign As String)
        Dim selInput As String
        selInput = ""
        Select Case funcSign
            Case "Sqrt"
                selInput = "sqrt()"
            Case "Abs"
                selInput = "abs()"
            Case "e"
                selInput = "e"
            Case "pi"
                selInput = "pi"
            Case "Rnd"
                selInput = "rnd"
            Case "Fact"
                selInput = "fact()"
        End Select
        txtInputMath.Text &= selInput
    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        quickFunctionInput("Sqrt")
    End Sub

    Private Sub btnAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbs.Click
        quickFunctionInput("Abs")
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        quickFunctionInput("e")
    End Sub

    Private Sub btnPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPi.Click
        quickFunctionInput("pi")
    End Sub

    Private Sub btnRnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRnd.Click
        quickFunctionInput("Rnd")
    End Sub

    Private Sub btnFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFact.Click
        quickFunctionInput("Fact")
    End Sub

    Private Sub btnCalcDateDiff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcDateDiff.Click
        If DateDiff("d", mcldA.SelectionStart, mcldB.SelectionStart) = 0 Then
            MsgBox("这两个日期没有差别")
            Exit Sub
        End If
        frmProDateDiff.Show()
    End Sub
End Class