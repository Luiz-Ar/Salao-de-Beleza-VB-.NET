Public Class FrmFuncionarioTela
    Dim agendar
    Private Sub FrmFuncionarioTela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        LblCadastroClienteTitle.Text = "AGENDA - " & cliente & ""
        LoadAgenda()
    End Sub

    Private Sub TxtData_ValueChanged(sender As Object, e As EventArgs) Handles TxtData.ValueChanged
        LoadAgenda()
    End Sub

    Private Sub LoadAgenda()

        Dim a, contRows As Integer
        contRows = -1
        DgvAgenda.ColumnCount = 7

        DgvAgenda.Columns(0).Name = "Hr"
        DgvAgenda.Columns(0).HeaderText = "Hr"
        DgvAgenda.Columns(0).DataPropertyName = "Hr"
        'DgvAgenda.Columns(0).Width = 35

        DgvAgenda.Columns(1).Name = "CPF"
        DgvAgenda.Columns(1).HeaderText = "CPF"
        DgvAgenda.Columns(1).DataPropertyName = "CPF"
        DgvAgenda.Columns(1).Visible = False

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

        DgvAgenda.Columns(6).Name = "id"
        DgvAgenda.Columns(6).Visible = False
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
        sql = "SELECT * FROM TBAGENDA WHERE FUNCIONARIO = '" & cliente & "' AND DATASERVICO = '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "' AND CANCELADO = 0 ORDER BY HORARIOENTRADA ASC"
        rs = db.Execute(sql)
        With Me.DgvAgenda
            .Rows.Clear()
            If rs.EOF Then
                For cont = 0 To 21 Step 1
                    .Rows.Add(vetor(cont), Nothing, Nothing, Nothing, Nothing, Nothing)
                Next
            Else
                While rs.EOF = False
                    For cont = 0 To 21 Step 1
                        If rs.EOF = False Then
                            If rs.Fields(8).Value = vetor(cont) Then
                                sql = "SELECT * FROM TBSERVICO WHERE IDSERVICO = " & rs.Fields(4).Value & ""
                                rsAux = db.Execute(sql)
                                If rsAux.Fields(7).Value > "00:30" And rsAux.Fields(7).Value <= "01:00" Then
                                    .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                    cont += 1
                                ElseIf rsAux.Fields(7).Value > "01:00" And rsAux.Fields(7).Value <= "01:30" Then
                                    For a = 0 To 1 Step 1
                                        .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                        cont += 1
                                    Next
                                ElseIf rsAux.Fields(7).Value > "01:30" And rsAux.Fields(7).Value <= "02:00" Then
                                    For a = 0 To 2 Step 1
                                        .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                        cont += 1
                                    Next
                                ElseIf rsAux.Fields(7).Value > "02:00" And rsAux.Fields(7).Value <= "02:30" Then
                                    For a = 0 To 3 Step 1
                                        .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                        cont += 1
                                    Next
                                ElseIf rsAux.Fields(7).Value > "02:30" And rsAux.Fields(7).Value <= "03:00" Then
                                    For a = 0 To 4 Step 1
                                        .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                        cont += 1
                                    Next
                                ElseIf rsAux.Fields(7).Value > "03:00" And rsAux.Fields(7).Value < "03:30" Then
                                    For a = 0 To 5 Step 1
                                        .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                        cont += 1
                                    Next
                                End If
                                .Rows.Add(vetor(cont), rs.Fields(1).Value, rs.Fields(7).Value, rs.Fields(5).Value, Nothing, rs.Fields(0).Value, rs.Fields(14).Value)
                                rs.MoveNext()
                            Else
                                .Rows.Add(vetor(cont), Nothing, Nothing, Nothing, Nothing, Nothing)
                            End If
                        Else
                            .Rows.Add(vetor(cont), Nothing, Nothing, Nothing, Nothing, Nothing)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        funcionario = True
        FrmRelatórios.Show()
    End Sub
End Class