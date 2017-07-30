using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocios {
    public class clsTables {
        public Task<DataTable> loadRegisters(String strTable, String strInstanceName, String strDataBase = "master") {
            return Task.Run(() => {
                return new Capa_Conexion.clsTables().loadRegisters(strTable, strInstanceName, strDataBase);
            });
        }

        public Task<DataTable> getTables(String strInstanceName, String strDatabase = "master") {
            return Task.Run(() => {
                Capa_Conexion.TablasBD clCargarTablas = new Capa_Conexion.TablasBD();
                DataTable oDT = clCargarTablas.CargarTablas(strInstanceName, strDatabase);

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
            });
        }
    }
}
