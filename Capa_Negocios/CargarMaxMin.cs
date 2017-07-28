using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    public class CargarMaxMin {

        public DataTable registroMayor(string strDataBase,string strColumna,string strTabla , String strInstancia , String var = "master") {
            Capa_Conexion.MaxMin clMaxMin = new Capa_Conexion.MaxMin ();
            return clMaxMin.cargarMax (strInstancia , strDataBase , strTabla , strColumna);
        }

        public DataTable registroMenor(string strDataBase , string strColumna , string strTabla , String strInstancia , String var = "master") {
            Capa_Conexion.MaxMin clMaxMin = new Capa_Conexion.MaxMin ();
            return clMaxMin.cargarMin (strInstancia , strDataBase , strTabla , strColumna);
        }
    }
}
