Public Class SurgicalReqReport
    Private Sub SurgicalReqReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Surgical_Requisition_View' table. You can move, or remove it, as needed.
        Me.Surgical_Requisition_ViewTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Surgical_Requisition_View)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Surgical_Requisition_View' table. You can move, or remove it, as needed.
        'Me.Surgical_Requisition_ViewTableAdapter.Fill(Me.DatabaseG26DataSetView.Surgical_Requisition_View)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Surgical_Requisition_View' table. You can move, or remove it, as needed.
        'Me.Surgical_Requisition_ViewTableAdapter.Fill(Me.DatabaseG26DataSetView.Surgical_Requisition_View)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub
End Class