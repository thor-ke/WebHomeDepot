using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace WebHomeDepot.clases.Tests
{
    [TestClass()]
    public class LectorExcelTests
    {
        [TestMethod()]
        public void leerTest()
        {
            var le = new LectorExcel()
            {
                ruta = @"C:\HDEPOT\CreadosExcel\Roberto01.xls"
            }.leer();


            string json= Newtonsoft.Json.JsonConvert.SerializeObject(le);
            Debug.Write(json);


            Assert.IsTrue(le.Count >0);
        }
    }
}