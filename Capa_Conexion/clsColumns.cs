using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class clsColumns {

        public DataTable getColumns(string strTable, String instance, String database = "master") {
            SqlCommand objSQL = new SqlCommand();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = String.Format("sp_columns {0}", strTable);
            return new clsConnection(instance, database).Select(objSQL);
        }

        public DataTable EsquemeInfo(String strColumn, String strTable, String instanceName, String strDatabase = "master") {
            SqlCommand objSQL = new SqlCommand();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = String.Format("SELECT TABLE_NAME AS [Nombre de la tabla]," +
                                 "COLUMN_NAME AS [Nombre de la columna]" +
                                 ",DATA_TYPE" +
                                 ",CHARACTER_MAXIMUM_LENGTH AS [Largo Maximo]" +
                                 ",COLUMN_DEFAULT AS [Valor por defecto] " +
                                 "FROM INFORMATION_SCHEMA.COLUMNS " +
                                 "WHERE COLUMN_NAME = '{0}' AND TABLE_NAME = '{1}';", strColumn, strTable);
            return new clsConnection(instanceName, strDatabase).Select(objSQL);
        }
    }
}
