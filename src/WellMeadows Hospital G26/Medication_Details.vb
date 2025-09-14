Public Class Medication_Details

    Private Sub Medication_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Medication_DetailsBindingNavigatorSaveItem.Click
        Dim existingRows = Me.DatabaseG26DataSetReq_Details.Medication_Details.Select("medication_no = 'MDH006' AND order_no = 5")
        Me.Validate()
        Me.Medication_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSetReq_Details)
    End Sub


    Private Sub Medication_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSetReq_Details.Medication_Details' table. You can move, or remove it, as needed.
        Me.Medication_DetailsTableAdapter.Fill(Me.DatabaseG26DataSetReq_Details.Medication_Details)

    End Sub

    Private Sub Pharma_LU_Click(sender As Object, e As EventArgs) Handles Pharma_LU.Click
        Phamarcetical_Lookup.Show()
    End Sub
End Class