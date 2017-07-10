using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista {
    public partial class frmPrincipal:Form {

        //DataTable objBase= new DataTable();

        public frmPrincipal() {
            InitializeComponent ();
        }

        private void frmPrincipal_Load(object sender,EventArgs e) {
            cboDataBases.DisplayMember = "DATABASE_NAME";
            cboDataBases.ValueMember = "DATABASE_NAME";
            cboDataBases.DataSource = new Capa_Negocios.CargarBases ().DataBases ();
        }

        private void btnCargar_Click(object sender,EventArgs e) {
            //FALTA LA VALIDACION POR SI LA BASE DE DATOS NO EXISTE
            DataTable objDT = new Capa_Negocios.CargarTablas ().Tablas (cboDataBases.SelectedValue.ToString ());
            lbTablas.ClearSelected ();
            if (objDT.Rows.Count > 0) {
                lbTablas.DisplayMember = "TABLE_NAME";
                lbTablas.ValueMember = "TABLE_NAME";
                lbTablas.DataSource = objDT;
            } else {
                MessageBox.Show ("La base de datos selecciona no contiene tablas","Adverencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lbTablas.DataSource = objDT;
            }
        }
    }
}