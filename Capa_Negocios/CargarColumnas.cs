using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    public class CargarColumnas {
        public DataTable datosColumnas (string strTabla) {
            Capa_Conexion.ColumnasBD clCargarColumnas = new Capa_Conexion.ColumnasBD ();
            return clCargarColumnas.datosColumnas (strTabla);
        }
    }
}