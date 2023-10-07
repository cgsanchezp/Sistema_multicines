Public Class FrmAlmacen

    Dim opcion As Short
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AgregarProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProductoToolStripMenuItem1.Click

        FrmAgregarProducto.Show()

    End Sub

 

    Private Sub FrmAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim productos As New CapaLogica.InfoProductos
        DataGridView1.DataSource = productos.listadoGeneral
      
    
    End Sub



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim opcion As Short, productos As New CapaLogica.InfoProductos
        If rbtCodigo.Checked Then
            opcion = 0
        Else
            opcion = 1
        End If
        DataGridView1.DataSource = productos.listaAvanzada(txtValorBuscado.Text, opcion)
    End Sub

    Private Sub txtValorBuscado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorBuscado.TextChanged
        Dim productos As New CapaLogica.InfoProductos
        If rbtCodigo.Checked Then
            opcion = 0
        Else
            opcion = 1
        End If
        DataGridView1.DataSource = productos.listaAvanzada(txtValorBuscado.Text, opcion)
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim productos As New CapaLogica.InfoProductos
        DataGridView1.DataSource = productos.listadoGeneral
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    


    End Sub
End Class