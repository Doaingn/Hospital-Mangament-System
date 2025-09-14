<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userLookup
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
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.UsersTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Param1ToolStripTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(488, 80)
        Me.Panel1.TabIndex = 79
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SHeadLB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(145, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "User Lookup"
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
        'UsersDataGridView
        '
        Me.UsersDataGridView.AutoGenerateColumns = False
        Me.UsersDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.UsersDataGridView.DataSource = Me.UsersBindingSource
        Me.UsersDataGridView.Location = New System.Drawing.Point(76, 109)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.Size = New System.Drawing.Size(345, 220)
        Me.UsersDataGridView.TabIndex = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Users_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Users_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Param1ToolStripTextBox1
        '
        Me.Param1ToolStripTextBox1.Location = New System.Drawing.Point(76, 83)
        Me.Param1ToolStripTextBox1.Name = "Param1ToolStripTextBox1"
        Me.Param1ToolStripTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox1.TabIndex = 83
        '
        'userLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 349)
        Me.Controls.Add(Me.Param1ToolStripTextBox1)
        Me.Controls.Add(Me.UsersDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "userLookup"
        Me.Text = "User Lookup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Param1ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Param1ToolStripTextBox1 As TextBox
End Class
