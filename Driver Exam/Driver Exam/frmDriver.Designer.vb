<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExam
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExam))
        Me.lblQuestions = New System.Windows.Forms.Label()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.rdbC = New System.Windows.Forms.RadioButton()
        Me.rdbD = New System.Windows.Forms.RadioButton()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.lblOptionA = New System.Windows.Forms.Label()
        Me.lblOptionB = New System.Windows.Forms.Label()
        Me.lblOptionC = New System.Windows.Forms.Label()
        Me.lblOptionD = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblQuestionSet = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuestions
        '
        Me.lblQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestions.Location = New System.Drawing.Point(13, 32)
        Me.lblQuestions.Name = "lblQuestions"
        Me.lblQuestions.Size = New System.Drawing.Size(360, 47)
        Me.lblQuestions.TabIndex = 0
        Me.lblQuestions.Text = "Questions"
        Me.lblQuestions.Visible = False
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbA.Location = New System.Drawing.Point(15, 128)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(37, 17)
        Me.rdbA.TabIndex = 1
        Me.rdbA.TabStop = True
        Me.rdbA.Text = "A."
        Me.rdbA.UseVisualStyleBackColor = True
        Me.rdbA.Visible = False
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbB.Location = New System.Drawing.Point(15, 162)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(37, 17)
        Me.rdbB.TabIndex = 2
        Me.rdbB.TabStop = True
        Me.rdbB.Text = "B."
        Me.rdbB.UseVisualStyleBackColor = True
        Me.rdbB.Visible = False
        '
        'rdbC
        '
        Me.rdbC.AutoSize = True
        Me.rdbC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbC.Location = New System.Drawing.Point(15, 195)
        Me.rdbC.Name = "rdbC"
        Me.rdbC.Size = New System.Drawing.Size(37, 17)
        Me.rdbC.TabIndex = 3
        Me.rdbC.TabStop = True
        Me.rdbC.Text = "C."
        Me.rdbC.UseVisualStyleBackColor = True
        Me.rdbC.Visible = False
        '
        'rdbD
        '
        Me.rdbD.AutoSize = True
        Me.rdbD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbD.Location = New System.Drawing.Point(15, 228)
        Me.rdbD.Name = "rdbD"
        Me.rdbD.Size = New System.Drawing.Size(38, 17)
        Me.rdbD.TabIndex = 4
        Me.rdbD.TabStop = True
        Me.rdbD.Text = "D."
        Me.rdbD.UseVisualStyleBackColor = True
        Me.rdbD.Visible = False
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.Location = New System.Drawing.Point(232, 310)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(53, 7)
        Me.lblCopyRight.TabIndex = 5
        Me.lblCopyRight.Text = "Copyright 2015"
        '
        'lblOptionA
        '
        Me.lblOptionA.AutoSize = True
        Me.lblOptionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionA.Location = New System.Drawing.Point(57, 128)
        Me.lblOptionA.Name = "lblOptionA"
        Me.lblOptionA.Size = New System.Drawing.Size(59, 13)
        Me.lblOptionA.TabIndex = 6
        Me.lblOptionA.Text = "Answer a"
        Me.lblOptionA.Visible = False
        '
        'lblOptionB
        '
        Me.lblOptionB.AutoSize = True
        Me.lblOptionB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionB.Location = New System.Drawing.Point(57, 162)
        Me.lblOptionB.Name = "lblOptionB"
        Me.lblOptionB.Size = New System.Drawing.Size(59, 13)
        Me.lblOptionB.TabIndex = 7
        Me.lblOptionB.Text = "Answer b"
        Me.lblOptionB.Visible = False
        '
        'lblOptionC
        '
        Me.lblOptionC.AutoSize = True
        Me.lblOptionC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionC.Location = New System.Drawing.Point(57, 195)
        Me.lblOptionC.Name = "lblOptionC"
        Me.lblOptionC.Size = New System.Drawing.Size(59, 13)
        Me.lblOptionC.TabIndex = 8
        Me.lblOptionC.Text = "Answer c"
        Me.lblOptionC.Visible = False
        '
        'lblOptionD
        '
        Me.lblOptionD.AutoSize = True
        Me.lblOptionD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionD.Location = New System.Drawing.Point(60, 228)
        Me.lblOptionD.Name = "lblOptionD"
        Me.lblOptionD.Size = New System.Drawing.Size(58, 13)
        Me.lblOptionD.TabIndex = 9
        Me.lblOptionD.Text = "answer d"
        Me.lblOptionD.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(408, 267)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'lblQuestionSet
        '
        Me.lblQuestionSet.AutoSize = True
        Me.lblQuestionSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionSet.Location = New System.Drawing.Point(16, 13)
        Me.lblQuestionSet.Name = "lblQuestionSet"
        Me.lblQuestionSet.Size = New System.Drawing.Size(78, 13)
        Me.lblQuestionSet.TabIndex = 11
        Me.lblQuestionSet.Text = "Question set"
        Me.lblQuestionSet.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(132, 121)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 12
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(273, 121)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 13
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(148, 93)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 15
        Me.lblFirstName.Text = "First Name "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(295, 93)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 16
        Me.lblLastName.Text = "Last Name"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(216, 185)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 17
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(298, 267)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(369, 13)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.Text = "User Name"
        Me.lblUserName.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(50, 53)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(416, 26)
        Me.lblWelcome.TabIndex = 20
        Me.lblWelcome.Text = "Welcome to the Driver Exam. You will need to score atleast 80% to pass" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " this exa" & _
    "m. Please enter your first and last name and then click Start."
        '
        'FrmExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(517, 326)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblQuestionSet)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblOptionD)
        Me.Controls.Add(Me.lblOptionC)
        Me.Controls.Add(Me.lblOptionB)
        Me.Controls.Add(Me.lblOptionA)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.rdbD)
        Me.Controls.Add(Me.rdbC)
        Me.Controls.Add(Me.rdbB)
        Me.Controls.Add(Me.rdbA)
        Me.Controls.Add(Me.lblQuestions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExam"
        Me.Text = "Drivers License Exam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestions As System.Windows.Forms.Label
    Friend WithEvents rdbA As System.Windows.Forms.RadioButton
    Friend WithEvents rdbB As System.Windows.Forms.RadioButton
    Friend WithEvents rdbC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbD As System.Windows.Forms.RadioButton
    Friend WithEvents lblCopyRight As System.Windows.Forms.Label
    Friend WithEvents lblOptionA As System.Windows.Forms.Label
    Friend WithEvents lblOptionB As System.Windows.Forms.Label
    Friend WithEvents lblOptionC As System.Windows.Forms.Label
    Friend WithEvents lblOptionD As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblQuestionSet As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label

End Class
