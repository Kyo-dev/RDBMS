using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Conexion {
    public class CargarRegistros {
    
        public DataTable cargarRegistros(string strTabla, String instanceName, String var = "master") {
            SqlCommand oCM = new SqlCommand("SELECT * FROM " + strTabla );
            oCM.CommandType = CommandType.Text;
            return new Conexion(instanceName: instanceName, var: var).ejecutarRutina(oCM, var);
        }
    }
}
