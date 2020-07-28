<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgendamento
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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.PicMinimizar = New System.Windows.Forms.PictureBox()
        Me.LblCadastroClienteTitle = New System.Windows.Forms.Label()
        Me.PnlMid = New System.Windows.Forms.Panel()
        Me.CbPago = New System.Windows.Forms.CheckBox()
        Me.CbCancelado = New System.Windows.Forms.CheckBox()
        Me.CbFinalizado = New System.Windows.Forms.CheckBox()
        Me.CmbTipoServico = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTipoServico = New System.Windows.Forms.Label()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.LblData = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.DateTimePicker()
        Me.LblDadosServico = New System.Windows.Forms.Label()
        Me.LblDadosCliente = New System.Windows.Forms.Label()
        Me.PnlValor = New System.Windows.Forms.Panel()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.MaskedTextBox()
        Me.PnlHora = New System.Windows.Forms.Panel()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.TxtHora = New System.Windows.Forms.MaskedTextBox()
        Me.PnlNome = New System.Windows.Forms.Panel()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.PnlCpfCliente = New System.Windows.Forms.Panel()
        Me.LblCpfCliente = New System.Windows.Forms.Label()
        Me.TxtCpfCliente = New System.Windows.Forms.MaskedTextBox()
        Me.PnlIdTipoServico = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdTipoServico = New System.Windows.Forms.TextBox()
        Me.PnlIdServico = New System.Windows.Forms.Panel()
        Me.LblIdServico = New System.Windows.Forms.Label()
        Me.TxtIdServico = New System.Windows.Forms.TextBox()
        Me.CmbServico = New System.Windows.Forms.ComboBox()
        Me.PnlServico = New System.Windows.Forms.Panel()
        Me.LblServico = New System.Windows.Forms.Label()
        Me.PnlCpf = New System.Windows.Forms.Panel()
        Me.LblCpf = New System.Windows.Forms.Label()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.CmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.PnlFuncionario = New System.Windows.Forms.Panel()
        Me.LblFuncionario = New System.Windows.Forms.Label()
        Me.PnlIdAgenda = New System.Windows.Forms.Panel()
        Me.LblIdAgenda = New System.Windows.Forms.Label()
        Me.TxtIdAgenda = New System.Windows.Forms.TextBox()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMid.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnlData.SuspendLayout()
        Me.PnlValor.SuspendLayout()
        Me.PnlHora.SuspendLayout()
        Me.PnlNome.SuspendLayout()
        Me.PnlCpfCliente.SuspendLayout()
        Me.PnlIdTipoServico.SuspendLayout()
        Me.PnlIdServico.SuspendLayout()
        Me.PnlServico.SuspendLayout()
        Me.PnlCpf.SuspendLayout()
        Me.PnlFuncionario.SuspendLayout()
        Me.PnlIdAgenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Controls.Add(Me.PicMinimizar)
        Me.PnlTop.Controls.Add(Me.LblCadastroClienteTitle)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(549, 29)
        Me.PnlTop.TabIndex = 0
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Location = New System.Drawing.Point(14, 8)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 40
        Me.PicFechar.TabStop = False
        '
        'PicMinimizar
        '
        Me.PicMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimizar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnMaximiza
        Me.PicMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicMinimizar.Location = New System.Drawing.Point(32, 8)
        Me.PicMinimizar.Name = "PicMinimizar"
        Me.PicMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.PicMinimizar.TabIndex = 41
        Me.PicMinimizar.TabStop = False
        '
        'LblCadastroClienteTitle
        '
        Me.LblCadastroClienteTitle.AutoSize = True
        Me.LblCadastroClienteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroClienteTitle.Location = New System.Drawing.Point(208, 7)
        Me.LblCadastroClienteTitle.Name = "LblCadastroClienteTitle"
        Me.LblCadastroClienteTitle.Size = New System.Drawing.Size(125, 16)
        Me.LblCadastroClienteTitle.TabIndex = 41
        Me.LblCadastroClienteTitle.Text = "AGENDAMENTO"
        '
        'PnlMid
        '
        Me.PnlMid.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PnlMid.Controls.Add(Me.CbPago)
        Me.PnlMid.Controls.Add(Me.CbCancelado)
        Me.PnlMid.Controls.Add(Me.CbFinalizado)
        Me.PnlMid.Controls.Add(Me.CmbTipoServico)
        Me.PnlMid.Controls.Add(Me.Panel1)
        Me.PnlMid.Controls.Add(Me.BtnLimpar)
        Me.PnlMid.Controls.Add(Me.BtnSalvar)
        Me.PnlMid.Controls.Add(Me.PnlData)
        Me.PnlMid.Controls.Add(Me.TxtData)
        Me.PnlMid.Controls.Add(Me.LblDadosServico)
        Me.PnlMid.Controls.Add(Me.LblDadosCliente)
        Me.PnlMid.Controls.Add(Me.PnlValor)
        Me.PnlMid.Controls.Add(Me.TxtValor)
        Me.PnlMid.Controls.Add(Me.PnlHora)
        Me.PnlMid.Controls.Add(Me.TxtHora)
        Me.PnlMid.Controls.Add(Me.PnlNome)
        Me.PnlMid.Controls.Add(Me.TxtNome)
        Me.PnlMid.Controls.Add(Me.PnlCpfCliente)
        Me.PnlMid.Controls.Add(Me.TxtCpfCliente)
        Me.PnlMid.Controls.Add(Me.PnlIdTipoServico)
        Me.PnlMid.Controls.Add(Me.TxtIdTipoServico)
        Me.PnlMid.Controls.Add(Me.PnlIdServico)
        Me.PnlMid.Controls.Add(Me.TxtIdServico)
        Me.PnlMid.Controls.Add(Me.CmbServico)
        Me.PnlMid.Controls.Add(Me.PnlServico)
        Me.PnlMid.Controls.Add(Me.PnlCpf)
        Me.PnlMid.Controls.Add(Me.TxtCpf)
        Me.PnlMid.Controls.Add(Me.CmbFuncionario)
        Me.PnlMid.Controls.Add(Me.PnlFuncionario)
        Me.PnlMid.Controls.Add(Me.PnlIdAgenda)
        Me.PnlMid.Controls.Add(Me.TxtIdAgenda)
        Me.PnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMid.Location = New System.Drawing.Point(0, 0)
        Me.PnlMid.Name = "PnlMid"
        Me.PnlMid.Size = New System.Drawing.Size(549, 429)
        Me.PnlMid.TabIndex = 1
        '
        'CbPago
        '
        Me.CbPago.AutoSize = True
        Me.CbPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CbPago.Location = New System.Drawing.Point(467, 299)
        Me.CbPago.Name = "CbPago"
        Me.CbPago.Size = New System.Drawing.Size(51, 17)
        Me.CbPago.TabIndex = 29
        Me.CbPago.Text = "Pago"
        Me.CbPago.UseVisualStyleBackColor = True
        '
        'CbCancelado
        '
        Me.CbCancelado.AutoSize = True
        Me.CbCancelado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CbCancelado.Location = New System.Drawing.Point(307, 299)
        Me.CbCancelado.Name = "CbCancelado"
        Me.CbCancelado.Size = New System.Drawing.Size(77, 17)
        Me.CbCancelado.TabIndex = 28
        Me.CbCancelado.Text = "Cancelado"
        Me.CbCancelado.UseVisualStyleBackColor = True
        '
        'CbFinalizado
        '
        Me.CbFinalizado.AutoSize = True
        Me.CbFinalizado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CbFinalizado.Location = New System.Drawing.Point(389, 299)
        Me.CbFinalizado.Name = "CbFinalizado"
        Me.CbFinalizado.Size = New System.Drawing.Size(73, 17)
        Me.CbFinalizado.TabIndex = 1
        Me.CbFinalizado.Text = "Finalizado"
        Me.CbFinalizado.UseVisualStyleBackColor = True
        '
        'CmbTipoServico
        '
        Me.CmbTipoServico.FormattingEnabled = True
        Me.CmbTipoServico.Location = New System.Drawing.Point(106, 119)
        Me.CmbTipoServico.Name = "CmbTipoServico"
        Me.CmbTipoServico.Size = New System.Drawing.Size(171, 21)
        Me.CmbTipoServico.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.Panel1.Controls.Add(Me.LblTipoServico)
        Me.Panel1.Location = New System.Drawing.Point(30, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 29)
        Me.Panel1.TabIndex = 26
        '
        'LblTipoServico
        '
        Me.LblTipoServico.AutoSize = True
        Me.LblTipoServico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblTipoServico.Location = New System.Drawing.Point(-1, 7)
        Me.LblTipoServico.Name = "LblTipoServico"
        Me.LblTipoServico.Size = New System.Drawing.Size(80, 13)
        Me.LblTipoServico.TabIndex = 0
        Me.LblTipoServico.Text = "Tipo de serviço"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnLimpar.FlatAppearance.BorderSize = 0
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.Location = New System.Drawing.Point(282, 353)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(107, 40)
        Me.BtnLimpar.TabIndex = 25
        Me.BtnLimpar.Text = "LIMPAR"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(169, 353)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(107, 40)
        Me.BtnSalvar.TabIndex = 24
        Me.BtnSalvar.Text = "SALVAR"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlData.Controls.Add(Me.LblData)
        Me.PnlData.Location = New System.Drawing.Point(223, 80)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(77, 29)
        Me.PnlData.TabIndex = 23
        '
        'LblData
        '
        Me.LblData.AutoSize = True
        Me.LblData.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblData.Location = New System.Drawing.Point(26, 7)
        Me.LblData.Name = "LblData"
        Me.LblData.Size = New System.Drawing.Size(30, 13)
        Me.LblData.TabIndex = 0
        Me.LblData.Text = "Data"
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(294, 84)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(224, 20)
        Me.TxtData.TabIndex = 22
        Me.TxtData.Value = New Date(2019, 11, 15, 0, 0, 0, 0)
        '
        'LblDadosServico
        '
        Me.LblDadosServico.AutoSize = True
        Me.LblDadosServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDadosServico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDadosServico.Location = New System.Drawing.Point(27, 47)
        Me.LblDadosServico.Name = "LblDadosServico"
        Me.LblDadosServico.Size = New System.Drawing.Size(133, 16)
        Me.LblDadosServico.TabIndex = 21
        Me.LblDadosServico.Text = "Dados de Serviço"
        '
        'LblDadosCliente
        '
        Me.LblDadosCliente.AutoSize = True
        Me.LblDadosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDadosCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDadosCliente.Location = New System.Drawing.Point(27, 228)
        Me.LblDadosCliente.Name = "LblDadosCliente"
        Me.LblDadosCliente.Size = New System.Drawing.Size(128, 16)
        Me.LblDadosCliente.TabIndex = 20
        Me.LblDadosCliente.Text = "Dados do Cliente"
        '
        'PnlValor
        '
        Me.PnlValor.BackColor = System.Drawing.Color.Transparent
        Me.PnlValor.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlValor.Controls.Add(Me.LblValor)
        Me.PnlValor.Location = New System.Drawing.Point(151, 293)
        Me.PnlValor.Name = "PnlValor"
        Me.PnlValor.Size = New System.Drawing.Size(77, 29)
        Me.PnlValor.TabIndex = 18
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblValor.Location = New System.Drawing.Point(21, 8)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(31, 13)
        Me.LblValor.TabIndex = 0
        Me.LblValor.Text = "Valor"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(228, 297)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(58, 20)
        Me.TxtValor.TabIndex = 19
        '
        'PnlHora
        '
        Me.PnlHora.BackColor = System.Drawing.Color.Transparent
        Me.PnlHora.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlHora.Controls.Add(Me.LblHora)
        Me.PnlHora.Location = New System.Drawing.Point(30, 293)
        Me.PnlHora.Name = "PnlHora"
        Me.PnlHora.Size = New System.Drawing.Size(77, 29)
        Me.PnlHora.TabIndex = 16
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblHora.Location = New System.Drawing.Point(16, 8)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(41, 13)
        Me.LblHora.TabIndex = 0
        Me.LblHora.Text = "Horário"
        '
        'TxtHora
        '
        Me.TxtHora.Location = New System.Drawing.Point(107, 297)
        Me.TxtHora.Mask = "00:00"
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(38, 20)
        Me.TxtHora.TabIndex = 17
        '
        'PnlNome
        '
        Me.PnlNome.BackColor = System.Drawing.Color.Transparent
        Me.PnlNome.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlNome.Controls.Add(Me.LblNome)
        Me.PnlNome.Location = New System.Drawing.Point(200, 258)
        Me.PnlNome.Name = "PnlNome"
        Me.PnlNome.Size = New System.Drawing.Size(77, 29)
        Me.PnlNome.TabIndex = 14
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNome.Location = New System.Drawing.Point(20, 8)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(35, 13)
        Me.LblNome.TabIndex = 0
        Me.LblNome.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(276, 262)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(242, 20)
        Me.TxtNome.TabIndex = 15
        '
        'PnlCpfCliente
        '
        Me.PnlCpfCliente.BackColor = System.Drawing.Color.Transparent
        Me.PnlCpfCliente.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlCpfCliente.Controls.Add(Me.LblCpfCliente)
        Me.PnlCpfCliente.Location = New System.Drawing.Point(30, 258)
        Me.PnlCpfCliente.Name = "PnlCpfCliente"
        Me.PnlCpfCliente.Size = New System.Drawing.Size(77, 29)
        Me.PnlCpfCliente.TabIndex = 12
        '
        'LblCpfCliente
        '
        Me.LblCpfCliente.AutoSize = True
        Me.LblCpfCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCpfCliente.Location = New System.Drawing.Point(9, 8)
        Me.LblCpfCliente.Name = "LblCpfCliente"
        Me.LblCpfCliente.Size = New System.Drawing.Size(62, 13)
        Me.LblCpfCliente.TabIndex = 0
        Me.LblCpfCliente.Text = "CPF Cliente"
        '
        'TxtCpfCliente
        '
        Me.TxtCpfCliente.Location = New System.Drawing.Point(107, 262)
        Me.TxtCpfCliente.Mask = "000,000,000-00"
        Me.TxtCpfCliente.Name = "TxtCpfCliente"
        Me.TxtCpfCliente.Size = New System.Drawing.Size(85, 20)
        Me.TxtCpfCliente.TabIndex = 13
        '
        'PnlIdTipoServico
        '
        Me.PnlIdTipoServico.BackColor = System.Drawing.Color.Transparent
        Me.PnlIdTipoServico.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlIdTipoServico.Controls.Add(Me.Label6)
        Me.PnlIdTipoServico.Location = New System.Drawing.Point(403, 185)
        Me.PnlIdTipoServico.Name = "PnlIdTipoServico"
        Me.PnlIdTipoServico.Size = New System.Drawing.Size(77, 29)
        Me.PnlIdTipoServico.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(2, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "IdTipo Serviço"
        '
        'TxtIdTipoServico
        '
        Me.TxtIdTipoServico.Location = New System.Drawing.Point(479, 189)
        Me.TxtIdTipoServico.Name = "TxtIdTipoServico"
        Me.TxtIdTipoServico.Size = New System.Drawing.Size(39, 20)
        Me.TxtIdTipoServico.TabIndex = 11
        '
        'PnlIdServico
        '
        Me.PnlIdServico.BackColor = System.Drawing.Color.Transparent
        Me.PnlIdServico.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlIdServico.Controls.Add(Me.LblIdServico)
        Me.PnlIdServico.Location = New System.Drawing.Point(283, 185)
        Me.PnlIdServico.Name = "PnlIdServico"
        Me.PnlIdServico.Size = New System.Drawing.Size(77, 29)
        Me.PnlIdServico.TabIndex = 8
        '
        'LblIdServico
        '
        Me.LblIdServico.AutoSize = True
        Me.LblIdServico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblIdServico.Location = New System.Drawing.Point(12, 8)
        Me.LblIdServico.Name = "LblIdServico"
        Me.LblIdServico.Size = New System.Drawing.Size(52, 13)
        Me.LblIdServico.TabIndex = 0
        Me.LblIdServico.Text = "IdServiço"
        '
        'TxtIdServico
        '
        Me.TxtIdServico.Location = New System.Drawing.Point(359, 189)
        Me.TxtIdServico.Name = "TxtIdServico"
        Me.TxtIdServico.Size = New System.Drawing.Size(39, 20)
        Me.TxtIdServico.TabIndex = 9
        '
        'CmbServico
        '
        Me.CmbServico.FormattingEnabled = True
        Me.CmbServico.Location = New System.Drawing.Point(106, 189)
        Me.CmbServico.Name = "CmbServico"
        Me.CmbServico.Size = New System.Drawing.Size(171, 21)
        Me.CmbServico.TabIndex = 7
        '
        'PnlServico
        '
        Me.PnlServico.BackColor = System.Drawing.Color.Transparent
        Me.PnlServico.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlServico.Controls.Add(Me.LblServico)
        Me.PnlServico.Location = New System.Drawing.Point(30, 185)
        Me.PnlServico.Name = "PnlServico"
        Me.PnlServico.Size = New System.Drawing.Size(77, 29)
        Me.PnlServico.TabIndex = 6
        '
        'LblServico
        '
        Me.LblServico.AutoSize = True
        Me.LblServico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblServico.Location = New System.Drawing.Point(19, 7)
        Me.LblServico.Name = "LblServico"
        Me.LblServico.Size = New System.Drawing.Size(43, 13)
        Me.LblServico.TabIndex = 0
        Me.LblServico.Text = "Serviço"
        '
        'PnlCpf
        '
        Me.PnlCpf.BackColor = System.Drawing.Color.Transparent
        Me.PnlCpf.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlCpf.Controls.Add(Me.LblCpf)
        Me.PnlCpf.Location = New System.Drawing.Point(359, 150)
        Me.PnlCpf.Name = "PnlCpf"
        Me.PnlCpf.Size = New System.Drawing.Size(77, 29)
        Me.PnlCpf.TabIndex = 4
        '
        'LblCpf
        '
        Me.LblCpf.AutoSize = True
        Me.LblCpf.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCpf.Location = New System.Drawing.Point(21, 8)
        Me.LblCpf.Name = "LblCpf"
        Me.LblCpf.Size = New System.Drawing.Size(27, 13)
        Me.LblCpf.TabIndex = 0
        Me.LblCpf.Text = "CPF"
        '
        'TxtCpf
        '
        Me.TxtCpf.Location = New System.Drawing.Point(436, 154)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(85, 20)
        Me.TxtCpf.TabIndex = 5
        '
        'CmbFuncionario
        '
        Me.CmbFuncionario.FormattingEnabled = True
        Me.CmbFuncionario.Location = New System.Drawing.Point(106, 154)
        Me.CmbFuncionario.Name = "CmbFuncionario"
        Me.CmbFuncionario.Size = New System.Drawing.Size(244, 21)
        Me.CmbFuncionario.TabIndex = 3
        '
        'PnlFuncionario
        '
        Me.PnlFuncionario.BackColor = System.Drawing.Color.Transparent
        Me.PnlFuncionario.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlFuncionario.Controls.Add(Me.LblFuncionario)
        Me.PnlFuncionario.Location = New System.Drawing.Point(30, 150)
        Me.PnlFuncionario.Name = "PnlFuncionario"
        Me.PnlFuncionario.Size = New System.Drawing.Size(77, 29)
        Me.PnlFuncionario.TabIndex = 2
        '
        'LblFuncionario
        '
        Me.LblFuncionario.AutoSize = True
        Me.LblFuncionario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblFuncionario.Location = New System.Drawing.Point(9, 7)
        Me.LblFuncionario.Name = "LblFuncionario"
        Me.LblFuncionario.Size = New System.Drawing.Size(62, 13)
        Me.LblFuncionario.TabIndex = 0
        Me.LblFuncionario.Text = "Funcionário"
        '
        'PnlIdAgenda
        '
        Me.PnlIdAgenda.BackColor = System.Drawing.Color.Transparent
        Me.PnlIdAgenda.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlIdAgenda.Controls.Add(Me.LblIdAgenda)
        Me.PnlIdAgenda.Location = New System.Drawing.Point(30, 80)
        Me.PnlIdAgenda.Name = "PnlIdAgenda"
        Me.PnlIdAgenda.Size = New System.Drawing.Size(77, 29)
        Me.PnlIdAgenda.TabIndex = 0
        '
        'LblIdAgenda
        '
        Me.LblIdAgenda.AutoSize = True
        Me.LblIdAgenda.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblIdAgenda.Location = New System.Drawing.Point(10, 7)
        Me.LblIdAgenda.Name = "LblIdAgenda"
        Me.LblIdAgenda.Size = New System.Drawing.Size(53, 13)
        Me.LblIdAgenda.TabIndex = 0
        Me.LblIdAgenda.Text = "IdAgenda"
        '
        'TxtIdAgenda
        '
        Me.TxtIdAgenda.Location = New System.Drawing.Point(106, 84)
        Me.TxtIdAgenda.Name = "TxtIdAgenda"
        Me.TxtIdAgenda.Size = New System.Drawing.Size(39, 20)
        Me.TxtIdAgenda.TabIndex = 1
        '
        'FrmAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 429)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PnlMid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendamento"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMid.ResumeLayout(False)
        Me.PnlMid.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        Me.PnlValor.ResumeLayout(False)
        Me.PnlValor.PerformLayout()
        Me.PnlHora.ResumeLayout(False)
        Me.PnlHora.PerformLayout()
        Me.PnlNome.ResumeLayout(False)
        Me.PnlNome.PerformLayout()
        Me.PnlCpfCliente.ResumeLayout(False)
        Me.PnlCpfCliente.PerformLayout()
        Me.PnlIdTipoServico.ResumeLayout(False)
        Me.PnlIdTipoServico.PerformLayout()
        Me.PnlIdServico.ResumeLayout(False)
        Me.PnlIdServico.PerformLayout()
        Me.PnlServico.ResumeLayout(False)
        Me.PnlServico.PerformLayout()
        Me.PnlCpf.ResumeLayout(False)
        Me.PnlCpf.PerformLayout()
        Me.PnlFuncionario.ResumeLayout(False)
        Me.PnlFuncionario.PerformLayout()
        Me.PnlIdAgenda.ResumeLayout(False)
        Me.PnlIdAgenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlMid As Panel
    Friend WithEvents LblDadosServico As Label
    Friend WithEvents LblDadosCliente As Label
    Friend WithEvents PnlValor As Panel
    Friend WithEvents LblValor As Label
    Friend WithEvents TxtValor As MaskedTextBox
    Friend WithEvents PnlHora As Panel
    Friend WithEvents LblHora As Label
    Friend WithEvents TxtHora As MaskedTextBox
    Friend WithEvents PnlNome As Panel
    Friend WithEvents LblNome As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents PnlCpfCliente As Panel
    Friend WithEvents LblCpfCliente As Label
    Friend WithEvents TxtCpfCliente As MaskedTextBox
    Friend WithEvents PnlIdTipoServico As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdTipoServico As TextBox
    Friend WithEvents PnlIdServico As Panel
    Friend WithEvents LblIdServico As Label
    Friend WithEvents TxtIdServico As TextBox
    Friend WithEvents CmbServico As ComboBox
    Friend WithEvents PnlServico As Panel
    Friend WithEvents LblServico As Label
    Friend WithEvents PnlCpf As Panel
    Friend WithEvents LblCpf As Label
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents CmbFuncionario As ComboBox
    Friend WithEvents PnlFuncionario As Panel
    Friend WithEvents LblFuncionario As Label
    Friend WithEvents PnlIdAgenda As Panel
    Friend WithEvents LblIdAgenda As Label
    Friend WithEvents TxtIdAgenda As TextBox
    Friend WithEvents TxtData As DateTimePicker
    Friend WithEvents PnlData As Panel
    Friend WithEvents LblData As Label
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblCadastroClienteTitle As Label
    Friend WithEvents PicMinimizar As PictureBox
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents CbCancelado As CheckBox
    Friend WithEvents CbFinalizado As CheckBox
    Friend WithEvents CmbTipoServico As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTipoServico As Label
    Friend WithEvents CbPago As CheckBox
End Class
