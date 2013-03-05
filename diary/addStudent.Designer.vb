<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
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
        Dim Student_Email_AddressLabel As System.Windows.Forms.Label
        Dim Student_AddressLabel As System.Windows.Forms.Label
        Dim Student_Telephone_NumberLabel As System.Windows.Forms.Label
        Dim Student_PINLabel As System.Windows.Forms.Label
        Dim Student_Family_NameLabel As System.Windows.Forms.Label
        Dim Student_SurnameLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Parent_NameLabel As System.Windows.Forms.Label
        Dim Parent_Family_NameLabel As System.Windows.Forms.Label
        Dim Parent_Telephone_NumberLabel As System.Windows.Forms.Label
        Dim Parent_AddressLabel As System.Windows.Forms.Label
        Dim Parent_Email_AddressLabel As System.Windows.Forms.Label
        Dim Personal_Doctor_NameLabel As System.Windows.Forms.Label
        Dim Personal_Doctor_AddressLabel As System.Windows.Forms.Label
        Dim Personal_Doctor_Telephone_NumberLabel As System.Windows.Forms.Label
        Dim Personal_Doctor_Email_AddressLabel As System.Windows.Forms.Label
        Dim Health_InsuranceLabel As System.Windows.Forms.Label
        Dim Ambilutory_CardLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addStudent))
        Me.labelPersonalDoctor = New System.Windows.Forms.Label()
        Me.labelParent = New System.Windows.Forms.Label()
        Me.buttonAddStudent = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.labelStudent = New System.Windows.Forms.Label()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Student_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Student_SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Student_Family_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Student_PINTextBox = New System.Windows.Forms.TextBox()
        Me.Student_Telephone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Student_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Student_Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Health_InsuranceCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Ambilutory_CardCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Parent_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Parent_Family_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Parent_Telephone_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.Parent_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Parent_Email_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Personal_Doctor_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Personal_Doctor_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Personal_Doctor_Telephone_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.Personal_Doctor_Email_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Student_DataTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.Student_DataTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        Student_Email_AddressLabel = New System.Windows.Forms.Label()
        Student_AddressLabel = New System.Windows.Forms.Label()
        Student_Telephone_NumberLabel = New System.Windows.Forms.Label()
        Student_PINLabel = New System.Windows.Forms.Label()
        Student_Family_NameLabel = New System.Windows.Forms.Label()
        Student_SurnameLabel = New System.Windows.Forms.Label()
        Student_NameLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Parent_NameLabel = New System.Windows.Forms.Label()
        Parent_Family_NameLabel = New System.Windows.Forms.Label()
        Parent_Telephone_NumberLabel = New System.Windows.Forms.Label()
        Parent_AddressLabel = New System.Windows.Forms.Label()
        Parent_Email_AddressLabel = New System.Windows.Forms.Label()
        Personal_Doctor_NameLabel = New System.Windows.Forms.Label()
        Personal_Doctor_AddressLabel = New System.Windows.Forms.Label()
        Personal_Doctor_Telephone_NumberLabel = New System.Windows.Forms.Label()
        Personal_Doctor_Email_AddressLabel = New System.Windows.Forms.Label()
        Health_InsuranceLabel = New System.Windows.Forms.Label()
        Ambilutory_CardLabel = New System.Windows.Forms.Label()
        CType(Me.Student_DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Student_DataBindingNavigator.SuspendLayout()
        CType(Me.Student_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_Email_AddressLabel
        '
        Student_Email_AddressLabel.AutoSize = True
        Student_Email_AddressLabel.Location = New System.Drawing.Point(13, 267)
        Student_Email_AddressLabel.Name = "Student_Email_AddressLabel"
        Student_Email_AddressLabel.Size = New System.Drawing.Size(100, 13)
        Student_Email_AddressLabel.TabIndex = 95
        Student_Email_AddressLabel.Text = "Електронна поща:"
        '
        'Student_AddressLabel
        '
        Student_AddressLabel.AutoSize = True
        Student_AddressLabel.Location = New System.Drawing.Point(72, 237)
        Student_AddressLabel.Name = "Student_AddressLabel"
        Student_AddressLabel.Size = New System.Drawing.Size(41, 13)
        Student_AddressLabel.TabIndex = 93
        Student_AddressLabel.Text = "Адрес:"
        '
        'Student_Telephone_NumberLabel
        '
        Student_Telephone_NumberLabel.AutoSize = True
        Student_Telephone_NumberLabel.Location = New System.Drawing.Point(14, 211)
        Student_Telephone_NumberLabel.Name = "Student_Telephone_NumberLabel"
        Student_Telephone_NumberLabel.Size = New System.Drawing.Size(102, 13)
        Student_Telephone_NumberLabel.TabIndex = 91
        Student_Telephone_NumberLabel.Text = "Телефонен номер:"
        '
        'Student_PINLabel
        '
        Student_PINLabel.AutoSize = True
        Student_PINLabel.Location = New System.Drawing.Point(85, 185)
        Student_PINLabel.Name = "Student_PINLabel"
        Student_PINLabel.Size = New System.Drawing.Size(31, 13)
        Student_PINLabel.TabIndex = 89
        Student_PINLabel.Text = "ЕГН:"
        '
        'Student_Family_NameLabel
        '
        Student_Family_NameLabel.AutoSize = True
        Student_Family_NameLabel.Location = New System.Drawing.Point(57, 159)
        Student_Family_NameLabel.Name = "Student_Family_NameLabel"
        Student_Family_NameLabel.Size = New System.Drawing.Size(59, 13)
        Student_Family_NameLabel.TabIndex = 87
        Student_Family_NameLabel.Text = "Фамилия:"
        '
        'Student_SurnameLabel
        '
        Student_SurnameLabel.AutoSize = True
        Student_SurnameLabel.Location = New System.Drawing.Point(57, 133)
        Student_SurnameLabel.Name = "Student_SurnameLabel"
        Student_SurnameLabel.Size = New System.Drawing.Size(56, 13)
        Student_SurnameLabel.TabIndex = 85
        Student_SurnameLabel.Text = "Презиме:"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(81, 107)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(32, 13)
        Student_NameLabel.TabIndex = 83
        Student_NameLabel.Text = "Име:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Location = New System.Drawing.Point(8, 81)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(108, 13)
        Student_IDLabel.TabIndex = 82
        Student_IDLabel.Text = "Номер на ученикът:"
        '
        'Parent_NameLabel
        '
        Parent_NameLabel.AutoSize = True
        Parent_NameLabel.Location = New System.Drawing.Point(363, 77)
        Parent_NameLabel.Name = "Parent_NameLabel"
        Parent_NameLabel.Size = New System.Drawing.Size(32, 13)
        Parent_NameLabel.TabIndex = 98
        Parent_NameLabel.Text = "Име:"
        '
        'Parent_Family_NameLabel
        '
        Parent_Family_NameLabel.AutoSize = True
        Parent_Family_NameLabel.Location = New System.Drawing.Point(336, 103)
        Parent_Family_NameLabel.Name = "Parent_Family_NameLabel"
        Parent_Family_NameLabel.Size = New System.Drawing.Size(59, 13)
        Parent_Family_NameLabel.TabIndex = 100
        Parent_Family_NameLabel.Text = "Фамилия:"
        '
        'Parent_Telephone_NumberLabel
        '
        Parent_Telephone_NumberLabel.AutoSize = True
        Parent_Telephone_NumberLabel.Location = New System.Drawing.Point(293, 129)
        Parent_Telephone_NumberLabel.Name = "Parent_Telephone_NumberLabel"
        Parent_Telephone_NumberLabel.Size = New System.Drawing.Size(102, 13)
        Parent_Telephone_NumberLabel.TabIndex = 101
        Parent_Telephone_NumberLabel.Text = "Телефонен номер:"
        '
        'Parent_AddressLabel
        '
        Parent_AddressLabel.AutoSize = True
        Parent_AddressLabel.Location = New System.Drawing.Point(354, 155)
        Parent_AddressLabel.Name = "Parent_AddressLabel"
        Parent_AddressLabel.Size = New System.Drawing.Size(41, 13)
        Parent_AddressLabel.TabIndex = 102
        Parent_AddressLabel.Text = "Адрес:"
        '
        'Parent_Email_AddressLabel
        '
        Parent_Email_AddressLabel.AutoSize = True
        Parent_Email_AddressLabel.Location = New System.Drawing.Point(295, 181)
        Parent_Email_AddressLabel.Name = "Parent_Email_AddressLabel"
        Parent_Email_AddressLabel.Size = New System.Drawing.Size(100, 13)
        Parent_Email_AddressLabel.TabIndex = 103
        Parent_Email_AddressLabel.Text = "Електронна поща:"
        '
        'Personal_Doctor_NameLabel
        '
        Personal_Doctor_NameLabel.AutoSize = True
        Personal_Doctor_NameLabel.Location = New System.Drawing.Point(76, 317)
        Personal_Doctor_NameLabel.Name = "Personal_Doctor_NameLabel"
        Personal_Doctor_NameLabel.Size = New System.Drawing.Size(32, 13)
        Personal_Doctor_NameLabel.TabIndex = 104
        Personal_Doctor_NameLabel.Text = "Име:"
        '
        'Personal_Doctor_AddressLabel
        '
        Personal_Doctor_AddressLabel.AutoSize = True
        Personal_Doctor_AddressLabel.Location = New System.Drawing.Point(67, 340)
        Personal_Doctor_AddressLabel.Name = "Personal_Doctor_AddressLabel"
        Personal_Doctor_AddressLabel.Size = New System.Drawing.Size(41, 13)
        Personal_Doctor_AddressLabel.TabIndex = 105
        Personal_Doctor_AddressLabel.Text = "Адрес:"
        '
        'Personal_Doctor_Telephone_NumberLabel
        '
        Personal_Doctor_Telephone_NumberLabel.AutoSize = True
        Personal_Doctor_Telephone_NumberLabel.Location = New System.Drawing.Point(64, 368)
        Personal_Doctor_Telephone_NumberLabel.Name = "Personal_Doctor_Telephone_NumberLabel"
        Personal_Doctor_Telephone_NumberLabel.Size = New System.Drawing.Size(44, 13)
        Personal_Doctor_Telephone_NumberLabel.TabIndex = 106
        Personal_Doctor_Telephone_NumberLabel.Text = "Номер:"
        '
        'Personal_Doctor_Email_AddressLabel
        '
        Personal_Doctor_Email_AddressLabel.AutoSize = True
        Personal_Doctor_Email_AddressLabel.Location = New System.Drawing.Point(8, 391)
        Personal_Doctor_Email_AddressLabel.Name = "Personal_Doctor_Email_AddressLabel"
        Personal_Doctor_Email_AddressLabel.Size = New System.Drawing.Size(100, 13)
        Personal_Doctor_Email_AddressLabel.TabIndex = 107
        Personal_Doctor_Email_AddressLabel.Text = "Електронна поща:"
        '
        'Health_InsuranceLabel
        '
        Health_InsuranceLabel.AutoSize = True
        Health_InsuranceLabel.Location = New System.Drawing.Point(227, 325)
        Health_InsuranceLabel.Name = "Health_InsuranceLabel"
        Health_InsuranceLabel.Size = New System.Drawing.Size(114, 13)
        Health_InsuranceLabel.TabIndex = 108
        Health_InsuranceLabel.Text = "Здравна осигуровка:"
        '
        'Ambilutory_CardLabel
        '
        Ambilutory_CardLabel.AutoSize = True
        Ambilutory_CardLabel.Location = New System.Drawing.Point(232, 365)
        Ambilutory_CardLabel.Name = "Ambilutory_CardLabel"
        Ambilutory_CardLabel.Size = New System.Drawing.Size(109, 13)
        Ambilutory_CardLabel.TabIndex = 109
        Ambilutory_CardLabel.Text = "Амбулаторна карта:"
        '
        'labelPersonalDoctor
        '
        Me.labelPersonalDoctor.AutoSize = True
        Me.labelPersonalDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPersonalDoctor.Location = New System.Drawing.Point(27, 284)
        Me.labelPersonalDoctor.Name = "labelPersonalDoctor"
        Me.labelPersonalDoctor.Size = New System.Drawing.Size(136, 25)
        Me.labelPersonalDoctor.TabIndex = 50
        Me.labelPersonalDoctor.Text = "Личен лекар:"
        '
        'labelParent
        '
        Me.labelParent.AutoSize = True
        Me.labelParent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelParent.Location = New System.Drawing.Point(374, 35)
        Me.labelParent.Name = "labelParent"
        Me.labelParent.Size = New System.Drawing.Size(99, 25)
        Me.labelParent.TabIndex = 45
        Me.labelParent.Text = "Родител:"
        '
        'buttonAddStudent
        '
        Me.buttonAddStudent.Location = New System.Drawing.Point(379, 398)
        Me.buttonAddStudent.Name = "buttonAddStudent"
        Me.buttonAddStudent.Size = New System.Drawing.Size(113, 43)
        Me.buttonAddStudent.TabIndex = 36
        Me.buttonAddStudent.Text = "Добави ученикът"
        Me.buttonAddStudent.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(15, 418)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(134, 23)
        Me.back.TabIndex = 72
        Me.back.Text = "Върни се"
        Me.back.UseVisualStyleBackColor = True
        '
        'labelStudent
        '
        Me.labelStudent.AutoSize = True
        Me.labelStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStudent.Location = New System.Drawing.Point(94, 35)
        Me.labelStudent.Name = "labelStudent"
        Me.labelStudent.Size = New System.Drawing.Size(84, 25)
        Me.labelStudent.TabIndex = 100
        Me.labelStudent.Text = "Ученик:"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Student_DataBindingNavigator
        '
        Me.Student_DataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Student_DataBindingNavigator.BindingSource = Me.Student_DataBindingSource
        Me.Student_DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Student_DataBindingNavigator.DeleteItem = Nothing
        Me.Student_DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.Student_DataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Student_DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Student_DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Student_DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Student_DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Student_DataBindingNavigator.Name = "Student_DataBindingNavigator"
        Me.Student_DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Student_DataBindingNavigator.Size = New System.Drawing.Size(526, 25)
        Me.Student_DataBindingNavigator.TabIndex = 98
        Me.Student_DataBindingNavigator.Text = "BindingNavigator1"
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
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(122, 78)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_IDTextBox.TabIndex = 126
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student Name", True))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(122, 104)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_NameTextBox.TabIndex = 128
        '
        'Student_SurnameTextBox
        '
        Me.Student_SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student Surname", True))
        Me.Student_SurnameTextBox.Location = New System.Drawing.Point(122, 130)
        Me.Student_SurnameTextBox.Name = "Student_SurnameTextBox"
        Me.Student_SurnameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_SurnameTextBox.TabIndex = 130
        '
        'Student_Family_NameTextBox
        '
        Me.Student_Family_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student Family Name", True))
        Me.Student_Family_NameTextBox.Location = New System.Drawing.Point(122, 156)
        Me.Student_Family_NameTextBox.Name = "Student_Family_NameTextBox"
        Me.Student_Family_NameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_Family_NameTextBox.TabIndex = 132
        '
        'Student_PINTextBox
        '
        Me.Student_PINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student PIN", True))
        Me.Student_PINTextBox.Location = New System.Drawing.Point(122, 182)
        Me.Student_PINTextBox.Name = "Student_PINTextBox"
        Me.Student_PINTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_PINTextBox.TabIndex = 134
        '
        'Student_Telephone_NumberTextBox
        '
        Me.Student_Telephone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student Telephone Number", True))
        Me.Student_Telephone_NumberTextBox.Location = New System.Drawing.Point(122, 208)
        Me.Student_Telephone_NumberTextBox.Name = "Student_Telephone_NumberTextBox"
        Me.Student_Telephone_NumberTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_Telephone_NumberTextBox.TabIndex = 136
        '
        'Student_AddressTextBox
        '
        Me.Student_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student Address", True))
        Me.Student_AddressTextBox.Location = New System.Drawing.Point(122, 234)
        Me.Student_AddressTextBox.Name = "Student_AddressTextBox"
        Me.Student_AddressTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_AddressTextBox.TabIndex = 138
        '
        'Student_Email_AddressTextBox
        '
        Me.Student_Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Student Email Address", True))
        Me.Student_Email_AddressTextBox.Location = New System.Drawing.Point(122, 260)
        Me.Student_Email_AddressTextBox.Name = "Student_Email_AddressTextBox"
        Me.Student_Email_AddressTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Student_Email_AddressTextBox.TabIndex = 140
        '
        'Health_InsuranceCheckBox1
        '
        Me.Health_InsuranceCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Student_DataBindingSource, "Health Insurance", True))
        Me.Health_InsuranceCheckBox1.Location = New System.Drawing.Point(347, 322)
        Me.Health_InsuranceCheckBox1.Name = "Health_InsuranceCheckBox1"
        Me.Health_InsuranceCheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.Health_InsuranceCheckBox1.TabIndex = 142
        Me.Health_InsuranceCheckBox1.UseVisualStyleBackColor = True
        '
        'Ambilutory_CardCheckBox1
        '
        Me.Ambilutory_CardCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Student_DataBindingSource, "Ambilutory Card", True))
        Me.Ambilutory_CardCheckBox1.Location = New System.Drawing.Point(347, 360)
        Me.Ambilutory_CardCheckBox1.Name = "Ambilutory_CardCheckBox1"
        Me.Ambilutory_CardCheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.Ambilutory_CardCheckBox1.TabIndex = 144
        Me.Ambilutory_CardCheckBox1.UseVisualStyleBackColor = True
        '
        'Parent_NameTextBox1
        '
        Me.Parent_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Parent Name", True))
        Me.Parent_NameTextBox1.Location = New System.Drawing.Point(401, 74)
        Me.Parent_NameTextBox1.Name = "Parent_NameTextBox1"
        Me.Parent_NameTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Parent_NameTextBox1.TabIndex = 146
        '
        'Parent_Family_NameTextBox1
        '
        Me.Parent_Family_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Parent Family Name", True))
        Me.Parent_Family_NameTextBox1.Location = New System.Drawing.Point(401, 100)
        Me.Parent_Family_NameTextBox1.Name = "Parent_Family_NameTextBox1"
        Me.Parent_Family_NameTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Parent_Family_NameTextBox1.TabIndex = 148
        '
        'Parent_Telephone_NumberTextBox1
        '
        Me.Parent_Telephone_NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Parent Telephone Number", True))
        Me.Parent_Telephone_NumberTextBox1.Location = New System.Drawing.Point(401, 126)
        Me.Parent_Telephone_NumberTextBox1.Name = "Parent_Telephone_NumberTextBox1"
        Me.Parent_Telephone_NumberTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Parent_Telephone_NumberTextBox1.TabIndex = 150
        '
        'Parent_AddressTextBox1
        '
        Me.Parent_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Parent Address", True))
        Me.Parent_AddressTextBox1.Location = New System.Drawing.Point(401, 152)
        Me.Parent_AddressTextBox1.Name = "Parent_AddressTextBox1"
        Me.Parent_AddressTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Parent_AddressTextBox1.TabIndex = 152
        '
        'Parent_Email_AddressTextBox1
        '
        Me.Parent_Email_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Parent Email Address", True))
        Me.Parent_Email_AddressTextBox1.Location = New System.Drawing.Point(401, 178)
        Me.Parent_Email_AddressTextBox1.Name = "Parent_Email_AddressTextBox1"
        Me.Parent_Email_AddressTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Parent_Email_AddressTextBox1.TabIndex = 154
        '
        'Personal_Doctor_NameTextBox1
        '
        Me.Personal_Doctor_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Personal Doctor Name", True))
        Me.Personal_Doctor_NameTextBox1.Location = New System.Drawing.Point(122, 313)
        Me.Personal_Doctor_NameTextBox1.Name = "Personal_Doctor_NameTextBox1"
        Me.Personal_Doctor_NameTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Personal_Doctor_NameTextBox1.TabIndex = 156
        '
        'Personal_Doctor_AddressTextBox1
        '
        Me.Personal_Doctor_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Personal Doctor Address", True))
        Me.Personal_Doctor_AddressTextBox1.Location = New System.Drawing.Point(122, 339)
        Me.Personal_Doctor_AddressTextBox1.Name = "Personal_Doctor_AddressTextBox1"
        Me.Personal_Doctor_AddressTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Personal_Doctor_AddressTextBox1.TabIndex = 158
        '
        'Personal_Doctor_Telephone_NumberTextBox1
        '
        Me.Personal_Doctor_Telephone_NumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Personal Doctor Telephone Number", True))
        Me.Personal_Doctor_Telephone_NumberTextBox1.Location = New System.Drawing.Point(122, 365)
        Me.Personal_Doctor_Telephone_NumberTextBox1.Name = "Personal_Doctor_Telephone_NumberTextBox1"
        Me.Personal_Doctor_Telephone_NumberTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Personal_Doctor_Telephone_NumberTextBox1.TabIndex = 160
        '
        'Personal_Doctor_Email_AddressTextBox1
        '
        Me.Personal_Doctor_Email_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Personal Doctor Email Address", True))
        Me.Personal_Doctor_Email_AddressTextBox1.Location = New System.Drawing.Point(122, 391)
        Me.Personal_Doctor_Email_AddressTextBox1.Name = "Personal_Doctor_Email_AddressTextBox1"
        Me.Personal_Doctor_Email_AddressTextBox1.Size = New System.Drawing.Size(104, 20)
        Me.Personal_Doctor_Email_AddressTextBox1.TabIndex = 162
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
        'addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 452)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(Me.Student_NameTextBox)
        Me.Controls.Add(Me.Student_SurnameTextBox)
        Me.Controls.Add(Me.Student_Family_NameTextBox)
        Me.Controls.Add(Me.Student_PINTextBox)
        Me.Controls.Add(Me.Student_Telephone_NumberTextBox)
        Me.Controls.Add(Me.Student_AddressTextBox)
        Me.Controls.Add(Me.Student_Email_AddressTextBox)
        Me.Controls.Add(Me.Health_InsuranceCheckBox1)
        Me.Controls.Add(Me.Ambilutory_CardCheckBox1)
        Me.Controls.Add(Me.Parent_NameTextBox1)
        Me.Controls.Add(Me.Parent_Family_NameTextBox1)
        Me.Controls.Add(Me.Parent_Telephone_NumberTextBox1)
        Me.Controls.Add(Me.Parent_AddressTextBox1)
        Me.Controls.Add(Me.Parent_Email_AddressTextBox1)
        Me.Controls.Add(Me.Personal_Doctor_NameTextBox1)
        Me.Controls.Add(Me.Personal_Doctor_AddressTextBox1)
        Me.Controls.Add(Me.Personal_Doctor_Telephone_NumberTextBox1)
        Me.Controls.Add(Me.Personal_Doctor_Email_AddressTextBox1)
        Me.Controls.Add(Ambilutory_CardLabel)
        Me.Controls.Add(Health_InsuranceLabel)
        Me.Controls.Add(Personal_Doctor_Email_AddressLabel)
        Me.Controls.Add(Personal_Doctor_Telephone_NumberLabel)
        Me.Controls.Add(Personal_Doctor_AddressLabel)
        Me.Controls.Add(Personal_Doctor_NameLabel)
        Me.Controls.Add(Parent_Email_AddressLabel)
        Me.Controls.Add(Parent_AddressLabel)
        Me.Controls.Add(Parent_Telephone_NumberLabel)
        Me.Controls.Add(Parent_Family_NameLabel)
        Me.Controls.Add(Me.labelStudent)
        Me.Controls.Add(Parent_NameLabel)
        Me.Controls.Add(Me.Student_DataBindingNavigator)
        Me.Controls.Add(Student_Email_AddressLabel)
        Me.Controls.Add(Student_AddressLabel)
        Me.Controls.Add(Student_Telephone_NumberLabel)
        Me.Controls.Add(Student_PINLabel)
        Me.Controls.Add(Student_Family_NameLabel)
        Me.Controls.Add(Student_SurnameLabel)
        Me.Controls.Add(Student_NameLabel)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.labelPersonalDoctor)
        Me.Controls.Add(Me.labelParent)
        Me.Controls.Add(Me.buttonAddStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addStudent"
        Me.Text = "Добавяне на ученик"
        CType(Me.Student_DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Student_DataBindingNavigator.ResumeLayout(False)
        Me.Student_DataBindingNavigator.PerformLayout()
        CType(Me.Student_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents labelPersonalDoctor As System.Windows.Forms.Label
    Private WithEvents labelParent As System.Windows.Forms.Label
    Private WithEvents buttonAddStudent As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Private WithEvents labelStudent As System.Windows.Forms.Label
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents Student_DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_DataTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.Student_DataTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Student_DataBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Student_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_Family_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_PINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_Telephone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Health_InsuranceCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Ambilutory_CardCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Parent_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Parent_Family_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Parent_Telephone_NumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Parent_AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Parent_Email_AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Personal_Doctor_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Personal_Doctor_AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Personal_Doctor_Telephone_NumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Personal_Doctor_Email_AddressTextBox1 As System.Windows.Forms.TextBox
End Class
