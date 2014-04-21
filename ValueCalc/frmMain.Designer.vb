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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtInputData = New System.Windows.Forms.TextBox()
        Me.llbProUI = New System.Windows.Forms.LinkLabel()
        Me.llbClear1 = New System.Windows.Forms.LinkLabel()
        Me.llbAbout = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiTouchPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbAutoShowProUI = New System.Windows.Forms.CheckBox()
        Me.btnCalcPhy = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbDigi1 = New System.Windows.Forms.TrackBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.llbHelp = New System.Windows.Forms.LinkLabel()
        Me.btnFact = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.mcldA = New System.Windows.Forms.MonthCalendar()
        Me.mcldB = New System.Windows.Forms.MonthCalendar()
        Me.btnCalcDateDiff = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.tbDigi1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.tbDigi2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInputData
        '
        Me.txtInputData.Location = New System.Drawing.Point(6, 6)
        Me.txtInputData.Name = "txtInputData"
        Me.txtInputData.Size = New System.Drawing.Size(480, 21)
        Me.txtInputData.TabIndex = 0
        Me.txtInputData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'llbProUI
        '
        Me.llbProUI.AutoSize = True
        Me.llbProUI.Location = New System.Drawing.Point(8, 133)
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
        Me.llbClear1.Location = New System.Drawing.Point(376, 38)
        Me.llbClear1.Name = "llbClear1"
        Me.llbClear1.Size = New System.Drawing.Size(29, 12)
        Me.llbClear1.TabIndex = 16
        Me.llbClear1.TabStop = True
        Me.llbClear1.Text = "清除"
        '
        'llbAbout
        '
        Me.llbAbout.AutoSize = True
        Me.llbAbout.Location = New System.Drawing.Point(470, 222)
        Me.llbAbout.Name = "llbAbout"
        Me.llbAbout.Size = New System.Drawing.Size(29, 12)
        Me.llbAbout.TabIndex = 13
        Me.llbAbout.TabStop = True
        Me.llbAbout.Text = "关于"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "偏差值"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "平均值"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "小数位"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "2位"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 215)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(502, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 17)
        Me.ToolStripStatusLabel1.Text = "Powered by NimitzDEV"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTouchPanel})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'tsmiTouchPanel
        '
        Me.tsmiTouchPanel.Name = "tsmiTouchPanel"
        Me.tsmiTouchPanel.Size = New System.Drawing.Size(152, 22)
        Me.tsmiTouchPanel.Text = "触摸板"
        '
        'cbAutoShowProUI
        '
        Me.cbAutoShowProUI.AutoSize = True
        Me.cbAutoShowProUI.Location = New System.Drawing.Point(306, 167)
        Me.cbAutoShowProUI.Name = "cbAutoShowProUI"
        Me.cbAutoShowProUI.Size = New System.Drawing.Size(180, 16)
        Me.cbAutoShowProUI.TabIndex = 22
        Me.cbAutoShowProUI.Text = "点击计算后自动打开演算过程"
        Me.cbAutoShowProUI.UseVisualStyleBackColor = True
        '
        'btnCalcPhy
        '
        Me.btnCalcPhy.Location = New System.Drawing.Point(411, 33)
        Me.btnCalcPhy.Name = "btnCalcPhy"
        Me.btnCalcPhy.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcPhy.TabIndex = 23
        Me.btnCalcPhy.Text = "计算结果"
        Me.btnCalcPhy.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(502, 215)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
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
        Me.TabPage1.Size = New System.Drawing.Size(494, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "平均与偏差"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbDigi1
        '
        Me.tbDigi1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDigi1.LargeChange = 1
        Me.tbDigi1.Location = New System.Drawing.Point(55, 35)
        Me.tbDigi1.Minimum = -1
        Me.tbDigi1.Name = "tbDigi1"
        Me.tbDigi1.Size = New System.Drawing.Size(186, 45)
        Me.tbDigi1.TabIndex = 18
        Me.tbDigi1.Value = 2
        '
        'TabPage2
        '
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
        Me.TabPage2.Size = New System.Drawing.Size(494, 189)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "算式运算"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnRnd
        '
        Me.btnRnd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRnd.Location = New System.Drawing.Point(122, 33)
        Me.btnRnd.Name = "btnRnd"
        Me.btnRnd.Size = New System.Drawing.Size(26, 23)
        Me.btnRnd.TabIndex = 31
        Me.btnRnd.Text = "R"
        Me.btnRnd.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Location = New System.Drawing.Point(93, 33)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(26, 23)
        Me.btnPi.TabIndex = 30
        Me.btnPi.Text = "π"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(64, 33)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(26, 23)
        Me.btnE.TabIndex = 29
        Me.btnE.Text = "e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnAbs
        '
        Me.btnAbs.Location = New System.Drawing.Point(35, 33)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(26, 23)
        Me.btnAbs.TabIndex = 28
        Me.btnAbs.Text = "||"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(6, 33)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(26, 23)
        Me.btnSqrt.TabIndex = 27
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'llbClear2
        '
        Me.llbClear2.AutoSize = True
        Me.llbClear2.Location = New System.Drawing.Point(378, 38)
        Me.llbClear2.Name = "llbClear2"
        Me.llbClear2.Size = New System.Drawing.Size(29, 12)
        Me.llbClear2.TabIndex = 26
        Me.llbClear2.TabStop = True
        Me.llbClear2.Text = "清除"
        '
        'tbResult
        '
        Me.tbResult.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbResult.Location = New System.Drawing.Point(10, 154)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.Size = New System.Drawing.Size(481, 29)
        Me.tbResult.TabIndex = 25
        Me.tbResult.Text = "0"
        Me.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "运算结果"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "2位"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "小数位"
        '
        'tbDigi2
        '
        Me.tbDigi2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDigi2.LargeChange = 1
        Me.tbDigi2.Location = New System.Drawing.Point(55, 85)
        Me.tbDigi2.Minimum = -1
        Me.tbDigi2.Name = "tbDigi2"
        Me.tbDigi2.Size = New System.Drawing.Size(183, 45)
        Me.tbDigi2.TabIndex = 21
        Me.tbDigi2.Value = 2
        '
        'btnCalcMath
        '
        Me.btnCalcMath.Location = New System.Drawing.Point(413, 33)
        Me.btnCalcMath.Name = "btnCalcMath"
        Me.btnCalcMath.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcMath.TabIndex = 1
        Me.btnCalcMath.Text = "运算式子"
        Me.btnCalcMath.UseVisualStyleBackColor = True
        '
        'txtInputMath
        '
        Me.txtInputMath.Location = New System.Drawing.Point(6, 6)
        Me.txtInputMath.Name = "txtInputMath"
        Me.txtInputMath.Size = New System.Drawing.Size(482, 21)
        Me.txtInputMath.TabIndex = 0
        Me.txtInputMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'llbHelp
        '
        Me.llbHelp.AutoSize = True
        Me.llbHelp.Location = New System.Drawing.Point(411, 222)
        Me.llbHelp.Name = "llbHelp"
        Me.llbHelp.Size = New System.Drawing.Size(53, 12)
        Me.llbHelp.TabIndex = 25
        Me.llbHelp.TabStop = True
        Me.llbHelp.Text = "使用帮助"
        '
        'btnFact
        '
        Me.btnFact.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnFact.Location = New System.Drawing.Point(152, 33)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(26, 23)
        Me.btnFact.TabIndex = 32
        Me.btnFact.Text = "！"
        Me.btnFact.UseVisualStyleBackColor = True
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
        Me.TabPage3.Size = New System.Drawing.Size(494, 189)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "天数差"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'mcldA
        '
        Me.mcldA.Location = New System.Drawing.Point(0, 24)
        Me.mcldA.Name = "mcldA"
        Me.mcldA.ShowWeekNumbers = True
        Me.mcldA.TabIndex = 0
        '
        'mcldB
        '
        Me.mcldB.Location = New System.Drawing.Point(248, 24)
        Me.mcldB.Name = "mcldB"
        Me.mcldB.ShowWeekNumbers = True
        Me.mcldB.TabIndex = 1
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(293, 12)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "在下面两个日历中选择两个日期来计算他们的天数差别"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(502, 237)
        Me.Controls.Add(Me.llbHelp)
        Me.Controls.Add(Me.llbAbout)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.tbDigi1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.tbDigi2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputData As System.Windows.Forms.TextBox
    Friend WithEvents llbProUI As System.Windows.Forms.LinkLabel
    Friend WithEvents llbClear1 As System.Windows.Forms.LinkLabel
    Friend WithEvents llbAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
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
    Friend WithEvents llbHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiTouchPanel As System.Windows.Forms.ToolStripMenuItem
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
End Class
