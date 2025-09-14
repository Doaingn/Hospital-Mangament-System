Public Class Clinic_LookUp


    Private Sub Clinic_LookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Outpatient_Clinics' table. You can move, or remove it, as needed.
        Me.Outpatient_ClinicsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Outpatient_Clinics)
    End Sub

    Private Sub Outpatient_ClinicsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Outpatient_ClinicsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Outpatient_ClinicsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Outpatient_Clinics, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Outpatient_ClinicsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Outpatient_Clinics, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class