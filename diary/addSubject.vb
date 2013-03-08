Public Class addSubject

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Me.Validate()
        Me.SubjectsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ElectronicDiaryDatabaseDataSet) 'Запазва предметът към базата данни
        Dim subject As String
        subject = Subject_NameTextBox.Text
        summary.summaryView.Items.Add("Добавен час:" & subject)
        functions.ShowFormHideCurrent(Me, StudentGrades) 'Добавя промяната към крайният отчет.
        StudentGrades.SubjectsTableAdapter.Fill(StudentGrades.ElectronicDiaryDatabaseDataSet.Subjects)
        StudentGrades.subjectList.Clear()
        With StudentGrades.subjectList
            .Columns.Add("Предмет", 90, HorizontalAlignment.Left)
            .Columns.Add("Преподавател", 90, HorizontalAlignment.Left)
            .FullRowSelect = True
            .GridLines = True
            .MultiSelect = False
            .View = View.Tile
        End With

        ' Преминава през редовете и ги добавя в списъка
        For Each dr As ElectronicDiaryDatabaseDataSet.SubjectsRow In ElectronicDiaryDatabaseDataSet.Subjects.Rows
            With dr
                Dim lvItem As New ListViewItem(.Subject_Name, 0)
                lvItem.SubItems.Add(.Teacher_Family_Name)
                'Добавя учебният предмет към списъкът с предмети
                StudentGrades.subjectList.Items.AddRange(New ListViewItem() {lvItem})
            End With
        Next
        StudentGrades.subjectList.Sorting = SortOrder.Ascending
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        functions.ShowFormHideCurrent(Me, StudentGrades)
    End Sub

    Private Sub addSubject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub addSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Subjects' table.
        Me.SubjectsTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Subjects)


    End Sub


End Class