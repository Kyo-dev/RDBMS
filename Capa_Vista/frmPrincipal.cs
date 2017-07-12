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

        List<Capa_Negocios.CargarColumnas> listColum = new List<Capa_Negocios.CargarColumnas> ();
        public frmPrincipal() {
            InitializeComponent ();
            //dgvInfoTablas.Columns.Add ("TABLE_CATALOG","Catalogo");
            //dgvInfoTablas.Columns.Add ("TABLE_NAME","Nombre de la Tabla");
            //dgvInfoTablas.Columns.Add ("COLUMN_NAME","Nombre de la Columna");
            //dgvInfoTablas.Columns.Add ("DATA_TYPE","Tipo de dato");
            //dgvInfoTablas.Columns.Add ("COLUMN_DEFAULT","Valor por Defecto");
            //dgvInfoTablas.Columns.Add ("CHARACTER_MAXIMUM_LENGTH","Largo maximo");
        }

        private void frmPrincipal_Load(object sender,EventArgs e) {
            cboDataBases.DisplayMember = "DATABASE_NAME";
            cboDataBases.ValueMember = "DATABASE_NAME";
            cboDataBases.DataSource = new Capa_Negocios.CargarBases ().DataBases ();
        }

        private void btnCargar_Click(object sender,EventArgs e) {
            //FALTA LA VALIDACION POR SI LA BASE DE DATOS NO EXISTE
            DataTable objDT = new Capa_Negocios.CargarTablas ().Tablas (cboDataBases.SelectedValue.ToString ());
            lbTablas.ClearSelected ();
            if (objDT.Rows.Count > 0) {
                lbTablas.DisplayMember = "TABLE_NAME";
                lbTablas.ValueMember = "TABLE_NAME";
                lbTablas.DataSource = objDT;
                    
            } else {
                MessageBox.Show ("La base de datos selecciona no contiene tablas","Adverencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lbTablas.DataSource = objDT;
            }
        }

        private void lbTablas_DoubleClick(object sender,EventArgs e) {
            //dgvInfoTablas.DataSource = new Capa_Negocios.CargarColumnas ().datosColumnas (lbTablas.SelectedValue.ToString());
            DataTable objDT = new Capa_Negocios.CargarColumnas ().datosColumnas (lbTablas.SelectedValue.ToString ());
            lbColumas.ClearSelected ();
            if (objDT.Rows.Count > 0) {
                lbColumas.DisplayMember = "COLUMN_NAME";
                lbColumas.ValueMember = "COLUMN_NAME";
                lbColumas.DataSource = objDT;
            } else {
                MessageBox.Show ("La tabla selecciona no contiene columas","Adverencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lbTablas.DataSource = objDT;
            }
        }
    }
}