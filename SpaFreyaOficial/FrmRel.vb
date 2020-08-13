Public Class FrmRel
    Private Sub FrmRel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta linha de código carrega dados na tabela 'dbSpaBelezaDataSet.tbFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbFuncionariosTableAdapter.queryFuncionarios(Me.dbSpaBelezaDataSet.tbFuncionarios)

        ReportViewer1.RefreshReport()
        ReportViewer1.Refresh()
    End Sub
End Class