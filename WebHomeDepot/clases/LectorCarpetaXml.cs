using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebHomeDepot.clases
{
    public class LectorCarpetaXml
    {
        public List<string> obtenerArchivosDirectorio(string rutaArchivo)
        {

            List<string> listaRuta = new List<string>();

            listaRuta = Directory.GetFiles(Path.GetDirectoryName(rutaArchivo), Path.GetFileName(rutaArchivo)).ToList();

            return listaRuta;
        }
    }
}