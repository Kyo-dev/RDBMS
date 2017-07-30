using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Capa_Conexion {
    public class clsDatabases {

        public DataTable getDataBases(String instanceName) {
            SqlCommand objSQL = new SqlCommand();
            objSQL.CommandType = CommandType.StoredProcedure;
            objSQL.CommandText = "sp_databases";
            return new clsConnection(instanceName).Select(objSQL);
        }

        public DataTable getInstancesNames() {
            return SqlDataSourceEnumerator.Instance.GetDataSources();
        }
    }
}
