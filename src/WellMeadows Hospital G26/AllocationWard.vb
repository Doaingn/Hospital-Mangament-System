Imports System.Data.SqlClient

Public Class AllocationWard
    Private Sub Ward_AllocationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ward_AllocationsBindingNavigator.Click
        Me.Validate()
        Me.Ward_AllocationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)
    End Sub
    Private Sub AllocationWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Ward_Allocations' table. You can move, or remove it, as needed.
        Me.Ward_AllocationsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Ward_Allocations)

    End Sub


    Private Sub P_LU_Click(sender As Object, e As EventArgs) Handles P_LU.Click
        Patient_Lookup.Show()
    End Sub

    Private Sub BA_LU_Click(sender As Object, e As EventArgs) Handles BA_LU.Click
        Bed_Allocation_LookUP.Show()
    End Sub

    Private Sub W_LU_Click_1(sender As Object, e As EventArgs) Handles W_LU.Click
        Ward_LookUp.Show()

    End Sub

    Private Sub Ward_AllocationsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Ward_AllocationsBindingNavigatorSaveItem.Click
        ' Validate and save current data in the current dataset
        Me.Validate()
        Me.Ward_AllocationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

        ' Call the function to insert the Allocation_ID and P_Num into Inpatients table
        InsertIntoInpatients(Allocation_idTextBox.Text, P_NumTextBox.Text)
    End Sub

    Private Sub InsertIntoInpatients(allocationID As String, pNum As String)
        ' Define the connection string (adjust according to your setup)
        Dim connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True"

        ' Define the SQL query to insert data into Inpatients table
        Dim query As String = "INSERT INTO Inpatients (Allocation_ID, P_Num) VALUES (@AllocationID, @PNum)"

        ' Create a new SQL connection and command
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@AllocationID", allocationID)
                command.Parameters.AddWithValue("@PNum", pNum)

                ' Open the connection
                connection.Open()

                ' Execute the query
                Try
                    command.ExecuteNonQuery()

                Catch ex As Exception

                End Try
            End Using
        End Using
    End Sub

    Private Sub WaitingListDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles WaitingListDateDateTimePicker.ValueChanged

    End Sub
End Class