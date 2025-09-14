Public Class Drug_Detail
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

    Private Sub Drug_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.DrugReq_Details' table. You can move, or remove it, as needed.
        Me.DrugReq_DetailsTableAdapter.Fill(Me.DatabaseG26DataSet2.DrugReq_Details)

    End Sub

    Private Sub Parma_LU_Click(sender As Object, e As EventArgs) Handles Parma_LU.Click
        Phamarcetical_Lookup.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DrugReqLookup.Show()
    End Sub
End Class