using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    public class CargarColumnas {
        public DataTable datosColumnas (string strTabla) {
            Capa_Conexion.ColumnasBD clCargarColumnas = new Capa_Conexion.ColumnasBD ();
            return clCargarColumnas.datosColumnas (strTabla);
        }
    }
}
 /*
            objDT.Columns [0].ColumnName = "TABLE_CATALOG";
            objDT.Columns [2].ColumnName = "TABLE_NAME";
            objDT.Columns [3].ColumnName = "COLUMN_NAME";
            objDT.Columns [7].ColumnName = "DATA_TYPE";
            objDT.Columns [5].ColumnName = "COLUMN_DEFAULT";
            objDT.Columns [8].ColumnName = "CHARACTER_MAXIMUM_LENGTH";
 */