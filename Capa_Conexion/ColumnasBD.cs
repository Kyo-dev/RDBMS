using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class ColumnasBD {

        public DataTable InfoColumnas(string strColumna) {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT TABLE_NAME " +
                                 "FROM " + strColumna + ".INFORMATION_SCHEMA.COLUMNS;";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }
    }
}
