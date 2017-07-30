﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion {
    public class clsTables {

        public DataTable loadRegisters(String strTable, String instanceName, String database = "master") {
            SqlCommand oCM = new SqlCommand(String.Format("SELECT * FROM {0}", strTable));
            oCM.CommandType = CommandType.Text;
            return new clsConnection(instanceName: instanceName, database: database).Select(oCM, database);
        }

        public DataTable getTables(String instanceName, String var = "master") {
            SqlCommand objSQL = new SqlCommand();
            objSQL.CommandType = CommandType.Text;
            objSQL.CommandText = "sp_Tables";
            return new clsConnection(instanceName, var).Select(objSQL);
        }
    }
}
