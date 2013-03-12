Public Class login


    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim passwordInput, userNameInput As String
        userNameInput = username.Text
        passwordInput = password.Text
        If Me.AccountsTableAdapter.LoginSystem(userNameInput, passwordInput) Then 'Изпраща подадената информация до базата данни за проверка на потребителя чрез селективна заявка

            MsgBox("Добре дошли, " + userNameInput)
            functions.ShowFormHideCurrent(Me, StudentSelection)
        Else
            MsgBox("Невалиден потребител или парола!")
        End If

    End Sub

    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub



    Private Sub login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.buttonLogin.PerformClick()
        End If
    End Sub

    Private Sub login_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Accounts' table. 
        Me.AccountsTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Accounts)

    End Sub

    Private Sub Registration_Click(sender As Object, e As EventArgs) Handles registration.Click
        functions.ShowFormHideCurrent(Me, RegisterUser)
    End Sub
End Class