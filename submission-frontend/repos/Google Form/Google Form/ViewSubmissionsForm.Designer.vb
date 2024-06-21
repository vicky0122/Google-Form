<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithub = New Label()
        lblStopwatch = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(64, 100)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(64, 139)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(64, 189)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(62, 25)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone"
        ' 
        ' lblGithub
        ' 
        lblGithub.AutoSize = True
        lblGithub.Location = New Point(64, 234)
        lblGithub.Name = "lblGithub"
        lblGithub.Size = New Size(68, 25)
        lblGithub.TabIndex = 6
        lblGithub.Text = "GitHub"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(64, 282)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(95, 25)
        lblStopwatch.TabIndex = 8
        lblStopwatch.Text = "Stopwatch"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(275, 94)
        txtName.Name = "txtName"
        txtName.Size = New Size(328, 31)
        txtName.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(275, 136)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(328, 31)
        txtEmail.TabIndex = 11
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(275, 186)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(328, 31)
        txtPhone.TabIndex = 13
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(275, 228)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(328, 31)
        txtGitHubLink.TabIndex = 14
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(275, 276)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(328, 31)
        txtStopwatchTime.TabIndex = 15
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Orange
        btnPrevious.Location = New Point(118, 352)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(173, 46)
        btnPrevious.TabIndex = 17
        btnPrevious.Text = "PREVIOUS(CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.CornflowerBlue
        btnNext.Location = New Point(337, 352)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(155, 46)
        btnNext.TabIndex = 18
        btnNext.Text = "NEXT(CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(145, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(353, 25)
        Label1.TabIndex = 19
        Label1.Text = "Veekshitha,Slidely Task 2-View Submissions"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 450)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGithub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
End Class
