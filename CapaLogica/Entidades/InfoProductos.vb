Imports System.Data.SqlClient
Public Class InfoProductos
    Implements Iproductos

    Public _cod As String
    Public _nombre As String
    Public _fecha_emision As Date
    Public _fecha_vencimiento As Date
    Public _tipo_producto As String
    Public _precio_costo As String
    Public _precio_venta As String
    Public _igv As String
    Public _proovedor As String
    Public _descripcion As String
    Public _cod_inversion As String
    Public _Peso As String


    Public Property codigo() As String
        Get
            Return _cod
        End Get
        Set(ByVal value As String)
            _cod = value
        End Set
    End Property


    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property fecha_emision() As Date
        Get
            Return _fecha_emision
        End Get
        Set(ByVal value As Date)
            _fecha_emision = value
        End Set
    End Property
    Public Property fecha_vencimiento() As Date
        Get
            Return _fecha_vencimiento
        End Get
        Set(ByVal value As Date)
            _fecha_vencimiento = value
        End Set
    End Property

    Public Property tipo_producto() As String
        Get
            Return _tipo_producto
        End Get
        Set(ByVal value As String)
            _tipo_producto = value
        End Set
    End Property

    Public Property precio_costo() As String
        Get
            Return _precio_costo
        End Get
        Set(ByVal value As String)
            _precio_costo = value
        End Set
    End Property
    Public Property precio_venta() As String
        Get
            Return _precio_venta
        End Get
        Set(ByVal value As String)
            _precio_venta = value
        End Set
    End Property
    Public Property igv() As String
        Get
            Return _igv
        End Get
        Set(ByVal value As String)
            _igv = value
        End Set
    End Property

    Public Property proovedor() As String
        Get
            Return _proovedor
        End Get
        Set(ByVal value As String)
            _proovedor = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Public Property codInversion() As String
        Get
            Return _cod_inversion
        End Get
        Set(ByVal value As String)
            _cod_inversion = value
        End Set
    End Property
    Public Property peso() As String
        Get
            Return _Peso
        End Get
        Set(ByVal value As String)
            _Peso = value
        End Set
    End Property

    Public Function agregar(ByVal obj As InfoProductos) As String Implements Iproductos.agregar
        Dim cm As New SqlCommand
        Dim objcon As New CapaDatos.DBAcceso
        cm.CommandType = CommandType.Text
        cm.Connection = objcon.connect
        cm.CommandText = "Insert into producto_consumo values ('" & obj.codigo & "','" & obj.nombre & "','" & obj.fecha_emision & "','" & obj.fecha_vencimiento & "','" & obj.tipo_producto & "','" & obj.precio_costo & "','" & obj.precio_venta & "','" & obj.proovedor & "','" & obj.descripcion & "','" & obj.codInversion & "','" & obj.peso & "')"
        Dim filas_afectadas As Integer = cm.ExecuteNonQuery
        If filas_afectadas > 0 Then
            Return True
        Else
            Return False
        End If
        'objcon.desconect()
    End Function

    Public Function editar(ByVal obj As InfoProductos) As Boolean Implements Iproductos.editar

    End Function



    Public Function listaAvanzada(ByVal texto As String, ByVal opcion As Short) As System.Data.DataTable Implements Iproductos.listaAvanzada
        Dim cad1, cad2 As String
        If opcion = 0 Then
            'busqueda por codigo'
            cad2 = "where cod_Producto_Consumo='" & texto & "'"
        Else
            'busqueda por Nombre'
            cad2 = "where nombre like'%" & texto & "%'"
        End If

        cad1 = "select cod_Producto_Consumo,nombre,fecha_emision,fecha_vencimiento,precio_costo,precio_venta,tipo_producto,proovedor,igv,descripcion,cod_inversion,Peso from producto_consumo " + cad2
        Dim con As New CapaDatos.DBAcceso
        Dim da As New SqlDataAdapter(cad1, con.connect)
        Dim ds As New DataSet
        da.Fill(ds, "dt")
        Return ds.Tables(0)

    End Function

    Public Function listadoGeneral() As System.Data.DataTable Implements Iproductos.listadoGeneral
        Dim objcon As New CapaDatos.DBAcceso
        Dim cad = "select*from producto_consumo"
        Dim da As New SqlDataAdapter(cad, objcon.connect)
        Dim ds As New DataSet
        da.Fill(ds, "dtproductos")
        Return ds.Tables(0)
    End Function


    Public Sub eliminar(ByVal obj As InfoProductos)
        Dim cm As New SqlCommand
        Dim objcon As New CapaDatos.DBAcceso
        cm.CommandType = CommandType.Text
        cm.Connection = objcon.connect
        cm.CommandText = "DELETE FROM producto_consumo WHERE cod_Producto_Consumo"
        Dim filas_afectadas As Integer = cm.ExecuteNonQuery

        objcon.desconect()
    End Sub

    Public Function eliminar1(ByVal obj As InfoProductos) As Boolean Implements Iproductos.eliminar

    End Function
End Class
