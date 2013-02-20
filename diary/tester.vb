Public Class tester

    Private Sub Parrent_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Parrent_DataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Parrent_DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ElectronicDiaryDatabaseDataSet)

    End Sub

    Private Sub tester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicDiaryDatabaseDataSet.Parrent_Data' table. You can move, or remove it, as needed.
        Me.Parrent_DataTableAdapter.Fill(Me.ElectronicDiaryDatabaseDataSet.Parrent_Data)

    End Sub
End Class