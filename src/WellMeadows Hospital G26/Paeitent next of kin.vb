Imports Microsoft.Reporting.Map.WebForms.BingMaps

Public Class Patient_next_of_kin
    Private Sub Patients_NextOfKinBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Patients_NextOfKinBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Patient_next_of_kin_Load(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin' table. You can move, or remove it, as needed.
        Me.Patients_NextOfKinTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin)

    End Sub

    Private Sub Patients_NextOfKinBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Patients_NextOfKinBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patients_NextOfKinBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Patient_next_of_kin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin' table. You can move, or remove it, as needed.
        Me.Patients_NextOfKinTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patient_Lookup.Show()
    End Sub

    Private Sub DOC_LU_Click(sender As Object, e As EventArgs) Handles DOC_LU.Click
        Address_LookUp.Show()
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Patients_NextOfKinTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox1.TextChanged
        Try
            Me.Patients_NextOfKinTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Address_Click(sender As Object, e As EventArgs) Handles Address.Click
        AddressP.Show()
    End Sub
End Class