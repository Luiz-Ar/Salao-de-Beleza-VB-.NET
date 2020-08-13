<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmShow
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
        Me.DgvGeral = New System.Windows.Forms.DataGridView()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DgvGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvGeral
        '
        Me.DgvGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGeral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Cargo, Me.Delete})
        Me.DgvGeral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvGeral.Location = New System.Drawing.Point(0, 0)
        Me.DgvGeral.Name = "DgvGeral"
        Me.DgvGeral.Size = New System.Drawing.Size(800, 450)
        Me.DgvGeral.TabIndex = 0
        '
        'PnlTop
        '
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(800, 53)
        Me.PnlTop.TabIndex = 1
        '
        'Cod
        '
        Me.Cod.HeaderText = "Cod"
        Me.Cod.Name = "Cod"
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        '
        'FrmShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.DgvGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmShow"
        Me.Text = "Form1"
        CType(Me.DgvGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvGeral As DataGridView
    Friend WithEvents PnlTop As Panel
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
