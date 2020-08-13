<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatórios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop2 = New System.Windows.Forms.Panel()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.LblCadastroClienteTitle = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.CmbTipoRelatorio = New System.Windows.Forms.ComboBox()
        Me.LblTipoRelatorio = New System.Windows.Forms.Label()
        Me.LblFuncionario = New System.Windows.Forms.Label()
        Me.CmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbServico = New System.Windows.Forms.ComboBox()
        Me.DgvRel = New System.Windows.Forms.DataGridView()
        Me.LblServicos = New System.Windows.Forms.Label()
        Me.CmbServicos = New System.Windows.Forms.ComboBox()
        Me.TxtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbData = New System.Windows.Forms.CheckBox()
        Me.BtnGerar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblQtde = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.PnlTop2.SuspendLayout()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop2
        '
        Me.PnlTop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop2.Controls.Add(Me.PicFechar)
        Me.PnlTop2.Controls.Add(Me.LblCadastroClienteTitle)
        Me.PnlTop2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop2.Location = New System.Drawing.Point(0, 14)
        Me.PnlTop2.Name = "PnlTop2"
        Me.PnlTop2.Size = New System.Drawing.Size(705, 29)
        Me.PnlTop2.TabIndex = 1
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Location = New System.Drawing.Point(14, 8)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 40
        Me.PicFechar.TabStop = False
        '
        'LblCadastroClienteTitle
        '
        Me.LblCadastroClienteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroClienteTitle.Location = New System.Drawing.Point(53, 7)
        Me.LblCadastroClienteTitle.Name = "LblCadastroClienteTitle"
        Me.LblCadastroClienteTitle.Size = New System.Drawing.Size(602, 16)
        Me.LblCadastroClienteTitle.TabIndex = 41
        Me.LblCadastroClienteTitle.Text = "RELATÓRIOS"
        Me.LblCadastroClienteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(705, 14)
        Me.PnlTop.TabIndex = 42
        '
        'CmbTipoRelatorio
        '
        Me.CmbTipoRelatorio.FormattingEnabled = True
        Me.CmbTipoRelatorio.Location = New System.Drawing.Point(131, 62)
        Me.CmbTipoRelatorio.Name = "CmbTipoRelatorio"
        Me.CmbTipoRelatorio.Size = New System.Drawing.Size(135, 21)
        Me.CmbTipoRelatorio.TabIndex = 43
        '
        'LblTipoRelatorio
        '
        Me.LblTipoRelatorio.AutoSize = True
        Me.LblTipoRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoRelatorio.Location = New System.Drawing.Point(15, 64)
        Me.LblTipoRelatorio.Name = "LblTipoRelatorio"
        Me.LblTipoRelatorio.Size = New System.Drawing.Size(113, 16)
        Me.LblTipoRelatorio.TabIndex = 44
        Me.LblTipoRelatorio.Text = "Tipo de Relatório"
        '
        'LblFuncionario
        '
        Me.LblFuncionario.AutoSize = True
        Me.LblFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFuncionario.Location = New System.Drawing.Point(50, 89)
        Me.LblFuncionario.Name = "LblFuncionario"
        Me.LblFuncionario.Size = New System.Drawing.Size(78, 16)
        Me.LblFuncionario.TabIndex = 46
        Me.LblFuncionario.Text = "Funcionário"
        '
        'CmbFuncionario
        '
        Me.CmbFuncionario.FormattingEnabled = True
        Me.CmbFuncionario.Location = New System.Drawing.Point(131, 87)
        Me.CmbFuncionario.Name = "CmbFuncionario"
        Me.CmbFuncionario.Size = New System.Drawing.Size(135, 21)
        Me.CmbFuncionario.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Tipo Serviço"
        '
        'CmbServico
        '
        Me.CmbServico.FormattingEnabled = True
        Me.CmbServico.Location = New System.Drawing.Point(357, 62)
        Me.CmbServico.Name = "CmbServico"
        Me.CmbServico.Size = New System.Drawing.Size(135, 21)
        Me.CmbServico.TabIndex = 47
        '
        'DgvRel
        '
        Me.DgvRel.AllowUserToAddRows = False
        Me.DgvRel.AllowUserToDeleteRows = False
        Me.DgvRel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRel.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DgvRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvRel.ColumnHeadersHeight = 40
        Me.DgvRel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvRel.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvRel.GridColor = System.Drawing.Color.Indigo
        Me.DgvRel.Location = New System.Drawing.Point(18, 169)
        Me.DgvRel.MultiSelect = False
        Me.DgvRel.Name = "DgvRel"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRel.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvRel.RowHeadersVisible = False
        Me.DgvRel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvRel.Size = New System.Drawing.Size(668, 343)
        Me.DgvRel.TabIndex = 49
        '
        'LblServicos
        '
        Me.LblServicos.AutoSize = True
        Me.LblServicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServicos.Location = New System.Drawing.Point(293, 89)
        Me.LblServicos.Name = "LblServicos"
        Me.LblServicos.Size = New System.Drawing.Size(61, 16)
        Me.LblServicos.TabIndex = 51
        Me.LblServicos.Text = "Serviços"
        '
        'CmbServicos
        '
        Me.CmbServicos.FormattingEnabled = True
        Me.CmbServicos.Location = New System.Drawing.Point(357, 87)
        Me.CmbServicos.Name = "CmbServicos"
        Me.CmbServicos.Size = New System.Drawing.Size(135, 21)
        Me.CmbServicos.TabIndex = 50
        '
        'TxtDataFinal
        '
        Me.TxtDataFinal.Location = New System.Drawing.Point(388, 111)
        Me.TxtDataFinal.Name = "TxtDataFinal"
        Me.TxtDataFinal.Size = New System.Drawing.Size(216, 20)
        Me.TxtDataFinal.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Data Final"
        '
        'TxtDataInicial
        '
        Me.TxtDataInicial.Location = New System.Drawing.Point(96, 111)
        Me.TxtDataInicial.Name = "TxtDataInicial"
        Me.TxtDataInicial.Size = New System.Drawing.Size(216, 20)
        Me.TxtDataInicial.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Data Inicial"
        '
        'CbData
        '
        Me.CbData.AutoSize = True
        Me.CbData.Location = New System.Drawing.Point(610, 113)
        Me.CbData.Name = "CbData"
        Me.CbData.Size = New System.Drawing.Size(68, 17)
        Me.CbData.TabIndex = 57
        Me.CbData.Text = "Por Data"
        Me.CbData.UseVisualStyleBackColor = True
        '
        'BtnGerar
        '
        Me.BtnGerar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGerar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.gerar
        Me.BtnGerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGerar.FlatAppearance.BorderSize = 0
        Me.BtnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGerar.Location = New System.Drawing.Point(502, 62)
        Me.BtnGerar.Name = "BtnGerar"
        Me.BtnGerar.Size = New System.Drawing.Size(168, 43)
        Me.BtnGerar.TabIndex = 58
        Me.BtnGerar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(518, 515)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Total de Registros:"
        '
        'LblQtde
        '
        Me.LblQtde.Location = New System.Drawing.Point(610, 515)
        Me.LblQtde.Name = "LblQtde"
        Me.LblQtde.Size = New System.Drawing.Size(76, 13)
        Me.LblQtde.TabIndex = 60
        Me.LblQtde.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblValor
        '
        Me.LblValor.Location = New System.Drawing.Point(610, 534)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(76, 13)
        Me.LblValor.TabIndex = 62
        Me.LblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 534)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Total em Valores:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Pesquisar Clientes: "
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Location = New System.Drawing.Point(141, 141)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(171, 20)
        Me.TxtPesquisar.TabIndex = 64
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(610, 139)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 65
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmRelatórios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 553)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtPesquisar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblValor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblQtde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnGerar)
        Me.Controls.Add(Me.CbData)
        Me.Controls.Add(Me.TxtDataFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDataInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblServicos)
        Me.Controls.Add(Me.CmbServicos)
        Me.Controls.Add(Me.DgvRel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbServico)
        Me.Controls.Add(Me.LblFuncionario)
        Me.Controls.Add(Me.CmbFuncionario)
        Me.Controls.Add(Me.LblTipoRelatorio)
        Me.Controls.Add(Me.CmbTipoRelatorio)
        Me.Controls.Add(Me.PnlTop2)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRelatórios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios"
        Me.PnlTop2.ResumeLayout(False)
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvRel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTop2 As Panel
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents LblCadastroClienteTitle As Label
    Friend WithEvents PnlTop As Panel
    Friend WithEvents CmbTipoRelatorio As ComboBox
    Friend WithEvents LblTipoRelatorio As Label
    Friend WithEvents LblFuncionario As Label
    Friend WithEvents CmbFuncionario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbServico As ComboBox
    Friend WithEvents DgvRel As DataGridView
    Friend WithEvents LblServicos As Label
    Friend WithEvents CmbServicos As ComboBox
    Friend WithEvents TxtDataFinal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDataInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CbData As CheckBox
    Friend WithEvents BtnGerar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LblQtde As Label
    Friend WithEvents LblValor As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents BtnReset As Button
End Class
