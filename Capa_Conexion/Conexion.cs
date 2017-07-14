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

        SqlConnection objConexion = new SqlConnection ("Data Source=RIN\\SQL2016;Initial Catalog=AdventureWorks2014;Integrated Security=True");
        //SqlConnection objConexion = new SqlConnection ("Data Source=DESKTOP-JJF4ANO\\SQLEXPRESS;Integrated Security=True");

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

        public DataTable ejecutarRutina(SqlCommand oSQLC) {

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

        public DataTable ejecutar(String txtSelect) {
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