Public Class Ward_shift
    Private Sub Ward_Shift_RotasBindingNavigatorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ward_Shift_RotasBindingNavigator.Click
        Me.Validate()
        Me.Ward_Shift_RotasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub
    Private Sub S_LU_Click(sender As Object, e As EventArgs) Handles S_LU.Click
        Staff_LookUp.Show()
    End Sub

    Private Sub W_LU_Click(sender As Object, e As EventArgs) Handles W_LU.Click
        Ward_LookUp.Show()
    End Sub

    Private Sub SH_LU_Click(sender As Object, e As EventArgs) Handles SH_LU.Click
        ShiftID_LookUp.Show()
    End Sub

    Private Sub Ward_Shift_RotasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ward_Shift_RotasBindingNavigator.Click
        Me.Validate()
        Me.Ward_Shift_RotasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Ward_shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Ward_Shift_Rotas' table. You can move, or remove it, as needed.
        Me.Ward_Shift_RotasTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Ward_Shift_Rotas)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Ward_Shift_RotasTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Ward_Shift_Rotas, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Ward_Shift_RotasTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Ward_Shift_Rotas, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class