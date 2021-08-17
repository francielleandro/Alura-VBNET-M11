<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ManutencaoClienteDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ManutencaoClienteDB))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolSaveButton = New System.Windows.Forms.ToolStripButton()
        Me.Lbl_Cpf = New System.Windows.Forms.Label()
        Me.Txt_Cpf = New System.Windows.Forms.TextBox()
        Me.Txt_Profissao = New System.Windows.Forms.TextBox()
        Me.Lbl_Profissao = New System.Windows.Forms.Label()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Grp_Lista = New System.Windows.Forms.GroupBox()
        Me.Lvw_Clientes = New System.Windows.Forms.ListView()
        Me.ToolStrip1.SuspendLayout()
        Me.Grp_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.ToolStripButton1, Me.ToolSaveButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(487, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Deletar"
        '
        'ToolSaveButton
        '
        Me.ToolSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSaveButton.Name = "ToolSaveButton"
        Me.ToolSaveButton.Size = New System.Drawing.Size(23, 22)
        Me.ToolSaveButton.Text = "Salvar"
        '
        'Lbl_Cpf
        '
        Me.Lbl_Cpf.AutoSize = True
        Me.Lbl_Cpf.Location = New System.Drawing.Point(20, 39)
        Me.Lbl_Cpf.Name = "Lbl_Cpf"
        Me.Lbl_Cpf.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cpf.TabIndex = 4
        Me.Lbl_Cpf.Text = "Label1"
        '
        'Txt_Cpf
        '
        Me.Txt_Cpf.Location = New System.Drawing.Point(66, 31)
        Me.Txt_Cpf.Name = "Txt_Cpf"
        Me.Txt_Cpf.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Cpf.TabIndex = 5
        '
        'Txt_Profissao
        '
        Me.Txt_Profissao.Location = New System.Drawing.Point(66, 57)
        Me.Txt_Profissao.Name = "Txt_Profissao"
        Me.Txt_Profissao.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Profissao.TabIndex = 7
        '
        'Lbl_Profissao
        '
        Me.Lbl_Profissao.AutoSize = True
        Me.Lbl_Profissao.Location = New System.Drawing.Point(20, 65)
        Me.Lbl_Profissao.Name = "Lbl_Profissao"
        Me.Lbl_Profissao.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Profissao.TabIndex = 6
        Me.Lbl_Profissao.Text = "Label1"
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Location = New System.Drawing.Point(66, 83)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Nome.TabIndex = 9
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.AutoSize = True
        Me.Lbl_Nome.Location = New System.Drawing.Point(20, 91)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Nome.TabIndex = 8
        Me.Lbl_Nome.Text = "Label1"
        '
        'Grp_Lista
        '
        Me.Grp_Lista.Controls.Add(Me.Lvw_Clientes)
        Me.Grp_Lista.Location = New System.Drawing.Point(13, 132)
        Me.Grp_Lista.Name = "Grp_Lista"
        Me.Grp_Lista.Size = New System.Drawing.Size(451, 231)
        Me.Grp_Lista.TabIndex = 11
        Me.Grp_Lista.TabStop = False
        Me.Grp_Lista.Text = "GroupBox1"
        '
        'Lvw_Clientes
        '
        Me.Lvw_Clientes.HideSelection = False
        Me.Lvw_Clientes.Location = New System.Drawing.Point(7, 20)
        Me.Lvw_Clientes.Name = "Lvw_Clientes"
        Me.Lvw_Clientes.Size = New System.Drawing.Size(438, 205)
        Me.Lvw_Clientes.TabIndex = 0
        Me.Lvw_Clientes.UseCompatibleStateImageBehavior = False
        '
        'Frm_ManutencaoClienteDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 385)
        Me.Controls.Add(Me.Grp_Lista)
        Me.Controls.Add(Me.Txt_Nome)
        Me.Controls.Add(Me.Lbl_Nome)
        Me.Controls.Add(Me.Txt_Profissao)
        Me.Controls.Add(Me.Lbl_Profissao)
        Me.Controls.Add(Me.Txt_Cpf)
        Me.Controls.Add(Me.Lbl_Cpf)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Frm_ManutencaoClienteDB"
        Me.Text = "Frm_ManutencaoClienteDB"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Grp_Lista.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolSaveButton As ToolStripButton
    Friend WithEvents Lbl_Cpf As Label
    Friend WithEvents Txt_Cpf As TextBox
    Friend WithEvents Txt_Profissao As TextBox
    Friend WithEvents Lbl_Profissao As Label
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Grp_Lista As GroupBox
    Friend WithEvents Lvw_Clientes As ListView
End Class
