<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Drug_Detail
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
        Dim DrugReqIDLabel As System.Windows.Forms.Label
        Dim Order_noLabel As System.Windows.Forms.Label
        Dim Drug_noLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DrugReqIDTextBox = New System.Windows.Forms.TextBox()
        Me.DrugReq_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseG26DataSet2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet2()
        Me.Order_noTextBox = New System.Windows.Forms.TextBox()
        Me.Drug_noTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Parma_LU = New System.Windows.Forms.Button()
        Me.DrugReq_DetailsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.DrugReq_DetailsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager()
        Me.DrugReq_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DrugReq_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DrugReq_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DrugReqIDLabel = New System.Windows.Forms.Label()
        Order_noLabel = New System.Windows.Forms.Label()
        Drug_noLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DrugReq_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugReq_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DrugReq_DetailsBindingNavigator.SuspendLayout()
        CType(Me.DrugReq_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrugReqIDLabel
        '
        DrugReqIDLabel.AutoSize = True
        DrugReqIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DrugReqIDLabel.Location = New System.Drawing.Point(3, 0)
        DrugReqIDLabel.Name = "DrugReqIDLabel"
        DrugReqIDLabel.Size = New System.Drawing.Size(152, 20)
        DrugReqIDLabel.TabIndex = 61
        DrugReqIDLabel.Text = "Drug Requisition ID:"
        '
        'Order_noLabel
        '
        Order_noLabel.AutoSize = True
        Order_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Order_noLabel.Location = New System.Drawing.Point(3, 32)
        Order_noLabel.Name = "Order_noLabel"
        Order_noLabel.Size = New System.Drawing.Size(75, 20)
        Order_noLabel.TabIndex = 63
        Order_noLabel.Text = "Order no:"
        '
        'Drug_noLabel
        '
        Drug_noLabel.AutoSize = True
        Drug_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Drug_noLabel.Location = New System.Drawing.Point(3, 64)
        Drug_noLabel.Name = "Drug_noLabel"
        Drug_noLabel.Size = New System.Drawing.Size(70, 20)
        Drug_noLabel.TabIndex = 65
        Drug_noLabel.Text = "Drug no:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        QuantityLabel.Location = New System.Drawing.Point(3, 96)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 67
        QuantityLabel.Text = "Quantity:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 80)
        Me.Panel1.TabIndex = 59
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(315, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Phamarcetical Request Form"
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
        Me.Panel2.Size = New System.Drawing.Size(962, 81)
        Me.Panel2.TabIndex = 58
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.58163!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.17347!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DrugReqIDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(DrugReqIDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Order_noTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Order_noLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Drug_noTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Drug_noLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.QuantityTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(QuantityLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Parma_LU, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 178)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(392, 130)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(346, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DrugReqIDTextBox
        '
        Me.DrugReqIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "DrugReqID", True))
        Me.DrugReqIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DrugReqIDTextBox.Location = New System.Drawing.Point(165, 3)
        Me.DrugReqIDTextBox.Name = "DrugReqIDTextBox"
        Me.DrugReqIDTextBox.Size = New System.Drawing.Size(175, 26)
        Me.DrugReqIDTextBox.TabIndex = 62
        '
        'DrugReq_DetailsBindingSource
        '
        Me.DrugReq_DetailsBindingSource.DataMember = "DrugReq_Details"
        Me.DrugReq_DetailsBindingSource.DataSource = Me.DatabaseG26DataSet2
        '
        'DatabaseG26DataSet2
        '
        Me.DatabaseG26DataSet2.DataSetName = "DatabaseG26DataSet2"
        Me.DatabaseG26DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_noTextBox
        '
        Me.Order_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "order_no", True))
        Me.Order_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Order_noTextBox.Location = New System.Drawing.Point(165, 35)
        Me.Order_noTextBox.Name = "Order_noTextBox"
        Me.Order_noTextBox.Size = New System.Drawing.Size(175, 26)
        Me.Order_noTextBox.TabIndex = 64
        '
        'Drug_noTextBox
        '
        Me.Drug_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "drug_no", True))
        Me.Drug_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Drug_noTextBox.Location = New System.Drawing.Point(165, 67)
        Me.Drug_noTextBox.Name = "Drug_noTextBox"
        Me.Drug_noTextBox.Size = New System.Drawing.Size(175, 26)
        Me.Drug_noTextBox.TabIndex = 66
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(165, 99)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(175, 26)
        Me.QuantityTextBox.TabIndex = 68
        '
        'Parma_LU
        '
        Me.Parma_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Parma_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Parma_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Parma_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Parma_LU.Location = New System.Drawing.Point(346, 68)
        Me.Parma_LU.Name = "Parma_LU"
        Me.Parma_LU.Size = New System.Drawing.Size(24, 23)
        Me.Parma_LU.TabIndex = 50
        Me.Parma_LU.UseVisualStyleBackColor = True
        '
        'DrugReq_DetailsTableAdapter
        '
        Me.DrugReq_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.Clinic_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.DrugReq_DetailsTableAdapter = Me.DrugReq_DetailsTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'DrugReq_DetailsBindingNavigator
        '
        Me.DrugReq_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DrugReq_DetailsBindingNavigator.BindingSource = Me.DrugReq_DetailsBindingSource
        Me.DrugReq_DetailsBindingNavigator.CountItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DrugReq_DetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.DrugReq_DetailsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DrugReq_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.DrugReq_DetailsBindingNavigatorSaveItem})
        Me.DrugReq_DetailsBindingNavigator.Location = New System.Drawing.Point(76, 321)
        Me.DrugReq_DetailsBindingNavigator.MoveFirstItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.MoveLastItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.MoveNextItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.MovePreviousItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.Name = "DrugReq_DetailsBindingNavigator"
        Me.DrugReq_DetailsBindingNavigator.PositionItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.DrugReq_DetailsBindingNavigator.TabIndex = 61
        Me.DrugReq_DetailsBindingNavigator.Text = "BindingNavigator1"
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
        'DrugReq_DetailsBindingNavigatorSaveItem
        '
        Me.DrugReq_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.DrugReq_DetailsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Name = "DrugReq_DetailsBindingNavigatorSaveItem"
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DrugReq_DetailsDataGridView
        '
        Me.DrugReq_DetailsDataGridView.AutoGenerateColumns = False
        Me.DrugReq_DetailsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DrugReq_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrugReq_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DrugReq_DetailsDataGridView.DataSource = Me.DrugReq_DetailsBindingSource
        Me.DrugReq_DetailsDataGridView.Location = New System.Drawing.Point(76, 370)
        Me.DrugReq_DetailsDataGridView.Name = "DrugReq_DetailsDataGridView"
        Me.DrugReq_DetailsDataGridView.Size = New System.Drawing.Size(445, 130)
        Me.DrugReq_DetailsDataGridView.TabIndex = 61
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DrugReqID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DrugReqID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "order_no"
        Me.DataGridViewTextBoxColumn2.HeaderText = "order_no"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "drug_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "drug_no"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Drug_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 934)
        Me.Controls.Add(Me.DrugReq_DetailsDataGridView)
        Me.Controls.Add(Me.DrugReq_DetailsBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Drug_Detail"
        Me.Text = "Drug_Detail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DrugReq_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugReq_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DrugReq_DetailsBindingNavigator.ResumeLayout(False)
        Me.DrugReq_DetailsBindingNavigator.PerformLayout()
        CType(Me.DrugReq_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Parma_LU As Button
    Friend WithEvents DatabaseG26DataSet2 As DatabaseG26DataSet2
    Friend WithEvents DrugReq_DetailsBindingSource As BindingSource
    Friend WithEvents DrugReq_DetailsTableAdapter As DatabaseG26DataSet2TableAdapters.DrugReq_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents DrugReq_DetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DrugReq_DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DrugReqIDTextBox As TextBox
    Friend WithEvents Order_noTextBox As TextBox
    Friend WithEvents Drug_noTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents DrugReq_DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
