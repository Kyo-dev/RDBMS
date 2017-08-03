using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocios {
    public class clsColumns {

        //Explicarme
        public Task<DataTable> EsquemeInfo(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return Task.Run(() => {
                return new Capa_Conexion.clsColumns().EsquemeInfo(strColumn, strTable, instanceName, strDataBase);
            });
        }

        public Task<DataTable> DATATYPE(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return Task.Run(() => {
                return new Capa_Conexion.clsColumns().EsquemeInfo(strColumn, strTable, instanceName, strDataBase);
            });
        }

        public Task<DataTable> getColumns(string strTable, String instance, String database = "master") {
            return Task.Run(() => {
                return new Capa_Conexion.clsColumns().getColumns(strTable, instance, database);
            });
        }
    }
}
