using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class TablasBD {

        public DataTable CargarTablas() {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.StoredProcedure;
            objSQL.CommandText = "";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }
    }
}