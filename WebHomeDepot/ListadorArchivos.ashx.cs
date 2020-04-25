using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using WebHomeDepot.clases;

namespace WebHomeDepot
{
    /// <summary>
    /// Descripción breve de ListadorArchivos
    /// </summary>
    public class ListadorArchivos : IHttpHandler
    {
        
        public void ProcessRequest(HttpContext context)
        {
            //Esta es muy corta y funciona
            string strJson = new StreamReader(context.Request.InputStream).ReadToEnd();

            context.Response.ContentType = "application/json";

            MensajeroListaArchiVO msj = Newtonsoft.Json.JsonConvert.DeserializeObject<MensajeroListaArchiVO>(strJson);

            var lstArchivosGen = new LectorCarpetaXml();
           
            List<string> lst = null;
           
            string directorio = string.Empty;
            switch (msj.rutaArchivo)
            {
                case "COLECTOR":
                    directorio = Properties.Settings.Default.ColectorXml;
                    var rt = Path.Combine(directorio, "*.xml");
                    var listaGen = lstArchivosGen.obtenerArchivosDirectorio(rt);
                    lst = listarXml(msj, listaGen);
                    break;
                case "PROCESADOS":
                    directorio = Properties.Settings.Default.CreadosExcel;
                    var rtx = Path.Combine(directorio, "*.xls?");

                    lst = lstArchivosGen.obtenerArchivosDirectorio(rtx);
     
                    break;
                case "PUBLICADOS":
                    directorio = Properties.Settings.Default.PublicadosExcel; 
                    var rtx2 = Path.Combine(directorio, "*.xls?");

                    lst = lstArchivosGen.obtenerArchivosDirectorio(rtx2);

                    break;
            }
       
            var ia = new InfoArchivos();
            ia.lstRutas = lst;
            List<ArchivosVO> archivos = ia.buscar();

            adicionarLink(ref archivos,directorio);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(archivos);
            context.Response.Write(json);


        }

        private void adicionarLink(ref List<ArchivosVO> lst, string directorio)
        {
            
            foreach (ArchivosVO ac in lst)
            {
                ac.link = "<a href='BajadorArchi.ashx?nombre=" + ac.nombre + "&dir=" + directorio + "'><i class='fas fa-cloud-download-alt'></i></a>";
                ac.ruta= "<a  href='BajadorArchi.ashx?nombre=" + ac.nombre + "&dir=" + directorio + "'>Bajar</a>";

            }
        }
       
        private static List<string> listarXml(MensajeroListaArchiVO msj, List<string> listaGen)
        {
            var lt = new ListaRutasPorVendedor();
            List<string> lst = null;
            if (msj != null && msj.codVendedor!= string.Empty)
            {
                lt.vendedor = byte.Parse(msj.codVendedor);
                lt.rutasXml = listaGen;
                lst = lt.listar();
            }
            return lst;
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