using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHomeDepot.clases
{
    /// <summary>
    /// Descripción breve de SubidorArchi
    /// </summary>
    public class SubidorArchi : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string savedFileName = "";

            foreach (string file in context.Request.Files)
            {
                HttpPostedFile hpf = context.Request.Files[file] as HttpPostedFile;
                if (hpf.ContentLength == 0)
                    continue;
                // savedFileName = context.Server.MapPath(Path.GetFileName(hpf.FileName));
                // hpf.SaveAs(savedFileName);
            }
            context.Response.Write(savedFileName);

            //context.Response.ContentType = "texto/normal";
            //context.Response.Write("Hola a todos");
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