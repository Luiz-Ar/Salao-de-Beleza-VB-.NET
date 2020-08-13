<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.PnlMid = New System.Windows.Forms.Panel()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.PicSenha = New System.Windows.Forms.PictureBox()
        Me.PicCpf = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.PnlMid.SuspendLayout()
        CType(Me.PicSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCpf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMid
        '
        Me.PnlMid.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.bgLoginDown
        Me.PnlMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PnlMid.Controls.Add(Me.BtnEntrar)
        Me.PnlMid.Controls.Add(Me.LblTipo)
        Me.PnlMid.Controls.Add(Me.TxtSenha)
        Me.PnlMid.Controls.Add(Me.TxtCpf)
        Me.PnlMid.Controls.Add(Me.PicSenha)
        Me.PnlMid.Controls.Add(Me.PicCpf)
        Me.PnlMid.Controls.Add(Me.Label2)
        Me.PnlMid.Controls.Add(Me.Label1)
        Me.PnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMid.Location = New System.Drawing.Point(0, 59)
        Me.PnlMid.Name = "PnlMid"
        Me.PnlMid.Size = New System.Drawing.Size(626, 531)
        Me.PnlMid.TabIndex = 1
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.btnEntrarRoxo
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Location = New System.Drawing.Point(74, 274)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(174, 46)
        Me.BtnEntrar.TabIndex = 3
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(132, 161)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(0, 13)
        Me.LblTipo.TabIndex = 14
        '
        'TxtSenha
        '
        Me.TxtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.ForeColor = System.Drawing.Color.White
        Me.TxtSenha.Location = New System.Drawing.Point(135, 223)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(123, 19)
        Me.TxtSenha.TabIndex = 12
        '
        'TxtCpf
        '
        Me.TxtCpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpf.ForeColor = System.Drawing.Color.White
        Me.TxtCpf.Location = New System.Drawing.Point(135, 185)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(123, 19)
        Me.TxtCpf.TabIndex = 11
        '
        'PicSenha
        '
        Me.PicSenha.BackColor = System.Drawing.Color.Transparent
        Me.PicSenha.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.senha
        Me.PicSenha.Location = New System.Drawing.Point(63, 220)
        Me.PicSenha.Name = "PicSenha"
        Me.PicSenha.Size = New System.Drawing.Size(195, 26)
        Me.PicSenha.TabIndex = 10
        Me.PicSenha.TabStop = False
        '
        'PicCpf
        '
        Me.PicCpf.BackColor = System.Drawing.Color.Transparent
        Me.PicCpf.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.cpf
        Me.PicCpf.Location = New System.Drawing.Point(63, 182)
        Me.PicCpf.Name = "PicCpf"
        Me.PicCpf.Size = New System.Drawing.Size(195, 26)
        Me.PicCpf.TabIndex = 9
        Me.PicCpf.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(12, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 79)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Beauty Spa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 54.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(72, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 87)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Freya"
        '
        'PnlTop
        '
        Me.PnlTop.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.BgLoginUp
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(626, 59)
        Me.PnlTop.TabIndex = 0
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.SpaFreyaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicFechar.Location = New System.Drawing.Point(8, 7)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 41
        Me.PicFechar.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 590)
        Me.Controls.Add(Me.PnlMid)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.PnlMid.ResumeLayout(False)
        Me.PnlMid.PerformLayout()
        CType(Me.PicSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCpf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlMid As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents PicSenha As PictureBox
    Friend WithEvents PicCpf As PictureBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents LblTipo As Label
    Friend WithEvents BtnEntrar As Button
End Class
