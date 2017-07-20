using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class EsquemaColumna {
        public DataTable InfoEsquema(string strColumna, string strTabla, String instanceName, String var = "master") {
            SqlCommand objSQL = new SqlCommand ();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "SELECT TABLE_NAME AS [Nombre de la tabla]," +
                                 "COLUMN_NAME AS [Nombre de la columna]" +
                                 ",DATA_TYPE AS [Tipo de dato]" +
                                 ",CHARACTER_MAXIMUM_LENGTH AS [Largo Maximo]" +
                                 ",COLUMN_DEFAULT AS [Valor por defecto] " +
                                 "FROM INFORMATION_SCHEMA.COLUMNS "+
                                 "WHERE COLUMN_NAME = '"+strColumna+"' AND TABLE_NAME = '"+strTabla+"';";
            return new Capa_Conexion.Conexion (instanceName, var).ejecutarRutina (objSQL);
        }
    }
}

