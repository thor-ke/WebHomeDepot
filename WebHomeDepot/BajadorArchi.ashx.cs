using System.Configuration;
using System.IO;
using System.Web;

namespace WebHomeDepot.clases
{
    /// <summary>
    /// Descripción breve de BajadorArchi
    /// </summary>
    public class BajadorArchi : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
           
            string archivo = context.Request.QueryString["nombre"];
            string pt = context.Request.QueryString["dir"];

            string nm= context.Request["nombre"];
            string p = context.Request["dir"];
           

            string dlDir = pt; 
            string path = Path.Combine(pt, archivo); 

            System.IO.FileInfo toDownload =
                  new System.IO.FileInfo(path);

            context.Response.Clear();
            context.Response.AddHeader("Content-Disposition",
                    "attachment; filename =" + archivo);

            context.Response.AddHeader("Content-Length",
                    toDownload.Length.ToString());
            context.Response.ContentType = "application/octet-stream";
            context.Response.WriteFile(path);
            context.Response.End();
      
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