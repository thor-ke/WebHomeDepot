using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class ConversorXmlTests
    {
        [TestMethod()]
        public void convertirTest()
        {
           var conv= new ConversorXml();
            conv.rutaXml = @"C:\BASE\Example PurchaseOrder.xml";
            var po= conv.convertir();
            var json= Newtonsoft.Json.JsonConvert.SerializeObject(po);

            Debug.Write(json);

            Assert.IsTrue(po.PO.Items.Length > 0);
        }
    }
}