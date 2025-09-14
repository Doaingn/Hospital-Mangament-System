<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClinicShift
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
        Dim Rota_IDLabel As System.Windows.Forms.Label
        Dim Date_of_ShiftLabel As System.Windows.Forms.Label
        Dim S_numLabel As System.Windows.Forms.Label
        Dim Clinic_NumLabel As System.Windows.Forms.Label
        Dim Shift_IDLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Rota_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_Shift_RotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Date_of_ShiftDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SH_LU = New System.Windows.Forms.Button()
        Me.Cli_LU = New System.Windows.Forms.Button()
        Me.St_LU = New System.Windows.Forms.Button()
        Me.S_numTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Shift_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Clinic_Shift_RotasTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Clinic_Shift_RotasTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Clinic_Shift_RotasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Clinic_Shift_RotasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Rota_IDLabel = New System.Windows.Forms.Label()
        Date_of_ShiftLabel = New System.Windows.Forms.Label()
        S_numLabel = New System.Windows.Forms.Label()
        Clinic_NumLabel = New System.Windows.Forms.Label()
        Shift_IDLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Clinic_Shift_RotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clinic_Shift_RotasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clinic_Shift_RotasBindingNavigator.SuspendLayout()
        CType(Me.Clinic_Shift_RotasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rota_IDLabel
        '
        Rota_IDLabel.AutoSize = True
        Rota_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Rota_IDLabel.Location = New System.Drawing.Point(3, 0)
        Rota_IDLabel.Name = "Rota_IDLabel"
        Rota_IDLabel.Size = New System.Drawing.Size(69, 20)
        Rota_IDLabel.TabIndex = 0
        Rota_IDLabel.Text = "Rota ID:"
        '
        'Date_of_ShiftLabel
        '
        Date_of_ShiftLabel.AutoSize = True
        Date_of_ShiftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_of_ShiftLabel.Location = New System.Drawing.Point(3, 28)
        Date_of_ShiftLabel.Name = "Date_of_ShiftLabel"
        Date_of_ShiftLabel.Size = New System.Drawing.Size(103, 20)
        Date_of_ShiftLabel.TabIndex = 2
        Date_of_ShiftLabel.Text = "Date of Shift:"
        '
        'S_numLabel
        '
        S_numLabel.AutoSize = True
        S_numLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_numLabel.Location = New System.Drawing.Point(3, 56)
        S_numLabel.Name = "S_numLabel"
        S_numLabel.Size = New System.Drawing.Size(108, 20)
        S_numLabel.TabIndex = 4
        S_numLabel.Text = "Staff Number:"
        '
        'Clinic_NumLabel
        '
        Clinic_NumLabel.AutoSize = True
        Clinic_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Clinic_NumLabel.Location = New System.Drawing.Point(3, 84)
        Clinic_NumLabel.Name = "Clinic_NumLabel"
        Clinic_NumLabel.Size = New System.Drawing.Size(87, 20)
        Clinic_NumLabel.TabIndex = 6
        Clinic_NumLabel.Text = "Clinic Num:"
        '
        'Shift_IDLabel
        '
        Shift_IDLabel.AutoSize = True
        Shift_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Shift_IDLabel.Location = New System.Drawing.Point(3, 112)
        Shift_IDLabel.Name = "Shift_IDLabel"
        Shift_IDLabel.Size = New System.Drawing.Size(67, 20)
        Shift_IDLabel.TabIndex = 8
        Shift_IDLabel.Text = "Shift ID:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.07692!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.92308!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.Controls.Add(Rota_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Rota_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Date_of_ShiftLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_of_ShiftDateTimePicker, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(S_numLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SH_LU, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Cli_LU, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.St_LU, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.S_numTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Clinic_NumLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Clinic_NumTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Shift_IDLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Shift_IDTextBox, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 173)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.12987!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(371, 144)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'Rota_IDTextBox
        '
        Me.Rota_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clinic_Shift_RotasBindingSource, "Rota_ID", True))
        Me.Rota_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rota_IDTextBox.Location = New System.Drawing.Point(128, 3)
        Me.Rota_IDTextBox.Name = "Rota_IDTextBox"
        Me.Rota_IDTextBox.Size = New System.Drawing.Size(190, 26)
        Me.Rota_IDTextBox.TabIndex = 1
        '
        'Clinic_Shift_RotasBindingSource
        '
        Me.Clinic_Shift_RotasBindingSource.DataMember = "Clinic_Shift_Rotas"
        Me.Clinic_Shift_RotasBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Date_of_ShiftDateTimePicker
        '
        Me.Date_of_ShiftDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Clinic_Shift_RotasBindingSource, "Date_of_Shift", True))
        Me.Date_of_ShiftDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_of_ShiftDateTimePicker.Location = New System.Drawing.Point(128, 31)
        Me.Date_of_ShiftDateTimePicker.Name = "Date_of_ShiftDateTimePicker"
        Me.Date_of_ShiftDateTimePicker.Size = New System.Drawing.Size(190, 26)
        Me.Date_of_ShiftDateTimePicker.TabIndex = 3
        '
        'SH_LU
        '
        Me.SH_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SH_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.SH_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SH_LU.ForeColor = System.Drawing.Color.Transparent
        Me.SH_LU.Location = New System.Drawing.Point(324, 116)
        Me.SH_LU.Name = "SH_LU"
        Me.SH_LU.Size = New System.Drawing.Size(24, 23)
        Me.SH_LU.TabIndex = 62
        Me.SH_LU.UseVisualStyleBackColor = True
        '
        'Cli_LU
        '
        Me.Cli_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cli_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Cli_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cli_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Cli_LU.Location = New System.Drawing.Point(324, 87)
        Me.Cli_LU.Name = "Cli_LU"
        Me.Cli_LU.Size = New System.Drawing.Size(24, 22)
        Me.Cli_LU.TabIndex = 61
        Me.Cli_LU.UseVisualStyleBackColor = True
        '
        'St_LU
        '
        Me.St_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.St_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.St_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.St_LU.ForeColor = System.Drawing.Color.Transparent
        Me.St_LU.Location = New System.Drawing.Point(324, 59)
        Me.St_LU.Name = "St_LU"
        Me.St_LU.Size = New System.Drawing.Size(24, 22)
        Me.St_LU.TabIndex = 63
        Me.St_LU.UseVisualStyleBackColor = True
        '
        'S_numTextBox
        '
        Me.S_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clinic_Shift_RotasBindingSource, "S_num", True))
        Me.S_numTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_numTextBox.Location = New System.Drawing.Point(128, 59)
        Me.S_numTextBox.Name = "S_numTextBox"
        Me.S_numTextBox.Size = New System.Drawing.Size(190, 26)
        Me.S_numTextBox.TabIndex = 5
        '
        'Clinic_NumTextBox
        '
        Me.Clinic_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clinic_Shift_RotasBindingSource, "Clinic_Num", True))
        Me.Clinic_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Clinic_NumTextBox.Location = New System.Drawing.Point(128, 87)
        Me.Clinic_NumTextBox.Name = "Clinic_NumTextBox"
        Me.Clinic_NumTextBox.Size = New System.Drawing.Size(190, 26)
        Me.Clinic_NumTextBox.TabIndex = 7
        '
        'Shift_IDTextBox
        '
        Me.Shift_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clinic_Shift_RotasBindingSource, "Shift_ID", True))
        Me.Shift_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Shift_IDTextBox.Location = New System.Drawing.Point(128, 115)
        Me.Shift_IDTextBox.Name = "Shift_IDTextBox"
        Me.Shift_IDTextBox.Size = New System.Drawing.Size(190, 26)
        Me.Shift_IDTextBox.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 80)
        Me.Panel1.TabIndex = 62
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(182, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Clinic Shift Rota"
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
        Me.Panel2.Size = New System.Drawing.Size(696, 81)
        Me.Panel2.TabIndex = 61
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
        'Clinic_Shift_RotasTableAdapter
        '
        Me.Clinic_Shift_RotasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.Clinic_Shift_RotasTableAdapter = Me.Clinic_Shift_RotasTableAdapter
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
        'Clinic_Shift_RotasBindingNavigator
        '
        Me.Clinic_Shift_RotasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Clinic_Shift_RotasBindingNavigator.BindingSource = Me.Clinic_Shift_RotasBindingSource
        Me.Clinic_Shift_RotasBindingNavigator.CountItem = Nothing
        Me.Clinic_Shift_RotasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Clinic_Shift_RotasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Clinic_Shift_RotasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Clinic_Shift_RotasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.Clinic_Shift_RotasBindingNavigatorSaveItem})
        Me.Clinic_Shift_RotasBindingNavigator.Location = New System.Drawing.Point(76, 320)
        Me.Clinic_Shift_RotasBindingNavigator.MoveFirstItem = Nothing
        Me.Clinic_Shift_RotasBindingNavigator.MoveLastItem = Nothing
        Me.Clinic_Shift_RotasBindingNavigator.MoveNextItem = Nothing
        Me.Clinic_Shift_RotasBindingNavigator.MovePreviousItem = Nothing
        Me.Clinic_Shift_RotasBindingNavigator.Name = "Clinic_Shift_RotasBindingNavigator"
        Me.Clinic_Shift_RotasBindingNavigator.PositionItem = Nothing
        Me.Clinic_Shift_RotasBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Clinic_Shift_RotasBindingNavigator.TabIndex = 64
        Me.Clinic_Shift_RotasBindingNavigator.Text = "BindingNavigator1"
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
        'Clinic_Shift_RotasBindingNavigatorSaveItem
        '
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem.Name = "Clinic_Shift_RotasBindingNavigatorSaveItem"
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Clinic_Shift_RotasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Clinic_Shift_RotasDataGridView
        '
        Me.Clinic_Shift_RotasDataGridView.AutoGenerateColumns = False
        Me.Clinic_Shift_RotasDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Clinic_Shift_RotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clinic_Shift_RotasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Clinic_Shift_RotasDataGridView.DataSource = Me.Clinic_Shift_RotasBindingSource
        Me.Clinic_Shift_RotasDataGridView.Location = New System.Drawing.Point(76, 352)
        Me.Clinic_Shift_RotasDataGridView.Name = "Clinic_Shift_RotasDataGridView"
        Me.Clinic_Shift_RotasDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.Clinic_Shift_RotasDataGridView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Rota_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rota_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date_of_Shift"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date_of_Shift"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "S_num"
        Me.DataGridViewTextBoxColumn3.HeaderText = "S_num"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Clinic_Num"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Clinic_Num"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Shift_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Shift_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Location = New System.Drawing.Point(484, 26)
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox.TabIndex = 66
        '
        'ClinicShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 670)
        Me.Controls.Add(Me.Clinic_Shift_RotasDataGridView)
        Me.Controls.Add(Me.Clinic_Shift_RotasBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ClinicShift"
        Me.Text = "ClinicShift"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Clinic_Shift_RotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clinic_Shift_RotasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clinic_Shift_RotasBindingNavigator.ResumeLayout(False)
        Me.Clinic_Shift_RotasBindingNavigator.PerformLayout()
        CType(Me.Clinic_Shift_RotasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cli_LU As Button
    Friend WithEvents SH_LU As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents St_LU As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Clinic_Shift_RotasBindingSource As BindingSource
    Friend WithEvents Clinic_Shift_RotasTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Clinic_Shift_RotasTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Clinic_Shift_RotasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Clinic_Shift_RotasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Rota_IDTextBox As TextBox
    Friend WithEvents Date_of_ShiftDateTimePicker As DateTimePicker
    Friend WithEvents S_numTextBox As TextBox
    Friend WithEvents Clinic_NumTextBox As TextBox
    Friend WithEvents Shift_IDTextBox As TextBox
    Friend WithEvents Clinic_Shift_RotasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Param1ToolStripTextBox As TextBox
End Class
