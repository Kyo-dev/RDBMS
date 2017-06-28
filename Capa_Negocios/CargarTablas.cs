using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarTablas {
        public DataTable Tablas(string strNombreTabla) {
            Capa_Conexion.TablasBD cl_CargarTablas = new Capa_Conexion.TablasBD ();
            return cl_CargarTablas.Cargar_Tablas(strNombreTabla);
        }       
    }
}