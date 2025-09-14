Public Class Staff_Allocation_Report
    Private Sub Staff_Allocation_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staff_Allocation_View' table. You can move, or remove it, as needed.
        Me.Staff_Allocation_ViewTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staff_Allocation_View)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Staff_Allocation_View' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class