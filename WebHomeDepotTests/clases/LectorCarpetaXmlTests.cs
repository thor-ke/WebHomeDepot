using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class LectorCarpetaXmlTests
    {
        [TestMethod()]
        public void obtenerArchivosDirectorioTest()
        {
           var lc =  new LectorCarpetaXml();
           var lista= lc.obtenerArchivosDirectorio(@"C:\BASE\*.xml");

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lista);

            Debug.Write(json);

            Assert.IsTrue(lista.Count > 0);

        }
    }
}