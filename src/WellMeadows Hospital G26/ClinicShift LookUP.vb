Public Class Shift_LookUP
    Private Sub Clinic_Shift_RotasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Clinic_Shift_RotasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Shift_LookUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas' table. You can move, or remove it, as needed.
        Me.Clinic_Shift_RotasTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Clinic_Shift_RotasTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Clinic_Shift_RotasTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Clinic_Shift_Rotas, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class