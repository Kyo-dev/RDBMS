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

       DataTable objBase= new DataTable();

        public frmPrincipal(DataTable objBase) {

            InitializeComponent ();
        }
        private void frmPrincipal_Load(object sender,EventArgs e) {
          
            Capa_Negocios.CargarTablas CargarTablas = new Capa_Negocios.CargarTablas();

            objBase = CargarTablas.Tablas();
            lbTablas.DataSource = objBase;
         
        }

        private void lbTablas_SelectedIndexChanged (object sender, EventArgs e)
        {

        }
    }
}
