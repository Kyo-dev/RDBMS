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

        public static DataTable objBase;

        public frmPrincipal(DataTable objBase) {
            InitializeComponent ();
        }
        private void frmPrincipal_Load(object sender,EventArgs e) {
            Capa_Negocios.CargarTablas cs_CargarTablas = new Capa_Negocios.CargarTablas ();
            objBase = cs_CargarTablas.Tablas (lbTablas.SelectedValue.ToString ());
            lbTablas.DisplayMember = "Tablas";
            lbTablas.ValueMember = "Tablas";
            lbTablas.DataSource = objBase;
        }
    }
}
