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
                    //lb = listBox
                    //lab = label
                }
                else
                {
                    MessageBox.Show("La base de datos selecciona no contiene tablas", "Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbTablas.Enabled = false;
                    lbColumas.Enabled = false;
                    labDataBase.Text = "";
                    // limpiar textos falta :V
                    dgvInfoEsquema.ClearSelection();
                    lbTablas.ClearSelected();
                    lbColumas.ClearSelected();
                }
            }
        }

        private async void lbTablas_DoubleClick (object sender, EventArgs e)
        {
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
                        MessageBox.Show("La tabla selecciona no contiene columas", "Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No hay tablas seleccionadas","Adverencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private async void lbColumas_DoubleClick (object sender, EventArgs e)
        {
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
                        MessageBox.Show("Imposible obtener esquema de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Seleccione una base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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