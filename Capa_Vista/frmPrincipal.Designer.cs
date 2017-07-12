namespace Capa_Vista {
    partial class frmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sc = new System.Windows.Forms.SplitContainer();
            this.labNomBD = new System.Windows.Forms.Label();
            this.labNomTab = new System.Windows.Forms.Label();
            this.lbColumas = new System.Windows.Forms.ListBox();
            this.cboDataBases = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lbTablas = new System.Windows.Forms.ListBox();
            this.labNomColum = new System.Windows.Forms.Label();
            this.dgvInfoTablas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.sc.Panel1.Controls.Add(this.labNomBD);
            this.sc.Panel1.Controls.Add(this.labNomTab);
            this.sc.Panel1.Controls.Add(this.lbColumas);
            this.sc.Panel1.Controls.Add(this.cboDataBases);
            this.sc.Panel1.Controls.Add(this.btnCargar);
            this.sc.Panel1.Controls.Add(this.lbTablas);
            this.sc.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.sc.Panel2.Controls.Add(this.labNomColum);
            this.sc.Panel2.Controls.Add(this.dgvInfoTablas);
            this.sc.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sc.Size = new System.Drawing.Size(910, 543);
            this.sc.SplitterDistance = 221;
            this.sc.TabIndex = 0;
            // 
            // labNomBD
            // 
            this.labNomBD.AutoSize = true;
            this.labNomBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomBD.ForeColor = System.Drawing.Color.White;
            this.labNomBD.Location = new System.Drawing.Point(12, 35);
            this.labNomBD.Name = "labNomBD";
            this.labNomBD.Size = new System.Drawing.Size(0, 16);
            this.labNomBD.TabIndex = 6;
            // 
            // labNomTab
            // 
            this.labNomTab.AutoSize = true;
            this.labNomTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomTab.ForeColor = System.Drawing.Color.White;
            this.labNomTab.Location = new System.Drawing.Point(12, 308);
            this.labNomTab.Name = "labNomTab";
            this.labNomTab.Size = new System.Drawing.Size(0, 16);
            this.labNomTab.TabIndex = 4;
            // 
            // lbColumas
            // 
            this.lbColumas.BackColor = System.Drawing.Color.Snow;
            this.lbColumas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbColumas.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbColumas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumas.ForeColor = System.Drawing.Color.Black;
            this.lbColumas.FormattingEnabled = true;
            this.lbColumas.ItemHeight = 17;
            this.lbColumas.Location = new System.Drawing.Point(12, 344);
            this.lbColumas.Name = "lbColumas";
            this.lbColumas.Size = new System.Drawing.Size(195, 187);
            this.lbColumas.TabIndex = 2;
            this.lbColumas.DoubleClick += new System.EventHandler(this.lbColumas_DoubleClick);
            // 
            // cboDataBases
            // 
            this.cboDataBases.BackColor = System.Drawing.Color.SteelBlue;
            this.cboDataBases.ForeColor = System.Drawing.Color.Snow;
            this.cboDataBases.FormattingEnabled = true;
            this.cboDataBases.Location = new System.Drawing.Point(88, 8);
            this.cboDataBases.Name = "cboDataBases";
            this.cboDataBases.Size = new System.Drawing.Size(119, 21);
            this.cboDataBases.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Snow;
            this.btnCargar.Location = new System.Drawing.Point(12, 3);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(70, 29);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lbTablas
            // 
            this.lbTablas.BackColor = System.Drawing.Color.Snow;
            this.lbTablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTablas.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbTablas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTablas.ForeColor = System.Drawing.Color.Black;
            this.lbTablas.FormattingEnabled = true;
            this.lbTablas.ItemHeight = 17;
            this.lbTablas.Location = new System.Drawing.Point(12, 72);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(195, 221);
            this.lbTablas.TabIndex = 0;
            this.lbTablas.DoubleClick += new System.EventHandler(this.lbTablas_DoubleClick);
            // 
            // labNomColum
            // 
            this.labNomColum.AutoSize = true;
            this.labNomColum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomColum.ForeColor = System.Drawing.Color.White;
            this.labNomColum.Location = new System.Drawing.Point(16, 16);
            this.labNomColum.Name = "labNomColum";
            this.labNomColum.Size = new System.Drawing.Size(0, 16);
            this.labNomColum.TabIndex = 2;
            // 
            // dgvInfoTablas
            // 
            this.dgvInfoTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoTablas.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvInfoTablas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInfoTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoTablas.Location = new System.Drawing.Point(19, 72);
            this.dgvInfoTablas.Name = "dgvInfoTablas";
            this.dgvInfoTablas.Size = new System.Drawing.Size(653, 76);
            this.dgvInfoTablas.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(910, 543);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "frmPrincipal";
            this.Text = "RDBMS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            this.sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.DataGridView dgvInfoTablas;
        private System.Windows.Forms.ListBox lbTablas;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cboDataBases;
        private System.Windows.Forms.ListBox lbColumas;
        private System.Windows.Forms.Label labNomColum;
        private System.Windows.Forms.Label labNomTab;
        private System.Windows.Forms.Label labNomBD;
    }
}