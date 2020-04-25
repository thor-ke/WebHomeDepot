using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class InfoArchivosTests
    {
        [TestMethod()]
        public void buscarTest()
        {
            List<string> listaRuta = new List<string>()
            {
                "C:\\BASE\\Example PurchaseOrder.xml",
                "C:\\BASE\\Example PurchaseOrder02.xml",
                "C:\\BASE\\Example PurchaseOrder03.xml"
            };


            var info = new InfoArchivos();
            info.lstRutas = listaRuta;
            List<ArchivosVO> lst = info.buscar();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(lst);

            Debug.Write(json);

            Assert.IsTrue(lst.Count > 0);

        }
    }
}