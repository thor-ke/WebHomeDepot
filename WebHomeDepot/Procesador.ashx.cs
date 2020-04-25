using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebHomeDepot.clases;

namespace WebHomeDepot
{
    /// <summary>
    /// Descripción breve de Procesador
    /// </summary>
    public class Procesador : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string s = new StreamReader(context.Request.InputStream).ReadToEnd();
            ProcesadorVO pc = Newtonsoft.Json.JsonConvert.DeserializeObject<ProcesadorVO>(s);

            var conv = new ConversorMultiXml();
            conv.rutasXml = pc.lstArchivos;
            List<PurchaseOrder> po = conv.convertir();

            var ce = new CreadorExcel();
            ce.lstPO = po;
            ce.nombreExcel = pc.nombreExcel;
            var nm = ce.crearExcel();

            var mv = new MovedorArchivos();
            mv.lstArchivos = pc.lstArchivos;
            mv.moverXml();
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