Public Class addStudent

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        StudentSelection.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim firstName, lastName As String
        firstName = textBox1.Text
        lastName = textBox3.Text
        summary.listView1.Items.Add("Student Added:" & firstName & " " & lastName)
        StudentSelection.listBox1.Items.Add(firstName & " " & lastName)
        Me.Hide()
        StudentSelection.Show()
    End Sub
End Class