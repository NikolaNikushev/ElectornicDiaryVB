Public Class Test

    Private Sub Parrent_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Parrent_DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ElectronicDiaryDatabaseDataSet)

    End Sub


End Class