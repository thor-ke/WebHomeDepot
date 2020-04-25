using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class CreadorExcelTests
    {


        List<PurchaseOrder> lstPO;
        [TestInitialize]
        public void iniciar()
        {
            List<string> listaRuta = new List<string>()
            {
                "C:\\BASE\\Example PurchaseOrder.xml",
                "C:\\BASE\\Example PurchaseOrder02.xml",
                "C:\\BASE\\Example PurchaseOrder03.xml"
            };

            ConversorMultiXml conv = new ConversorMultiXml();
            conv.rutasXml = listaRuta;
            lstPO = conv.convertir();
        }

        [TestMethod()]
        public void crearExcelTest()
        {
            CreadorExcel ce = new CreadorExcel();
            ce.lstPO = lstPO;
            ce.nombreExcel = "PruebaExcel.xlsx";
            string ruta= ce.crearExcel();

            Assert.IsTrue(ruta.Length > 0);

        }
    }
}