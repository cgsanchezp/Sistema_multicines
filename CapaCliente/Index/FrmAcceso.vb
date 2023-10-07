Public Class FrmAcceso

    Dim login As New CapaLogica.login
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        validacion_usuario()
    End Sub

    Sub validacion_usuario()
        Dim usuario = txtUsuario.Text
        Dim contrasenia = txtContrasenia.Text
        Dim acceso As Boolean = login.acceso(usuario, contrasenia)
        MsgBox(acceso)
    End Sub

End Class