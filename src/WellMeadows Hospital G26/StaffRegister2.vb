Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StaffRegister2
    Private Sub StaffsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub StaffRegister2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet6.GetNextSNum' table. You can move, or remove it, as needed.
        Me.GetNextSNumTableAdapter.Fill(Me.DatabaseG26DataSet6.GetNextSNum)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet5.GetNextAddressID' table. You can move, or remove it, as needed.
        Me.GetNextAddressIDTableAdapter.Fill(Me.DatabaseG26DataSet5.GetNextAddressID)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Addresses' table. You can move, or remove it, as needed.
        'Me.AddressesTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.
        'Me.StaffsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Users)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet4.GetNextUserID' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DatabaseG26DataSet5.GetNextAddressID' table. You can move, or remove it, as needed.
        'Me.GetNextAddressIDTableAdapter.Fill(Me.DatabaseG26DataSet5.GetNextAddressID)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Addresses' table. You can move, or remove it, as needed.
        'Me.AddressesTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.
        'Me.StaffsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs)

    End Sub
    Private Function HandleAddressID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim address_id As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("HandleAddressID", connection)
            command.CommandType = CommandType.StoredProcedure

            ' ตั้งค่าพารามิเตอร์ที่เกี่ยวข้อง
            command.Parameters.AddWithValue("@House_No", House_NoTextBox.Text)
            command.Parameters.AddWithValue("@Street", StreetTextBox.Text)
            command.Parameters.AddWithValue("@District", DistrictTextBox.Text)
            command.Parameters.AddWithValue("@Province", ProvinceTextBox.Text)
            command.Parameters.AddWithValue("@Postal_Code", Postal_CodeTextBox.Text)
            command.Parameters.AddWithValue("@Country", CountryTextBox.Text)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    address_id = reader("AddressID").ToString()
                End If
            End Using
        End Using

        Return address_id
    End Function
    ' ฟังก์ชันเพื่อดึง Users_ID ล่าสุด
    Private Function LoadLatestUserID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim latestUserID As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("SELECT TOP 1 Users_ID FROM Users ORDER BY Users_ID DESC", connection)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    latestUserID = reader("Users_ID").ToString()
                End If
            End Using
        End Using

        Return latestUserID
    End Function

    ' ฟังก์ชันเพื่อดึง Address_ID ถัดไป
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

    ' ฟังก์ชันเพื่อดึง S_Num ถัดไป
    Private Function GetNextSNum() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextSNum As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("GetNextSNum", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextSNum = reader("NextSNum").ToString()
                End If
            End Using
        End Using

        Return nextSNum
    End Function

    ' ฟังก์ชัน SaveData เพื่อบันทึกข้อมูลลงในตาราง
    Private Sub SaveData()
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim newAddressID As String = GetNextAddressID()
        Dim newUserID As String = LoadLatestUserID()
        Dim newSNum As String = GetNextSNum()

        ' ตั้งค่า TextBox ของ Address_ID และ Users_ID
        Users_IDTextBox.Text = newUserID
        NextSNumTextBox.Text = newSNum
        AddressIDTextBox.Text = newAddressID

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' ตรวจสอบว่า Address_ID มีอยู่ในตาราง Staffs แล้วหรือไม่
            Dim addressCheckCommand As New SqlCommand("
            SELECT COUNT(*) 
            FROM Staffs 
            WHERE Address_ID = @Address_ID", connection)
            addressCheckCommand.Parameters.AddWithValue("@Address_ID", newAddressID)

            Dim addressExists As Integer = Convert.ToInt32(addressCheckCommand.ExecuteScalar())

            ' ถ้า Address_ID ไม่อยู่ในตาราง Staffs ให้เพิ่มลงในตาราง Addresses
            If addressExists = 0 Then
                Dim addressInsertCommand As New SqlCommand("
                INSERT INTO Addresses (Address_ID, House_No, Street, District, Province, Postal_Code, Country) 
                VALUES (@Address_ID, @House_No, @Street, @District, @Province, @Postal_Code, @Country)", connection)
                addressInsertCommand.Parameters.AddWithValue("@Address_ID", newAddressID)
                addressInsertCommand.Parameters.AddWithValue("@House_No", House_NoTextBox.Text)
                addressInsertCommand.Parameters.AddWithValue("@Street", StreetTextBox.Text)
                addressInsertCommand.Parameters.AddWithValue("@District", DistrictTextBox.Text)
                addressInsertCommand.Parameters.AddWithValue("@Province", ProvinceTextBox.Text)
                addressInsertCommand.Parameters.AddWithValue("@Postal_Code", Postal_CodeTextBox.Text)
                addressInsertCommand.Parameters.AddWithValue("@Country", CountryTextBox.Text)
                addressInsertCommand.ExecuteNonQuery()
            End If

            ' คำสั่ง SQL สำหรับการบันทึกข้อมูลลงในตาราง Staffs
            Dim staffInsertCommand As New SqlCommand("
            INSERT INTO Staffs (S_Num, S_ID, First_Name, Last_Name, Date_of_Birth, Sex, Position, PhoneNum, CurrentSalary, SalaryScale, Address_ID, Users_ID) 
            VALUES (@S_Num, @S_ID, @First_Name, @Last_Name, @Date_of_Birth, @Sex, @Position, @PhoneNum, @CurrentSalary, @SalaryScale, @Address_ID, @Users_ID)", connection)

            staffInsertCommand.Parameters.AddWithValue("@S_Num", newSNum)
            staffInsertCommand.Parameters.AddWithValue("@S_ID", S_IDTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@First_Name", First_NameTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@Last_Name", Last_NameTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@Date_of_Birth", Date_of_BirthDateTimePicker.Value)
            staffInsertCommand.Parameters.AddWithValue("@Sex", SexTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@Position", PositionTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@PhoneNum", PhoneNumTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@CurrentSalary", Decimal.Parse(CurrentSalaryTextBox.Text))
            staffInsertCommand.Parameters.AddWithValue("@SalaryScale", SalaryScaleTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@Address_ID", Address_IDTextBox.Text)
            staffInsertCommand.Parameters.AddWithValue("@Users_ID", newUserID)

            Try
                staffInsertCommand.ExecuteNonQuery()
                MessageBox.Show("Data saved successfully!")
                ' Show StaffRegister3 form if data is saved successfully
                Dim staffRegister3 As New StaffRegister3()
                staffRegister3.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        SaveData()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextSNumTextBox.ReadOnly = True

        Users_IDTextBox.Text = LoadLatestUserID()
        Users_IDTextBox.Visible = False
    End Sub

    Private Sub BEd_LU_Click(sender As Object, e As EventArgs) Handles BEd_LU.Click
        Address_LookUp.Show()
    End Sub


End Class


'INSERT INTO Addresses (Address_ID, House_No, Street, District, Province, Postal_Code, Country) 
'        VALUES (@Address_ID, @House_No, @Street, @District, @Province, @Postal_Code, @Country); 