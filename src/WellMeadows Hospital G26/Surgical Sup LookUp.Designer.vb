<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Surgical_Sup_LookUp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Me.Surgical_SuppliesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Surgical_SuppliesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Surgical_SuppliesTableAdapter1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Surgical_SuppliesTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Surgical_SuppliesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Surgical_SuppliesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 80)
        Me.Panel1.TabIndex = 88
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SHeadLB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(300, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Surgical Equipment Lookup"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(-178, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1647, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Location = New System.Drawing.Point(76, 84)
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox.TabIndex = 89
        '
        'Surgical_SuppliesDataGridView
        '
        Me.Surgical_SuppliesDataGridView.AutoGenerateColumns = False
        Me.Surgical_SuppliesDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Surgical_SuppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Surgical_SuppliesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Surgical_SuppliesDataGridView.DataSource = Me.Surgical_SuppliesBindingSource1
        Me.Surgical_SuppliesDataGridView.Location = New System.Drawing.Point(76, 110)
        Me.Surgical_SuppliesDataGridView.Name = "Surgical_SuppliesDataGridView"
        Me.Surgical_SuppliesDataGridView.Size = New System.Drawing.Size(743, 220)
        Me.Surgical_SuppliesDataGridView.TabIndex = 89
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "item_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "quantity_in_stock"
        Me.DataGridViewTextBoxColumn4.HeaderText = "quantity_in_stock"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "reorder_level"
        Me.DataGridViewTextBoxColumn5.HeaderText = "reorder_level"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cost_per_unit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cost_per_unit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "supplier_no"
        Me.DataGridViewTextBoxColumn7.HeaderText = "supplier_no"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Surgical_SuppliesBindingSource1
        '
        Me.Surgical_SuppliesBindingSource1.DataMember = "Surgical_Supplies"
        Me.Surgical_SuppliesBindingSource1.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Surgical_SuppliesTableAdapter1
        '
        Me.Surgical_SuppliesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AddressesTableAdapter = Nothing
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
        Me.TableAdapterManager1.Surgical_SuppliesTableAdapter = Me.Surgical_SuppliesTableAdapter1
        Me.TableAdapterManager1.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        Me.TableAdapterManager1.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager1.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager1.WardsTableAdapter = Nothing
        Me.TableAdapterManager1.Work_ExperienceTableAdapter = Nothing
        '
        'Surgical_Sup_LookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 368)
        Me.Controls.Add(Me.Surgical_SuppliesDataGridView)
        Me.Controls.Add(Me.Param1ToolStripTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Surgical_Sup_LookUp"
        Me.Text = "Surgical_Sup_LookUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Surgical_SuppliesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Surgical_SuppliesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Surgical_SuppliesBindingSource1 As BindingSource
    Friend WithEvents Surgical_SuppliesTableAdapter1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Surgical_SuppliesTableAdapter
    Friend WithEvents TableAdapterManager1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Surgical_SuppliesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Param1ToolStripTextBox As TextBox
End Class
