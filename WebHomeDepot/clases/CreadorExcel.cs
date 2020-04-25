using SpreadsheetLight;
using System.Collections.Generic;
using System.IO;

namespace WebHomeDepot.clases
{
    public class CreadorExcel
    {
        public List<PurchaseOrder> lstPO { get; set; }
        public string nombreExcel { get; set; }

       
        public string crearExcel()
        {
            //var appSettings = ConfigurationManager.AppSettings;
            string pt = Properties.Settings.Default.CreadosExcel; //appSettings["CreadosExcel"];

            if (pt== null)
            {
                pt = @"C:\HDEPOT\CreadosExcel";
            }
            
            string rutaExcel= Path.Combine(pt, nombreExcel);

            //string rutaExcel = AppDomain.CurrentDomain.BaseDirectory + nombreExcel;
            
            SLDocument doc = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();

            //columnas
            dt.Columns.Add("SKU", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("CANT", typeof(string));
            dt.Columns.Add("TIENDA", typeof(string));
            dt.Columns.Add("OC", typeof(string));
            dt.Columns.Add("Costo Unitario", typeof(string));
            dt.Columns.Add("Fill01", typeof(string));
            dt.Columns.Add("Fill02", typeof(string));

            foreach (PurchaseOrder po in lstPO)
            {
                PurchaseOrderPOItem[] p = po.PO.Items;
                int lg = p.Length;
                for (int i = 0; i < lg; i++)
                {
                    string ct = p[i].Quantity;
                    string desc = p[i].Descr;
                    string ship = po.PO.ShipTo.ShipToId +"-" + po.PO.ShipTo.ShipToNamePlace;
                    string sku= p[i].Id;
                    byte oc = po.PO.PONumber;
                    decimal costo = p[i].UnitCost;
                    dt.Rows.Add(sku, desc, ct,ship,oc,costo);
                }
            }

            doc.ImportDataTable(1, 1, dt, true);
            doc.SaveAs(rutaExcel);

            return rutaExcel;
        }
    }
}