using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Capa_Conexion {
    /*
     * Principales comandos para las consulas a la base de datos.
     *sp_columns
     *sp_database
     */

    public class Conexion {

        SqlConnection objConexion = new SqlConnection ("Data Source=RIN\\SQL2016;Integrated Security=True");

        public bool abrirConexion() {
            try {
                objConexion.Open();
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
        public DataTable cargarBases() {
            abrirConexion ();
            SqlCommand SqlCom = new SqlCommand ();
            SqlCom.Connection = objConexion;
            SqlCom.CommandType = CommandType.StoredProcedure;
            SqlCom.CommandText = "sp_databases";
            SqlDataReader sqlDt;
            sqlDt = SqlCom.ExecuteReader ();
            DataTable Dt = new DataTable ();
            Dt.Rows.Add (sqlDt.GetString (0));
            cerrarConexion ();
            return Dt;
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
            }// fin del try/catch
        }
    }
}