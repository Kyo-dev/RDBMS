using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class DataBases {
        public DataTable ServidoresSQL() {
            SqlCommand objSQl = new SqlCommand ();
            objSQl.CommandType = CommandType.StoredProcedure;
            objSQl.CommandText = "sp_databases";
            return new Capa_Conexion.Conexion().ejecutarRutina(objSQl);
        }
    }
}
