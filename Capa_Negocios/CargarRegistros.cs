﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    public class CargarRegistros {

        public DataTable cargarRegistros(string strTabla, String instanceName, String var = "master") {
            return new Capa_Conexion.CargarRegistros().cargarRegistros(strTabla, instanceName, var);
        }
    }
}
