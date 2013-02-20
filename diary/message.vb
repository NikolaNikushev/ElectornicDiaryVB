Public Class message

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        StudentSelection.Show()
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim message As String
        Dim toWho As String
        toWho = StudentSelection.toWho
        message = richTextBox1.Text
        summary.listView1.Items.Add("До " & toWho & ":" & vbCrLf & message)
        Me.Hide()
        StudentSelection.Show()
    End Sub
End Class