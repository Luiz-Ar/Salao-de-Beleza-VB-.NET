Public Class FrmControleGeral
    Dim n
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

    Private Sub FrmControleGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()
        PnlClean.Visible = True
        PnlCargos.Visible = False
        PnlFuncionarios.Visible = False
        PnlTipoServico.Visible = False
        PnlServicos.Visible = False
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

    Private Sub BtnCargos_Click(sender As Object, e As EventArgs) Handles BtnCargos.Click
        PnlClean.Visible = False
        PnlCargos.Visible = True
        PnlFuncionarios.Visible = False
        PnlTipoServico.Visible = False
        PnlServicos.Visible = False
        LimparCargo()
    End Sub

    Private Sub BtnFuncionarios_Click(sender As Object, e As EventArgs) Handles BtnFuncionarios.Click
        LimparFuncionarios()
        PnlClean.Visible = False
        PnlCargos.Visible = False
        PnlFuncionarios.Visible = True
        PnlTipoServico.Visible = False
        PnlServicos.Visible = False
        SelecionarCargos()
    End Sub

    Private Sub BtnTipoServico_Click(sender As Object, e As EventArgs) Handles BtnTipoServico.Click
        PnlClean.Visible = False
        TxtIdTipoServico.Enabled = True
        PnlCargos.Visible = False
        PnlFuncionarios.Visible = False
        PnlTipoServico.Visible = True
        PnlServicos.Visible = False
        LimparTipoServico()
    End Sub

    Private Sub BtnServico_Click(sender As Object, e As EventArgs) Handles BtnServico.Click
        PnlClean.Visible = False
        PnlCargos.Visible = False
        PnlFuncionarios.Visible = False
        PnlTipoServico.Visible = False
        PnlServicos.Visible = True
        LimparServico()
        SelecionarServico()
    End Sub

    Private Sub PicIdCargos_Click(sender As Object, e As EventArgs) Handles PicIdCargos.Click
        TxtIdCargo.Select()
    End Sub

    Private Sub PicCargos_Click(sender As Object, e As EventArgs) Handles PicCargos.Click
        TxtCargo.Select()
    End Sub

    Private Sub BtnLimparCargo_Click(sender As Object, e As EventArgs) Handles BtnLimparCargo.Click
        LimparCargo()
    End Sub

    Private Sub LimparCargo()
        TxtIdCargo.Enabled = True
        TxtIdCargo.Clear()
        TxtCargo.Clear()
        n = 0
        sql = "select * from tbCargos"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtIdCargo.Text = n + 1
        TxtIdCargo.Enabled = False
    End Sub

    Private Sub BtnCadastrarCargo_Click(sender As Object, e As EventArgs) Handles BtnCadastrarCargo.Click
        If TxtIdCargo.Text = "" Or TxtCargo.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "insert into tbCargos values ('" & TxtIdCargo.Text & "','" & TxtCargo.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Cargo cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            LimparCargo()
        End If
    End Sub

    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub LimparFuncionarios()
        TxtCpf.Clear()
        TxtNome.Clear()
        TxtDataNascimento.Clear()
        TxtIdCargoFuncionario.Clear()
        TxtCep.Clear()
        TxtEndereco.Clear()
        TxtComp.Clear()
        TxtBairro.Clear()
        TxtCidade.Clear()
        TxtEstado.Clear()
        TxtTelefone.Clear()
        TxtCelular.Clear()
        TxtEmail.Clear()
        TxtSenha.Clear()
        TxtRSenha.Clear()
        CbSenha.Checked = False
        SelecionarCargos()
    End Sub

    Private Sub BtnLimparFuncionarios_Click(sender As Object, e As EventArgs) Handles BtnLimparFuncionarios.Click
        LimparFuncionarios()
        TxtCpf.Select()
    End Sub

    Private Sub TxtCep_TextChanged(sender As Object, e As EventArgs) Handles TxtCep.TextChanged
        Try
            If TxtCep.MaskCompleted Then
                sql = "select * from tbCep where CEP = '" & TxtCep.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    'TxtCep.Enabled = False
                    TxtEndereco.Text = rs.Fields(1).Value
                    TxtEndereco.Enabled = False
                    TxtCidade.Text = rs.Fields(2).Value
                    TxtBairro.Enabled = False
                    TxtBairro.Text = rs.Fields(3).Value
                    TxtCidade.Enabled = False
                    TxtEstado.Text = rs.Fields(4).Value
                    TxtEstado.Enabled = False
                Else
                    resp = MsgBox("CEP NÃO CADASTRADO NA BASE!, Deseja cadastrar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
                    If resp = vbYes Then
                        ShowFormCep()
                    Else
                        TxtCep.Clear()
                        TxtEndereco.Clear()
                        TxtCidade.Clear()
                        TxtBairro.Clear()
                        TxtEstado.Clear()
                        TxtEndereco.Enabled = True
                        TxtCidade.Enabled = True
                        TxtBairro.Enabled = True
                        TxtEstado.Enabled = True
                        TxtCep.Select()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CbSenha_CheckedChanged(sender As Object, e As EventArgs) Handles CbSenha.CheckedChanged
        If CbSenha.Checked Then
            TxtSenha.PasswordChar = ""
            TxtRSenha.PasswordChar = ""
        Else
            TxtSenha.PasswordChar = "•"
            TxtRSenha.PasswordChar = "•"
        End If
    End Sub

    Private Sub SelecionarServico()
        CmbTipoServico.Items.Clear()
        CmbTipoServico.Text = ""
        sql = "Select * from tbTipoServico order by TipoServico"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbTipoServico.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub
    Private Sub SelecionarCargos()
        CmbFuncionarios.Items.Clear()
        CmbFuncionarios.Text = ""
        sql = "select * from tbCargos"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            CmbFuncionarios.Items.Add(rs.Fields(1).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnCadastrarFuncionarios_Click(sender As Object, e As EventArgs) Handles BtnCadastrarFuncionarios.Click
        Try
            If TxtCpf.MaskCompleted = False Or TxtNome.Text = "" Or TxtDataNascimento.MaskCompleted = False Or CmbFuncionarios.Text = "" Or TxtIdCargoFuncionario.Text = "" Or TxtCep.MaskCompleted = False Or TxtEndereco.Text = "" Or TxtComp.Text = "" Or TxtBairro.Text = "" Or TxtCidade.Text = "" Or TxtEstado.Text = "" Or TxtTelefone.MaskCompleted = False Or TxtCelular.MaskCompleted = False Or TxtEmail.Text = "" Or TxtSenha.Text = "" Or TxtRSenha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                If TxtSenha.Text <> TxtRSenha.Text Then
                    MsgBox("As senhas não coincidem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    sql = "insert into tbFuncionarios values ('" & TxtCpf.Text & "', '" & TxtNome.Text & "'," &
                          "'" & TxtDataNascimento.Text & "', '" & TxtIdCargoFuncionario.Text & "', '" & CmbFuncionarios.Text & "'," &
                          "'" & TxtCep.Text & "', '" & TxtEndereco.Text & "', '" & TxtComp.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "'," &
                          "'" & TxtEstado.Text & "', '" & TxtTelefone.Text & "', '" & TxtCelular.Text & "', '" & TxtEmail.Text & "'," &
                          "'" & TxtSenha.Text & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Funcionário Cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    LimparFuncionarios()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbFuncionarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFuncionarios.SelectedIndexChanged
        TxtIdCargoFuncionario.Enabled = True
        If CmbFuncionarios.Text <> "" Then
            sql = "select * from tbCargos where cargo = '" & CmbFuncionarios.Text & "'"
            rs = db.Execute(sql)
            TxtIdCargoFuncionario.Text = rs.Fields(0).Value
            TxtIdCargoFuncionario.Enabled = False
        End If
    End Sub

    Private Sub LimparTipoServico()
        TxtIdTipoServico.Clear()
        TxtTipoServico.Clear()
        TxtIdTipoServico.Enabled = True
        sql = "select * from tbTipoServico"
        rs = db.Execute(sql)
        n = 0
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtIdTipoServico.Text = n + 1
        TxtIdTipoServico.Enabled = False
    End Sub

    Private Sub BtnCadastrarTipoServico_Click(sender As Object, e As EventArgs) Handles BtnCadastrarTipoServico.Click
        Try
            If TxtIdTipoServico.Text = "" Or TxtTipoServico.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "insert into tbTipoServico values ('" & TxtIdTipoServico.Text & "','" & TxtTipoServico.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Tipo de Serviço cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparTipoServico()
                TxtTipoServico.Select()
            End If
        Catch ex As Exception
            MsgBox("Tipo de Serviço NÃO cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            LimparTipoServico()
        End Try
    End Sub

    Private Sub BtnLimparTipoServico_Click(sender As Object, e As EventArgs) Handles BtnLimparTipoServico.Click
        LimparTipoServico()
    End Sub

    Private Sub LimparServico()
        Try
            TxtIdServico.Enabled = True
            TxtIdServico.Clear()
            TxtIdTipoServico2.Clear()
            TxtServico.Clear()
            TxtCpfFuncionario.Clear()
            TxtPreco.Clear()
            TxtTempo.Clear()
            CmbFuncionario.Items.Clear()
            CmbFuncionario.Text = ""
            CmbTipoServico.Items.Clear()
            CmbTipoServico.Text = ""
            SelecionarServico()
            sql = "select * from tbServico"
            rs = db.Execute(sql)
            n = 0
            Do While rs.EOF = False
                n += 1
                rs.MoveNext()
            Loop
            TxtIdServico.Text = n + 1
            TxtIdServico.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnLimparServico_Click(sender As Object, e As EventArgs) Handles BtnLimparServico.Click
        LimparServico()
    End Sub

    Private Sub CmbTipoServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoServico.SelectedIndexChanged
        If CmbTipoServico.Text <> "" Then
            TxtIdTipoServico2.Enabled = True
            sql = "select * from tbTipoServico where TipoServico = '" & CmbTipoServico.Text & "'"
            rs = db.Execute(sql)
            TxtIdTipoServico2.Text = rs.Fields(0).Value
            TxtIdTipoServico2.Enabled = False
            sql = "select * from tbFuncionarios where cargo = '" & CmbTipoServico.Text & "'"
            rs = db.Execute(sql)
            CmbFuncionario.Items.Clear()
            Do While rs.EOF = False
                    CmbFuncionario.Items.Add(rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End If
    End Sub

    Private Sub BtnCadastrarServico_Click(sender As Object, e As EventArgs) Handles BtnCadastrarServico.Click
        If TxtIdServico.Text = "" Or CmbTipoServico.Text = "" Or TxtIdTipoServico2.Text = "" Or TxtServico.Text = "" Or CmbFuncionario.Text = "" Or TxtPreco.Text = "" Or TxtTempo.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            'sql = "insert into tbServico values ('" & TxtIdServico.Text & "','" & TxtIdTipoServico2.Text & "', '" & CmbTipoServico.Text & "','" & TxtServico.Text & "', '" & TxtCpfFuncionario.Text & "', '" & CmbFuncionario.Text & "','" & TxtPreco.Text & "', '" & TxtTempo.Text & "')"
            sql = "insert into tbServico (idServico, idTipoServico, tipoServico, servico, cpfFuncionario, funcionario, precoServico, tempoServico) values ('" & TxtIdServico.Text & "', '" & TxtIdTipoServico2.Text & "', '" & CmbTipoServico.Text & "', '" & TxtServico.Text & "', '" & TxtCpfFuncionario.Text & "', '" & CmbFuncionario.Text & "', '" & TxtPreco.Text & "', '" & TxtTempo.Text & "')"
            rs = db.Execute(UCase(sql))

            MsgBox("Serviço cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            LimparServico()
            CmbTipoServico.Select()
        End If
    End Sub

    Private Sub LlCargos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            ShowFormDgv()
            sql = "select * from tbCargos order by cargo asc"
            rs = db.Execute(sql)
            cod = 1
            With FrmShow.DgvGeral
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cod, rs.Fields(1).Value, Nothing)
                    rs.MoveNext()
                    cod += 1
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PicLogOut_Click(sender As Object, e As EventArgs) Handles PicLogOut.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TxtIdTipoServico.Select()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        TxtTipoServico.Select()
    End Sub

    Private Sub PicIdServico_Click(sender As Object, e As EventArgs) Handles PicIdServico.Click
        TxtIdServico.Select()
    End Sub

    Private Sub PicTipoServico_Click(sender As Object, e As EventArgs) Handles PicTipoServico.Click
        CmbTipoServico.Select()
    End Sub

    Private Sub PicIdTipoServico_Click(sender As Object, e As EventArgs) Handles PicIdTipoServico.Click
        TxtIdTipoServico2.Select()
    End Sub

    Private Sub PicServico_Click(sender As Object, e As EventArgs) Handles PicServico.Click
        TxtServico.Select()
    End Sub

    Private Sub PicCpfFuncionarioServico_Click(sender As Object, e As EventArgs) Handles PicCpfFuncionarioServico.Click
        TxtCpfFuncionario.Select()
    End Sub

    Private Sub PicFuncionarioServico_Click(sender As Object, e As EventArgs) Handles PicFuncionarioServico.Click
        CmbFuncionario.Select()
    End Sub

    Private Sub PicPreco_Click(sender As Object, e As EventArgs) Handles PicPreco.Click
        TxtPreco.Select()
    End Sub

    Private Sub PicTempo_Click(sender As Object, e As EventArgs) Handles PicTempo.Click
        TxtTempo.Select()
    End Sub

    Private Sub PicCpf_Click(sender As Object, e As EventArgs) Handles PicCpf.Click
        TxtCpf.Select()
    End Sub

    Private Sub PicData_Click(sender As Object, e As EventArgs) Handles PicData.Click
        TxtDataNascimento.Select()
    End Sub

    Private Sub PicNome_Click(sender As Object, e As EventArgs) Handles PicNome.Click
        TxtNome.Select()
    End Sub

    Private Sub PicCargo_Click(sender As Object, e As EventArgs) Handles PicCargo.Click
        CmbFuncionarios.Select()
    End Sub

    Private Sub PicIdCargo_Click(sender As Object, e As EventArgs) Handles PicIdCargo.Click
        TxtIdCargoFuncionario.Select()
    End Sub

    Private Sub PicCep_Click(sender As Object, e As EventArgs) Handles PicCep.Click
        TxtCep.Select()
    End Sub

    Private Sub PicEndereco_Click(sender As Object, e As EventArgs) Handles PicEndereco.Click
        TxtEndereco.Select()
    End Sub

    Private Sub PicComp_Click(sender As Object, e As EventArgs) Handles PicComp.Click
        TxtComp.Select()
    End Sub

    Private Sub PicBairro_Click(sender As Object, e As EventArgs) Handles PicBairro.Click
        TxtBairro.Select()
    End Sub

    Private Sub PicCidade_Click(sender As Object, e As EventArgs) Handles PicCidade.Click
        TxtCidade.Select()
    End Sub

    Private Sub PicEstado_Click(sender As Object, e As EventArgs) Handles PicEstado.Click
        TxtEstado.Select()
    End Sub

    Private Sub PicTelefone_Click(sender As Object, e As EventArgs) Handles PicTelefone.Click
        TxtTelefone.Select()
    End Sub

    Private Sub PicCelular_Click(sender As Object, e As EventArgs) Handles PicCelular.Click
        TxtCelular.Select()
    End Sub

    Private Sub PicEmail_Click(sender As Object, e As EventArgs) Handles PicEmail.Click
        TxtEmail.Select()
    End Sub

    Private Sub PicSenha_Click(sender As Object, e As EventArgs) Handles PicSenha.Click
        TxtSenha.Select()
    End Sub

    Private Sub PicRsenha_Click(sender As Object, e As EventArgs) Handles PicRsenha.Click
        TxtRSenha.Select()
    End Sub

    Private Sub CmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFuncionario.SelectedIndexChanged
        TxtCpfFuncionario.Enabled = True
        sql = "select * from tbFuncionarios where nome = '" & CmbFuncionario.Text & "'"
        rs = db.Execute(sql)
        TxtCpfFuncionario.Text = rs.Fields(0).Value
        TxtCpfFuncionario.Enabled = False
    End Sub

    Private Sub BtnSeeAll_Click(sender As Object, e As EventArgs) Handles BtnSeeAll.Click
        frmVisualizar.Show()
    End Sub
End Class