using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class ColumnasBD {
        //sp_columns_managed
        public DataTable datosColumnas(string strTabla) {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT COLUMN_NAME " +
                                 "FROM INFORMATION_SCHEMA.COLUMNS " +
                                 "WHERE TABLE_NAME = '"+strTabla+"';";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }
    }
}




