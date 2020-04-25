using System;
using System.Collections.Generic;
using System.IO;

namespace WebHomeDepot.clases
{
    public class MovedorArchivos
    {
        public List<string> lstArchivos { get; set; }

        public bool moverXml()
        {
            bool res = false;
            try
            {

                string ptXml = Properties.Settings.Default.ColectorXml;
                string ptTarget = Properties.Settings.Default.Procesados;

                foreach (string a in lstArchivos)
                {
                    string rutaOrigen = Path.Combine(ptXml, a);
                    string rutaDestino = Path.Combine(ptTarget, a);
                    File.Move(rutaOrigen, rutaDestino);
                }
                res = true;
            }
            catch (Exception ex)
            {

            }

            return res;
        }
        public bool moverXls()
        {
            bool res = false;
            try
            {
                string ptXls = Properties.Settings.Default.Procesados;
                string ptTarget = Properties.Settings.Default.PublicadosExcel;

                foreach (string a in lstArchivos)
                {
                    string rutaOrigen = Path.Combine(ptXls, a);
                    string rutaDestino = Path.Combine(ptTarget, a);
                    File.Move(rutaOrigen, rutaDestino);
                }
                res = true;
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}