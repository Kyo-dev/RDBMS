using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class cargarBases {
        public DataTable cargarBD() {
            return new Capa_Conexion.Conexion ().cargarBases();
        }
    }
}
