<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier
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
        Dim Supplier_noLabel As System.Windows.Forms.Label
        Dim Supplier_nameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim Fax_numberLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.StaffsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.StaffsTableAdapter()
        Me.SuppliersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuppliersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SuppliersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Supplier_noTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_numberTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Supplier_noLabel = New System.Windows.Forms.Label()
        Supplier_nameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        Fax_numberLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuppliersBindingNavigator.SuspendLayout()
        CType(Me.SuppliersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Supplier_noLabel
        '
        Supplier_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Supplier_noLabel.AutoSize = True
        Supplier_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Supplier_noLabel.Location = New System.Drawing.Point(3, 7)
        Supplier_noLabel.Name = "Supplier_noLabel"
        Supplier_noLabel.Size = New System.Drawing.Size(95, 20)
        Supplier_noLabel.TabIndex = 58
        Supplier_noLabel.Text = "Supplier No:"
        '
        'Supplier_nameLabel
        '
        Supplier_nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Supplier_nameLabel.AutoSize = True
        Supplier_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Supplier_nameLabel.Location = New System.Drawing.Point(3, 42)
        Supplier_nameLabel.Name = "Supplier_nameLabel"
        Supplier_nameLabel.Size = New System.Drawing.Size(117, 20)
        Supplier_nameLabel.TabIndex = 60
        Supplier_nameLabel.Text = "Supplier Name:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PhoneNumLabel.Location = New System.Drawing.Point(3, 77)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(119, 20)
        PhoneNumLabel.TabIndex = 62
        PhoneNumLabel.Text = "Phone Number:"
        AddHandler PhoneNumLabel.Click, AddressOf Me.PhoneNumLabel_Click
        '
        'Fax_numberLabel
        '
        Fax_numberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Fax_numberLabel.AutoSize = True
        Fax_numberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Fax_numberLabel.Location = New System.Drawing.Point(3, 113)
        Fax_numberLabel.Name = "Fax_numberLabel"
        Fax_numberLabel.Size = New System.Drawing.Size(99, 20)
        Fax_numberLabel.TabIndex = 64
        Fax_numberLabel.Text = "Fax Number:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 80)
        Me.Panel1.TabIndex = 57
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(99, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Supplier"
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
        Me.Panel2.Size = New System.Drawing.Size(666, 81)
        Me.Panel2.TabIndex = 56
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
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
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
        'StaffsTableAdapter
        '
        Me.StaffsTableAdapter.ClearBeforeFill = True
        '
        'SuppliersBindingNavigator
        '
        Me.SuppliersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SuppliersBindingNavigator.BindingSource = Me.SuppliersBindingSource
        Me.SuppliersBindingNavigator.CountItem = Nothing
        Me.SuppliersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SuppliersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SuppliersBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SuppliersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.SuppliersBindingNavigatorSaveItem})
        Me.SuppliersBindingNavigator.Location = New System.Drawing.Point(76, 309)
        Me.SuppliersBindingNavigator.MoveFirstItem = Nothing
        Me.SuppliersBindingNavigator.MoveLastItem = Nothing
        Me.SuppliersBindingNavigator.MoveNextItem = Nothing
        Me.SuppliersBindingNavigator.MovePreviousItem = Nothing
        Me.SuppliersBindingNavigator.Name = "SuppliersBindingNavigator"
        Me.SuppliersBindingNavigator.PositionItem = Nothing
        Me.SuppliersBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.SuppliersBindingNavigator.TabIndex = 58
        Me.SuppliersBindingNavigator.Text = "BindingNavigator1"
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
        'SuppliersDataGridView
        '
        Me.SuppliersDataGridView.AutoGenerateColumns = False
        Me.SuppliersDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppliersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SuppliersDataGridView.DataSource = Me.SuppliersBindingSource
        Me.SuppliersDataGridView.Location = New System.Drawing.Point(76, 341)
        Me.SuppliersDataGridView.Name = "SuppliersDataGridView"
        Me.SuppliersDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.SuppliersDataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "supplier_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "supplier_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "supplier_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "supplier_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PhoneNum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PhoneNum"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fax_number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fax_number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'StaffsBindingSource
        '
        Me.StaffsBindingSource.DataMember = "Staffs"
        Me.StaffsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'Supplier_noTextBox
        '
        Me.Supplier_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Supplier_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "supplier_no", True))
        Me.Supplier_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Supplier_noTextBox.Location = New System.Drawing.Point(135, 4)
        Me.Supplier_noTextBox.Name = "Supplier_noTextBox"
        Me.Supplier_noTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Supplier_noTextBox.TabIndex = 59
        '
        'Supplier_nameTextBox
        '
        Me.Supplier_nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Supplier_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "supplier_name", True))
        Me.Supplier_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Supplier_nameTextBox.Location = New System.Drawing.Point(135, 39)
        Me.Supplier_nameTextBox.Name = "Supplier_nameTextBox"
        Me.Supplier_nameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Supplier_nameTextBox.TabIndex = 61
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(135, 74)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PhoneNumTextBox.TabIndex = 63
        '
        'Fax_numberTextBox
        '
        Me.Fax_numberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Fax_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "fax_number", True))
        Me.Fax_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Fax_numberTextBox.Location = New System.Drawing.Point(135, 110)
        Me.Fax_numberTextBox.Name = "Fax_numberTextBox"
        Me.Fax_numberTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Fax_numberTextBox.TabIndex = 65
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.11679!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.88321!))
        Me.TableLayoutPanel1.Controls.Add(Supplier_noLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Supplier_noTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Supplier_nameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(PhoneNumLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Supplier_nameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Fax_numberLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Fax_numberTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneNumTextBox, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(411, 142)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Location = New System.Drawing.Point(454, 27)
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox.TabIndex = 68
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 581)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.SuppliersDataGridView)
        Me.Controls.Add(Me.SuppliersBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Supplier"
        Me.Text = "Supply"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuppliersBindingNavigator.ResumeLayout(False)
        Me.SuppliersBindingNavigator.PerformLayout()
        CType(Me.SuppliersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuppliersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SuppliersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.StaffsTableAdapter
    Friend WithEvents SuppliersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents StaffsBindingSource As BindingSource
    Friend WithEvents Supplier_noTextBox As TextBox
    Friend WithEvents Supplier_nameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents Fax_numberTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Param1ToolStripTextBox As TextBox
End Class
