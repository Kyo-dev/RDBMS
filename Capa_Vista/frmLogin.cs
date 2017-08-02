using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista {
    public partial class frmLogin : MetroFramework.Forms.MetroForm {
        public frmLogin() {
            InitializeComponent();
        }


        private async void btnCargar_Click(object sender, EventArgs e) {
            frmLoad frm = new frmLoad ("Cargando instancias...");
            cboInstancias.DataSource = await new Capa_Negocios.clsDatabases().getInstancesName();
            frm.Close ();
        }
        //kas

        private async void btnEntrar_Click(object sender, EventArgs e) {
            frmMessageBoxError frmError = new frmMessageBoxError ("Error");
            if(cboInstancias.Text.ToString().Trim() != String.Empty) {
                if(await new Capa_Negocios.clsDatabases().conecctionTest(cboInstancias.Text.ToString().Trim())) {
                    this.Hide();
                    new frmPrincipal(cboInstancias.Text.ToString(), this).Show();
                } else {
                    frmMessageBoxError.Show("Conexión erronea, verifique el nombre de la instancia");
                }
            } else {
                frmMessageBoxError.Show ("Por favor, ingrese o seleccione una instancia");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}