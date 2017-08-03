using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Capa_Vista {
    public partial class frmPorcentajes : MetroForm {
        public frmPorcentajes(DataColumn dC, String database, String instance) {
            this.dC = dC;
            InitializeComponent();
            this.database = database;
            this.instance = instance;
        }

        private DataColumn dC;
        private String database;
        private String instance;

        private void frmPorcentajes_Load(object sender, EventArgs e) {
            //Capa_Negocios.DataTypeColumns op = new Capa_Negocios.DataTypeColumns();
            //lbChar.Text = "Char: " + op.porcentChar(this.dC) + "%";
            //lbSmallint.Text = "Smallint: " + op.porcentSmallInt(this.dC) + "%";
            //lbTinyint.Text = "Tinyint: " + op.porcenTinyInt(this.dC) + "%";
            //lbDate.Text = "DateTime: " + op.porcentDate(this.dC) + "%";
            //lbInt.Text = "Int: " + op.porcentInt(this.dC) + "%";
        }

        private void btnEject_Click(object sender, EventArgs e) {
            if(!new Capa_Negocios.DataTypeColumns().ejecCMD(txtConsult.Text.Trim(), database, instance)) {
                frmMessageBoxError.Show("No se pudo ejecutar la sentencia, ¿Esta bien escrita?");
            } else {
                MetroFramework.MetroMessageBox.Show(this, "Consulta ejecutada correctamente");
            }
        }
    }
}
