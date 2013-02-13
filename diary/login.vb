Public Class login
    ' Dim usernames(10), passwords(10) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim enteredPassword, enteredUserName As String
        'enteredPassword = TextBox2.Text
        ' enteredUserName = TextBox1.Text
        'For i = 0 To 10 Step 1
        'If enteredPassword = passwords(i) Then
        'If enteredUserName = usernames(i) Then
        ' 'PASS
        Me.Hide()
        selector.Show()
        MessageBox.Show("Добре дошли, господине(госпожо(госпожице)) „име""")
        ' Load files
        ' Else
        ' 'ERROR in Password
        ' End If
        ' Else
        ' 'ERROR in username
        ' End If
        ' Next
    End Sub
End Class