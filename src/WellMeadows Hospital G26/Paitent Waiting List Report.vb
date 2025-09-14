Public Class Paitent_Waiting_List_Report
    Private Sub Paitent_Waiting_List_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients_Waiting_For_Beds' table. You can move, or remove it, as needed.
        Me.Patients_Waiting_For_BedsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_Waiting_For_Beds)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Patients_Waiting_For_Beds' table. You can move, or remove it, as needed.
        'Me.Patients_Waiting_For_BedsTableAdapter.Fill(Me.DatabaseG26DataSetView.Patients_Waiting_For_Beds)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class