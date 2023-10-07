Imports System.Data.SqlClient
Public Class DBAcceso
    Public cn As SqlConnection
    Public Function connect() As SqlConnection
        cn = New SqlConnection
        cn.ConnectionString = "Data Source=DESKTOP-BNHKP7P;Initial Catalog=IndieDB;Integrated Security=True"
        cn.Open()
        Return cn
    End Function
    Public Sub desconect()
        cn.Close()
    End Sub

End Class
