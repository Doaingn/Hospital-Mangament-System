Public Class DrugReport
    Private Sub DrugReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Drug_Requisition_View' table. You can move, or remove it, as needed.
        Me.Drug_Requisition_ViewTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Drug_Requisition_View)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Drug_Requisition_View' table. You can move, or remove it, as needed.
        'Me.Drug_Requisition_ViewTableAdapter.Fill(Me.DatabaseG26DataSetView.Drug_Requisition_View)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SHeadLB_Click(sender As Object, e As EventArgs) Handles SHeadLB.Click

    End Sub
End Class