Public Class Bed
    ' Private WithEvents BedsBindingNavigatorSaveItem As ToolStripButton

    Private Sub BedsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BedsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BedsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet)
    End Sub

    Private Sub Bed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Beds' table. You can move, or remove it, as needed.
        Me.BedsTableAdapter.Fill(Me.DatabaseG26DataSet.Beds)
    End Sub
End Class