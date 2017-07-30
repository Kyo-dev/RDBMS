using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocios {
    public class clsDatabases {

        public Task<DataTable> getDatabases(String instanceName) {
            return Task.Run(() => {
                return new Capa_Conexion.clsDatabases().getDataBases(instanceName: instanceName);
            });
        }

        public Task<List<String>> getInstancesName() {
            return Task.Run(() => {
                DataTable oDT = new Capa_Conexion.clsDatabases().getInstancesNames();
                List<String> instance = new List<String>();
                foreach(DataRow source in oDT.Rows) {
                    string servername;
                    string instanceName = source["InstanceName"].ToString();

                    if(!string.IsNullOrEmpty(instanceName)) {
                        servername = source["InstanceName"] + "\\" + source["ServerName"];
                    } else {
                        servername = source["ServerName"].ToString();
                    }
                    instance.Add(servername);
                }
                return instance;
            });
        }

        public Task<bool> conecctionTest(String instanceName) {
            return Task.Run(() => {
                return new Capa_Conexion.clsConnection(instanceName: instanceName).openConnection();
            });
        }
    }
}
