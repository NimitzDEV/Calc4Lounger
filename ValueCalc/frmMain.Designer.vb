<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtInputData = New System.Windows.Forms.TextBox()
        Me.llbProUI = New System.Windows.Forms.LinkLabel()
        Me.llbClear1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbAutoShowProUI = New System.Windows.Forms.CheckBox()
        Me.btnCalcPhy = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFact = New System.Windows.Forms.Button()
        Me.btnRnd = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.llbClear2 = New System.Windows.Forms.LinkLabel()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDigi2 = New System.Windows.Forms.TrackBar()
        Me.btnCalcMath = New System.Windows.Forms.Button()
        Me.txtInputMath = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbDigi1 = New System.Windows.Forms.TrackBar()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalcDateDiff = New System.Windows.Forms.Button()
        Me.mcldB = New System.Windows.Forms.MonthCalendar()
        Me.mcldA = New System.Windows.Forms.MonthCalendar()
        Me.tbUnits = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.llbRev = New System.Windows.Forms.LinkLabel()
        Me.tbCU = New System.Windows.Forms.TextBox()
        Me.tbOU = New System.Windows.Forms.TextBox()
        Me.btnCU = New System.Windows.Forms.Button()
        Me.btnOU = New System.Windows.Forms.Button()
        Me.btnCatSel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.llbHelp = New System.Windows.Forms.LinkLabel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.llbWeb = New System.Windows.Forms.LinkLabel()
        Me.cmsCatSel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsOU = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsCU = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.tbDigi2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.tbDigi1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.tbUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInputData
        '
        Me.txtInputData.Location = New System.Drawing.Point(6, 24)
        Me.txtInputData.Name = "txtInputData"
        Me.txtInputData.Size = New System.Drawing.Size(480, 21)
        Me.txtInputData.TabIndex = 0
        Me.txtInputData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'llbProUI
        '
        Me.llbProUI.AutoSize = True
        Me.llbProUI.Location = New System.Drawing.Point(8, 151)
        Me.llbProUI.Name = "llbProUI"
        Me.llbProUI.Size = New System.Drawing.Size(53, 12)
        Me.llbProUI.TabIndex = 17
        Me.llbProUI.TabStop = True
        Me.llbProUI.Text = "演算过程"
        Me.llbProUI.Visible = False
        '
        'llbClear1
        '
        Me.llbClear1.AutoSize = True
        Me.llbClear1.Location = New System.Drawing.Point(376, 56)
        Me.llbClear1.Name = "llbClear1"
        Me.llbClear1.Size = New System.Drawing.Size(29, 12)
        Me.llbClear1.TabIndex = 16
        Me.llbClear1.TabStop = True
        Me.llbClear1.Text = "清除"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "偏差值"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "平均值"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "小数位"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "2位"
        '
        'cbAutoShowProUI
        '
        Me.cbAutoShowProUI.AutoSize = True
        Me.cbAutoShowProUI.Location = New System.Drawing.Point(306, 185)
        Me.cbAutoShowProUI.Name = "cbAutoShowProUI"
        Me.cbAutoShowProUI.Size = New System.Drawing.Size(180, 16)
        Me.cbAutoShowProUI.TabIndex = 22
        Me.cbAutoShowProUI.Text = "点击计算后自动打开演算过程"
        Me.cbAutoShowProUI.UseVisualStyleBackColor = True
        '
        'btnCalcPhy
        '
        Me.btnCalcPhy.Location = New System.Drawing.Point(411, 51)
        Me.btnCalcPhy.Name = "btnCalcPhy"
        Me.btnCalcPhy.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcPhy.TabIndex = 23
        Me.btnCalcPhy.Text = "计算结果"
        Me.btnCalcPhy.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.tbUnits)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(502, 233)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.btnFact)
        Me.TabPage2.Controls.Add(Me.btnRnd)
        Me.TabPage2.Controls.Add(Me.btnPi)
        Me.TabPage2.Controls.Add(Me.btnE)
        Me.TabPage2.Controls.Add(Me.btnAbs)
        Me.TabPage2.Controls.Add(Me.btnSqrt)
        Me.TabPage2.Controls.Add(Me.llbClear2)
        Me.TabPage2.Controls.Add(Me.tbResult)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.tbDigi2)
        Me.TabPage2.Controls.Add(Me.btnCalcMath)
        Me.TabPage2.Controls.Add(Me.txtInputMath)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(494, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "算式运算"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "请输入算式"
        '
        'btnFact
        '
        Me.btnFact.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnFact.Location = New System.Drawing.Point(152, 51)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(26, 23)
        Me.btnFact.TabIndex = 32
        Me.btnFact.Text = "！"
        Me.btnFact.UseVisualStyleBackColor = True
        '
        'btnRnd
        '
        Me.btnRnd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRnd.Location = New System.Drawing.Point(122, 51)
        Me.btnRnd.Name = "btnRnd"
        Me.btnRnd.Size = New System.Drawing.Size(26, 23)
        Me.btnRnd.TabIndex = 31
        Me.btnRnd.Text = "R"
        Me.btnRnd.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Location = New System.Drawing.Point(93, 51)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(26, 23)
        Me.btnPi.TabIndex = 30
        Me.btnPi.Text = "π"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(64, 51)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(26, 23)
        Me.btnE.TabIndex = 29
        Me.btnE.Text = "e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnAbs
        '
        Me.btnAbs.Location = New System.Drawing.Point(35, 51)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(26, 23)
        Me.btnAbs.TabIndex = 28
        Me.btnAbs.Text = "||"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(6, 51)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(26, 23)
        Me.btnSqrt.TabIndex = 27
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'llbClear2
        '
        Me.llbClear2.AutoSize = True
        Me.llbClear2.Location = New System.Drawing.Point(378, 56)
        Me.llbClear2.Name = "llbClear2"
        Me.llbClear2.Size = New System.Drawing.Size(29, 12)
        Me.llbClear2.TabIndex = 26
        Me.llbClear2.TabStop = True
        Me.llbClear2.Text = "清除"
        '
        'tbResult
        '
        Me.tbResult.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbResult.Location = New System.Drawing.Point(5, 172)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.Size = New System.Drawing.Size(481, 29)
        Me.tbResult.TabIndex = 25
        Me.tbResult.Text = "0"
        Me.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "运算结果"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "2位"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "小数位"
        '
        'tbDigi2
        '
        Me.tbDigi2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDigi2.LargeChange = 1
        Me.tbDigi2.Location = New System.Drawing.Point(55, 100)
        Me.tbDigi2.Minimum = -1
        Me.tbDigi2.Name = "tbDigi2"
        Me.tbDigi2.Size = New System.Drawing.Size(183, 45)
        Me.tbDigi2.TabIndex = 21
        Me.tbDigi2.Value = 2
        '
        'btnCalcMath
        '
        Me.btnCalcMath.Location = New System.Drawing.Point(413, 51)
        Me.btnCalcMath.Name = "btnCalcMath"
        Me.btnCalcMath.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcMath.TabIndex = 1
        Me.btnCalcMath.Text = "运算式子"
        Me.btnCalcMath.UseVisualStyleBackColor = True
        '
        'txtInputMath
        '
        Me.txtInputMath.Location = New System.Drawing.Point(6, 24)
        Me.txtInputMath.Name = "txtInputMath"
        Me.txtInputMath.Size = New System.Drawing.Size(482, 21)
        Me.txtInputMath.TabIndex = 0
        Me.txtInputMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnCalcPhy)
        Me.TabPage1.Controls.Add(Me.txtInputData)
        Me.TabPage1.Controls.Add(Me.cbAutoShowProUI)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.llbClear1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.llbProUI)
        Me.TabPage1.Controls.Add(Me.tbDigi1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(494, 207)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "平均与偏差"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 12)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "请输入数据，使用分号间隔"
        '
        'tbDigi1
        '
        Me.tbDigi1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDigi1.LargeChange = 1
        Me.tbDigi1.Location = New System.Drawing.Point(55, 53)
        Me.tbDigi1.Minimum = -1
        Me.tbDigi1.Name = "tbDigi1"
        Me.tbDigi1.Size = New System.Drawing.Size(186, 45)
        Me.tbDigi1.TabIndex = 18
        Me.tbDigi1.Value = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(494, 207)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "电路工具箱"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "色环电阻计算器"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.btnCalcDateDiff)
        Me.TabPage3.Controls.Add(Me.mcldB)
        Me.TabPage3.Controls.Add(Me.mcldA)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(494, 207)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "天数差"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(293, 12)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "在下面两个日历中选择两个日期来计算他们的天数差别"
        '
        'btnCalcDateDiff
        '
        Me.btnCalcDateDiff.Location = New System.Drawing.Point(416, 0)
        Me.btnCalcDateDiff.Name = "btnCalcDateDiff"
        Me.btnCalcDateDiff.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcDateDiff.TabIndex = 2
        Me.btnCalcDateDiff.Text = "计算"
        Me.btnCalcDateDiff.UseVisualStyleBackColor = True
        '
        'mcldB
        '
        Me.mcldB.Location = New System.Drawing.Point(248, 24)
        Me.mcldB.Name = "mcldB"
        Me.mcldB.ShowWeekNumbers = True
        Me.mcldB.TabIndex = 1
        '
        'mcldA
        '
        Me.mcldA.Location = New System.Drawing.Point(0, 24)
        Me.mcldA.Name = "mcldA"
        Me.mcldA.ShowWeekNumbers = True
        Me.mcldA.TabIndex = 0
        '
        'tbUnits
        '
        Me.tbUnits.Controls.Add(Me.Label12)
        Me.tbUnits.Controls.Add(Me.llbRev)
        Me.tbUnits.Controls.Add(Me.tbCU)
        Me.tbUnits.Controls.Add(Me.tbOU)
        Me.tbUnits.Controls.Add(Me.btnCU)
        Me.tbUnits.Controls.Add(Me.btnOU)
        Me.tbUnits.Controls.Add(Me.btnCatSel)
        Me.tbUnits.Controls.Add(Me.Label11)
        Me.tbUnits.Location = New System.Drawing.Point(4, 22)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Padding = New System.Windows.Forms.Padding(3)
        Me.tbUnits.Size = New System.Drawing.Size(494, 207)
        Me.tbUnits.TabIndex = 4
        Me.tbUnits.Text = "单位换算"
        Me.tbUnits.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 56)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "="
        '
        'llbRev
        '
        Me.llbRev.AutoSize = True
        Me.llbRev.Location = New System.Drawing.Point(8, 91)
        Me.llbRev.Name = "llbRev"
        Me.llbRev.Size = New System.Drawing.Size(53, 12)
        Me.llbRev.TabIndex = 9
        Me.llbRev.TabStop = True
        Me.llbRev.Text = "正负切换"
        '
        'tbCU
        '
        Me.tbCU.Enabled = False
        Me.tbCU.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbCU.Location = New System.Drawing.Point(8, 150)
        Me.tbCU.Name = "tbCU"
        Me.tbCU.Size = New System.Drawing.Size(397, 26)
        Me.tbCU.TabIndex = 7
        Me.tbCU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbOU
        '
        Me.tbOU.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbOU.Location = New System.Drawing.Point(8, 62)
        Me.tbOU.Name = "tbOU"
        Me.tbOU.Size = New System.Drawing.Size(397, 26)
        Me.tbOU.TabIndex = 6
        Me.tbOU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCU
        '
        Me.btnCU.AutoSize = True
        Me.btnCU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCU.Location = New System.Drawing.Point(411, 149)
        Me.btnCU.MinimumSize = New System.Drawing.Size(75, 28)
        Me.btnCU.Name = "btnCU"
        Me.btnCU.Size = New System.Drawing.Size(75, 28)
        Me.btnCU.TabIndex = 5
        Me.btnCU.Text = "CU"
        Me.btnCU.UseVisualStyleBackColor = True
        '
        'btnOU
        '
        Me.btnOU.AutoSize = True
        Me.btnOU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOU.Location = New System.Drawing.Point(411, 61)
        Me.btnOU.MinimumSize = New System.Drawing.Size(75, 28)
        Me.btnOU.Name = "btnOU"
        Me.btnOU.Size = New System.Drawing.Size(75, 28)
        Me.btnOU.TabIndex = 4
        Me.btnOU.Text = "OU"
        Me.btnOU.UseVisualStyleBackColor = True
        '
        'btnCatSel
        '
        Me.btnCatSel.Location = New System.Drawing.Point(411, 10)
        Me.btnCatSel.Name = "btnCatSel"
        Me.btnCatSel.Size = New System.Drawing.Size(75, 26)
        Me.btnCatSel.TabIndex = 1
        Me.btnCatSel.Text = "CatSel"
        Me.btnCatSel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(352, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "分类选择"
        '
        'llbHelp
        '
        Me.llbHelp.AutoSize = True
        Me.llbHelp.Location = New System.Drawing.Point(445, 241)
        Me.llbHelp.Name = "llbHelp"
        Me.llbHelp.Size = New System.Drawing.Size(53, 12)
        Me.llbHelp.TabIndex = 35
        Me.llbHelp.TabStop = True
        Me.llbHelp.Text = "使用帮助"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(4, 236)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 23)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "关于与更新"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'llbWeb
        '
        Me.llbWeb.AutoSize = True
        Me.llbWeb.Location = New System.Drawing.Point(386, 241)
        Me.llbWeb.Name = "llbWeb"
        Me.llbWeb.Size = New System.Drawing.Size(53, 12)
        Me.llbWeb.TabIndex = 37
        Me.llbWeb.TabStop = True
        Me.llbWeb.Text = "访问官网"
        '
        'cmsCatSel
        '
        Me.cmsCatSel.Name = "cmsCatSel"
        Me.cmsCatSel.Size = New System.Drawing.Size(61, 4)
        '
        'cmsOU
        '
        Me.cmsOU.Name = "cmsOU"
        Me.cmsOU.Size = New System.Drawing.Size(61, 4)
        '
        'cmsCU
        '
        Me.cmsCU.Name = "cmsCU"
        Me.cmsCU.Size = New System.Drawing.Size(61, 4)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(502, 261)
        Me.Controls.Add(Me.llbWeb)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.llbHelp)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.tbDigi2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.tbDigi1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.tbUnits.ResumeLayout(False)
        Me.tbUnits.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputData As System.Windows.Forms.TextBox
    Friend WithEvents llbProUI As System.Windows.Forms.LinkLabel
    Friend WithEvents llbClear1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbAutoShowProUI As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalcPhy As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtInputMath As System.Windows.Forms.TextBox
    Friend WithEvents tbDigi1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbDigi2 As System.Windows.Forms.TrackBar
    Friend WithEvents btnCalcMath As System.Windows.Forms.Button
    Friend WithEvents llbClear2 As System.Windows.Forms.LinkLabel
    Friend WithEvents tbResult As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAbs As System.Windows.Forms.Button
    Friend WithEvents btnSqrt As System.Windows.Forms.Button
    Friend WithEvents btnPi As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnRnd As System.Windows.Forms.Button
    Friend WithEvents btnFact As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents mcldB As System.Windows.Forms.MonthCalendar
    Friend WithEvents mcldA As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnCalcDateDiff As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents llbHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents llbWeb As System.Windows.Forms.LinkLabel
    Friend WithEvents tbUnits As System.Windows.Forms.TabPage
    Friend WithEvents btnCU As System.Windows.Forms.Button
    Friend WithEvents btnOU As System.Windows.Forms.Button
    Friend WithEvents btnCatSel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbCU As System.Windows.Forms.TextBox
    Friend WithEvents tbOU As System.Windows.Forms.TextBox
    Friend WithEvents cmsCatSel As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsOU As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsCU As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents llbRev As System.Windows.Forms.LinkLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
