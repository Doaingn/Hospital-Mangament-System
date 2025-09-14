Public Class Patient_Appointment_Report
    Private Sub Patient_Appointment_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.PatientAppointments' table. You can move, or remove it, as needed.
        Me.PatientAppointmentsTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.PatientAppointments)
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.PatientAppointments' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class