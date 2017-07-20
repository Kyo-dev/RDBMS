     using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class TablasBD {
        public DataTable CargarTablas(String instanceName, String var = "master") {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "sp_Tables";
            return new Capa_Conexion.Conexion (instanceName, var).ejecutarRutina (objSQL);
        }
    }
}