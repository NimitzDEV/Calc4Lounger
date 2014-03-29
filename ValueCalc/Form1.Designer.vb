<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Slider1 = New DevComponents.DotNetBar.Controls.Slider()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SlidePanel1 = New DevComponents.DotNetBar.Controls.SlidePanel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.SlidePanel2 = New DevComponents.DotNetBar.Controls.SlidePanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.CheckBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.SlidePanel1.SuspendLayout()
        Me.SlidePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(0, Byte), Integer)))
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(431, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(342, 28)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(92, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "计算"
        '
        'MetroStatusBar1
        '
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.CheckBoxItem1})
        Me.MetroStatusBar1.Location = New System.Drawing.Point(0, 331)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(1021, 22)
        Me.MetroStatusBar1.TabIndex = 2
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Powered by NimitzDEV"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "平均值"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "偏差值"
        '
        'Slider1
        '
        '
        '
        '
        Me.Slider1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Slider1.Location = New System.Drawing.Point(3, 28)
        Me.Slider1.Maximum = 8
        Me.Slider1.Name = "Slider1"
        Me.Slider1.Size = New System.Drawing.Size(160, 29)
        Me.Slider1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.Slider1.TabIndex = 5
        Me.Slider1.Text = "小数"
        Me.Slider1.Value = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "小数位：2位"
        '
        'SlidePanel1
        '
        Me.SlidePanel1.BackColor = System.Drawing.Color.White
        Me.SlidePanel1.Controls.Add(Me.LinkLabel9)
        Me.SlidePanel1.Controls.Add(Me.LinkLabel8)
        Me.SlidePanel1.Controls.Add(Me.TextBox2)
        Me.SlidePanel1.Controls.Add(Me.LinkLabel4)
        Me.SlidePanel1.Controls.Add(Me.LinkLabel3)
        Me.SlidePanel1.Controls.Add(Me.LinkLabel2)
        Me.SlidePanel1.Controls.Add(Me.ReflectionLabel1)
        Me.SlidePanel1.Location = New System.Drawing.Point(12, 148)
        Me.SlidePanel1.Name = "SlidePanel1"
        Me.SlidePanel1.Size = New System.Drawing.Size(425, 143)
        Me.SlidePanel1.SlideOutButtonVisible = False
        Me.SlidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Bottom
        Me.SlidePanel1.TabIndex = 9
        Me.SlidePanel1.Text = "SlidePanel1"
        Me.SlidePanel1.UsesBlockingAnimation = False
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(48, 99)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(53, 13)
        Me.LinkLabel9.TabIndex = 7
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Google+"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Location = New System.Drawing.Point(9, 99)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel8.TabIndex = 6
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "知乎"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(159, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(263, 137)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "※数据输入方法：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-将要求的数据全部输入输入框中" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-每一个数据需要使用（分号）隔开" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-中文和英文的符号都能支持" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "※小数位：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-滑动滑竿调整需要保留的小数" & _
            "位" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-程序自动自动四舍五入" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "---------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "开发：NimitzDEV " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "邮箱：nimitzdevteam@gmail.com" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(9, 121)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "返回"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(74, 76)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "腾讯微博"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(9, 76)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "新浪微博"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(30, 3)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(110, 70)
        Me.ReflectionLabel1.TabIndex = 0
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Nimitz</i><font color=""#B02B2C"">DEV</font></font></b>"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(376, 106)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "使用说明"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(303, 35)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel5.TabIndex = 10
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "清除"
        '
        'SlidePanel2
        '
        Me.SlidePanel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.SlidePanel2.Controls.Add(Me.Label5)
        Me.SlidePanel2.Controls.Add(Me.LinkLabel6)
        Me.SlidePanel2.Controls.Add(Me.Label6)
        Me.SlidePanel2.Location = New System.Drawing.Point(490, 137)
        Me.SlidePanel2.Name = "SlidePanel2"
        Me.SlidePanel2.Size = New System.Drawing.Size(418, 145)
        Me.SlidePanel2.SlideOutButtonVisible = False
        Me.SlidePanel2.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Bottom
        Me.SlidePanel2.TabIndex = 11
        Me.SlidePanel2.Text = "SlidePanel2"
        Me.SlidePanel2.UsesBlockingAnimation = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, -8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 128)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = ":("
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.LinkColor = System.Drawing.Color.White
        Me.LinkLabel6.Location = New System.Drawing.Point(363, 117)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel6.TabIndex = 3
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "确定"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(114, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "没有输入数据哦！"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(104, 82)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel7.TabIndex = 12
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "演算过程"
        Me.LinkLabel7.Visible = False
        '
        'CheckBoxItem1
        '
        Me.CheckBoxItem1.Name = "CheckBoxItem1"
        Me.CheckBoxItem1.Text = "点击计算后自动弹出演算过程"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1021, 353)
        Me.Controls.Add(Me.SlidePanel1)
        Me.Controls.Add(Me.SlidePanel2)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Slider1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ValueCalc"
        Me.SlidePanel1.ResumeLayout(False)
        Me.SlidePanel1.PerformLayout()
        Me.SlidePanel2.ResumeLayout(False)
        Me.SlidePanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Slider1 As DevComponents.DotNetBar.Controls.Slider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents SlidePanel1 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents SlidePanel2 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
End Class
