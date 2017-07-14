using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    public class CargarRegistros {
        public DataTable registroColumna(string strColumna, string strTabla) {
            Capa_Conexion.RegistroColumnas clCargarRegistros = new Capa_Conexion.RegistroColumnas ();
            return clCargarRegistros.cargarRegistros (strColumna,strTabla);
        }
    }
}