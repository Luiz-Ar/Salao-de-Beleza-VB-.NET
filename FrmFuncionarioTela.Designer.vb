﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFuncionarioTela
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.LblCadastroClienteTitle = New System.Windows.Forms.Label()
        Me.DgvAgenda = New System.Windows.Forms.DataGridView()
        Me.TxtData = New System.Windows.Forms.DateTimePicker()
        Me.PicFechar = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PnlTop.SuspendLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.PicFechar)
        Me.PnlTop.Controls.Add(Me.LblCadastroClienteTitle)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(560, 29)
        Me.PnlTop.TabIndex = 0
        '
        'LblCadastroClienteTitle
        '
        Me.LblCadastroClienteTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCadastroClienteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCadastroClienteTitle.Location = New System.Drawing.Point(0, 6)
        Me.LblCadastroClienteTitle.Name = "LblCadastroClienteTitle"
        Me.LblCadastroClienteTitle.Size = New System.Drawing.Size(560, 16)
        Me.LblCadastroClienteTitle.TabIndex = 42
        Me.LblCadastroClienteTitle.Text = "AGENDA FUNCIONARIO"
        Me.LblCadastroClienteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DgvAgenda
        '
        Me.DgvAgenda.AllowUserToAddRows = False
        Me.DgvAgenda.AllowUserToDeleteRows = False
        Me.DgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAgenda.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkMagenta
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAgenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAgenda.DefaultCellStyle = DataGridViewCellStyle20
        Me.DgvAgenda.GridColor = System.Drawing.Color.Indigo
        Me.DgvAgenda.Location = New System.Drawing.Point(20, 68)
        Me.DgvAgenda.MultiSelect = False
        Me.DgvAgenda.Name = "DgvAgenda"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAgenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DgvAgenda.RowHeadersVisible = False
        Me.DgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvAgenda.Size = New System.Drawing.Size(521, 399)
        Me.DgvAgenda.TabIndex = 5
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(20, 38)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(212, 20)
        Me.TxtData.TabIndex = 6
        '
        'PicFechar
        '
        Me.PicFechar.BackColor = System.Drawing.Color.Transparent
        Me.PicFechar.BackgroundImage = Global.spaBelezaOficial.My.Resources.Resources.btnFechar
        Me.PicFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFechar.Location = New System.Drawing.Point(12, 6)
        Me.PicFechar.Name = "PicFechar"
        Me.PicFechar.Size = New System.Drawing.Size(15, 15)
        Me.PicFechar.TabIndex = 43
        Me.PicFechar.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(434, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmFuncionarioTela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 481)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtData)
        Me.Controls.Add(Me.DgvAgenda)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFuncionarioTela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFuncionarioTela"
        Me.PnlTop.ResumeLayout(False)
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents DgvAgenda As DataGridView
    Friend WithEvents LblCadastroClienteTitle As Label
    Friend WithEvents TxtData As DateTimePicker
    Friend WithEvents PicFechar As PictureBox
    Friend WithEvents Button1 As Button
End Class
