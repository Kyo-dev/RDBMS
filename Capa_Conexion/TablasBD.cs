using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class TablasBD {

        public DataTable CargarTablasBD ()
        {
            Capa_Conexion.Conexion conecta = new Capa_Conexion.Conexion();
            DataTable dtTablas;
            SqlCommand obj = new SqlCommand();
            obj.CommandType = CommandType.StoredProcedure;
            dtTablas= conecta.ejecutar("SELECT name FROM sysobjects WHERE xtype = 'u'");
            return dtTablas;
        }


        // falta la rutina, sql me da errores

        //public DataTable Cargar_Tablas(string strNombreTabla) {
        //    SqlCommand objCommand = new SqlCommand ();
        //    SqlConnection objConexion = new SqlConnection ();
        //    objCommand.CommandType = CommandType.Text;
        //    objCommand.CommandText = "SELECT CAST(table_name as varchar) Tablas " +
        //                             "FROM " + strNombreTabla + 
        //                             ".INFORMATION_SCHEMA.TABLES;";
        //    return new Capa_Conexion.Conexion ().ejecutarRutina (objCommand);

        //}
    }
}