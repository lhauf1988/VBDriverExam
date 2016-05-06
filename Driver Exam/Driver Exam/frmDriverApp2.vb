Public Class frmDriverApp2



    Private Sub frmDriverApp2_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Dim FinalAnswer(10) As String
        Dim correctAnswers() As String = {"", "A", "B", "C", "D", "A", "B", "C", " D", "A", "B"}

        For cnt As Integer = 0 To 10

            If user(cnt) = correctAnswers(cnt) Then
                FinalAnswer(cnt) = "Correct"
            Else
                FinalAnswer(cnt) = "Wrong"
            End If

        Next

        For cnt As Integer = 1 To 10
            Me.lstbxResults.Items.Add(Questions(cnt))
            Me.lstbxResults.Items.Add(user(cnt) & "" + "=" + FinalAnswer(cnt))
        Next

        'Score is the test score (ie 80%)..
        Dim Score As Integer = 0

        For cnt As Integer = 1 To 10
            If FinalAnswer(cnt) = "Correct" Then
                Score += 1
            End If
        Next

        lblFinalScore.Text = "Your score is " & Score * 10 & "%"
        If Score >= 8 Then
            lblPassFailMessage.Text = "Congratulations! You passed the Drivers Exam!"
        Else
            lblPassFailMessage.Text = "You will need to retake the Drivers Exam."
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class