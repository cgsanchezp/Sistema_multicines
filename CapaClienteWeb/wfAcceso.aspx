<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfAcceso.aspx.vb" Inherits="CapaClienteWeb.wfAcceso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>login</title>
    <link rel="stylesheet" href="content/css/bootstrap.min.css" />
    <link rel="stylesheet" href="content/css/login.css" />
</head>
<body>
    <div class="sidenav">
      <div class="login-main-text">
         <h2>Application<br\>Login Page</h2>
         <p>Login or register from here to access.</p>
      </div>
   </div>
   <div class="main">
      <div class="col-md-6 col-sm-12">
         <div class="login-form">
            <form action="wfAcceso.aspx" runat="server">
               <div class="form-group">
                  <label>Usuario</label>
                  <input id="txtusername" type="text" class="form-control" placeholder="" runat="server" required>
               </div>
               <div class="form-group">
                  <label>Password</label>
                  <input id="txtpassword" class="form-control" placeholder="" runat="server" required>
               </div>
            <tr>
                <td>Persistent Cookie:</td>
                <td><ASP:CheckBox id="chkPersistCookie" runat="server" autopostback="false" /></td>
                <td></td>
            </tr>
                <asp:Button id="cmdLogin" class="btn btn-black" runat="server" Text="Login" />
            </form>
         </div>
      </div>
   </div>
    <script src="content/js/bootstrap.bundle.min.js"></script>
</body>
</html>
