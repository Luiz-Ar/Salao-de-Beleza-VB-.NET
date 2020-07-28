Public Class FrmServicos
    Dim menor As Boolean
    Dim CF, CM, MP, MQ, MS, ES As Boolean
    Dim agendar

    Private Sub FrmServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()
        menor = True
    End Sub

    Private Sub PnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub PnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseUp
        drag = False
    End Sub
    Private Sub BtnHideMenu_Click(sender As Object, e As EventArgs) Handles BtnHideMenu.Click
        If menor Then
            Me.PnlDireita.Visible = False
            Me.Width = 815
            Me.PnlDireitaMenor.Dock = DockStyle.Right
            Me.PnlDireitaMenor.Visible = True
            menor = False
        Else
            Me.PnlDireitaMenor.Visible = False
            Me.Width = 943
            Me.PnlDireita.Dock = DockStyle.Right
            Me.PnlDireita.Visible = True
            menor = True
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
    Private Sub BtnCadastrarClienteTxt_Click(sender As Object, e As EventArgs) Handles BtnCadastrarClienteTxt.Click
        ShowFormCliente()
    End Sub

    Private Sub BtnCadastrarClienteIcone_Click(sender As Object, e As EventArgs) Handles BtnCadastrarClienteIcone.Click
        ShowFormCliente()
    End Sub

    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub PicMinimizar_Click(sender As Object, e As EventArgs) Handles PicMinimizar.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub BtnCadastrarCEPTopImage_Click(sender As Object, e As EventArgs) Handles BtnCadastrarCEPTopImage.Click
        ShowFormCep()
    End Sub

    Private Sub BtnCadastrarCEPTopText_Click(sender As Object, e As EventArgs) Handles BtnCadastrarCEPTopText.Click
        ShowFormCep()
    End Sub

    Private Sub BtnCabeleireiroF_Click(sender As Object, e As EventArgs) Handles BtnCabeleireiroF.Click
        SelectCabeleireiroF()
    End Sub

    Private Sub BtnCabeleireiroFMenor_Click(sender As Object, e As EventArgs) Handles BtnCabeleireiroFMenor.Click
        SelectCabeleireiroF()
    End Sub

    Private Sub SelectCabeleireiroF()
        PnlPositionActive.Visible = True
        Me.PicTitle.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.titleCF
        If CF = False Then
            DgvAgenda.Columns.Clear()
        End If
        CF = True
        CM = False
        MP = False
        MS = False
        MQ = False
        ES = False
        CmbServico.Items.Clear()
        CmbProfissional.Items.Clear()
        CmbProfissional.Text = ""
        CmbServico.Text = ""
        PnlPositionActive.Height = BtnCabeleireiroF.Height
        PnlPositionActive.Top = BtnCabeleireiroF.Top
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE IDCARGO = 3 ORDER BY NOME ASC"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbProfissional.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnCabeleireiroM_Click(sender As Object, e As EventArgs) Handles BtnCabeleireiroM.Click
        SelectCabeleireiroM()
    End Sub

    Private Sub BtnCabeleireiroMMenor_Click(sender As Object, e As EventArgs) Handles BtnCabeleireiroMMenor.Click
        SelectCabeleireiroM()
    End Sub

    Private Sub SelectCabeleireiroM()
        PnlPositionActive.Visible = True
        Me.PicTitle.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.titleCM
        If CM = False Then
            DgvAgenda.Columns.Clear()
        End If
        CF = False
        CM = True
        MP = False
        MS = False
        MQ = False
        ES = False
        CmbServico.Items.Clear()
        CmbProfissional.Items.Clear()
        CmbProfissional.Text = ""
        CmbServico.Text = ""
        PnlPositionActive.Height = BtnCabeleireiroM.Height
        PnlPositionActive.Top = BtnCabeleireiroM.Top
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE IDCARGO = 3 ORDER BY NOME ASC"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbProfissional.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnManPed_Click(sender As Object, e As EventArgs) Handles BtnManPed.Click
        SelectManPed()
    End Sub

    Private Sub BtnManPedMenor_Click(sender As Object, e As EventArgs) Handles BtnManPedMenor.Click
        SelectManPed()
    End Sub

    Private Sub SelectManPed()
        PnlPositionActive.Visible = True
        Me.PicTitle.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.TitleMP
        If MP = False Then
            DgvAgenda.Columns.Clear()
        End If
        CF = False
        CM = False
        MP = True
        MS = False
        MQ = False
        ES = False
        CmbServico.Items.Clear()
        CmbProfissional.Items.Clear()
        CmbProfissional.Text = ""
        CmbServico.Text = ""
        PnlPositionActive.Height = BtnManPed.Height
        PnlPositionActive.Top = BtnManPed.Top
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE IDCARGO = 4 ORDER BY NOME ASC"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbProfissional.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnMaquiagem_Click(sender As Object, e As EventArgs) Handles BtnMaquiagem.Click
        SelectMaquiagem()
    End Sub

    Private Sub BtnMaquiagemMenor_Click(sender As Object, e As EventArgs) Handles BtnMaquiagemMenor.Click
        SelectMaquiagem()
    End Sub

    Private Sub SelectMaquiagem()
        PnlPositionActive.Visible = True
        Me.PicTitle.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.titleMQ
        If MQ = False Then
            DgvAgenda.Columns.Clear()
        End If
        CF = False
        CM = False
        MP = False
        MS = False
        MQ = True
        ES = False
        CmbServico.Items.Clear()
        CmbProfissional.Items.Clear()
        CmbProfissional.Text = ""
        CmbServico.Text = ""
        PnlPositionActive.Height = BtnMaquiagem.Height
        PnlPositionActive.Top = BtnMaquiagem.Top
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE IDCARGO = 7 ORDER BY NOME ASC"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbProfissional.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnMassagem_Click(sender As Object, e As EventArgs) Handles BtnMassagem.Click
        SelectMassagem()
    End Sub

    Private Sub BtnMassagemMenor_Click(sender As Object, e As EventArgs) Handles BtnMassagemMenor.Click
        SelectMassagem()
    End Sub

    Private Sub SelectMassagem()
        PnlPositionActive.Visible = True
        Me.PicTitle.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.titleMS
        If ES = False Then
            DgvAgenda.Columns.Clear()
        End If
        CF = False
        CM = False
        MP = False
        MS = True
        MQ = False
        ES = False
        CmbServico.Items.Clear()
        CmbProfissional.Items.Clear()
        CmbProfissional.Text = ""
        CmbServico.Text = ""
        PnlPositionActive.Height = BtnMassagem.Height
        PnlPositionActive.Top = BtnMassagem.Top
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE IDCARGO = 5 ORDER BY NOME ASC"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbProfissional.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnEstetica_Click(sender As Object, e As EventArgs) Handles BtnEstetica.Click
        SelectEstetica()
    End Sub

    Private Sub BtnEsteticaMenor_Click(sender As Object, e As EventArgs) Handles BtnEsteticaMenor.Click
        SelectEstetica()
    End Sub

    Private Sub DgvAgenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAgenda.CellContentClick
        Dim contLinha As Integer
        Try
            With DgvAgenda
                agenda = False
                If (CmbProfissional.Text = "" Or CmbServico.Text = "") And .CurrentRow.Cells(3).Value = "" And .CurrentRow.Cells(7).Selected = True Then
                    MsgBox("Selecione um serviço!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                ElseIf CmbProfissional.Text <> "" And .CurrentRow.Cells(3).Value <> "" And .CurrentRow.Cells(7).Selected = True Then
                    resp = MsgBox("Deseja editar o agendamento? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        agenda = False
                        id = .CurrentRow.Cells(5).Value.ToString
                        SHowFormAgendamento()
                    End If
                End If
                If CmbProfissional.Text <> "" And CmbServico.Text <> "" Then
                    If .CurrentRow.Cells(3).Value = "" Then
                        If .CurrentRow.Cells(7).Selected = True Then
                            sql = "SELECT * FROM TBSERVICO WHERE FUNCIONARIO = '" & CmbProfissional.Text & "' AND SERVICO = '" & CmbServico.Text & "'"
                            rs = db.Execute(sql)
                            sql = "SELECT * FROM TBSERVICO WHERE IDSERVICO = " & rs.Fields(0).Value & ""
                            rsAux = db.Execute(sql)
                            If rsAux.Fields(7).Value > "00:30" And rsAux.Fields(7).Value < "01:00" Then
                                contLinha = .CurrentRow.Index
                                If .Rows(contLinha + 1).Cells(3).Value <> "" Then
                                    ErroMensagem()
                                    Exit Sub
                                End If
                            ElseIf rsAux.Fields(7).Value >= "01:00" And rsAux.Fields(7).Value < "01:30" Then
                                For a = 1 To 2 Step 1
                                    If .Rows(contLinha + a).Cells(3).Value <> "" Then
                                        ErroMensagem()
                                        Exit Sub
                                    End If
                                Next
                            ElseIf rsAux.Fields(7).Value >= "01:30" And rsAux.Fields(7).Value < "02:00" Then
                                For a = 1 To 3 Step 1
                                    If .Rows(contLinha + a).Cells(3).Value <> "" Then
                                        ErroMensagem()
                                        Exit Sub
                                    End If
                                Next
                            ElseIf rsAux.Fields(7).Value >= "02:00" And rsAux.Fields(7).Value < "02:30" Then
                                For a = 1 To 4 Step 1
                                    If .Rows(contLinha + a).Cells(3).Value <> "" Then
                                        ErroMensagem()
                                        Exit Sub
                                    End If
                                Next
                            ElseIf rsAux.Fields(7).Value >= "02:30" And rsAux.Fields(7).Value < "03:00" Then
                                For a = 1 To 5 Step 1
                                    If .Rows(contLinha + a).Cells(3).Value <> "" Then
                                        ErroMensagem()
                                        Exit Sub
                                    End If
                                Next
                            ElseIf rsAux.Fields(7).Value >= "03:00" And rsAux.Fields(7).Value < "03:30" Then
                                For a = 1 To 6 Step 1
                                    If .Rows(contLinha + a).Cells(3).Value <> "" Then
                                        ErroMensagem()
                                        Exit Sub
                                    End If
                                Next
                            End If
                            aux = .CurrentRow.Cells(0).Value.ToString
                            d = TxtData.Text
                            agenda = True
                            cliente = ""
                            cpfCliente = ""
                            FrmAgendamento.Show()
                        End If
                    End If

                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SelectEstetica()
        PnlPositionActive.Visible = True
        Me.PicTitle.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.titleES
        If ES = False Then
            DgvAgenda.Columns.Clear()
        End If
        CF = False
        CM = False
        MP = False
        MS = False
        MQ = False
        ES = True
        CmbServico.Items.Clear()
        CmbProfissional.Items.Clear()
        CmbProfissional.Text = ""
        CmbServico.Text = ""
        PnlPositionActive.Height = BtnEstetica.Height
        PnlPositionActive.Top = BtnEstetica.Top
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE IDCARGO = 6 ORDER BY NOME ASC"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbProfissional.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub CmbProfissional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProfissional.SelectedIndexChanged
        CmbServico.Items.Clear()
        If CF Then
            sql = "SELECT * FROM TBSERVICO WHERE FUNCIONARIO = '" & CmbProfissional.Text & "' AND SERVICO LIKE 'F%'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                CmbServico.Items.Add(rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        ElseIf CM Then
            sql = "SELECT * FROM TBSERVICO WHERE FUNCIONARIO = '" & CmbProfissional.Text & "' AND SERVICO LIKE 'M%'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                CmbServico.Items.Add(rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        Else
            sql = "SELECT * FROM TBSERVICO WHERE FUNCIONARIO = '" & CmbProfissional.Text & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                CmbServico.Items.Add(rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End If
        LoadAgenda()
    End Sub

    Private Sub TxtData_ValueChanged(sender As Object, e As EventArgs) Handles TxtData.ValueChanged
        If CmbProfissional.Text = "" Then
            Exit Sub
        Else
            LoadAgenda()
        End If
    End Sub

    Public Sub LoadAgenda()
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


        agendar = New DataGridViewImageColumn With {
            .Width = 10,
            .Name = "Agendar",
            .HeaderText = "Agendar",
            .Image = Global.spaBelezaOficial.My.Resources.Resources.agenda
        }
        DgvAgenda.Columns.Add(agendar)

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
        sql = "SELECT * FROM TBAGENDA WHERE FUNCIONARIO = '" & CmbProfissional.Text & "' AND DATASERVICO = '" & TxtData.Text & "' AND CANCELADO = 0 ORDER BY HORARIOENTRADA ASC"
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
                                    'contRows += 1
                                    '.Rows(contRows).Cells(0).Selected = True
                                    'If rs.Fields(14).Value > 0 Then
                                    '.CurrentRow.DefaultCellStyle.BackColor = Color.Red
                                    'End If
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
                                'contRows += 1
                                '.Rows(contRows).Cells(0).Selected = True
                            End If
                        Else
                            .Rows.Add(vetor(cont), Nothing, Nothing, Nothing, Nothing, Nothing)
                            'contRows += 1
                            '.Rows(contRows).Cells(0).Selected = True
                        End If
                    Next
                End While
            End If
        End With
    End Sub

    Private Sub ErroMensagem()
        MsgBox("Não é possível cadastrar devido as horas!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    End Sub
End Class