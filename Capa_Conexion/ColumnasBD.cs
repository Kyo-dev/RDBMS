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
            //objSQL.CommandText = "SELECT TABLE_CATALOG" +
            //                     ",TABLE_NAME" +
            //                     ",COLUMN_NAME" +
            //                     ",DATA_TYPE" +
            //                     ",COLUMN_DEFAULT" +
            //                     ",CHARACTER_MAXIMUM_LENGTH" +
            //                     "FROM "+strTabla+".INFORMATION_SCHEMA.COLUMNS;";
            objSQL.CommandText = "sp_columns_managed";
            return new Capa_Conexion.Conexion ().ejecutarRutina (objSQL);
        }
    }
}
