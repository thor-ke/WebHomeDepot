using SpreadsheetLight;
using System.Collections.Generic;

namespace WebHomeDepot.clases
{
    public class LectorExcel
    {
        public string ruta { get; set; }
        List<ExcelVO> lstRowExcel { get; set; }

        public LectorExcel()
        {
            lstRowExcel = new List<ExcelVO>();
        }
        public List<ExcelVO> leer()
        {
            
            SLDocument sl = new SLDocument(ruta);
            int rowIndex = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(rowIndex, 1)))
            {
                var exc = new ExcelVO();
                exc.linea = rowIndex;
                exc.SKU = sl.GetCellValueAsString(rowIndex, 1);
                exc.Descripcion = sl.GetCellValueAsString(rowIndex, 2);
                exc.CANT = sl.GetCellValueAsString(rowIndex, 3);
                exc.TIENDA = sl.GetCellValueAsString(rowIndex, 4);
                exc.OC = sl.GetCellValueAsString(rowIndex, 5);
                exc.CostoUnitario= sl.GetCellValueAsString(rowIndex, 6);
                exc.Fill01 = sl.GetCellValueAsString(rowIndex, 7);
                exc.Fill02 = sl.GetCellValueAsString(rowIndex, 8);

                lstRowExcel.Add(exc);

                rowIndex += 1;
            }

            return lstRowExcel;
        }
    }
}