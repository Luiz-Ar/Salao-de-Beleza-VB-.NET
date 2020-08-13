Public Class FrmRelatórios

    Dim ContRows, ContValor As Integer
    Private Sub Relatórios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConectaBanco()
            ArredondarLados()
            If funcionario Then
                CmbTipoRelatorio.Items.Add("AGENDAMENTOS")
                CmbTipoRelatorio.Items.Add("SERVIÇOS REALIZADOS")
                BloquearParaFuncionario()
            Else
                CmbTipoRelatorio.Items.Add("AGENDAMENTOS")
                CmbTipoRelatorio.Items.Add("CLIENTES")
                CmbTipoRelatorio.Items.Add("SERVIÇOS REALIZADOS")

                sql = "SELECT * FROM TBCARGOS WHERE IDCARGO > 2 AND IDCARGO < 8"
                rs = db.Execute(sql)

                If rs.EOF Then
                    Exit Sub
                Else
                    CmbServico.Items.Clear()
                    Do While rs.EOF = False
                        CmbServico.Items.Add(rs.Fields(1).Value)
                        rs.MoveNext()
                    Loop
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServico.SelectedIndexChanged
        Try
            sql = "SELECT NOME FROM TBFUNCIONARIOS WHERE CARGO = '" & CmbServico.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                Exit Sub
            Else
                CmbFuncionario.Items.Clear()
                Do While rs.EOF = False
                    CmbFuncionario.Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFuncionario.SelectedIndexChanged
        Try
            ComboServicos()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboServicos()
        sql = "SELECT * FROM TBSERVICO WHERE FUNCIONARIO = '" & CmbFuncionario.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF Then
            Exit Sub
        Else
            CmbServicos.Items.Clear()
            Do While rs.EOF = False
                CmbServicos.Items.Add(rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End If
    End Sub

    Private Sub ArredondarLados()
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        'Me.BackColor = Color.Red
        Me.WindowState = WindowState.Normal
    End Sub
    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        Try
            If funcionario Then
                Me.Close()
            Else
                resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    Me.Close()
                    frmLogin.Show()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnGerar_Click(sender As Object, e As EventArgs) Handles BtnGerar.Click
        Try
            ContValor = 0
            ContRows = 0
            If CmbTipoRelatorio.Text = "" Then
                MsgBox("Escolha o tipo de relatório!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                If CmbFuncionario.Text = "" And CmbServico.Text = "" And CmbServicos.Text = "" Then
                    LoadDataViewItem1()
                ElseIf CmbFuncionario.Text = "" And CmbServico.Text <> "" And CmbServicos.Text = "" Then
                    LoadDataViewItem2()
                ElseIf CmbFuncionario.Text <> "" And CmbServico.Text <> "" And CmbServicos.Text = "" Then
                    LoadDataViewItem3()
                ElseIf CmbFuncionario.Text <> "" And CmbServico.Text <> "" And CmbServicos.Text <> "" Then
                    LoadDataViewItem4()
                End If
            End If
            If funcionario Then
                BloquearParaFuncionario()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataViewItem1()
        Try
            DgvRel.Rows.Clear()
            If CmbTipoRelatorio.Text = "AGENDAMENTOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            ElseIf CmbTipoRelatorio.Text = "SERVIÇOS REALIZADOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If

                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            Else
                LoadDataGridClientes()
                LoadClientes()
            End If
            LblQtde.Text = ContRows.ToString
            LblValor.Text = FormatCurrency(ContValor).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataViewItem2()
        Try
            sql = "SELECT * FROM TBTIPOSERVICO WHERE TIPOSERVICO = '" & CmbServico.Text & "'"
            rsAux = db.Execute(sql)
            DgvRel.Rows.Clear()
            If CmbTipoRelatorio.Text = "AGENDAMENTOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            ElseIf CmbTipoRelatorio.Text = "SERVIÇOS REALIZADOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            Else
                LoadDataGridClientes()
                LoadClientes()
            End If
            LblQtde.Text = ContRows.ToString
            LblValor.Text = FormatCurrency(ContValor).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataViewItem3()
        Try
            sql = "SELECT * FROM TBTIPOSERVICO WHERE TIPOSERVICO = '" & CmbServico.Text & "'"
            rsAux = db.Execute(sql)
            DgvRel.Rows.Clear()
            If CmbTipoRelatorio.Text = "AGENDAMENTOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            ElseIf CmbTipoRelatorio.Text = "SERVIÇOS REALIZADOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            Else
                LoadDataGridClientes()
                LoadClientes()
            End If
            LblQtde.Text = ContRows.ToString
            LblValor.Text = FormatCurrency(ContValor).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataViewItem4()
        Try
            sql = "SELECT * FROM TBTIPOSERVICO WHERE TIPOSERVICO = '" & CmbServico.Text & "'"
            rsAux = db.Execute(sql)
            DgvRel.Rows.Clear()
            If CmbTipoRelatorio.Text = "AGENDAMENTOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' AND SERVICO = '" & CmbServicos.Text & "' ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = 0 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' AND SERVICO = '" & CmbServicos.Text & "' AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            ElseIf CmbTipoRelatorio.Text = "SERVIÇOS REALIZADOS" Then
                LoadDataGridServicos()
                With DgvRel
                    If CbData.CheckState = 0 Then
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' AND SERVICO = '" & CmbServicos.Text & "' ORDER BY DATASERVICO"
                        rs = db.Execute(sql)
                    Else
                        sql = "SELECT * FROM TBAGENDA WHERE FINALIZADO = -1 AND IDTIPOSERVICO = " & rsAux.Fields(0).Value & " AND FUNCIONARIO = '" & CmbFuncionario.Text & "' AND SERVICO = '" & CmbServicos.Text & "' AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                        rs = db.Execute(sql)
                    End If
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            Else
                LoadDataGridClientes()
                LoadClientes()
            End If
            LblQtde.Text = ContRows.ToString
            LblValor.Text = FormatCurrency(ContValor).ToString
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadClientes()
        Try
            sql = "SELECT * FROM TBCLIENTES ORDER BY NOME ASC"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                With DgvRel
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(13).Value, FormatDateTime(rs.Fields(2).Value, DateFormat.ShortDate), rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value)
                    rs.MoveNext()
                    ContRows += 1
                End With
            Loop
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGridServicos()
        Try
            With DgvRel
                .ColumnCount = 7

                .Columns(0).Name = "DATA SERVIÇO"
                .Columns(0).HeaderText = "DATA SERVIÇO"
                .Columns(0).DataPropertyName = "DATA SERVIÇO"

                .Columns(1).Name = "FUNCIONÁRIO"
                .Columns(1).HeaderText = "FUNCIONÁRIO"
                .Columns(1).DataPropertyName = "FUNCIONÁRIO"

                If funcionario Then
                    .Columns(1).Visible = False
                End If

                .Columns(2).Name = "SERVIÇO"
                .Columns(2).HeaderText = "SERVIÇO"
                .Columns(2).DataPropertyName = "SERVIÇO"
                .Columns(2).Visible = True

                .Columns(3).Name = "CPF CLIENTE"
                .Columns(3).HeaderText = "CPF CLIENTE"
                .Columns(3).DataPropertyName = "CPF CLIENTE"

                .Columns(4).Name = "CLIENTE"
                .Columns(4).HeaderText = "CLIENTE"
                .Columns(4).DataPropertyName = "CLIENTE"

                .Columns(5).Name = "HORARIO"
                .Columns(5).HeaderText = "HORARIO"
                .Columns(5).DataPropertyName = "HORARIO"

                .Columns(6).Name = "PREÇO"
                .Columns(6).HeaderText = "PREÇO"
                .Columns(6).DataPropertyName = "PREÇO"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataGridClientes()
        Try
            With DgvRel
                .ColumnCount = 7

                .Columns(0).Name = "CPF"
                .Columns(0).HeaderText = "CPF"
                .Columns(0).DataPropertyName = "CPF"

                .Columns(1).Name = "NOME CLIENTE"
                .Columns(1).HeaderText = "NOME CLIENTE"
                .Columns(1).DataPropertyName = "NOME CLIENTE"

                .Columns(2).Name = "SEXO"
                .Columns(2).HeaderText = "SEXO"
                .Columns(2).DataPropertyName = "SEXO"
                .Columns(2).Visible = False

                .Columns(3).Name = "DATA NASCIMENTO"
                .Columns(3).HeaderText = "DATA NASCIMENTO"
                .Columns(3).DataPropertyName = "DATA NASCIMENTO"

                .Columns(4).Name = "TELEFONE"
                .Columns(4).HeaderText = "TELEFONE"
                .Columns(4).DataPropertyName = "TELEFONE"

                .Columns(5).Name = "CELULAR"
                .Columns(5).HeaderText = "CELULAR"
                .Columns(5).DataPropertyName = "CELULAR"

                .Columns(6).Name = "E-MAIL"
                .Columns(6).HeaderText = "E-MAIL"
                .Columns(6).DataPropertyName = "E-MAIL"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbTipoRelatorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoRelatorio.SelectedIndexChanged
        Try
            If CmbTipoRelatorio.Text = "CLIENTES" Then
                CmbFuncionario.Enabled = False
                CmbServico.Enabled = False
                CmbServicos.Enabled = False
                TxtDataFinal.Enabled = False
                TxtDataInicial.Enabled = False
                CbData.Enabled = False
                TxtPesquisar.Enabled = True
            ElseIf funcionario = False Then
                CmbFuncionario.Enabled = True
                CmbServico.Enabled = True
                CmbServicos.Enabled = True
                TxtDataFinal.Enabled = True
                TxtDataInicial.Enabled = True
                CbData.Enabled = True
                TxtPesquisar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Try
            CmbFuncionario.Text = ""
            CmbTipoRelatorio.Text = ""
            CmbServico.Text = ""
            CmbServicos.Text = ""
            TxtPesquisar.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        Try
            ContRows = 0
            ContValor = 0
            If funcionario Then
                sql = "SELECT * FROM TBAGENDA WHERE FUNCIONARIO = '" & CmbFuncionario.Text & "' AND CLIENTE LIKE '" & TxtPesquisar.Text & "%' ORDER BY DATASERVICO DESC"
                rs = db.Execute(sql)
                LoadDataGridServicos()
                With DgvRel
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(2).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                        ContValor += CInt(rs.Fields(9).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            Else
                sql = "Select * FROM TBCLIENTES WHERE NOME Like '" & TxtPesquisar.Text & "%'"
                rs = db.Execute(sql)
                LoadDataGridClientes()
                With DgvRel
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(13).Value, FormatDateTime(rs.Fields(2).Value, DateFormat.ShortDate), rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            End If
            LblQtde.Text = ContRows.ToString
            LblValor.Text = FormatCurrency(ContValor).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BloquearParaFuncionario()
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE NOME = '" & cliente & "'"
        rs = db.Execute(sql)
        CmbFuncionario.Text = rs.Fields(1).Value
        CmbServico.Text = rs.Fields(4).Value
        CmbFuncionario.Enabled = False
        CmbServico.Enabled = False
        BtnReset.Enabled = False
        ComboServicos()
    End Sub
End Class