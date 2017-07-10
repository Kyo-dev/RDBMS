using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    class CargarColumnas {
        public DataTable InfoColumna (string strColumnas) {
            Capa_Conexion.ColumnasBD clColumnas = new Capa_Conexion.ColumnasBD ();
            return clColumnas.InfoColumnas (strColumnas);
        }
    }
}
