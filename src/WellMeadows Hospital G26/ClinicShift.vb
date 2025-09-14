Public Class ClinicShift

    Private Sub ClinicShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas' table. You can move, or remove it, as needed.
        Me.Clinic_Shift_RotasTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Clinic_Shift_Rotas' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Clinic_LookUp.Show()
    End Sub

    Private Sub SH_LU_Click(sender As Object, e As EventArgs) Handles SH_LU.Click
        ShiftID_LookUp.Show()
    End Sub

    Private Sub SHeadLB_Click(sender As Object, e As EventArgs) Handles SHeadLB.Click

    End Sub

    Private Sub St_LU_Click(sender As Object, e As EventArgs) Handles St_LU.Click
        Staff_LookUp.Show()
    End Sub

    Private Sub Clinic_Shift_RotasBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Clinic_Shift_RotasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Clinic_Shift_RotasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Clinic_Shift_RotasTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Clinic_Shift_RotasTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class