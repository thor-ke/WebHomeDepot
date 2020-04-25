using System.Collections.Generic;

namespace WebHomeDepot.clases
{
    public class InfoArchivos
    {
        public List<string> lstRutas { get; set; }
        public string json { get; set; }
        private List<ArchivosVO> lstArchivos { get; set; }

        public InfoArchivos()
        {
            lstArchivos = new List<ArchivosVO>();
        }

        public List<ArchivosVO> buscar()
        {
            if (lstRutas !=null) {
                foreach (string str in lstRutas)
                {
                    var a = new ArchivosVO();
                    var i = new System.IO.FileInfo(str);
                    a.largo = (i.Length / 1024).ToString() + " Kb";
                    a.nombre = i.Name;
                    a.fecha = i.CreationTime.ToString();
                    a.ruta = str;
                    a.link = "<a href='BajadorArchi.ashx?nombre=" + i.Name + "'>Bajar</a>";
                    lstArchivos.Add(a);
                }
            }
            return lstArchivos;
        }
        private void crearJson()
        {
           json = Newtonsoft.Json.JsonConvert.SerializeObject(lstArchivos);
        }
    }

    
    public class ArchivosVO
    {
        public string largo;
        public string fecha;
        public string nombre;
        public string ruta;
        public string link;
    }

}