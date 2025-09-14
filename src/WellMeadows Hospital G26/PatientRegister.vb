Imports System.Data.SqlClient

Public Class PatientRegister
    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub PatientRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet7.GetNextPNum' table. You can move, or remove it, as needed.
        Me.GetNextPNumTableAdapter.Fill(Me.DatabaseG26DataSet7.GetNextPNum)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet5.GetNextAddressID' table. You can move, or remove it, as needed.
        Me.GetNextAddressIDTableAdapter.Fill(Me.DatabaseG26DataSet5.GetNextAddressID)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin' table. You can move, or remove it, as needed.
        Me.Patients_NextOfKinTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients_NextOfKin)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Addresses' table. You can move, or remove it, as needed.
        'Me.AddressesTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients' table. You can move, or remove it, as needed.
        'Me.PatientsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients)

    End Sub
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
    Private Function GetNextPNum() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextPNum As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("GetNextPNum", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextPNum = reader("NextPNum").ToString()
                End If
            End Using
        End Using

        Return nextPNum
    End Function

    Private Sub SaveData()
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim newPNum As String = GetNextPNum()
        Dim enteredAddressID As String = Address_IDTextBox1.Text  'ใช้ค่าจาก TextBox โดยตรง

        ' ตั้งค่า TextBox ของ Address_ID และ P_Num
        NextPNumTextBox.Text = newPNum
        Address_IDTextBox.Text = enteredAddressID

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Check if Address_ID exists in Patients
            Dim addressCheckCommand As New SqlCommand("SELECT COUNT(*) FROM Patients WHERE Address_ID = @Address_ID", connection)
            addressCheckCommand.Parameters.AddWithValue("@Address_ID", enteredAddressID)
            Dim addressExists As Integer = Convert.ToInt32(addressCheckCommand.ExecuteScalar())

            If addressExists = 0 Then
                ' Insert into Addresses only if Address_ID does not exist in Patients
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

            ' Insert into Patients
            Dim patientSql As String = "INSERT INTO Patients (P_Num, P_ID, First_Name, Last_Name, PhoneNum, Date_Of_Birth, Sex, Marital_Status, Date_Registered, Address_ID, doctorID) VALUES (@P_Num, @P_ID, @First_Name, @Last_Name, @PhoneNum, @Date_Of_Birth, @Sex, @Marital_Status, @Date_Registered, @Address_ID, @doctorID)"
            Dim patientCommand As New SqlCommand(patientSql, connection)
            patientCommand.Parameters.AddWithValue("@P_Num", newPNum)
            patientCommand.Parameters.AddWithValue("@P_ID", P_IDTextBox.Text)
            patientCommand.Parameters.AddWithValue("@First_Name", First_NameTextBox.Text)
            patientCommand.Parameters.AddWithValue("@Last_Name", Last_NameTextBox.Text)
            patientCommand.Parameters.AddWithValue("@PhoneNum", PhoneNumTextBox.Text)
            patientCommand.Parameters.AddWithValue("@Date_Of_Birth", Date_Of_BirthDateTimePicker.Value)
            patientCommand.Parameters.AddWithValue("@Sex", SexComboBox.Text)
            patientCommand.Parameters.AddWithValue("@Marital_Status", Marital_StatusComboBox.Text)
            patientCommand.Parameters.AddWithValue("@Date_Registered", Date_RegisteredDateTimePicker.Value)
            patientCommand.Parameters.AddWithValue("@Address_ID", enteredAddressID)
            patientCommand.Parameters.AddWithValue("@doctorID", DoctorIDTextBox.Text)

            Try
                patientCommand.ExecuteNonQuery()
                MessageBox.Show("Data saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub








    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        SaveData()
        PatientRegister2.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Address_IDTextBox.Visible = False
    End Sub

    Private Sub DOC_LU_Click(sender As Object, e As EventArgs) Handles DOC_LU.Click
        Doctor_LookUp.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Address_LookUp.Show()
    End Sub
End Class