Public Class StudentGrades

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        StudentSelection.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Hide()
        addSubject.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        'dim textInTxT=<ime>_<ime>_<nomer>.txt
        '<ime>_<ime>_<nomer>.txt = VSICHKO
        '- SEND Vsichko
        'selector.changes +=" And you will send EVERYTHING to <student>'s Parent < student parent name>
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        ' send (if toAdd!=textInTXT)
        '<ime>_<ime>_<nomer>.txt=VSICHKO
        'selector.changes +=" And you will send Only the updates to <student>'s Parent < student parent name>
    End Sub

    Private Sub diary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If(date < 1 srok date kogato svurshva, label9.text=1; else label9.text=2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        listBox1.Items.Remove(listBox1.SelectedItem)
    End Sub
End Class