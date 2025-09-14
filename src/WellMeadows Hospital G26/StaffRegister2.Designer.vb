<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffRegister2
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
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim CurrentSalaryLabel As System.Windows.Forms.Label
        Dim SalaryScaleLabel As System.Windows.Forms.Label
        Dim NextSNumLabel As System.Windows.Forms.Label
        Dim House_NoLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim ProvinceLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Address_IDLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Users_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DatabaseG26DataSet5 = New WellMeadows_Hospital_G26.DatabaseG26DataSet5()
        Me.GetNextAddressIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextAddressIDTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.GetNextAddressIDTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.DatabaseG26DataSet5TableAdapters.TableAdapterManager()
        Me.DatabaseG26DataSet6 = New WellMeadows_Hospital_G26.DatabaseG26DataSet6()
        Me.GetNextSNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextSNumTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet6TableAdapters.GetNextSNumTableAdapter()
        Me.TableAdapterManager2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet6TableAdapters.TableAdapterManager()
        Me.NextSNumTextBox = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.House_NoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.Postal_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SexTextBox = New System.Windows.Forms.ComboBox()
        Me.SalaryScaleTextBox = New System.Windows.Forms.ComboBox()
        Me.PositionTextBox = New System.Windows.Forms.ComboBox()
        Me.User = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.AddressesTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter()
        Me.StaffsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.StaffsTableAdapter()
        Me.BEd_LU = New System.Windows.Forms.Button()
        Me.AddressIDTextBox = New System.Windows.Forms.TextBox()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        CurrentSalaryLabel = New System.Windows.Forms.Label()
        SalaryScaleLabel = New System.Windows.Forms.Label()
        NextSNumLabel = New System.Windows.Forms.Label()
        House_NoLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        DistrictLabel = New System.Windows.Forms.Label()
        ProvinceLabel = New System.Windows.Forms.Label()
        Postal_CodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Address_IDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextAddressIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextSNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S_IDLabel
        '
        S_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_IDLabel.AutoSize = True
        S_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_IDLabel.Location = New System.Drawing.Point(4, 42)
        S_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(69, 20)
        S_IDLabel.TabIndex = 95
        S_IDLabel.Text = "Staff ID:"
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
        First_NameLabel.TabIndex = 97
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
        Last_NameLabel.TabIndex = 99
        Last_NameLabel.Text = "Last Name:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_of_BirthLabel.Location = New System.Drawing.Point(4, 147)
        Date_of_BirthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(103, 20)
        Date_of_BirthLabel.TabIndex = 101
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'SexLabel
        '
        SexLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        SexLabel.Location = New System.Drawing.Point(4, 182)
        SexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(40, 20)
        SexLabel.TabIndex = 103
        SexLabel.Text = "Sex:"
        '
        'PositionLabel
        '
        PositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PositionLabel.Location = New System.Drawing.Point(4, 252)
        PositionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(69, 20)
        PositionLabel.TabIndex = 105
        PositionLabel.Text = "Position:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PhoneNumLabel.Location = New System.Drawing.Point(4, 217)
        PhoneNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(119, 20)
        PhoneNumLabel.TabIndex = 107
        PhoneNumLabel.Text = "Phone Number:"
        '
        'CurrentSalaryLabel
        '
        CurrentSalaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CurrentSalaryLabel.AutoSize = True
        CurrentSalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CurrentSalaryLabel.Location = New System.Drawing.Point(4, 287)
        CurrentSalaryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CurrentSalaryLabel.Name = "CurrentSalaryLabel"
        CurrentSalaryLabel.Size = New System.Drawing.Size(114, 20)
        CurrentSalaryLabel.TabIndex = 109
        CurrentSalaryLabel.Text = "Current Salary:"
        '
        'SalaryScaleLabel
        '
        SalaryScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SalaryScaleLabel.AutoSize = True
        SalaryScaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        SalaryScaleLabel.Location = New System.Drawing.Point(4, 327)
        SalaryScaleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SalaryScaleLabel.Name = "SalaryScaleLabel"
        SalaryScaleLabel.Size = New System.Drawing.Size(101, 20)
        SalaryScaleLabel.TabIndex = 111
        SalaryScaleLabel.Text = "Salary Scale:"
        '
        'NextSNumLabel
        '
        NextSNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NextSNumLabel.AutoSize = True
        NextSNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        NextSNumLabel.Location = New System.Drawing.Point(4, 7)
        NextSNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NextSNumLabel.Name = "NextSNumLabel"
        NextSNumLabel.Size = New System.Drawing.Size(108, 20)
        NextSNumLabel.TabIndex = 130
        NextSNumLabel.Text = "Staff Number:"
        '
        'House_NoLabel
        '
        House_NoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        House_NoLabel.AutoSize = True
        House_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        House_NoLabel.Location = New System.Drawing.Point(4, 7)
        House_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        House_NoLabel.Name = "House_NoLabel"
        House_NoLabel.Size = New System.Drawing.Size(84, 20)
        House_NoLabel.TabIndex = 118
        House_NoLabel.Text = "House No:"
        '
        'StreetLabel
        '
        StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        StreetLabel.AutoSize = True
        StreetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StreetLabel.Location = New System.Drawing.Point(4, 41)
        StreetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(57, 20)
        StreetLabel.TabIndex = 120
        StreetLabel.Text = "Street:"
        '
        'DistrictLabel
        '
        DistrictLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DistrictLabel.AutoSize = True
        DistrictLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DistrictLabel.Location = New System.Drawing.Point(4, 75)
        DistrictLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(62, 20)
        DistrictLabel.TabIndex = 122
        DistrictLabel.Text = "District:"
        '
        'ProvinceLabel
        '
        ProvinceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ProvinceLabel.AutoSize = True
        ProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ProvinceLabel.Location = New System.Drawing.Point(4, 109)
        ProvinceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProvinceLabel.Name = "ProvinceLabel"
        ProvinceLabel.Size = New System.Drawing.Size(73, 20)
        ProvinceLabel.TabIndex = 124
        ProvinceLabel.Text = "Province:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Postal_CodeLabel.Location = New System.Drawing.Point(4, 143)
        Postal_CodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(99, 20)
        Postal_CodeLabel.TabIndex = 126
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CountryLabel.Location = New System.Drawing.Point(4, 177)
        CountryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(68, 20)
        CountryLabel.TabIndex = 128
        CountryLabel.Text = "Country:"
        '
        'Address_IDLabel
        '
        Address_IDLabel.AutoSize = True
        Address_IDLabel.Location = New System.Drawing.Point(115, 655)
        Address_IDLabel.Name = "Address_IDLabel"
        Address_IDLabel.Size = New System.Drawing.Size(93, 20)
        Address_IDLabel.TabIndex = 140
        Address_IDLabel.Text = "Address ID:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 123)
        Me.Panel1.TabIndex = 92
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(106, 37)
        Me.SHeadLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(156, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Staff Register"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox2.Location = New System.Drawing.Point(-144, 42)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1570, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 125)
        Me.Panel2.TabIndex = 91
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(18, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 98)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "S_ID", True))
        Me.S_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_IDTextBox.Location = New System.Drawing.Point(161, 40)
        Me.S_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.S_IDTextBox.TabIndex = 96
        '
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(161, 75)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.First_NameTextBox.TabIndex = 98
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(161, 110)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Last_NameTextBox.TabIndex = 100
        '
        'Date_of_BirthDateTimePicker
        '
        Me.Date_of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffsBindingSource, "Date_of_Birth", True))
        Me.Date_of_BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_of_BirthDateTimePicker.Location = New System.Drawing.Point(161, 145)
        Me.Date_of_BirthDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Date_of_BirthDateTimePicker.Name = "Date_of_BirthDateTimePicker"
        Me.Date_of_BirthDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_of_BirthDateTimePicker.TabIndex = 102
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(161, 215)
        Me.PhoneNumTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PhoneNumTextBox.TabIndex = 108
        '
        'CurrentSalaryTextBox
        '
        Me.CurrentSalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "CurrentSalary", True))
        Me.CurrentSalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CurrentSalaryTextBox.Location = New System.Drawing.Point(161, 285)
        Me.CurrentSalaryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CurrentSalaryTextBox.Name = "CurrentSalaryTextBox"
        Me.CurrentSalaryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CurrentSalaryTextBox.TabIndex = 110
        '
        'Users_IDTextBox
        '
        Me.Users_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Users_ID", True))
        Me.Users_IDTextBox.Location = New System.Drawing.Point(-89, 434)
        Me.Users_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Users_IDTextBox.Name = "Users_IDTextBox"
        Me.Users_IDTextBox.Size = New System.Drawing.Size(148, 26)
        Me.Users_IDTextBox.TabIndex = 116
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
        'DatabaseG26DataSet6
        '
        Me.DatabaseG26DataSet6.DataSetName = "DatabaseG26DataSet6"
        Me.DatabaseG26DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetNextSNumBindingSource
        '
        Me.GetNextSNumBindingSource.DataMember = "GetNextSNum"
        Me.GetNextSNumBindingSource.DataSource = Me.DatabaseG26DataSet6
        '
        'GetNextSNumTableAdapter
        '
        Me.GetNextSNumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NextSNumTextBox
        '
        Me.NextSNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextSNumBindingSource, "NextSNum", True))
        Me.NextSNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NextSNumTextBox.Location = New System.Drawing.Point(161, 5)
        Me.NextSNumTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextSNumTextBox.Name = "NextSNumTextBox"
        Me.NextSNumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NextSNumTextBox.TabIndex = 131
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.White
        Me.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.Black
        Me.savebtn.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._next
        Me.savebtn.Location = New System.Drawing.Point(540, 1019)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(44, 28)
        Me.savebtn.TabIndex = 132
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.51436!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.48564!))
        Me.TableLayoutPanel1.Controls.Add(House_NoLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(StreetLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.House_NoTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StreetTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DistrictTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ProvinceTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Postal_CodeTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CountryTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(DistrictLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(ProvinceLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Postal_CodeLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(CountryLabel, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(111, 796)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(383, 204)
        Me.TableLayoutPanel1.TabIndex = 134
        '
        'House_NoTextBox
        '
        Me.House_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "House_No", True))
        Me.House_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.House_NoTextBox.Location = New System.Drawing.Point(162, 5)
        Me.House_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.House_NoTextBox.Name = "House_NoTextBox"
        Me.House_NoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.House_NoTextBox.TabIndex = 119
        '
        'AddressesBindingSource
        '
        Me.AddressesBindingSource.DataMember = "Addresses"
        Me.AddressesBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Street", True))
        Me.StreetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.StreetTextBox.Location = New System.Drawing.Point(162, 39)
        Me.StreetTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StreetTextBox.TabIndex = 121
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "District", True))
        Me.DistrictTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DistrictTextBox.Location = New System.Drawing.Point(162, 73)
        Me.DistrictTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DistrictTextBox.TabIndex = 123
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Province", True))
        Me.ProvinceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(162, 107)
        Me.ProvinceTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProvinceTextBox.TabIndex = 125
        '
        'Postal_CodeTextBox
        '
        Me.Postal_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Postal_Code", True))
        Me.Postal_CodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Postal_CodeTextBox.Location = New System.Drawing.Point(162, 141)
        Me.Postal_CodeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Postal_CodeTextBox.Name = "Postal_CodeTextBox"
        Me.Postal_CodeTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Postal_CodeTextBox.TabIndex = 127
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(162, 175)
        Me.CountryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CountryTextBox.TabIndex = 129
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58801!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41199!))
        Me.TableLayoutPanel2.Controls.Add(Me.NextSNumTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SexTextBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.SalaryScaleTextBox, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(NextSNumLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.S_IDTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PositionTextBox, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(S_IDLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(First_NameLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(PhoneNumLabel, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(SexLabel, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Last_NameLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Date_of_BirthLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Date_of_BirthDateTimePicker, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Last_NameTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(PositionLabel, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(CurrentSalaryLabel, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(SalaryScaleLabel, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.CurrentSalaryTextBox, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.PhoneNumTextBox, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.First_NameTextBox, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(111, 293)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(534, 359)
        Me.TableLayoutPanel2.TabIndex = 135
        '
        'SexTextBox
        '
        Me.SexTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Sex", True))
        Me.SexTextBox.FormattingEnabled = True
        Me.SexTextBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexTextBox.Location = New System.Drawing.Point(160, 182)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(201, 28)
        Me.SexTextBox.TabIndex = 142
        '
        'SalaryScaleTextBox
        '
        Me.SalaryScaleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SalaryScaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "SalaryScale", True))
        Me.SalaryScaleTextBox.FormattingEnabled = True
        Me.SalaryScaleTextBox.Items.AddRange(New Object() {"A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3"})
        Me.SalaryScaleTextBox.Location = New System.Drawing.Point(160, 326)
        Me.SalaryScaleTextBox.Name = "SalaryScaleTextBox"
        Me.SalaryScaleTextBox.Size = New System.Drawing.Size(201, 28)
        Me.SalaryScaleTextBox.TabIndex = 141
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Position", True))
        Me.PositionTextBox.FormattingEnabled = True
        Me.PositionTextBox.Items.AddRange(New Object() {"Medical Director", "Doctor", "Charge Nurse", "Nurse", "Personnel Officer"})
        Me.PositionTextBox.Location = New System.Drawing.Point(160, 252)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(202, 28)
        Me.PositionTextBox.TabIndex = 140
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.User.ForeColor = System.Drawing.Color.DimGray
        Me.User.Location = New System.Drawing.Point(107, 253)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(165, 20)
        Me.User.TabIndex = 137
        Me.User.Text = "Personnel Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(107, 714)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Address Information "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox3.Location = New System.Drawing.Point(0, 737)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 138
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox4.Location = New System.Drawing.Point(0, 276)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 136
        Me.PictureBox4.TabStop = False
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Patients_NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.Pharmaceutical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Me.StaffsTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'AddressesTableAdapter
        '
        Me.AddressesTableAdapter.ClearBeforeFill = True
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'BEd_LU
        '
        Me.BEd_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BEd_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.BEd_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEd_LU.ForeColor = System.Drawing.Color.Transparent
        Me.BEd_LU.Location = New System.Drawing.Point(478, 657)
        Me.BEd_LU.Name = "BEd_LU"
        Me.BEd_LU.Size = New System.Drawing.Size(24, 23)
        Me.BEd_LU.TabIndex = 140
        Me.BEd_LU.UseVisualStyleBackColor = True
        '
        'AddressIDTextBox
        '
        Me.AddressIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextAddressIDBindingSource, "NextAddressID", True))
        Me.AddressIDTextBox.Location = New System.Drawing.Point(-123, 618)
        Me.AddressIDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddressIDTextBox.Name = "AddressIDTextBox"
        Me.AddressIDTextBox.Size = New System.Drawing.Size(199, 26)
        Me.AddressIDTextBox.TabIndex = 130
        '
        'Address_IDTextBox
        '
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Address_ID", True))
        Me.Address_IDTextBox.Location = New System.Drawing.Point(271, 655)
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        Me.Address_IDTextBox.Size = New System.Drawing.Size(201, 26)
        Me.Address_IDTextBox.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(116, 683)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(379, 13)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "* If you have an Address ID, it is not necessary to fill in the Address Informati" &
    "on."
        '
        'StaffRegister2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 1061)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Address_IDLabel)
        Me.Controls.Add(Me.Address_IDTextBox)
        Me.Controls.Add(Me.BEd_LU)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.AddressIDTextBox)
        Me.Controls.Add(Me.Users_IDTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StaffRegister2"
        Me.Text = "StaffRegister2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextAddressIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextSNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents AddressesTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Date_of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents CurrentSalaryTextBox As TextBox
    Friend WithEvents Users_IDTextBox As TextBox
    Friend WithEvents AddressesBindingSource As BindingSource
    Friend WithEvents DatabaseG26DataSet5 As DatabaseG26DataSet5
    Friend WithEvents GetNextAddressIDBindingSource As BindingSource
    Friend WithEvents GetNextAddressIDTableAdapter As DatabaseG26DataSet5TableAdapters.GetNextAddressIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DatabaseG26DataSet5TableAdapters.TableAdapterManager
    Friend WithEvents DatabaseG26DataSet6 As DatabaseG26DataSet6
    Friend WithEvents GetNextSNumBindingSource As BindingSource
    Friend WithEvents GetNextSNumTableAdapter As DatabaseG26DataSet6TableAdapters.GetNextSNumTableAdapter
    Friend WithEvents TableAdapterManager2 As DatabaseG26DataSet6TableAdapters.TableAdapterManager
    Friend WithEvents NextSNumTextBox As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents User As Label
    Friend WithEvents House_NoTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents Postal_CodeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SexTextBox As ComboBox
    Friend WithEvents SalaryScaleTextBox As ComboBox
    Friend WithEvents PositionTextBox As ComboBox
    Friend WithEvents BEd_LU As Button
    Friend WithEvents AddressIDTextBox As TextBox
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents Label4 As Label
End Class
