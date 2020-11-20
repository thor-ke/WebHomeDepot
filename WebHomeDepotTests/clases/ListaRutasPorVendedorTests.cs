using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class ListaRutasPorVendedorTests
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

            var vendedores =new ListaRutasPorVendedor();
            vendedores.vendedor = string.Empty;
            vendedores.rutasXml = listaRuta;
            var listaRutas= vendedores.listar();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(listaRutas);

            Debug.Write(json);

            Assert.IsTrue(listaRutas.Count > 0);

        }
    }
}