Imports System.Net.Mail
Public Class message

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        functions.ShowFormHideCurrent(Me, StudentSelection)
    End Sub
    Private Sub send_Click(sender As Object, e As EventArgs) Handles send.Click
        functions.SendMail(messageInfo, YourMail.Text, labelToWho.Text, Subject, YourPassword.Text)

        'Изпраща информацията въведена към крайният отчет
        functions.AddToSummary("До " & labelToWho.Text & ":" & vbCrLf & "text", summary.summaryView)
        functions.ShowFormHideCurrent(Me, StudentSelection)

    End Sub

    Private Sub message_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim splits As String
        splits = labelToWho.Text
        Dim emails() As String = splits.Split(" ")
        labelToWho.Text = ""
        For Each item As String In emails
            labelToWho.Text += item + ","
        Next


    End Sub
End Class