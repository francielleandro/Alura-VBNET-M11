Imports System.Data.SqlClient
Public Class SQLServerConn
#Region "Propertys"
    Public Property StringConn As String
    Public Property connDB As SqlConnection
#End Region
#Region "Constructor"
    Public Sub New(Servidor As String, Banco As String)
        ' StringConn = "Persist Security Info=False;Integrated Security=True;Initial Catalog=Northwind;server=(local)"
        'StringConn = "Data Source=DESKTOP-RGPMAAC;Initial Catalog=BYTEBANK;Integrated Security=True"
        StringConn = "Data Source=" + Servidor + ";Initial Catalog=" + Banco + ";Integrated Security=True"
        connDB = New SqlConnection(StringConn)
        connDB.Open()
    End Sub
#End Region
#Region "Methods"

    Public Sub Close()
        connDB.Close()
    End Sub

    Public Function SQLQuery(SQL As String, ByRef DT As DataTable) As String
        Try
            Dim myCommand As IDbCommand = New SqlCommand(SQL, connDB)
            myCommand.CommandTimeout = 0
            Dim myReader As IDataReader = myCommand.ExecuteReader()
            DT.Load(myReader)
            Return ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SQLCommand(SQL As String) As String
        Try
            Dim myCommand As IDbCommand = New SqlCommand(SQL, connDB)
            myCommand.CommandTimeout = 0
            myCommand.ExecuteReader()
            Return ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


#End Region
End Class
