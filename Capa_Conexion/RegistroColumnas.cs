using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class RegistroColumnas {
        public DataTable cargarRegistros(string strColumna, string strTabla, string strBaseDatos) {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT " + strColumna + " " +
                                 "FROM " + strBaseDatos + "." +"dbo"+"."+ strTabla + ";";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }
    }
}
