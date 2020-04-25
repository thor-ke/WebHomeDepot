using SpreadsheetLight;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web;

namespace WebHomeDepot.clases
{
    public class ExcelVO
    {
        public int linea { get; set; }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public string CANT { get; set; }
        public string TIENDA { get; set; }
        public string OC { get; set; }
        public string CostoUnitario { get; set; }
        public string Fill01 { get; set; }
        public string Fill02 { get; set; }

        //DataTable dt { get; set; }
        //public DataTable crearDataTable()
        //{
        //    dt = new DataTable();

        //    //columnas
        //    dt.Columns.Add("SKU", typeof(string));
        //    dt.Columns.Add("Descripción", typeof(string));
        //    dt.Columns.Add("CANT", typeof(string));
        //    dt.Columns.Add("TIENDA", typeof(string));
        //    dt.Columns.Add("OC", typeof(string));
        //    dt.Columns.Add("Costo Unitario", typeof(double));
        //    dt.Columns.Add("Fill01", typeof(string));
        //    dt.Columns.Add("Fill02", typeof(string));
        //    dt.Rows.Add("1234567", "Sku de Prueba", 2, "NE01", "123980", "2.300", "", "");
        //    dt.Rows.Add("1234568", "Sku de Prueba 02", 2, "NE01", "123981", "300.23", "", "");
        //    //SessionParameter["ExcelTable"] = dt;

        //    return dt;
        //}

        //public void updateTable(object sender, GridViewUpdateEventArgs e)
        //{
        //Retrieve the table from the session object.
        //DataTable dt = (DataTable)Session["ExcelTable"];

        //Update the values.
        // GridViewRow row = e.GridView1.Rows[e.RowIndex];
        //dt.Rows[row.DataItemIndex]["SKU"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["Descripción"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["CANT"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["TIENDA"] = ((TextBox)(row.Cells[4].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["OC"] = ((TextBox)(row.Cells[5].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["Costo Unitario"] = ((TextBox)(row.Cells[6].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["Fill01"] = ((TextBox)(row.Cells[7].Controls[0])).Text;
        //dt.Rows[row.DataItemIndex]["Fill02"] = ((TextBox)(row.Cells[8].Controls[0])).Text;

        //Reset the edit index.
        //GridView1.EditIndex = -1;
        //}
    }

    public class getExcelLayer
    {
        public static List<ExcelVO> getExcelList()
        {
            // List<ExcelVO> lst = new List<ExcelVO>();
            HttpContext context = HttpContext.Current;
            List<ExcelVO> lst = (List<ExcelVO>)context.Session["Excel"];

            return lst;
        }

      
        public static void updateExcel(ExcelVO ex)
        {
            HttpContext context = HttpContext.Current;
            List<ExcelVO> lst = (List<ExcelVO>)context.Session["Excel"];
            foreach (ExcelVO e in lst)
            {
                if (e.linea.Equals(ex.linea))
                {
                    e.CANT = ex.CANT;
                    e.CostoUnitario = ex.CostoUnitario;
                    e.Descripcion = ex.Descripcion;
                    e.Fill01 = ex.Fill01;
                    e.Fill02 = ex.Fill02;
                    e.TIENDA = ex.TIENDA;
                    e.OC = ex.OC;
                }
            }

            context.Session["Excel"] = lst;

            grabarExcel();

            //return -1;
        }

        public static void grabarExcel()
        {
            string nombreExcel = "Roberto01.xls";

            HttpContext context = HttpContext.Current;
            List<ExcelVO> lst = (List<ExcelVO>)context.Session["Excel"];

            string pt = Properties.Settings.Default.CreadosExcel; 

            string rutaExcel = Path.Combine(pt, nombreExcel);

            SLDocument doc = new SLDocument();
            DataTable dt = new DataTable();

            //columnas
            dt.Columns.Add("SKU", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("CANT", typeof(string));
            dt.Columns.Add("TIENDA", typeof(string));
            dt.Columns.Add("OC", typeof(string));
            dt.Columns.Add("Costo Unitario", typeof(string));
            dt.Columns.Add("Fill01", typeof(string));
            dt.Columns.Add("Fill02", typeof(string));

            for(int i=0; i < lst.Count; i++)
            //foreach (ExcelVO exc in lst)
            {
 
                string ct = lst[i].CANT;
                string desc = lst[i].Descripcion;
                string ship = lst[i].TIENDA; 
                string sku = lst[i].SKU; 
                string oc = lst[i].OC;
                string costo = lst[i].CostoUnitario;
                string fill01 = lst[i].Fill01;
                string fill02 = lst[i].Fill02;
                dt.Rows.Add(sku, desc, ct, ship, oc, costo, fill01, fill02);
             
            }

            doc.ImportDataTable(1, 1, dt, true);
            doc.SaveAs(rutaExcel);
        }

        public static void publicarExcel(string nombreExcel)
        {
            
            HttpContext context = HttpContext.Current;
            List<ExcelVO> lst = (List<ExcelVO>)context.Session["Excel"];
            string pt = Properties.Settings.Default.PublicadosExcel;

            string rutaExcel = Path.Combine(pt, nombreExcel);

            SLDocument doc = new SLDocument();
            DataTable dt = new DataTable();

            //columnas
            dt.Columns.Add("SKU", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("CANT", typeof(string));
            dt.Columns.Add("TIENDA", typeof(string));
            dt.Columns.Add("OC", typeof(string));
            dt.Columns.Add("Costo Unitario", typeof(string));
            dt.Columns.Add("Fill01", typeof(string));
            dt.Columns.Add("Fill02", typeof(string));

            for (int i = 0; i < lst.Count; i++)
            //foreach (ExcelVO exc in lst)
            {

                string ct = lst[i].CANT;
                string desc = lst[i].Descripcion;
                string ship = lst[i].TIENDA;
                string sku = lst[i].SKU;
                string oc = lst[i].OC;
                string costo = lst[i].CostoUnitario;
                string fill01 = lst[i].Fill01;
                string fill02 = lst[i].Fill02;
                dt.Rows.Add(sku, desc, ct, ship, oc, costo, fill01, fill02);

            }

            doc.ImportDataTable(1, 1, dt, true);
            doc.SaveAs(rutaExcel);
        }

    }

}