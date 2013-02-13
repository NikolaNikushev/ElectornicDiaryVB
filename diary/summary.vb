Public Class summary

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        selector.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        login.Close()
    End Sub

    Private Sub summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'listView1=CHANGES
    End Sub
End Class