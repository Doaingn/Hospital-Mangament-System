Public Class Patient_Medicine_Report
    Private Sub Patient_Medicine_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Medication_View' table. You can move, or remove it, as needed.
        Me.Medication_ViewTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_View)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class