Public Class Patient_Details
    Private Sub Patient_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.PatientDetails' table. You can move, or remove it, as needed.
        Me.PatientDetailsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.PatientDetails)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.PatientDetails' table. You can move, or remove it, as needed.


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class