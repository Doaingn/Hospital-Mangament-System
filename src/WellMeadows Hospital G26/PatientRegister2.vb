Imports System.Data.SqlClient

Public Class PatientRegister2
    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub PatientRegister2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet8.GetLatestPNum' table. You can move, or remove it, as needed.
        Me.GetLatestPNumTableAdapter.Fill(Me.DatabaseG26DataSet8.GetLatestPNum)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet7.GetNextPNum' table. You can move, or remove it, as needed.
        Me.GetNextPNumTableAdapter.Fill(Me.DatabaseG26DataSet7.GetNextPNum)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet5.GetNextAddressID' table. You can move, or remove it, as needed.
        Me.GetNextAddressIDTableAdapter.Fill(Me.DatabaseG26DataSet5.GetNextAddressID)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin' table. You can move, or remove it, as needed.
        'Me.Patients_NextOfKinTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Addresses' table. You can move, or remove it, as needed.
        'Me.AddressesTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients' table. You can move, or remove it, as needed.
        'Me.PatientsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients)

    End Sub
    Private Function GetLatestPNum() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim latestPNum As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT TOP 1 P_Num FROM Patients ORDER BY P_Num DESC", connection)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    latestPNum = reader("P_Num").ToString()
                End If
            End Using
        End Using
        Return latestPNum
    End Function

    Private Function GetNextAddressID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextAddressID As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("GetNextAddressID", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextAddressID = reader("NextAddressID").ToString()
                End If
            End Using
        End Using

        Return nextAddressID
    End Function
    Private Sub SaveData()
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim latestPNum As String = GetLatestPNum()
        Dim enteredAddressID As String = AddressIDTextBox1.Text  ' ใช้ Address_ID จาก TextBox โดยตรง

        ' ตั้งค่า TextBox ของ Address_ID และ P_Num
        P_NumTextBox.Text = latestPNum

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Check if Address_ID exists in Patients_NextOfKin
            Dim addressCheckCommand As New SqlCommand("SELECT COUNT(*) FROM Patients_NextOfKin WHERE Address_ID = @Address_ID", connection)
            addressCheckCommand.Parameters.AddWithValue("@Address_ID", enteredAddressID)
            Dim addressExists As Integer = Convert.ToInt32(addressCheckCommand.ExecuteScalar())

            If addressExists = 0 Then
                ' Insert into Addresses only if Address_ID does not exist in Patients_NextOfKin
                Dim addressSql As String = "INSERT INTO Addresses (Address_ID, House_No, Street, District, Province, Postal_Code, Country) VALUES (@Address_ID, @House_No, @Street, @District, @Province, @Postal_Code, @Country)"
                Dim addressCommand As New SqlCommand(addressSql, connection)
                addressCommand.Parameters.AddWithValue("@Address_ID", enteredAddressID)
                addressCommand.Parameters.AddWithValue("@House_No", House_NoTextBox.Text)
                addressCommand.Parameters.AddWithValue("@Street", StreetTextBox.Text)
                addressCommand.Parameters.AddWithValue("@District", DistrictTextBox.Text)
                addressCommand.Parameters.AddWithValue("@Province", ProvinceTextBox.Text)
                addressCommand.Parameters.AddWithValue("@Postal_Code", Postal_CodeTextBox.Text)
                addressCommand.Parameters.AddWithValue("@Country", CountryTextBox.Text)
                addressCommand.ExecuteNonQuery()
            End If

            ' Insert into Patients_NextOfKin
            Dim patientNextOfKinSql As String = "INSERT INTO Patients_NextOfKin (P_Num, First_Name, Last_Name, PhoneNum, Relationship, Address_ID) VALUES (@P_Num, @First_Name, @Last_Name, @PhoneNum, @Relationship, @Address_ID)"
            Dim patientNextOfKinCommand As New SqlCommand(patientNextOfKinSql, connection)
            patientNextOfKinCommand.Parameters.AddWithValue("@P_Num", latestPNum)
            patientNextOfKinCommand.Parameters.AddWithValue("@First_Name", First_NameTextBox.Text)
            patientNextOfKinCommand.Parameters.AddWithValue("@Last_Name", Last_NameTextBox.Text)
            patientNextOfKinCommand.Parameters.AddWithValue("@PhoneNum", PhoneNumTextBox.Text)
            patientNextOfKinCommand.Parameters.AddWithValue("@Relationship", RelationshipComboBox.Text)
            patientNextOfKinCommand.Parameters.AddWithValue("@Address_ID", enteredAddressID)  ' ใช้ค่าจาก AddressIDTextBox1 โดยตรง ไม่มี auto-increment 

            Try
                patientNextOfKinCommand.ExecuteNonQuery()
                MessageBox.Show("Registration completed!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        SaveData()
        Me.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextAddressIDTextBox.Hide()
        P_NumTextBox.Hide()
    End Sub

    Private Sub BEd_LU_Click(sender As Object, e As EventArgs) Handles BEd_LU.Click
        Address_LookUp.Show()
    End Sub
End Class