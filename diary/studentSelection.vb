Public Class StudentSelection
    Public Sub sendMails(ByVal collected As ListView)
        For Each item As Object In collected.Items
            message.labelToWho.Text += item.Text + " " 'Изписва мейлите с разстояние 1 спация
        Next

    End Sub
    Private Sub finished_Click(sender As Object, e As EventArgs) Handles finished.Click
        functions.ShowFormHideCurrent(Me, summary)
    End Sub

    Private Sub massageToClass_Click(sender As Object, e As EventArgs) Handles messageToClass.Click
        sendMails(Invisible)

        'Избрано е да се изпрати съобщение до всички ученици
        functions.ShowFormHideCurrent(Me, message)
    End Sub

    Private Sub massageToParents_Click(sender As Object, e As EventArgs) Handles messageToParents.Click
        sendMails(InvisibleParents)

        functions.ShowFormHideCurrent(Me, message)
        'Избрано е да се изпрати съобщение до всички родители на учениците

    End Sub

    'Изпраща съобщение до ученик
    Private Sub massageToStudent_Click(sender As Object, e As EventArgs) Handles messageToStudent.Click
        If functions.CheckSelectedEntry(studentList) Then
            Dim toWho As String
            toWho = studentList.SelectedItems(0).Text

            functions.MassageToWho(Me.Student_DataTableAdapter.MessageByStudent(toWho)) 'Избрано е да се изпрати съобщение до избрания ученик
            functions.ShowFormHideCurrent(Me, message)
        End If
    End Sub

    'Изпраща съобщение до родител
    Private Sub messageToParent_Click_1(sender As Object, e As EventArgs) Handles messageToParent.Click
        If functions.CheckSelectedEntry(studentList) Then
            Dim toWho, email As String
            email = ""
            toWho = studentList.SelectedItems(0).Text
            Dim counter As Integer = 0
            For Each dr As ElectronicDiaryDatabaseDataSet.Student_DataRow In ElectronicDiaryDatabaseDataSet.Student_Data.Rows
                If dr.Student_Name = toWho Then
                    email = dr.Parent_Email_Address
                    Exit For
                End If
                    counter += 1
            Next
            functions.MassageToWho(email) 'Избрано е да се изпрати съобщение до избрания родител
            functions.ShowFormHideCurrent(Me, message)
        End If
    End Sub

    Private Sub studentData_Click(sender As Object, e As EventArgs) Handles studentData.Click
        functions.ShowFormHideCurrent(Me, addStudent)
    End Sub

    'Потвърждавате ученикът и отивате на следващата форма
    Private Sub confirmChoice_Click(sender As Object, e As EventArgs) Handles confirmChoice.Click
        If functions.CheckSelectedEntry(studentList) Then
            StudentGrades.labelCurrentStudent.Text = studentList.SelectedItems(0).Text
            StudentGrades.labelStudentNumber.Text = studentList.SelectedIndices(0) + 1
            functions.ShowFormHideCurrent(Me, StudentGrades)
        End If
        'Изчислява средният успех на ученикът
        functions.GetAverage(StudentGrades.labelStudentNumber, StudentGrades.labelCurrentSubjectNumber, StudentGrades.studentGradesList, StudentGrades.subjectList, StudentGrades.AverageScore)
        StudentGrades.AverageGrade.Text = "0"
    End Sub

    Private Sub StudentSelection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Student_Data' table.
        Me.Student_DataTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Student_Data)
        functions.BackColor(Me, Color.Coral)
        Invisible.Visible = False
        InvisibleParents.Visible = False

        'Създава ListView
        With studentList
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
                studentList.Items.AddRange(New ListViewItem() {lvItem})
            End With
        Next
        studentList.Sorting = SortOrder.Ascending

        With Invisible
            .Columns.Add("email", 90, HorizontalAlignment.Left)
            .FullRowSelect = True
            .GridLines = True
            .MultiSelect = False
            .View = View.Details
        End With

        'Минава през редовете и добавя информацията, която таргетираме, с цел изпращане на мейловете
        For Each dr As ElectronicDiaryDatabaseDataSet.Student_DataRow In ElectronicDiaryDatabaseDataSet.Student_Data.Rows
            With dr
                Dim mails As New ListViewItem(.Student_Email_Address, 0)
                Invisible.Items.AddRange(New ListViewItem() {mails})
            End With
        Next

        With InvisibleParents
            .Columns.Add("email", 90, HorizontalAlignment.Left)
            .FullRowSelect = True
            .GridLines = True
            .MultiSelect = False
            .View = View.Details
        End With

        'Минава през редовете и добавя информацията, която таргетираме, с цел изпращане на мейловете
        For Each dr As ElectronicDiaryDatabaseDataSet.Student_DataRow In ElectronicDiaryDatabaseDataSet.Student_Data.Rows
            With dr
                Dim mails As New ListViewItem(.Parent_Email_Address, 0)
                InvisibleParents.Items.AddRange(New ListViewItem() {mails})
            End With
        Next

    End Sub

End Class