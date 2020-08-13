Public Class FrmServicoPrestado
    Dim contLinha As Integer
    Dim valor As Integer
    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        Me.Close()
    End Sub

    Private Sub TxtCpfCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCpfCliente.TextChanged
        If TxtCpfCliente.MaskCompleted Then
            sql = "SELECT * FROM TBCLIENTES WHERE CPFCLIENTE = '" & TxtCpfCliente.Text & "'"
            rs = db.Execute(sql)
            TxtNome.Text = rs.Fields(1).Value
            TxtNome.Enabled = False
            TxtData.Text = aux
            TxtData.Enabled = False
        End If
    End Sub

    Private Sub FrmServicoPrestado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArredondarLados()
        Dim n As Integer
        n = 1
        sql = "SELECT * FROM TBSERVICOPRESTADO"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            n += 1
            rs.MoveNext()
        Loop
        TxtCpfCliente.Text = cpfCliente
        TxtCpfCliente.Enabled = False
        TxtIdPrestacao.Text = n
        TxtIdPrestacao.Enabled = False

        DgvServicos.ColumnCount = 6
        DgvServicos.Columns(0).Name = "ID SERVIÇO"
        DgvServicos.Columns(0).HeaderText = "ID SERVIÇO"
        DgvServicos.Columns(0).DataPropertyName = "ID SERVIÇO"

        DgvServicos.Columns(1).Name = "TIPO DE SERVIÇO"
        DgvServicos.Columns(1).HeaderText = "TIPO DE SERVIÇO"
        DgvServicos.Columns(1).DataPropertyName = "TIPO DE SERVIÇO"

        DgvServicos.Columns(2).Name = "SERVIÇO PRESTADO"
        DgvServicos.Columns(2).HeaderText = "SERVIÇO PRESTADO"
        DgvServicos.Columns(2).DataPropertyName = "SERVIÇO PRESTADO"

        DgvServicos.Columns(3).Name = "FUNCIONÁRIO"
        DgvServicos.Columns(3).HeaderText = "FUNCIONÁRIO"
        DgvServicos.Columns(3).DataPropertyName = "FUNCIONÁRIO"

        DgvServicos.Columns(4).Name = "TEMPO"
        DgvServicos.Columns(4).HeaderText = "TEMPO"
        DgvServicos.Columns(4).DataPropertyName = "TEMPO"

        DgvServicos.Columns(5).Name = "PREÇO"
        DgvServicos.Columns(5).HeaderText = "PREÇO"
        DgvServicos.Columns(5).DataPropertyName = "PREÇO"

        sql = "SELECT * FROM TBAGENDA WHERE CPFCLIENTE = '" & TxtCpfCliente.Text & "' AND  DATASERVICO = '" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "' ORDER BY HORARIOENTRADA ASC"
        rs = db.Execute(sql)

        With DgvServicos

            valor = 0
            .Rows.Clear()
            Do While rs.EOF = False
                sql = "SELECT * FROM TBTIPOSERVICO WHERE IDTIPOSERVICO = " & rs.Fields(3).Value & ""
                rsAux = db.Execute(sql)
                .Rows.Add(rs.Fields(0).Value, rsAux.Fields(1).Value, rs.Fields(5).Value, rs.Fields(2).Value, rs.Fields(8).Value, FormatCurrency(rs.Fields(9).Value))
                valor += rs.Fields(9).Value
                contLinha += 1
                rs.MoveNext()
            Loop
            TxtValor.Text = FormatCurrency(valor)
            TxtValor.Enabled = False
        End With
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
    Private Sub CbCredito_Click(sender As Object, e As EventArgs) Handles CbCredito.Click
        If CbCredito.CheckState = 1 Then
            CbDebito.CheckState = 0
            CbDinheiro.CheckState = 0
        End If
    End Sub

    Private Sub CbDebito_Click(sender As Object, e As EventArgs) Handles CbDebito.Click
        If CbDebito.CheckState = 1 Then
            CbCredito.CheckState = 0
            CbDinheiro.CheckState = 0
        End If
    End Sub

    Private Sub CbDinheiro_Click(sender As Object, e As EventArgs) Handles CbDinheiro.Click
        If CbDinheiro.CheckState = 1 Then
            CbCredito.CheckState = 0
            CbDebito.CheckState = 0
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If CbCredito.CheckState = 0 And CbDebito.CheckState = 0 And CbDinheiro.CheckState = 0 Then
            MsgBox("Preencha a forma de pagamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If
        If TextDesconto.Text = "" Then
            TextDesconto.Text = 0
        End If
        sql = "INSERT INTO TBSERVICOPRESTADO VALUES (" & TxtIdPrestacao.Text & "," &
                                                     "'" & TxtCpfCliente.Text & "'," &
                                                     "'" & TxtNome.Text & "'," &
                                                     "'" & FormatDateTime(TxtData.Text, DateFormat.ShortDate) & "'," &
                                                     "'" & TxtValor.Text & "', " &
                                                     "'" & CbCredito.CheckState & "'," &
                                                     "'" & CbDebito.CheckState & "'," &
                                                     "'" & CbDinheiro.CheckState & "', " &
                                                     "'" & TextDesconto.Text & "')"
        db.Execute(UCase(sql))
        db2.Execute(UCase(sql))
        Dim n2 As Integer
        With DgvServicos
            Do While n2 < contLinha
                sql = "UPDATE TBAGENDA SET IDSERVICOPRESTADO = " & TxtIdPrestacao.Text & ", FINALIZADO = 1, PAGO = 1 WHERE IDAGENDA = " & .Rows(n2).Cells(0).Value & ""
                db.Execute(sql)
                db2.Execute(sql)
                n2 += 1
            Loop
        End With

        MsgBox("Serviço Finalizado", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ATENÇÃO")
        Me.Close()
    End Sub

    Private Sub TextDesconto_Leave(sender As Object, e As EventArgs) Handles TextDesconto.Leave
        If IsNumeric(TextDesconto.Text) = False Then
            TextDesconto.Text = ""
        Else
            If TextDesconto.Text > 90 Or TextDesconto.Text < 0 Then
                MsgBox("Descontos devem ser de 0 a 90 porcento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                TextDesconto.Text = ""
                TextDesconto.Select()
            Else
                Dim desconto As Integer
                desconto = CInt(TextDesconto.Text)
                TxtValor.Text = FormatCurrency(valor - (valor * desconto / 100))
            End If
        End If
    End Sub
End Class