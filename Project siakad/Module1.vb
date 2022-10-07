Imports MySql.Data.MySqlClient
Module Module1
    Public connct As MySqlConnection
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public dr As MySqlDataReader
    Public str As String
    Public data As Integer
    Public i As Integer
    Sub koneksi()

        str = "server=localhost;userid=root;password=;database=siakad;convert zero datetime=true"
        connct = New MySqlConnection(str)
        If connct.State = ConnectionState.Closed Then
            connct.Open()
        End If
    End Sub
End Module
