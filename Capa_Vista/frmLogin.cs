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
            frmPrincipal frm = new frmPrincipal ();
            frm.Show ();
            this.Hide (); 
        }

    }
}
