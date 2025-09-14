Public Class Appointment
    Private Sub BindingNavigator1SaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigator1.Click
        Me.Validate()
        Me.AppointmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)
    End Sub
    Private Sub S_LU_Click(sender As Object, e As EventArgs) Handles S_LU.Click
        Staff_LookUp.Show()
    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Clinic_LookUp.Show()
    End Sub

    Private Sub P_LU_Click(sender As Object, e As EventArgs) Handles P_LU.Click
        Patient_Lookup.Show()
    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Appointments)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.AppointmentsTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Appointments, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.AppointmentsTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Appointments, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class