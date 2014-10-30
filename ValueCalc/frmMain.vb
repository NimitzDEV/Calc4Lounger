Public Class frmMain
    Dim sumUp As Double
    Dim dividerCounter As Integer
    Dim divStr As String
    Dim storeOrigPosition As Integer

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initCatList(cmsCatSel)
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        Randomize()
        ReadSettings()
        TabControl1.SelectedIndex = pref_lasttab
        cbAutoShowProUI.Checked = pref_autoshowproui
        tbDigi1.Value = pref_dots1
        tbDigi2.Value = pref_dots2
        If tbDigi1.Value < 0 Then
            Label4.Text = "完整"
        Else
            Label4.Text = tbDigi1.Value & "位"
        End If
        If tbDigi2.Value < 0 Then
            Label5.Text = "完整"
        Else
            Label5.Text = tbDigi2.Value & "位"
        End If

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDigi1.Scroll
        If tbDigi1.Value = -1 Then
            Label4.Text = "完整"
            Exit Sub
        End If
        Label4.Text = tbDigi1.Value & "位"
        pref_dots2 = tbDigi2.Value
    End Sub
    Private Function countNum(ByVal inputStr As String) As Integer
        '计算有多少个数值需要计算
        dividerCounter = 0
        For i = 0 To Len(inputStr)
            divStr = Strings.Right(Strings.Left(inputStr, i), 1)
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
        If Strings.Right(txtInputData.Text, 1) = ";" Then
            txtInputData.Text = Strings.Left(txtInputData.Text, Len(txtInputData.Text) - 1)
        End If
        If Strings.Left(txtInputData.Text, 1) = ";" Then
            txtInputData.Text = Strings.Right(txtInputData.Text, Len(txtInputData.Text) - 1)
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
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClear1.LinkClicked
        txtInputData.Text = ""
        resetData()
    End Sub
    Private Sub showProUI()
        If frmProUI.ToString <> "" Then frmProUI.Close()
        If My.Computer.FileSystem.FileExists(folderPath & "mimetex.exe") = True Then
            outputHtmlFile()
            frmProUI.Show()
        Else
            MsgBox("缺少mimetex文件")
            If MsgBox("是否现在引导您下载缺失的组件？", MsgBoxStyle.OkCancel, "缺少组件") = MsgBoxResult.Ok Then
                frmLeadDownload.ShowDialog()
                frmLeadDownload.Dispose()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbProUI.LinkClicked
        showProUI()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        frmAbout.Show(Me)
    End Sub


    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDigi2.Scroll
        If tbDigi2.Value = -1 Then
            Label5.Text = "完整"
            Exit Sub
        End If
        Label5.Text = tbDigi2.Value & "位"
        pref_dots1 = tbDigi1.Value
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClear2.LinkClicked
        txtInputMath.Text = ""
        tbResult.Text = "0"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcMath.Click
        Try
            ansValue = Calc.Calc.Compute(txtInputMath.Text)
            If tbDigi2.Value <> -1 Then
                ansValue = System.Math.Round(Val(ansValue), tbDigi2.Value)
            End If
            tbResult.Text = ansValue
        Catch ex As Exception
            Debug.Print(ex.Message)
            tbResult.Text = "算式异常"
        End Try
    End Sub


    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputMath.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCalcMath.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputMath.KeyPress
        e.KeyChar = keyFilter(e.KeyChar)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInputData.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCalcPhy.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputData.KeyPress
        e.KeyChar = keyFilter(e.KeyChar)
        If e.KeyChar = "+" Then e.KeyChar = ";"
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmCRR.Show()
    End Sub




    Private Sub llbHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbHelp.LinkClicked
        frmHelp.Show(Me)
    End Sub

    Private Sub llbAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbAbout.LinkClicked
        frmAbout.Show(Me)
    End Sub


    Private Sub cbAutoShowProUI_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoShowProUI.CheckedChanged
        pref_autoshowproui = cbAutoShowProUI.Checked
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        pref_lasttab = TabControl1.SelectedIndex
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmUpdate.ShowDialog()
        frmUpdate.Dispose()
    End Sub

    Private Sub llbWeb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbWeb.LinkClicked
        Process.Start("http://ndev.cu.cc")
    End Sub


    Private Sub btnCatSel_Click(sender As Object, e As EventArgs) Handles btnCatSel.Click
        cmsCatSel.Show(btnCatSel, 0, btnCatSel.Height)
    End Sub

    Private Sub btnOU_Click(sender As Object, e As EventArgs) Handles btnOU.Click
        cmsOU.Show(btnOU, 0, btnOU.Height)
    End Sub

    Private Sub btnCU_Click(sender As Object, e As EventArgs) Handles btnCU.Click
        cmsCU.Show(btnCU, 0, btnCU.Height)
    End Sub


    Private Sub tbOU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbOU.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Chr(8) OrElse e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tbOU_TextChanged(sender As Object, e As EventArgs) Handles tbOU.TextChanged
        doConver()

    End Sub

    Private Sub llbRev_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbRev.LinkClicked
        tbOU.Text = -tbOU.Text
    End Sub
End Class