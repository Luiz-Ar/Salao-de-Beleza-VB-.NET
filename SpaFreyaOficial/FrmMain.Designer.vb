<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.PnlMid = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbServico = New System.Windows.Forms.ComboBox()
        Me.CmbProfissional = New System.Windows.Forms.ComboBox()
        Me.DgvAgenda = New System.Windows.Forms.DataGridView()
        Me.PnlLeft2 = New System.Windows.Forms.Panel()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PicMinimizar = New System.Windows.Forms.PictureBox()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.BtnHideMenu = New System.Windows.Forms.Button()
        Me.LblCadastrarClientes = New System.Windows.Forms.Label()
        Me.BtnCadastrarClientes = New System.Windows.Forms.Button()
        Me.TxtData = New System.Windows.Forms.DateTimePicker()
        Me.PicTitle = New System.Windows.Forms.PictureBox()
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
        Me.PnlMid.SuspendLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDireita.SuspendLayout()
        Me.PnlDireitaMenor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMid
        '
        Me.PnlMid.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.bgTab2
        Me.PnlMid.Controls.Add(Me.Label2)
        Me.PnlMid.Controls.Add(Me.Label1)
        Me.PnlMid.Controls.Add(Me.CmbServico)
        Me.PnlMid.Controls.Add(Me.CmbProfissional)
        Me.PnlMid.Controls.Add(Me.DgvAgenda)
        Me.PnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMid.Location = New System.Drawing.Point(21, 145)
        Me.PnlMid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlMid.Name = "PnlMid"
        Me.PnlMid.Size = New System.Drawing.Size(979, 539)
        Me.PnlMid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serviço"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Profissional"
        '
        'CmbServico
        '
        Me.CmbServico.FormattingEnabled = True
        Me.CmbServico.Location = New System.Drawing.Point(16, 144)
        Me.CmbServico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbServico.Name = "CmbServico"
        Me.CmbServico.Size = New System.Drawing.Size(201, 24)
        Me.CmbServico.TabIndex = 2
        '
        'CmbProfissional
        '
        Me.CmbProfissional.FormattingEnabled = True
        Me.CmbProfissional.Location = New System.Drawing.Point(16, 81)
        Me.CmbProfissional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbProfissional.Name = "CmbProfissional"
        Me.CmbProfissional.Size = New System.Drawing.Size(201, 24)
        Me.CmbProfissional.TabIndex = 1
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
        Me.DgvAgenda.Location = New System.Drawing.Point(268, 22)
        Me.DgvAgenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.DgvAgenda.RowHeadersWidth = 51
        Me.DgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvAgenda.Size = New System.Drawing.Size(695, 491)
        Me.DgvAgenda.TabIndex = 5
        '
        'PnlLeft2
        '
        Me.PnlLeft2.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.bgLeft2
        Me.PnlLeft2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft2.Location = New System.Drawing.Point(0, 145)
        Me.PnlLeft2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlLeft2.Name = "PnlLeft2"
        Me.PnlLeft2.Size = New System.Drawing.Size(21, 539)
        Me.PnlLeft2.TabIndex = 2
        '
        'PnlTop
        '
        Me.PnlTop.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.bgTop2
        Me.PnlTop.Controls.Add(Me.PicMinimizar)
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Controls.Add(Me.BtnHideMenu)
        Me.PnlTop.Controls.Add(Me.LblCadastrarClientes)
        Me.PnlTop.Controls.Add(Me.BtnCadastrarClientes)
        Me.PnlTop.Controls.Add(Me.TxtData)
        Me.PnlTop.Controls.Add(Me.PicTitle)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1000, 145)
        Me.PnlTop.TabIndex = 1
        '
        'PicMinimizar
        '
        Me.PicMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimizar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.btnMaximiza
        Me.PicMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicMinimizar.Location = New System.Drawing.Point(43, 15)
        Me.PicMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicMinimizar.Name = "PicMinimizar"
        Me.PicMinimizar.Size = New System.Drawing.Size(21, 20)
        Me.PicMinimizar.TabIndex = 8
        Me.PicMinimizar.TabStop = False
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Location = New System.Drawing.Point(17, 15)
        Me.PicFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(21, 20)
        Me.PicFechar.TabIndex = 7
        Me.PicFechar.TabStop = False
        '
        'BtnHideMenu
        '
        Me.BtnHideMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.hideMenu
        Me.BtnHideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHideMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHideMenu.FlatAppearance.BorderSize = 0
        Me.BtnHideMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHideMenu.Location = New System.Drawing.Point(956, 6)
        Me.BtnHideMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnHideMenu.Name = "BtnHideMenu"
        Me.BtnHideMenu.Size = New System.Drawing.Size(39, 39)
        Me.BtnHideMenu.TabIndex = 6
        Me.BtnHideMenu.UseVisualStyleBackColor = False
        '
        'LblCadastrarClientes
        '
        Me.LblCadastrarClientes.AutoSize = True
        Me.LblCadastrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.LblCadastrarClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCadastrarClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCadastrarClientes.Location = New System.Drawing.Point(817, 121)
        Me.LblCadastrarClientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCadastrarClientes.Name = "LblCadastrarClientes"
        Me.LblCadastrarClientes.Size = New System.Drawing.Size(124, 17)
        Me.LblCadastrarClientes.TabIndex = 3
        Me.LblCadastrarClientes.Text = "Cadastrar Clientes"
        '
        'BtnCadastrarClientes
        '
        Me.BtnCadastrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClientes.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources._00fotoCliente
        Me.BtnCadastrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCadastrarClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrarClientes.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCadastrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarClientes.Location = New System.Drawing.Point(829, 15)
        Me.BtnCadastrarClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCadastrarClientes.Name = "BtnCadastrarClientes"
        Me.BtnCadastrarClientes.Size = New System.Drawing.Size(100, 100)
        Me.BtnCadastrarClientes.TabIndex = 1
        Me.BtnCadastrarClientes.UseVisualStyleBackColor = False
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(21, 113)
        Me.TxtData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(280, 22)
        Me.TxtData.TabIndex = 0
        '
        'PicTitle
        '
        Me.PicTitle.BackColor = System.Drawing.Color.Transparent
        Me.PicTitle.Location = New System.Drawing.Point(268, 0)
        Me.PicTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicTitle.Name = "PicTitle"
        Me.PicTitle.Size = New System.Drawing.Size(429, 145)
        Me.PicTitle.TabIndex = 5
        Me.PicTitle.TabStop = False
        '
        'PnlDireita
        '
        Me.PnlDireita.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.bgLeft
        Me.PnlDireita.Controls.Add(Me.PnlPositionActive)
        Me.PnlDireita.Controls.Add(Me.BtnEstetica)
        Me.PnlDireita.Controls.Add(Me.BtnMassagem)
        Me.PnlDireita.Controls.Add(Me.BtnMaquiagem)
        Me.PnlDireita.Controls.Add(Me.BtnManPed)
        Me.PnlDireita.Controls.Add(Me.BtnCabeleireiroM)
        Me.PnlDireita.Controls.Add(Me.BtnCabeleireiroF)
        Me.PnlDireita.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlDireita.Location = New System.Drawing.Point(1000, 0)
        Me.PnlDireita.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlDireita.Name = "PnlDireita"
        Me.PnlDireita.Size = New System.Drawing.Size(257, 684)
        Me.PnlDireita.TabIndex = 0
        '
        'PnlPositionActive
        '
        Me.PnlPositionActive.Location = New System.Drawing.Point(244, 145)
        Me.PnlPositionActive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlPositionActive.Name = "PnlPositionActive"
        Me.PnlPositionActive.Size = New System.Drawing.Size(13, 53)
        Me.PnlPositionActive.TabIndex = 6
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
        Me.BtnEstetica.Image = Global.SpaFreyaOficial.My.Resources.Resources.estetica64
        Me.BtnEstetica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEstetica.Location = New System.Drawing.Point(0, 513)
        Me.BtnEstetica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEstetica.Name = "BtnEstetica"
        Me.BtnEstetica.Size = New System.Drawing.Size(257, 60)
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
        Me.BtnMassagem.Image = Global.SpaFreyaOficial.My.Resources.Resources.massagem64
        Me.BtnMassagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMassagem.Location = New System.Drawing.Point(0, 446)
        Me.BtnMassagem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMassagem.Name = "BtnMassagem"
        Me.BtnMassagem.Size = New System.Drawing.Size(257, 60)
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
        Me.BtnMaquiagem.Image = Global.SpaFreyaOficial.My.Resources.Resources.makeup64
        Me.BtnMaquiagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMaquiagem.Location = New System.Drawing.Point(0, 378)
        Me.BtnMaquiagem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMaquiagem.Name = "BtnMaquiagem"
        Me.BtnMaquiagem.Size = New System.Drawing.Size(257, 60)
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
        Me.BtnManPed.Image = Global.SpaFreyaOficial.My.Resources.Resources.manicure264
        Me.BtnManPed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManPed.Location = New System.Drawing.Point(0, 310)
        Me.BtnManPed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnManPed.Name = "BtnManPed"
        Me.BtnManPed.Size = New System.Drawing.Size(257, 60)
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
        Me.BtnCabeleireiroM.Image = Global.SpaFreyaOficial.My.Resources.Resources.maquina64
        Me.BtnCabeleireiroM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCabeleireiroM.Location = New System.Drawing.Point(0, 242)
        Me.BtnCabeleireiroM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCabeleireiroM.Name = "BtnCabeleireiroM"
        Me.BtnCabeleireiroM.Size = New System.Drawing.Size(257, 60)
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
        Me.BtnCabeleireiroF.Image = Global.SpaFreyaOficial.My.Resources.Resources.tesoura64
        Me.BtnCabeleireiroF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCabeleireiroF.Location = New System.Drawing.Point(0, 175)
        Me.BtnCabeleireiroF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCabeleireiroF.Name = "BtnCabeleireiroF"
        Me.BtnCabeleireiroF.Size = New System.Drawing.Size(257, 60)
        Me.BtnCabeleireiroF.TabIndex = 0
        Me.BtnCabeleireiroF.Text = "Cabeleireiro     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Feminino     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnCabeleireiroF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroF.UseVisualStyleBackColor = False
        '
        'PnlDireitaMenor
        '
        Me.PnlDireitaMenor.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.bgLeft
        Me.PnlDireitaMenor.Controls.Add(Me.BtnEsteticaMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnMassagemMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnMaquiagemMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnManPedMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnCabeleireiroMMenor)
        Me.PnlDireitaMenor.Controls.Add(Me.BtnCabeleireiroFMenor)
        Me.PnlDireitaMenor.Location = New System.Drawing.Point(1007, 0)
        Me.PnlDireitaMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlDireitaMenor.Name = "PnlDireitaMenor"
        Me.PnlDireitaMenor.Size = New System.Drawing.Size(89, 684)
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
        Me.BtnEsteticaMenor.Image = Global.SpaFreyaOficial.My.Resources.Resources.estetica64
        Me.BtnEsteticaMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEsteticaMenor.Location = New System.Drawing.Point(3, 513)
        Me.BtnEsteticaMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEsteticaMenor.Name = "BtnEsteticaMenor"
        Me.BtnEsteticaMenor.Size = New System.Drawing.Size(81, 60)
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
        Me.BtnMassagemMenor.Image = Global.SpaFreyaOficial.My.Resources.Resources.massagem64
        Me.BtnMassagemMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMassagemMenor.Location = New System.Drawing.Point(3, 446)
        Me.BtnMassagemMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMassagemMenor.Name = "BtnMassagemMenor"
        Me.BtnMassagemMenor.Size = New System.Drawing.Size(81, 60)
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
        Me.BtnMaquiagemMenor.Image = Global.SpaFreyaOficial.My.Resources.Resources.makeup64
        Me.BtnMaquiagemMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaquiagemMenor.Location = New System.Drawing.Point(3, 378)
        Me.BtnMaquiagemMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMaquiagemMenor.Name = "BtnMaquiagemMenor"
        Me.BtnMaquiagemMenor.Size = New System.Drawing.Size(81, 60)
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
        Me.BtnManPedMenor.Image = Global.SpaFreyaOficial.My.Resources.Resources.manicure264
        Me.BtnManPedMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManPedMenor.Location = New System.Drawing.Point(3, 310)
        Me.BtnManPedMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnManPedMenor.Name = "BtnManPedMenor"
        Me.BtnManPedMenor.Size = New System.Drawing.Size(81, 60)
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
        Me.BtnCabeleireiroMMenor.Image = Global.SpaFreyaOficial.My.Resources.Resources.maquina64
        Me.BtnCabeleireiroMMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroMMenor.Location = New System.Drawing.Point(3, 242)
        Me.BtnCabeleireiroMMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCabeleireiroMMenor.Name = "BtnCabeleireiroMMenor"
        Me.BtnCabeleireiroMMenor.Size = New System.Drawing.Size(81, 60)
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
        Me.BtnCabeleireiroFMenor.Image = Global.SpaFreyaOficial.My.Resources.Resources.tesoura64
        Me.BtnCabeleireiroFMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroFMenor.Location = New System.Drawing.Point(3, 175)
        Me.BtnCabeleireiroFMenor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCabeleireiroFMenor.Name = "BtnCabeleireiroFMenor"
        Me.BtnCabeleireiroFMenor.Size = New System.Drawing.Size(81, 60)
        Me.BtnCabeleireiroFMenor.TabIndex = 0
        Me.BtnCabeleireiroFMenor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCabeleireiroFMenor.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 684)
        Me.Controls.Add(Me.PnlMid)
        Me.Controls.Add(Me.PnlLeft2)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PnlDireita)
        Me.Controls.Add(Me.PnlDireitaMenor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        Me.PnlMid.ResumeLayout(False)
        Me.PnlMid.PerformLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDireita.ResumeLayout(False)
        Me.PnlDireitaMenor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlDireita As Panel
    Friend WithEvents BtnEsteticaMenor As Button
    Friend WithEvents BtnMassagemMenor As Button
    Friend WithEvents BtnMaquiagemMenor As Button
    Friend WithEvents BtnManPedMenor As Button
    Friend WithEvents BtnCabeleireiroMMenor As Button
    Friend WithEvents BtnCabeleireiroFMenor As Button
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlLeft2 As Panel
    Friend WithEvents PnlMid As Panel
    Friend WithEvents DgvAgenda As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbServico As ComboBox
    Friend WithEvents CmbProfissional As ComboBox
    Friend WithEvents TxtData As DateTimePicker
    Friend WithEvents BtnCabeleireiroF As Button
    Friend WithEvents BtnEstetica As Button
    Friend WithEvents BtnMassagem As Button
    Friend WithEvents BtnMaquiagem As Button
    Friend WithEvents BtnManPed As Button
    Friend WithEvents BtnCabeleireiroM As Button
    Friend WithEvents BtnCadastrarClientes As Button
    Friend WithEvents LblCadastrarClientes As Label
    Friend WithEvents PicTitle As PictureBox
    Friend WithEvents BtnHideMenu As Button
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents PicMinimizar As PictureBox
    Friend WithEvents PnlPositionActive As Panel
    Friend WithEvents PnlDireitaMenor As Panel
End Class
