Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters

Public Class MainMenu
    ' - แสดงตำนวน Staff
    Private Sub Staff_Count(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"

        Dim query As String = "SELECT COUNT(S_Num) FROM Staffs"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim sNumCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            lblSNumCount.Text = sNumCount.ToString()
        End Using
    End Sub

    '-แสดงจำนวน Patient
    Private Sub Patient_Count(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim query As String = "SELECT COUNT(P_NUM) FROM Patients"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim pNumCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            lblPNumCount.Text = pNumCount.ToString()
        End Using
    End Sub

    'แสดงตำนวน In-Patient
    Private Sub In_Patient_Count(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim query As String = "SELECT COUNT(P_NUM) FROM InPatients"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim pNumCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            lblINPNumCount.Text = pNumCount.ToString() & ""
        End Using
    End Sub

    Public Property LoggedInUsers As String
    'แสดงชื่อ user ซ้ายบน
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = "Welcome, " & LoggedInUsers
        SetAccessControl()
    End Sub

    'กำหนดสิทธิ์การเข้าถึง
    Private Sub SetAccessControl()
        If LoggedInUsers.Contains("MedicDi") Then
            Staffbtn.Enabled = False
            PatientMedicationFormBtn.Enabled = False
            StaffAllocationBtn.Enabled = False
            PharmaceuticalRequisitionBtn.Enabled = False
            PharmaceuticalEquipmentRequisitionReportBtn.Enabled = False
            SurgicalEquipmentRequisitionBtn.Enabled = False
            SurgicalEquipmentRequisitionReportBtn.Enabled = False
            WardAllocationBtn.Enabled = False
            StaffDetailsBtn.Enabled = False
            PatientMedicationReportBtn.Enabled = False
            ClinicShiftBtn.Enabled = False
            ShiftBtn.Enabled = False
            WardShiftBtn.Enabled = False
            PatientAppointmentBtn.Enabled = False
            StaffRegisbtn.Enabled = False

        ElseIf LoggedInUsers.Contains("ChargeNurse") Then
            Staffbtn.Enabled = False
            Supplierbtn.Enabled = False
            StaffDetailsBtn.Enabled = False
            StaffRegisbtn.Enabled = False

        ElseIf LoggedInUsers.Contains("Nurse") Then
            PatientMedicationFormBtn.Enabled = False
            PatientMedicationReportBtn.Enabled = False
            Supplierbtn.Enabled = False
            PatientAppointmentBtn.Enabled = False
            PatientsAppointmentReportbtn.Enabled = False
            OutPatientAppointmentReportBtn.Enabled = False
            WardAllocationBtn.Enabled = False
            ClinicShiftBtn.Enabled = False
            ShiftBtn.Enabled = False
            WardShiftBtn.Enabled = False
            PharmaceuticalRequisitionBtn.Enabled = False
            PharmaceuticalEquipmentRequisitionReportBtn.Enabled = False
            SurgicalEquipmentRequisitionBtn.Enabled = False
            SurgicalEquipmentRequisitionReportBtn.Enabled = False
            StaffDetailsBtn.Enabled = False
            StaffRegisbtn.Enabled = False

        ElseIf LoggedInUsers.Contains("PersonOff") Then
            PatientMedicationFormBtn.Enabled = False
            PatientMedicationReportBtn.Enabled = False
            Supplierbtn.Enabled = False
            PatientAppointmentBtn.Enabled = False
            PatientsAppointmentReportbtn.Enabled = False
            OutPatientAppointmentReportBtn.Enabled = False
            WardAllocationBtn.Enabled = False
            ClinicShiftBtn.Enabled = False
            ShiftBtn.Enabled = False
            WardShiftBtn.Enabled = False
            PharmaceuticalRequisitionBtn.Enabled = False
            PharmaceuticalEquipmentRequisitionReportBtn.Enabled = False
            SurgicalEquipmentRequisitionBtn.Enabled = False
            SurgicalEquipmentRequisitionReportBtn.Enabled = False
        End If
    End Sub


    Private Sub PatientMedicationReportBtn_Click(sender As Object, e As EventArgs) Handles PatientMedicationReportBtn.Click
        Patient_Medicine_Report.Show()
    End Sub

    Private Sub PatientAppointmentBtn_Click(sender As Object, e As EventArgs) Handles PatientAppointmentBtn.Click
        Appointment.Show()
    End Sub

    Private Sub PatientMedicationFormBtn_Click(sender As Object, e As EventArgs) Handles PatientMedicationFormBtn.Click
        Patient_Medication_Form.Show()
    End Sub

    Private Sub InPatientDetailsBtn_Click(sender As Object, e As EventArgs) Handles InPatientDetailsBtn.Click
        InPatientDetail.Show()
    End Sub

    Private Sub PatientDetailsBtn_Click(sender As Object, e As EventArgs) Handles PatientDetailsBtn.Click
        Patient_Details.Show()
    End Sub

    Private Sub StaffDetailsBtn_Click(sender As Object, e As EventArgs) Handles StaffDetailsBtn.Click
        Staff_Details.Show()
    End Sub

    Private Sub InPatientBtn_Click(sender As Object, e As EventArgs)
        InPatients.Show()
    End Sub

    Private Sub LocalDbtn_Click(sender As Object, e As EventArgs)
        local_doctor.Show()
    End Sub

    Private Sub PatientsAppointmentReportbtn_Click(sender As Object, e As EventArgs) Handles PatientsAppointmentReportbtn.Click
        Patient_Appointment_Report.Show()
    End Sub

    Private Sub OutPatientAppointmentReportBtn_Click(sender As Object, e As EventArgs) Handles OutPatientAppointmentReportBtn.Click
        OutPatient_Appointment_Report.Show()
    End Sub

    Private Sub WardShiftBtn_Click(sender As Object, e As EventArgs) Handles WardShiftBtn.Click
        Ward_shift.Show()
    End Sub

    Private Sub ClinicShiftBtn_Click(sender As Object, e As EventArgs) Handles ClinicShiftBtn.Click
        ClinicShift.Show()
    End Sub

    Private Sub ShiftBtn_Click(sender As Object, e As EventArgs) Handles ShiftBtn.Click
        Shift.Show()
    End Sub

    Private Sub WardAllocationBtn_Click(sender As Object, e As EventArgs) Handles WardAllocationBtn.Click
        AllocationWard.Show()
    End Sub

    Private Sub ClinicAllocationBtn_Click(sender As Object, e As EventArgs)
        ClinicShift.Show()
    End Sub

    Private Sub StaffAllocationBtn_Click(sender As Object, e As EventArgs) Handles StaffAllocationBtn.Click
        Staff_Allocation_Report.Show()
    End Sub

    Private Sub PharmaceuticalRequisitionBtn_Click(sender As Object, e As EventArgs) Handles PharmaceuticalRequisitionBtn.Click
        DrugRequisitionForm.Show()
    End Sub

    Private Sub PharmaceuticalEquipmentRequisitionReportBtn_Click(sender As Object, e As EventArgs) Handles PharmaceuticalEquipmentRequisitionReportBtn.Click
        DrugReport.Show()
    End Sub

    Private Sub SurgicalEquipmentRequisitionBtn_Click(sender As Object, e As EventArgs) Handles SurgicalEquipmentRequisitionBtn.Click
        SuricalEquipmentRequisition.Show()
    End Sub

    Private Sub SurgicalEquipmentRequisitionReportBtn_Click(sender As Object, e As EventArgs) Handles SurgicalEquipmentRequisitionReportBtn.Click
        SurgicalReqReport.Show()
    End Sub

    Private Sub BedAllobtn_Click(sender As Object, e As EventArgs) Handles BedAllobtn.Click
        AllocationBed.Show()
    End Sub

    Private Sub Supplierbtn_Click(sender As Object, e As EventArgs) Handles Supplierbtn.Click
        Supplier.Show()
    End Sub

    Private Sub PatientRegisBtn_Click(sender As Object, e As EventArgs) Handles PatientBtn.Click
        Patients.Show()
    End Sub

    Private Sub Pregisbtn_Click(sender As Object, e As EventArgs) Handles Pregisbtn.Click
        PatientRegister.Show()
    End Sub

    Private Sub StaffRegisbtn_Click(sender As Object, e As EventArgs) Handles StaffRegisbtn.Click
        StaffRegister.Show()
    End Sub
    Private Sub PateWaitBtn_Click(sender As Object, e As EventArgs) Handles PateWaitBtn.Click
        Paitent_Waiting_List_Report.Show()
    End Sub

    Private Sub MainMenu_Load_1()

    End Sub

    Private Sub Pregisbtn_Click_1()

    End Sub

    Private Sub Staffbtn_Click(sender As Object, e As EventArgs) Handles Staffbtn.Click
        Staff.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        ' ยืนยันการ Logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' ทำการ Logout เช่น ปิดฟอร์มปัจจุบันและเปิดฟอร์ม Login
            Me.Close()
            log.Show()
        End If
    End Sub


End Class