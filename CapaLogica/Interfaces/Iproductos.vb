Imports System.Data.SqlClient
Public Interface Iproductos
    'funcion agregar producto'
    Function agregar(ByVal obj As InfoProductos) As String
    'funcion editar producto'
    Function editar(ByVal obj As InfoProductos) As Boolean
    'funcion eliminar producto'
    Function eliminar(ByVal obj As InfoProductos) As Boolean
    'funcion para mostrar los productos de manera general'
    Function listadoGeneral() As DataTable
    'funcion para buscar un producto especifico'
    Function listaAvanzada(ByVal texto As String, ByVal opcion As Short) As DataTable

End Interface
