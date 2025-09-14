Public Class EmployeeContract
    Private Sub Employment_ContractsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Employment_ContractsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Employment_ContractsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub EmployeeContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Employment_Contracts' table. You can move, or remove it, as needed.
        Me.Employment_ContractsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Employment_Contracts)

    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Staff_LookUp.Show()
    End Sub
End Class