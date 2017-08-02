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
            foreach (DataRow row in dC.Table.Rows) {
                if (!Regex.IsMatch ((String) row[dC] , @"(?<!\d)(?:(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:(?:0[13578]|1[02])31)|(?:(?:0[1,3-9]|1[0-2])(?:29|30)))|(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))0229)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:0?[1-9])|(?:1[0-2]))(?:0?[1-9]|1\d|2[0-8]))(?!\d)")) {//Obviamente expresion regular de internet :v
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public static double porcentDate(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            int isDate = 0;
            foreach (DataRow row in dC.Table.Rows) {
                if (!Regex.IsMatch ((String) row[dC] , @"(?<!\d)(?:(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:(?:0[13578]|1[02])31)|(?:(?:0[1,3-9]|1[0-2])(?:29|30)))|(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))0229)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(?:(?:0?[1-9])|(?:1[0-2]))(?:0?[1-9]|1\d|2[0-8]))(?!\d)")) {//Obviamente expresion regular de internet :v
                    isDate++;
                }
            }

            return intTotal / isDate * 100;
        }

        //public static bool convertColumnDate(String strTable, String strColumn, String instance, String database = "master") {

        //}
        #endregion

        #region Datatype INT
        public bool canBeInt(DataColumn dC) {
            bool cantBe = true;
            foreach (DataRow row in dC.Table.Rows) { //Recorre cada registro.

                bool isNumber = true;
                foreach (char c in (String) row[dC]) { //Valida que cada char sea numerico
                    if (!Char.IsNumber (c)) {
                        isNumber = false;
                    }
                }

                Int64 num = Convert.ToInt64 (row[dC]); //Necesito convertirlo a dato numero para la comprobar, se cambia al dato entero mas grande
                if ((num < -2147483648 || num > 2147483648) && isNumber) { //Si el dato es completamente numerico verifico el tamaño INT (Ver tabla de tipos de datos en la pagina de Microsoft)
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public static double porcentInt(DataColumn dC) {
            int intTotal = dC.Table.Rows.Count;
            double isInt = 0;
            foreach (DataRow row in dC.Table.Rows) { //Recorre cada registro.
                foreach (char c in (String) row[dC]) { //Valida que cada char sea numerico
                    if (!Char.IsNumber (c)) {
                        isInt++;
                    }
                }
            }
            return intTotal / isInt * 100;
        }

        #endregion

        #region DataType Byte
        public bool canBeByte(DataColumn dC) {
            bool cantBe = true;
            foreach (DataRow row in dC.Table.Rows) { //Recorre cada registro.

                if (!row.Equals (1) && !row.Equals (0)) {
                    cantBe = false;
                }
            }
            return cantBe;
        }

        public static double porcenByte (DataColumn dC){
            int intTotal = dC.Table.Rows.Count;
            int isByte = 0;
            foreach (DataRow row in dC.Table.Rows) {
                if (!row.Equals(1) && !row.Equals(0)) {
                    isByte++;
                }
            }
            return intTotal / isByte * 100;
        }

        #endregion

        #region DataType TinyInt
        public bool canBeTinyInt(DataColumn dC) {
            bool cantBe = true;
            foreach (DataRow row in dC.Table.Rows) {
                bool isNumber = true;
                foreach (char c in (String) row[dC]) {
                    if (!Char.IsNumber (c)) {
                        isNumber = false;
                    }
                }
                Int64 num = Convert.ToInt64 (row[dC]);
                if ((num < 0 || num > 255) && isNumber) {
                    cantBe = false;
                }
            }
            return cantBe;
        }
        #endregion

        #region DataType SmallInt
        public bool canBeSmallInt(DataColumn dC) {
            bool cantBe = true;
            foreach (DataRow row in dC.Table.Rows) {

                bool isNumber = true;
                foreach (char c in (String) row[dC]) {
                    if (!Char.IsNumber (c)) {
                        isNumber = false;

                    }

                }
                Int64 num = Convert.ToInt64 (row[dC]);
                if ((num < Convert.ToInt16 (-32.767) || num > 32.767) && isNumber) {
                    cantBe = false;
                }
            }
            return cantBe;
        }
        #endregion

        #region Max y Min
        public String SelectMax(String strColumn , String strTable , String instanceName , String strDataBase = "master") {
            return
                    }
        #endregion

    }
}

