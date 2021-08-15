Public Class Frm_Cliente_SQLServer
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Cadastro de Clientes por SQLServer"
    End Sub

    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BYTEBANKDataSet)

    End Sub

    Private Sub Frm_Cliente_SQLServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BYTEBANKDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTETableAdapter.Fill(Me.BYTEBANKDataSet.CLIENTE)

    End Sub
End Class