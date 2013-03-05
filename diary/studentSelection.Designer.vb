<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentSelection))
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.labelWorkWithDiary = New System.Windows.Forms.Label()
        Me.finished = New System.Windows.Forms.Button()
        Me.messageToStudent = New System.Windows.Forms.Button()
        Me.labelMessageToStudent = New System.Windows.Forms.Label()
        Me.labelMessageToParents = New System.Windows.Forms.Label()
        Me.labelMessageToClass = New System.Windows.Forms.Label()
        Me.messageToParents = New System.Windows.Forms.Button()
        Me.messageToClass = New System.Windows.Forms.Button()
        Me.labelChooseStudent = New System.Windows.Forms.Label()
        Me.labelInfoStudentData = New System.Windows.Forms.Label()
        Me.confirmChoice = New System.Windows.Forms.Button()
        Me.studentData = New System.Windows.Forms.Button()
        Me.labelMessageToParent = New System.Windows.Forms.Label()
        Me.messageToParent = New System.Windows.Forms.Button()
        Me.studentList = New System.Windows.Forms.ListView()
        Me.Invisible = New System.Windows.Forms.ListView()
        Me.Student_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.Student_DataTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.Student_DataTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.InvisibleParents = New System.Windows.Forms.ListView()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Student_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelMessage
        '
        Me.labelMessage.AutoSize = True
        Me.labelMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.Location = New System.Drawing.Point(420, 9)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Size = New System.Drawing.Size(168, 29)
        Me.labelMessage.TabIndex = 38
        Me.labelMessage.Text = "СЪОБЩЕНИЕ"
        '
        'labelWorkWithDiary
        '
        Me.labelWorkWithDiary.AutoSize = True
        Me.labelWorkWithDiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWorkWithDiary.Location = New System.Drawing.Point(261, 0)
        Me.labelWorkWithDiary.MaximumSize = New System.Drawing.Size(100, 0)
        Me.labelWorkWithDiary.Name = "labelWorkWithDiary"
        Me.labelWorkWithDiary.Size = New System.Drawing.Size(98, 48)
        Me.labelWorkWithDiary.TabIndex = 37
        Me.labelWorkWithDiary.Text = "Работа с Дневника"
        '
        'finished
        '
        Me.finished.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finished.Location = New System.Drawing.Point(439, 375)
        Me.finished.Name = "finished"
        Me.finished.Size = New System.Drawing.Size(138, 50)
        Me.finished.TabIndex = 34
        Me.finished.Text = "Приключих"
        Me.finished.UseVisualStyleBackColor = True
        '
        'messageToStudent
        '
        Me.messageToStudent.Location = New System.Drawing.Point(439, 167)
        Me.messageToStudent.Name = "messageToStudent"
        Me.messageToStudent.Size = New System.Drawing.Size(150, 35)
        Me.messageToStudent.TabIndex = 33
        Me.messageToStudent.Text = "Съобщение до ученика"
        Me.messageToStudent.UseVisualStyleBackColor = True
        '
        'labelMessageToStudent
        '
        Me.labelMessageToStudent.AutoSize = True
        Me.labelMessageToStudent.Location = New System.Drawing.Point(444, 125)
        Me.labelMessageToStudent.MaximumSize = New System.Drawing.Size(156, 0)
        Me.labelMessageToStudent.Name = "labelMessageToStudent"
        Me.labelMessageToStudent.Size = New System.Drawing.Size(153, 39)
        Me.labelMessageToStudent.TabIndex = 32
        Me.labelMessageToStudent.Text = "Ако имате съобщение само за избраният ученик, изпратете:"
        '
        'labelMessageToParents
        '
        Me.labelMessageToParents.AutoSize = True
        Me.labelMessageToParents.Location = New System.Drawing.Point(444, 214)
        Me.labelMessageToParents.MaximumSize = New System.Drawing.Size(150, 0)
        Me.labelMessageToParents.Name = "labelMessageToParents"
        Me.labelMessageToParents.Size = New System.Drawing.Size(139, 26)
        Me.labelMessageToParents.TabIndex = 31
        Me.labelMessageToParents.Text = "Ако имате съобщение за родителите, изпратете:"
        '
        'labelMessageToClass
        '
        Me.labelMessageToClass.AutoSize = True
        Me.labelMessageToClass.Location = New System.Drawing.Point(436, 48)
        Me.labelMessageToClass.MaximumSize = New System.Drawing.Size(150, 0)
        Me.labelMessageToClass.Name = "labelMessageToClass"
        Me.labelMessageToClass.Size = New System.Drawing.Size(139, 26)
        Me.labelMessageToClass.TabIndex = 30
        Me.labelMessageToClass.Text = "Ако имате съобщение до класа, изпратете:"
        '
        'messageToParents
        '
        Me.messageToParents.Location = New System.Drawing.Point(439, 243)
        Me.messageToParents.Name = "messageToParents"
        Me.messageToParents.Size = New System.Drawing.Size(150, 35)
        Me.messageToParents.TabIndex = 29
        Me.messageToParents.Text = "Съобщение до родителите"
        Me.messageToParents.UseVisualStyleBackColor = True
        '
        'messageToClass
        '
        Me.messageToClass.Location = New System.Drawing.Point(439, 77)
        Me.messageToClass.Name = "messageToClass"
        Me.messageToClass.Size = New System.Drawing.Size(150, 35)
        Me.messageToClass.TabIndex = 28
        Me.messageToClass.Text = "Съобщение до класа"
        Me.messageToClass.UseVisualStyleBackColor = True
        '
        'labelChooseStudent
        '
        Me.labelChooseStudent.AutoSize = True
        Me.labelChooseStudent.Location = New System.Drawing.Point(65, 6)
        Me.labelChooseStudent.Name = "labelChooseStudent"
        Me.labelChooseStudent.Size = New System.Drawing.Size(93, 13)
        Me.labelChooseStudent.TabIndex = 25
        Me.labelChooseStudent.Text = "Изберете ученик"
        '
        'labelInfoStudentData
        '
        Me.labelInfoStudentData.AutoSize = True
        Me.labelInfoStudentData.Location = New System.Drawing.Point(251, 48)
        Me.labelInfoStudentData.MaximumSize = New System.Drawing.Size(120, 0)
        Me.labelInfoStudentData.Name = "labelInfoStudentData"
        Me.labelInfoStudentData.Size = New System.Drawing.Size(120, 52)
        Me.labelInfoStudentData.TabIndex = 24
        Me.labelInfoStudentData.Text = "За да добавите, премахнете, промените данните на ученик, работете с:"
        '
        'confirmChoice
        '
        Me.confirmChoice.Location = New System.Drawing.Point(12, 125)
        Me.confirmChoice.Name = "confirmChoice"
        Me.confirmChoice.Size = New System.Drawing.Size(209, 36)
        Me.confirmChoice.TabIndex = 22
        Me.confirmChoice.Text = "Потвърди избора"
        Me.confirmChoice.UseVisualStyleBackColor = True
        '
        'studentData
        '
        Me.studentData.Location = New System.Drawing.Point(254, 106)
        Me.studentData.Name = "studentData"
        Me.studentData.Size = New System.Drawing.Size(105, 42)
        Me.studentData.TabIndex = 21
        Me.studentData.Text = "Данните за учениците"
        Me.studentData.UseVisualStyleBackColor = True
        '
        'labelMessageToParent
        '
        Me.labelMessageToParent.AutoSize = True
        Me.labelMessageToParent.Location = New System.Drawing.Point(444, 290)
        Me.labelMessageToParent.MaximumSize = New System.Drawing.Size(150, 0)
        Me.labelMessageToParent.Name = "labelMessageToParent"
        Me.labelMessageToParent.Size = New System.Drawing.Size(139, 39)
        Me.labelMessageToParent.TabIndex = 43
        Me.labelMessageToParent.Text = "Ако имате съобщение за родителя на ученика, изпратете:"
        '
        'messageToParent
        '
        Me.messageToParent.Location = New System.Drawing.Point(438, 332)
        Me.messageToParent.Name = "messageToParent"
        Me.messageToParent.Size = New System.Drawing.Size(150, 35)
        Me.messageToParent.TabIndex = 42
        Me.messageToParent.Text = "Съобщение до родителя"
        Me.messageToParent.UseVisualStyleBackColor = True
        '
        'studentList
        '
        Me.studentList.Location = New System.Drawing.Point(12, 22)
        Me.studentList.Name = "studentList"
        Me.studentList.Size = New System.Drawing.Size(209, 97)
        Me.studentList.TabIndex = 44
        Me.studentList.UseCompatibleStateImageBehavior = False
        '
        'Invisible
        '
        Me.Invisible.Location = New System.Drawing.Point(378, 402)
        Me.Invisible.Name = "Invisible"
        Me.Invisible.Size = New System.Drawing.Size(10, 10)
        Me.Invisible.TabIndex = 45
        Me.Invisible.UseCompatibleStateImageBehavior = False
        '
        'Student_DataBindingSource
        '
        Me.Student_DataBindingSource.DataMember = "Student Data"
        Me.Student_DataBindingSource.DataSource = Me.ElectronicDiaryDatabaseDataSet
        '
        'ElectronicDiaryDatabaseDataSet
        '
        Me.ElectronicDiaryDatabaseDataSet.DataSetName = "ElectronicDiaryDatabaseDataSet"
        Me.ElectronicDiaryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_DataTableAdapter
        '
        Me.Student_DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Message_Log_To_ParentsTableAdapter = Nothing
        Me.TableAdapterManager.Message_Log_To_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DataTableAdapter = Me.Student_DataTableAdapter
        Me.TableAdapterManager.SubjectsTableAdapter = Nothing
        Me.TableAdapterManager.Summary_LogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvisibleParents
        '
        Me.InvisibleParents.Location = New System.Drawing.Point(378, 402)
        Me.InvisibleParents.Name = "InvisibleParents"
        Me.InvisibleParents.Size = New System.Drawing.Size(10, 10)
        Me.InvisibleParents.TabIndex = 46
        Me.InvisibleParents.UseCompatibleStateImageBehavior = False
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, 167)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(386, 258)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 47
        Me.Logo.TabStop = False
        '
        'StudentSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 432)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.InvisibleParents)
        Me.Controls.Add(Me.Invisible)
        Me.Controls.Add(Me.studentList)
        Me.Controls.Add(Me.labelMessageToParent)
        Me.Controls.Add(Me.messageToParent)
        Me.Controls.Add(Me.labelMessage)
        Me.Controls.Add(Me.labelWorkWithDiary)
        Me.Controls.Add(Me.finished)
        Me.Controls.Add(Me.messageToStudent)
        Me.Controls.Add(Me.labelMessageToStudent)
        Me.Controls.Add(Me.labelMessageToParents)
        Me.Controls.Add(Me.labelMessageToClass)
        Me.Controls.Add(Me.messageToParents)
        Me.Controls.Add(Me.messageToClass)
        Me.Controls.Add(Me.labelChooseStudent)
        Me.Controls.Add(Me.labelInfoStudentData)
        Me.Controls.Add(Me.confirmChoice)
        Me.Controls.Add(Me.studentData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentSelection"
        Me.Text = "Главно меню"
        CType(Me.Student_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents labelMessage As System.Windows.Forms.Label
    Private WithEvents labelWorkWithDiary As System.Windows.Forms.Label
    Private WithEvents finished As System.Windows.Forms.Button
    Private WithEvents messageToStudent As System.Windows.Forms.Button
    Private WithEvents labelMessageToStudent As System.Windows.Forms.Label
    Private WithEvents labelMessageToParents As System.Windows.Forms.Label
    Private WithEvents labelMessageToClass As System.Windows.Forms.Label
    Private WithEvents messageToParents As System.Windows.Forms.Button
    Private WithEvents messageToClass As System.Windows.Forms.Button
    Private WithEvents labelChooseStudent As System.Windows.Forms.Label
    Private WithEvents labelInfoStudentData As System.Windows.Forms.Label
    Private WithEvents confirmChoice As System.Windows.Forms.Button
    Private WithEvents studentData As System.Windows.Forms.Button
    Private WithEvents labelMessageToParent As System.Windows.Forms.Label
    Private WithEvents messageToParent As System.Windows.Forms.Button
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents Student_DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_DataTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.Student_DataTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents studentList As System.Windows.Forms.ListView
    Friend WithEvents Invisible As System.Windows.Forms.ListView
    Friend WithEvents InvisibleParents As System.Windows.Forms.ListView
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
End Class
