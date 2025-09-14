Public Class Staff_Details
    Private Sub Staff_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.StaffDetails' table. You can move, or remove it, as needed.
        Me.StaffDetailsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.StaffDetails)
        'TODO: This line of code loads data into the 'DataSetStaffDetail.StaffDetails' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class