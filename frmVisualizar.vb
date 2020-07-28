Public Class frmVisualizar
    Private Sub FrmVisualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        'Preencher Cargos 
        DgvCargos.ColumnCount = 2

        DgvCargos.Columns(0).Name = "IdCargo"
        DgvCargos.Columns(1).Name = "Cargo"


        DgvCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        sql = "SELECT * FROM TBCARGOS ORDER BY CARGO ASC"
        rs = db.Execute(sql)
        With Me.DgvCargos
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With

        'Preencher Funcionarios
        DgvFuncionarios.ColumnCount = 3
        DgvFuncionarios.Columns(0).Name = "N"
        DgvFuncionarios.Columns(1).Name = "Nome"
        DgvFuncionarios.Columns(2).Name = "Cargo"
        sql = "SELECT * FROM TBFUNCIONARIOS ORDER BY NOME ASC"
        rs = db.Execute(sql)
        With Me.DgvFuncionarios
            Dim n As Integer
            n = 1
            Do While rs.EOF = False
                .Rows.Add(n, rs.Fields(1).Value, rs.Fields(4).Value)
                rs.MoveNext()
                n += 1
            Loop
        End With

        'Preencher Tipos de Serviço
        DgvTipoServico.ColumnCount = 2
        DgvTipoServico.Columns(0).Name = "IdTipo"
        DgvTipoServico.Columns(1).Name = "Tipo de Serviço"
        sql = "SELECT * FROM TBTIPOSERVICO ORDER BY TIPOSERVICO ASC"
        rs = db.Execute(sql)
        With Me.DgvTipoServico
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        End With

        'Preencher Serviços
        DgvServicos.ColumnCount = 3
        DgvServicos.Columns(0).Name = "id"
        DgvServicos.Columns(1).Name = "Servico"
        DgvServicos.Columns(2).Name = "Tipo de Serviço"
        sql = "SELECT * FROM TBSERVICO ORDER BY TIPOSERVICO ASC"
        rs = db.Execute(sql)
        Dim cont
        cont = 1
        With Me.DgvServicos
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(3).Value, rs.Fields(2).Value)
                rs.MoveNext()
                cont += 1
            Loop
        End With
        If FrmControleGeral.PnlCargos.Visible Then
            Me.TabVisualizar.SelectedIndex = 0
        ElseIf FrmControleGeral.PnlFuncionarios.Visible Then
            Me.TabVisualizar.SelectedIndex = 1
        ElseIf FrmControleGeral.PnlTipoServico.Visible Then
            Me.TabVisualizar.SelectedIndex = 2
        ElseIf FrmControleGeral.PnlServicos.Visible Then
            Me.TabVisualizar.SelectedIndex = 3
        End If
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

    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        Me.Close()
    End Sub

End Class