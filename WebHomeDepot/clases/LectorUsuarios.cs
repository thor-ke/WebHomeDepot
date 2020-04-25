using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace WebHomeDepot.clases
{
    public class LectorUsuarios
    {
        [DefaultValue("usuarios.json")]
        public string nombreJson { get; set; }

        public List<UsuarioVO> lstUsuarios { get; set; }
        public List<UsuarioVO> leer()
        {
            string rutaJson = nombreJson;
            string json = File.ReadAllText(rutaJson);

            UsuarioVO[] usu = Newtonsoft.Json.JsonConvert.DeserializeObject<UsuarioVO[]>(json);
            lstUsuarios = new List<UsuarioVO>(usu);

            return lstUsuarios;

        }
    }
}