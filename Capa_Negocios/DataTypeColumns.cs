using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace Capa_Negocios {
    public class DataTypeColumns {
        #region Datatype Date
        public bool canBeDate(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) {
                if(!Regex.IsMatch(Convert.ToString(row[dC]), @"(?<!\d)(?:(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:(?:0[13578]|1[02])31)|(?:(?:0[1,3-9]|1[0-2])(?:29|30)))|(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))0229)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:0?[1-9])|(?:1[0-2]))(?:0?[1-9]|1\d|2[0-8]))(?!\d)^")) {//Obviamente expresion regular de internet :v
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public double porcentDate(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            int isDate = 0;
            double douResultado;
            foreach(DataRow row in dC.Table.Rows) {
                if(Regex.IsMatch(Convert.ToString(row[dC]), @"(?<!\d)(?:(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:(?:0[13578]|1[02])31)|(?:(?:0[1,3-9]|1[0-2])(?:29|30)))|(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))0229)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:0?[1-9])|(?:1[0-2]))(?:0?[1-9]|1\d|2[0-8]))(?!\d)^")) {//Obviamente expresion regular de internet :v
                    isDate++;
                }
            }
            if(isDate == 0) return 0;
            return douResultado = intTotal / isDate * 100;
        }

        #endregion

        #region Datatype INT
        public bool canBeInt(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) { //Recorre cada registro.

                bool isNumber = true;
                foreach(char c in Convert.ToString(row[dC])) { //Valida que cada char sea numerico
                    if(!Char.IsNumber(c)) {
                        isNumber = false;
                    }
                }

                Int64 num = Convert.ToInt64(Convert.ToString(row[dC])); //Necesito convertirlo a dato numero para la comprobar, se cambia al dato entero mas grande
                if((num < -2147483648 || num > 2147483648) && isNumber) { //Si el dato es completamente numerico verifico el tamaño INT (Ver tabla de tipos de datos en la pagina de Microsoft)
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public double porcentInt(DataColumn dC) {
            int douTotal = dC.Table.Rows.Count;
            int isInt = 0;
            foreach(DataRow row in dC.Table.Rows) { //Recorre cada registro.

                bool isNumber = true;
                foreach(char c in Convert.ToString(row[dC])) { //Valida que cada char sea numerico
                    if(!Char.IsNumber(c)) {
                        isNumber = false;
                    }
                }

                if(isNumber) {
                    Int64 num = Convert.ToInt64(Convert.ToString(row[dC])); //Necesito convertirlo a dato numero para la comprobar, se cambia al dato entero mas grande
                    if((num < -2147483648 || num > 2147483648) && isNumber) { //Si el dato es completamente numerico verifico el tamaño INT (Ver tabla de tipos de datos en la pagina de Microsoft)
                        isInt++;
                    }
                }
            }
            if(isInt == 0) return 0;
            return isInt * 100 / douTotal;
        }

        #endregion

        #region DataType TinyInt
        public bool canBeTinyInt(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) {
                bool isNumber = true;
                foreach(char c in Convert.ToString(row[dC])) {
                    if(!Char.IsNumber(c) && row[dC] != null) {
                        isNumber = false;
                    }
                }
                Int64 num = Convert.ToInt64(Convert.ToString(row[dC]));
                if((num < 0 || num > 255) && isNumber) {
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public double porcenTinyInt(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            int isTiniIny = 0;
            foreach(DataRow row in dC.Table.Rows) {
                bool isNumber = true;
                foreach(char c in Convert.ToString(row[dC])) {
                    if(!Char.IsNumber(c)) {
                        isNumber = false;
                    }
                }
                if(isNumber) {
                    isTiniIny++;
                }
            }
            if(isTiniIny == 0) return 0;
            return isTiniIny * 100 / intTotal;
        }
        #endregion

        #region DataType SmallInt
        public bool canBeSmallInt(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) {

                bool isNumber = true;
                foreach(char c in (String)row[dC]) {
                    if(!Char.IsNumber(c) && row[dC] != null) {
                        isNumber = false;
                    }

                }
                Int64 num = Convert.ToInt64(row[dC]);
                if((num < Convert.ToInt16(-32.767) || num > 32.767) && isNumber) {
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public double porcentSmallInt(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            int isSmallInt = 0;
            foreach(DataRow row in dC.Table.Rows) {
                bool isNumber = true;
                foreach(char c in Convert.ToString(row[dC])) {
                    if(!Char.IsNumber(c)) {
                        isNumber = false; 
                    }
                }
                if(isNumber) {
                    isSmallInt++;
                }
            }
            if(isSmallInt == 0) return 0;
            return isSmallInt * 100 / intTotal;
        }
        #endregion

        #region DataType Char
        public bool canbeChar(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) {
                if(Convert.ToString(row[dC]).Length != 1 && (Convert.ToString(row[dC]) != "true" && Convert.ToString(row[dC]) != "false")) {
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public double porcentChar(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            int isChar = 0;
            foreach(DataRow row in dC.Table.Rows) {
                if((Convert.ToString(row[dC])).Length == 1) {
                    isChar++;
                }
            }
            if(isChar == 0) return 0;
            return isChar * 100 / intTotal;
        }
        #endregion

        #region Max y Min
        public Task<DataTable> SelectMax(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return Task.Run(() => {
                return new Capa_Conexion.DataTypeColumns().SelectMax(strColumn, strTable, instanceName, strDataBase); 
            });
        }

        public Task<DataTable> SelectMin(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return Task.Run(() => {
                return new Capa_Conexion.DataTypeColumns().SelectMin(strColumn, strTable, instanceName, strDataBase);
            });
        }
        #endregion

        #region ChangeDataType
        public bool ChangeToINT(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return new Capa_Conexion.DataTypeColumns().ChangeDataType("INT", strColumn, strTable, instanceName, strDataBase);
        }

        public bool ChangeToDate(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return new Capa_Conexion.DataTypeColumns().ChangeDataType("DATETIME", strColumn, strTable, instanceName, strDataBase);
        }

        public bool ChangeToByte(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return new Capa_Conexion.DataTypeColumns().ChangeDataType("BYTE", strColumn, strTable, instanceName, strDataBase);
        }

        public bool ChangeToSmallINT(String strColumn, String strTable, String instanceName, String strDataBase = "master") {
            return new Capa_Conexion.DataTypeColumns().ChangeDataType("BYTE", strColumn, strTable, instanceName, strDataBase);
        }
        #endregion

        public bool ejecCMD(String CMD, String database, String instance) {
            return new Capa_Conexion.clsConnection(instance, database).CMD(new System.Data.SqlClient.SqlCommand(CMD));
        }
    }
}
