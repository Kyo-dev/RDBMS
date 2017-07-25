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
        public frmPrincipal (String instanceName, Form login)
        {
            InitializeComponent();
            this.instanceName = instanceName;
            this.login = login;
        }

        public String instanceName { get; set; }
        public Form login { get; set; }

        private void frmPrincipal_Load (object sender, EventArgs e)
        {
            cboDataBases.DataSource = new Capa_Negocios.CargarBases().DataBases(instanceName);
            cboDataBases.DisplayMember = "DATABASE_NAME";
            cboDataBases.ValueMember = "DATABASE_NAME";
        }

        private void frmPrincipal_FormClosing (object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void btnCargar_Click (object sender, EventArgs e)
        {
            DataTable objDT = new Capa_Negocios.CargarTablas().Tablas(instanceName, cboDataBases.SelectedValue.ToString());
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
                    //lb = listBox
                    //lab = label
                    gb1.Text =  cboDataBases.SelectedValue.ToString();
                }
                else
                {
                    MessageBox.Show("La base de datos selecciona no contiene tablas", "Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbTablas.Enabled = false;
                    lbColumas.Enabled = false;
                    labNomColum.Text = "";
                    // limpiar textos falta :V
                    dgvInfoEsquema.ClearSelection();
                    lbTablas.ClearSelected();
                    lbColumas.ClearSelected();
                }
            }
        }

        private void lbTablas_DoubleClick (object sender, EventArgs e)
        {
            if (cboDataBases.SelectedItem != null && lbTablas.SelectedValue != null)
            {
                DataTable objDT = new Capa_Negocios.CargarColumnas().datosColumnas(lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
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
                    }
                    else
                    {
                        MessageBox.Show("La tabla selecciona no contiene columas", "Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //pequeño error
                        lbTablas.DataSource = objDT;
                        lbColumas.Enabled = false;
                        labNomColum.Text = "";
                        lbColumas.ClearSelected();
                        dgvInfoEsquema.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay tablas seleccionadas","Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        private void lbColumas_DoubleClick (object sender, EventArgs e)
        {
            if (lbTablas.SelectedItem != null)
            {
                DataTable objDT = new Capa_Negocios.CargarEsquema().Esquemas(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                if (lbColumas.Enabled)
                {
                    if (objDT.Rows.Count > 0)
                    {
                        dgvInfoEsquema.DataSource = objDT;
                        dgvInfoRegistros.DataSource = objDT;
                        labNomColum.Text = "Base de Datos: " + cboDataBases.SelectedValue.ToString() + "\nTabla seleccionada: " + lbTablas.SelectedValue.ToString() + "\nEsquema de columna: " + lbColumas.SelectedValue.ToString();
                        labNomRegistros.Text = "Registros de la columna: " + lbTablas.SelectedValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Imposible obtener esquema de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbColumas.Enabled = false;
                        lbTablas.Enabled = false;
                        labNomColum.Text = "";
                        lbColumas.ClearSelected();
                        lbTablas.ClearSelected();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void verRegistros ()
        {
            DataTable objDT = objDT = new Capa_Negocios.CargarRegistros().registroColumna(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString());
            if (lbColumas.Enabled)
            {
                if (objDT.Rows.Count > 0)
                {
                    dgvInfoRegistros.DataSource = objDT;
                }
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
    }
}

// hacer un metodo que limpie todos los label