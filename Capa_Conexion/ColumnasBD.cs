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
        public DataTable datosColumnas() {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.StoredProcedure;
            objSQL.CommandText = "sp_columns_managed";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }

        //public int ConsultarColumnas() {
        //    SqlCommand objSQL = new SqlCommand ();
        //    objSQL.CommandType = CommandType.StoredProcedure;
        //    objSQL.CommandText = "sp_columns_managed";
        //    objSQL.Parameters.Add ("@TABLE_CATALOG",SqlDbType.VarChar,100);
        //}
    }
}
