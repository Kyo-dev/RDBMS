using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista {
    public partial class frmLogin:Form {
        public frmLogin() {
            InitializeComponent ();
        }

        private void btnSalir_Click(object sender,EventArgs e) {
            Close ();
        }

        private void btnEntrar_Click(object sender,EventArgs e) {
            //faltan las validaciones
            DataTable objDT = new Capa_Negocios.CargarBases ().DataBases ();
            if (objDT.Rows.Count > 0) {
                this.Hide ();
                new frmPrincipal (objDT).Show ();
            } else {
                MessageBox.Show ("Error","Instancia no encontrada",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender,EventArgs e) {
            //Creo que este no deberia ir aqui sino el de las instancias 
            cboDataBase.DisplayMember = "DATABASE_NAME";
            cboDataBase.ValueMember = "DATABASE_NAME"; 
            cboDataBase.DataSource = new Capa_Negocios.CargarBases ().DataBases();
        }
    }
}
