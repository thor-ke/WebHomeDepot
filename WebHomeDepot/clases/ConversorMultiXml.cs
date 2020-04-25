using System.Collections.Generic;
using System.IO;

namespace WebHomeDepot.clases
{
    public class ConversorMultiXml
    {
        public List<string> rutasXml { get; set; }
        public List<PurchaseOrder> lstPO { get; set; }

        protected ConversorXml cx;
        public ConversorMultiXml()
        {
            cx = new ConversorXml();
        }

        public virtual List<PurchaseOrder> convertir()
        {
            if(rutasXml== null || rutasXml.Count == 0)
            {
                return lstPO;
            }
            string pt = Properties.Settings.Default.ColectorXml;
          
            lstPO = new List<PurchaseOrder>();

            foreach(string ruta in rutasXml)
            {
                string path = Path.Combine(pt, ruta);
                cx.rutaXml = path;

                lstPO.Add(cx.convertir());
            }

            return lstPO;
        }
    }
}