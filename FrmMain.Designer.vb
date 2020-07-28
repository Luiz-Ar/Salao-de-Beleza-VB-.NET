<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.PnlGeral = New System.Windows.Forms.Panel()
        Me.DgvAgenda = New System.Windows.Forms.DataGridView()
        Me.LblProfissional = New System.Windows.Forms.Label()
        Me.CmbProfissional = New System.Windows.Forms.ComboBox()
        Me.LblServico = New System.Windows.Forms.Label()
        Me.CmbServico = New System.Windows.Forms.ComboBox()
        Me.PnlEsquerda = New System.Windows.Forms.Panel()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.TxtData = New System.Windows.Forms.DateTimePicker()
        Me.BtnCadastrarCEPTopText = New System.Windows.Forms.Button()
        Me.BtnCadastrarCEPTopImage = New System.Windows.Forms.Button()
        Me.PicTitle = New System.Windows.Forms.PictureBox()
        Me.PicMinimizar = New System.Windows.Forms.PictureBox()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.BtnCadastrarClienteTxt = New System.Windows.Forms.Button()
        Me.BtnCadastrarClienteIcone = New System.Windows.Forms.Button()
        Me.BtnHideMenu = New System.Windows.Forms.Button()
        Me.PnlDireita = New System.Windows.Forms.Panel()
        Me.PnlPositionActive = New System.Windows.Forms.Panel()
        Me.BtnEstetica = New System.Windows.Forms.Button()
        Me.BtnMassagem = New System.Windows.Forms.Button()
        Me.BtnMaquiagem = New System.Windows.Forms.Button()
        Me.BtnManPed = New System.Windows.Forms.Button()
        Me.BtnCabeleireiroM = New System.Windows.Forms.Button()
        Me.BtnCabeleireiroF = New System.Windows.Forms.Button()
        Me.PnlDireitaMenor = New System.Windows.Forms.Panel()
        Me.BtnEsteticaMenor = New System.Windows.Forms.Button()
        Me.BtnMassagemMenor = New System.Windows.Forms.Button()
        Me.BtnMaquiagemMenor = New System.Windows.Forms.Button()
        Me.BtnManPedMenor = New System.Windows.Forms.Button()
        Me.BtnCabeleireiroMMenor = New System.Windows.Forms.Button()
        Me.BtnCabeleireiroFMenor = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlGeral.SuspendLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDireita.SuspendLayout()
        Me.PnlDireitaMenor.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ofd1
        '
        Me.Ofd1.FileName = "OpenFileDialog1"
        '
        'PnlGeral
        '
        Me.PnlGeral.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.bgTab2
        Me.PnlGeral.Controls.Add(Me.DgvAgenda)
        Me.PnlGeral.Controls.Add(Me.LblProfissional)
        Me.PnlGeral.Controls.Add(Me.CmbProfissional)
        Me.PnlGeral.Controls.Add(Me.LblServico)
        Me.PnlGeral.Controls.Add(Me.CmbServico)
        Me.PnlGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGeral.Location = New System.Drawing.Point(16, 118)
        Me.PnlGeral.Name = "PnlGeral"
        Me.PnlGeral.Size = New System.Drawing.Size(734, 438)
        Me.PnlGeral.TabIndex = 1
        '
        'DgvAgenda
        '
        Me.DgvAgenda.AllowUserToAddRows = False
        Me.DgvAgenda.AllowUserToDeleteRows = False
        Me.DgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAgenda.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAgenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAgenda.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvAgenda.GridColor = System.Drawing.Color.Indigo
        Me.DgvAgenda.Location = New System.Drawing.Point(201, 18)
        Me.DgvAgenda.MultiSelect = False
        Me.DgvAgenda.Name = "DgvAgenda"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAgenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvAgenda.RowHeadersVisible = False
        Me.DgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvAgenda.Size = New System.Drawing.Size(521, 399)
        Me.DgvAgenda.TabIndex = 4
        '
        'LblProfissional
        '
        Me.LblProfissional.AutoSize = True
        Me.LblProfissional.BackColor = System.Drawing.Color.Transparent
        Me.LblProfissional.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfissional.Location = New System.Drawing.Point(48, 18)
        Me.LblProfissional.Name = "LblProfissional"
        Me.LblProfissional.Size = New System.Drawing.Size(103, 18)
        Me.LblProfissional.TabIndex = 3
        Me.LblProfissional.Text = "Profissional:"
        '
        'CmbProfissional
        '
        Me.CmbProfissional.FormattingEnabled = True
        Me.CmbProfissional.Location = New System.Drawing.Point(25, 39)
        Me.CmbProfissional.Name = "CmbProfissional"
        Me.CmbProfissional.Size = New System.Drawing.Size(148, 21)
        Me.CmbProfissional.TabIndex = 2
        '
        'LblServico
        '
        Me.LblServico.AutoSize = True
        Me.LblServico.BackColor = System.Drawing.Color.Transparent
        Me.LblServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServico.Location = New System.Drawing.Point(64, 67)
        Me.LblServico.Name = "LblServico"
        Me.LblServico.Size = New System.Drawing.Size(70, 18)
        Me.LblServico.TabIndex = 1
        Me.LblServico.Text = "Serviço:"
        '
        'CmbServico
        '
        Me.CmbServico.FormattingEnabled = True
        Me.CmbServico.Location = New System.Drawing.Point(25, 88)
        Me.CmbServico.Name = "CmbServico"
        Me.CmbServico.Size = New System.Drawing.Size(148, 21)
        Me.CmbServico.TabIndex = 0
        '
        'PnlEsquerda
        '
        Me.PnlEsquerda.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.bgLeft2
        Me.PnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlEsquerda.Location = New System.Drawing.Point(0, 118)
        Me.PnlEsquerda.Name = "PnlEsquerda"
        Me.PnlEsquerda.Size = New System.Drawing.Size(16, 438)
        Me.PnlEsquerda.TabIndex = 3
        '
        'PnlTop
        '
        Me.PnlTop.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.bgTop2
        Me.PnlTop.Controls.Add(Me.TxtData)
        Me.PnlTop.Controls.Add(Me.BtnCadastrarCEPTopText)
        Me.PnlTop.Controls.Add(Me.BtnCadastrarCEPTopImage)
        Me.PnlTop.Controls.Add(Me.PicTitle)
        Me.PnlTop.Controls.Add(Me.PicMinimizar)
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Controls.Add(Me.BtnCadastrarClienteTxt)
        Me.PnlTop.Controls.Add(Me.BtnCadastrarClienteIcone)
        Me.PnlTop.Controls.Add(Me.BtnHideMenu)
        Me.PnlTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(750, 118)
        Me.PnlTop.TabIndex = 1
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(16, 80)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(212, 20)
        Me.TxtData.TabIndex = 5
        '
        'BtnCadastrarCEPTopText
        '
        Me.BtnCadastrarCEPTopText.BackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarCEPTopText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarCEPTopText.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarCEPTopText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarCEPTopText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarCEPTopText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarCEPTopText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarCEPTopText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCadastrarCEPTopText.Location = New System.Drawing.Point(545, 71)
        Me.BtnCadastrarCEPTopText.Name = "BtnCadastrarCEPTopText"
        Me.BtnCadastrarCEPTopText.Size = New System.Drawing.Size(84, 42)
        Me.BtnCadastrarCEPTopText.TabIndex = 6
        Me.BtnCadastrarCEPTopText.Text = "Cadastrar CEP's"
        Me.BtnCadastrarCEPTopText.UseVisualStyleBackColor = False
        '
        'BtnCadastrarCEPTopImage
        '
        Me.BtnCadastrarCEPTopImage.BackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarCEPTopImage.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.placas2
        Me.BtnCadastrarCEPTopImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCadastrarCEPTopImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarCEPTopImage.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarCEPTopImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarCEPTopImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarCEPTopImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarCEPTopImage.Location = New System.Drawing.Point(556, 3)
        Me.BtnCadastrarCEPTopImage.Name = "BtnCadastrarCEPTopImage"
        Me.BtnCadastrarCEPTopImage.Size = New System.Drawing.Size(62, 79)
        Me.BtnCadastrarCEPTopImage.TabIndex = 5
        Me.BtnCadastrarCEPTopImage.UseVisualStyleBackColor = False
        '
        'PicTitle
        '
        Me.PicTitle.BackColor = System.Drawing.Color.Transparent
        Me.PicTitle.Location = New System.Drawing.Point(217, 0)
        Me.PicTitle.Name = "PicTitle"
        Me.PicTitle.Size = New System.Drawing.Size(322, 118)
        Me.PicTitle.TabIndex = 7
        Me.PicTitle.TabStop = False
        '
        'PicMinimizar
        '
        Me.PicMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimizar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnMaximiza
        Me.PicMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMinimizar.Location = New System.Drawing.Point(31, 3)
        Me.PicMinimizar.Name = "PicMinimizar"
        Me.PicMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.PicMinimizar.TabIndex = 4
        Me.PicMinimizar.TabStop = False
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicFechar.Location = New System.Drawing.Point(12, 3)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 3
        Me.PicFechar.TabStop = False
        '
        'BtnCadastrarClienteTxt
        '
        Me.BtnCadastrarClienteTxt.BackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClienteTxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarClienteTxt.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarClienteTxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClienteTxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClienteTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarClienteTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarClienteTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCadastrarClienteTxt.Location = New System.Drawing.Point(624, 72)
        Me.BtnCadastrarClienteTxt.Name = "BtnCadastrarClienteTxt"
        Me.BtnCadastrarClienteTxt.Size = New System.Drawing.Size(84, 42)
        Me.BtnCadastrarClienteTxt.TabIndex = 2
        Me.BtnCadastrarClienteTxt.Text = "Cadastrar Cliente"
        Me.BtnCadastrarClienteTxt.UseVisualStyleBackColor = False
        '
        'BtnCadastrarClienteIcone
        '
        Me.BtnCadastrarClienteIcone.BackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClienteIcone.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources._00fotoCliente
        Me.BtnCadastrarClienteIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCadastrarClienteIcone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarClienteIcone.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarClienteIcone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClienteIcone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClienteIcone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarClienteIcone.Location = New System.Drawing.Point(635, 4)
        Me.BtnCadastrarClienteIcone.Name = "BtnCadastrarClienteIcone"
        Me.BtnCadastrarClienteIcone.Size = New System.Drawing.Size(62, 79)
        Me.BtnCadastrarClienteIcone.TabIndex = 1
        Me.BtnCadastrarClienteIcone.UseVisualStyleBackColor = False
        '
        'BtnHideMenu
        '
        Me.BtnHideMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.hideMenu
        Me.BtnHideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHideMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHideMenu.FlatAppearance.BorderSize = 0
        Me.BtnHideMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHideMenu.Location = New System.Drawing.Point(717, 5)
        Me.BtnHideMenu.Name = "BtnHideMenu"
        Me.BtnHideMenu.Size = New System.Drawing.Size(27, 29)
        Me.BtnHideMenu.TabIndex = 0
        Me.BtnHideMenu.UseVisualStyleBackColor = False
        '
        'PnlDireita
        '
        Me.PnlDireita.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.bgLeft
        Me.PnlDireita.Controls.Add(Me.PnlPositionActive)
        Me.PnlDireita.Controls.Add(Me.BtnEstetica)
        Me.PnlDireita.Controls.Add(Me.BtnMassagem)
        Me.PnlDireita.Controls.Add(Me.BtnMaquiagem)
        Me.PnlDireita.Controls.Add(Me.BtnManPed)
        Me.PnlDireita.Controls.Add(Me.BtnCabeleireiroM)
        Me.PnlDireita.Controls.Add(Me.BtnCabeleireiroF)
        Me.PnlDireita.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlDireita.Location = New System.Drawing.Point(750, 0)
        Me.PnlDireita.Name = "PnlDireita"
        Me.PnlDireita.Size = New System.Drawing.Size(193, 556)
        Me.PnlDireita.TabIndex = 0
        '
        'PnlPositionActive
        '
        Me.PnlPositionActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.PnlPositionActive.Location = New System.Drawing.Point(186, 142)
        Me.PnlPositionActive.Name = "PnlPositionActive"
        Me.PnlPositionActive.Size = New System.Drawing.Size(7, 49)
        Me.PnlPositionActive.TabIndex = 3
        Me.PnlPositionActive.Visible = False
        '
        'BtnEstetica
        '
        Me.BtnEstetica.BackColor = System.Drawing.Color.Transparent
        Me.BtnEstetica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstetica.FlatAppearance.BorderSize = 0
        Me.BtnEstetica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEstetica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BtnEstetica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEstetica.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEstetica.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEstetica.Image = Global.spaBelezaOficial.My.Resources.Resources.estetica64
        Me.BtnEstetica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEstetica.Location = New System.Drawing.Point(0, 417)
        Me.BtnEstetica.Name = "BtnEstetica"
        Me.BtnEstetica.Size = New System.Drawing.Size(193, 49)
        Me.BtnEstetica.TabIndex = 5
        Me.BtnEstetica.Text = "Estética     "
        Me.BtnEstetica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEstetica.UseVisualStyleBackColor = False
        '
        'BtnMassagem
        '
        Me.BtnMassagem.BackColor = System.Drawing.Color.Transparent
        Me.BtnMassagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMassagem.FlatAppearance.BorderSize = 0
        Me.BtnMassagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnMassagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BtnMassagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMassagem.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMassagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMassagem.Image = Global.spaBelezaOficial.My.Resources.Resources.massagem64
        Me.BtnMassagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMassagem.Location = New System.Drawing.Point(0, 362)
        Me.BtnMassagem.Name = "BtnMassagem"
        Me.BtnMassagem.Size = New System.Drawing.Size(193, 49)
        Me.BtnMassagem.TabIndex = 4
        Me.BtnMassagem.Text = "Massagem     "
        Me.BtnMassagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMassagem.UseVisualStyleBackColor = False
        '
        'BtnMaquiagem
        '
        Me.BtnMaquiagem.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaquiagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaquiagem.FlatAppearance.BorderSize = 0
        Me.BtnMaquiagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnMaquiagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BtnMaquiagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaquiagem.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMaquiagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMaquiagem.Image = Global.spaBelezaOficial.My.Resources.Resources.makeup64
        Me.BtnMaquiagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMaquiagem.Location = New System.Drawing.Point(0, 307)
        Me.BtnMaquiagem.Name = "BtnMaquiagem"
        Me.BtnMaquiagem.Size = New System.Drawing.Size(193, 49)
        Me.BtnMaquiagem.TabIndex = 3
        Me.BtnMaquiagem.Text = "Maquiagem     "
        Me.BtnMaquiagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaquiagem.UseVisualStyleBackColor = False
        '
        'BtnManPed
        '
        Me.BtnManPed.BackColor = System.Drawing.Color.Transparent
        Me.BtnManPed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManPed.FlatAppearance.BorderSize = 0
        Me.BtnManPed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnManPed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BtnManPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManPed.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManPed.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnManPed.Image = Global.spaBelezaOficial.My.Resources.Resources.manicure264
        Me.BtnManPed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManPed.Location = New System.Drawing.Point(0, 252)
        Me.BtnManPed.Name = "BtnManPed"
        Me.BtnManPed.Size = New System.Drawing.Size(193, 49)
        Me.BtnManPed.TabIndex = 2
        Me.BtnManPed.Text = "Manicure     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pedicure     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnManPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManPed.UseVisualStyleBackColor = False
        '
        'BtnCabeleireiroM
        '
        Me.BtnCabeleireiroM.BackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCabeleireiroM.FlatAppearance.BorderSize = 0
        Me.BtnCabeleireiroM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BtnCabeleireiroM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCabeleireiroM.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCabeleireiroM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCabeleireiroM.Image = Global.spaBelezaOficial.My.Resources.Resources.maquina64
        Me.BtnCabeleireiroM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCabeleireiroM.Location = New System.Drawing.Point(0, 197)
        Me.BtnCabeleireiroM.Name = "BtnCabeleireiroM"
        Me.BtnCabeleireiroM.Size = New System.Drawing.Size(193, 49)
        Me.BtnCabeleireiroM.TabIndex = 1
        Me.BtnCabeleireiroM.Text = "Cabeleireiro     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Masculino     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnCabeleireiroM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroM.UseVisualStyleBackColor = False
        '
        'BtnCabeleireiroF
        '
        Me.BtnCabeleireiroF.BackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCabeleireiroF.FlatAppearance.BorderSize = 0
        Me.BtnCabeleireiroF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.BtnCabeleireiroF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCabeleireiroF.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCabeleireiroF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCabeleireiroF.Image = Global.spaBelezaOficial.My.Resources.Resources.tesoura64
        Me.BtnCabeleireiroF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCabeleireiroF.Location = New System.Drawing.Point(0, 142)
        Me.BtnCabeleireiroF.Name = "BtnCabeleireiroF"
        Me.BtnCabeleireiroF.Size = New System.Drawing.Size(193, 49)
        Me.BtnCabeleireiroF.TabIndex = 0
        Me.BtnCabeleireiroF.Text = "Cabeleireiro     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Feminino     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnCabeleireiroF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroF.UseVisualStyleBackColor = False
        '
        'PnlDireitaMenor
        '
        Me.PnlDireitaMenor.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.bgLeft
        Me.PnlDireitaMenor.Controls.Add(Me.BtnEsteticaMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnMassagemMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnMaquiagemMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnManPedMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnCabeleireiroMMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnCabeleireiroFMenor)
        Me.PnlDireitaMenor.Location = New System.Drawing.Point(755, 0)
        Me.PnlDireitaMenor.Name = "PnlDireitaMenor"
        Me.PnlDireitaMenor.Size = New System.Drawing.Size(67, 556)
        Me.PnlDireitaMenor.TabIndex = 4
        '
        'BtnEsteticaMenor
        '
        Me.BtnEsteticaMenor.BackColor = System.Drawing.Color.Transparent
        Me.BtnEsteticaMenor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEsteticaMenor.FlatAppearance.BorderSize = 0
        Me.BtnEsteticaMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEsteticaMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.BtnEsteticaMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEsteticaMenor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEsteticaMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEsteticaMenor.Image = Global.spaBelezaOficial.My.Resources.Resources.estetica64
        Me.BtnEsteticaMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEsteticaMenor.Location = New System.Drawing.Point(2, 417)
        Me.BtnEsteticaMenor.Name = "BtnEsteticaMenor"
        Me.BtnEsteticaMenor.Size = New System.Drawing.Size(61, 49)
        Me.BtnEsteticaMenor.TabIndex = 5
        Me.BtnEsteticaMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEsteticaMenor.UseVisualStyleBackColor = False
        '
        'BtnMassagemMenor
        '
        Me.BtnMassagemMenor.BackColor = System.Drawing.Color.Transparent
        Me.BtnMassagemMenor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMassagemMenor.FlatAppearance.BorderSize = 0
        Me.BtnMassagemMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnMassagemMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.BtnMassagemMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMassagemMenor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMassagemMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMassagemMenor.Image = Global.spaBelezaOficial.My.Resources.Resources.massagem64
        Me.BtnMassagemMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMassagemMenor.Location = New System.Drawing.Point(2, 362)
        Me.BtnMassagemMenor.Name = "BtnMassagemMenor"
        Me.BtnMassagemMenor.Size = New System.Drawing.Size(61, 49)
        Me.BtnMassagemMenor.TabIndex = 4
        Me.BtnMassagemMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMassagemMenor.UseVisualStyleBackColor = False
        '
        'BtnMaquiagemMenor
        '
        Me.BtnMaquiagemMenor.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaquiagemMenor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaquiagemMenor.FlatAppearance.BorderSize = 0
        Me.BtnMaquiagemMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnMaquiagemMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.BtnMaquiagemMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaquiagemMenor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMaquiagemMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMaquiagemMenor.Image = Global.spaBelezaOficial.My.Resources.Resources.makeup64
        Me.BtnMaquiagemMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaquiagemMenor.Location = New System.Drawing.Point(2, 307)
        Me.BtnMaquiagemMenor.Name = "BtnMaquiagemMenor"
        Me.BtnMaquiagemMenor.Size = New System.Drawing.Size(61, 49)
        Me.BtnMaquiagemMenor.TabIndex = 3
        Me.BtnMaquiagemMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaquiagemMenor.UseVisualStyleBackColor = False
        '
        'BtnManPedMenor
        '
        Me.BtnManPedMenor.BackColor = System.Drawing.Color.Transparent
        Me.BtnManPedMenor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManPedMenor.FlatAppearance.BorderSize = 0
        Me.BtnManPedMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnManPedMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.BtnManPedMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManPedMenor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManPedMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnManPedMenor.Image = Global.spaBelezaOficial.My.Resources.Resources.manicure264
        Me.BtnManPedMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManPedMenor.Location = New System.Drawing.Point(2, 252)
        Me.BtnManPedMenor.Name = "BtnManPedMenor"
        Me.BtnManPedMenor.Size = New System.Drawing.Size(61, 49)
        Me.BtnManPedMenor.TabIndex = 2
        Me.BtnManPedMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManPedMenor.UseVisualStyleBackColor = False
        '
        'BtnCabeleireiroMMenor
        '
        Me.BtnCabeleireiroMMenor.BackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroMMenor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCabeleireiroMMenor.FlatAppearance.BorderSize = 0
        Me.BtnCabeleireiroMMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroMMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.BtnCabeleireiroMMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCabeleireiroMMenor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCabeleireiroMMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCabeleireiroMMenor.Image = Global.spaBelezaOficial.My.Resources.Resources.maquina64
        Me.BtnCabeleireiroMMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroMMenor.Location = New System.Drawing.Point(2, 197)
        Me.BtnCabeleireiroMMenor.Name = "BtnCabeleireiroMMenor"
        Me.BtnCabeleireiroMMenor.Size = New System.Drawing.Size(61, 49)
        Me.BtnCabeleireiroMMenor.TabIndex = 1
        Me.BtnCabeleireiroMMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroMMenor.UseVisualStyleBackColor = False
        '
        'BtnCabeleireiroFMenor
        '
        Me.BtnCabeleireiroFMenor.BackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroFMenor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCabeleireiroFMenor.FlatAppearance.BorderSize = 0
        Me.BtnCabeleireiroFMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCabeleireiroFMenor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid
        Me.BtnCabeleireiroFMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCabeleireiroFMenor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCabeleireiroFMenor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCabeleireiroFMenor.Image = Global.spaBelezaOficial.My.Resources.Resources.tesoura64
        Me.BtnCabeleireiroFMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroFMenor.Location = New System.Drawing.Point(2, 142)
        Me.BtnCabeleireiroFMenor.Name = "BtnCabeleireiroFMenor"
        Me.BtnCabeleireiroFMenor.Size = New System.Drawing.Size(61, 49)
        Me.BtnCabeleireiroFMenor.TabIndex = 0
        Me.BtnCabeleireiroFMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroFMenor.UseVisualStyleBackColor = False
        '
        'FrmServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 556)
        Me.Controls.Add(Me.PnlGeral)
        Me.Controls.Add(Me.PnlEsquerda)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PnlDireita)
        Me.Controls.Add(Me.PnlDireitaMenor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnlGeral.ResumeLayout(False)
        Me.PnlGeral.PerformLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDireita.ResumeLayout(False)
        Me.PnlDireitaMenor.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlDireita As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents BtnCabeleireiroF As Button
    Friend WithEvents BtnCabeleireiroM As Button
    Friend WithEvents BtnManPed As Button
    Friend WithEvents BtnMaquiagem As Button
    Friend WithEvents BtnMassagem As Button
    Friend WithEvents BtnEstetica As Button
    Friend WithEvents PnlPositionActive As Panel
    Friend WithEvents PnlEsquerda As Panel
    Friend WithEvents Ofd1 As OpenFileDialog
    Friend WithEvents PnlGeral As Panel
    Friend WithEvents DgvAgenda As DataGridView
    Friend WithEvents LblProfissional As Label
    Friend WithEvents CmbProfissional As ComboBox
    Friend WithEvents LblServico As Label
    Friend WithEvents CmbServico As ComboBox
    Friend WithEvents BtnHideMenu As Button
    Friend WithEvents PnlDireitaMenor As Panel
    Friend WithEvents BtnEsteticaMenor As Button
    Friend WithEvents BtnMassagemMenor As Button
    Friend WithEvents BtnMaquiagemMenor As Button
    Friend WithEvents BtnManPedMenor As Button
    Friend WithEvents BtnCabeleireiroMMenor As Button
    Friend WithEvents BtnCabeleireiroFMenor As Button
    Friend WithEvents BtnCadastrarClienteIcone As Button
    Friend WithEvents BtnCadastrarClienteTxt As Button
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents PicMinimizar As PictureBox
    Friend WithEvents BtnCadastrarCEPTopText As Button
    Friend WithEvents BtnCadastrarCEPTopImage As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TxtData As DateTimePicker
    Friend WithEvents PicTitle As PictureBox
End Class
