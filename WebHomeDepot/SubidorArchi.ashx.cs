using System.IO;
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
                {
                    continue;
                }else
                {
                     savedFileName = context.Server.MapPath(Path.GetFileName(hpf.FileName));
                    // hpf.SaveAs(savedFileName);
                }
                // savedFileName = context.Server.MapPath(Path.GetFileName(hpf.FileName));
                // hpf.SaveAs(savedFileName);
            }
            context.Response.Write(savedFileName);

         
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