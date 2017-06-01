using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Conexion {
    /*
     * Principales comandos para las consulas a la base de datos.
     *sp_columns
     *sp_database
     */

    class Conexion {

        SqlConnection objConexion = new SqlConnection ("FALTA ES STRING DE CONEXION");

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
    }
}
