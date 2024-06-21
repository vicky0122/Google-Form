Imports System.Net
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private Shared submissions As List(Of Submission)

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        FetchSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.P Then
            ShowPreviousSubmission()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            ShowNextSubmission()
        End If
    End Sub

    Private Sub FetchSubmission(index As Integer)
        Using webClient As New WebClient()
            Try
                Dim response As String = webClient.DownloadString($"http://localhost:3000/read?index={index}")
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(response)

                If submissions Is Nothing Then submissions = New List(Of Submission)()

                If index >= submissions.Count Then submissions.Add(submission)

                ShowSubmission(submission)
            Catch ex As Exception
                MessageBox.Show("Submissions are completed")
            End Try
        End Using
    End Sub

    Private Sub ShowSubmission(submission As Submission)
        If submission IsNot Nothing Then
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.PhoneNumber
            txtGitHubLink.Text = submission.GitHubLink
            txtStopwatchTime.Text = submission.StopwatchTime

            ' Make text boxes read-only
            txtName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtPhone.ReadOnly = True
            txtGitHubLink.ReadOnly = True
            txtStopwatchTime.ReadOnly = True
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ShowPreviousSubmission()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ShowNextSubmission()
    End Sub

    Private Sub ShowPreviousSubmission()
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(submissions(currentIndex))
        Else
            MessageBox.Show("No previous submissions.")
        End If
    End Sub

    Private Sub ShowNextSubmission()
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(submissions(currentIndex))
        Else
            FetchSubmission(currentIndex + 1)
        End If
    End Sub
End Class
