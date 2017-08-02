using MetroFramework.Forms;
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
    public partial class frmMessageBoxError : MetroForm {
        public frmMessageBoxError(String strMessage) {
            InitializeComponent ();
            lbMsg.Text = strMessage;
        }

        public static void Show(String strMensaje) {
            new frmMessageBoxError (strMensaje).ShowDialog ();
        }

        private void btnCancel_Click(object sender , EventArgs e) {
            this.Close ();
        }
    }
}