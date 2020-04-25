using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebHomeDepot.clases;

namespace WebHomeDepot
{
    public partial class Editor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cargarGrid();
            }
            else
            {

                btAddExcel.Click += new System.EventHandler(btAddExcel_Click);

            }
        }

        private void cargarGrid()
        {
            //string pt = Properties.Settings.Default.CreadosExcel;

            HttpContext context = HttpContext.Current;
            //string nm= string.Empty;
            //if (context.Session["ExcelActual"] != null)
            //{
            //    nm = context.Session["ExcelActual"].ToString(); //"Roberto01.xls";
            //}else
            //{
            //    nm= "Roberto01.xls";
            //}

            string pt = string.Empty;
            string cp = Session["Carpeta"].ToString();
            string nm = Session["ExcelActual"].ToString();


            if (cp.Equals("PROCESADOS"))
            {
                pt = Properties.Settings.Default.CreadosExcel;
            }
            if (cp.Equals("PUBLICADOS"))
            {
                pt = Properties.Settings.Default.PublicadosExcel;
            }


            if (nm != null)
            {
                //Aca hay que abrir el Excel o con Boton click
                List<ExcelVO> lst = new LectorExcel()
                {
                    ruta = Path.Combine(pt, nm), //@"C:\HDEPOT\CreadosExcel\Roberto01.xls"
                }.leer();

                context.Session["Excel"] = lst;
                //context.Session["ExcelActual"] = nm;
            }
        }

        DataTable dt { get; set; }
        [Obsolete]
        public DataTable crearDataTable()
        {
            dt = new DataTable();

            //columnas
            dt.Columns.Add("SKU", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("CANT", typeof(string));
            dt.Columns.Add("TIENDA", typeof(string));
            dt.Columns.Add("OC", typeof(string));
            dt.Columns.Add("Costo Unitario", typeof(double));
            dt.Columns.Add("Fill01", typeof(string));
            dt.Columns.Add("Fill02", typeof(string));
            dt.Rows.Add("1234567", "Sku de Prueba", 2, "NE01", "123980", "2.300", "", "");
            dt.Rows.Add("1234568", "Sku de Prueba 02", 2, "NE01", "123981", "300.23", "", "");

            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            Session["ExcelTable"] = dt;

            //BindData();

            return dt;
        }
        [Obsolete]
        public void editarColumna(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            GridView1.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            BindData();
        }
        [Obsolete]
        public void actualizarColumna(DataTable dt, GridViewEditEventArgs e)
        {
            //Retrieve the table from the session object.
            //DataTable dt = (DataTable)Session["ExcelTable"];

            //Update the values.
            GridViewRow row = GridView1.Rows[e.NewEditIndex];
            dt.Rows[row.DataItemIndex]["SKU"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Descripción"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["CANT"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["TIENDA"] = ((TextBox)(row.Cells[4].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["OC"] = ((TextBox)(row.Cells[5].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Costo Unitario"] = ((TextBox)(row.Cells[6].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Fill01"] = ((TextBox)(row.Cells[7].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Fill02"] = ((TextBox)(row.Cells[8].Controls[0])).Text;

            //Reset the edit index.
            GridView1.EditIndex = -1;

        }
        [Obsolete]
        protected void cancelarEdicion(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            GridView1.EditIndex = -1;
            //Bind data to the GridView control.
            BindData();
        }
        [Obsolete]
        private void BindData()
        {
            //GridView1.DataSource = Session["ExcelTable"];
            //GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Publica Excel
                string nombre = txtArchi.Text;
                getExcelLayer.publicarExcel(nombre);

                //Mueve archivos
                string nmExcelActual = Session["ExcelActual"].ToString();
                string ptExcelCreados = Properties.Settings.Default.CreadosExcel;
                string ptPublicados = Properties.Settings.Default.PublicadosExcel;

                string rutaOrigen = Path.Combine(ptExcelCreados, nmExcelActual);
                string rutaDestino = Path.Combine(ptPublicados, nombre);
                File.Move(rutaOrigen, rutaDestino);

                var code = true;
                if (code == true)//se inserto
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "ShowPopup();", true);
                    this.lblTitlePopUp.Text = "Muy bien";
                    this.lblMessage.Text = "Muy bien, ya te encuentras inscrito en nuestra base de datos ahora pueden iniciar sesión.";
                }
                else //problemas al insertar
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "ShowPopup();", true);
                    this.lblTitlePopUp.Text = "Algo salio mal";
                    this.lblMessage.Text = "Tu registro no ha podido llevarse a cabo debido a que estamos presentando errores en nuestros servidores. Te sugerimos volver a intentarlo más tarde.";
                }



            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "ShowPopup();", true);
                this.lblTitlePopUp.Text = "Algo salio mal";
                this.lblMessage.Text = ex.Message;
            }

        }

        protected void btAddExcel_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //    return;
            //}

            List<int> lineas = new List<int>();
            List<ExcelVO> lst = (List<ExcelVO>)Session["Excel"];
            foreach (ExcelVO exc in lst)
            {
                lineas.Add(exc.linea);
            }

            var excel = new ExcelVO();
            excel.linea = lineas.Max() + 1;
            excel.SKU = txtSKU.Text;
            excel.Descripcion = txtDescripcion.Text;
            excel.CANT = txtCantidad.Text;
            excel.TIENDA = txtTienda.Text;
            excel.OC = txtOc.Text;
            excel.CostoUnitario = txtCostoUnitario.Text;
            excel.Fill01 = txtFill01.Text;
            excel.Fill02 = txtFill02.Text;
            lst.Add(excel);

            Session["Excel"] = lst;

            getExcelLayer.grabarExcel();

            //cargarGrid();

            limpiarForm();

            GridView1.DataSourceID = ObjectDataSource1.UniqueID;
        }

        private void limpiarForm()
        {

            txtSKU.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtTienda.Text = string.Empty;
            txtOc.Text = string.Empty;
            txtCostoUnitario.Text = string.Empty;
            txtFill01.Text = string.Empty;
            txtFill02.Text = string.Empty;
        }

       
    }
}
