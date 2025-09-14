<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff
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
        Dim S_NumLabel As System.Windows.Forms.Label
        Dim S_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim CurrentSalaryLabel As System.Windows.Forms.Label
        Dim Address_IDLabel As System.Windows.Forms.Label
        Dim Users_IDLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim SalaryScaleLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Param1ToolStripTextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SalaryScaleComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DOC_LU = New System.Windows.Forms.Button()
        Me.S_NumTextBox = New System.Windows.Forms.TextBox()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Users_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.UserBtn = New System.Windows.Forms.Button()
        Me.AddrBtn = New System.Windows.Forms.Button()
        Me.Contractbtn = New System.Windows.Forms.Button()
        Me.WEXSBtn = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.StaffsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.StaffsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.StaffsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuppliersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        S_NumLabel = New System.Windows.Forms.Label()
        S_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        CurrentSalaryLabel = New System.Windows.Forms.Label()
        Address_IDLabel = New System.Windows.Forms.Label()
        Users_IDLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        SalaryScaleLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.StaffsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'S_NumLabel
        '
        S_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_NumLabel.AutoSize = True
        S_NumLabel.Location = New System.Drawing.Point(3, 8)
        S_NumLabel.Name = "S_NumLabel"
        S_NumLabel.Size = New System.Drawing.Size(108, 20)
        S_NumLabel.TabIndex = 0
        S_NumLabel.Text = "Staff Number:"
        '
        'S_IDLabel
        '
        S_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_IDLabel.AutoSize = True
        S_IDLabel.Location = New System.Drawing.Point(311, 8)
        S_IDLabel.Name = "S_IDLabel"
        S_IDLabel.Size = New System.Drawing.Size(69, 20)
        S_IDLabel.TabIndex = 2
        S_IDLabel.Text = "Staff ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(3, 44)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(311, 44)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(3, 80)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(103, 20)
        Date_of_BirthLabel.TabIndex = 8
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Location = New System.Drawing.Point(311, 116)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(96, 20)
        PhoneNumLabel.TabIndex = 14
        PhoneNumLabel.Text = "Phone Num:"
        '
        'CurrentSalaryLabel
        '
        CurrentSalaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CurrentSalaryLabel.AutoSize = True
        CurrentSalaryLabel.Location = New System.Drawing.Point(3, 144)
        CurrentSalaryLabel.Name = "CurrentSalaryLabel"
        CurrentSalaryLabel.Size = New System.Drawing.Size(66, 36)
        CurrentSalaryLabel.TabIndex = 16
        CurrentSalaryLabel.Text = "Current Salary:"
        '
        'Address_IDLabel
        '
        Address_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Address_IDLabel.AutoSize = True
        Address_IDLabel.Location = New System.Drawing.Point(311, 225)
        Address_IDLabel.Name = "Address_IDLabel"
        Address_IDLabel.Size = New System.Drawing.Size(93, 20)
        Address_IDLabel.TabIndex = 20
        Address_IDLabel.Text = "Address ID:"
        '
        'Users_IDLabel
        '
        Users_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Users_IDLabel.AutoSize = True
        Users_IDLabel.Location = New System.Drawing.Point(311, 188)
        Users_IDLabel.Name = "Users_IDLabel"
        Users_IDLabel.Size = New System.Drawing.Size(76, 20)
        Users_IDLabel.TabIndex = 22
        Users_IDLabel.Text = "Users ID:"
        '
        'SexLabel
        '
        SexLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(311, 80)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(40, 20)
        SexLabel.TabIndex = 64
        SexLabel.Text = "Sex:"
        '
        'PositionLabel
        '
        PositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(3, 116)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(69, 20)
        PositionLabel.TabIndex = 65
        PositionLabel.Text = "Position:"
        '
        'SalaryScaleLabel
        '
        SalaryScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SalaryScaleLabel.AutoSize = True
        SalaryScaleLabel.Location = New System.Drawing.Point(311, 152)
        SalaryScaleLabel.Name = "SalaryScaleLabel"
        SalaryScaleLabel.Size = New System.Drawing.Size(101, 20)
        SalaryScaleLabel.TabIndex = 66
        SalaryScaleLabel.Text = "Salary Scale:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1390, 80)
        Me.Panel1.TabIndex = 59
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(203, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Staff Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox1.Location = New System.Drawing.Point(-96, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1047, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Param1ToolStripTextBox1)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1390, 81)
        Me.Panel2.TabIndex = 58
        '
        'Param1ToolStripTextBox1
        '
        Me.Param1ToolStripTextBox1.Location = New System.Drawing.Point(1178, 26)
        Me.Param1ToolStripTextBox1.Name = "Param1ToolStripTextBox1"
        Me.Param1ToolStripTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox1.TabIndex = 65
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.05512!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.02362!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.56979!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.51231!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.TableLayoutPanel1.Controls.Add(SalaryScaleLabel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SalaryScaleComboBox, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(PositionLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PositionComboBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(SexLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SexComboBox, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DOC_LU, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(S_NumLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.S_NumTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(S_IDLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.S_IDTextBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(First_NameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.First_NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Last_NameLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Last_NameTextBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Date_of_BirthLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_of_BirthDateTimePicker, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(PhoneNumLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneNumTextBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(CurrentSalaryLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CurrentSalaryTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Users_IDLabel, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Users_IDTextBox, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Address_IDLabel, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Address_IDTextBox, 3, 6)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 164)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(775, 254)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'SalaryScaleComboBox
        '
        Me.SalaryScaleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SalaryScaleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "SalaryScale", True))
        Me.SalaryScaleComboBox.FormattingEnabled = True
        Me.SalaryScaleComboBox.Items.AddRange(New Object() {"A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3"})
        Me.SalaryScaleComboBox.Location = New System.Drawing.Point(419, 151)
        Me.SalaryScaleComboBox.Name = "SalaryScaleComboBox"
        Me.SalaryScaleComboBox.Size = New System.Drawing.Size(194, 28)
        Me.SalaryScaleComboBox.TabIndex = 67
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
        'PositionComboBox
        '
        Me.PositionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PositionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Position", True))
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"Medical Doctor", "Charge Nurse", "Nurse", "Personnel Officer"})
        Me.PositionComboBox.Location = New System.Drawing.Point(120, 115)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(185, 28)
        Me.PositionComboBox.TabIndex = 66
        '
        'SexComboBox
        '
        Me.SexComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Sex", True))
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexComboBox.Location = New System.Drawing.Point(419, 79)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(194, 28)
        Me.SexComboBox.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(619, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 64
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DOC_LU
        '
        Me.DOC_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DOC_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.DOC_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DOC_LU.ForeColor = System.Drawing.Color.Transparent
        Me.DOC_LU.Location = New System.Drawing.Point(619, 186)
        Me.DOC_LU.Name = "DOC_LU"
        Me.DOC_LU.Size = New System.Drawing.Size(24, 23)
        Me.DOC_LU.TabIndex = 64
        Me.DOC_LU.UseVisualStyleBackColor = True
        '
        'S_NumTextBox
        '
        Me.S_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "S_Num", True))
        Me.S_NumTextBox.Location = New System.Drawing.Point(120, 5)
        Me.S_NumTextBox.Name = "S_NumTextBox"
        Me.S_NumTextBox.Size = New System.Drawing.Size(185, 26)
        Me.S_NumTextBox.TabIndex = 1
        '
        'S_IDTextBox
        '
        Me.S_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(419, 5)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(194, 26)
        Me.S_IDTextBox.TabIndex = 3
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(120, 41)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(185, 26)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(419, 41)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(194, 26)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'Date_of_BirthDateTimePicker
        '
        Me.Date_of_BirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffsBindingSource, "Date_of_Birth", True))
        Me.Date_of_BirthDateTimePicker.Location = New System.Drawing.Point(120, 77)
        Me.Date_of_BirthDateTimePicker.Name = "Date_of_BirthDateTimePicker"
        Me.Date_of_BirthDateTimePicker.Size = New System.Drawing.Size(185, 26)
        Me.Date_of_BirthDateTimePicker.TabIndex = 9
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(419, 113)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(194, 26)
        Me.PhoneNumTextBox.TabIndex = 15
        '
        'CurrentSalaryTextBox
        '
        Me.CurrentSalaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CurrentSalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "CurrentSalary", True))
        Me.CurrentSalaryTextBox.Location = New System.Drawing.Point(120, 149)
        Me.CurrentSalaryTextBox.Name = "CurrentSalaryTextBox"
        Me.CurrentSalaryTextBox.Size = New System.Drawing.Size(185, 26)
        Me.CurrentSalaryTextBox.TabIndex = 17
        '
        'Users_IDTextBox
        '
        Me.Users_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Users_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Users_ID", True))
        Me.Users_IDTextBox.Location = New System.Drawing.Point(419, 185)
        Me.Users_IDTextBox.Name = "Users_IDTextBox"
        Me.Users_IDTextBox.Size = New System.Drawing.Size(194, 26)
        Me.Users_IDTextBox.TabIndex = 23
        '
        'Address_IDTextBox
        '
        Me.Address_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffsBindingSource, "Address_ID", True))
        Me.Address_IDTextBox.Location = New System.Drawing.Point(419, 222)
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        Me.Address_IDTextBox.Size = New System.Drawing.Size(194, 26)
        Me.Address_IDTextBox.TabIndex = 21
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.48387!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.3871!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.UserBtn, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.AddrBtn, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Contractbtn, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.WEXSBtn, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button7, 4, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(737, 725)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(582, 64)
        Me.TableLayoutPanel3.TabIndex = 62
        '
        'UserBtn
        '
        Me.UserBtn.Location = New System.Drawing.Point(11, 11)
        Me.UserBtn.Margin = New System.Windows.Forms.Padding(11)
        Me.UserBtn.Name = "UserBtn"
        Me.UserBtn.Size = New System.Drawing.Size(91, 42)
        Me.UserBtn.TabIndex = 0
        Me.UserBtn.Text = "User"
        Me.UserBtn.UseVisualStyleBackColor = True
        '
        'AddrBtn
        '
        Me.AddrBtn.Location = New System.Drawing.Point(124, 11)
        Me.AddrBtn.Margin = New System.Windows.Forms.Padding(11)
        Me.AddrBtn.Name = "AddrBtn"
        Me.AddrBtn.Size = New System.Drawing.Size(96, 42)
        Me.AddrBtn.TabIndex = 1
        Me.AddrBtn.Text = "Address"
        Me.AddrBtn.UseVisualStyleBackColor = True
        '
        'Contractbtn
        '
        Me.Contractbtn.Location = New System.Drawing.Point(242, 11)
        Me.Contractbtn.Margin = New System.Windows.Forms.Padding(11)
        Me.Contractbtn.Name = "Contractbtn"
        Me.Contractbtn.Size = New System.Drawing.Size(94, 42)
        Me.Contractbtn.TabIndex = 2
        Me.Contractbtn.Text = "Employment Contract"
        Me.Contractbtn.UseVisualStyleBackColor = True
        '
        'WEXSBtn
        '
        Me.WEXSBtn.Location = New System.Drawing.Point(358, 11)
        Me.WEXSBtn.Margin = New System.Windows.Forms.Padding(11)
        Me.WEXSBtn.Name = "WEXSBtn"
        Me.WEXSBtn.Size = New System.Drawing.Size(94, 42)
        Me.WEXSBtn.TabIndex = 3
        Me.WEXSBtn.Text = "Work Experience"
        Me.WEXSBtn.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(474, 11)
        Me.Button7.Margin = New System.Windows.Forms.Padding(11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 42)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Qualification"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'StaffsDataGridView
        '
        Me.StaffsDataGridView.AutoGenerateColumns = False
        Me.StaffsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.StaffsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.StaffsDataGridView.DataSource = Me.StaffsBindingSource
        Me.StaffsDataGridView.Location = New System.Drawing.Point(76, 453)
        Me.StaffsDataGridView.Name = "StaffsDataGridView"
        Me.StaffsDataGridView.Size = New System.Drawing.Size(1243, 266)
        Me.StaffsDataGridView.TabIndex = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "S_Num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "S_Num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "S_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "S_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date_of_Birth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date_of_Birth"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PhoneNum"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PhoneNum"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CurrentSalary"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CurrentSalary"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SalaryScale"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SalaryScale"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Address_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Address_ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Users_ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Users_ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
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
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'StaffsBindingNavigator
        '
        Me.StaffsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffsBindingNavigator.BindingSource = Me.StaffsBindingSource
        Me.StaffsBindingNavigator.CountItem = Nothing
        Me.StaffsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.StaffsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.StaffsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.SuppliersBindingNavigatorSaveItem})
        Me.StaffsBindingNavigator.Location = New System.Drawing.Point(76, 421)
        Me.StaffsBindingNavigator.MoveFirstItem = Nothing
        Me.StaffsBindingNavigator.MoveLastItem = Nothing
        Me.StaffsBindingNavigator.MoveNextItem = Nothing
        Me.StaffsBindingNavigator.MovePreviousItem = Nothing
        Me.StaffsBindingNavigator.Name = "StaffsBindingNavigator"
        Me.StaffsBindingNavigator.PositionItem = Nothing
        Me.StaffsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.StaffsBindingNavigator.TabIndex = 64
        Me.StaffsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'SuppliersBindingNavigatorSaveItem
        '
        Me.SuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SuppliersBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.SuppliersBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SuppliersBindingNavigatorSaveItem.Name = "SuppliersBindingNavigatorSaveItem"
        Me.SuppliersBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.SuppliersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 791)
        Me.Controls.Add(Me.StaffsBindingNavigator)
        Me.Controls.Add(Me.StaffsDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Staff"
        Me.Text = "Staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.StaffsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffsBindingNavigator.ResumeLayout(False)
        Me.StaffsBindingNavigator.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents UserBtn As Button
    Friend WithEvents AddrBtn As Button
    Friend WithEvents Contractbtn As Button
    Friend WithEvents WEXSBtn As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents StaffsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents S_NumTextBox As TextBox
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Date_of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents CurrentSalaryTextBox As TextBox
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents Users_IDTextBox As TextBox
    Friend WithEvents StaffsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Param1ToolStripTextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DOC_LU As Button
    Friend WithEvents SalaryScaleComboBox As ComboBox
    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents StaffsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SuppliersBindingNavigatorSaveItem As ToolStripButton
End Class
