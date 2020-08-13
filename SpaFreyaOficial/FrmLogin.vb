Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectaBanco()
        ArredondarLados()
        TxtCpf.Select()
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
        Try
            resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENÇÃO")
            If resp = vbYes Then
                Me.Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PicCpf_Click(sender As Object, e As EventArgs) Handles PicCpf.Click
        TxtCpf.Select()
    End Sub

    Private Sub PicSenha_Click(sender As Object, e As EventArgs) Handles PicSenha.Click
        TxtSenha.Select()
    End Sub

    Private Sub TxtCpf_TextChanged(sender As Object, e As EventArgs) Handles TxtCpf.TextChanged
        If TxtCpf.MaskCompleted Then
            sql = "select * from tbFuncionarios where cpf = '" & TxtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF Then
                MsgBox("CPF NÃO CADASTRADO NO SISTEMA!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                TxtCpf.Text = ""
                TxtCpf.Select()
            Else
                LblTipo.Text = rs.Fields(4).Value
            End If
        Else
            LblTipo.Text = ""
        End If
    End Sub
    Private Sub BtnEntrar_Click_1(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        If TxtCpf.MaskCompleted = False Or TxtSenha.Text = "" Then
            MsgBox("PREENCHA TODOS OS CAMPOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "Select * from tbFuncionarios where cpf = '" & TxtCpf.Text & "'"
            rs = db.Execute(sql)
            cliente = rs.Fields(1).Value
            If TxtSenha.Text <> rs.Fields(14).Value Then
                MsgBox("SENHA INCORRETA", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                TxtSenha.Text = ""
                TxtSenha.Select()
            Else
                If rs.Fields(3).Value = 1 Then
                    funcionario = False
                    FrmRelatórios.Show()
                    Me.Hide()
                ElseIf rs.Fields(3).Value = 2 Then
                    FrmMain.Show()
                    Me.Hide()
                ElseIf rs.Fields(3).Value = 8 Then
                    FrmControleGeral.Show()
                    Me.Hide()
                Else
                    FrmFuncionarioTela.Show()
                    Me.Hide()
                End If
                TxtCpf.Text = ""
                TxtSenha.Text = ""
                TxtCpf.Select()
            End If
        End If
    End Sub
End Class