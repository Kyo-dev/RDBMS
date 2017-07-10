using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarBases {
        public DataTable DataBases() {
            Capa_Conexion.DataBases cl_CargarBases = new Capa_Conexion.DataBases ();
            return cl_CargarBases.SQLDataBase ();
        }
    }
}
