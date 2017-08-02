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

namespace Capa_Vista
{

    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public String instanceName { get; set; }
        public Form login { get; set; }


        public frmPrincipal (String instanceName, Form login)
        {
            InitializeComponent();
            this.instanceName = instanceName;
            this.login = login;
        }

        private async void frmPrincipal_Load (object sender, EventArgs e)
        {
            cboDataBases.DataSource = await new Capa_Negocios.clsDatabases().getDatabases(instanceName);
            cboDataBases.DisplayMember = "DATABASE_NAME";
            cboDataBases.ValueMember = "DATABASE_NAME";
        }

        private void frmPrincipal_FormClosing (object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private async void btnCargar_Click (object sender, EventArgs e)
        {
            frmMessageBoxError frmError = new frmMessageBoxError ("Error... ");
            DataTable objDT = await new Capa_Negocios.clsTables().getTables(instanceName, cboDataBases.SelectedValue.ToString());
            lbTablas.ClearSelected();
            lbColumas.ClearSelected();
            if (cboDataBases.Enabled)
            {
                if (objDT.Rows.Count > 0)
                {
                    lbTablas.Enabled = true;
                    lbColumas.Enabled = false;
                    lbColumas.ClearSelected();
                    lbTablas.DataSource = objDT;
                    lbTablas.DisplayMember = "TABLE_NAME";
                    lbTablas.ValueMember = "TABLE_NAME";
                }
                else
                {
                    if (await new Capa_Negocios.clsTables ().getTables (instanceName , cboDataBases.SelectedValue.ToString ()) == null) {
                        frmError.Close ();
                        frmMessageBoxError.Show ("Error");
                    }

                    frmMessageBoxError.Show("La base de datos selecciona no contiene tablas");
                    lbTablas.Enabled = false;
                    lbColumas.Enabled = false;
                    labDataBase.Text = "";
                    dgvInfoEsquema.ClearSelection();
                    lbTablas.ClearSelected();
                    lbColumas.ClearSelected();
                }
            }
        }

        private async void lbTablas_DoubleClick (object sender, EventArgs e)
        {
            frmMessageBoxError frmError = new frmMessageBoxError ("Error...  ");
            if (cboDataBases.SelectedItem != null && lbTablas.SelectedValue != null)
            {
                DataTable objDT = await new Capa_Negocios.clsColumns().getColumns(lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                
                if (lbTablas.Enabled)
                {
                    if (objDT.Rows.Count > 0)
                    {

                        lbColumas.ClearSelected();
                        lbColumas.Enabled = true;
                        lbColumas.DisplayMember = "COLUMN_NAME";
                        lbColumas.ValueMember = "COLUMN_NAME";
                        lbColumas.DataSource = objDT;
                        labNomTab.Text = "Columnas de la Tabla:\n" + lbTablas.SelectedValue.ToString();
                        dgvInfoRegistros.DataSource = await new Capa_Negocios.clsTables().loadRegisters(lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                        labCantRegistros.Text = "Cantidad de registros: " + dgvInfoRegistros.Rows.Count;
                    }
                    else
                    {
                        if (await new Capa_Negocios.clsTables ().loadRegisters (lbTablas.SelectedValue.ToString (), instanceName , cboDataBases.SelectedValue.ToString ())== null) {
                            frmError.Close ();
                            frmMessageBoxError.Show ("Error");
                        }
                        //pequeño error
                        lbTablas.DataSource = objDT;
                        lbColumas.Enabled = false;
                        labDataBase.Text = "";
                        lbColumas.ClearSelected();
                        dgvInfoEsquema.ClearSelection();
                    }
                }
            }
            else
            {
                frmMessageBoxError.Show ("Seleccione una base de datos");
                frmError.Close ();
            }
        }

        private async void lbColumas_DoubleClick (object sender, EventArgs e)
        {
            frmMessageBoxError frmError = new frmMessageBoxError ("Error... ");
            if (lbTablas.SelectedItem != null)
            {
                DataTable objDT = await new Capa_Negocios.clsColumns().EsquemeInfo(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                if (lbColumas.Enabled)
                {
                    if (objDT.Rows.Count > 0)
                    {
                        dgvInfoEsquema.DataSource = objDT;
                        labDataBase.Text = "Base de Datos: " + cboDataBases.SelectedValue.ToString();
                        labTable.Text = "Tabla seleccionada: " + lbTablas.SelectedValue.ToString();
                        labEsquema.Text = "Esquema de columna: " + lbColumas.SelectedValue.ToString();
                        labNomRegistros.Text = "Registros de la columna: " + lbTablas.SelectedValue.ToString();
                    }
                    else
                    {
                        if (await new Capa_Negocios.clsColumns ().EsquemeInfo (lbColumas.SelectedValue.ToString () , lbTablas.SelectedValue.ToString () , instanceName , cboDataBases.SelectedValue.ToString ()) == null) {
                            frmError.Close ();
                            frmMessageBoxError.Show ("Error");
                        }
                        frmMessageBoxError.Show("Imposible obtener esquema de la tabla.");
                        lbColumas.Enabled = false;
                        lbTablas.Enabled = false;
                        labDataBase.Text = "";
                        lbColumas.ClearSelected();
                        lbTablas.ClearSelected();
                    }
                }
            }
            else
            {
                frmMessageBoxError.Show ("Seleccione una base de datos.");

            }

        }

        public void consultaColumna ()
        {
            foreach (DataGridViewRow row in dgvInfoEsquema.Rows)
            {
                string nomTabla = Convert.ToString(row.Cells["TABLE_NAME"].Value);
            }
            DataGridViewRow rows = dgvInfoEsquema.Rows[0];
            MessageBox.Show(Convert.ToString(rows.Cells["TABLE_NAME"].Value));
        }

        private void groupBox5_Enter (object sender, EventArgs e)
        {

        }
    }
}

// hacer un metodo que limpie todos los label