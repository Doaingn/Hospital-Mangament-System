<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim Marital_StatusLabel As System.Windows.Forms.Label
        Dim Date_RegisteredLabel As System.Windows.Forms.Label
        Dim DoctorIDLabel As System.Windows.Forms.Label
        Dim House_NoLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim ProvinceLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Address_IDLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.House_NoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.Postal_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.NextPNumTextBox = New System.Windows.Forms.TextBox()
        Me.GetNextPNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseG26DataSet7 = New WellMeadows_Hospital_G26.DatabaseG26DataSet7()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.Marital_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Date_RegisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DoctorIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.AddressesTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter()
        Me.Patients_NextOfKinTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Patients_NextOfKinTableAdapter()
        Me.Patients_NextOfKinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseG26DataSet5 = New WellMeadows_Hospital_G26.DatabaseG26DataSet5()
        Me.GetNextAddressIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextAddressIDTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.GetNextAddressIDTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.TableAdapterManager()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.GetNextPNumTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet7TableAdapters.GetNextPNumTableAdapter()
        Me.TableAdapterManager2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet7TableAdapters.TableAdapterManager()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DOC_LU = New System.Windows.Forms.Button()
        Me.Address_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        P_NumLabel = New System.Windows.Forms.Label()
        P_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        Marital_StatusLabel = New System.Windows.Forms.Label()
        Date_RegisteredLabel = New System.Windows.Forms.Label()
        DoctorIDLabel = New System.Windows.Forms.Label()
        House_NoLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        DistrictLabel = New System.Windows.Forms.Label()
        ProvinceLabel = New System.Windows.Forms.Label()
        Postal_CodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Address_IDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.GetNextPNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patients_NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextAddressIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_NumLabel
        '
        P_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_NumLabel.AutoSize = True
        P_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_NumLabel.Location = New System.Drawing.Point(4, 7)
        P_NumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        P_NumLabel.Name = "P_NumLabel"
        P_NumLabel.Size = New System.Drawing.Size(123, 20)
        P_NumLabel.TabIndex = 0
        P_NumLabel.Text = "Patient Number:"
        '
        'P_IDLabel
        '
        P_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_IDLabel.AutoSize = True
        P_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_IDLabel.Location = New System.Drawing.Point(4, 42)
        P_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(84, 20)
        P_IDLabel.TabIndex = 2
        P_IDLabel.Text = "Patient ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        First_NameLabel.Location = New System.Drawing.Point(4, 77)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(4, 112)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PhoneNumLabel.Location = New System.Drawing.Point(4, 147)
        PhoneNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(119, 20)
        PhoneNumLabel.TabIndex = 8
        PhoneNumLabel.Text = "Phone Number:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(4, 182)
        Date_Of_BirthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(106, 20)
        Date_Of_BirthLabel.TabIndex = 10
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'SexLabel
        '
        SexLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        SexLabel.Location = New System.Drawing.Point(4, 217)
        SexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(40, 20)
        SexLabel.TabIndex = 12
        SexLabel.Text = "Sex:"
        '
        'Marital_StatusLabel
        '
        Marital_StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Marital_StatusLabel.AutoSize = True
        Marital_StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Marital_StatusLabel.Location = New System.Drawing.Point(4, 252)
        Marital_StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Marital_StatusLabel.Name = "Marital_StatusLabel"
        Marital_StatusLabel.Size = New System.Drawing.Size(111, 20)
        Marital_StatusLabel.TabIndex = 14
        Marital_StatusLabel.Text = "Marital Status:"
        '
        'Date_RegisteredLabel
        '
        Date_RegisteredLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_RegisteredLabel.AutoSize = True
        Date_RegisteredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_RegisteredLabel.Location = New System.Drawing.Point(4, 287)
        Date_RegisteredLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_RegisteredLabel.Name = "Date_RegisteredLabel"
        Date_RegisteredLabel.Size = New System.Drawing.Size(130, 20)
        Date_RegisteredLabel.TabIndex = 16
        Date_RegisteredLabel.Text = "Date Registered:"
        '
        'DoctorIDLabel
        '
        DoctorIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DoctorIDLabel.AutoSize = True
        DoctorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DoctorIDLabel.Location = New System.Drawing.Point(4, 323)
        DoctorIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DoctorIDLabel.Name = "DoctorIDLabel"
        DoctorIDLabel.Size = New System.Drawing.Size(82, 20)
        DoctorIDLabel.TabIndex = 20
        DoctorIDLabel.Text = "Doctor ID:"
        '
        'House_NoLabel
        '
        House_NoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        House_NoLabel.AutoSize = True
        House_NoLabel.Location = New System.Drawing.Point(4, 7)
        House_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        House_NoLabel.Name = "House_NoLabel"
        House_NoLabel.Size = New System.Drawing.Size(84, 20)
        House_NoLabel.TabIndex = 2
        House_NoLabel.Text = "House No:"
        '
        'StreetLabel
        '
        StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(4, 42)
        StreetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(57, 20)
        StreetLabel.TabIndex = 4
        StreetLabel.Text = "Street:"
        '
        'DistrictLabel
        '
        DistrictLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DistrictLabel.AutoSize = True
        DistrictLabel.Location = New System.Drawing.Point(4, 77)
        DistrictLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(62, 20)
        DistrictLabel.TabIndex = 6
        DistrictLabel.Text = "District:"
        '
        'ProvinceLabel
        '
        ProvinceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ProvinceLabel.AutoSize = True
        ProvinceLabel.Location = New System.Drawing.Point(4, 112)
        ProvinceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProvinceLabel.Name = "ProvinceLabel"
        ProvinceLabel.Size = New System.Drawing.Size(73, 20)
        ProvinceLabel.TabIndex = 8
        ProvinceLabel.Text = "Province:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Location = New System.Drawing.Point(4, 147)
        Postal_CodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(99, 20)
        Postal_CodeLabel.TabIndex = 10
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(4, 182)
        CountryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(68, 20)
        CountryLabel.TabIndex = 12
        CountryLabel.Text = "Country:"
        '
        'Address_IDLabel
        '
        Address_IDLabel.AutoSize = True
        Address_IDLabel.Location = New System.Drawing.Point(132, 654)
        Address_IDLabel.Name = "Address_IDLabel"
        Address_IDLabel.Size = New System.Drawing.Size(93, 20)
        Address_IDLabel.TabIndex = 137
        Address_IDLabel.Text = "Address ID:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 123)
        Me.Panel1.TabIndex = 63
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(106, 37)
        Me.SHeadLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(181, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Patient Register"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox1.Location = New System.Drawing.Point(-144, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1570, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 125)
        Me.Panel2.TabIndex = 62
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(18, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 98)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(124, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wellmeadows Hospital"
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.User.ForeColor = System.Drawing.Color.DimGray
        Me.User.Location = New System.Drawing.Point(132, 708)
        Me.User.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(68, 20)
        Me.User.TabIndex = 78
        Me.User.Text = "Address"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47849!))
        Me.TableLayoutPanel1.Controls.Add(House_NoLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.House_NoTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(StreetLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(DistrictLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(ProvinceLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Postal_CodeLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(CountryLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.StreetTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DistrictTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ProvinceTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Postal_CodeTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CountryTextBox, 1, 5)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(118, 760)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(361, 242)
        Me.TableLayoutPanel1.TabIndex = 79
        '
        'House_NoTextBox
        '
        Me.House_NoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.House_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "House_No", True))
        Me.House_NoTextBox.Location = New System.Drawing.Point(143, 5)
        Me.House_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.House_NoTextBox.Name = "House_NoTextBox"
        Me.House_NoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.House_NoTextBox.TabIndex = 3
        '
        'AddressesBindingSource
        '
        Me.AddressesBindingSource.DataMember = "Addresses"
        Me.AddressesBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Street", True))
        Me.StreetTextBox.Location = New System.Drawing.Point(143, 40)
        Me.StreetTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StreetTextBox.TabIndex = 5
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "District", True))
        Me.DistrictTextBox.Location = New System.Drawing.Point(143, 75)
        Me.DistrictTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DistrictTextBox.TabIndex = 7
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(143, 110)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProvinceTextBox.TabIndex = 9
        '
        'Postal_CodeTextBox
        '
        Me.Postal_CodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Postal_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Postal_Code", True))
        Me.Postal_CodeTextBox.Location = New System.Drawing.Point(143, 145)
        Me.Postal_CodeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Postal_CodeTextBox.Name = "Postal_CodeTextBox"
        Me.Postal_CodeTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Postal_CodeTextBox.TabIndex = 11
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(143, 180)
        Me.CountryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CountryTextBox.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(107, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Personnel Information"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.33518!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.66482!))
        Me.TableLayoutPanel2.Controls.Add(Me.NextPNumTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(P_NumLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(P_IDLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.P_IDTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(First_NameLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.First_NameTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Last_NameLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Last_NameTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(PhoneNumLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PhoneNumTextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Date_Of_BirthLabel, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Date_Of_BirthDateTimePicker, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(SexLabel, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.SexComboBox, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Marital_StatusLabel, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Marital_StatusComboBox, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Date_RegisteredLabel, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Date_RegisteredDateTimePicker, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(DoctorIDLabel, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.DoctorIDTextBox, 1, 9)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(128, 298)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(361, 351)
        Me.TableLayoutPanel2.TabIndex = 83
        '
        'NextPNumTextBox
        '
        Me.NextPNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextPNumBindingSource, "NextPNum", True))
        Me.NextPNumTextBox.Location = New System.Drawing.Point(144, 3)
        Me.NextPNumTextBox.Name = "NextPNumTextBox"
        Me.NextPNumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NextPNumTextBox.TabIndex = 135
        '
        'GetNextPNumBindingSource
        '
        Me.GetNextPNumBindingSource.DataMember = "GetNextPNum"
        Me.GetNextPNumBindingSource.DataSource = Me.DatabaseG26DataSet7
        '
        'DatabaseG26DataSet7
        '
        Me.DatabaseG26DataSet7.DataSetName = "DatabaseG26DataSet7"
        Me.DatabaseG26DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "P_ID", True))
        Me.P_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_IDTextBox.Location = New System.Drawing.Point(145, 40)
        Me.P_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.P_IDTextBox.TabIndex = 3
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(145, 75)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(145, 110)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(145, 145)
        Me.PhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PhoneNumTextBox.TabIndex = 9
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_Of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource, "Date_Of_Birth", True))
        Me.Date_Of_BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(145, 180)
        Me.Date_Of_BirthDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 11
        '
        'SexComboBox
        '
        Me.SexComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Sex", True))
        Me.SexComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexComboBox.Location = New System.Drawing.Point(145, 215)
        Me.SexComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(200, 28)
        Me.SexComboBox.TabIndex = 13
        '
        'Marital_StatusComboBox
        '
        Me.Marital_StatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Marital_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Marital_Status", True))
        Me.Marital_StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Marital_StatusComboBox.FormattingEnabled = True
        Me.Marital_StatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Separated ", "Divorced", "Widowed"})
        Me.Marital_StatusComboBox.Location = New System.Drawing.Point(145, 250)
        Me.Marital_StatusComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Marital_StatusComboBox.Name = "Marital_StatusComboBox"
        Me.Marital_StatusComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Marital_StatusComboBox.TabIndex = 15
        '
        'Date_RegisteredDateTimePicker
        '
        Me.Date_RegisteredDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_RegisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource, "Date_Registered", True))
        Me.Date_RegisteredDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_RegisteredDateTimePicker.Location = New System.Drawing.Point(145, 285)
        Me.Date_RegisteredDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_RegisteredDateTimePicker.Name = "Date_RegisteredDateTimePicker"
        Me.Date_RegisteredDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_RegisteredDateTimePicker.TabIndex = 17
        '
        'DoctorIDTextBox
        '
        Me.DoctorIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DoctorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "doctorID", True))
        Me.DoctorIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DoctorIDTextBox.Location = New System.Drawing.Point(145, 320)
        Me.DoctorIDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DoctorIDTextBox.Name = "DoctorIDTextBox"
        Me.DoctorIDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DoctorIDTextBox.TabIndex = 21
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Me.AddressesTableAdapter
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.Clinic_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.DrugReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.DrugRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.Employment_ContractsTableAdapter = Nothing
        Me.TableAdapterManager.InpatientsTableAdapter = Nothing
        Me.TableAdapterManager.Local_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager.Local_DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_HeadTableAdapter = Nothing
        Me.TableAdapterManager.Outpatient_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager.OutpatientsTableAdapter = Nothing
        Me.TableAdapterManager.Patients_NextOfKinTableAdapter = Me.Patients_NextOfKinTableAdapter
        Me.TableAdapterManager.PatientsTableAdapter = Me.PatientsTableAdapter
        Me.TableAdapterManager.Pharmaceutical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'AddressesTableAdapter
        '
        Me.AddressesTableAdapter.ClearBeforeFill = True
        '
        'Patients_NextOfKinTableAdapter
        '
        Me.Patients_NextOfKinTableAdapter.ClearBeforeFill = True
        '
        'Patients_NextOfKinBindingSource
        '
        Me.Patients_NextOfKinBindingSource.DataMember = "Patients_NextOfKin"
        Me.Patients_NextOfKinBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'DatabaseG26DataSet5
        '
        Me.DatabaseG26DataSet5.DataSetName = "DatabaseG26DataSet5"
        Me.DatabaseG26DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetNextAddressIDBindingSource
        '
        Me.GetNextAddressIDBindingSource.DataMember = "GetNextAddressID"
        Me.GetNextAddressIDBindingSource.DataSource = Me.DatabaseG26DataSet5
        '
        'GetNextAddressIDTableAdapter
        '
        Me.GetNextAddressIDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Address_IDTextBox
        '
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextAddressIDBindingSource, "NextAddressID", True))
        Me.Address_IDTextBox.Location = New System.Drawing.Point(-96, 767)
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        Me.Address_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Address_IDTextBox.TabIndex = 136
        '
        'GetNextPNumTableAdapter
        '
        Me.GetNextPNumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'savebtn
        '
        Me.savebtn.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._next
        Me.savebtn.Location = New System.Drawing.Point(509, 1029)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(44, 28)
        Me.savebtn.TabIndex = 134
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(932, 1181)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 35)
        Me.Button1.TabIndex = 85
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(870, 1133)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 35)
        Me.Button2.TabIndex = 86
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox6.Location = New System.Drawing.Point(-3, 278)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(640, 17)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 81
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox4.Location = New System.Drawing.Point(-13, 733)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(640, 17)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 75
        Me.PictureBox4.TabStop = False
        '
        'DOC_LU
        '
        Me.DOC_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DOC_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.DOC_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DOC_LU.ForeColor = System.Drawing.Color.Transparent
        Me.DOC_LU.Location = New System.Drawing.Point(477, 621)
        Me.DOC_LU.Name = "DOC_LU"
        Me.DOC_LU.Size = New System.Drawing.Size(24, 23)
        Me.DOC_LU.TabIndex = 137
        Me.DOC_LU.UseVisualStyleBackColor = True
        '
        'Address_IDTextBox1
        '
        Me.Address_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource, "Address_ID", True))
        Me.Address_IDTextBox1.Location = New System.Drawing.Point(273, 651)
        Me.Address_IDTextBox1.Name = "Address_IDTextBox1"
        Me.Address_IDTextBox1.Size = New System.Drawing.Size(198, 26)
        Me.Address_IDTextBox1.TabIndex = 138
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(133, 680)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(379, 13)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "* If you have an Address ID, it is not necessary to fill in the Address Informati" &
    "on."
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(477, 649)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 144
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PatientRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(766, 1061)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Address_IDLabel)
        Me.Controls.Add(Me.Address_IDTextBox1)
        Me.Controls.Add(Me.DOC_LU)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Address_IDTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PatientRegister"
        Me.Text = "PatientRegister"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.GetNextPNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patients_NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextAddressIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents User As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddressesTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter
    Friend WithEvents AddressesBindingSource As BindingSource
    Friend WithEvents House_NoTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents Postal_CodeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents Patients_NextOfKinTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Patients_NextOfKinTableAdapter
    Friend WithEvents Patients_NextOfKinBindingSource As BindingSource
    Friend WithEvents savebtn As Button
    Friend WithEvents DatabaseG26DataSet5 As DatabaseG26DataSet5
    Friend WithEvents GetNextAddressIDBindingSource As BindingSource
    Friend WithEvents GetNextAddressIDTableAdapter As DatabaseG26DataSet5TableAdapters.GetNextAddressIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DatabaseG26DataSet5TableAdapters.TableAdapterManager
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents DatabaseG26DataSet7 As DatabaseG26DataSet7
    Friend WithEvents GetNextPNumBindingSource As BindingSource
    Friend WithEvents GetNextPNumTableAdapter As DatabaseG26DataSet7TableAdapters.GetNextPNumTableAdapter
    Friend WithEvents TableAdapterManager2 As DatabaseG26DataSet7TableAdapters.TableAdapterManager
    Friend WithEvents NextPNumTextBox As TextBox
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents Marital_StatusComboBox As ComboBox
    Friend WithEvents Date_RegisteredDateTimePicker As DateTimePicker
    Friend WithEvents DoctorIDTextBox As TextBox
    Friend WithEvents DOC_LU As Button
    Friend WithEvents Address_IDTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
