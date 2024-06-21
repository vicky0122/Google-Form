<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        label1 = New Label()
        label2 = New Label()
        label3 = New Label()
        label4 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubRepo = New TextBox()
        Label5 = New Label()
        btnStartStopwatch = New Button()
        btnSubmit = New Button()
        txtStopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(55, 104)
        label1.Name = "label1"
        label1.Size = New Size(59, 25)
        label1.TabIndex = 0
        label1.Text = "Name"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(55, 152)
        label2.Name = "label2"
        label2.Size = New Size(54, 25)
        label2.TabIndex = 1
        label2.Text = "Email"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(55, 197)
        label3.Name = "label3"
        label3.Size = New Size(62, 25)
        label3.TabIndex = 2
        label3.Text = "Phone"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(55, 242)
        label4.Name = "label4"
        label4.Size = New Size(109, 25)
        label4.TabIndex = 3
        label4.Text = "GitHubRepo"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(229, 104)
        txtName.Name = "txtName"
        txtName.Size = New Size(327, 31)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(229, 152)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(327, 31)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(229, 197)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(327, 31)
        txtPhone.TabIndex = 6
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.Location = New Point(229, 236)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(327, 31)
        txtGitHubRepo.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(118, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(366, 25)
        Label5.TabIndex = 20
        Label5.Text = "Veekshitha,Slidely Task 2-Create Submissions"
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.BackColor = Color.DarkOrange
        btnStartStopwatch.Location = New Point(44, 326)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(285, 40)
        btnStartStopwatch.TabIndex = 21
        btnStartStopwatch.Text = "STOPWATCH(CTRL+T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.CornflowerBlue
        btnSubmit.Location = New Point(229, 387)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(177, 36)
        btnSubmit.TabIndex = 23
        btnSubmit.Text = "SUBMIT(CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(363, 331)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.Size = New Size(193, 31)
        txtStopwatch.TabIndex = 25
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(651, 450)
        Controls.Add(txtStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStopwatch)
        Controls.Add(Label5)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStopwatch As TextBox
End Class
