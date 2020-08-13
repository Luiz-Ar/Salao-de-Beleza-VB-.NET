Public Class FrmControleCliente

    Private Sub FrmControleCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConectaBanco()
            ArredondarLados()
            If cpf Then
                TxtCpf.Text = FrmAgendamento.TxtCpfCliente.Text
                cpf = False
                TxtDataNascimento.Select()
            End If
            CmbSexo.Items.Add("FEMININO")
            CmbSexo.Items.Add("MASCULINO")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        Me.Close()
    End Sub

    Private Sub PicMinimizar_Click(sender As Object, e As EventArgs) Handles PicMinimizar.Click
        Me.WindowState = WindowState.Minimized
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

    Private Sub BtnCadastrarCliente_Click(sender As Object, e As EventArgs)
        Try
            If TxtCpf.MaskCompleted = False Or TxtNome.Text = "" Or TxtDataNascimento.MaskCompleted = False Or TxtCep.Text = "" Or TxtComp.Text = "" Or TxtTelefone.MaskCompleted = False Or TxtCelular.MaskCompleted = False Or TxtEmail.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "insert into tbClientes values ('" & TxtCpf.Text & "', " &
                          "'" & TxtNome.Text & "', " &
                          "'" & TxtDataNascimento.Text & "', " &
                          "'" & TxtCep.Text & "', " &
                          "'" & TxtEndereco.Text & "', " &
                          "'" & TxtComp.Text & "', " &
                          "'" & TxtBairro.Text & "', " &
                          "'" & TxtCidade.Text & "', " &
                          "'" & TxtEstado.Text & "', " &
                          "'" & TxtTelefone.Text & "', " &
                          "'" & TxtCelular.Text & "', " &
                          "'" & TxtEmail.Text & "', " &
                          "'" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cliente Cadastrado!")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxtCep_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Dim FrmControleCliente = New FrmControleCliente
        Me.Close()
        FrmControleCliente.Show()
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
                        PnlCadastroClientes.Visible = False
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

    Private Sub BtnCadastrarCliente_Click_1(sender As Object, e As EventArgs) Handles BtnCadastrarCliente.Click
        If TxtCpf.MaskCompleted = False Or TxtDataNascimento.MaskCompleted = False Or TxtNome.Text = "" Or TxtCpf.MaskCompleted = False Or TxtComp.Text = "" Or TxtTelefone.MaskCompleted = False Or TxtCelular.MaskCompleted = False Or TxtEmail.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "SELECT * FROM TBCLIENTES WHERE CPFCLIENTE = '" & TxtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("CPF JÁ CADASTRADO", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "INSERT INTO TBCLIENTES VALUES('" & TxtCpf.Text & "', '" & TxtNome.Text & "', '" & TxtDataNascimento.Text & "', '" & TxtCep.Text & "', '" & TxtEndereco.Text & "', '" & TxtComp.Text & "', '" & TxtBairro.Text & "', '" & TxtCidade.Text & "', '" & TxtEstado.Text & "', '" & TxtTelefone.Text & "', '" & TxtCelular.Text & "', '" & TxtEmail.Text & "', '" & diretorio & "', '" & CmbSexo.Text & "')"
                db.Execute(UCase(sql))
                db2.Execute(UCase(sql))
                MsgBox("CLIENTE CADASTRADO COM SUCESSO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Me.Close()
                ShowFormCliente()
                TxtCpf.Select()
            End If
        End If
    End Sub
    Private Sub CarregarImagem()
        Me.Ofd1.Multiselect = False
        Me.Ofd1.Title = "Selecionar Foto do Cliente"
        Ofd1.InitialDirectory = Application.StartupPath & "\fotos\"
        Ofd1.Filter = "Imagens (*jpg;*bmp;*.png)|*jpg;*.bmp;*.png"
        If Ofd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            diretorio = Ofd1.FileName
        End If
    End Sub

    Private Sub BtnPicCliente_Click(sender As Object, e As EventArgs) Handles BtnPicCliente.Click
        CarregarImagem()
    End Sub

    Private Sub TxtDataNascimento_Leave(sender As Object, e As EventArgs) Handles TxtDataNascimento.Leave
        If IsDate(TxtDataNascimento.Text) = False Or TxtDataNascimento.MaskCompleted = False Then
            If TxtDataNascimento.Text = "  /  /" Then
                Exit Sub
            End If
            MsgBox("Data inválida! Digite uma data válida", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            TxtDataNascimento.Text = ""
            TxtDataNascimento.Select()
        End If
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        Try
            Dim ContRows, ContValor As Integer
            ContRows = 0
            ContValor = 0
            DgvClientes.Rows.Clear()
            If CbData.CheckState = 0 Then
                sql = "SELECT * FROM TBAGENDA WHERE CLIENTE LIKE '" & TxtPesquisar.Text & "%' ORDER BY DATASERVICO DESC"
                rs = db.Execute(sql)
                sql = "SELECT * FROM TBTIPOSERVICO WHERE IDTIPOSERVICO = " & rs.Fields(3).Value & ""
                rsAux = db.Execute(sql)
                LoadDataGridClientes()
                With DgvClientes
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(6).Value, rs.Fields(7).Value, rsAux.Fields(1).Value, rs.Fields(5).Value, rs.Fields(8).Value, rs.Fields(2).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            Else
                sql = "SELECT * FROM TBAGENDA WHERE CLIENTE LIKE '" & TxtPesquisar.Text & "%' AND DATASERVICO BETWEEN '" & FormatDateTime(TxtDataInicial.Text, DateFormat.ShortDate) & "' AND '" & FormatDateTime(TxtDataFinal.Text, DateFormat.ShortDate) & "' ORDER BY DATASERVICO ASC "
                rs = db.Execute(sql)
                sql = "SELECT * FROM TBTIPOSERVICO WHERE IDTIPOSERVICO = " & rs.Fields(3).Value & ""
                rsAux = db.Execute(sql)
                LoadDataGridClientes()
                With DgvClientes
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(10).Value, rs.Fields(6).Value, rs.Fields(7).Value, rsAux.Fields(1).Value, rs.Fields(5).Value, rs.Fields(8).Value, rs.Fields(2).Value)
                        rs.MoveNext()
                        ContRows += 1
                    Loop
                End With
            End If
            LblQtde.Text = ContRows.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadDataGridClientes()
        Try
            With DgvClientes
                .ColumnCount = 7

                .Columns(0).Name = "DATA SERVICO"
                .Columns(0).HeaderText = "DATA SERVICO"
                .Columns(0).DataPropertyName = "DATA SERVICO"

                .Columns(1).Name = "CPF CLIENTE"
                .Columns(1).HeaderText = "CPF CLIENTE"
                .Columns(1).DataPropertyName = "CPF CLIENTE"

                .Columns(2).Name = "NOME CLIENTE"
                .Columns(2).HeaderText = "NOME CLIENTE"
                .Columns(2).DataPropertyName = "NOME CLIENTE"

                .Columns(3).Name = "TIPO SERVICO"
                .Columns(3).HeaderText = "TIPO SERVICO"
                .Columns(3).DataPropertyName = "TIPO SERVICO"

                .Columns(4).Name = "SERVICO"
                .Columns(4).HeaderText = "SERVICO"
                .Columns(4).DataPropertyName = "SERVICO"

                .Columns(5).Name = "HORARIO"
                .Columns(5).HeaderText = "HORARIO"
                .Columns(5).DataPropertyName = "HORARIO"

                .Columns(6).Name = "FUNCIONARIO"
                .Columns(6).HeaderText = "FUNCIONARIO"
                .Columns(6).DataPropertyName = "FUNCIONARIO"
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class