Public Class summary

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        functions.ShowFormHideCurrent(Me, StudentSelection)
    End Sub

    Private Sub forward_Click(sender As Object, e As EventArgs) Handles forward.Click
        Application.Exit()
    End Sub

    Private Sub summary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        functions.BackColor(Me, Color.Tomato)
    End Sub
End Class