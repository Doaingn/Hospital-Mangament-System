Public Class InPatientDetail
    Private Sub InPatientDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.InpatientDetails' table. You can move, or remove it, as needed.
        Me.InpatientDetailsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.InpatientDetails)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.SurgicalReq_Details' table. You can move, or remove it, as needed.        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.InpatientDetails' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class