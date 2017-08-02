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

    public partial class frmPrincipal : MetroFramework.Forms.MetroForm {
        public String instanceName { get; set; }
        public Form login { get; set; }


        public frmPrincipal(String instanceName, Form login) {
            InitializeComponent();
            this.instanceName = instanceName;
            this.login = login;
        }

        private async void frmPrincipal_Load(object sender, EventArgs e) {
            cboDataBases.DataSource = await new Capa_Negocios.clsDatabases().getDatabases(instanceName);
            cboDataBases.DisplayMember = "DATABASE_NAME";
            cboDataBases.ValueMember = "DATABASE_NAME";
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            login.Show();
        }

        private async void btnCargar_Click(object sender, EventArgs e) {
            frmLoad frm = new frmLoad ("Cargando bases de datos... ");
            DataTable objDT = await new Capa_Negocios.clsTables().getTables(instanceName, cboDataBases.SelectedValue.ToString());
            frm.Close ();
            lbTablas.DataSource = null;
            lbColumas.DataSource = null;
            if (cboDataBases.Enabled)
            {
                if (objDT.Rows.Count > 0)
                {

                    lbTablas.Enabled = true;
                    lbColumas.Enabled = false;
                    lbColumas.Items.Clear();
                    lbTablas.DataSource = objDT;
                    lbTablas.DisplayMember = "TABLE_NAME";
                    lbTablas.ValueMember = "TABLE_NAME";
                } else {
                    if(objDT == null) {
                        frmMessageBoxError.Show("Error");
                    }

                    frmMessageBoxError.Show("La base de datos selecciona no contiene tablas");
                    lbTablas.Enabled = false;
                    lbColumas.Enabled = false;
                    labDataBase.Text = String.Empty;
                    lbTablas.Items.Clear();
                    lbColumas.Items.Clear();
                }
            }
        }

        private async void lbTablas_DoubleClick(object sender, EventArgs e) {
            if (cboDataBases.SelectedItem != null && lbTablas.SelectedValue != null) {
                limpiar ();
                frmLoad frm = new frmLoad ("Cargando columnas... ");
                DataTable objDT = await new Capa_Negocios.clsColumns().getColumns(lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                frm.Close ();
                if (objDT is null) {
                    frmMessageBoxError.Show ("Error al cargar las columnas");
                    return;
                }
                if (lbTablas.Enabled)
                {
                    if (objDT.Rows.Count > 0)
                    {
                        lbColumas.ClearSelected();
                        lbColumas.Enabled = true;
                        lbColumas.DisplayMember = "COLUMN_NAME";
                        lbColumas.ValueMember = "COLUMN_NAME";
                        lbColumas.DataSource = objDT;
                        DataTable Dt =  await new Capa_Negocios.clsTables().loadRegisters(lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                        dgvInfoRegistros.DataSource = Dt;
                        labCantRegistros.Text = "Cantidad de registros: " + dgvInfoRegistros.Rows.Count;
                    } else {
                        lbTablas.DataSource = objDT;
                        lbColumas.Enabled = false;
                        labDataBase.Text = "";
                        lbColumas.DataSource = null;
                    }
                }
            } else {
                frmMessageBoxError.Show("Seleccione una base de datos");
            }
        }

        private async void lbColumas_DoubleClick(object sender, EventArgs e) {
            if(lbTablas.SelectedItem != null) {
                frmLoad frm = new frmLoad ("Cargando esquema... ");
                DataTable objDT = await new Capa_Negocios.clsColumns().EsquemeInfo(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                frm.Close ();
                if(lbColumas.Enabled) {
                    if(objDT.Rows.Count > 0) {
                        labDataBase.Text = "Base de Datos: " + cboDataBases.SelectedValue.ToString();
                        labTable.Text = "Tabla seleccionada: " + lbTablas.SelectedValue.ToString();
                        labEsquema.Text = "Esquema de columna: " + lbColumas.SelectedValue.ToString();
                        DataTable minimo = await new Capa_Negocios.DataTypeColumns().SelectMin(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                        if(minimo is null) {
                            frmMessageBoxError.Show("Error al extraer dato minimo, es correcto el tipo de dato?");
                            return;
                        }
                        labMin.Text = "Dato Mínimo: " + Convert.ToString(minimo.Rows[0]["Minimo"]);

                        DataTable maximo = await new Capa_Negocios.DataTypeColumns().SelectMax(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString());
                        if(maximo is null) {
                            frmMessageBoxError.Show("Error al extraer dato máximo, es correcto el tipo de dato?");
                            return;
                        }
                        labMax.Text = "Dato Máximo: " + Convert.ToString(maximo.Rows[0]["Maximo"]);
                    } else {
                        if(await new Capa_Negocios.clsColumns().EsquemeInfo(lbColumas.SelectedValue.ToString(), lbTablas.SelectedValue.ToString(), instanceName, cboDataBases.SelectedValue.ToString()) == null) {
                            frmMessageBoxError.Show("Error");
                        }
                        frmMessageBoxError.Show("Imposible obtener esquema de la tabla.");
                        lbColumas.Enabled = false;
                        lbTablas.Enabled = false;
                        lbColumas.Items.Clear ();
                        lbTablas.Items.Clear ();
                        labDataBase.Text = "";           
                    } 
                }
            } else {
                frmMessageBoxError.Show("Seleccione una base de datos.");
            }
        }
        public void limpiar() {

            labDataBase.Text = "Base de Datos: ";
            labEsquema.Text = "Esquema de columna: ";
            labTable.Text = "Tabla seleccionada";
            labCantRegistros.Text = "Cantidad de registros";
            labMax.Text = "Dato Maximo";
            labMin.Text = "Dato Mínimo";
        }
    }
}
