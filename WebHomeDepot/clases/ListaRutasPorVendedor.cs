using System.Collections.Generic;

namespace WebHomeDepot.clases
{
    public class ListaRutasPorVendedor
    {

        public byte vendedor { get; set; }
        public List<string> rutasXml { get; set; }
        public List<string> lstRutasVendedor { get; private set; }
      

        protected ConversorXml cx;

        public ListaRutasPorVendedor()
        {
            cx = new ConversorXml();
        }

        public List<string> listar()
        {
            if (rutasXml == null || rutasXml.Count == 0)
            {
                return lstRutasVendedor;
            }
            lstRutasVendedor = new List<string>();

            foreach (string ruta in rutasXml)
            {
                cx.rutaXml = ruta;
                var po = cx.convertir();
                var ven = po.PO.Vendor.VendorId;
                if (ven == (vendedor))
                {

                    lstRutasVendedor.Add(ruta);
                }
            }
          
            return lstRutasVendedor;
        }

    }
}