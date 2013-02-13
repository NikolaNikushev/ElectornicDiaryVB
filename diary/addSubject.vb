Public Class addSubject

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        diary.listBox1.Items.Add(textBox2.Text)
        Dim subject As String
        subject = textBox2.Text
        summary.listView1.Items.Add("Добавен час:" & subject)
        Me.Hide()
        diary.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Hide()
        diary.Show()
    End Sub
End Class