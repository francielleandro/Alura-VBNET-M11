<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal01))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesAgenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesAgenciaDicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManutençãoListViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManutençãoCCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClienteSQLServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManutençãoDeClientesDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.ManutençãoCCToolStripMenuItem, Me.CadastroDBToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasCorrentesArrayToolStripMenuItem, Me.ContasCorrentesListasToolStripMenuItem, Me.ContasCorrentesAgenciaToolStripMenuItem, Me.ContasCorrentesAgenciaDicToolStripMenuItem, Me.SimulaçãoToolStripMenuItem, Me.ManutençãoListViewToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'ContasCorrentesArrayToolStripMenuItem
        '
        Me.ContasCorrentesArrayToolStripMenuItem.Name = "ContasCorrentesArrayToolStripMenuItem"
        Me.ContasCorrentesArrayToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesArrayToolStripMenuItem.Text = "Contas Correntes Array"
        '
        'ContasCorrentesListasToolStripMenuItem
        '
        Me.ContasCorrentesListasToolStripMenuItem.Name = "ContasCorrentesListasToolStripMenuItem"
        Me.ContasCorrentesListasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesListasToolStripMenuItem.Text = "Contas Correntes Listas"
        '
        'ContasCorrentesAgenciaToolStripMenuItem
        '
        Me.ContasCorrentesAgenciaToolStripMenuItem.Name = "ContasCorrentesAgenciaToolStripMenuItem"
        Me.ContasCorrentesAgenciaToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesAgenciaToolStripMenuItem.Text = "Contas Correntes Agencia"
        '
        'ContasCorrentesAgenciaDicToolStripMenuItem
        '
        Me.ContasCorrentesAgenciaDicToolStripMenuItem.Name = "ContasCorrentesAgenciaDicToolStripMenuItem"
        Me.ContasCorrentesAgenciaDicToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesAgenciaDicToolStripMenuItem.Text = "Contas Correntes Agencia Dic"
        '
        'SimulaçãoToolStripMenuItem
        '
        Me.SimulaçãoToolStripMenuItem.Name = "SimulaçãoToolStripMenuItem"
        Me.SimulaçãoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SimulaçãoToolStripMenuItem.Text = "Simulação"
        '
        'ManutençãoListViewToolStripMenuItem
        '
        Me.ManutençãoListViewToolStripMenuItem.Name = "ManutençãoListViewToolStripMenuItem"
        Me.ManutençãoListViewToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ManutençãoListViewToolStripMenuItem.Text = "Manutenção ListView"
        '
        'ManutençãoCCToolStripMenuItem
        '
        Me.ManutençãoCCToolStripMenuItem.Name = "ManutençãoCCToolStripMenuItem"
        Me.ManutençãoCCToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.ManutençãoCCToolStripMenuItem.Text = "Manutenção CC"
        '
        'CadastroDBToolStripMenuItem
        '
        Me.CadastroDBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClienteToolStripMenuItem, Me.CadastroDeClienteSQLServerToolStripMenuItem, Me.ManutençãoDeClientesDBToolStripMenuItem})
        Me.CadastroDBToolStripMenuItem.Name = "CadastroDBToolStripMenuItem"
        Me.CadastroDBToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CadastroDBToolStripMenuItem.Text = "Cadastro DB"
        '
        'CadastroDeClienteToolStripMenuItem
        '
        Me.CadastroDeClienteToolStripMenuItem.Name = "CadastroDeClienteToolStripMenuItem"
        Me.CadastroDeClienteToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente"
        '
        'CadastroDeClienteSQLServerToolStripMenuItem
        '
        Me.CadastroDeClienteSQLServerToolStripMenuItem.Name = "CadastroDeClienteSQLServerToolStripMenuItem"
        Me.CadastroDeClienteSQLServerToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CadastroDeClienteSQLServerToolStripMenuItem.Text = "Cadastro de Cliente SQL Server"
        '
        'ManutençãoDeClientesDBToolStripMenuItem
        '
        Me.ManutençãoDeClientesDBToolStripMenuItem.Name = "ManutençãoDeClientesDBToolStripMenuItem"
        Me.ManutençãoDeClientesDBToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ManutençãoDeClientesDBToolStripMenuItem.Text = "Manutenção de Clientes DB"
        '
        'Frm_Principal01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal01"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesAgenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesAgenciaDicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManutençãoListViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManutençãoCCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeClienteSQLServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManutençãoDeClientesDBToolStripMenuItem As ToolStripMenuItem
End Class
