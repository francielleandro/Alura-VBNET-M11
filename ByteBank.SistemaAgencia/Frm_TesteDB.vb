Imports ByteBank.Bibliotecas.Classes.BancoDeDados
Public Class Frm_TesteDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DtGrid_Resultado.Columns.Clear()
        DtGrid_Resultado.DataSource = Nothing
        Try
            Dim Dt As New DataTable
            Dim DB As New SQLServerConn("DESKTOP-RGPMAAC", "BYTEBANK")
            Dim Retorno As String = DB.SQLQuery("SELECT [CPF],[NOME],[PROFISSAO] FROM [BYTEBANK].[dbo].[CLIENTE]", Dt)
            DtGrid_Resultado.DataSource = Dt
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CPF = "408223223"
        Dim Nome = "Franciel"
        Dim Profissao = "Engenheiro"
        Dim comando As String = $"INSERT INTO CLIENTE VALUES('{CPF}','{Nome}','{Profissao}');"
        Dim query As String = $"SELECT [CPF],[NOME],[PROFISSAO] FROM [BYTEBANK].[dbo].[CLIENTE] WHERE CPF = '{CPF}'"
        Dim Dt As New DataTable

        Try
            Dim DB As New SQLServerConn("DESKTOP-RGPMAAC", "BYTEBANK")
            Dim Retorno As String = DB.SQLQuery(query, Dt)

            If Dt.Rows.Count > 0 Then
                MsgBox("Cliente já cadastrado")
            Else
                DB.SQLCommand(comando)
                MsgBox("Cliente incluido com sucesso")
            End If
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CPF = "408223223"
        Dim comando As String = $"DELETE FROM CLIENTE WHERE CPF = '{CPF}';"
        Try
            Dim DB As New SQLServerConn("DESKTOP-RGPMAAC", "BYTEBANK")
            DB.SQLCommand(comando)
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class