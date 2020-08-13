<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisualizar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabFuncionarios = New System.Windows.Forms.TabPage()
        Me.DgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.TabCargos = New System.Windows.Forms.TabPage()
        Me.DgvCargos = New System.Windows.Forms.DataGridView()
        Me.TabVisualizar = New System.Windows.Forms.TabControl()
        Me.TabTipoServico = New System.Windows.Forms.TabPage()
        Me.DgvTipoServico = New System.Windows.Forms.DataGridView()
        Me.tabServicos = New System.Windows.Forms.TabPage()
        Me.DgvServicos = New System.Windows.Forms.DataGridView()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.TabFuncionarios.SuspendLayout()
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCargos.SuspendLayout()
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVisualizar.SuspendLayout()
        Me.TabTipoServico.SuspendLayout()
        CType(Me.DgvTipoServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServicos.SuspendLayout()
        CType(Me.DgvServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabFuncionarios
        '
        Me.TabFuncionarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.TabFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabFuncionarios.Controls.Add(Me.DgvFuncionarios)
        Me.TabFuncionarios.Location = New System.Drawing.Point(4, 45)
        Me.TabFuncionarios.Name = "TabFuncionarios"
        Me.TabFuncionarios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFuncionarios.Size = New System.Drawing.Size(514, 326)
        Me.TabFuncionarios.TabIndex = 5
        Me.TabFuncionarios.Text = "FUNCIONÁRIOS"
        '
        'DgvFuncionarios
        '
        Me.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFuncionarios.Location = New System.Drawing.Point(3, 3)
        Me.DgvFuncionarios.Name = "DgvFuncionarios"
        Me.DgvFuncionarios.Size = New System.Drawing.Size(506, 318)
        Me.DgvFuncionarios.TabIndex = 3
        '
        'TabCargos
        '
        Me.TabCargos.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.TabCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabCargos.Controls.Add(Me.DgvCargos)
        Me.TabCargos.Location = New System.Drawing.Point(4, 45)
        Me.TabCargos.Name = "TabCargos"
        Me.TabCargos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCargos.Size = New System.Drawing.Size(514, 326)
        Me.TabCargos.TabIndex = 1
        Me.TabCargos.Text = "CARGOS"
        '
        'DgvCargos
        '
        Me.DgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCargos.Location = New System.Drawing.Point(3, 3)
        Me.DgvCargos.Name = "DgvCargos"
        Me.DgvCargos.Size = New System.Drawing.Size(506, 318)
        Me.DgvCargos.TabIndex = 3
        '
        'TabVisualizar
        '
        Me.TabVisualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabVisualizar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabVisualizar.Controls.Add(Me.TabCargos)
        Me.TabVisualizar.Controls.Add(Me.TabFuncionarios)
        Me.TabVisualizar.Controls.Add(Me.TabTipoServico)
        Me.TabVisualizar.Controls.Add(Me.tabServicos)
        Me.TabVisualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabVisualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabVisualizar.ItemSize = New System.Drawing.Size(120, 41)
        Me.TabVisualizar.Location = New System.Drawing.Point(0, 75)
        Me.TabVisualizar.Name = "TabVisualizar"
        Me.TabVisualizar.Padding = New System.Drawing.Point(0, 0)
        Me.TabVisualizar.SelectedIndex = 0
        Me.TabVisualizar.Size = New System.Drawing.Size(522, 375)
        Me.TabVisualizar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabVisualizar.TabIndex = 4
        '
        'TabTipoServico
        '
        Me.TabTipoServico.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.TabTipoServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabTipoServico.Controls.Add(Me.DgvTipoServico)
        Me.TabTipoServico.Location = New System.Drawing.Point(4, 45)
        Me.TabTipoServico.Name = "TabTipoServico"
        Me.TabTipoServico.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTipoServico.Size = New System.Drawing.Size(514, 326)
        Me.TabTipoServico.TabIndex = 6
        Me.TabTipoServico.Text = "TIPOS DE SERVIÇOS"
        '
        'DgvTipoServico
        '
        Me.DgvTipoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTipoServico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTipoServico.Location = New System.Drawing.Point(3, 3)
        Me.DgvTipoServico.Name = "DgvTipoServico"
        Me.DgvTipoServico.Size = New System.Drawing.Size(506, 318)
        Me.DgvTipoServico.TabIndex = 3
        '
        'tabServicos
        '
        Me.tabServicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.tabServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabServicos.Controls.Add(Me.DgvServicos)
        Me.tabServicos.Location = New System.Drawing.Point(4, 45)
        Me.tabServicos.Name = "tabServicos"
        Me.tabServicos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServicos.Size = New System.Drawing.Size(514, 326)
        Me.tabServicos.TabIndex = 7
        Me.tabServicos.Text = "SERVIÇOS"
        '
        'DgvServicos
        '
        Me.DgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvServicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvServicos.Location = New System.Drawing.Point(3, 3)
        Me.DgvServicos.Name = "DgvServicos"
        Me.DgvServicos.Size = New System.Drawing.Size(506, 318)
        Me.DgvServicos.TabIndex = 3
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(521, 25)
        Me.PnlTop.TabIndex = 5
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicFechar.Location = New System.Drawing.Point(12, 5)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 43
        Me.PicFechar.TabStop = False
        '
        'PnlMenu
        '
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(0, 25)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(521, 44)
        Me.PnlMenu.TabIndex = 6
        '
        'frmVisualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(521, 450)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.TabVisualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVisualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVisualizar"
        Me.TabFuncionarios.ResumeLayout(False)
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCargos.ResumeLayout(False)
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVisualizar.ResumeLayout(False)
        Me.TabTipoServico.ResumeLayout(False)
        CType(Me.DgvTipoServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServicos.ResumeLayout(False)
        CType(Me.DgvServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabFuncionarios As TabPage
    Friend WithEvents DgvFuncionarios As DataGridView
    Friend WithEvents TabCargos As TabPage
    Friend WithEvents DgvCargos As DataGridView
    Friend WithEvents TabVisualizar As TabControl
    Friend WithEvents tabServicos As TabPage
    Friend WithEvents DgvServicos As DataGridView
    Friend WithEvents TabTipoServico As TabPage
    Friend WithEvents DgvTipoServico As DataGridView
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents PicFechar As PictureBox
End Class
