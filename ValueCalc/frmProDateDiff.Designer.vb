<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProDateDiff
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
        Me.lbTip1 = New System.Windows.Forms.Label()
        Me.lbDiff = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbWeek = New System.Windows.Forms.RadioButton()
        Me.rbDay = New System.Windows.Forms.RadioButton()
        Me.rbHour = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTip1
        '
        Me.lbTip1.AutoSize = True
        Me.lbTip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTip1.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbTip1.ForeColor = System.Drawing.Color.OliveDrab
        Me.lbTip1.Location = New System.Drawing.Point(3, 0)
        Me.lbTip1.Name = "lbTip1"
        Me.lbTip1.Size = New System.Drawing.Size(508, 53)
        Me.lbTip1.TabIndex = 0
        Me.lbTip1.Text = "日期 2000/01/01 到 2000/01/01 之间"
        Me.lbTip1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDiff
        '
        Me.lbDiff.AutoSize = True
        Me.lbDiff.BackColor = System.Drawing.Color.Transparent
        Me.lbDiff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbDiff.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbDiff.Location = New System.Drawing.Point(3, 53)
        Me.lbDiff.Name = "lbDiff"
        Me.lbDiff.Size = New System.Drawing.Size(508, 30)
        Me.lbDiff.TabIndex = 1
        Me.lbDiff.Text = "之间相差"
        Me.lbDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Location = New System.Drawing.Point(517, 345)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 56)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "关闭"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.60934!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.39066!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbDiff, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbResult, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.91753!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.08247!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(594, 404)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbResult.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbResult.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbResult.Location = New System.Drawing.Point(3, 83)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(508, 259)
        Me.lbResult.TabIndex = 4
        Me.lbResult.Text = "200000000天"
        Me.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(517, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "单位"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbWeek)
        Me.Panel1.Controls.Add(Me.rbDay)
        Me.Panel1.Controls.Add(Me.rbHour)
        Me.Panel1.Location = New System.Drawing.Point(517, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 253)
        Me.Panel1.TabIndex = 6
        '
        'rbWeek
        '
        Me.rbWeek.AutoSize = True
        Me.rbWeek.Location = New System.Drawing.Point(18, 144)
        Me.rbWeek.Name = "rbWeek"
        Me.rbWeek.Size = New System.Drawing.Size(35, 16)
        Me.rbWeek.TabIndex = 2
        Me.rbWeek.Text = "周"
        Me.rbWeek.UseVisualStyleBackColor = True
        '
        'rbDay
        '
        Me.rbDay.AutoSize = True
        Me.rbDay.Checked = True
        Me.rbDay.Location = New System.Drawing.Point(18, 122)
        Me.rbDay.Name = "rbDay"
        Me.rbDay.Size = New System.Drawing.Size(35, 16)
        Me.rbDay.TabIndex = 1
        Me.rbDay.TabStop = True
        Me.rbDay.Text = "天"
        Me.rbDay.UseVisualStyleBackColor = True
        '
        'rbHour
        '
        Me.rbHour.AutoSize = True
        Me.rbHour.Location = New System.Drawing.Point(18, 100)
        Me.rbHour.Name = "rbHour"
        Me.rbHour.Size = New System.Drawing.Size(47, 16)
        Me.rbHour.TabIndex = 0
        Me.rbHour.Text = "小时"
        Me.rbHour.UseVisualStyleBackColor = True
        '
        'frmProDateDiff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 404)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProDateDiff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "天数差计算"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbTip1 As System.Windows.Forms.Label
    Friend WithEvents lbDiff As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbWeek As System.Windows.Forms.RadioButton
    Friend WithEvents rbDay As System.Windows.Forms.RadioButton
    Friend WithEvents rbHour As System.Windows.Forms.RadioButton
End Class
