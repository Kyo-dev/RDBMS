using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    // Conexion para conocer Base de Datos

    public class DataBases {
        public DataTable ServidoresSQL() {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.StoredProcedure;
            objSQL.CommandText = "sp_databases";
            return new Capa_Conexion.Conexion().ejecutarRutina(objSQL);
        }

        public DataTable MotoresDB() {
            SqlCommand objCommand = new SqlCommand ();
            Conexion objConexion = new Conexion ();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "sp_helpdb";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objCommand);
        }
    }
}
