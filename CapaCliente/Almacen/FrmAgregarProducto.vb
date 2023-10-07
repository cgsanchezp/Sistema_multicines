Public Class FrmAgregarProducto

    Private Sub FrmAgregarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim productos As New CapaLogica.InfoProductos


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim productos As New CapaLogica.InfoProductos
        productos.codigo = txtCodProd.Text
        productos.nombre = txtNombre.Text
        productos.fecha_emision = txtFecha_emision.Text
        productos.fecha_vencimiento = txtFecha_venc.Text
        productos.tipo_producto = txtTipProd.Text
        productos.precio_costo = txtPrecioCosto.Text
        productos.precio_venta = txtPrecioVenta.Text
        productos.proovedor = txtProovedor.Text
        productos.descripcion = txtDescProd.Text
        productos.codInversion = txtCodInv.Text
        productos.peso = txtPeso.Text

        If productos.agregar(productos) = True Then

            'DataGridView1.DataSource = productos.listadoGeneral


        Else
            'Label3.Text = "error"
        End If


    End Sub
End Class