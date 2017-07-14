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
        public frmPrincipal() {
            InitializeComponent ();
        }

        private void frmPrincipal_Load(object sender,EventArgs e) {
            cboDataBases.DataSource = new Capa_Negocios.CargarBases ().DataBases ();
            cboDataBases.DisplayMember = "DATABASE_NAME";
            cboDataBases.ValueMember = "DATABASE_NAME";
        }

        private void btnCargar_Click(object sender,EventArgs e) {
            DataTable objDT = new Capa_Negocios.CargarTablas ().Tablas (cboDataBases.SelectedValue.ToString ());
            lbTablas.ClearSelected ();
            lbColumas.ClearSelected ();
            if (objDT.Rows.Count > 0) {
                lbTablas.Enabled = true;
                lbColumas.Enabled = false;
                lbColumas.ClearSelected ();
                lbTablas.DataSource = objDT;
                lbTablas.DisplayMember = "TABLE_NAME";
                lbTablas.ValueMember = "TABLE_NAME";
                labNomBD.Text = "Base de Datos:\n" + cboDataBases.SelectedValue.ToString ();
            } else {
                MessageBox.Show ("La base de datos selecciona no contiene tablas","Adverencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lbTablas.Enabled = false;
                lbColumas.Enabled = false;
                labNomColum.Text = "";
                dgvInfoEsquema.ClearSelection ();
                lbTablas.ClearSelected ();
                lbColumas.ClearSelected ();
            }
        }

        private void lbTablas_DoubleClick(object sender,EventArgs e) {
            if (lbTablas.Enabled) {
                DataTable objDT = new Capa_Negocios.CargarColumnas ().datosColumnas (lbTablas.SelectedValue.ToString ());
                lbColumas.ClearSelected ();
                lbColumas.Enabled = true;
                if (objDT.Rows.Count > 0) {
                    lbColumas.DisplayMember = "COLUMN_NAME";
                    lbColumas.ValueMember = "COLUMN_NAME";
                    lbColumas.DataSource = objDT;
                    labNomTab.Text = "Columnas de la Tabla:\n" + lbTablas.SelectedValue.ToString ();
                } else {
                    MessageBox.Show ("La tabla selecciona no contiene columas","Adverencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lbTablas.DataSource = objDT;
                    lbColumas.Enabled = false;
                    labNomColum.Text = "";
                    lbColumas.ClearSelected ();
                    dgvInfoEsquema.ClearSelection ();
                }
            }
        }

        private void lbColumas_DoubleClick(object sender,EventArgs e) {
            DataTable objDT = new DataTable ();
            objDT = new Capa_Negocios.CargarEsquema ().Esquemas (lbColumas.SelectedValue.ToString (),lbTablas.SelectedValue.ToString ());
            if (lbColumas.Enabled) {
                if (objDT.Rows.Count > 0) {
                    dgvInfoEsquema.DataSource = objDT;
                    //verRegistros ();
                    labNomColum.Text = "Base de Datos: " + cboDataBases.SelectedValue.ToString () + "\nTabla seleccionada: " + lbTablas.SelectedValue.ToString () + "\nEsquema de columna: " + lbColumas.SelectedValue.ToString ();
                    labNomRegistros.Text = "Registros de la columna: " + lbTablas.SelectedValue.ToString ();
                } else {
                    MessageBox.Show ("Imposible obtener esquema de la tabla.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lbColumas.Enabled = false;
                    lbTablas.Enabled = false;
                    labNomColum.Text = "";
                    lbColumas.ClearSelected ();
                    lbTablas.ClearSelected ();
                    
                }
            }
        }

        private void verRegistros() {
            DataTable objDT = objDT = new Capa_Negocios.CargarRegistros ().registroColumna (lbColumas.SelectedValue.ToString (),lbTablas.SelectedValue.ToString ());
            if (lbColumas.Enabled) {
                if (objDT.Rows.Count > 0) {
                    dgvInfoRegistros.DataSource = objDT;
                }
            }
        }

        public void consultaColumna() {
            foreach (DataGridViewRow row in dgvInfoEsquema.Rows) {
                string nomTabla = Convert.ToString (row.Cells ["TABLE_NAME"].Value);
            }
            DataGridViewRow rows = dgvInfoEsquema.Rows [0];
            MessageBox.Show (Convert.ToString (rows.Cells ["TABLE_NAME"].Value));
        }
    }
}
