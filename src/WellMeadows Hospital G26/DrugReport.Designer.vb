<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrugReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DrugRequisitionViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.DrugRequisitionViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseG26DataSetView = New WellMeadows_Hospital_G26.DatabaseG26DataSetView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Drug_Requisition_ViewTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetViewTableAdapters.Drug_Requisition_ViewTableAdapter()
        Me.Drug_Requisition_ViewTableAdapter1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Drug_Requisition_ViewTableAdapter()
        CType(Me.DrugRequisitionViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugRequisitionViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSetView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrugRequisitionViewBindingSource1
        '
        Me.DrugRequisitionViewBindingSource1.DataMember = "Drug_Requisition_View"
        Me.DrugRequisitionViewBindingSource1.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DrugRequisitionViewBindingSource
        '
        Me.DrugRequisitionViewBindingSource.DataMember = "Drug_Requisition_View"
        Me.DrugRequisitionViewBindingSource.DataSource = Me.DatabaseG26DataSetView
        '
        'DatabaseG26DataSetView
        '
        Me.DatabaseG26DataSetView.DataSetName = "DatabaseG26DataSetView"
        Me.DatabaseG26DataSetView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1547, 80)
        Me.Panel1.TabIndex = 86
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SHeadLB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(264, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Drug Requisition Report"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1547, 81)
        Me.Panel2.TabIndex = 85
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(83, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(82, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wellmeadows Hospital"
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DrugRequisitionViewBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WellMeadows_Hospital_G26.PharmaceuticalReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 182)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1523, 549)
        Me.ReportViewer1.TabIndex = 87
        '
        'Drug_Requisition_ViewTableAdapter
        '
        Me.Drug_Requisition_ViewTableAdapter.ClearBeforeFill = True
        '
        'Drug_Requisition_ViewTableAdapter1
        '
        Me.Drug_Requisition_ViewTableAdapter1.ClearBeforeFill = True
        '
        'DrugReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 743)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "DrugReport"
        Me.Text = "DrugReport"
        CType(Me.DrugRequisitionViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugRequisitionViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSetView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DatabaseG26DataSetView As DatabaseG26DataSetView
    Friend WithEvents DrugRequisitionViewBindingSource As BindingSource
    Friend WithEvents Drug_Requisition_ViewTableAdapter As DatabaseG26DataSetViewTableAdapters.Drug_Requisition_ViewTableAdapter
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents DrugRequisitionViewBindingSource1 As BindingSource
    Friend WithEvents Drug_Requisition_ViewTableAdapter1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Drug_Requisition_ViewTableAdapter
End Class
