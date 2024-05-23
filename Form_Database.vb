Imports System.Data.Odbc
Public Class Form_Database
    Public Connection As OdbcConnection
    Public Cmd As OdbcCommand
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As New DataSet
    Public Str As String
    Public Sql As String


    Public Sub OpenConnection()
        Str = "Driver={MySQL ODBC 3.51 Driver};database=dbtoko;server=localhost;uid=root"
        Connection = New OdbcConnection(Str)
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If
    End Sub
End Class