Public Class Form1

    Private Sub btnLetterGrade_Click(sender As Object, e As EventArgs) Handles btnLetterGrade.Click
        Const LOWEST_SCORE As Double = 0
        Const HIGHEST_SCORE As Double = 100
        Dim scoreEntered As Double

        scoreEntered = Val(Me.txtScore.Text)

        If Not ValidEntry(scoreEntered, HIGHEST_SCORE, LOWEST_SCORE) Then
            MessageBox.Show("Enter a score between " & LOWEST_SCORE & " and " & HIGHEST_SCORE)
            Me.txtScore.Text = Nothing
            Me.lblLetterGrade.Text = Nothing
        Else
            Me.lblLetterGrade.Text = "Your grade is a(n) " & LetterGrade(scoreEntered)
        End If
    End Sub
    '********************************************************************************************
    'ValidEntry
    'Returns True if lowerLimit <= userNum <= upperLimit.
    '
    'post: True has been returned if lowerLimit <= userNum <= upperLimit.
    'False has been returned otherwise.
    '********************************************************************************************
    Function ValidEntry(ByVal userNum As Integer, ByVal upperLimit As Integer, _
                         ByVal lowerLimit As Integer) As Boolean
        If userNum > upperLimit Or userNum < lowerLimit Then
            Return False
        Else
            Return True
        End If
    End Function
    '********************************************************************************************
    'LetterGrade
    'Returns a letter grade corresponding to score.
    '
    'post: A letter grade (A, B, C, D, or F) has been returned.
    '********************************************************************************************
    Function LetterGrade(ByVal score As Double) As Char
        If score >= 90 Then
            Return "A"
        ElseIf score >= 80 Then
            Return "B"
        ElseIf score >= 70 Then
            Return "C"
        ElseIf score >= 60 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function

    Private Sub txtScore_TextChanged(sender As Object, e As EventArgs) Handles txtScore.TextChanged
        Me.lblLetterGrade.Text = Nothing
    End Sub
End Class
