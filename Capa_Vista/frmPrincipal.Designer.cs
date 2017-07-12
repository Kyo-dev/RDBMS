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
            this.lbColumas = new System.Windows.Forms.ListBox();
            this.cboDataBases = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lbTablas = new System.Windows.Forms.ListBox();
            this.dgvInfoTablas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labNomColum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labNomTab = new System.Windows.Forms.Label();
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
            this.sc.Panel1.Controls.Add(this.labNomTab);
            this.sc.Panel1.Controls.Add(this.label2);
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
            this.sc.Panel2.Controls.Add(this.label1);
            this.sc.Panel2.Controls.Add(this.dgvInfoTablas);
            this.sc.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sc.Size = new System.Drawing.Size(907, 501);
            this.sc.SplitterDistance = 222;
            this.sc.TabIndex = 0;
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
            this.lbColumas.Location = new System.Drawing.Point(12, 302);
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
            this.lbTablas.Location = new System.Drawing.Point(12, 38);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(195, 221);
            this.lbTablas.TabIndex = 0;
            this.lbTablas.DoubleClick += new System.EventHandler(this.lbTablas_DoubleClick);
            // 
            // dgvInfoTablas
            // 
            this.dgvInfoTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoTablas.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvInfoTablas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInfoTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoTablas.Location = new System.Drawing.Point(16, 37);
            this.dgvInfoTablas.Name = "dgvInfoTablas";
            this.dgvInfoTablas.Size = new System.Drawing.Size(653, 222);
            this.dgvInfoTablas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esquema de la columna:";
            // 
            // labNomColum
            // 
            this.labNomColum.AutoSize = true;
            this.labNomColum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomColum.ForeColor = System.Drawing.Color.White;
            this.labNomColum.Location = new System.Drawing.Point(175, 13);
            this.labNomColum.Name = "labNomColum";
            this.labNomColum.Size = new System.Drawing.Size(0, 16);
            this.labNomColum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tabla: ";
            // 
            // labNomTab
            // 
            this.labNomTab.AutoSize = true;
            this.labNomTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomTab.ForeColor = System.Drawing.Color.White;
            this.labNomTab.Location = new System.Drawing.Point(53, 273);
            this.labNomTab.Name = "labNomTab";
            this.labNomTab.Size = new System.Drawing.Size(0, 16);
            this.labNomTab.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(907, 501);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNomTab;
        private System.Windows.Forms.Label label2;
    }
}