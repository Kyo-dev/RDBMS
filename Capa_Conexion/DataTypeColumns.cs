using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Conexion {
    public class DataTypeColumns {
        public DataTable SelectMax(String strColumn, String strTable, String instanceName, String dataBase = "master") {
            SqlCommand oSQLC = new SqlCommand($"SELECT MAX({strColumn}) Maximo FROM {strTable};");
            oSQLC.CommandType = CommandType.Text;
            return new clsConnection(instanceName: instanceName, database: dataBase).Select(oSQLC);
        }
    }
}
