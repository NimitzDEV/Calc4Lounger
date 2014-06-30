Public Class frmCRR


    Private Sub frmCRR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nowSteping = 1
        typeLen = 0
        Dim i As Integer
        For i = 0 To 5
            shData(i) = -1
            subSetColor(Color.FromArgb(221, 221, 221), i + 1)
        Next
    End Sub
    Private Sub subSetColor(ByVal tgColor As Color, tgSection As Integer)
        Dim ftColor As Color
        If tgColor.R = 0 And tgColor.G = 0 And tgColor.B = 0 Then
            ftColor = Color.White
        Else
            ftColor = Color.Black
        End If
        Select Case tgSection
            Case 1
                btnCir1.BackColor = tgColor
                btnCir1.ForeColor = ftColor
            Case 2
                btnCir2.BackColor = tgColor
                btnCir2.ForeColor = ftColor
            Case 3
                btnCir3.BackColor = tgColor
                btnCir3.ForeColor = ftColor
            Case 4
                btnCir4.BackColor = tgColor
                btnCir4.ForeColor = ftColor
            Case 5
                btnCir5.BackColor = tgColor
                btnCir5.ForeColor = ftColor
            Case 6
                btnCir6.BackColor = tgColor
                btnCir6.ForeColor = ftColor
        End Select
    End Sub
    Private Sub setColor(ByVal tgColor As Color)
        subSetColor(tgColor, nowSteping)
        typeDefi(nowSteping)
        nowSteping += 1
    End Sub
    Private Sub typeDefi(ByVal typeId As Integer)
        Select Case typeId
            Case 3
                lbType.Text = "三色环电阻"
            Case 4
                lbType.Text = "四色环电阻"
            Case 5
                lbType.Text = "五色环电阻"
            Case 6
                lbType.Text = "六色环电阻"
                lbFull.Visible = True
            Case Else
                lbType.Text = "无"
        End Select
    End Sub
    Private Sub cleanData(ByVal startPosition As Integer)
        If startPosition <> 1 Then
            If shData(startPosition - 1) = -1 Then Exit Sub
        End If
        nowSteping = startPosition
        startPosition -= 1
        Dim s As Integer
        For s = startPosition To 5
            shData(s) = -1
            subSetColor(Color.FromArgb(221, 221, 221), s + 1)
        Next
        typeDefi(nowSteping - 1)
        lbFull.Visible = False
        output.Text = composeResult(nowSteping - 1)
    End Sub
    Private Sub shDataRecord(ByVal targetVal As Integer)
        If nowSteping > 7 Then
            output.Text = "请输入色环数据"
            shData(5) = targetVal
            '清空数据
            cleanData(1)
            Exit Sub
        End If
        If nowSteping > 7 Or nowSteping < 2 Then Exit Sub
        shData(nowSteping - 2) = targetVal
        output.Text = composeResult(nowSteping - 1)
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        setColor(Color.Silver)
        shDataRecord(1)
    End Sub

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        setColor(Color.Gold)
        shDataRecord(2)
    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        setColor(Color.Black)
        shDataRecord(3)
    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        setColor(Color.Brown)
        shDataRecord(4)
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        setColor(Color.Red)
        shDataRecord(5)
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        setColor(Color.Orange)
        shDataRecord(6)
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        setColor(Color.Yellow)
        shDataRecord(7)
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        setColor(Color.Green)
        shDataRecord(8)
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        setColor(Color.Blue)
        shDataRecord(9)
    End Sub

    Private Sub btnPueple_Click(sender As Object, e As EventArgs) Handles btnPueple.Click
        setColor(Color.Purple)
        shDataRecord(10)
    End Sub

    Private Sub btnGrey_Click(sender As Object, e As EventArgs) Handles btnGrey.Click
        setColor(Color.Gray)
        shDataRecord(11)
    End Sub

    Private Sub btnWhite_Click(sender As Object, e As EventArgs) Handles btnWhite.Click
        setColor(Color.White)
        shDataRecord(12)
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        setColor(Color.FromArgb(163, 148, 128))
        shDataRecord(13)
    End Sub

    Private Sub btnCir1_Click(sender As Object, e As EventArgs) Handles btnCir1.Click
        cleanData(1)
    End Sub

    Private Sub btnCir2_Click(sender As Object, e As EventArgs) Handles btnCir2.Click
        cleanData(2)
    End Sub

    Private Sub btnCir3_Click(sender As Object, e As EventArgs) Handles btnCir3.Click
        cleanData(3)
    End Sub

    Private Sub btnCir4_Click(sender As Object, e As EventArgs) Handles btnCir4.Click
        cleanData(4)
    End Sub

    Private Sub btnCir5_Click(sender As Object, e As EventArgs) Handles btnCir5.Click
        cleanData(5)
    End Sub

    Private Sub btnCir6_Click(sender As Object, e As EventArgs) Handles btnCir6.Click
        cleanData(6)
    End Sub
End Class