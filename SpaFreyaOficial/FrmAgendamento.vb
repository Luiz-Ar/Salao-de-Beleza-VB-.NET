Public Class FrmAgendamento
    Dim n As Integer
    Dim a As Boolean
    Private Sub Agendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()
        LimparAgendamento()
        cpf = False
        If agenda Then
            TxtData.Text = d
            TxtHora.Text = aux
            sql = "SELECT * FROM TBFUNCIONARIOS WHERE NOME = '" & FrmMain.CmbProfissional.Text & "'"
            rs = db.Execute(sql)
            CmbTipoServico.Text = rs.Fields(4).Value
            CmbFuncionario.Text = FrmMain.CmbProfissional.Text
            CmbServico.Text = FrmMain.CmbServico.Text
            CmbTipoServico.Enabled = False
            CmbServico.Enabled = False
            CmbFuncionario.Enabled = False
            TxtHora.Enabled = False
            TxtData.Enabled = False
            agenda = False
            sql = "SELECT * FROM TBSERVICO WHERE SERVICO = '" & CmbServico.Text & "'"
            rs = db.Execute(sql)
            TxtValor.Text = FormatCurrency(rs.Fields(6).Value)
            TxtValor.Enabled = False
            TxtCpfCliente.Select()
        Else
            sql = "SELECT * FROM TBAGENDA WHERE IDAGENDA = " & id & ""
            rsAux = db.Execute(sql)
            TxtIdAgenda.Text = id
            TxtData.Text = rsAux.Fields(10).Value
            sql = "SELECT * FROM TBTIPOSERVICO WHERE '" & TxtIdTipoServico.Text & "'"
            rs = db.Execute(sql)
            CmbTipoServico.Text = rs.Fields(1).Value
            'CmbTipoServico.Text = rsAux.Fields(5).Value
            CmbFuncionario.Text = rsAux.Fields(2).Value
            TxtCpf.Text = rsAux.Fields(1).Value
            CmbServico.Text = rsAux.Fields(5).Value
            TxtIdServico.Text = rsAux.Fields(4).Value
            TxtIdTipoServico.Text = rsAux.Fields(3).Value
            TxtCpfCliente.Text = rsAux.Fields(6).Value
            TxtNome.Text = rsAux.Fields(7).Value
            TxtHora.Text = rsAux.Fields(8).Value
            TxtValor.Text = FormatCurrency(rsAux.Fields(9).Value)
            For cod = 11 To 13 Step 1
                If rsAux.Fields(cod).Value = 0 Then
                    id = 0
                Else
                    id = 1
                End If
                If cod = 11 Then
                    CbFinalizado.CheckState = id
                ElseIf cod = 12 Then
                    CbCancelado.CheckState = id
                Else
                    CbPago.CheckState = id
                End If
            Next
            TxtIdAgenda.Enabled = False
            TxtData.Enabled = False
            CmbFuncionario.Enabled = False
            TxtCpf.Enabled = False
            CmbServico.Enabled = False
            TxtIdServico.Enabled = False
            TxtIdTipoServico.Enabled = False
            TxtCpfCliente.Enabled = False
            TxtNome.Enabled = False
            TxtHora.Enabled = False
            TxtValor.Enabled = False
            CmbTipoServico.Enabled = False
            BtnLimpar.Enabled = False
        End If
        If CbFinalizado.CheckState = 1 And CbPago.CheckState = 1 Then
            BtnSalvar.Enabled = False
            BtnLimpar.Enabled = False
            CbFinalizado.Enabled = False
            CbCancelado.Enabled = False
            CbPago.Enabled = False
        End If
    End Sub
    Private Sub PnlTop2_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PnlTop2_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub PnlTop2_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseUp
        drag = False
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
        Me.Close()
    End Sub

    Private Sub PicMinimizar_Click(sender As Object, e As EventArgs) Handles PicMinimizar.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub TxtCpfCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCpfCliente.TextChanged
        If TxtCpfCliente.MaskCompleted = True Then
            sql = "SELECT * FROM TBCLIENTES WHERE CPFCLIENTE = '" & TxtCpfCliente.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                resp = MsgBox("Cliente não cadastrado! Deseja Cadastrar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    cpf = True
                    ShowFormCliente()
                End If
            Else
                TxtNome.Enabled = True
                TxtNome.Text = rs.Fields(1).Value
                TxtNome.Enabled = False
            End If
        End If
    End Sub

    Private Sub LimparAgendamento()
        TxtIdAgenda.Enabled = True
        n = 0
        sql = "SELECT * FROM TBAGENDA"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtIdAgenda.Text = n + 1
        TxtIdAgenda.Enabled = False
        CmbTipoServico.Items.Clear()
        CmbTipoServico.Text = ""
        CmbServico.Items.Clear()
        CmbServico.Text = ""
        TxtIdServico.Text = ""
        TxtIdTipoServico.Text = ""
        CmbFuncionario.Items.Clear()
        CmbFuncionario.Text = ""
        TxtCpf.Text = ""
        TxtCpfCliente.Text = ""
        TxtNome.Text = ""
        TxtHora.Text = ""
        TxtValor.Text = ""
        CbCancelado.CheckState = 0
        CbFinalizado.CheckState = 0
        sql = "SELECT * FROM TBTIPOSERVICO"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbTipoServico.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub CmbTipoServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoServico.SelectedIndexChanged
        CmbFuncionario.Items.Clear()
        CmbFuncionario.Text = ""
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE CARGO = '" & CmbTipoServico.Text & "'"
        rs = db.Execute(sql)
        Do Until rs.EOF
            CmbFuncionario.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub CmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFuncionario.SelectedIndexChanged
        CmbServico.Items.Clear()
        CmbServico.Text = ""
        TxtCpf.Enabled = True
        TxtCpf.Text = ""
        sql = "SELECT * FROM TBFUNCIONARIOS WHERE NOME = '" & CmbFuncionario.Text & "'"
        rs = db.Execute(sql)
        TxtCpf.Text = rs.Fields(0).Value
        sql = "SELECT * FROM TBSERVICO WHERE FUNCIONARIO = '" & CmbFuncionario.Text & "'"
        rs = db.Execute(sql)
        Do Until rs.EOF
            CmbServico.Items.Add(rs.Fields(3).Value)
            rs.MoveNext()
        Loop
        TxtCpf.Enabled = False
    End Sub

    Private Sub CmbServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServico.SelectedIndexChanged
        TxtIdServico.Enabled = True
        TxtIdTipoServico.Enabled = True
        sql = "SELECT * FROM TBSERVICO WHERE SERVICO = '" & CmbServico.Text & "' AND FUNCIONARIO = '" & CmbFuncionario.Text & "'"
        rs = db.Execute(sql)
        TxtIdServico.Text = rs.Fields(0).Value
        TxtIdTipoServico.Text = rs.Fields(1).Value
        TxtIdServico.Enabled = False
        TxtIdTipoServico.Enabled = False
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        SHowFormAgendamento()
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        sql = "SELECT * FROM TBAGENDA WHERE IDAGENDA = " & TxtIdAgenda.Text & ""
        rs = db.Execute(sql)
        If rs.EOF Then
            If TxtCpfCliente.MaskCompleted = False Then
                MsgBox("Preencha o CPF do cliente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                'd = TxtData.Value.Date.ToString
                sql = "INSERT INTO TBAGENDA (IDAGENDA, CPFFUNCIONARIO, FUNCIONARIO, " &
                  "IDTIPOSERVICO, IDSERVICO, SERVICO, CPFCLIENTE, CLIENTE, HORARIOENTRADA, " &
                  "VALORACORDADO, DATASERVICO, FINALIZADO, CANCELADO, PAGO) " &
                  "VALUES ('" & TxtIdAgenda.Text & "', " &
                  "'" & TxtCpf.Text & "', " &
                  "'" & CmbFuncionario.Text & "', " &
                  "'" & TxtIdTipoServico.Text & "', " &
                  "'" & TxtIdServico.Text & "', " &
                  "'" & CmbServico.Text & "', " &
                  "'" & TxtCpfCliente.Text & "', " &
                  "'" & TxtNome.Text & "', " &
                  "'" & TxtHora.Text & "', " &
                  "'" & TxtValor.Text & "', " &
                  "'" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "', " &
                  "'" & CbFinalizado.CheckState & "', " &
                  "'" & CbCancelado.CheckState & "', " &
                  "'" & CbPago.CheckState & "')"
                rs = db.Execute(UCase(sql))
                rs2 = db2.Execute(UCase(sql))
                MsgBox("AGENDADO COM SUCESSO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Me.Close()
            End If
        Else
            a = True
            UpdateAgendamento()
        End If
        FrmMain.LoadAgenda()
    End Sub

    Private Sub UpdateAgendamento()
        sql = "UPDATE TBAGENDA " &
                  "SET FINALIZADO = '" & CbFinalizado.CheckState & "', " &
                  "CANCELADO = '" & CbCancelado.CheckState & "', " &
                  "PAGO = '" & CbPago.CheckState & "'" &
                  "WHERE IDAGENDA = " & TxtIdAgenda.Text & ""
        rs = db.Execute(sql)
        rs2 = db2.Execute(sql)
        If a Then
            MsgBox("Agendamento Atualizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "SELECT * FROM TBAGENDA WHERE IDAGENDA = " & TxtIdAgenda.Text & ""
            rs = db.Execute(sql)
            cpfCliente = rs.Fields(6).Value
            aux = TxtData.Text
        End If
        Me.Close()
    End Sub

    Private Sub CbFinalizado_Click(sender As Object, e As EventArgs) Handles CbFinalizado.Click
        If CbFinalizado.CheckState = 1 Then
            resp = MsgBox("Deseja finalizar o serviço?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                a = False
                UpdateAgendamento()
                FrmServicoPrestado.Show()
            End If
        End If
    End Sub

End Class