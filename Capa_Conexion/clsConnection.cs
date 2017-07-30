using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Capa_Conexion {

    public class clsConnection {

        //CUANDO VAYA A PROGRAMAR DESCOMENTE LA SUYA Y COMENTE LA MIA NO LA BORRE  >:V

        SqlConnection objConexion;//Cadena personalizada para que haga todas las consultas a la base de datos que se escogió

        //SqlConnection objConexion = new SqlConnection ("Data Source=DESKTOP-JJF4ANO\\SQLEXPRESS;Integrated Security=True");

        public clsConnection(String instanceName, String database = "master") {
            objConexion = new SqlConnection(String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", instanceName, database));
        }

        public bool openConnection() {
            try {
                objConexion.Open();
                return true;
            } catch(Exception) {
                return false;
                throw;
            }
        }

        public bool closeConnection() {
            try {
                if(objConexion.State == ConnectionState.Closed) {
                    return true;
                }
                objConexion.Close();
                return true;
            } catch(Exception) {

                throw;
            } finally {
                objConexion.Close();
            }
        }

        public DataTable Select(SqlCommand oSQLC, String database = "master") {

            try {
                oSQLC.Connection = objConexion;
                DataTable oDT = new DataTable();
                SqlDataAdapter oSQLDA = new SqlDataAdapter(oSQLC);

                if(openConnection()) {
                    oSQLDA.Fill(oDT);
                }
                closeConnection();

                return oDT;

            } catch(SqlException e) {
                throw e;
            }
            // fin del try/catch
        }

    }
}