<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient_next_of_kin
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
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_next_of_kin))
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim Address_IDLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Param1ToolStripTextBox1 = New System.Windows.Forms.TextBox()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DOC_LU = New System.Windows.Forms.Button()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_NextOfKinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Patients_NextOfKinTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Patients_NextOfKinTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Patients_NextOfKinBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Patients_NextOfKinBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patients_NextOfKinDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Address = New System.Windows.Forms.Button()
        P_NumLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Address_IDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Patients_NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patients_NextOfKinBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patients_NextOfKinBindingNavigator.SuspendLayout()
        CType(Me.Patients_NextOfKinDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_NumLabel
        '
        resources.ApplyResources(P_NumLabel, "P_NumLabel")
        P_NumLabel.Name = "P_NumLabel"
        '
        'First_NameLabel
        '
        resources.ApplyResources(First_NameLabel, "First_NameLabel")
        First_NameLabel.Name = "First_NameLabel"
        '
        'Last_NameLabel
        '
        resources.ApplyResources(Last_NameLabel, "Last_NameLabel")
        Last_NameLabel.Name = "Last_NameLabel"
        '
        'PhoneNumLabel
        '
        resources.ApplyResources(PhoneNumLabel, "PhoneNumLabel")
        PhoneNumLabel.Name = "PhoneNumLabel"
        '
        'RelationshipLabel
        '
        resources.ApplyResources(RelationshipLabel, "RelationshipLabel")
        RelationshipLabel.Name = "RelationshipLabel"
        '
        'Address_IDLabel
        '
        resources.ApplyResources(Address_IDLabel, "Address_IDLabel")
        Address_IDLabel.Name = "Address_IDLabel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'SHeadLB
        '
        resources.ApplyResources(Me.SHeadLB, "SHeadLB")
        Me.SHeadLB.Name = "SHeadLB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Param1ToolStripTextBox1)
        Me.Panel2.Controls.Add(Me.Param1ToolStripTextBox)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Param1ToolStripTextBox1
        '
        Me.Param1ToolStripTextBox1.ForeColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Param1ToolStripTextBox1, "Param1ToolStripTextBox1")
        Me.Param1ToolStripTextBox1.Name = "Param1ToolStripTextBox1"
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.ForeColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Param1ToolStripTextBox, "Param1ToolStripTextBox")
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DOC_LU, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(P_NumLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.P_NumTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(First_NameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.First_NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Last_NameLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Last_NameTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(PhoneNumLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneNumTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(RelationshipLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RelationshipTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Address_IDLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Address_IDTextBox, 1, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DOC_LU
        '
        resources.ApplyResources(Me.DOC_LU, "DOC_LU")
        Me.DOC_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.DOC_LU.ForeColor = System.Drawing.Color.Transparent
        Me.DOC_LU.Name = "DOC_LU"
        Me.DOC_LU.UseVisualStyleBackColor = True
        '
        'P_NumTextBox
        '
        resources.ApplyResources(Me.P_NumTextBox, "P_NumTextBox")
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "P_Num", True))
        Me.P_NumTextBox.Name = "P_NumTextBox"
        '
        'Patients_NextOfKinBindingSource
        '
        Me.Patients_NextOfKinBindingSource.DataMember = "Patients_NextOfKin"
        Me.Patients_NextOfKinBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.Namespace = "http://tempuri.org/SQLEXPRESS_DatabaseG26DataSet.xsd"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'First_NameTextBox
        '
        resources.ApplyResources(Me.First_NameTextBox, "First_NameTextBox")
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "First_Name", True))
        Me.First_NameTextBox.Name = "First_NameTextBox"
        '
        'Last_NameTextBox
        '
        resources.ApplyResources(Me.Last_NameTextBox, "Last_NameTextBox")
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        '
        'PhoneNumTextBox
        '
        resources.ApplyResources(Me.PhoneNumTextBox, "PhoneNumTextBox")
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        '
        'RelationshipTextBox
        '
        resources.ApplyResources(Me.RelationshipTextBox, "RelationshipTextBox")
        Me.RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "Relationship", True))
        Me.RelationshipTextBox.Name = "RelationshipTextBox"
        '
        'Address_IDTextBox
        '
        resources.ApplyResources(Me.Address_IDTextBox, "Address_IDTextBox")
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patients_NextOfKinBindingSource, "Address_ID", True))
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        '
        'Patients_NextOfKinTableAdapter
        '
        Me.Patients_NextOfKinTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Patients_NextOfKinTableAdapter = Me.Patients_NextOfKinTableAdapter
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
        'Patients_NextOfKinBindingNavigator
        '
        Me.Patients_NextOfKinBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patients_NextOfKinBindingNavigator.BindingSource = Me.Patients_NextOfKinBindingSource
        Me.Patients_NextOfKinBindingNavigator.CountItem = Nothing
        Me.Patients_NextOfKinBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        resources.ApplyResources(Me.Patients_NextOfKinBindingNavigator, "Patients_NextOfKinBindingNavigator")
        Me.Patients_NextOfKinBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Patients_NextOfKinBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.Patients_NextOfKinBindingNavigatorSaveItem})
        Me.Patients_NextOfKinBindingNavigator.MoveFirstItem = Nothing
        Me.Patients_NextOfKinBindingNavigator.MoveLastItem = Nothing
        Me.Patients_NextOfKinBindingNavigator.MoveNextItem = Nothing
        Me.Patients_NextOfKinBindingNavigator.MovePreviousItem = Nothing
        Me.Patients_NextOfKinBindingNavigator.Name = "Patients_NextOfKinBindingNavigator"
        Me.Patients_NextOfKinBindingNavigator.PositionItem = Nothing
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Add
        resources.ApplyResources(Me.BindingNavigatorAddNewItem, "BindingNavigatorAddNewItem")
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Delete
        resources.ApplyResources(Me.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem")
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        resources.ApplyResources(Me.BindingNavigatorSeparator1, "BindingNavigatorSeparator1")
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        resources.ApplyResources(Me.BindingNavigatorSeparator2, "BindingNavigatorSeparator2")
        '
        'Patients_NextOfKinBindingNavigatorSaveItem
        '
        Me.Patients_NextOfKinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patients_NextOfKinBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        resources.ApplyResources(Me.Patients_NextOfKinBindingNavigatorSaveItem, "Patients_NextOfKinBindingNavigatorSaveItem")
        Me.Patients_NextOfKinBindingNavigatorSaveItem.Name = "Patients_NextOfKinBindingNavigatorSaveItem"
        '
        'Patients_NextOfKinDataGridView
        '
        Me.Patients_NextOfKinDataGridView.AutoGenerateColumns = False
        Me.Patients_NextOfKinDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Patients_NextOfKinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patients_NextOfKinDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Patients_NextOfKinDataGridView.DataSource = Me.Patients_NextOfKinBindingSource
        resources.ApplyResources(Me.Patients_NextOfKinDataGridView, "Patients_NextOfKinDataGridView")
        Me.Patients_NextOfKinDataGridView.Name = "Patients_NextOfKinDataGridView"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_Num"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNum"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Relationship"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn5, "DataGridViewTextBoxColumn5")
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address_ID"
        resources.ApplyResources(Me.DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6")
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.Address, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'Address
        '
        resources.ApplyResources(Me.Address, "Address")
        Me.Address.Name = "Address"
        Me.Address.UseVisualStyleBackColor = True
        '
        'Patient_next_of_kin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Patients_NextOfKinDataGridView)
        Me.Controls.Add(Me.Patients_NextOfKinBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Patient_next_of_kin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Patients_NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patients_NextOfKinBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patients_NextOfKinBindingNavigator.ResumeLayout(False)
        CType(Me.Patients_NextOfKinDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Param1ToolStripTextBox As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Patients_NextOfKinBindingSource As BindingSource
    Friend WithEvents Patients_NextOfKinTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Patients_NextOfKinTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patients_NextOfKinBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Patients_NextOfKinBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents RelationshipTextBox As TextBox
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents Patients_NextOfKinDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents DOC_LU As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Address As Button
    Friend WithEvents Param1ToolStripTextBox1 As TextBox
End Class
