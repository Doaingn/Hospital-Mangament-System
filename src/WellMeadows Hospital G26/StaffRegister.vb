Imports System.Data.SqlClient

Public Class StaffRegister
    Private Sub StaffsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub StaffRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet4.GetNextUserID' table. You can move, or remove it, as needed.
        Me.GetNextUserIDTableAdapter.Fill(Me.DatabaseG26DataSet4.GetNextUserID)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Addresses' table. You can move, or remove it, as needed.
        'Me.AddressesTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Users)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.
        'Me.StaffsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs)

    End Sub

    Private Function GetNextUserID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextUserID As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("GetNextUserID", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextUserID = reader("NextUserID").ToString()
                End If
            End Using
        End Using

        Return nextUserID
    End Function

    Private Sub SaveData()
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim newUserID As String = GetNextUserID()
        Users_IDTextBox.Text = newUserID

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("INSERT INTO Users (Users_ID, username, password) VALUES (@Users_ID, @username, @password);", connection)

            ' กำหนดพารามิเตอร์ของ Users
            command.Parameters.AddWithValue("@Users_ID", newUserID)
            command.Parameters.AddWithValue("@username", UsernameTextBox.Text)
            command.Parameters.AddWithValue("@password", PasswordTextBox.Text)
            Try
                command.ExecuteNonQuery()
                StaffRegister2.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        SaveData()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Users_IDTextBox.Visible = False
    End Sub

End Class
