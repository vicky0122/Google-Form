Imports System.Net
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        txtStopwatch.ReadOnly = True
        txtStopwatch.Text = "00:00:00"
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            SubmitForm()
        End If
    End Sub

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStopwatch.Text = "Resume Stopwatch"
        Else
            stopwatch.Start()
            btnStartStopwatch.Text = "Pause Stopwatch"
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitForm()
    End Sub

    Private Sub SubmitForm()
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNumber As String = txtPhone.Text
        Dim gitHubLink As String = txtGitHubRepo.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        Dim submissionData As New Dictionary(Of String, String) From {
            {"Name", name},
            {"Email", email},
            {"PhoneNumber", phoneNumber},
            {"GitHubLink", gitHubLink},
            {"StopwatchTime", stopwatchTime}
        }

        Dim webClient As New WebClient()
        webClient.Headers.Add("Content-Type", "application/json")

        Try
            Dim submissionJson As String = JsonConvert.SerializeObject(submissionData)
            Dim response As String = webClient.UploadString("http://localhost:3000/submit", "POST", submissionJson)
            MessageBox.Show("Submission saved successfully")
        Catch ex As Exception
            MessageBox.Show("Error saving submission: " & ex.Message)
        End Try

        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGitHubRepo.Clear()
        stopwatch.Reset()
        btnStartStopwatch.Text = "Start Stopwatch"
        txtStopwatch.Text = "00:00:00"
    End Sub
End Class
