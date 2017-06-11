using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class InstanciasSQL {

        public DataTable CargarInstancias() {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.StoredProcedure;
            objSQL.CommandText = "";
            return new Capa_Conexion.Conexion ().ejecutarRutina(objSQL);
        }
    }
}
