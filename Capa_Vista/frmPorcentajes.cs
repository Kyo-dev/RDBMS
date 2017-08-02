using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Capa_Vista {
    public partial class frmPorcentajes : MetroForm {
        public frmPorcentajes(DataColumn dC) {
            this.dC = dC;
            InitializeComponent();
        }

        private DataColumn dC;

        private void frmPorcentajes_Load(object sender, EventArgs e) {
            Capa_Negocios.DataTypeColumns op = new Capa_Negocios.DataTypeColumns();
            lbChar.Text = "Char: " + op.porcentChar(this.dC) + "%";
            lbSmallint.Text = "Smallint: " + op.porcentSmallInt(this.dC) + "%";
            lbTinyint.Text = "Tinyint: " + op.porcenTinyInt(this.dC) + "%";
            lbDate.Text = "DateTime: " + op.porcentDate(this.dC) + "%";
            lbBit.Text = "Bit: " + op.porcenByte(this.dC) + "%";
        }
    }
}
