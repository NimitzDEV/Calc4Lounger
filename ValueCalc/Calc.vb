Imports System.Math
Module Calc
    Public Class Calc
        Private Shared spop As String() = {"asin", "acos", "atan", "csc", "sec", "cot", "sin", "cos", "tan", "lg", "ln", "abs", "rnd", "sqrt", "fact", "e", "pi"}

        Public Shared Function Compute(ByVal expression As String) As Double
            expression = ChkSpc(expression)
            expression = ChkSpc(expression)
            If Mid(expression, 1, 1) = "(" AndAlso Mid(expression, expression.Length, 1) = ")" Then Return Compute(Mid(expression, 2, expression.Length - 2))
            If InStrCount(expression, {"+", "-", "*", "/", "^"}) = 0 Then Return Val(expression)
            Dim pCount As Integer = 0
            Dim ch As Char, exp1 As String = "", exp2 As String = ""
            For i = expression.Length To 1 Step -1
                ch = Mid(expression, i, 1)
                Select Case ch
                    Case "("
                        pCount += 1
                    Case ")"
                        pCount -= 1
                    Case "+"
                        If pCount = 0 Then If Not (i > 1 AndAlso Mid(expression, i - 1, 1) = "^") Then Return Compute(Mid(expression, 1, i - 1)) + Compute(Mid(expression, i + 1, expression.Length - i))
                    Case "-"
                        If pCount = 0 Then If Not (i > 1 AndAlso Mid(expression, i - 1, 1) = "^") Then Return Compute(Mid(expression, 1, i - 1)) - Compute(Mid(expression, i + 1, expression.Length - i))
                End Select
            Next
            For i = expression.Length To 1 Step -1
                ch = Mid(expression, i, 1)
                Select Case ch
                    Case "("
                        pCount += 1
                    Case ")"
                        pCount -= 1
                    Case "*"
                        If pCount = 0 Then Return Compute(Mid(expression, 1, i - 1)) * Compute(Mid(expression, i + 1, expression.Length - i))
                    Case "/"
                        If pCount = 0 Then Return Compute(Mid(expression, 1, i - 1)) / Compute(Mid(expression, i + 1, expression.Length - i))
                End Select
            Next
            For i = expression.Length To 1 Step -1
                ch = Mid(expression, i, 1)
                Select Case ch
                    Case "("
                        pCount += 1
                    Case ")"
                        pCount -= 1
                    Case "^"
                        If pCount = 0 Then Return Compute(Mid(expression, 1, i - 1)) ^ Compute(Mid(expression, i + 1, expression.Length - i))
                End Select
            Next
            Return 0
        End Function

        Private Shared Function InStrCount(ByVal sourceString As String, ByVal chr As Char()) As Integer
            Dim count As Integer = 0
            For Each ch In chr
                For i = 1 To sourceString.Length
                    If Mid(sourceString, i, 1) = ch Then count += 1
                Next
            Next
            Return count
        End Function

        Private Shared Function InStrCount(ByVal sourceString As String, ByVal str As String) As Integer
            Dim count As Integer = 0
            Do While InStr(sourceString, str) <> -1
                count += 1
                sourceString = Microsoft.VisualBasic.Right(sourceString, sourceString.Length - InStr(sourceString, str))
            Loop
            Return count
        End Function

        Private Shared Function ChkSpc(ByVal sourceString As String) As String
            sourceString = sourceString.ToLower
start:      For Each op In spop
                If InStr(sourceString, op) > 0 Then sourceString = SearchSpecialOp(sourceString, op) : GoTo start
            Next
            Return sourceString
        End Function

        Private Shared Function SearchSpecialOp(ByVal sourceString As String, ByVal op As String) As String
            Select Case op
                Case "sin", "cos", "tan", "csc", "sec", "cot", "asin", "acos", "atan", "lg", "ln", "abs", "rnd", "sqrt", "fact"
                    Dim l As Integer = InStr(sourceString, op)
                    Dim c As Char, pCount As Integer = 0
                    Dim result, nm As Double
                    For i = l + op.Length To sourceString.Length
                        c = Mid(sourceString, i, 1)
                        Select Case c
                            Case "("
                                pCount += 1
                            Case ")"
                                pCount -= 1
                                If pCount = 0 Then
                                    nm = Compute(Mid(sourceString, l + op.Length + 1, i - (l + op.Length + 1)))
                                    Select Case op
                                        Case "sin"
                                            result = Sin(nm)
                                        Case "cos"
                                            result = Cos(nm)
                                        Case "tan"
                                            result = Tan(nm)
                                        Case "csc"
                                            result = 1 / Sin(nm)
                                        Case "sec"
                                            result = 1 / Cos(nm)
                                        Case "cot"
                                            result = 1 / Tan(nm)
                                        Case "asin"
                                            result = Asin(nm)
                                        Case "acos"
                                            result = Acos(nm)
                                        Case "atan"
                                            result = Atan(nm)
                                        Case "lg"
                                            result = Log10(nm)
                                        Case "ln"
                                            result = Math.Log(nm)
                                        Case "abs"
                                            result = Abs(nm)
                                        Case "rnd"
                                            result = Rnd() * nm
                                        Case "sqrt"
                                            result = Sqrt(nm)
                                        Case "fact"
                                            Dim factCalc As Integer
                                            Dim factCalcResult As Long
                                            factCalcResult = 1
                                            For factCalc = 1 To nm
                                                factCalcResult *= factCalc
                                            Next
                                            result = factCalcResult
                                    End Select
                                    Return Mid(sourceString, 1, l - 1) & result & Mid(sourceString, i + 1, sourceString.Length - i)
                                End If
                        End Select
                    Next
                Case "e", "pi"
                    Dim cst As String
                    cst = ""
                    Dim lo As Integer = InStr(sourceString, op)
                    Select Case op
                        Case "e"
                            cst = IIf(Not (lo > 1 AndAlso Mid(sourceString, lo - 1, 1) Like "#"), E.ToString, "*10^")
                        Case "pi"
                            cst = PI
                    End Select
                    Return Mid(sourceString, 1, lo - 1) & cst & Mid(sourceString, lo + op.Length, sourceString.Length - lo - op.Length + 1)
            End Select
            Return 0
        End Function
    End Class
End Module
