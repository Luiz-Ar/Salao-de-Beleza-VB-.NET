<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCep
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
        Me.PnlCadastrarCep = New System.Windows.Forms.Panel()
        Me.BtnSearchCep = New System.Windows.Forms.Button()
        Me.BtnLimparCep = New System.Windows.Forms.Button()
        Me.BtnCadastrarCep = New System.Windows.Forms.Button()
        Me.TxtCepPesquisar = New System.Windows.Forms.MaskedTextBox()
        Me.LblCepPesquisar = New System.Windows.Forms.Label()
        Me.PnlSepCep = New System.Windows.Forms.Panel()
        Me.LblCadastrodeCep = New System.Windows.Forms.Label()
        Me.PicPlacas = New System.Windows.Forms.PictureBox()
        Me.LblCadastroEstado = New System.Windows.Forms.Label()
        Me.TxtCadastroEstado = New System.Windows.Forms.TextBox()
        Me.LblCadastroCidade = New System.Windows.Forms.Label()
        Me.TxtCadastroCidade = New System.Windows.Forms.TextBox()
        Me.LblCadastroBairro = New System.Windows.Forms.Label()
        Me.TxtCadastroBairro = New System.Windows.Forms.TextBox()
        Me.LblCadastroEndereco = New System.Windows.Forms.Label()
        Me.TxtCadastroEndereco = New System.Windows.Forms.TextBox()
        Me.LblCadastroCep = New System.Windows.Forms.Label()
        Me.TxtCadastroCep = New System.Windows.Forms.MaskedTextBox()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.LblCadastroCepTitle = New System.Windows.Forms.Label()
        Me.PicMinimizar = New System.Windows.Forms.PictureBox()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.PnlCadastrarCep.SuspendLayout()
        CType(Me.PicPlacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlCadastrarCep
        '
        Me.PnlCadastrarCep.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PnlCadastrarCep.Controls.Add(Me.BtnSearchCep)
        Me.PnlCadastrarCep.Controls.Add(Me.BtnLimparCep)
        Me.PnlCadastrarCep.Controls.Add(Me.BtnCadastrarCep)
        Me.PnlCadastrarCep.Controls.Add(Me.TxtCepPesquisar)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCepPesquisar)
        Me.PnlCadastrarCep.Controls.Add(Me.PnlSepCep)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCadastrodeCep)
        Me.PnlCadastrarCep.Controls.Add(Me.PicPlacas)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCadastroEstado)
        Me.PnlCadastrarCep.Controls.Add(Me.TxtCadastroEstado)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCadastroCidade)
        Me.PnlCadastrarCep.Controls.Add(Me.TxtCadastroCidade)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCadastroBairro)
        Me.PnlCadastrarCep.Controls.Add(Me.TxtCadastroBairro)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCadastroEndereco)
        Me.PnlCadastrarCep.Controls.Add(Me.TxtCadastroEndereco)
        Me.PnlCadastrarCep.Controls.Add(Me.LblCadastroCep)
        Me.PnlCadastrarCep.Controls.Add(Me.TxtCadastroCep)
        Me.PnlCadastrarCep.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlCadastrarCep.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PnlCadastrarCep.Location = New System.Drawing.Point(0, 27)
        Me.PnlCadastrarCep.Name = "PnlCadastrarCep"
        Me.PnlCadastrarCep.Size = New System.Drawing.Size(800, 423)
        Me.PnlCadastrarCep.TabIndex = 32
        '
        'BtnSearchCep
        '
        Me.BtnSearchCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearchCep.FlatAppearance.BorderSize = 0
        Me.BtnSearchCep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSearchCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSearchCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchCep.Image = Global.spaBelezaOficial.My.Resources.Resources.searchIcon
        Me.BtnSearchCep.Location = New System.Drawing.Point(254, 75)
        Me.BtnSearchCep.Name = "BtnSearchCep"
        Me.BtnSearchCep.Size = New System.Drawing.Size(25, 25)
        Me.BtnSearchCep.TabIndex = 37
        Me.BtnSearchCep.UseVisualStyleBackColor = True
        '
        'BtnLimparCep
        '
        Me.BtnLimparCep.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnLimparCep.FlatAppearance.BorderSize = 0
        Me.BtnLimparCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimparCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimparCep.Location = New System.Drawing.Point(208, 318)
        Me.BtnLimparCep.Name = "BtnLimparCep"
        Me.BtnLimparCep.Size = New System.Drawing.Size(119, 58)
        Me.BtnLimparCep.TabIndex = 36
        Me.BtnLimparCep.Text = "LIMPAR"
        Me.BtnLimparCep.UseVisualStyleBackColor = False
        '
        'BtnCadastrarCep
        '
        Me.BtnCadastrarCep.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnCadastrarCep.FlatAppearance.BorderSize = 0
        Me.BtnCadastrarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrarCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarCep.Location = New System.Drawing.Point(73, 318)
        Me.BtnCadastrarCep.Name = "BtnCadastrarCep"
        Me.BtnCadastrarCep.Size = New System.Drawing.Size(119, 58)
        Me.BtnCadastrarCep.TabIndex = 35
        Me.BtnCadastrarCep.Text = "CADASTRO"
        Me.BtnCadastrarCep.UseVisualStyleBackColor = False
        '
        'TxtCepPesquisar
        '
        Me.TxtCepPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCepPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCepPesquisar.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtCepPesquisar.Location = New System.Drawing.Point(182, 79)
        Me.TxtCepPesquisar.Mask = "00000-000"
        Me.TxtCepPesquisar.Name = "TxtCepPesquisar"
        Me.TxtCepPesquisar.Size = New System.Drawing.Size(67, 22)
        Me.TxtCepPesquisar.TabIndex = 34
        '
        'LblCepPesquisar
        '
        Me.LblCepPesquisar.AutoSize = True
        Me.LblCepPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCepPesquisar.Location = New System.Drawing.Point(49, 82)
        Me.LblCepPesquisar.Name = "LblCepPesquisar"
        Me.LblCepPesquisar.Size = New System.Drawing.Size(125, 16)
        Me.LblCepPesquisar.TabIndex = 33
        Me.LblCepPesquisar.Text = "Pesquisar por CEP:"
        '
        'PnlSepCep
        '
        Me.PnlSepCep.BackColor = System.Drawing.Color.White
        Me.PnlSepCep.Location = New System.Drawing.Point(51, 64)
        Me.PnlSepCep.Name = "PnlSepCep"
        Me.PnlSepCep.Size = New System.Drawing.Size(683, 6)
        Me.PnlSepCep.TabIndex = 32
        '
        'LblCadastrodeCep
        '
        Me.LblCadastrodeCep.AutoSize = True
        Me.LblCadastrodeCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastrodeCep.Location = New System.Drawing.Point(44, 17)
        Me.LblCadastrodeCep.Name = "LblCadastrodeCep"
        Me.LblCadastrodeCep.Size = New System.Drawing.Size(309, 42)
        Me.LblCadastrodeCep.TabIndex = 31
        Me.LblCadastrodeCep.Text = "Cadastro de CEP"
        '
        'PicPlacas
        '
        Me.PicPlacas.Image = Global.spaBelezaOficial.My.Resources.Resources.placas
        Me.PicPlacas.Location = New System.Drawing.Point(425, 176)
        Me.PicPlacas.Name = "PicPlacas"
        Me.PicPlacas.Size = New System.Drawing.Size(325, 244)
        Me.PicPlacas.TabIndex = 30
        Me.PicPlacas.TabStop = False
        '
        'LblCadastroEstado
        '
        Me.LblCadastroEstado.AutoSize = True
        Me.LblCadastroEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCadastroEstado.Location = New System.Drawing.Point(34, 270)
        Me.LblCadastroEstado.Name = "LblCadastroEstado"
        Me.LblCadastroEstado.Size = New System.Drawing.Size(54, 16)
        Me.LblCadastroEstado.TabIndex = 29
        Me.LblCadastroEstado.Text = "Estado:"
        '
        'TxtCadastroEstado
        '
        Me.TxtCadastroEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCadastroEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCadastroEstado.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtCadastroEstado.Location = New System.Drawing.Point(106, 267)
        Me.TxtCadastroEstado.Name = "TxtCadastroEstado"
        Me.TxtCadastroEstado.Size = New System.Drawing.Size(118, 22)
        Me.TxtCadastroEstado.TabIndex = 28
        '
        'LblCadastroCidade
        '
        Me.LblCadastroCidade.AutoSize = True
        Me.LblCadastroCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroCidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCadastroCidade.Location = New System.Drawing.Point(34, 243)
        Me.LblCadastroCidade.Name = "LblCadastroCidade"
        Me.LblCadastroCidade.Size = New System.Drawing.Size(55, 16)
        Me.LblCadastroCidade.TabIndex = 27
        Me.LblCadastroCidade.Text = "Cidade:"
        '
        'TxtCadastroCidade
        '
        Me.TxtCadastroCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCadastroCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCadastroCidade.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtCadastroCidade.Location = New System.Drawing.Point(106, 240)
        Me.TxtCadastroCidade.Name = "TxtCadastroCidade"
        Me.TxtCadastroCidade.Size = New System.Drawing.Size(176, 22)
        Me.TxtCadastroCidade.TabIndex = 26
        '
        'LblCadastroBairro
        '
        Me.LblCadastroBairro.AutoSize = True
        Me.LblCadastroBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroBairro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCadastroBairro.Location = New System.Drawing.Point(34, 215)
        Me.LblCadastroBairro.Name = "LblCadastroBairro"
        Me.LblCadastroBairro.Size = New System.Drawing.Size(47, 16)
        Me.LblCadastroBairro.TabIndex = 25
        Me.LblCadastroBairro.Text = "Bairro:"
        '
        'TxtCadastroBairro
        '
        Me.TxtCadastroBairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCadastroBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCadastroBairro.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtCadastroBairro.Location = New System.Drawing.Point(106, 212)
        Me.TxtCadastroBairro.Name = "TxtCadastroBairro"
        Me.TxtCadastroBairro.Size = New System.Drawing.Size(226, 22)
        Me.TxtCadastroBairro.TabIndex = 24
        '
        'LblCadastroEndereco
        '
        Me.LblCadastroEndereco.AutoSize = True
        Me.LblCadastroEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCadastroEndereco.Location = New System.Drawing.Point(34, 188)
        Me.LblCadastroEndereco.Name = "LblCadastroEndereco"
        Me.LblCadastroEndereco.Size = New System.Drawing.Size(70, 16)
        Me.LblCadastroEndereco.TabIndex = 21
        Me.LblCadastroEndereco.Text = "Endereço:"
        '
        'TxtCadastroEndereco
        '
        Me.TxtCadastroEndereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCadastroEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCadastroEndereco.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtCadastroEndereco.Location = New System.Drawing.Point(106, 185)
        Me.TxtCadastroEndereco.Name = "TxtCadastroEndereco"
        Me.TxtCadastroEndereco.Size = New System.Drawing.Size(284, 22)
        Me.TxtCadastroEndereco.TabIndex = 20
        '
        'LblCadastroCep
        '
        Me.LblCadastroCep.AutoSize = True
        Me.LblCadastroCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroCep.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCadastroCep.Location = New System.Drawing.Point(34, 159)
        Me.LblCadastroCep.Name = "LblCadastroCep"
        Me.LblCadastroCep.Size = New System.Drawing.Size(38, 16)
        Me.LblCadastroCep.TabIndex = 19
        Me.LblCadastroCep.Text = "CEP:"
        '
        'TxtCadastroCep
        '
        Me.TxtCadastroCep.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCadastroCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCadastroCep.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtCadastroCep.Location = New System.Drawing.Point(106, 156)
        Me.TxtCadastroCep.Mask = "00000-000"
        Me.TxtCadastroCep.Name = "TxtCadastroCep"
        Me.TxtCadastroCep.Size = New System.Drawing.Size(67, 22)
        Me.TxtCadastroCep.TabIndex = 18
        '
        'PnlTop
        '
        Me.PnlTop.Controls.Add(Me.LblCadastroCepTitle)
        Me.PnlTop.Controls.Add(Me.PicMinimizar)
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(800, 29)
        Me.PnlTop.TabIndex = 33
        '
        'LblCadastroCepTitle
        '
        Me.LblCadastroCepTitle.AutoSize = True
        Me.LblCadastroCepTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroCepTitle.Location = New System.Drawing.Point(328, 6)
        Me.LblCadastroCepTitle.Name = "LblCadastroCepTitle"
        Me.LblCadastroCepTitle.Size = New System.Drawing.Size(125, 16)
        Me.LblCadastroCepTitle.TabIndex = 40
        Me.LblCadastroCepTitle.Text = "CADASTRO CEP"
        '
        'PicMinimizar
        '
        Me.PicMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimizar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnMaximiza
        Me.PicMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicMinimizar.Location = New System.Drawing.Point(39, 6)
        Me.PicMinimizar.Name = "PicMinimizar"
        Me.PicMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.PicMinimizar.TabIndex = 39
        Me.PicMinimizar.TabStop = False
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Location = New System.Drawing.Point(21, 6)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 38
        Me.PicFechar.TabStop = False
        '
        'FrmCep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.PnlCadastrarCep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.PnlCadastrarCep.ResumeLayout(False)
        Me.PnlCadastrarCep.PerformLayout()
        CType(Me.PicPlacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.PicMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlCadastrarCep As Panel
    Friend WithEvents BtnSearchCep As Button
    Friend WithEvents BtnLimparCep As Button
    Friend WithEvents BtnCadastrarCep As Button
    Friend WithEvents TxtCepPesquisar As MaskedTextBox
    Friend WithEvents LblCepPesquisar As Label
    Friend WithEvents PnlSepCep As Panel
    Friend WithEvents LblCadastrodeCep As Label
    Friend WithEvents PicPlacas As PictureBox
    Friend WithEvents LblCadastroEstado As Label
    Friend WithEvents TxtCadastroEstado As TextBox
    Friend WithEvents LblCadastroCidade As Label
    Friend WithEvents TxtCadastroCidade As TextBox
    Friend WithEvents LblCadastroBairro As Label
    Friend WithEvents TxtCadastroBairro As TextBox
    Friend WithEvents LblCadastroEndereco As Label
    Friend WithEvents TxtCadastroEndereco As TextBox
    Friend WithEvents LblCadastroCep As Label
    Friend WithEvents TxtCadastroCep As MaskedTextBox
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PicMinimizar As PictureBox
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents LblCadastroCepTitle As Label
End Class
