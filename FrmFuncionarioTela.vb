Public Class FrmFuncionarioTela
    Dim agendar
    Private Sub FrmFuncionarioTela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAgenda()
    End Sub

    Private Sub TxtData_ValueChanged(sender As Object, e As EventArgs) Handles TxtData.ValueChanged
        LoadAgenda()
    End Sub

    Private Sub LoadAgenda()
        LblCadastroClienteTitle.Text = "AGENDA FUNCIONÁRIO: '" & cliente & "'"
        DgvAgenda.ColumnCount = 6

        DgvAgenda.Columns(0).Name = "Hr"
        'DgvAgenda.Columns(0).Width = 45
        DgvAgenda.Columns(0).HeaderText = "Hr"
        DgvAgenda.Columns(0).DataPropertyName = "Hr"

        DgvAgenda.Columns(1).Name = "CPF"
        DgvAgenda.Columns(1).HeaderText = "CPF"
        DgvAgenda.Columns(1).DataPropertyName = "CPF"

        DgvAgenda.Columns(2).Name = "Cliente"
        DgvAgenda.Columns(2).HeaderText = "Cliente"
        DgvAgenda.Columns(2).DataPropertyName = "Cliente"

        DgvAgenda.Columns(3).Name = "Serviço"
        DgvAgenda.Columns(3).HeaderText = "Serviço"
        DgvAgenda.Columns(3).DataPropertyName = "Serviço"


        DgvAgenda.Columns(4).Visible = False
        DgvAgenda.Columns(5).Name = "Cod"
        DgvAgenda.Columns(5).HeaderText = "Cod"
        DgvAgenda.Columns(5).DataPropertyName = "Cod"
        DgvAgenda.Columns(5).Visible = False

        DgvAgenda.SelectionMode = DataGridViewSelectionMode.CellSelect
        Dim cont
        cont = 0
        sql = "select * from tbHorarios"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            vetor(cont) = rs.Fields(0).Value
            rs.MoveNext()
            cont += 1
        Loop

        d = TxtData.Value.Date.ToString
        sql = "SELECT * FROM TBAGENDA WHERE FUNCIONARIO = '" & cliente & "' AND DATASERVICO = '" & TxtData.Text & "' AND CANCELADO = 0 ORDER BY HORARIOENTRADA ASC"
        rs = db.Execute(sql)
        With Me.DgvAgenda
            .Rows.Clear()
            If rs.EOF Then
                For cont = 0 To 20 Step 1
                    .Rows.Add(vetor(cont), Nothing, Nothing, Nothing)
                Next
            Else
                While rs.EOF = False
                    For cont = 0 To 20 Step 1
                        If rs.EOF = False Then
                            If rs.Fields(8).Value = vetor(cont) Then
                                .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value)
                                rs.MoveNext()
                            Else
                                .Rows.Add(vetor(cont), Nothing, Nothing, Nothing)
                            End If
                        Else
                            .Rows.Add(vetor(cont), Nothing, Nothing, Nothing)
                        End If
                    Next
                End While
            End If
        End With
    End Sub

    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class