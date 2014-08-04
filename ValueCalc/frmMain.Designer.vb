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
        Me.cbAutoShowProUI = New System.Windows.Forms.CheckBox()
        Me.btnCalcPhy = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.tbDigi1 = New System.Windows.Forms.TrackBar()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalcDateDiff = New System.Windows.Forms.Button()
        Me.mcldB = New System.Windows.Forms.MonthCalendar()
        Me.mcldA = New System.Windows.Forms.MonthCalendar()
        Me.llbHelp = New System.Windows.Forms.LinkLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.获取新版本ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.getNewVerStable = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetNewVerNightly = New System.Windows.Forms.ToolStripMenuItem()
        Me.getReleaseCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.tbDigi2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.tbDigi1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInputData
        '
        resources.ApplyResources(Me.txtInputData, "txtInputData")
        Me.txtInputData.Name = "txtInputData"
        '
        'llbProUI
        '
        resources.ApplyResources(Me.llbProUI, "llbProUI")
        Me.llbProUI.Name = "llbProUI"
        Me.llbProUI.TabStop = True
        '
        'llbClear1
        '
        resources.ApplyResources(Me.llbClear1, "llbClear1")
        Me.llbClear1.Name = "llbClear1"
        Me.llbClear1.TabStop = True
        '
        'llbAbout
        '
        resources.ApplyResources(Me.llbAbout, "llbAbout")
        Me.llbAbout.Name = "llbAbout"
        Me.llbAbout.TabStop = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        '
        'cbAutoShowProUI
        '
        resources.ApplyResources(Me.cbAutoShowProUI, "cbAutoShowProUI")
        Me.cbAutoShowProUI.Name = "cbAutoShowProUI"
        Me.cbAutoShowProUI.UseVisualStyleBackColor = True
        '
        'btnCalcPhy
        '
        resources.ApplyResources(Me.btnCalcPhy, "btnCalcPhy")
        Me.btnCalcPhy.Name = "btnCalcPhy"
        Me.btnCalcPhy.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage2
        '
        resources.ApplyResources(Me.TabPage2, "TabPage2")
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
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnFact
        '
        resources.ApplyResources(Me.btnFact, "btnFact")
        Me.btnFact.Name = "btnFact"
        Me.btnFact.UseVisualStyleBackColor = True
        '
        'btnRnd
        '
        resources.ApplyResources(Me.btnRnd, "btnRnd")
        Me.btnRnd.Name = "btnRnd"
        Me.btnRnd.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        resources.ApplyResources(Me.btnPi, "btnPi")
        Me.btnPi.Name = "btnPi"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnE
        '
        resources.ApplyResources(Me.btnE, "btnE")
        Me.btnE.Name = "btnE"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnAbs
        '
        resources.ApplyResources(Me.btnAbs, "btnAbs")
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        resources.ApplyResources(Me.btnSqrt, "btnSqrt")
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'llbClear2
        '
        resources.ApplyResources(Me.llbClear2, "llbClear2")
        Me.llbClear2.Name = "llbClear2"
        Me.llbClear2.TabStop = True
        '
        'tbResult
        '
        resources.ApplyResources(Me.tbResult, "tbResult")
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'tbDigi2
        '
        resources.ApplyResources(Me.tbDigi2, "tbDigi2")
        Me.tbDigi2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDigi2.LargeChange = 1
        Me.tbDigi2.Minimum = -1
        Me.tbDigi2.Name = "tbDigi2"
        Me.tbDigi2.Value = 2
        '
        'btnCalcMath
        '
        resources.ApplyResources(Me.btnCalcMath, "btnCalcMath")
        Me.btnCalcMath.Name = "btnCalcMath"
        Me.btnCalcMath.UseVisualStyleBackColor = True
        '
        'txtInputMath
        '
        resources.ApplyResources(Me.txtInputMath, "txtInputMath")
        Me.txtInputMath.Name = "txtInputMath"
        '
        'TabPage1
        '
        resources.ApplyResources(Me.TabPage1, "TabPage1")
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
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbDigi1
        '
        resources.ApplyResources(Me.tbDigi1, "tbDigi1")
        Me.tbDigi1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbDigi1.LargeChange = 1
        Me.tbDigi1.Minimum = -1
        Me.tbDigi1.Name = "tbDigi1"
        Me.tbDigi1.Value = 2
        '
        'TabPage4
        '
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.btnCalcDateDiff)
        Me.TabPage3.Controls.Add(Me.mcldB)
        Me.TabPage3.Controls.Add(Me.mcldA)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'btnCalcDateDiff
        '
        resources.ApplyResources(Me.btnCalcDateDiff, "btnCalcDateDiff")
        Me.btnCalcDateDiff.Name = "btnCalcDateDiff"
        Me.btnCalcDateDiff.UseVisualStyleBackColor = True
        '
        'mcldB
        '
        resources.ApplyResources(Me.mcldB, "mcldB")
        Me.mcldB.Name = "mcldB"
        '
        'mcldA
        '
        resources.ApplyResources(Me.mcldA, "mcldA")
        Me.mcldA.Name = "mcldA"
        '
        'llbHelp
        '
        resources.ApplyResources(Me.llbHelp, "llbHelp")
        Me.llbHelp.Name = "llbHelp"
        Me.llbHelp.TabStop = True
        '
        'ToolStripDropDownButton1
        '
        resources.ApplyResources(Me.ToolStripDropDownButton1, "ToolStripDropDownButton1")
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.获取新版本ToolStripMenuItem, Me.getReleaseCode})
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        '
        '获取新版本ToolStripMenuItem
        '
        resources.ApplyResources(Me.获取新版本ToolStripMenuItem, "获取新版本ToolStripMenuItem")
        Me.获取新版本ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.getNewVerStable, Me.GetNewVerNightly})
        Me.获取新版本ToolStripMenuItem.Name = "获取新版本ToolStripMenuItem"
        '
        'getNewVerStable
        '
        resources.ApplyResources(Me.getNewVerStable, "getNewVerStable")
        Me.getNewVerStable.Name = "getNewVerStable"
        '
        'GetNewVerNightly
        '
        resources.ApplyResources(Me.GetNewVerNightly, "GetNewVerNightly")
        Me.GetNewVerNightly.Name = "GetNewVerNightly"
        '
        'getReleaseCode
        '
        resources.ApplyResources(Me.getReleaseCode, "getReleaseCode")
        Me.getReleaseCode.Name = "getReleaseCode"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.llbHelp)
        Me.Controls.Add(Me.llbAbout)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents 获取新版本ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents getNewVerStable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetNewVerNightly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents getReleaseCode As System.Windows.Forms.ToolStripMenuItem
End Class
