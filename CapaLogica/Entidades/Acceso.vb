Imports System.Data.SqlClient
Public Class Acceso
    Private cn As CapaDatos.DBAcceso
    Public Function listacceso()
        Dim cn As New CapaDatos.DBAcceso
        Dim da As New SqlDataAdapter("Select Cod_Personal,cod_tipo_cargo,usuario from Acceso", cn.connect)
        Dim ds As New DataSet
        da.Fill(ds, "dtAcceso")
        'cn.desconect()
        Return ds

    End Function
End Class
