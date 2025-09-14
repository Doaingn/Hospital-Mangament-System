Public Class AllocationBed

    Private Sub AllocationBed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.BedAllocations' table. You can move, or remove it, as needed.
        Me.BedAllocationsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.BedAllocations)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.BedAllocations' table. You can move, or remove it, as needed.
    End Sub

    Private Sub BEd_LU_Click(sender As Object, e As EventArgs) Handles BEd_LU.Click
        Bed_lookup.Show()
    End Sub

    Private Sub BedAllocationsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles BedAllocationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BedAllocationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub
End Class