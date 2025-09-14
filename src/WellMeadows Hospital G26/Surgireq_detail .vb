Public Class Surgireq_detail
    Private Sub SurgicalReq_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SurgicalReq_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SurgicalReq_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSetReq_Details)

    End Sub

    Private Sub Surgireq_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSetReq_Details.SurgicalReq_Details' table. You can move, or remove it, as needed.
        Me.SurgicalReq_DetailsTableAdapter.Fill(Me.DatabaseG26DataSetReq_Details.SurgicalReq_Details)

    End Sub

    Private Sub Parma_LU_Click(sender As Object, e As EventArgs) Handles Parma_LU.Click
        Phamarcetical_Lookup.Show()
    End Sub

    Private Sub SRbtn_Click(sender As Object, e As EventArgs) Handles SRbtn.Click
        SurgicalIDLookup.Show()
    End Sub
End Class