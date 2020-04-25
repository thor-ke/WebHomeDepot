using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class ConversorMultiXmlTests
    {
        [TestMethod()]
        public void convertirTest()
        {
            List<string> listaRuta = new List<string>()
            {
                "C:\\BASE\\Example PurchaseOrder.xml",
                "C:\\BASE\\Example PurchaseOrder02.xml",
                "C:\\BASE\\Example PurchaseOrder03.xml"
            };

            var cnm = new ConversorMultiXml();
            cnm.rutasXml = listaRuta;
            var po = cnm.convertir();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(po);

            Debug.Write(json);

            Assert.IsTrue(po != null);
        }
    }
}