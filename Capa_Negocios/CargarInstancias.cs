using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarInstancias {

        public List<String> cargarInstancia() {
            DataTable oDT =  new Capa_Conexion.InstanciasSQL ().CargarInstancias ();
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
        }

        public bool conecctionTest(String instanceName) {
            return new Capa_Conexion.Conexion(instanceName: instanceName).abrirConexion();
        }

    }
}
