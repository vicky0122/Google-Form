<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.DarkOrange
        btnViewSubmissions.BackgroundImageLayout = ImageLayout.Zoom
        btnViewSubmissions.Location = New Point(70, 114)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Padding = New Padding(5)
        btnViewSubmissions.RightToLeft = RightToLeft.Yes
        btnViewSubmissions.Size = New Size(320, 44)
        btnViewSubmissions.TabIndex = 9
        btnViewSubmissions.Tag = ""
        btnViewSubmissions.Text = "VIEW SUBMISSION(CTRL+V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.CornflowerBlue
        btnCreateSubmission.BackgroundImageLayout = ImageLayout.Zoom
        btnCreateSubmission.FlatStyle = FlatStyle.Popup
        btnCreateSubmission.ForeColor = SystemColors.ActiveCaptionText
        btnCreateSubmission.Location = New Point(70, 175)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(324, 44)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "CREATE SUBMISSION(CTRL+N)"
        btnCreateSubmission.TextImageRelation = TextImageRelation.TextAboveImage
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 25)
        Label1.TabIndex = 2
        Label1.Text = "Veekshitha,Slidely Task 2-Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 353)
        Controls.Add(Label1)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Cursor = Cursors.Hand
        Name = "Form1"
        Text = "Form1"
        TransparencyKey = Color.Blue
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Label1 As Label
End Class
