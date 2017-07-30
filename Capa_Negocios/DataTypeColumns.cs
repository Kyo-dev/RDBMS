using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace Capa_Negocios {
    class DataTypeColumns {
        #region Datatype Date
        public static bool canBeDate(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) {
                if(!Regex.IsMatch((String)row[dC], @"(?<!\d)(?:(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:(?:0[13578]|1[02])31)|(?:(?:0[1,3-9]|1[0-2])(?:29|30)))|(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))0229)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:0?[1-9])|(?:1[0-2]))(?:0?[1-9]|1\d|2[0-8]))(?!\d)")) {//Obviamente expresion regular de internet :v
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public static double porcentDate(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            int isDate = 0;
            foreach(DataRow row in dC.Table.Rows) {
                if(!Regex.IsMatch((String)row[dC], @"(?<!\d)(?:(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:(?:0[13578]|1[02])31)|(?:(?:0[1,3-9]|1[0-2])(?:29|30)))|(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))0229)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:0?[1-9])|(?:1[0-2]))(?:0?[1-9]|1\d|2[0-8]))(?!\d)")) {//Obviamente expresion regular de internet :v
                    isDate++;
                }
            }

            return intTotal / isDate * 100;
        }

        //public static bool convertColumnDate(String strTable, String strColumn, String instance, String database = "master") {

        //}
        #endregion

        #region Datatype INT
        public static bool canBeInt(DataColumn dC) {
            bool cantBe = true;
            foreach(DataRow row in dC.Table.Rows) { //Recorre cada registro.

                bool isNumber = true;
                foreach(char c in (String)row[dC]) { //Valida que cada char sea numerico
                    if(!Char.IsNumber(c)) {
                        isNumber = false;
                    }
                }

                Int64 num = Convert.ToInt64(row[dC]); //Necesito convertirlo a dato numero para la comprobar, se cambia al dato entero mas grande
                if((num < -2147483648 || num > 2147483648) && isNumber) { //Si el dato es completamente numerico verifico el tamaño INT (Ver tabla de tipos de datos en la pagina de Microsoft)
                    cantBe = false;
                }
            }
            return cantBe;
        }
        #endregion
    }
}
