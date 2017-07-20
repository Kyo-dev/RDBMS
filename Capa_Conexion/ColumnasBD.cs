using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class ColumnasBD {
        public DataTable datosColumnas(string strTabla, String instancia, String var = "master") {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "sp_columns " + strTabla;
            return new Capa_Conexion.Conexion (instancia, var).ejecutarRutina (objSQL);
        }
    }
}




