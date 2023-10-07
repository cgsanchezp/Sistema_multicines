Public Class wfAcceso
    Inherits System.Web.UI.Page
    Dim login As New CapaLogica.login
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim user As String = txtusername.Value
        Dim pass As String = txtpassword.Value
        Dim acceso As Boolean = login.acceso(user, pass)
        If login.acceso(user, pass) Then
            Dim tkt As FormsAuthenticationTicket = New FormsAuthenticationTicket(1, user, DateTime.Now, DateTime.Now.AddMinutes(30), chkPersistCookie.Checked, "your custom data")
            Dim cookiestr As String = FormsAuthentication.Encrypt(tkt)
            Dim cookie As HttpCookie = New HttpCookie(FormsAuthentication.FormsCookieName)
            cookie.Value = cookiestr
            cookie.Expires = tkt.Expiration

            Response.Cookies.Add(cookie)

            Dim returnUrl As String = Request.QueryString("principal.Master")
            If returnUrl Is Nothing OrElse returnUrl = "" Then
                returnUrl = "principal.Master"
            End If
            Response.Redirect(returnUrl)
        End If

        MsgBox("Acceso al sistema: " + Convert.ToString(acceso))
    End Sub
End Class