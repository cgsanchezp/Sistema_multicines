<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectarmeAlSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosEnDescomposicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.NombreDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FechaDelProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProovedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.MisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaDinamicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ControlDePeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ControlDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LasMasTaquillerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HorariosYSueldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.txtValorBuscado = New System.Windows.Forms.TextBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.lblBusq = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtNombre = New System.Windows.Forms.RadioButton
        Me.rbtCodigo = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ControlDeSedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevasSedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(785, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.UseWaitCursor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(785, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectarmeAlSistemaToolStripMenuItem, Me.AgregarProductoToolStripMenuItem, Me.ControlDeVentasToolStripMenuItem, Me.ControlDeSedesToolStripMenuItem, Me.ControlDePeliculasToolStripMenuItem, Me.GenerarReporteToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem1.Text = "Archivo"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ConnectarmeAlSistemaToolStripMenuItem
        '
        Me.ConnectarmeAlSistemaToolStripMenuItem.Name = "ConnectarmeAlSistemaToolStripMenuItem"
        Me.ConnectarmeAlSistemaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ConnectarmeAlSistemaToolStripMenuItem.Text = "Connectarme al sistema"
        '
        'AgregarProductoToolStripMenuItem
        '
        Me.AgregarProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProductoToolStripMenuItem1, Me.ModificarRegistroToolStripMenuItem, Me.EliminarRegistroToolStripMenuItem, Me.HorariosYSueldosToolStripMenuItem})
        Me.AgregarProductoToolStripMenuItem.Name = "AgregarProductoToolStripMenuItem"
        Me.AgregarProductoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AgregarProductoToolStripMenuItem.Text = "Control de personal"
        '
        'AgregarProductoToolStripMenuItem1
        '
        Me.AgregarProductoToolStripMenuItem1.Name = "AgregarProductoToolStripMenuItem1"
        Me.AgregarProductoToolStripMenuItem1.Size = New System.Drawing.Size(257, 22)
        Me.AgregarProductoToolStripMenuItem1.Text = "Agregar personal"
        '
        'ModificarRegistroToolStripMenuItem
        '
        Me.ModificarRegistroToolStripMenuItem.Name = "ModificarRegistroToolStripMenuItem"
        Me.ModificarRegistroToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ModificarRegistroToolStripMenuItem.Text = "Modificar/Eliminar datos de personal"
        '
        'EliminarRegistroToolStripMenuItem
        '
        Me.EliminarRegistroToolStripMenuItem.Name = "EliminarRegistroToolStripMenuItem"
        Me.EliminarRegistroToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.EliminarRegistroToolStripMenuItem.Text = "Busqueda Rapida"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosEnDescomposicionToolStripMenuItem})
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.GenerarReporteToolStripMenuItem.Text = "Control de clientes"
        '
        'ProductosEnDescomposicionToolStripMenuItem
        '
        Me.ProductosEnDescomposicionToolStripMenuItem.Name = "ProductosEnDescomposicionToolStripMenuItem"
        Me.ProductosEnDescomposicionToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ProductosEnDescomposicionToolStripMenuItem.Text = "Promociones"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreDeProductoToolStripMenuItem, Me.FechaDelProductoToolStripMenuItem, Me.ProovedoresToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem2.Text = "Consultas"
        '
        'NombreDeProductoToolStripMenuItem
        '
        Me.NombreDeProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.NombreDeProductoToolStripMenuItem.Name = "NombreDeProductoToolStripMenuItem"
        Me.NombreDeProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NombreDeProductoToolStripMenuItem.Text = "Nombre de "
        '
        'FechaDelProductoToolStripMenuItem
        '
        Me.FechaDelProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LasMasTaquillerasToolStripMenuItem})
        Me.FechaDelProductoToolStripMenuItem.Name = "FechaDelProductoToolStripMenuItem"
        Me.FechaDelProductoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FechaDelProductoToolStripMenuItem.Text = "peliculas"
        '
        'ProovedoresToolStripMenuItem
        '
        Me.ProovedoresToolStripMenuItem.Name = "ProovedoresToolStripMenuItem"
        Me.ProovedoresToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ProovedoresToolStripMenuItem.Text = "Proovedores"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MisDatosToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripMenuItem3.Text = "Mi cuenta"
        '
        'MisDatosToolStripMenuItem
        '
        Me.MisDatosToolStripMenuItem.Name = "MisDatosToolStripMenuItem"
        Me.MisDatosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MisDatosToolStripMenuItem.Text = "Cambiar mi contraseña"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.AyudaDinamicaToolStripMenuItem})
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(99, 20)
        Me.ToolStripMenuItem4.Text = "Ayuda y soporte"
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
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonalToolStripMenuItem.Text = "personal"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "clientes"
        '
        'ControlDePeliculasToolStripMenuItem
        '
        Me.ControlDePeliculasToolStripMenuItem.Name = "ControlDePeliculasToolStripMenuItem"
        Me.ControlDePeliculasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ControlDePeliculasToolStripMenuItem.Text = "Control de peliculas"
        '
        'ControlDeVentasToolStripMenuItem
        '
        Me.ControlDeVentasToolStripMenuItem.Name = "ControlDeVentasToolStripMenuItem"
        Me.ControlDeVentasToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ControlDeVentasToolStripMenuItem.Text = "Control de ventas"
        '
        'LasMasTaquillerasToolStripMenuItem
        '
        Me.LasMasTaquillerasToolStripMenuItem.Name = "LasMasTaquillerasToolStripMenuItem"
        Me.LasMasTaquillerasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LasMasTaquillerasToolStripMenuItem.Text = "Las mas taquilleras"
        '
        'HorariosYSueldosToolStripMenuItem
        '
        Me.HorariosYSueldosToolStripMenuItem.Name = "HorariosYSueldosToolStripMenuItem"
        Me.HorariosYSueldosToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.HorariosYSueldosToolStripMenuItem.Text = "Horarios y sueldos"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(264, 400)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 35
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(395, 103)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(345, 400)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtValorBuscado
        '
        Me.txtValorBuscado.Location = New System.Drawing.Point(169, 105)
        Me.txtValorBuscado.Name = "txtValorBuscado"
        Me.txtValorBuscado.Size = New System.Drawing.Size(220, 20)
        Me.txtValorBuscado.TabIndex = 30
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(183, 400)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 32
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblBusq
        '
        Me.lblBusq.AutoSize = True
        Me.lblBusq.Location = New System.Drawing.Point(166, 87)
        Me.lblBusq.Name = "lblBusq"
        Me.lblBusq.Size = New System.Drawing.Size(46, 13)
        Me.lblBusq.TabIndex = 31
        Me.lblBusq.Text = "Buscar :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtNombre)
        Me.GroupBox1.Controls.Add(Me.rbtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 74)
        Me.GroupBox1.TabIndex = 29
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
        Me.DataGridView1.Location = New System.Drawing.Point(22, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 224)
        Me.DataGridView1.TabIndex = 28
        '
        'ControlDeSedesToolStripMenuItem
        '
        Me.ControlDeSedesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevasSedesToolStripMenuItem})
        Me.ControlDeSedesToolStripMenuItem.Name = "ControlDeSedesToolStripMenuItem"
        Me.ControlDeSedesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ControlDeSedesToolStripMenuItem.Text = "Control de sedes"
        '
        'NuevasSedesToolStripMenuItem
        '
        Me.NuevasSedesToolStripMenuItem.Name = "NuevasSedesToolStripMenuItem"
        Me.NuevasSedesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevasSedesToolStripMenuItem.Text = "Nuevas sedes"
        '
        'FrmAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 621)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtValorBuscado)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblBusq)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmAdm"
        Me.Text = "Multicines--Administracion"
        Me.TopMost = True
        Me.UseWaitCursor = True
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectarmeAlSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosEnDescomposicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaDelProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProovedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MisDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaDinamicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosYSueldosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDePeliculasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LasMasTaquillerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtValorBuscado As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblBusq As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ControlDeSedesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevasSedesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
