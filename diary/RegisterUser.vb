Public Class RegisterUser


    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click

        Me.Validate()
        Me.AccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ElectronicDiaryDatabaseDataSet) 'Запазва потребителят в базата данни
        MsgBox("Вие успешно се регистрирахте! Сега влезте в системата с Вашият потребител!")
        functions.ShowFormHideCurrent(Me, login)

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
       functions.ShowFormHideCurrent(Me, login)
    End Sub

    Private Sub RegisterUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


    Private Sub RegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Accounts'
        Me.AccountsTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Accounts)

    End Sub

End Class