<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicoPrestado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.PicMinimizar = New System.Windows.Forms.PictureBox()
        Me.LblCadastroClienteTitle = New System.Windows.Forms.Label()
        Me.PnlMid = New System.Windows.Forms.Panel()
        Me.CbDinheiro = New System.Windows.Forms.CheckBox()
        Me.CbDebito = New System.Windows.Forms.CheckBox()
        Me.CbCredito = New System.Windows.Forms.CheckBox()
        Me.DgvServicos = New System.Windows.Forms.DataGridView()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.LblData = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.DateTimePicker()
        Me.LblDadosServico = New System.Windows.Forms.Label()
        Me.PnlValor = New System.Windows.Forms.Panel()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.MaskedTextBox()
        Me.PnlNome = New System.Windows.Forms.Panel()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.PnlCpfCliente = New System.Windows.Forms.Panel()
        Me.LblCpfCliente = New System.Windows.Forms.Label()
        Me.TxtCpfCliente = New System.Windows.Forms.MaskedTextBox()
        Me.PnlIdAgenda = New System.Windows.Forms.Panel()
        Me.LblIdAgenda = New System.Windows.Forms.Label()
        Me.TxtIdPrestacao = New System.Windows.Forms.TextBox()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMid.SuspendLayout()
        CType(Me.DgvServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlData.SuspendLayout()
        Me.PnlValor.SuspendLayout()
        Me.PnlNome.SuspendLayout()
        Me.PnlCpfCliente.SuspendLayout()
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
        Me.PnlTop.Size = New System.Drawing.Size(700, 29)
        Me.PnlTop.TabIndex = 1
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
        Me.LblCadastroClienteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroClienteTitle.Location = New System.Drawing.Point(211, 7)
        Me.LblCadastroClienteTitle.Name = "LblCadastroClienteTitle"
        Me.LblCadastroClienteTitle.Size = New System.Drawing.Size(305, 16)
        Me.LblCadastroClienteTitle.TabIndex = 41
        Me.LblCadastroClienteTitle.Text = "SERVIÇO PRESTADO"
        Me.LblCadastroClienteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlMid
        '
        Me.PnlMid.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PnlMid.Controls.Add(Me.CbDinheiro)
        Me.PnlMid.Controls.Add(Me.CbDebito)
        Me.PnlMid.Controls.Add(Me.CbCredito)
        Me.PnlMid.Controls.Add(Me.DgvServicos)
        Me.PnlMid.Controls.Add(Me.BtnSalvar)
        Me.PnlMid.Controls.Add(Me.PnlData)
        Me.PnlMid.Controls.Add(Me.TxtData)
        Me.PnlMid.Controls.Add(Me.LblDadosServico)
        Me.PnlMid.Controls.Add(Me.PnlValor)
        Me.PnlMid.Controls.Add(Me.TxtValor)
        Me.PnlMid.Controls.Add(Me.PnlNome)
        Me.PnlMid.Controls.Add(Me.TxtNome)
        Me.PnlMid.Controls.Add(Me.PnlCpfCliente)
        Me.PnlMid.Controls.Add(Me.TxtCpfCliente)
        Me.PnlMid.Controls.Add(Me.PnlIdAgenda)
        Me.PnlMid.Controls.Add(Me.TxtIdPrestacao)
        Me.PnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMid.Location = New System.Drawing.Point(0, 29)
        Me.PnlMid.Name = "PnlMid"
        Me.PnlMid.Size = New System.Drawing.Size(700, 420)
        Me.PnlMid.TabIndex = 2
        '
        'CbDinheiro
        '
        Me.CbDinheiro.AutoSize = True
        Me.CbDinheiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CbDinheiro.Location = New System.Drawing.Point(428, 370)
        Me.CbDinheiro.Name = "CbDinheiro"
        Me.CbDinheiro.Size = New System.Drawing.Size(65, 17)
        Me.CbDinheiro.TabIndex = 30
        Me.CbDinheiro.Text = "Dinheiro"
        Me.CbDinheiro.UseVisualStyleBackColor = True
        '
        'CbDebito
        '
        Me.CbDebito.AutoSize = True
        Me.CbDebito.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CbDebito.Location = New System.Drawing.Point(365, 370)
        Me.CbDebito.Name = "CbDebito"
        Me.CbDebito.Size = New System.Drawing.Size(57, 17)
        Me.CbDebito.TabIndex = 29
        Me.CbDebito.Text = "Débito"
        Me.CbDebito.UseVisualStyleBackColor = True
        '
        'CbCredito
        '
        Me.CbCredito.AutoSize = True
        Me.CbCredito.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CbCredito.Location = New System.Drawing.Point(300, 370)
        Me.CbCredito.Name = "CbCredito"
        Me.CbCredito.Size = New System.Drawing.Size(59, 17)
        Me.CbCredito.TabIndex = 28
        Me.CbCredito.Text = "Crédito"
        Me.CbCredito.UseVisualStyleBackColor = True
        '
        'DgvServicos
        '
        Me.DgvServicos.AllowUserToAddRows = False
        Me.DgvServicos.AllowUserToDeleteRows = False
        Me.DgvServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvServicos.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DgvServicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvServicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvServicos.ColumnHeadersHeight = 40
        Me.DgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvServicos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvServicos.GridColor = System.Drawing.Color.Indigo
        Me.DgvServicos.Location = New System.Drawing.Point(30, 91)
        Me.DgvServicos.MultiSelect = False
        Me.DgvServicos.Name = "DgvServicos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvServicos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvServicos.RowHeadersVisible = False
        Me.DgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvServicos.Size = New System.Drawing.Size(641, 261)
        Me.DgvServicos.TabIndex = 27
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(30, 358)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(107, 40)
        Me.BtnSalvar.TabIndex = 24
        Me.BtnSalvar.Text = "FINALIZAR"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'PnlData
        '
        Me.PnlData.BackColor = System.Drawing.Color.Transparent
        Me.PnlData.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlData.Controls.Add(Me.LblData)
        Me.PnlData.Location = New System.Drawing.Point(208, 17)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(77, 29)
        Me.PnlData.TabIndex = 23
        '
        'LblData
        '
        Me.LblData.AutoSize = True
        Me.LblData.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblData.Location = New System.Drawing.Point(25, 7)
        Me.LblData.Name = "LblData"
        Me.LblData.Size = New System.Drawing.Size(30, 13)
        Me.LblData.TabIndex = 0
        Me.LblData.Text = "Data"
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(279, 21)
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
        Me.LblDadosServico.Location = New System.Drawing.Point(29, 23)
        Me.LblDadosServico.Name = "LblDadosServico"
        Me.LblDadosServico.Size = New System.Drawing.Size(133, 16)
        Me.LblDadosServico.TabIndex = 21
        Me.LblDadosServico.Text = "Dados de Serviço"
        '
        'PnlValor
        '
        Me.PnlValor.BackColor = System.Drawing.Color.Transparent
        Me.PnlValor.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlValor.Controls.Add(Me.LblValor)
        Me.PnlValor.Location = New System.Drawing.Point(518, 364)
        Me.PnlValor.Name = "PnlValor"
        Me.PnlValor.Size = New System.Drawing.Size(77, 29)
        Me.PnlValor.TabIndex = 18
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblValor.Location = New System.Drawing.Point(9, 8)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(58, 13)
        Me.LblValor.TabIndex = 0
        Me.LblValor.Text = "Valor Total"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(594, 368)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(77, 20)
        Me.TxtValor.TabIndex = 19
        '
        'PnlNome
        '
        Me.PnlNome.BackColor = System.Drawing.Color.Transparent
        Me.PnlNome.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlNome.Controls.Add(Me.LblNome)
        Me.PnlNome.Location = New System.Drawing.Point(368, 56)
        Me.PnlNome.Name = "PnlNome"
        Me.PnlNome.Size = New System.Drawing.Size(77, 29)
        Me.PnlNome.TabIndex = 14
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNome.Location = New System.Drawing.Point(19, 8)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(35, 13)
        Me.LblNome.TabIndex = 0
        Me.LblNome.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(444, 60)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(227, 20)
        Me.TxtNome.TabIndex = 15
        '
        'PnlCpfCliente
        '
        Me.PnlCpfCliente.BackColor = System.Drawing.Color.Transparent
        Me.PnlCpfCliente.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlCpfCliente.Controls.Add(Me.LblCpfCliente)
        Me.PnlCpfCliente.Location = New System.Drawing.Point(200, 56)
        Me.PnlCpfCliente.Name = "PnlCpfCliente"
        Me.PnlCpfCliente.Size = New System.Drawing.Size(77, 29)
        Me.PnlCpfCliente.TabIndex = 12
        '
        'LblCpfCliente
        '
        Me.LblCpfCliente.AutoSize = True
        Me.LblCpfCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCpfCliente.Location = New System.Drawing.Point(7, 8)
        Me.LblCpfCliente.Name = "LblCpfCliente"
        Me.LblCpfCliente.Size = New System.Drawing.Size(62, 13)
        Me.LblCpfCliente.TabIndex = 0
        Me.LblCpfCliente.Text = "CPF Cliente"
        '
        'TxtCpfCliente
        '
        Me.TxtCpfCliente.Location = New System.Drawing.Point(277, 60)
        Me.TxtCpfCliente.Mask = "000,000,000-00"
        Me.TxtCpfCliente.Name = "TxtCpfCliente"
        Me.TxtCpfCliente.Size = New System.Drawing.Size(85, 20)
        Me.TxtCpfCliente.TabIndex = 13
        '
        'PnlIdAgenda
        '
        Me.PnlIdAgenda.BackColor = System.Drawing.Color.Transparent
        Me.PnlIdAgenda.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.button
        Me.PnlIdAgenda.Controls.Add(Me.LblIdAgenda)
        Me.PnlIdAgenda.Location = New System.Drawing.Point(30, 56)
        Me.PnlIdAgenda.Name = "PnlIdAgenda"
        Me.PnlIdAgenda.Size = New System.Drawing.Size(77, 29)
        Me.PnlIdAgenda.TabIndex = 0
        '
        'LblIdAgenda
        '
        Me.LblIdAgenda.AutoSize = True
        Me.LblIdAgenda.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblIdAgenda.Location = New System.Drawing.Point(9, 7)
        Me.LblIdAgenda.Name = "LblIdAgenda"
        Me.LblIdAgenda.Size = New System.Drawing.Size(64, 13)
        Me.LblIdAgenda.TabIndex = 0
        Me.LblIdAgenda.Text = "IdPrestação"
        '
        'TxtIdPrestacao
        '
        Me.TxtIdPrestacao.Location = New System.Drawing.Point(106, 60)
        Me.TxtIdPrestacao.Name = "TxtIdPrestacao"
        Me.TxtIdPrestacao.Size = New System.Drawing.Size(86, 20)
        Me.TxtIdPrestacao.TabIndex = 1
        '
        'FrmServicoPrestado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 449)
        Me.Controls.Add(Me.PnlMid)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmServicoPrestado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmServicoPrestado"
        Me.PnlTop.ResumeLayout(False)
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMid.ResumeLayout(False)
        Me.PnlMid.PerformLayout()
        CType(Me.DgvServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        Me.PnlValor.ResumeLayout(False)
        Me.PnlValor.PerformLayout()
        Me.PnlNome.ResumeLayout(False)
        Me.PnlNome.PerformLayout()
        Me.PnlCpfCliente.ResumeLayout(False)
        Me.PnlCpfCliente.PerformLayout()
        Me.PnlIdAgenda.ResumeLayout(False)
        Me.PnlIdAgenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents PicMinimizar As PictureBox
    Friend WithEvents LblCadastroClienteTitle As Label
    Friend WithEvents PnlMid As Panel
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents PnlData As Panel
    Friend WithEvents LblData As Label
    Friend WithEvents TxtData As DateTimePicker
    Friend WithEvents LblDadosServico As Label
    Friend WithEvents PnlValor As Panel
    Friend WithEvents LblValor As Label
    Friend WithEvents TxtValor As MaskedTextBox
    Friend WithEvents PnlNome As Panel
    Friend WithEvents LblNome As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents PnlCpfCliente As Panel
    Friend WithEvents LblCpfCliente As Label
    Friend WithEvents TxtCpfCliente As MaskedTextBox
    Friend WithEvents PnlIdAgenda As Panel
    Friend WithEvents LblIdAgenda As Label
    Friend WithEvents TxtIdPrestacao As TextBox
    Friend WithEvents DgvServicos As DataGridView
    Friend WithEvents CbDinheiro As CheckBox
    Friend WithEvents CbDebito As CheckBox
    Friend WithEvents CbCredito As CheckBox
End Class
