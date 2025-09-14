<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressP
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
        Dim Address_IDLabel As System.Windows.Forms.Label
        Dim House_NoLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim ProvinceLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.AddressesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressesTableAdapter1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.AddressesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.House_NoTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.Postal_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Address_IDLabel = New System.Windows.Forms.Label()
        House_NoLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        DistrictLabel = New System.Windows.Forms.Label()
        ProvinceLabel = New System.Windows.Forms.Label()
        Postal_CodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Address_IDLabel
        '
        Address_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Address_IDLabel.AutoSize = True
        Address_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Address_IDLabel.Location = New System.Drawing.Point(3, 4)
        Address_IDLabel.Name = "Address_IDLabel"
        Address_IDLabel.Size = New System.Drawing.Size(93, 20)
        Address_IDLabel.TabIndex = 0
        Address_IDLabel.Text = "Address ID:"
        '
        'House_NoLabel
        '
        House_NoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        House_NoLabel.AutoSize = True
        House_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        House_NoLabel.Location = New System.Drawing.Point(349, 4)
        House_NoLabel.Name = "House_NoLabel"
        House_NoLabel.Size = New System.Drawing.Size(84, 20)
        House_NoLabel.TabIndex = 2
        House_NoLabel.Text = "House No:"
        '
        'StreetLabel
        '
        StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        StreetLabel.AutoSize = True
        StreetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StreetLabel.Location = New System.Drawing.Point(3, 33)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(57, 20)
        StreetLabel.TabIndex = 4
        StreetLabel.Text = "Street:"
        '
        'DistrictLabel
        '
        DistrictLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DistrictLabel.AutoSize = True
        DistrictLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DistrictLabel.Location = New System.Drawing.Point(349, 33)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(62, 20)
        DistrictLabel.TabIndex = 6
        DistrictLabel.Text = "District:"
        '
        'ProvinceLabel
        '
        ProvinceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ProvinceLabel.AutoSize = True
        ProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ProvinceLabel.Location = New System.Drawing.Point(3, 62)
        ProvinceLabel.Name = "ProvinceLabel"
        ProvinceLabel.Size = New System.Drawing.Size(73, 20)
        ProvinceLabel.TabIndex = 8
        ProvinceLabel.Text = "Province:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Postal_CodeLabel.Location = New System.Drawing.Point(349, 62)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(99, 20)
        Postal_CodeLabel.TabIndex = 10
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        CountryLabel.Location = New System.Drawing.Point(3, 94)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(68, 20)
        CountryLabel.TabIndex = 12
        CountryLabel.Text = "Country:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Param1ToolStripTextBox)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(889, 81)
        Me.Panel2.TabIndex = 55
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.ForeColor = System.Drawing.Color.Gray
        Me.Param1ToolStripTextBox.Location = New System.Drawing.Point(677, 26)
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(83, 46)
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
        Me.Label1.Location = New System.Drawing.Point(82, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wellmeadows Hospital"
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(98, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Address"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 80)
        Me.Panel1.TabIndex = 56
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox2.Location = New System.Drawing.Point(-96, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1047, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.Namespace = "http://tempuri.org/SQLEXPRESS_DatabaseG26DataSet.xsd"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddressesBindingSource1
        '
        Me.AddressesBindingSource1.DataMember = "Addresses"
        Me.AddressesBindingSource1.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'AddressesTableAdapter1
        '
        Me.AddressesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AddressesTableAdapter = Me.AddressesTableAdapter1
        Me.TableAdapterManager1.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager1.BedsTableAdapter = Nothing
        Me.TableAdapterManager1.Clinic_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager1.DrugReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.DrugRequisitionTableAdapter = Nothing
        Me.TableAdapterManager1.Employment_ContractsTableAdapter = Nothing
        Me.TableAdapterManager1.InpatientsTableAdapter = Nothing
        Me.TableAdapterManager1.Local_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager1.Local_DoctorsTableAdapter = Nothing
        Me.TableAdapterManager1.Medication_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.Medication_HeadTableAdapter = Nothing
        Me.TableAdapterManager1.Outpatient_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager1.OutpatientsTableAdapter = Nothing
        Me.TableAdapterManager1.Patients_NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager1.PatientsTableAdapter = Nothing
        Me.TableAdapterManager1.Pharmaceutical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager1.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager1.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager1.StaffsTableAdapter = Nothing
        Me.TableAdapterManager1.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager1.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager1.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        Me.TableAdapterManager1.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager1.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager1.WardsTableAdapter = Nothing
        Me.TableAdapterManager1.Work_ExperienceTableAdapter = Nothing
        '
        'AddressesDataGridView
        '
        Me.AddressesDataGridView.AutoGenerateColumns = False
        Me.AddressesDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.AddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddressesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AddressesDataGridView.DataSource = Me.AddressesBindingSource1
        Me.AddressesDataGridView.Location = New System.Drawing.Point(76, 381)
        Me.AddressesDataGridView.Name = "AddressesDataGridView"
        Me.AddressesDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.AddressesDataGridView.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Address_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Address_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "House_No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "House_No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Street"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Street"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "District"
        Me.DataGridViewTextBoxColumn4.HeaderText = "District"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Province"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Province"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Postal_Code"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Postal_Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03647!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.37082!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45289!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.13982!))
        Me.TableLayoutPanel1.Controls.Add(Address_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Address_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(House_NoLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.House_NoTextBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(StreetLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StreetTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(DistrictLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DistrictTextBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(ProvinceLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ProvinceTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Postal_CodeLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Postal_CodeTextBox, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(CountryLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CountryTextBox, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 164)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65318!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42593!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.98148!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(637, 182)
        Me.TableLayoutPanel1.TabIndex = 67
        '
        'Address_IDTextBox
        '
        Me.Address_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "Address_ID", True))
        Me.Address_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Address_IDTextBox.Location = New System.Drawing.Point(143, 3)
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        Me.Address_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Address_IDTextBox.TabIndex = 1
        '
        'House_NoTextBox
        '
        Me.House_NoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.House_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "House_No", True))
        Me.House_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.House_NoTextBox.Location = New System.Drawing.Point(472, 3)
        Me.House_NoTextBox.Name = "House_NoTextBox"
        Me.House_NoTextBox.Size = New System.Drawing.Size(162, 26)
        Me.House_NoTextBox.TabIndex = 3
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "Street", True))
        Me.StreetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.StreetTextBox.Location = New System.Drawing.Point(143, 32)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StreetTextBox.TabIndex = 5
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "District", True))
        Me.DistrictTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DistrictTextBox.Location = New System.Drawing.Point(472, 32)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(162, 26)
        Me.DistrictTextBox.TabIndex = 7
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "Province", True))
        Me.ProvinceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(143, 61)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ProvinceTextBox.TabIndex = 9
        '
        'Postal_CodeTextBox
        '
        Me.Postal_CodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Postal_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "Postal_Code", True))
        Me.Postal_CodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Postal_CodeTextBox.Location = New System.Drawing.Point(472, 61)
        Me.Postal_CodeTextBox.Name = "Postal_CodeTextBox"
        Me.Postal_CodeTextBox.Size = New System.Drawing.Size(162, 26)
        Me.Postal_CodeTextBox.TabIndex = 11
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressesBindingSource1, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(143, 91)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CountryTextBox.TabIndex = 13
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.AddressesBindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(76, 349)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(89, 29)
        Me.BindingNavigator1.TabIndex = 68
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Add
        Me.BindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Delete
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(26, 26)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'AddressP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 623)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AddressesDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "AddressP"
        Me.Text = "Address"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SHeadLB As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents AddressesBindingSource1 As BindingSource
    Friend WithEvents AddressesTableAdapter1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.AddressesTableAdapter
    Friend WithEvents TableAdapterManager1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddressesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents House_NoTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents Postal_CodeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Param1ToolStripTextBox As TextBox
End Class
