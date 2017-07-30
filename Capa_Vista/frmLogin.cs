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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin() {
            InitializeComponent ();
        }


        private async void btnCargar_Click (object sender, EventArgs e)
        {
            cboInstancias.DataSource = await new Capa_Negocios.clsDatabases().getInstancesName();
        }

        private async void btnEntrar_Click (object sender, EventArgs e)
        {
            if (cboInstancias.Text.ToString().Trim() != String.Empty)
            {
                if (await new Capa_Negocios.clsDatabases().conecctionTest(cboInstancias.Text.ToString().Trim()))
                {
                    this.Hide();
                    new frmPrincipal(cboInstancias.Text.ToString(), this).Show();
                }
                else
                {
                    MessageBox.Show(this, "Conexión erronea, verifique el nombre de la instancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Por favor, ingrese o seleccione una instancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}