using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHomeDepot
{
    /// <summary>
    /// Descripción breve de SesionadorArchivo
    /// </summary>
    public class SesionadorArchivo : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "texto/normal";
            //context.Response.Write("Hola a todos");

            string nm = context.Request["nombre"];
            string carpeta= context.Request["carpeta"];

            context.Session.Add("ExcelActual", nm);
            context.Session.Add("Carpeta", carpeta);

            context.Response.ContentType = "texto/normal";
            context.Response.Write("Carpeta: " + carpeta +", Archivo: " + nm);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}