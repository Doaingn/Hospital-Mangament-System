<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRegister2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim House_NoLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim ProvinceLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.AddressesTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter()
        Me.Patients_NextOfKinTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Patients_NextOfKinTableAdapter()
        Me.AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.House_NoTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.Postal_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_NextOfKinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.RelationshipComboBox = New System.Windows.Forms.ComboBox()
        Me.DatabaseG26DataSet5 = New WellMeadows_Hospital_G26.DatabaseG26DataSet5()
        Me.GetNextAddressIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextAddressIDTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.GetNextAddressIDTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.TableAdapterManager()
        Me.NextAddressIDTextBox = New System.Windows.Forms.TextBox()
        Me.DatabaseG26DataSet7 = New WellMeadows_Hospital_G26.DatabaseG26DataSet7()
        Me.GetNextPNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextPNumTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet7TableAdapters.GetNextPNumTableAdapter()
        Me.TableAdapterManager2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet7TableAdapters.TableAdapterManager()
        Me.DatabaseG26DataSet8 = New WellMeadows_Hospital_G26.DatabaseG26DataSet8()
        Me.GetLatestPNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetLatestPNumTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet8TableAdapters.GetLatestPNumTableAdapter()
        Me.TableAdapterManager3 = New WellMeadows_Hospital_G26.DatabaseG26DataSet8TableAdapters.TableAdapterManager()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddressIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BEd_LU = New System.Windows.Forms.Button()
        House_NoLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        DistrictLabel = New System.Windows.Forms.Label()
        ProvinceLabel = New System.Windows.Forms.Label()
        Postal_CodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patients_NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextAddressIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextPNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetLatestPNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'House_NoLabel
        '
        House_NoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        House_NoLabel.AutoSize = True
        House_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        House_NoLabel.Location = New System.Drawing.Point(3, 4)
        House_NoLabel.Name = "House_NoLabel"
        House_NoLabel.Size = New System.Drawing.Size(84, 20)
        House_NoLabel.TabIndex = 89
        House_NoLabel.Text = "House No:"
        '
        'StreetLabel
        '
        StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        StreetLabel.AutoSize = True
        StreetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StreetLabel.Location = New System.Drawing.Point(3, 32)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(57, 20)
        StreetLabel.TabIndex = 91
        StreetLabel.Text = "Street:"
        '
        'DistrictLabel
        '
        DistrictLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DistrictLabel.AutoSize = True
        DistrictLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DistrictLabel.Location = New System.Drawing.Point(3, 60)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(62, 20)
        DistrictLabel.TabIndex = 93
        DistrictLabel.Text = "District:"
        '
        'ProvinceLabel
        '
        ProvinceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ProvinceLabel.AutoSize = True
        ProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ProvinceLabel.Location = New System.Drawing.Point(3, 88)
        ProvinceLabel.Name = "ProvinceLabel"
        ProvinceLabel.Size = New System.Drawing.Size(73, 20)
        ProvinceLabel.TabIndex = 95
        ProvinceLabel.Text = "Province:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Postal_CodeLabel.Location = New System.Drawing.Point(3, 116)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(99, 20)
        Postal_CodeLabel.TabIndex = 97
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CountryLabel.Location = New System.Drawing.Point(3, 144)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(68, 20)
        CountryLabel.TabIndex = 99
        CountryLabel.Text = "Country:"
        '
        'First_NameLabel
        '
        First_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        First_NameLabel.Location = New System.Drawing.Point(3, 6)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 102
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(3, 39)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 104
        Last_NameLabel.Text = "Last Name:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PhoneNumLabel.Location = New System.Drawing.Point(3, 72)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(96, 20)
        PhoneNumLabel.TabIndex = 106
        PhoneNumLabel.Text = "Phone Num:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        RelationshipLabel.AutoSize = True
        RelationshipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        RelationshipLabel.Location = New System.Drawing.Point(3, 105)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(101, 20)
        RelationshipLabel.TabIndex = 108
        RelationshipLabel.Text = "Relationship:"
        '
        'Label5
        '
        Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label5.Location = New System.Drawing.Point(3, 140)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(93, 20)
        Label5.TabIndex = 145
        Label5.Text = "Address ID:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 123)
        Me.Panel1.TabIndex = 65
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
        Me.Panel2.Size = New System.Drawing.Size(593, 125)
        Me.Panel2.TabIndex = 64
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
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
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
        'AddressesBindingSource
        '
        Me.AddressesBindingSource.DataMember = "Addresses"
        Me.AddressesBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'House_NoTextBox
        '
        Me.House_NoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.House_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "House_No", True))
        Me.House_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.House_NoTextBox.Location = New System.Drawing.Point(115, 3)
        Me.House_NoTextBox.Name = "House_NoTextBox"
        Me.House_NoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.House_NoTextBox.TabIndex = 90
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Street", True))
        Me.StreetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.StreetTextBox.Location = New System.Drawing.Point(115, 31)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StreetTextBox.TabIndex = 92
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "District", True))
        Me.DistrictTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DistrictTextBox.Location = New System.Drawing.Point(115, 59)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DistrictTextBox.TabIndex = 94
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Province", True))
        Me.ProvinceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(115, 87)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProvinceTextBox.TabIndex = 96
        '
        'Postal_CodeTextBox
        '
        Me.Postal_CodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Postal_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Postal_Code", True))
        Me.Postal_CodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Postal_CodeTextBox.Location = New System.Drawing.Point(115, 115)
        Me.Postal_CodeTextBox.Name = "Postal_CodeTextBox"
        Me.Postal_CodeTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Postal_CodeTextBox.TabIndex = 98
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(115, 143)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CountryTextBox.TabIndex = 100
        '
        'Patients_NextOfKinBindingSource
        '
        Me.Patients_NextOfKinBindingSource.DataMember = "Patients_NextOfKin"
        Me.Patients_NextOfKinBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(113, 3)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(198, 26)
        Me.First_NameTextBox.TabIndex = 103
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(113, 36)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(198, 26)
        Me.Last_NameTextBox.TabIndex = 105
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(113, 69)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(198, 26)
        Me.PhoneNumTextBox.TabIndex = 107
        '
        'RelationshipComboBox
        '
        Me.RelationshipComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RelationshipComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "Relationship", True))
        Me.RelationshipComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RelationshipComboBox.FormattingEnabled = True
        Me.RelationshipComboBox.Items.AddRange(New Object() {"Spouse", "Adult Children", "Parents", "Siblings", "Other Relatives"})
        Me.RelationshipComboBox.Location = New System.Drawing.Point(113, 102)
        Me.RelationshipComboBox.Name = "RelationshipComboBox"
        Me.RelationshipComboBox.Size = New System.Drawing.Size(198, 28)
        Me.RelationshipComboBox.TabIndex = 109
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
        'NextAddressIDTextBox
        '
        Me.NextAddressIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextAddressIDBindingSource, "NextAddressID", True))
        Me.NextAddressIDTextBox.Location = New System.Drawing.Point(0, 595)
        Me.NextAddressIDTextBox.Name = "NextAddressIDTextBox"
        Me.NextAddressIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NextAddressIDTextBox.TabIndex = 112
        '
        'DatabaseG26DataSet7
        '
        Me.DatabaseG26DataSet7.DataSetName = "DatabaseG26DataSet7"
        Me.DatabaseG26DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetNextPNumBindingSource
        '
        Me.GetNextPNumBindingSource.DataMember = "GetNextPNum"
        Me.GetNextPNumBindingSource.DataSource = Me.DatabaseG26DataSet7
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
        'DatabaseG26DataSet8
        '
        Me.DatabaseG26DataSet8.DataSetName = "DatabaseG26DataSet8"
        Me.DatabaseG26DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetLatestPNumBindingSource
        '
        Me.GetLatestPNumBindingSource.DataMember = "GetLatestPNum"
        Me.GetLatestPNumBindingSource.DataSource = Me.DatabaseG26DataSet8
        '
        'GetLatestPNumTableAdapter
        '
        Me.GetLatestPNumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'P_NumTextBox
        '
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetLatestPNumBindingSource, "P_Num", True))
        Me.P_NumTextBox.Location = New System.Drawing.Point(476, 297)
        Me.P_NumTextBox.Name = "P_NumTextBox"
        Me.P_NumTextBox.Size = New System.Drawing.Size(121, 20)
        Me.P_NumTextBox.TabIndex = 114
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.23809!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.7619!))
        Me.TableLayoutPanel2.Controls.Add(Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Last_NameLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.AddressIDTextBox1, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(PhoneNumLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(RelationshipLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(First_NameLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RelationshipComboBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PhoneNumTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Last_NameTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.First_NameTextBox, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(128, 289)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(315, 169)
        Me.TableLayoutPanel2.TabIndex = 136
        '
        'AddressIDTextBox1
        '
        Me.AddressIDTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AddressIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextAddressIDBindingSource, "NextAddressID", True))
        Me.AddressIDTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddressIDTextBox1.Location = New System.Drawing.Point(113, 137)
        Me.AddressIDTextBox1.Name = "AddressIDTextBox1"
        Me.AddressIDTextBox1.Size = New System.Drawing.Size(198, 26)
        Me.AddressIDTextBox1.TabIndex = 144
        Me.AddressIDTextBox1.Text = "1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58801!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41199!))
        Me.TableLayoutPanel1.Controls.Add(House_NoLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(StreetLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(DistrictLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(ProvinceLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Postal_CodeLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(CountryLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.CountryTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Postal_CodeTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ProvinceTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DistrictTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StreetTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.House_NoTextBox, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(128, 558)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(380, 169)
        Me.TableLayoutPanel1.TabIndex = 137
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox2.Location = New System.Drawing.Point(0, 272)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 140
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(107, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 20)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Patient Next-of-kin Information"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox4.Location = New System.Drawing.Point(-31, 534)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 142
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(76, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 20)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Patient Next-of-kin Address"
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.Transparent
        Me.savebtn.Location = New System.Drawing.Point(468, 760)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(112, 35)
        Me.savebtn.TabIndex = 145
        Me.savebtn.Text = "Submit"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(129, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 13)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "* If you have an Address ID, it is not necessary to fill in the Address Informati" &
    "on."
        '
        'BEd_LU
        '
        Me.BEd_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BEd_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.BEd_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEd_LU.ForeColor = System.Drawing.Color.Transparent
        Me.BEd_LU.Location = New System.Drawing.Point(446, 426)
        Me.BEd_LU.Name = "BEd_LU"
        Me.BEd_LU.Size = New System.Drawing.Size(24, 23)
        Me.BEd_LU.TabIndex = 147
        Me.BEd_LU.UseVisualStyleBackColor = True
        '
        'PatientRegister2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 812)
        Me.Controls.Add(Me.BEd_LU)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.P_NumTextBox)
        Me.Controls.Add(Me.NextAddressIDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "PatientRegister2"
        Me.Text = "PatientRegister2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patients_NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextAddressIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextPNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetLatestPNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents RelationshipComboBox As ComboBox
    Friend WithEvents DatabaseG26DataSet5 As DatabaseG26DataSet5
    Friend WithEvents GetNextAddressIDBindingSource As BindingSource
    Friend WithEvents GetNextAddressIDTableAdapter As DatabaseG26DataSet5TableAdapters.GetNextAddressIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DatabaseG26DataSet5TableAdapters.TableAdapterManager
    Friend WithEvents NextAddressIDTextBox As TextBox
    Friend WithEvents DatabaseG26DataSet7 As DatabaseG26DataSet7
    Friend WithEvents GetNextPNumBindingSource As BindingSource
    Friend WithEvents GetNextPNumTableAdapter As DatabaseG26DataSet7TableAdapters.GetNextPNumTableAdapter
    Friend WithEvents TableAdapterManager2 As DatabaseG26DataSet7TableAdapters.TableAdapterManager
    Friend WithEvents DatabaseG26DataSet8 As DatabaseG26DataSet8
    Friend WithEvents GetLatestPNumBindingSource As BindingSource
    Friend WithEvents GetLatestPNumTableAdapter As DatabaseG26DataSet8TableAdapters.GetLatestPNumTableAdapter
    Friend WithEvents TableAdapterManager3 As DatabaseG26DataSet8TableAdapters.TableAdapterManager
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddressIDTextBox1 As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BEd_LU As Button
End Class
