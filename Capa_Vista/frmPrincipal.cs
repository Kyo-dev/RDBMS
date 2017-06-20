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
    public partial class frmPrincipal:Form {

        public static DataTable objBase;

        public frmPrincipal( DataTable objBase) {
            InitializeComponent ();
            frmPrincipal.objBase = objBase;
            
        }
        private void frmPrincipal_Load(object sender,EventArgs e) {

        }
    }
}
