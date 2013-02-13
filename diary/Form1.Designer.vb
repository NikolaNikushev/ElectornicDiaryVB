<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Parent_IDLabel As System.Windows.Forms.Label
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.Parrent_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Parrent_DataTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.Parrent_DataTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Parrent_DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Parrent_DataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Parent_IDTextBox = New System.Windows.Forms.TextBox()
        Parent_IDLabel = New System.Windows.Forms.Label()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parrent_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parrent_DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Parrent_DataBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElectronicDiaryDatabaseDataSet
        '
        Me.ElectronicDiaryDatabaseDataSet.DataSetName = "ElectronicDiaryDatabaseDataSet"
        Me.ElectronicDiaryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Parrent_DataBindingSource
        '
        Me.Parrent_DataBindingSource.DataMember = "Parrent Data"
        Me.Parrent_DataBindingSource.DataSource = Me.ElectronicDiaryDatabaseDataSet
        '
        'Parrent_DataTableAdapter
        '
        Me.Parrent_DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Parrent_DataTableAdapter = Me.Parrent_DataTableAdapter
        Me.TableAdapterManager.Personal_Doctor_DataTableAdapter = Nothing
        Me.TableAdapterManager.Student_DataTableAdapter = Nothing
        Me.TableAdapterManager.SubjectsTableAdapter = Nothing
        Me.TableAdapterManager.Teacher_DataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Parrent_DataBindingNavigator
        '
        Me.Parrent_DataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Parrent_DataBindingNavigator.BindingSource = Me.Parrent_DataBindingSource
        Me.Parrent_DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Parrent_DataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Parrent_DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Parrent_DataBindingNavigatorSaveItem})
        Me.Parrent_DataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Parrent_DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Parrent_DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Parrent_DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Parrent_DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Parrent_DataBindingNavigator.Name = "Parrent_DataBindingNavigator"
        Me.Parrent_DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Parrent_DataBindingNavigator.Size = New System.Drawing.Size(321, 25)
        Me.Parrent_DataBindingNavigator.TabIndex = 0
        Me.Parrent_DataBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Parrent_DataBindingNavigatorSaveItem
        '
        Me.Parrent_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Parrent_DataBindingNavigatorSaveItem.Image = CType(resources.GetObject("Parrent_DataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Parrent_DataBindingNavigatorSaveItem.Name = "Parrent_DataBindingNavigatorSaveItem"
        Me.Parrent_DataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Parrent_DataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Parent_IDLabel
        '
        Parent_IDLabel.AutoSize = True
        Parent_IDLabel.Location = New System.Drawing.Point(140, 66)
        Parent_IDLabel.Name = "Parent_IDLabel"
        Parent_IDLabel.Size = New System.Drawing.Size(55, 13)
        Parent_IDLabel.TabIndex = 1
        Parent_IDLabel.Text = "Parent ID:"
        '
        'Parent_IDTextBox
        '
        Me.Parent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Parrent_DataBindingSource, "Parent ID", True))
        Me.Parent_IDTextBox.Location = New System.Drawing.Point(201, 63)
        Me.Parent_IDTextBox.Name = "Parent_IDTextBox"
        Me.Parent_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Parent_IDTextBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 261)
        Me.Controls.Add(Parent_IDLabel)
        Me.Controls.Add(Me.Parent_IDTextBox)
        Me.Controls.Add(Me.Parrent_DataBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parrent_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parrent_DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Parrent_DataBindingNavigator.ResumeLayout(False)
        Me.Parrent_DataBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents Parrent_DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parrent_DataTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.Parrent_DataTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Parrent_DataBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Parrent_DataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Parent_IDTextBox As System.Windows.Forms.TextBox
End Class
