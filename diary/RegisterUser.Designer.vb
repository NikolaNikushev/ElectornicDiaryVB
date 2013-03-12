<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterUser
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterUser))
        Me.Register = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AccountsTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.AccountsTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        CType(Me.AccountsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ElectronicDiaryDatabaseDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.AccountsBindingNavigator,System.ComponentModel.ISupportInitialize).BeginInit
        Me.AccountsBindingNavigator.SuspendLayout
        Me.SuspendLayout
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = true
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        UsernameLabel.Location = New System.Drawing.Point(12, 38)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(92, 17)
        UsernameLabel.TabIndex = 7
        UsernameLabel.Text = "Потребител:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = true
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        PasswordLabel.Location = New System.Drawing.Point(41, 60)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(62, 17)
        PasswordLabel.TabIndex = 8
        PasswordLabel.Text = "Парола:"
        '
        'Label1
        '
        Label1.AutoSize = true
        Label1.Location = New System.Drawing.Point(41, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 13)
        Label1.TabIndex = 10
        Label1.Text = "<-- Добави нов"
        '
        'PositionLabel
        '
        PositionLabel.Location = New System.Drawing.Point(0, 0)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(100, 23)
        PositionLabel.TabIndex = 0
        '
        'Register
        '
        Me.Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Register.Location = New System.Drawing.Point(97, 95)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(113, 23)
        Me.Register.TabIndex = 2
        Me.Register.Text = "Регистрация"
        Me.Register.UseVisualStyleBackColor = true
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.Back.Location = New System.Drawing.Point(3, 95)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(86, 23)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Върни се"
        Me.Back.UseVisualStyleBackColor = true
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "Username", true))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(110, 38)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox1.TabIndex = 11
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.ElectronicDiaryDatabaseDataSet
        '
        'ElectronicDiaryDatabaseDataSet
        '
        Me.ElectronicDiaryDatabaseDataSet.DataSetName = "ElectronicDiaryDatabaseDataSet"
        Me.ElectronicDiaryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "Password", true))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(110, 64)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox1.TabIndex = 12
        Me.PasswordTextBox1.UseSystemPasswordChar = true
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'AccountsBindingNavigator
        '
        Me.AccountsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AccountsBindingNavigator.BindingSource = Me.AccountsBindingSource
        Me.AccountsBindingNavigator.CountItem = Nothing
        Me.AccountsBindingNavigator.DeleteItem = Nothing
        Me.AccountsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorAddNewItem})
        Me.AccountsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccountsBindingNavigator.MoveFirstItem = Nothing
        Me.AccountsBindingNavigator.MoveLastItem = Nothing
        Me.AccountsBindingNavigator.MoveNextItem = Nothing
        Me.AccountsBindingNavigator.MovePreviousItem = Nothing
        Me.AccountsBindingNavigator.Name = "AccountsBindingNavigator"
        Me.AccountsBindingNavigator.PositionItem = Nothing
        Me.AccountsBindingNavigator.Size = New System.Drawing.Size(220, 25)
        Me.AccountsBindingNavigator.TabIndex = 7
        Me.AccountsBindingNavigator.Text = "BindingNavigator1"
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Me.AccountsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.Message_Log_To_ParentsTableAdapter = Nothing
        Me.TableAdapterManager.Message_Log_To_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DataTableAdapter = Nothing
        Me.TableAdapterManager.SubjectsTableAdapter = Nothing
        Me.TableAdapterManager.Summary_LogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegisterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 128)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PasswordTextBox1)
        Me.Controls.Add(Me.UsernameTextBox1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.AccountsBindingNavigator)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(PositionLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegisterUser"
        Me.Text = "Регистрация"
        CType(Me.AccountsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ElectronicDiaryDatabaseDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.AccountsBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.AccountsBindingNavigator.ResumeLayout(false)
        Me.AccountsBindingNavigator.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents AccountsTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccountsBindingNavigator As System.Windows.Forms.BindingNavigator

End Class
