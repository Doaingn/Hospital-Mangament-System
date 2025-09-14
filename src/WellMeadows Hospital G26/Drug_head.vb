Public Class Drug_head
    Private Sub DrugRequisitionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DrugRequisitionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet2)

    End Sub

    Private Sub DrugRequisitionBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DrugRequisitionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DrugRequisitionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet2)

    End Sub

    Private Sub Drug_head_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.DrugReq_Details' table. You can move, or remove it, as needed.
        Me.DrugReq_DetailsTableAdapter.Fill(Me.DatabaseG26DataSet2.DrugReq_Details)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.DrugRequisition' table. You can move, or remove it, as needed.
        Me.DrugRequisitionTableAdapter.Fill(Me.DatabaseG26DataSet2.DrugRequisition)

    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Clinic_LookUp.Show()
    End Sub

    Private Sub W_LU_Click(sender As Object, e As EventArgs) Handles W_LU.Click
        Ward_LookUp.Show()
    End Sub

    Private Sub DrugReq_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DrugReq_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet2)

    End Sub

    Private Sub DrugReq_DetailsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DrugReq_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DrugReq_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Phamarcetical_Lookup.Show()
    End Sub
End Class