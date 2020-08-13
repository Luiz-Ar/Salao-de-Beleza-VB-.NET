'Dim frmInstance As New FrmCep
Public Class FrmCep
    Private Sub FrmCep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()
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

    Private Sub LblCadastroCepTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub LblCadastroCepTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub LblCadastroCepTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTop.MouseUp
        drag = False
    End Sub
    Private Sub BtnCadastrarCep_Click(sender As Object, e As EventArgs) Handles BtnCadastrarCep.Click
        If TxtCadastroCep.MaskCompleted = False Or TxtCadastroEndereco.Text = "" Or TxtCadastroBairro.Text = "" Or TxtCadastroCidade.Text = "" Or TxtCadastroEstado.Text = "" Then
            MsgBox("Preencha todo os campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "select * from tbCep where cep = '" & TxtCadastroCep.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                MsgBox("CEP já existe!", vbInformation + vbOKOnly, "ATENÇÃO")
            Else
                sql = "insert into tbCep values ('" & TxtCadastroCep.Text & "','" & TxtCadastroEndereco.Text & "','" & TxtCadastroCidade.Text & "','" & TxtCadastroBairro.Text & "', '" & TxtCadastroEstado.Text & "')"
                db.Execute(UCase(sql))
                db2.Execute(UCase(sql))
                MsgBox("CEP CADASTRADO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Dim frm = New FrmCep
                Me.Close()
                frm.Show()
            End If
        End If
    End Sub

    Private Sub BtnLimparCep_Click(sender As Object, e As EventArgs) Handles BtnLimparCep.Click
        Dim frm = New FrmCep
        Me.Close()
        frm.Show()
    End Sub

    Private Sub BtnSearchCep_Click(sender As Object, e As EventArgs) Handles BtnSearchCep.Click
        sql = "Select * from tbCep where cep = '" & TxtCepPesquisar.Text & "'"
        rs = db.Execute(UCase(sql))
        If rs.EOF Then
            MsgBox("CEP não cadastrado!!", vbCritical + vbOKOnly, "ATENÇÃO")
            resp = MsgBox("Deseja cadastrar cep?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                TxtCadastroCep.Text = TxtCepPesquisar.Text
                TxtCadastroEndereco.Select()
            Else
                TxtCepPesquisar.Clear()
                TxtCepPesquisar.Select()
            End If
        Else
            TxtCadastroCep.Text = rs.Fields(0).Value
            TxtCadastroEndereco.Text = rs.Fields(1).Value
            TxtCadastroCidade.Text = rs.Fields(2).Value
            TxtCadastroBairro.Text = rs.Fields(3).Value
            TxtCadastroEstado.Text = rs.Fields(4).Value
        End If
    End Sub
    Private Sub PicFechar_Click(sender As Object, e As EventArgs) Handles PicFechar.Click
        Me.Close()
    End Sub

    Private Sub PicMinimizar_Click(sender As Object, e As EventArgs) Handles PicMinimizar.Click
        Me.WindowState = WindowState.Minimized
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
    End Sub

End Class