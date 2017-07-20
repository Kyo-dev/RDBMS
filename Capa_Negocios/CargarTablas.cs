using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios {
    public class CargarTablas {

        public DataTable Tablas(String var = "master") {
            Capa_Conexion.TablasBD clCargarTablas = new Capa_Conexion.TablasBD ();
            DataTable oDT =  clCargarTablas.CargarTablas (var);
            List<DataRow> deleteRows = new List<DataRow>();
            foreach(DataRow item in oDT.Rows) {
                if(item["TABLE_OWNER"].ToString() != "dbo") {
                    deleteRows.Add(item);
                }
            }

            foreach(var item in deleteRows) {
                oDT.Rows.Remove(item);
            }
            return oDT;
        }
    }
}