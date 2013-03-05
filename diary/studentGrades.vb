Public Class StudentGrades
    Public writingText As String
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'Запазва въведената от вас информация по текстовите файлове
        If functions.CheckSelectedEntry(subjectList) Then
            Dim locationNumberSubject As String = labelStudentNumber.Text & "_" & labelCurrentSubjectNumber.Text
            functions.WriteToDiarySave("offline-Grade", studentGradesList, locationNumberSubject)
            functions.WriteToDiarySave("offline-Absence", studentAbsenceList, locationNumberSubject)
            functions.WriteToDiarySave("offline-Remark", remarksView, locationNumberSubject)
        End If
    End Sub

    Private Sub bsubjectAddEditRemove_Click(sender As Object, e As EventArgs) Handles subjectAddEditRemove.Click
        functions.ShowFormHideCurrent(Me, addSubject)
    End Sub

    Private Sub StudentGrades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub diary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Subjects' table.
        Me.SubjectsTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Subjects)

        functions.BackColor(Me, Color.RosyBrown)

        If (Date.Now > New Date(Date.Now.Year, 2, 1)) And (Date.Now < New Date(Date.Now.Year, 7, 1)) Then
            labelCurrentSemester.Text = "II"
        Else
            labelCurrentSemester.Text = "I"
        End If

        ' Преминава през редовете и ги добавя в списъка
        With subjectList
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

                subjectList.Items.AddRange(New ListViewItem() {lvItem})
            End With
        Next
        subjectList.Sorting = SortOrder.Ascending
    End Sub
    'Бутоните, с който вие потвърждавате своя избор.
    Private Sub confirmChoice_Click(sender As Object, e As EventArgs) Handles confirmChoice.Click
        labelCurrentSubject.Text = subjectList.SelectedItems(0).Text
        labelCurrentSubjectNumber.Text = subjectList.SelectedIndices(0) + 1
        Dim directory As String
        directory = labelStudentNumber.Text & "_" & labelCurrentSubjectNumber.Text
        functions.ReadFile(directory, "studentGrades.txt", studentGradesList, "grade")
        functions.ReadFile(directory, "studentAbsence.txt", studentAbsenceList, "absence")
        functions.ReadFile(directory, "studentRemark.txt", remarksView, "remark")
    End Sub
    'Пише по файлът, съхраняващ отсъствията
    Private Sub addAbsence_Click(sender As Object, e As EventArgs) Handles addAbsence.Click
        functions.WriteToDiary("absence", studentAbsenceList, Val(labelStudentNumber.Text))
    End Sub
    'Премахва информацията от файлът, съхраняващ отсъствията 
    Private Sub removeAbsence_Click(sender As Object, e As EventArgs) Handles removeAbsence.Click
        If functions.CheckSelectedEntry(studentAbsenceList) Then
            If functions.ConfirmAction() Then
                summary.summaryView.Items.Add("Премахнато отсъствие на Номер " & labelStudentNumber.Text & ":" & studentAbsenceList.SelectedItems(0).Text)
                studentAbsenceList.Items.RemoveAt(studentAbsenceList.SelectedIndices(0))
            End If
        End If
    End Sub
    'Пише по файлът, съхраняващ оценките
    Private Sub addGrade_Click(sender As Object, e As EventArgs) Handles addGrade.Click
        functions.WriteToDiary("grade", studentGradesList, Val(labelStudentNumber.Text))

    End Sub
    'Премахва информацията от файлът, съхраняващ оценките 
    Private Sub removeGrade_Click(sender As Object, e As EventArgs) Handles removeGrade.Click
        If functions.CheckSelectedEntry(studentGradesList) Then
            If functions.ConfirmAction() Then
                summary.summaryView.Items.Add("Премахната оценка на Номер " & labelStudentNumber.Text & ":" & studentAbsenceList.SelectedItems(0).Text)
                studentGradesList.Items.RemoveAt(studentGradesList.SelectedIndices(0))
            End If
        End If
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        functions.ShowFormHideCurrent(Me, StudentSelection)
    End Sub
End Class