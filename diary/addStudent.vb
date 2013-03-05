Public Class addStudent

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        functions.ShowFormHideCurrent(Me, StudentSelection)
    End Sub

    Private Sub buttonAddStudent_Click(sender As Object, e As EventArgs) Handles buttonAddStudent.Click
        Try 'Проверява дали информацията е валидна и при грешка не позволява продължаване
            Me.Validate()
            Me.Student_DataBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ElectronicDiaryDatabaseDataSet) 'Запазва ученикът към базата данни.
            MsgBox("Ученикът е добавен успешно!")

            Dim firstName, lastName As String
            firstName = Student_NameTextBox.Text
            lastName = Student_Family_NameTextBox.Text
            summary.summaryView.Items.Add("Student Added:" & firstName & " " & lastName) 'Добавя промените към крайният отчет.
        Catch ex As Exception
            MsgBox("Номерът на ученикът вече е зает!")
        End Try
        For Each dr As ElectronicDiaryDatabaseDataSet.Student_DataRow In ElectronicDiaryDatabaseDataSet.Student_Data.Rows
            With dr
                Dim lvItem As New ListViewItem(.Student_Name, 0)
                lvItem.SubItems.Add(.Student_Family_Name)

                StudentSelection.studentList.Items.AddRange(New ListViewItem() {lvItem}) 'Добавя ученикът към списъка с ученици
            End With
        Next
        StudentSelection.studentList.Sorting = SortOrder.Ascending

    End Sub

    Private Sub addStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Student_Data' table.
        Me.Student_DataTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Student_Data)
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Student_Data' table.
        Me.Student_DataTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Student_Data)
        functions.BackColor(Me, Color.Tan)

    End Sub

End Class