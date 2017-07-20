using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Capa_Conexion {

    public class Conexion {

        //CUANDO VAYA A PROGRAMAR DESCOMENTE LA SUYA Y COMENTE LA MIA NO LA BORRE  >:V

        SqlConnection objConexion;//Cadena personalizada para que haga todas las consultas a la base de datos que se escogió

        public DataTable instancias() {
           return SqlDataSourceEnumerator.Instance.GetDataSources();    
        }

        //SqlConnection objConexion = new SqlConnection ("Data Source=DESKTOP-JJF4ANO\\SQLEXPRESS;Integrated Security=True");

        public Conexion(String instanceName, String var = "master") {
            objConexion = new SqlConnection("Data Source="+instanceName+";Initial Catalog=" + var + ";Integrated Security=True");
        }

        public bool abrirConexion() {
            try {
                objConexion.Open ();
                return true;
            } catch (Exception) {
                return false;
                throw;
            }
        }

        public bool cerrarConexion() {
            try {
                if (objConexion.State == ConnectionState.Closed) {
                    return true;
                }
                objConexion.Close ();
                return true;
            } catch (Exception) {

                throw;
            } finally {
                objConexion.Close ();
            }
        }

        public DataTable ejecutarRutina(SqlCommand oSQLC, String var = "master") {

            try {
                oSQLC.Connection = objConexion;
                DataTable oDT = new DataTable ();
                SqlDataAdapter oSQLDA = new SqlDataAdapter (oSQLC);

                if (abrirConexion ()) {
                    oSQLDA.Fill (oDT);
                }
                cerrarConexion ();

                return oDT;

            } catch (SqlException e) {
                throw e;
            }
            // fin del try/catch
        }

        public DataTable ejecutar(String txtSelect, String var = "master") {
            SqlCommand cSelect = new SqlCommand ();
            DataTable oDT = new DataTable ();
            SqlDataAdapter oSQLDA = new SqlDataAdapter (cSelect);

            try {
                cSelect.CommandText = txtSelect;
                cSelect.Connection = objConexion;
            } catch (Exception) {

                throw;
            }
            if (abrirConexion ()) {
                oSQLDA.Fill (oDT);
            }
            cerrarConexion ();

            return oDT;
        }
    }
}