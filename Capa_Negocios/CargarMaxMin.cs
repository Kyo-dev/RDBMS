using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios {
    public class CargarMaxMin {

        // NO SE SI USAR LISTAS PARA OBTENER LA FILA QUE CONTIENE EL VALOR O CON SOLO EL VALOR BASTA

        List<string> listRegistro = new List<string> ();

        public DataTable registroMayor(string strDataBase,string strColumna,string strTabla , String strInstancia) {
            Capa_Conexion.MaxMin clMaxMin = new Capa_Conexion.MaxMin ();
            listRegistro = new List<string>();

            return clMaxMin.cargarMax (strInstancia , strDataBase , strTabla , strColumna);
        }

        public DataTable registroMenor(string strDataBase , string strColumna , string strTabla , String strInstancia) {
            Capa_Conexion.MaxMin clMaxMin = new Capa_Conexion.MaxMin ();
            listRegistro = new List<string> ();

            return clMaxMin.cargarMin (strInstancia , strDataBase , strTabla , strColumna);
        }
    }
}
