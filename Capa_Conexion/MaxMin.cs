using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class MaxMin {
        public DataTable cargarMax(string strInstancia, string strDataBase, string strTabla, string strColumn, String var = "master") {
            SqlCommand objSQL = new SqlCommand();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT MAX (" + strColumn + ") " +
                                 "FROM " + strTabla + ";";
            return new Capa_Conexion.Conexion (strInstancia, var).ejecutarRutina (objSQL);
        }

        public DataTable cargarMin(string strInstancia , string strDataBase , string strTabla , string strColumn , String var = "master") {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT MIN (" + strColumn + ") " +
                                 "FROM " + strTabla + ";";
            return new Capa_Conexion.Conexion (strInstancia , var).ejecutarRutina (objSQL);
        }
    }
}
