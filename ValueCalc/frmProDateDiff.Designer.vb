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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProDateDiff))
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
        resources.ApplyResources(Me.lbTip1, "lbTip1")
        Me.lbTip1.ForeColor = System.Drawing.Color.OliveDrab
        Me.lbTip1.Name = "lbTip1"
        '
        'lbDiff
        '
        resources.ApplyResources(Me.lbDiff, "lbDiff")
        Me.lbDiff.BackColor = System.Drawing.Color.Transparent
        Me.lbDiff.Name = "lbDiff"
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.lbDiff, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbResult, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'lbResult
        '
        resources.ApplyResources(Me.lbResult, "lbResult")
        Me.lbResult.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbResult.Name = "lbResult"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.rbWeek)
        Me.Panel1.Controls.Add(Me.rbDay)
        Me.Panel1.Controls.Add(Me.rbHour)
        Me.Panel1.Name = "Panel1"
        '
        'rbWeek
        '
        resources.ApplyResources(Me.rbWeek, "rbWeek")
        Me.rbWeek.Name = "rbWeek"
        Me.rbWeek.UseVisualStyleBackColor = True
        '
        'rbDay
        '
        resources.ApplyResources(Me.rbDay, "rbDay")
        Me.rbDay.Checked = True
        Me.rbDay.Name = "rbDay"
        Me.rbDay.TabStop = True
        Me.rbDay.UseVisualStyleBackColor = True
        '
        'rbHour
        '
        resources.ApplyResources(Me.rbHour, "rbHour")
        Me.rbHour.Name = "rbHour"
        Me.rbHour.UseVisualStyleBackColor = True
        '
        'frmProDateDiff
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProDateDiff"
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
