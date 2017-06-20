using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarTablas {
        public DataTable Tablas() {
            DataTable objDT = new Capa_Conexion.TablasBD ().CargarTablas();
            objDT.Columns [0].ColumnName = "name";
            return objDT;
        }
    }
}
