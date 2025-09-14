<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medication_Head
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
        Dim Medication_noLabel As System.Windows.Forms.Label
        Dim Order_dateLabel As System.Windows.Forms.Label
        Dim S_numLabel As System.Windows.Forms.Label
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim W_NumLabel As System.Windows.Forms.Label
        Dim Clinic_NumLabel As System.Windows.Forms.Label
        Me.DatabaseG26DataSet2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet2()
        Me.Medication_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medication_HeadTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.Medication_HeadTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager()
        Me.Medication_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Medication_HeadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Medication_noTextBox = New System.Windows.Forms.TextBox()
        Me.Order_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_numTextBox = New System.Windows.Forms.TextBox()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.W_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Medication_HeadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medic_detail = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.P_LU = New System.Windows.Forms.Button()
        Me.S_LU = New System.Windows.Forms.Button()
        Me.Cli_LU = New System.Windows.Forms.Button()
        Me.W_LU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Medication_noLabel = New System.Windows.Forms.Label()
        Order_dateLabel = New System.Windows.Forms.Label()
        S_numLabel = New System.Windows.Forms.Label()
        P_NumLabel = New System.Windows.Forms.Label()
        W_NumLabel = New System.Windows.Forms.Label()
        Clinic_NumLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medication_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medication_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Medication_HeadBindingNavigator.SuspendLayout()
        CType(Me.Medication_HeadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Medication_noLabel
        '
        Medication_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Medication_noLabel.AutoSize = True
        Medication_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Medication_noLabel.Location = New System.Drawing.Point(3, 7)
        Medication_noLabel.Name = "Medication_noLabel"
        Medication_noLabel.Size = New System.Drawing.Size(112, 20)
        Medication_noLabel.TabIndex = 38
        Medication_noLabel.Text = "Medication no:"
        '
        'Order_dateLabel
        '
        Order_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Order_dateLabel.AutoSize = True
        Order_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Order_dateLabel.Location = New System.Drawing.Point(3, 42)
        Order_dateLabel.Name = "Order_dateLabel"
        Order_dateLabel.Size = New System.Drawing.Size(92, 20)
        Order_dateLabel.TabIndex = 40
        Order_dateLabel.Text = "Order Date:"
        '
        'S_numLabel
        '
        S_numLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_numLabel.AutoSize = True
        S_numLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_numLabel.Location = New System.Drawing.Point(3, 77)
        S_numLabel.Name = "S_numLabel"
        S_numLabel.Size = New System.Drawing.Size(108, 20)
        S_numLabel.TabIndex = 42
        S_numLabel.Text = "Staff Number:"
        '
        'P_NumLabel
        '
        P_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_NumLabel.AutoSize = True
        P_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_NumLabel.Location = New System.Drawing.Point(3, 112)
        P_NumLabel.Name = "P_NumLabel"
        P_NumLabel.Size = New System.Drawing.Size(123, 20)
        P_NumLabel.TabIndex = 44
        P_NumLabel.Text = "Patient Number:"
        '
        'W_NumLabel
        '
        W_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        W_NumLabel.AutoSize = True
        W_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        W_NumLabel.Location = New System.Drawing.Point(3, 147)
        W_NumLabel.Name = "W_NumLabel"
        W_NumLabel.Size = New System.Drawing.Size(111, 20)
        W_NumLabel.TabIndex = 46
        W_NumLabel.Text = "Ward Number:"
        '
        'Clinic_NumLabel
        '
        Clinic_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Clinic_NumLabel.AutoSize = True
        Clinic_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Clinic_NumLabel.Location = New System.Drawing.Point(3, 183)
        Clinic_NumLabel.Name = "Clinic_NumLabel"
        Clinic_NumLabel.Size = New System.Drawing.Size(87, 20)
        Clinic_NumLabel.TabIndex = 48
        Clinic_NumLabel.Text = "Clinic Num:"
        '
        'DatabaseG26DataSet2
        '
        Me.DatabaseG26DataSet2.DataSetName = "DatabaseG26DataSet2"
        Me.DatabaseG26DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Medication_HeadBindingSource
        '
        Me.Medication_HeadBindingSource.DataMember = "Medication_Head"
        Me.Medication_HeadBindingSource.DataSource = Me.DatabaseG26DataSet2
        '
        'Medication_HeadTableAdapter
        '
        Me.Medication_HeadTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Medication_HeadTableAdapter = Me.Medication_HeadTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Medication_HeadBindingNavigator
        '
        Me.Medication_HeadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Medication_HeadBindingNavigator.BindingSource = Me.Medication_HeadBindingSource
        Me.Medication_HeadBindingNavigator.CountItem = Nothing
        Me.Medication_HeadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Medication_HeadBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Medication_HeadBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Medication_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.Medication_HeadBindingNavigatorSaveItem})
        Me.Medication_HeadBindingNavigator.Location = New System.Drawing.Point(76, 415)
        Me.Medication_HeadBindingNavigator.MoveFirstItem = Nothing
        Me.Medication_HeadBindingNavigator.MoveLastItem = Nothing
        Me.Medication_HeadBindingNavigator.MoveNextItem = Nothing
        Me.Medication_HeadBindingNavigator.MovePreviousItem = Nothing
        Me.Medication_HeadBindingNavigator.Name = "Medication_HeadBindingNavigator"
        Me.Medication_HeadBindingNavigator.PositionItem = Nothing
        Me.Medication_HeadBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Medication_HeadBindingNavigator.TabIndex = 38
        Me.Medication_HeadBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'Medication_HeadBindingNavigatorSaveItem
        '
        Me.Medication_HeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Medication_HeadBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Medication_HeadBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Medication_HeadBindingNavigatorSaveItem.Name = "Medication_HeadBindingNavigatorSaveItem"
        Me.Medication_HeadBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Medication_HeadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Medication_noTextBox
        '
        Me.Medication_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Medication_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_HeadBindingSource, "medication_no", True))
        Me.Medication_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Medication_noTextBox.Location = New System.Drawing.Point(141, 4)
        Me.Medication_noTextBox.Name = "Medication_noTextBox"
        Me.Medication_noTextBox.Size = New System.Drawing.Size(195, 26)
        Me.Medication_noTextBox.TabIndex = 39
        '
        'Order_dateDateTimePicker
        '
        Me.Order_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Order_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Medication_HeadBindingSource, "order_date", True))
        Me.Order_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Order_dateDateTimePicker.Location = New System.Drawing.Point(141, 39)
        Me.Order_dateDateTimePicker.Name = "Order_dateDateTimePicker"
        Me.Order_dateDateTimePicker.Size = New System.Drawing.Size(195, 26)
        Me.Order_dateDateTimePicker.TabIndex = 41
        '
        'S_numTextBox
        '
        Me.S_numTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_HeadBindingSource, "S_num", True))
        Me.S_numTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_numTextBox.Location = New System.Drawing.Point(141, 74)
        Me.S_numTextBox.Name = "S_numTextBox"
        Me.S_numTextBox.Size = New System.Drawing.Size(195, 26)
        Me.S_numTextBox.TabIndex = 43
        '
        'P_NumTextBox
        '
        Me.P_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_HeadBindingSource, "P_Num", True))
        Me.P_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_NumTextBox.Location = New System.Drawing.Point(141, 109)
        Me.P_NumTextBox.Name = "P_NumTextBox"
        Me.P_NumTextBox.Size = New System.Drawing.Size(195, 26)
        Me.P_NumTextBox.TabIndex = 45
        '
        'W_NumTextBox
        '
        Me.W_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.W_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_HeadBindingSource, "W_Num", True))
        Me.W_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.W_NumTextBox.Location = New System.Drawing.Point(141, 144)
        Me.W_NumTextBox.Name = "W_NumTextBox"
        Me.W_NumTextBox.Size = New System.Drawing.Size(195, 26)
        Me.W_NumTextBox.TabIndex = 47
        '
        'Clinic_NumTextBox
        '
        Me.Clinic_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Clinic_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_HeadBindingSource, "Clinic_Num", True))
        Me.Clinic_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Clinic_NumTextBox.Location = New System.Drawing.Point(141, 180)
        Me.Clinic_NumTextBox.Name = "Clinic_NumTextBox"
        Me.Clinic_NumTextBox.Size = New System.Drawing.Size(195, 26)
        Me.Clinic_NumTextBox.TabIndex = 49
        '
        'Medication_HeadDataGridView
        '
        Me.Medication_HeadDataGridView.AutoGenerateColumns = False
        Me.Medication_HeadDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Medication_HeadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Medication_HeadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Medication_HeadDataGridView.DataSource = Me.Medication_HeadBindingSource
        Me.Medication_HeadDataGridView.Location = New System.Drawing.Point(76, 461)
        Me.Medication_HeadDataGridView.Name = "Medication_HeadDataGridView"
        Me.Medication_HeadDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.Medication_HeadDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "medication_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "medication_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "order_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "order_date"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "P_Num"
        Me.DataGridViewTextBoxColumn4.HeaderText = "P_Num"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "W_Num"
        Me.DataGridViewTextBoxColumn5.HeaderText = "W_Num"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Clinic_Num"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Clinic_Num"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Medic_detail
        '
        Me.Medic_detail.Location = New System.Drawing.Point(604, 698)
        Me.Medic_detail.Name = "Medic_detail"
        Me.Medic_detail.Size = New System.Drawing.Size(115, 40)
        Me.Medic_detail.TabIndex = 53
        Me.Medic_detail.Text = "Medical Item Requisition"
        Me.Medic_detail.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.74083!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87775!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.13692!))
        Me.TableLayoutPanel1.Controls.Add(Me.Medication_noTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Clinic_NumLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(W_NumLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(P_NumLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(S_numLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Order_dateLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Medication_noLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Order_dateDateTimePicker, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.S_numTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.P_NumTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.W_NumTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Clinic_NumTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.P_LU, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.S_LU, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Cli_LU, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.W_LU, 2, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 180)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(409, 212)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'P_LU
        '
        Me.P_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.P_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_LU.ForeColor = System.Drawing.Color.Transparent
        Me.P_LU.Location = New System.Drawing.Point(345, 111)
        Me.P_LU.Name = "P_LU"
        Me.P_LU.Size = New System.Drawing.Size(24, 23)
        Me.P_LU.TabIndex = 53
        Me.P_LU.UseVisualStyleBackColor = True
        '
        'S_LU
        '
        Me.S_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.S_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_LU.ForeColor = System.Drawing.Color.Transparent
        Me.S_LU.Location = New System.Drawing.Point(345, 76)
        Me.S_LU.Name = "S_LU"
        Me.S_LU.Size = New System.Drawing.Size(24, 23)
        Me.S_LU.TabIndex = 54
        Me.S_LU.UseVisualStyleBackColor = True
        '
        'Cli_LU
        '
        Me.Cli_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cli_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Cli_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cli_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Cli_LU.Location = New System.Drawing.Point(345, 182)
        Me.Cli_LU.Name = "Cli_LU"
        Me.Cli_LU.Size = New System.Drawing.Size(24, 23)
        Me.Cli_LU.TabIndex = 50
        Me.Cli_LU.UseVisualStyleBackColor = True
        '
        'W_LU
        '
        Me.W_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.W_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.W_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.W_LU.ForeColor = System.Drawing.Color.Transparent
        Me.W_LU.Location = New System.Drawing.Point(345, 146)
        Me.W_LU.Name = "W_LU"
        Me.W_LU.Size = New System.Drawing.Size(24, 23)
        Me.W_LU.TabIndex = 52
        Me.W_LU.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 80)
        Me.Panel1.TabIndex = 68
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(234, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Medication Requition"
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
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 81)
        Me.Panel2.TabIndex = 67
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
        'Medication_Head
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 777)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Medic_detail)
        Me.Controls.Add(Me.Medication_HeadDataGridView)
        Me.Controls.Add(Me.Medication_HeadBindingNavigator)
        Me.Name = "Medication_Head"
        Me.Text = "Patient Medication"
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medication_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medication_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Medication_HeadBindingNavigator.ResumeLayout(False)
        Me.Medication_HeadBindingNavigator.PerformLayout()
        CType(Me.Medication_HeadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseG26DataSet2 As DatabaseG26DataSet2
    Friend WithEvents Medication_HeadBindingSource As BindingSource
    Friend WithEvents Medication_HeadTableAdapter As DatabaseG26DataSet2TableAdapters.Medication_HeadTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Medication_HeadBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Medication_HeadBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Medication_noTextBox As TextBox
    Friend WithEvents Order_dateDateTimePicker As DateTimePicker
    Friend WithEvents S_numTextBox As TextBox
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents W_NumTextBox As TextBox
    Friend WithEvents Clinic_NumTextBox As TextBox
    Friend WithEvents Medication_HeadDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Medic_detail As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cli_LU As Button
    Friend WithEvents W_LU As Button
    Friend WithEvents P_LU As Button
    Friend WithEvents S_LU As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
