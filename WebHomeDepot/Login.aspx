<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebHomeDepot.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<link href="Recursos/gridBT/bootstrap.min.css" rel="stylesheet" />
<script src="Recursos/gridBT/bootstrap.min.js"></script>
<script src="Recursos/gridBT/jquery-2.2.0.min.js"></script>
    <style>
body {
    font-family: "Lato", sans-serif;
}



.main-head{
    height: 150px;
    background: #FFF;
   
}

.sidenav {
    height: 100%;
    background-color: #000;
    overflow-x: hidden;
    padding-top: 20px;
}


.main {
    padding: 0px 10px;
}

@media screen and (max-height: 450px) {
    .sidenav {padding-top: 15px;}
}

@media screen and (max-width: 450px) {
    .login-form{
        margin-top: 10%;
    }

    .register-form{
        margin-top: 10%;
    }
}

@media screen and (min-width: 768px){
    .main{
        margin-left: 40%; 
    }

    .sidenav{
        width: 40%;
        position: fixed;
        z-index: 1;
        top: 0;
        left: 0;
    }

    .login-form{
        margin-top: 80%;
    }

    .register-form{
        margin-top: 20%;
    }
}


.login-main-text{
    margin-top: 20%;
    padding: 60px;
    color: #fff;
}

.login-main-text h2{
    font-weight: 300;
}

.btn-black{
    background-color: #000 !important;
    color: #fff;
}


    </style>
<body>
    <div class="row">
        <div class="col-4">
            <div class="sidenav">
                <div class="login-main-text">
                    <h2>Application<br>
                        Login Page</h2>
                    <p>Login or register from here to access.</p>
                </div>
            </div>
        </div>
        <div class="col-8">
            <div class="main align-middle">
                <div class="col-md-6 col-sm-12">
                    <div class="login-form">
                        <form id="form1" runat="server">
                            <div class="form-group">
                                <label>Usuario</label>
                                <%--<input type="text" class="form-control" placeholder="User Name">--%>
                                <asp:TextBox ID="txtUsuario" class="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Password</label>
                                <%--<input type="password" class="form-control" placeholder="Password">--%>
                                <asp:TextBox ID="txtPass" class="form-control" runat="server" TextMode="Password" OnTextChanged="txtPass_TextChanged"></asp:TextBox>
                            </div>
                            <%--<button type="submit" class="btn btn-black">Ingresar</button>--%>

                            <%--<button type="submit" class="btn btn-secondary">Register</button>--%>
                            
                            <asp:Button ID="Button1" class="btn btn-outline-dark"  runat="server" OnClick="Button1_Click" Text="Ingresar" />
                            <%--<asp:Login ID="Button1"></asp:Login>--%>
                            <br />
                            <br />
                            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
                            
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
