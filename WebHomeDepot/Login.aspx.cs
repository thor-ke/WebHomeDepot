using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Security;
using WebHomeDepot.clases;

namespace WebHomeDepot
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsCallback)
            {
                LabelError.Text = string.Empty;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool valido = false;
            string pt = Server.MapPath("~");
            string archiJson = "usuarios.json";
            Path.Combine(pt, archiJson);

            var lu = new LectorUsuarios();
            lu.nombreJson = Path.Combine(pt, archiJson);
            List<UsuarioVO> lstUsuarios = lu.leer();
            foreach (UsuarioVO usu in lstUsuarios)
            {
                if(usu.user.Equals(txtUsuario.Text) && usu.password.Equals(txtPass.Text))
                {
                    valido = true;
                    Session["nombreVendedor"] = usu.nombre;
                    Session["codigoVendedor"] = usu.codigoVendedor;
                    break;
                }
            }

            //FormsAuthentication.Authenticate(txtUsuario.Text, txtPass.Text)
            if (valido)
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, false);

                //string pt = Request.QueryString["ReturnUrl"];
                //Response.Redirect("Editor.aspx");

            }
            else

                LabelError.Text = "Usuario o clave incorrecto";

        }

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}