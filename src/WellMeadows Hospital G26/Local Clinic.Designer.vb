<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Local_Clinic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Local_Clinic))
        Dim ClinicIDLabel As System.Windows.Forms.Label
        Dim ClinicNameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim Address_IDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DatabaseG26DataSet = New WellMeadows_Hospital_G26.DatabaseG26DataSet()
        Me.Local_ClinicsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Local_ClinicsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.Local_ClinicsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Local_ClinicsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Local_ClinicsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClinicIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClinicNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Local_ClinicsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ClinicIDLabel = New System.Windows.Forms.Label()
        ClinicNameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        Address_IDLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local_ClinicsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local_ClinicsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Local_ClinicsBindingNavigator.SuspendLayout()
        CType(Me.Local_ClinicsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 78)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.Panel2.TabIndex = 40
        '
        'DatabaseG26DataSet
        '
        Me.DatabaseG26DataSet.DataSetName = "DatabaseG26DataSet"
        Me.DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Local_ClinicsBindingSource
        '
        Me.Local_ClinicsBindingSource.DataMember = "Local_Clinics"
        Me.Local_ClinicsBindingSource.DataSource = Me.DatabaseG26DataSet
        '
        'Local_ClinicsTableAdapter
        '
        Me.Local_ClinicsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Local_ClinicsTableAdapter = Me.Local_ClinicsTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Local_ClinicsBindingNavigator
        '
        Me.Local_ClinicsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Local_ClinicsBindingNavigator.BindingSource = Me.Local_ClinicsBindingSource
        Me.Local_ClinicsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Local_ClinicsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Local_ClinicsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Local_ClinicsBindingNavigatorSaveItem})
        Me.Local_ClinicsBindingNavigator.Location = New System.Drawing.Point(0, 81)
        Me.Local_ClinicsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Local_ClinicsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Local_ClinicsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Local_ClinicsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Local_ClinicsBindingNavigator.Name = "Local_ClinicsBindingNavigator"
        Me.Local_ClinicsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Local_ClinicsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Local_ClinicsBindingNavigator.TabIndex = 41
        Me.Local_ClinicsBindingNavigator.Text = "BindingNavigator1"
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
        'Local_ClinicsBindingNavigatorSaveItem
        '
        Me.Local_ClinicsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Local_ClinicsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Local_ClinicsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Local_ClinicsBindingNavigatorSaveItem.Name = "Local_ClinicsBindingNavigatorSaveItem"
        Me.Local_ClinicsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Local_ClinicsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClinicIDLabel
        '
        ClinicIDLabel.AutoSize = True
        ClinicIDLabel.Location = New System.Drawing.Point(290, 192)
        ClinicIDLabel.Name = "ClinicIDLabel"
        ClinicIDLabel.Size = New System.Drawing.Size(48, 13)
        ClinicIDLabel.TabIndex = 41
        ClinicIDLabel.Text = "clinic ID:"
        '
        'ClinicIDTextBox
        '
        Me.ClinicIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_ClinicsBindingSource, "clinicID", True))
        Me.ClinicIDTextBox.Location = New System.Drawing.Point(362, 189)
        Me.ClinicIDTextBox.Name = "ClinicIDTextBox"
        Me.ClinicIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClinicIDTextBox.TabIndex = 42
        '
        'ClinicNameLabel
        '
        ClinicNameLabel.AutoSize = True
        ClinicNameLabel.Location = New System.Drawing.Point(290, 218)
        ClinicNameLabel.Name = "ClinicNameLabel"
        ClinicNameLabel.Size = New System.Drawing.Size(65, 13)
        ClinicNameLabel.TabIndex = 43
        ClinicNameLabel.Text = "clinic Name:"
        '
        'ClinicNameTextBox
        '
        Me.ClinicNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_ClinicsBindingSource, "clinicName", True))
        Me.ClinicNameTextBox.Location = New System.Drawing.Point(362, 215)
        Me.ClinicNameTextBox.Name = "ClinicNameTextBox"
        Me.ClinicNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClinicNameTextBox.TabIndex = 44
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Location = New System.Drawing.Point(290, 244)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(66, 13)
        PhoneNumLabel.TabIndex = 45
        PhoneNumLabel.Text = "Phone Num:"
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_ClinicsBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(362, 241)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumTextBox.TabIndex = 46
        '
        'Address_IDLabel
        '
        Address_IDLabel.AutoSize = True
        Address_IDLabel.Location = New System.Drawing.Point(290, 270)
        Address_IDLabel.Name = "Address_IDLabel"
        Address_IDLabel.Size = New System.Drawing.Size(62, 13)
        Address_IDLabel.TabIndex = 47
        Address_IDLabel.Text = "Address ID:"
        '
        'Address_IDTextBox
        '
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_ClinicsBindingSource, "Address_ID", True))
        Me.Address_IDTextBox.Location = New System.Drawing.Point(362, 267)
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        Me.Address_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Address_IDTextBox.TabIndex = 48
        '
        'Local_ClinicsDataGridView
        '
        Me.Local_ClinicsDataGridView.AutoGenerateColumns = False
        Me.Local_ClinicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Local_ClinicsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Local_ClinicsDataGridView.DataSource = Me.Local_ClinicsBindingSource
        Me.Local_ClinicsDataGridView.Location = New System.Drawing.Point(153, 324)
        Me.Local_ClinicsDataGridView.Name = "Local_ClinicsDataGridView"
        Me.Local_ClinicsDataGridView.Size = New System.Drawing.Size(442, 220)
        Me.Local_ClinicsDataGridView.TabIndex = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "clinicID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "clinicID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "clinicName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "clinicName"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Local_Clinic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 610)
        Me.Controls.Add(Me.Local_ClinicsDataGridView)
        Me.Controls.Add(ClinicIDLabel)
        Me.Controls.Add(Me.ClinicIDTextBox)
        Me.Controls.Add(ClinicNameLabel)
        Me.Controls.Add(Me.ClinicNameTextBox)
        Me.Controls.Add(PhoneNumLabel)
        Me.Controls.Add(Me.PhoneNumTextBox)
        Me.Controls.Add(Address_IDLabel)
        Me.Controls.Add(Me.Address_IDTextBox)
        Me.Controls.Add(Me.Local_ClinicsBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Local_Clinic"
        Me.Text = "Local_Clinic"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local_ClinicsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local_ClinicsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Local_ClinicsBindingNavigator.ResumeLayout(False)
        Me.Local_ClinicsBindingNavigator.PerformLayout()
        CType(Me.Local_ClinicsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DatabaseG26DataSet As DatabaseG26DataSet
    Friend WithEvents Local_ClinicsBindingSource As BindingSource
    Friend WithEvents Local_ClinicsTableAdapter As DatabaseG26DataSetTableAdapters.Local_ClinicsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Local_ClinicsBindingNavigator As BindingNavigator
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
    Friend WithEvents Local_ClinicsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClinicIDTextBox As TextBox
    Friend WithEvents ClinicNameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents Local_ClinicsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
