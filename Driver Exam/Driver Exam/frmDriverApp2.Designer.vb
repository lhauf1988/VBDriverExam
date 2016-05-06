<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriverApp2
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
        Me.lstbxResults = New System.Windows.Forms.ListBox()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblPassFailMessage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstbxResults
        '
        Me.lstbxResults.FormattingEnabled = True
        Me.lstbxResults.Location = New System.Drawing.Point(43, 127)
        Me.lstbxResults.Name = "lstbxResults"
        Me.lstbxResults.Size = New System.Drawing.Size(419, 277)
        Me.lstbxResults.TabIndex = 0
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Location = New System.Drawing.Point(206, 468)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(78, 13)
        Me.lblCopyRight.TabIndex = 1
        Me.lblCopyRight.Text = "Copyright 2015"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(114, 37)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(273, 16)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Thank you for taking the Drivers Exam!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPassFailMessage
        '
        Me.lblPassFailMessage.AutoSize = True
        Me.lblPassFailMessage.Location = New System.Drawing.Point(142, 93)
        Me.lblPassFailMessage.Name = "lblPassFailMessage"
        Me.lblPassFailMessage.Size = New System.Drawing.Size(39, 13)
        Me.lblPassFailMessage.TabIndex = 3
        Me.lblPassFailMessage.Text = "Label2"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(387, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Location = New System.Drawing.Point(142, 63)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(39, 13)
        Me.lblFinalScore.TabIndex = 5
        Me.lblFinalScore.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(216, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(39, 13)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "Label1"
        '
        'frmDriverApp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 490)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPassFailMessage)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.lstbxResults)
        Me.Name = "frmDriverApp2"
        Me.Text = "frmDriverApp2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbxResults As System.Windows.Forms.ListBox
    Friend WithEvents lblCopyRight As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblPassFailMessage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblFinalScore As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
