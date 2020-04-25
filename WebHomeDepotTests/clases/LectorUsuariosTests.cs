using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class LectorUsuariosTests
    {
        [TestMethod()]
        public void leerTest()
        {
            var lu = new LectorUsuarios();
            lu.nombreJson = "usuarios.json";
            var lst = lu.leer();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lst);

            Debug.Write(json);

            Assert.IsTrue(lst.Count > 0);
        }        
    }
}