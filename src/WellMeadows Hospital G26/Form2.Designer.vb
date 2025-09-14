<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DatabaseG26DataSet2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet2()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager()
        Me.AddressesTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.AddressesTableAdapter()
        Me.AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.searchtbox = New System.Windows.Forms.TextBox()
        Me.staffdatagrid = New System.Windows.Forms.DataGridView()
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.staffdatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabaseG26DataSet2
        '
        Me.DatabaseG26DataSet2.DataSetName = "DatabaseG26DataSet2"
        Me.DatabaseG26DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.DatabaseG26DataSet2
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Me.AddressesTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'AddressesTableAdapter
        '
        Me.AddressesTableAdapter.ClearBeforeFill = True
        '
        'AddressesBindingSource
        '
        Me.AddressesBindingSource.DataMember = "Addresses"
        Me.AddressesBindingSource.DataSource = Me.DatabaseG26DataSet2
        '
        'searchtbox
        '
        Me.searchtbox.Location = New System.Drawing.Point(248, 55)
        Me.searchtbox.Name = "searchtbox"
        Me.searchtbox.Size = New System.Drawing.Size(100, 20)
        Me.searchtbox.TabIndex = 0
        '
        'staffdatagrid
        '
        Me.staffdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.staffdatagrid.Location = New System.Drawing.Point(183, 112)
        Me.staffdatagrid.Name = "staffdatagrid"
        Me.staffdatagrid.Size = New System.Drawing.Size(240, 150)
        Me.staffdatagrid.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.staffdatagrid)
        Me.Controls.Add(Me.searchtbox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.staffdatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseG26DataSet2 As DatabaseG26DataSet2
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As DatabaseG26DataSet2TableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents AddressesTableAdapter As DatabaseG26DataSet2TableAdapters.AddressesTableAdapter
    Friend WithEvents AddressesBindingSource As BindingSource
    Friend WithEvents searchtbox As TextBox
    Friend WithEvents staffdatagrid As DataGridView
End Class
