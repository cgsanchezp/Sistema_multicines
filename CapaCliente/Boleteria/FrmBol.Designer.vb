<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBol
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BoleteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarBoletoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClienteNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClienteRegistradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarClienteRegistradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarMiContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevolucionDeDineroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoleteriaToolStripMenuItem, Me.RegistrarClienteToolStripMenuItem, Me.MiCuentaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BoleteriaToolStripMenuItem
        '
        Me.BoleteriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarBoletoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.BoleteriaToolStripMenuItem.Name = "BoleteriaToolStripMenuItem"
        Me.BoleteriaToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.BoleteriaToolStripMenuItem.Text = "Gestion de boletos"
        '
        'GenerarBoletoToolStripMenuItem
        '
        Me.GenerarBoletoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteNuevoToolStripMenuItem, Me.ClienteRegistradoToolStripMenuItem})
        Me.GenerarBoletoToolStripMenuItem.Name = "GenerarBoletoToolStripMenuItem"
        Me.GenerarBoletoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GenerarBoletoToolStripMenuItem.Text = "Generar boleto"
        '
        'ClienteNuevoToolStripMenuItem
        '
        Me.ClienteNuevoToolStripMenuItem.Name = "ClienteNuevoToolStripMenuItem"
        Me.ClienteNuevoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClienteNuevoToolStripMenuItem.Text = "Cliente nuevo"
        '
        'ClienteRegistradoToolStripMenuItem
        '
        Me.ClienteRegistradoToolStripMenuItem.Name = "ClienteRegistradoToolStripMenuItem"
        Me.ClienteRegistradoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClienteRegistradoToolStripMenuItem.Text = "Cliente Registrado"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.ModificarClienteRegistradoToolStripMenuItem})
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.RegistrarClienteToolStripMenuItem.Text = " Cliente"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        '
        'ModificarClienteRegistradoToolStripMenuItem
        '
        Me.ModificarClienteRegistradoToolStripMenuItem.Name = "ModificarClienteRegistradoToolStripMenuItem"
        Me.ModificarClienteRegistradoToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ModificarClienteRegistradoToolStripMenuItem.Text = "Modificar Cliente Registrado"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoporteToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AyudaToolStripMenuItem.Text = "ayuda"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SoporteToolStripMenuItem.Text = "ayuda soporte"
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarMiContraseñaToolStripMenuItem})
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MiCuentaToolStripMenuItem.Text = "Mi cuenta"
        '
        'CambiarMiContraseñaToolStripMenuItem
        '
        Me.CambiarMiContraseñaToolStripMenuItem.Name = "CambiarMiContraseñaToolStripMenuItem"
        Me.CambiarMiContraseñaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CambiarMiContraseñaToolStripMenuItem.Text = "Cambiar mi contraseña"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevolucionDeDineroToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'DevolucionDeDineroToolStripMenuItem
        '
        Me.DevolucionDeDineroToolStripMenuItem.Name = "DevolucionDeDineroToolStripMenuItem"
        Me.DevolucionDeDineroToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DevolucionDeDineroToolStripMenuItem.Text = "Devolucion de dinero"
        '
        'FrmBol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 474)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmBol"
        Me.Text = "Multicines.boleteria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BoleteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarBoletoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteRegistradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteRegistradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionDeDineroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarMiContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
