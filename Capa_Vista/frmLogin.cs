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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin() {
            InitializeComponent ();
        }

        private void btnSalir_Click(object sender,EventArgs e) {
            Close ();
        }

        private void btnEntrar_Click(object sender,EventArgs e) {
            if(cboInstancias.Text.ToString() != String.Empty) {
                if(new Capa_Negocios.CargarInstancias().conecctionTest(cboInstancias.Text.ToString())) {
                    MessageBox.Show(this, "Conexión existosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    new frmPrincipal(cboInstancias.Text.ToString(), this).Show();
                    this.Hide();
                } else {
                    MessageBox.Show(this, "Conexión erronea, verifique el nombre de la instancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show(this, "Por favor, ingrese o seleccione una instancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInstancias_Click(object sender, EventArgs e) {
            cboInstancias.DataSource = new Capa_Negocios.CargarInstancias().cargarInstancia();
        }
    }
}