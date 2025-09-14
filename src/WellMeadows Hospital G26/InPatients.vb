Public Class InPatients
    Private Sub InpatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InpatientsBindingNavigatorSaveItem.Click, InpatientsBindingNavigatorSaveItem.Click, InpatientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InpatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet)

    End Sub

    Private Sub InPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Inpatients' table. You can move, or remove it, as needed.
        Me.InpatientsTableAdapter.Fill(Me.DatabaseG26DataSet.Inpatients)

    End Sub

    Private Sub Add_LU_Click(sender As Object, e As EventArgs) Handles Add_LU.Click
        Patient_Ward_Allocation_LookUp.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patient_Lookup.Show()
    End Sub
End Class