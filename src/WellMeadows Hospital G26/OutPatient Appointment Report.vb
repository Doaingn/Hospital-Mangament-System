Public Class OutPatient_Appointment_Report
    Private Sub OutPatient_Appointment_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Outpatient_Appointments_View' table. You can move, or remove it, as needed.
        Me.Outpatient_Appointments_ViewTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Outpatient_Appointments_View)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Outpatient_Appointments_View' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class