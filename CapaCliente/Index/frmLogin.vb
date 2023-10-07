Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim login As New CapaLogica.login
        ' Dim ds As DataSet = login.acceso(txtusuario.Text, txtPassword.Text)
        Dim ds As DataSet
        Dim rows As Integer = ds.Tables("dtAcceso").Rows.Count

        usuario = ds.Tables("dtAcceso").Rows(0).Item(1).ToString

        If cod_cargo = "CG005" Then
            FrmAdm.Show()
        End If

        If cod_cargo = "CG006" Then
            FrmBol.Show()
        End If

        If cod_cargo = "CG008" Then
            frmCaj.Show()
        End If

        If cod_cargo = "CG002" Then
            FrmVend.Show()
        End If

        If cod_cargo = "CG004" Then
            FrmSeg.Show()
        End If

        If cod_cargo = "CG001" Then
            FrmTec.Show()
        End If

        If cod_cargo = "CG009" Then
            FrmAlmacen.Show()
        End If

        Me.Hide()
        ' Else
        'MessageBox.Show("Le quedan " & CStr(3 - n) & " Intentos ", "Error de Usuario o Clave!!!")
        txtusuario.Text = ""
        txtPassword.Text = ""
        txtusuario.Focus()


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboCargo.Items.Add("Administrador")
        CboCargo.Items.Add("Boletero")
        CboCargo.Items.Add("Cajero")
        CboCargo.Items.Add("Vendedor")
        CboCargo.Items.Add("Seguridad")
        CboCargo.Items.Add("Tec.Mantenimiento")
        CboCargo.Items.Add("Almacen")

    End Sub

    Private Sub CboCargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCargo.SelectedIndexChanged
        Dim a As Integer = CboCargo.SelectedIndex
        Select Case a
            Case 0 : cod_cargo = "CG005"
            Case 1 : cod_cargo = "CG006"
            Case 2 : cod_cargo = "CG008"
            Case 3 : cod_cargo = "CG002"
            Case 4 : cod_cargo = "CG004"
            Case 5 : cod_cargo = "CG001"
            Case 6 : cod_cargo = "CG009"
        End Select

    End Sub
End Class