using System;
using System.Web.Security;

namespace WebHomeDepot
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //btAddExcel.Click += new System.EventHandler(btAddExcel_Click);
        }

        protected void btSalir_Click(object sender, EventArgs e)
        {
            //se borra la cookie de autenticacion
            FormsAuthentication.SignOut();

            //se redirecciona al usuario a la pagina de login
            Response.Redirect(Request.UrlReferrer.ToString());
        }
     
    }
}