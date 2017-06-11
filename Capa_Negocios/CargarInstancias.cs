using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    class CargarInstancias {

        public DataTable cargarInstancia() {
            DataTable objDT = new Capa_Conexion.InstanciasSQL ().CargarInstancias ();
            // falta agragar las columnas, no me deja ejecutar la rutina
            return objDT;
            
        }

    }
}
