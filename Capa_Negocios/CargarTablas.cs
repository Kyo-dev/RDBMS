using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarTablas {

        public DataTable Tablas(string strDataBase) {
            Capa_Conexion.TablasBD clCargarTablas = new Capa_Conexion.TablasBD ();
            return clCargarTablas.CargarTablas (strDataBase);
        }
    }
}