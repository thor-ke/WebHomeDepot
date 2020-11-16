using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WebHomeDepot.clases
{
    public class ConversorXml
    {
        public string rutaXml { get; set; }
        public PurchaseOrder convertir()
        {
            //@"C:\BASE\Example PurchaseOrder.xml"
            string pt = Properties.Settings.Default.CreadosExcel;
            string xmltext = File.ReadAllText(rutaXml);

            var serializer = new XmlSerializer(typeof(PurchaseOrderPO));
            var buffer = Encoding.UTF8.GetBytes(xmltext);
          
            using (var stream = new MemoryStream(buffer))
            {
                var po = (PurchaseOrder)serializer.Deserialize(stream);
                stream.Flush();
                stream.Close();
                return po;
            }
        }
    }
}