using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class clsTables {

        public DataTable loadRegisters(String strTable, String instanceName, String database = "master") {
            SqlCommand oCM = new SqlCommand("SELECT * FROM {strTable}");
            oCM.CommandType = CommandType.Text;
            return new clsConnection(instanceName: instanceName, database: database).Select(oCM, database);
        }
    }
}
