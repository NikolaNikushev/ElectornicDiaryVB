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
            summary.summaryView.Items.Add("Ученик добавен:" & firstName & " " & lastName) 'Добавя промените към крайният отчет.
        
            StudentSelection.studentList.Clear()
            'Попълва информацията в тип ListView
            With StudentSelection.studentList
                .Columns.Add("Име", 90, HorizontalAlignment.Left)
                .Columns.Add("Фамилно име", 90, HorizontalAlignment.Left)
                .FullRowSelect = True
                .GridLines = True
                .MultiSelect = False
                .View = View.Details
            End With

            'Минава през редовете и добавя информацията, която таргетираме, с цел изпращане на мейловете
            For Each dr As ElectronicDiaryDatabaseDataSet.Student_DataRow In ElectronicDiaryDatabaseDataSet.Student_Data.Rows
                With dr
                    Dim lvItem As New ListViewItem(.Student_Name, 0)
                    lvItem.SubItems.Add(.Student_Family_Name)
                    StudentSelection.studentList.Items.AddRange(New ListViewItem() {lvItem})
                End With
            Next
            StudentSelection.studentList.Sorting = SortOrder.Ascending
        Catch ex As Exception
            MsgBox("Номерът на ученикът вече е зает!")
        End Try
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
'Списък с намерени проблеми:
' : При модифицирането на ученик
' : При въвеждане на ново име с несъответстващо име за подредбата в момента не се транспортира информацията за оценките и отсъствията с него ( лесен for цикъл, но не сме имали времето да го оправим )