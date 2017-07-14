 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class TablasBD {
        public DataTable CargarTablas(string strDataBase) {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT TABLE_NAME " +
                                 "FROM "+strDataBase+".INFORMATION_SCHEMA.TABLES;";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }
    }
}