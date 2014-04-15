Public Class frmTouch
    Dim targetControl As System.Windows.Forms.TextBox
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Left = frmMain.Left
        Me.Top = frmMain.Top + frmMain.Height + 10
    End Sub
    Private Function getSelectedTab() As System.Windows.Forms.TextBox
        If frmMain.TabControl1.SelectedIndex = 0 Then
            Return frmMain.txtInputData
        ElseIf frmMain.TabControl1.SelectedIndex = 1 Then
            Return frmMain.txtInputMath
        End If
        Return frmMain.txtInputData
    End Function
    Private Sub sendData(ByVal sendChar As String)
        targetControl = getSelectedTab()
        If frmMain.TabControl1.SelectedIndex = 0 And sendChar = "+" Then
            sendChar = ";"
        End If
        If sendChar = "Del" Then
            If targetControl.Text = "" Then Exit Sub
            targetControl.Text = Microsoft.VisualBasic.Left(targetControl.Text, Len(targetControl.Text) - 1)
            Exit Sub
        End If
        targetControl.Text &= sendChar

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        sendData("0")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        sendData(".")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sendData("1")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sendData("2")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sendData("3")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        sendData("4")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        sendData("5")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        sendData("6")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        sendData("7")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        sendData("8")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        sendData("9")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        sendData("+")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        sendData("-")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        sendData("*")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        sendData("/")
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        sendData("(")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        sendData(")")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        sendData("pi")
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        sendData("e")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        sendData("Del")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If frmMain.TabControl1.SelectedIndex = 0 Then
            frmMain.btnCalcPhy.PerformClick()
        ElseIf frmMain.TabControl1.SelectedIndex = 1 Then
            frmMain.btnCalcMath.PerformClick()
        End If
    End Sub
End Class