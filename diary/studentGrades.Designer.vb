<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentGrades))
        Me.labelRemarks = New System.Windows.Forms.Label()
        Me.remarksView = New System.Windows.Forms.RichTextBox()
        Me.labelCurrentSemester = New System.Windows.Forms.Label()
        Me.labelSemster = New System.Windows.Forms.Label()
        Me.labelStudentAbsence = New System.Windows.Forms.Label()
        Me.labelGrades = New System.Windows.Forms.Label()
        Me.labelCurrentStudent = New System.Windows.Forms.Label()
        Me.subjectAddEditRemove = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.subjectList = New System.Windows.Forms.ListView()
        Me.confirmChoice = New System.Windows.Forms.Button()
        Me.studentGradesList = New System.Windows.Forms.ListView()
        Me.studentAbsenceList = New System.Windows.Forms.ListView()
        Me.addGrade = New System.Windows.Forms.Button()
        Me.addAbsence = New System.Windows.Forms.Button()
        Me.removeAbsence = New System.Windows.Forms.Button()
        Me.removeGrade = New System.Windows.Forms.Button()
        Me.labelCurrentSubject = New System.Windows.Forms.Label()
        Me.labelCurrentSubjectNumber = New System.Windows.Forms.Label()
        Me.labelInfoNumber = New System.Windows.Forms.Label()
        Me.labelStudentNumber = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Average = New System.Windows.Forms.Label()
        Me.AverageScore = New System.Windows.Forms.Label()
        Me.AverageGrade = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AbsenceSums = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.SubjectsTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelRemarks
        '
        Me.labelRemarks.AutoSize = True
        Me.labelRemarks.Location = New System.Drawing.Point(379, 117)
        Me.labelRemarks.Name = "labelRemarks"
        Me.labelRemarks.Size = New System.Drawing.Size(64, 13)
        Me.labelRemarks.TabIndex = 34
        Me.labelRemarks.Text = "Зебележки"
        '
        'remarksView
        '
        Me.remarksView.Location = New System.Drawing.Point(302, 133)
        Me.remarksView.Name = "remarksView"
        Me.remarksView.Size = New System.Drawing.Size(227, 163)
        Me.remarksView.TabIndex = 33
        Me.remarksView.Text = ""
        '
        'labelCurrentSemester
        '
        Me.labelCurrentSemester.AutoSize = True
        Me.labelCurrentSemester.Location = New System.Drawing.Point(459, 41)
        Me.labelCurrentSemester.Name = "labelCurrentSemester"
        Me.labelCurrentSemester.Size = New System.Drawing.Size(35, 13)
        Me.labelCurrentSemester.TabIndex = 32
        Me.labelCurrentSemester.Text = "label9"
        Me.labelCurrentSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelSemster
        '
        Me.labelSemster.AutoSize = True
        Me.labelSemster.Location = New System.Drawing.Point(448, 15)
        Me.labelSemster.Name = "labelSemster"
        Me.labelSemster.Size = New System.Drawing.Size(32, 13)
        Me.labelSemster.TabIndex = 31
        Me.labelSemster.Text = "Срок"
        '
        'labelStudentAbsence
        '
        Me.labelStudentAbsence.AutoSize = True
        Me.labelStudentAbsence.Location = New System.Drawing.Point(11, 198)
        Me.labelStudentAbsence.Name = "labelStudentAbsence"
        Me.labelStudentAbsence.Size = New System.Drawing.Size(62, 13)
        Me.labelStudentAbsence.TabIndex = 29
        Me.labelStudentAbsence.Text = "Отсъствия"
        '
        'labelGrades
        '
        Me.labelGrades.AutoSize = True
        Me.labelGrades.Location = New System.Drawing.Point(11, 133)
        Me.labelGrades.Name = "labelGrades"
        Me.labelGrades.Size = New System.Drawing.Size(45, 13)
        Me.labelGrades.TabIndex = 27
        Me.labelGrades.Text = "Оценки"
        '
        'labelCurrentStudent
        '
        Me.labelCurrentStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCurrentStudent.Location = New System.Drawing.Point(5, 11)
        Me.labelCurrentStudent.MaximumSize = New System.Drawing.Size(200, 100)
        Me.labelCurrentStudent.Name = "labelCurrentStudent"
        Me.labelCurrentStudent.Size = New System.Drawing.Size(200, 20)
        Me.labelCurrentStudent.TabIndex = 26
        Me.labelCurrentStudent.Text = "Ученик"
        '
        'subjectAddEditRemove
        '
        Me.subjectAddEditRemove.Location = New System.Drawing.Point(163, 255)
        Me.subjectAddEditRemove.Name = "subjectAddEditRemove"
        Me.subjectAddEditRemove.Size = New System.Drawing.Size(136, 41)
        Me.subjectAddEditRemove.TabIndex = 20
        Me.subjectAddEditRemove.Text = "Добави или редактирай час"
        Me.subjectAddEditRemove.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(1, 264)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 19
        Me.save.Text = "Запамети"
        Me.save.UseVisualStyleBackColor = True
        '
        'subjectList
        '
        Me.subjectList.Location = New System.Drawing.Point(211, 2)
        Me.subjectList.Name = "subjectList"
        Me.subjectList.Size = New System.Drawing.Size(190, 78)
        Me.subjectList.TabIndex = 41
        Me.subjectList.UseCompatibleStateImageBehavior = False
        '
        'confirmChoice
        '
        Me.confirmChoice.Location = New System.Drawing.Point(407, 57)
        Me.confirmChoice.Name = "confirmChoice"
        Me.confirmChoice.Size = New System.Drawing.Size(130, 23)
        Me.confirmChoice.TabIndex = 42
        Me.confirmChoice.Text = "Потвърди избора"
        Me.confirmChoice.UseVisualStyleBackColor = True
        '
        'studentGradesList
        '
        Me.studentGradesList.Location = New System.Drawing.Point(79, 121)
        Me.studentGradesList.Name = "studentGradesList"
        Me.studentGradesList.Size = New System.Drawing.Size(121, 25)
        Me.studentGradesList.TabIndex = 43
        Me.studentGradesList.UseCompatibleStateImageBehavior = False
        '
        'studentAbsenceList
        '
        Me.studentAbsenceList.Location = New System.Drawing.Point(79, 191)
        Me.studentAbsenceList.Name = "studentAbsenceList"
        Me.studentAbsenceList.Size = New System.Drawing.Size(121, 25)
        Me.studentAbsenceList.TabIndex = 44
        Me.studentAbsenceList.UseCompatibleStateImageBehavior = False
        '
        'addGrade
        '
        Me.addGrade.Location = New System.Drawing.Point(211, 121)
        Me.addGrade.Name = "addGrade"
        Me.addGrade.Size = New System.Drawing.Size(23, 23)
        Me.addGrade.TabIndex = 45
        Me.addGrade.Text = "+"
        Me.addGrade.UseVisualStyleBackColor = True
        '
        'addAbsence
        '
        Me.addAbsence.Location = New System.Drawing.Point(211, 191)
        Me.addAbsence.Name = "addAbsence"
        Me.addAbsence.Size = New System.Drawing.Size(23, 23)
        Me.addAbsence.TabIndex = 46
        Me.addAbsence.Text = "+"
        Me.addAbsence.UseVisualStyleBackColor = True
        '
        'removeAbsence
        '
        Me.removeAbsence.Location = New System.Drawing.Point(250, 191)
        Me.removeAbsence.Name = "removeAbsence"
        Me.removeAbsence.Size = New System.Drawing.Size(21, 23)
        Me.removeAbsence.TabIndex = 49
        Me.removeAbsence.Text = "-"
        Me.removeAbsence.UseVisualStyleBackColor = True
        '
        'removeGrade
        '
        Me.removeGrade.Location = New System.Drawing.Point(250, 122)
        Me.removeGrade.Name = "removeGrade"
        Me.removeGrade.Size = New System.Drawing.Size(21, 22)
        Me.removeGrade.TabIndex = 48
        Me.removeGrade.Text = "-"
        Me.removeGrade.UseVisualStyleBackColor = True
        '
        'labelCurrentSubject
        '
        Me.labelCurrentSubject.AutoSize = True
        Me.labelCurrentSubject.Location = New System.Drawing.Point(232, 93)
        Me.labelCurrentSubject.Name = "labelCurrentSubject"
        Me.labelCurrentSubject.Size = New System.Drawing.Size(0, 13)
        Me.labelCurrentSubject.TabIndex = 50
        '
        'labelCurrentSubjectNumber
        '
        Me.labelCurrentSubjectNumber.Location = New System.Drawing.Point(299, 27)
        Me.labelCurrentSubjectNumber.Name = "labelCurrentSubjectNumber"
        Me.labelCurrentSubjectNumber.Size = New System.Drawing.Size(0, 0)
        Me.labelCurrentSubjectNumber.TabIndex = 51
        '
        'labelInfoNumber
        '
        Me.labelInfoNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInfoNumber.Location = New System.Drawing.Point(5, 98)
        Me.labelInfoNumber.MaximumSize = New System.Drawing.Size(200, 100)
        Me.labelInfoNumber.Name = "labelInfoNumber"
        Me.labelInfoNumber.Size = New System.Drawing.Size(60, 20)
        Me.labelInfoNumber.TabIndex = 52
        Me.labelInfoNumber.Text = "Номер:"
        '
        'labelStudentNumber
        '
        Me.labelStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStudentNumber.Location = New System.Drawing.Point(61, 98)
        Me.labelStudentNumber.MaximumSize = New System.Drawing.Size(200, 100)
        Me.labelStudentNumber.Name = "labelStudentNumber"
        Me.labelStudentNumber.Size = New System.Drawing.Size(60, 20)
        Me.labelStudentNumber.TabIndex = 53
        Me.labelStudentNumber.Text = "Номер:"
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(82, 264)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 54
        Me.back.Text = "Върни се"
        Me.back.UseVisualStyleBackColor = True
        '
        'Average
        '
        Me.Average.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Average.Location = New System.Drawing.Point(5, 41)
        Me.Average.MaximumSize = New System.Drawing.Size(200, 100)
        Me.Average.Name = "Average"
        Me.Average.Size = New System.Drawing.Size(106, 20)
        Me.Average.TabIndex = 55
        Me.Average.Text = "Среден успех:"
        '
        'AverageScore
        '
        Me.AverageScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageScore.Location = New System.Drawing.Point(106, 41)
        Me.AverageScore.MaximumSize = New System.Drawing.Size(200, 100)
        Me.AverageScore.Name = "AverageScore"
        Me.AverageScore.Size = New System.Drawing.Size(65, 20)
        Me.AverageScore.TabIndex = 56
        Me.AverageScore.Text = "0,00"
        '
        'AverageGrade
        '
        Me.AverageGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageGrade.Location = New System.Drawing.Point(116, 156)
        Me.AverageGrade.MaximumSize = New System.Drawing.Size(200, 100)
        Me.AverageGrade.Name = "AverageGrade"
        Me.AverageGrade.Size = New System.Drawing.Size(99, 20)
        Me.AverageGrade.TabIndex = 58
        Me.AverageGrade.Text = "0,00"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 156)
        Me.Label2.MaximumSize = New System.Drawing.Size(200, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Среден успех:"
        '
        'AbsenceSums
        '
        Me.AbsenceSums.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbsenceSums.Location = New System.Drawing.Point(133, 229)
        Me.AbsenceSums.MaximumSize = New System.Drawing.Size(200, 100)
        Me.AbsenceSums.Name = "AbsenceSums"
        Me.AbsenceSums.Size = New System.Drawing.Size(99, 20)
        Me.AbsenceSums.TabIndex = 60
        Me.AbsenceSums.Text = "0 0/0"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 229)
        Me.Label4.MaximumSize = New System.Drawing.Size(200, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Брой отсъствия:"
        '
        'ElectronicDiaryDatabaseDataSet
        '
        Me.ElectronicDiaryDatabaseDataSet.DataSetName = "ElectronicDiaryDatabaseDataSet"
        Me.ElectronicDiaryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "Subjects"
        Me.SubjectsBindingSource.DataSource = Me.ElectronicDiaryDatabaseDataSet
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Message_Log_To_ParentsTableAdapter = Nothing
        Me.TableAdapterManager.Message_Log_To_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DataTableAdapter = Nothing
        Me.TableAdapterManager.SubjectsTableAdapter = Me.SubjectsTableAdapter
        Me.TableAdapterManager.Summary_LogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 300)
        Me.Controls.Add(Me.AbsenceSums)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AverageGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AverageScore)
        Me.Controls.Add(Me.Average)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.labelStudentNumber)
        Me.Controls.Add(Me.labelInfoNumber)
        Me.Controls.Add(Me.labelCurrentSubjectNumber)
        Me.Controls.Add(Me.labelCurrentSubject)
        Me.Controls.Add(Me.removeAbsence)
        Me.Controls.Add(Me.removeGrade)
        Me.Controls.Add(Me.addAbsence)
        Me.Controls.Add(Me.addGrade)
        Me.Controls.Add(Me.studentAbsenceList)
        Me.Controls.Add(Me.studentGradesList)
        Me.Controls.Add(Me.confirmChoice)
        Me.Controls.Add(Me.subjectList)
        Me.Controls.Add(Me.labelRemarks)
        Me.Controls.Add(Me.remarksView)
        Me.Controls.Add(Me.labelCurrentSemester)
        Me.Controls.Add(Me.labelSemster)
        Me.Controls.Add(Me.labelStudentAbsence)
        Me.Controls.Add(Me.labelGrades)
        Me.Controls.Add(Me.labelCurrentStudent)
        Me.Controls.Add(Me.subjectAddEditRemove)
        Me.Controls.Add(Me.save)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentGrades"
        Me.Text = "Оценките, забележките и отсъствия"
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents labelRemarks As System.Windows.Forms.Label
    Private WithEvents remarksView As System.Windows.Forms.RichTextBox
    Private WithEvents labelCurrentSemester As System.Windows.Forms.Label
    Private WithEvents labelSemster As System.Windows.Forms.Label
    Private WithEvents labelStudentAbsence As System.Windows.Forms.Label
    Private WithEvents labelGrades As System.Windows.Forms.Label
    Public WithEvents labelCurrentStudent As System.Windows.Forms.Label
    Private WithEvents subjectAddEditRemove As System.Windows.Forms.Button
    Private WithEvents save As System.Windows.Forms.Button
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents subjectList As System.Windows.Forms.ListView
    Private WithEvents confirmChoice As System.Windows.Forms.Button
    Friend WithEvents studentGradesList As System.Windows.Forms.ListView
    Friend WithEvents studentAbsenceList As System.Windows.Forms.ListView
    Private WithEvents addGrade As System.Windows.Forms.Button
    Private WithEvents addAbsence As System.Windows.Forms.Button
    Private WithEvents removeAbsence As System.Windows.Forms.Button
    Private WithEvents removeGrade As System.Windows.Forms.Button
    Public WithEvents labelInfoNumber As System.Windows.Forms.Label
    Public WithEvents labelStudentNumber As System.Windows.Forms.Label
    Private WithEvents back As System.Windows.Forms.Button
    Public WithEvents labelCurrentSubject As System.Windows.Forms.Label
    Public WithEvents Average As System.Windows.Forms.Label
    Public WithEvents AverageScore As System.Windows.Forms.Label
    Public WithEvents AverageGrade As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents AbsenceSums As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents labelCurrentSubjectNumber As System.Windows.Forms.Label
End Class
