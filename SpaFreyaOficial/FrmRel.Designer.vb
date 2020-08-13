<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRel
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbFuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbSpaBelezaDataSet = New SpaFreyaOficial.dbSpaBelezaDataSet()
        Me.tbFuncionariosTableAdapter = New SpaFreyaOficial.dbSpaBelezaDataSetTableAdapters.tbFuncionariosTableAdapter()
        CType(Me.tbFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbSpaBelezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dataSetFuncionarios"
        ReportDataSource1.Value = Me.tbFuncionariosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SpaFreyaOficial.rptFuncionarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(600, 366)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbFuncionariosBindingSource
        '
        Me.tbFuncionariosBindingSource.DataMember = "tbFuncionarios"
        Me.tbFuncionariosBindingSource.DataSource = Me.dbSpaBelezaDataSet
        '
        'dbSpaBelezaDataSet
        '
        Me.dbSpaBelezaDataSet.DataSetName = "dbSpaBelezaDataSet"
        Me.dbSpaBelezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbFuncionariosTableAdapter
        '
        Me.tbFuncionariosTableAdapter.ClearBeforeFill = True
        '
        'FrmRel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmRel"
        Me.Text = "FrmRel"
        CType(Me.tbFuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbSpaBelezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbFuncionariosBindingSource As BindingSource
    Friend WithEvents dbSpaBelezaDataSet As dbSpaBelezaDataSet
    Friend WithEvents tbFuncionariosTableAdapter As dbSpaBelezaDataSetTableAdapters.tbFuncionariosTableAdapter
End Class
