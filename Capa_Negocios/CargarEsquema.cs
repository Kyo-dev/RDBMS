using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarEsquema {

        public DataTable Esquemas(string strColumna, string strTabla) {
            Capa_Conexion.EsquemaColumna clEsquema = new Capa_Conexion.EsquemaColumna ();
            return clEsquema.InfoEsquema (strColumna, strTabla);
        }
    }
}