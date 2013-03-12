<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.registration = New System.Windows.Forms.Button()
        Me.ElectronicDiaryDatabaseDataSet = New diary.ElectronicDiaryDatabaseDataSet()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsTableAdapter = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.AccountsTableAdapter()
        Me.TableAdapterManager = New diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ПървоПроверетеЗаНоваВерсияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПровериToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutomaticUpdater1 = New wyDay.Controls.AutomaticUpdater()
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AutomaticUpdater1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(33, 116)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(75, 23)
        Me.buttonLogin.TabIndex = 0
        Me.buttonLogin.Text = "Влез"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Location = New System.Drawing.Point(41, 93)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(45, 13)
        Me.labelPassword.TabIndex = 1
        Me.labelPassword.Text = "Парола"
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Location = New System.Drawing.Point(41, 67)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(67, 13)
        Me.labelUsername.TabIndex = 2
        Me.labelUsername.Text = "Потребител"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(114, 64)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(100, 20)
        Me.username.TabIndex = 3
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(114, 90)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(100, 20)
        Me.password.TabIndex = 4
        Me.password.UseSystemPasswordChar = True
        '
        'registration
        '
        Me.registration.Location = New System.Drawing.Point(126, 116)
        Me.registration.Name = "registration"
        Me.registration.Size = New System.Drawing.Size(83, 23)
        Me.registration.TabIndex = 5
        Me.registration.Text = "Регистрация"
        Me.registration.UseVisualStyleBackColor = True
        '
        'ElectronicDiaryDatabaseDataSet
        '
        Me.ElectronicDiaryDatabaseDataSet.DataSetName = "ElectronicDiaryDatabaseDataSet"
        Me.ElectronicDiaryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.ElectronicDiaryDatabaseDataSet
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Me.AccountsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Message_Log_To_ParentsTableAdapter = Nothing
        Me.TableAdapterManager.Message_Log_To_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Student_DataTableAdapter = Nothing
        Me.TableAdapterManager.SubjectsTableAdapter = Nothing
        Me.TableAdapterManager.Summary_LogTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПървоПроверетеЗаНоваВерсияToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(252, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ПървоПроверетеЗаНоваВерсияToolStripMenuItem
        '
        Me.ПървоПроверетеЗаНоваВерсияToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПровериToolStripMenuItem})
        Me.ПървоПроверетеЗаНоваВерсияToolStripMenuItem.Name = "ПървоПроверетеЗаНоваВерсияToolStripMenuItem"
        Me.ПървоПроверетеЗаНоваВерсияToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.ПървоПроверетеЗаНоваВерсияToolStripMenuItem.Text = "Моля, първо обновете"
        '
        'ПровериToolStripMenuItem
        '
        Me.ПровериToolStripMenuItem.Name = "ПровериToolStripMenuItem"
        Me.ПровериToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ПровериToolStripMenuItem.Text = "Обнови"
        '
        'AutomaticUpdater1
        '
        Me.AutomaticUpdater1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutomaticUpdater1.ContainerForm = Me
        Me.AutomaticUpdater1.GUID = "c2088147-6b2b-43df-91b6-250e56260cbc"
        Me.AutomaticUpdater1.Location = New System.Drawing.Point(224, 38)
        Me.AutomaticUpdater1.Name = "AutomaticUpdater1"
        Me.AutomaticUpdater1.Size = New System.Drawing.Size(16, 16)
        Me.AutomaticUpdater1.TabIndex = 7
        Me.AutomaticUpdater1.ToolStripItem = Me.ПровериToolStripMenuItem
        Me.AutomaticUpdater1.wyUpdateCommandline = Nothing
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 146)
        Me.Controls.Add(Me.AutomaticUpdater1)
        Me.Controls.Add(Me.registration)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "login"
        Me.Text = "Система"
        CType(Me.ElectronicDiaryDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AutomaticUpdater1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonLogin As System.Windows.Forms.Button
    Friend WithEvents labelPassword As System.Windows.Forms.Label
    Friend WithEvents labelUsername As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents registration As System.Windows.Forms.Button
    Friend WithEvents ElectronicDiaryDatabaseDataSet As diary.ElectronicDiaryDatabaseDataSet
    Friend WithEvents AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountsTableAdapter As diary.ElectronicDiaryDatabaseDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents TableAdapterManager As diary.ElectronicDiaryDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ПървоПроверетеЗаНоваВерсияToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПровериToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutomaticUpdater1 As wyDay.Controls.AutomaticUpdater
End Class
