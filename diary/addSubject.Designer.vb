<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSubject
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
        Dim Subject_NameLabel As System.Windows.Forms.Label
        Dim Teacher_NameLabel As System.Windows.Forms.Label
        Dim Teacher_Family_NameLabel As System.Windows.Forms.Label
        Dim Classes_per_WeekLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addSubject))
        Me.back = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.SubjectsTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.SubjectsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Subject_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Teacher_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Teacher_Family_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Classes_per_WeekTextBox = New System.Windows.Forms.TextBox()
        Subject_NameLabel = New System.Windows.Forms.Label()
        Teacher_NameLabel = New System.Windows.Forms.Label()
        Teacher_Family_NameLabel = New System.Windows.Forms.Label()
        Classes_per_WeekLabel = New System.Windows.Forms.Label()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubjectsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Subject_NameLabel
        '
        Subject_NameLabel.AutoSize = True
        Subject_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Subject_NameLabel.Location = New System.Drawing.Point(2, 38)
        Subject_NameLabel.Name = "Subject_NameLabel"
        Subject_NameLabel.Size = New System.Drawing.Size(170, 17)
        Subject_NameLabel.TabIndex = 22
        Subject_NameLabel.Text = "Име на учебен предмет:"
        '
        'Teacher_NameLabel
        '
        Teacher_NameLabel.AutoSize = True
        Teacher_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Teacher_NameLabel.Location = New System.Drawing.Point(48, 67)
        Teacher_NameLabel.Name = "Teacher_NameLabel"
        Teacher_NameLabel.Size = New System.Drawing.Size(124, 17)
        Teacher_NameLabel.TabIndex = 23
        Teacher_NameLabel.Text = "Име на учителят:"
        '
        'Teacher_Family_NameLabel
        '
        Teacher_Family_NameLabel.AutoSize = True
        Teacher_Family_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Teacher_Family_NameLabel.Location = New System.Drawing.Point(69, 94)
        Teacher_Family_NameLabel.Name = "Teacher_Family_NameLabel"
        Teacher_Family_NameLabel.Size = New System.Drawing.Size(103, 17)
        Teacher_Family_NameLabel.TabIndex = 24
        Teacher_Family_NameLabel.Text = "Фамилно име:"
        '
        'Classes_per_WeekLabel
        '
        Classes_per_WeekLabel.AutoSize = True
        Classes_per_WeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Classes_per_WeekLabel.Location = New System.Drawing.Point(22, 123)
        Classes_per_WeekLabel.Name = "Classes_per_WeekLabel"
        Classes_per_WeekLabel.Size = New System.Drawing.Size(140, 17)
        Classes_per_WeekLabel.TabIndex = 25
        Classes_per_WeekLabel.Text = "Часове на седмица:"
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.back.Location = New System.Drawing.Point(12, 153)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(95, 31)
        Me.back.TabIndex = 21
        Me.back.Text = "Върни се"
        Me.back.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.add.Location = New System.Drawing.Point(193, 151)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 33)
        Me.add.TabIndex = 12
        Me.add.Text = "Добави"
        Me.add.UseVisualStyleBackColor = True
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
        'SubjectsBindingNavigator
        '
        Me.SubjectsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SubjectsBindingNavigator.BindingSource = Me.SubjectsBindingSource
        Me.SubjectsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SubjectsBindingNavigator.DeleteItem = Nothing
        Me.SubjectsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.SubjectsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SubjectsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SubjectsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SubjectsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SubjectsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SubjectsBindingNavigator.Name = "SubjectsBindingNavigator"
        Me.SubjectsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SubjectsBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.SubjectsBindingNavigator.TabIndex = 22
        Me.SubjectsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Subject_NameTextBox
        '
        Me.Subject_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Subject Name", True))
        Me.Subject_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Subject_NameTextBox.Location = New System.Drawing.Point(178, 35)
        Me.Subject_NameTextBox.Name = "Subject_NameTextBox"
        Me.Subject_NameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Subject_NameTextBox.TabIndex = 23
        '
        'Teacher_NameTextBox
        '
        Me.Teacher_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Teacher Name", True))
        Me.Teacher_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Teacher_NameTextBox.Location = New System.Drawing.Point(178, 64)
        Me.Teacher_NameTextBox.Name = "Teacher_NameTextBox"
        Me.Teacher_NameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Teacher_NameTextBox.TabIndex = 24
        '
        'Teacher_Family_NameTextBox
        '
        Me.Teacher_Family_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Teacher Family Name", True))
        Me.Teacher_Family_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Teacher_Family_NameTextBox.Location = New System.Drawing.Point(178, 94)
        Me.Teacher_Family_NameTextBox.Name = "Teacher_Family_NameTextBox"
        Me.Teacher_Family_NameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Teacher_Family_NameTextBox.TabIndex = 25
        '
        'Classes_per_WeekTextBox
        '
        Me.Classes_per_WeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Classes per Week", True))
        Me.Classes_per_WeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Classes_per_WeekTextBox.Location = New System.Drawing.Point(168, 123)
        Me.Classes_per_WeekTextBox.Name = "Classes_per_WeekTextBox"
        Me.Classes_per_WeekTextBox.Size = New System.Drawing.Size(33, 23)
        Me.Classes_per_WeekTextBox.TabIndex = 26
        '
        'addSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.Controls.Add(Classes_per_WeekLabel)
        Me.Controls.Add(Me.Classes_per_WeekTextBox)
        Me.Controls.Add(Teacher_Family_NameLabel)
        Me.Controls.Add(Me.Teacher_Family_NameTextBox)
        Me.Controls.Add(Teacher_NameLabel)
        Me.Controls.Add(Me.Teacher_NameTextBox)
        Me.Controls.Add(Subject_NameLabel)
        Me.Controls.Add(Me.Subject_NameTextBox)
        Me.Controls.Add(Me.SubjectsBindingNavigator)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.add)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addSubject"
        Me.Text = "Добавяне на предмет"
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubjectsBindingNavigator.ResumeLayout(False)
        Me.SubjectsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents back As System.Windows.Forms.Button
    Private WithEvents add As System.Windows.Forms.Button
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SubjectsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Subject_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teacher_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teacher_Family_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Classes_per_WeekTextBox As System.Windows.Forms.TextBox
End Class
