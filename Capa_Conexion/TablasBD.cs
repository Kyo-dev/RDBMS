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
            //SqlCommand objSQL = new SqlCommand ();
            //objSQL.CommandType = CommandType.StoredProcedure;
            //objSQL.CommandText = "";

            SqlCommand objSQL = new SqlCommand ("SELECT name FROM sysobjects WHERE xtype='u'");

            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }

        public DataTable Cargar_Tablas(string strNombreTabla) {
            SqlCommand objCommand = new SqlCommand ();
            SqlConnection objConexion = new SqlConnection ();
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "SELECT CAST(table_name as varchar) Tablas " +
                                     "FROM " + strNombreTabla + 
                                     ".INFORMATION_SCHEMA.TABLES;";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objCommand);

        }
    }
}