Public Class selector
    Public toWho As String
    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Hide()
        summary.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Hide()
        message.Show()
        toWho = "Класа"
        message.label2.Text = toWho
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Hide()
        message.Show()
        toWho = "Родителите"
        message.label2.Text = toWho
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Me.Hide()
        message.Show()
        toWho = "Ученика"
        message.label2.Text = toWho
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        addStudent.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        'Me.Hide()
        MsgBox("Need database :)")
        ' OPEN SAVED DATA TO EDIT
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        listBox1.Items.Remove(listBox1.SelectedItem)
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        'Me.Hide()
        MsgBox("Need database :)")

        'OPEN SAVED DATA TO VIEW
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If listBox1.SelectedItem IsNot Nothing AndAlso listBox1.SelectedItem.ToString() <> "" Then
            diary.label3.Text = listBox1.SelectedItem
            Me.Hide()
            diary.Show()
        End If
    End Sub

    Private Sub selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class