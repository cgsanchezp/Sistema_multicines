<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectarmeAlSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosEnDescomposicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaDeVencimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FallasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaDelProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDelProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProovedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarMiContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaYSoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaDinamicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtValorBuscado = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblBusq = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtNombre = New System.Windows.Forms.RadioButton()
        Me.rbtCodigo = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.MiCuentaToolStripMenuItem, Me.AyudaYSoporteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectarmeAlSistemaToolStripMenuItem, Me.AgregarProductoToolStripMenuItem, Me.GenerarReporteToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        Me.ArchivoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ConnectarmeAlSistemaToolStripMenuItem
        '
        Me.ConnectarmeAlSistemaToolStripMenuItem.Name = "ConnectarmeAlSistemaToolStripMenuItem"
        Me.ConnectarmeAlSistemaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ConnectarmeAlSistemaToolStripMenuItem.Text = "Connectarme al sistema"
        '
        'AgregarProductoToolStripMenuItem
        '
        Me.AgregarProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProductoToolStripMenuItem1, Me.ModificarRegistroToolStripMenuItem, Me.EliminarRegistroToolStripMenuItem})
        Me.AgregarProductoToolStripMenuItem.Name = "AgregarProductoToolStripMenuItem"
        Me.AgregarProductoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AgregarProductoToolStripMenuItem.Text = "Almacen de productos"
        '
        'AgregarProductoToolStripMenuItem1
        '
        Me.AgregarProductoToolStripMenuItem1.Name = "AgregarProductoToolStripMenuItem1"
        Me.AgregarProductoToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.AgregarProductoToolStripMenuItem1.Text = "Agregar al registro"
        '
        'ModificarRegistroToolStripMenuItem
        '
        Me.ModificarRegistroToolStripMenuItem.Name = "ModificarRegistroToolStripMenuItem"
        Me.ModificarRegistroToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ModificarRegistroToolStripMenuItem.Text = "Modificar/Eliminar  Registro"
        '
        'EliminarRegistroToolStripMenuItem
        '
        Me.EliminarRegistroToolStripMenuItem.Name = "EliminarRegistroToolStripMenuItem"
        Me.EliminarRegistroToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.EliminarRegistroToolStripMenuItem.Text = "Busqueda Rapida"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosEnDescomposicionToolStripMenuItem, Me.FechaDeVencimientoToolStripMenuItem, Me.FallasToolStripMenuItem})
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar Reporte"
        '
        'ProductosEnDescomposicionToolStripMenuItem
        '
        Me.ProductosEnDescomposicionToolStripMenuItem.Name = "ProductosEnDescomposicionToolStripMenuItem"
        Me.ProductosEnDescomposicionToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ProductosEnDescomposicionToolStripMenuItem.Text = "Productos en descomposicion"
        '
        'FechaDeVencimientoToolStripMenuItem
        '
        Me.FechaDeVencimientoToolStripMenuItem.Name = "FechaDeVencimientoToolStripMenuItem"
        Me.FechaDeVencimientoToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.FechaDeVencimientoToolStripMenuItem.Text = "Fecha de vencimiento"
        '
        'FallasToolStripMenuItem
        '
        Me.FallasToolStripMenuItem.Name = "FallasToolStripMenuItem"
        Me.FallasToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.FallasToolStripMenuItem.Text = "Fallas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreDeProductoToolStripMenuItem, Me.PesoToolStripMenuItem, Me.FechaDelProductoToolStripMenuItem, Me.StockDelProductoToolStripMenuItem, Me.ProovedoresToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'NombreDeProductoToolStripMenuItem
        '
        Me.NombreDeProductoToolStripMenuItem.Name = "NombreDeProductoToolStripMenuItem"
        Me.NombreDeProductoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NombreDeProductoToolStripMenuItem.Text = "Nombre de producto"
        '
        'PesoToolStripMenuItem
        '
        Me.PesoToolStripMenuItem.Name = "PesoToolStripMenuItem"
        Me.PesoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PesoToolStripMenuItem.Text = "Peso del producto"
        '
        'FechaDelProductoToolStripMenuItem
        '
        Me.FechaDelProductoToolStripMenuItem.Name = "FechaDelProductoToolStripMenuItem"
        Me.FechaDelProductoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.FechaDelProductoToolStripMenuItem.Text = "Fecha del producto"
        '
        'StockDelProductoToolStripMenuItem
        '
        Me.StockDelProductoToolStripMenuItem.Name = "StockDelProductoToolStripMenuItem"
        Me.StockDelProductoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.StockDelProductoToolStripMenuItem.Text = "stock del producto"
        '
        'ProovedoresToolStripMenuItem
        '
        Me.ProovedoresToolStripMenuItem.Name = "ProovedoresToolStripMenuItem"
        Me.ProovedoresToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ProovedoresToolStripMenuItem.Text = "Proovedores"
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarMiContraseñaToolStripMenuItem, Me.MisDatosToolStripMenuItem})
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.MiCuentaToolStripMenuItem.Text = "Mi cuenta"
        '
        'CambiarMiContraseñaToolStripMenuItem
        '
        Me.CambiarMiContraseñaToolStripMenuItem.Name = "CambiarMiContraseñaToolStripMenuItem"
        Me.CambiarMiContraseñaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CambiarMiContraseñaToolStripMenuItem.Text = "Cambiar mi cuenta"
        '
        'MisDatosToolStripMenuItem
        '
        Me.MisDatosToolStripMenuItem.Name = "MisDatosToolStripMenuItem"
        Me.MisDatosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.MisDatosToolStripMenuItem.Text = "Cambiar mi contraseña"
        '
        'AyudaYSoporteToolStripMenuItem
        '
        Me.AyudaYSoporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.AyudaDinamicaToolStripMenuItem})
        Me.AyudaYSoporteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AyudaYSoporteToolStripMenuItem.Name = "AyudaYSoporteToolStripMenuItem"
        Me.AyudaYSoporteToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AyudaYSoporteToolStripMenuItem.Text = "Ayuda y soporte"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'AyudaDinamicaToolStripMenuItem
        '
        Me.AyudaDinamicaToolStripMenuItem.Name = "AyudaDinamicaToolStripMenuItem"
        Me.AyudaDinamicaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AyudaDinamicaToolStripMenuItem.Text = "Ayuda dinamica"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(340, 386)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtValorBuscado
        '
        Me.txtValorBuscado.Location = New System.Drawing.Point(164, 91)
        Me.txtValorBuscado.Name = "txtValorBuscado"
        Me.txtValorBuscado.Size = New System.Drawing.Size(220, 20)
        Me.txtValorBuscado.TabIndex = 22
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(178, 386)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblBusq
        '
        Me.lblBusq.AutoSize = True
        Me.lblBusq.Location = New System.Drawing.Point(161, 73)
        Me.lblBusq.Name = "lblBusq"
        Me.lblBusq.Size = New System.Drawing.Size(46, 13)
        Me.lblBusq.TabIndex = 23
        Me.lblBusq.Text = "Buscar :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtNombre)
        Me.GroupBox1.Controls.Add(Me.rbtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 74)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda Rapida"
        '
        'rbtNombre
        '
        Me.rbtNombre.AutoSize = True
        Me.rbtNombre.Checked = True
        Me.rbtNombre.Location = New System.Drawing.Point(18, 23)
        Me.rbtNombre.Name = "rbtNombre"
        Me.rbtNombre.Size = New System.Drawing.Size(79, 17)
        Me.rbtNombre.TabIndex = 1
        Me.rbtNombre.TabStop = True
        Me.rbtNombre.Text = "Por nombre"
        Me.rbtNombre.UseVisualStyleBackColor = True
        '
        'rbtCodigo
        '
        Me.rbtCodigo.AutoSize = True
        Me.rbtCodigo.Location = New System.Drawing.Point(18, 45)
        Me.rbtCodigo.Name = "rbtCodigo"
        Me.rbtCodigo.Size = New System.Drawing.Size(76, 17)
        Me.rbtCodigo.TabIndex = 1
        Me.rbtCodigo.TabStop = True
        Me.rbtCodigo.Text = "Por codigo"
        Me.rbtCodigo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 224)
        Me.DataGridView1.TabIndex = 20
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(390, 89)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(259, 386)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 27
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'FrmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(628, 550)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtValorBuscado)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblBusq)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmAlmacen"
        Me.Text = "FrmAlmacen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaYSoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosEnDescomposicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaDeVencimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaDinamicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FallasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaDelProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarMiContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MisDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDelProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProovedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectarmeAlSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtValorBuscado As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblBusq As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
