Public Class Shift
    Private Sub ShiftsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ShiftsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShiftsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Shifts' table. You can move, or remove it, as needed.
        Me.ShiftsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Shifts)

    End Sub
End Class