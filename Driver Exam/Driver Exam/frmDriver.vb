Public Class FrmExam
    Public intNext As Integer = 1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If txtFirstName.Text = "" Then
            MessageBox.Show("Please enter your first name")
            txtFirstName.Focus()
            Exit Sub
        ElseIf txtLastName.Text = "" Then
            MessageBox.Show("Please enter your last name")
            txtLastName.Focus()
            Exit Sub
        End If
        MessageBox.Show("Hello " & txtFirstName.Text & " " & txtLastName.Text & Environment.NewLine() & " are you ready to begin your drivers exam?", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Question)

        lblWelcome.Visible = False
        lblFirstName.Visible = False
        lblLastName.Visible = False
        btnStart.Visible = False
        txtFirstName.Visible = False
        txtLastName.Visible = False
        lblOptionA.Visible = True
        lblOptionB.Visible = True
        lblOptionC.Visible = True
        lblOptionD.Visible = True
        rdbA.Visible = True
        rdbB.Visible = True
        rdbC.Visible = True
        rdbD.Visible = True
        lblQuestions.Visible = True
        lblQuestionSet.Visible = True
        lblUserName.Visible = True
        btnNext.Visible = True
        btnBack.Visible = True
        btnBack.Enabled = False
        lblUserName.Visible = True

        lblQuestions.Text = Questions(intNext)

        lblQuestionSet.Text = "Question " & intNext & " of 10"

        lblUserName.Text = txtFirstName.Text & " " & txtLastName.Text

        Call AnswerSelection()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnNext.Text = "Submit" Then
            Me.Hide()
            frmDriverApp2.Show()
            Exit Sub
        End If
        If rdbA.Checked = False And rdbB.Checked = False And rdbC.Checked = False And rdbD.Checked = False Then
            MessageBox.Show("Please select a answer before clicking next")
            Exit Sub
        End If

        intNext += 1
        lblQuestions.Text = Questions(intNext)
        lblQuestionSet.Text = "Question " & intNext & " of 10"
        Call AnswerSelection()

        Call yes()
        If intNext = 2 Then
            btnBack.Enabled = True
        End If
        If intNext = 10 Then
            btnNext.Text = "Submit"

        Else
            btnNext.Text = "Next"
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        intNext -= 1
        lblQuestions.Text = Questions(intNext)
        lblQuestionSet.Text = "Question " & intNext & " of 10"
        Call AnswerSelection()

        Call yes()
        If intNext < 2 Then
            btnBack.Enabled = False
        End If
        If intNext = 10 Then
            btnNext.Text = "Submit"
        Else
            btnNext.Text = "Next"
        End If
    End Sub

    Private Sub AnswerSelection()

        Dim PossibleAnswers(4, 10)
        PossibleAnswers(1, 1) = "Five inches from a sidewalk."
        PossibleAnswers(2, 1) = "On a bridge."
        PossibleAnswers(3, 1) = "In front of a public driveway."
        PossibleAnswers(4, 1) = "On an unmarked crosswalk."

        PossibleAnswers(1, 2) = "A police car."
        PossibleAnswers(2, 2) = "A large, over-sized truck."
        PossibleAnswers(3, 2) = "A passenger car."
        PossibleAnswers(4, 2) = "A motorcycle."

        PossibleAnswers(1, 3) = "Ajust instrument lights to be brighter."
        PossibleAnswers(2, 3) = "Turn on vehicle parking lights."
        PossibleAnswers(3, 3) = "Use your low beams."
        PossibleAnswers(4, 3) = "Use high beams."

        PossibleAnswers(1, 4) = "Proceed through the crossing before the train is within 1,500ft of crossing."
        PossibleAnswers(2, 4) = "Stop within 15ft of nearest rail."
        PossibleAnswers(3, 4) = "Proceed through the crossing before the train is within 500ft of crossing."
        PossibleAnswers(4, 4) = "Stop within 50ft but not less than 15ft from the nearest rail."

        PossibleAnswers(1, 5) = "You cannot see as well."
        PossibleAnswers(2, 5) = "Traffic is faster."
        PossibleAnswers(3, 5) = "There is a larger volume of traffic."
        PossibleAnswers(4, 5) = "None of the above."

        PossibleAnswers(1, 6) = "Is allowed in all emergencies."
        PossibleAnswers(2, 6) = "Illegal and unsafe."
        PossibleAnswers(3, 6) = "Is only allowed in the right hand lane."
        PossibleAnswers(4, 6) = "All of the above."

        PossibleAnswers(1, 7) = "On a freeway"
        PossibleAnswers(2, 7) = "In a tunnel"
        PossibleAnswers(3, 7) = "At a sidewalk."
        PossibleAnswers(4, 7) = "None of the above"

        PossibleAnswers(1, 8) = "Listen to music in headphones."
        PossibleAnswers(2, 8) = "Try to think of something else than driving."
        PossibleAnswers(3, 8) = "Turn off the radio."
        PossibleAnswers(4, 8) = "Take regular rest stops."

        PossibleAnswers(1, 9) = "Call for professional help."
        PossibleAnswers(2, 9) = "Help the injured person from the car and make them lie down."
        PossibleAnswers(3, 9) = "Give the person something to drink."
        PossibleAnswers(4, 9) = "Get back in your car and drive off."

        PossibleAnswers(1, 10) = "A flashing red light."
        PossibleAnswers(2, 10) = "A police officer."
        PossibleAnswers(3, 10) = "A stop sign."
        PossibleAnswers(4, 10) = "A steady red light."

        lblOptionA.Text = PossibleAnswers(1, intNext)
        lblOptionB.Text = PossibleAnswers(2, intNext)
        lblOptionC.Text = PossibleAnswers(3, intNext)
        lblOptionD.Text = PossibleAnswers(4, intNext)
    End Sub

    Private Sub yes()
        If user(intNext) = "A" Then
            rdbA.Checked = True
        ElseIf user(intNext) = "B" Then
            rdbB.Checked = True
        ElseIf user(intNext) = "C" Then
            rdbC.Checked = True
        ElseIf user(intNext) = "D" Then
            rdbD.Checked = True
        Else
            rdbA.Checked = False
            rdbB.Checked = False
            rdbC.Checked = False
            rdbD.Checked = False
        End If
    End Sub

    Private Sub rdbA_CheckedChanged(sender As Object, e As EventArgs) Handles rdbA.CheckedChanged
        user(intNext) = "A"
    End Sub

    Private Sub rdbB_CheckedChanged(sender As Object, e As EventArgs) Handles rdbB.CheckedChanged
        user(intNext) = "B"
    End Sub

    Private Sub rdbC_CheckedChanged(sender As Object, e As EventArgs) Handles rdbC.CheckedChanged
        user(intNext) = "C"
    End Sub

    Private Sub rdbD_CheckedChanged(sender As Object, e As EventArgs) Handles rdbD.CheckedChanged
        user(intNext) = "D"
    End Sub

End Class
