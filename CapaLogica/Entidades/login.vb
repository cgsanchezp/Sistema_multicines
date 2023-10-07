Imports System.Data.SqlClient
Public Class login
    Public Function acceso(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim cn As New CapaDatos.DBAcceso
        Dim cmd As New SqlCommand
        cmd.CommandText = "select * from Acceso where usuario=@usuario and clave=@clave"
        cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = usuario
        cmd.Parameters.Add("@clave", SqlDbType.Char, 5).Value = clave
        cmd.CommandType = CommandType.Text
        cmd.Connection = cn.connect

        Try
            cmd.ExecuteNonQuery()
            Dim sqlDA As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sqlDA.Fill(dt)
            Dim cregistros As Integer = dt.Rows.Count
            If cregistros >= 1 Then
                Return True
            End If
            cn.desconect()
            Return False
        Catch ex As Exception
            Console.WriteLine("Ocurrió un error: " & ex.Message)
        End Try

    End Function
End Class
