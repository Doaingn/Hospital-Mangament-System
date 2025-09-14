<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Out_patient_clinic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Out_patient_clinic))
        Dim Clinic_NumLabel As System.Windows.Forms.Label
        Dim Clinic_NameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Telephone_ExtLabel As System.Windows.Forms.Label
        Dim Charge_NurseLabel As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatabaseG26DataSet = New WellMeadows_Hospital_G26.DatabaseG26DataSet()
        Me.Outpatient_ClinicsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Outpatient_ClinicsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.Outpatient_ClinicsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Outpatient_ClinicsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Outpatient_ClinicsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Clinic_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_NameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_ExtTextBox = New System.Windows.Forms.TextBox()
        Me.Charge_NurseTextBox = New System.Windows.Forms.TextBox()
        Me.Outpatient_ClinicsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Clinic_NumLabel = New System.Windows.Forms.Label()
        Clinic_NameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Telephone_ExtLabel = New System.Windows.Forms.Label()
        Charge_NurseLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Outpatient_ClinicsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Outpatient_ClinicsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Outpatient_ClinicsBindingNavigator.SuspendLayout()
        CType(Me.Outpatient_ClinicsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(823, 81)
        Me.Panel2.TabIndex = 42
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 78)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(120, 46)
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
        Me.Label1.Location = New System.Drawing.Point(118, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wellmeadows Hospital"
        '
        'DatabaseG26DataSet
        '
        Me.DatabaseG26DataSet.DataSetName = "DatabaseG26DataSet"
        Me.DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Outpatient_ClinicsBindingSource
        '
        Me.Outpatient_ClinicsBindingSource.DataMember = "Outpatient_Clinics"
        Me.Outpatient_ClinicsBindingSource.DataSource = Me.DatabaseG26DataSet
        '
        'Outpatient_ClinicsTableAdapter
        '
        Me.Outpatient_ClinicsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Outpatient_ClinicsTableAdapter = Me.Outpatient_ClinicsTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Outpatient_ClinicsBindingNavigator
        '
        Me.Outpatient_ClinicsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Outpatient_ClinicsBindingNavigator.BindingSource = Me.Outpatient_ClinicsBindingSource
        Me.Outpatient_ClinicsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Outpatient_ClinicsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Outpatient_ClinicsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Outpatient_ClinicsBindingNavigatorSaveItem})
        Me.Outpatient_ClinicsBindingNavigator.Location = New System.Drawing.Point(0, 81)
        Me.Outpatient_ClinicsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Outpatient_ClinicsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Outpatient_ClinicsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Outpatient_ClinicsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Outpatient_ClinicsBindingNavigator.Name = "Outpatient_ClinicsBindingNavigator"
        Me.Outpatient_ClinicsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Outpatient_ClinicsBindingNavigator.Size = New System.Drawing.Size(823, 25)
        Me.Outpatient_ClinicsBindingNavigator.TabIndex = 43
        Me.Outpatient_ClinicsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Outpatient_ClinicsBindingNavigatorSaveItem
        '
        Me.Outpatient_ClinicsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Outpatient_ClinicsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Outpatient_ClinicsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Outpatient_ClinicsBindingNavigatorSaveItem.Name = "Outpatient_ClinicsBindingNavigatorSaveItem"
        Me.Outpatient_ClinicsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Outpatient_ClinicsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Clinic_NumLabel
        '
        Clinic_NumLabel.AutoSize = True
        Clinic_NumLabel.Location = New System.Drawing.Point(292, 183)
        Clinic_NumLabel.Name = "Clinic_NumLabel"
        Clinic_NumLabel.Size = New System.Drawing.Size(60, 13)
        Clinic_NumLabel.TabIndex = 43
        Clinic_NumLabel.Text = "Clinic Num:"
        '
        'Clinic_NumTextBox
        '
        Me.Clinic_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Outpatient_ClinicsBindingSource, "Clinic_Num", True))
        Me.Clinic_NumTextBox.Location = New System.Drawing.Point(377, 180)
        Me.Clinic_NumTextBox.Name = "Clinic_NumTextBox"
        Me.Clinic_NumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Clinic_NumTextBox.TabIndex = 44
        '
        'Clinic_NameLabel
        '
        Clinic_NameLabel.AutoSize = True
        Clinic_NameLabel.Location = New System.Drawing.Point(292, 209)
        Clinic_NameLabel.Name = "Clinic_NameLabel"
        Clinic_NameLabel.Size = New System.Drawing.Size(66, 13)
        Clinic_NameLabel.TabIndex = 45
        Clinic_NameLabel.Text = "Clinic Name:"
        '
        'Clinic_NameTextBox
        '
        Me.Clinic_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Outpatient_ClinicsBindingSource, "Clinic_Name", True))
        Me.Clinic_NameTextBox.Location = New System.Drawing.Point(377, 206)
        Me.Clinic_NameTextBox.Name = "Clinic_NameTextBox"
        Me.Clinic_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Clinic_NameTextBox.TabIndex = 46
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(292, 235)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 47
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Outpatient_ClinicsBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(377, 232)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationTextBox.TabIndex = 48
        '
        'Telephone_ExtLabel
        '
        Telephone_ExtLabel.AutoSize = True
        Telephone_ExtLabel.Location = New System.Drawing.Point(292, 261)
        Telephone_ExtLabel.Name = "Telephone_ExtLabel"
        Telephone_ExtLabel.Size = New System.Drawing.Size(79, 13)
        Telephone_ExtLabel.TabIndex = 49
        Telephone_ExtLabel.Text = "Telephone Ext:"
        '
        'Telephone_ExtTextBox
        '
        Me.Telephone_ExtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Outpatient_ClinicsBindingSource, "Telephone_Ext", True))
        Me.Telephone_ExtTextBox.Location = New System.Drawing.Point(377, 258)
        Me.Telephone_ExtTextBox.Name = "Telephone_ExtTextBox"
        Me.Telephone_ExtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telephone_ExtTextBox.TabIndex = 50
        '
        'Charge_NurseLabel
        '
        Charge_NurseLabel.AutoSize = True
        Charge_NurseLabel.Location = New System.Drawing.Point(292, 287)
        Charge_NurseLabel.Name = "Charge_NurseLabel"
        Charge_NurseLabel.Size = New System.Drawing.Size(75, 13)
        Charge_NurseLabel.TabIndex = 51
        Charge_NurseLabel.Text = "Charge Nurse:"
        '
        'Charge_NurseTextBox
        '
        Me.Charge_NurseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Outpatient_ClinicsBindingSource, "Charge_Nurse", True))
        Me.Charge_NurseTextBox.Location = New System.Drawing.Point(377, 284)
        Me.Charge_NurseTextBox.Name = "Charge_NurseTextBox"
        Me.Charge_NurseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Charge_NurseTextBox.TabIndex = 52
        '
        'Outpatient_ClinicsDataGridView
        '
        Me.Outpatient_ClinicsDataGridView.AutoGenerateColumns = False
        Me.Outpatient_ClinicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Outpatient_ClinicsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Outpatient_ClinicsDataGridView.DataSource = Me.Outpatient_ClinicsBindingSource
        Me.Outpatient_ClinicsDataGridView.Location = New System.Drawing.Point(123, 371)
        Me.Outpatient_ClinicsDataGridView.Name = "Outpatient_ClinicsDataGridView"
        Me.Outpatient_ClinicsDataGridView.Size = New System.Drawing.Size(541, 220)
        Me.Outpatient_ClinicsDataGridView.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Clinic_Num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clinic_Num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Clinic_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Clinic_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telephone_Ext"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telephone_Ext"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Charge_Nurse"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Charge_Nurse"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Out_patient_clinic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 663)
        Me.Controls.Add(Me.Outpatient_ClinicsDataGridView)
        Me.Controls.Add(Clinic_NumLabel)
        Me.Controls.Add(Me.Clinic_NumTextBox)
        Me.Controls.Add(Clinic_NameLabel)
        Me.Controls.Add(Me.Clinic_NameTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Telephone_ExtLabel)
        Me.Controls.Add(Me.Telephone_ExtTextBox)
        Me.Controls.Add(Charge_NurseLabel)
        Me.Controls.Add(Me.Charge_NurseTextBox)
        Me.Controls.Add(Me.Outpatient_ClinicsBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Out_patient_clinic"
        Me.Text = "Out_patient_clinic"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Outpatient_ClinicsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Outpatient_ClinicsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Outpatient_ClinicsBindingNavigator.ResumeLayout(False)
        Me.Outpatient_ClinicsBindingNavigator.PerformLayout()
        CType(Me.Outpatient_ClinicsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatabaseG26DataSet As DatabaseG26DataSet
    Friend WithEvents Outpatient_ClinicsBindingSource As BindingSource
    Friend WithEvents Outpatient_ClinicsTableAdapter As DatabaseG26DataSetTableAdapters.Outpatient_ClinicsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Outpatient_ClinicsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Outpatient_ClinicsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Clinic_NumTextBox As TextBox
    Friend WithEvents Clinic_NameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents Telephone_ExtTextBox As TextBox
    Friend WithEvents Charge_NurseTextBox As TextBox
    Friend WithEvents Outpatient_ClinicsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
