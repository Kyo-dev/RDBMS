using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class InstanciasSQL {

        //Esta funcion es opcional, se quesa para el final

        public DataTable CargarInstancias() {
            return new Capa_Conexion.Conexion(null).instancias();
        }
    }
}