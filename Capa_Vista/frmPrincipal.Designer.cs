namespace Capa_Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbColumas = new System.Windows.Forms.ListBox();
            this.btnCargar = new MetroFramework.Controls.MetroButton();
            this.lbTablas = new System.Windows.Forms.ListBox();
            this.cboDataBases = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.labMin = new MetroFramework.Controls.MetroLabel();
            this.labMax = new MetroFramework.Controls.MetroLabel();
            this.labCantRegistros = new MetroFramework.Controls.MetroLabel();
            this.labTable = new MetroFramework.Controls.MetroLabel();
            this.labEsquema = new MetroFramework.Controls.MetroLabel();
            this.labDataBase = new MetroFramework.Controls.MetroLabel();
            this.dgvInfoRegistros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(20, 60);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.sc.Panel1.Controls.Add(this.metroLabel3);
            this.sc.Panel1.Controls.Add(this.metroLabel2);
            this.sc.Panel1.Controls.Add(this.metroLabel1);
            this.sc.Panel1.Controls.Add(this.lbColumas);
            this.sc.Panel1.Controls.Add(this.btnCargar);
            this.sc.Panel1.Controls.Add(this.lbTablas);
            this.sc.Panel1.Controls.Add(this.cboDataBases);
            this.sc.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.sc.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sc.Panel2.Controls.Add(this.panel1);
            this.sc.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sc.Size = new System.Drawing.Size(1232, 513);
            this.sc.SplitterDistance = 293;
            this.sc.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Tablas";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 338);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Columnas";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Base de Datos:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbColumas
            // 
            this.lbColumas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lbColumas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbColumas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbColumas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumas.ForeColor = System.Drawing.Color.White;
            this.lbColumas.FormattingEnabled = true;
            this.lbColumas.ItemHeight = 17;
            this.lbColumas.Location = new System.Drawing.Point(12, 360);
            this.lbColumas.Name = "lbColumas";
            this.lbColumas.Size = new System.Drawing.Size(263, 136);
            this.lbColumas.TabIndex = 5;
            this.lbColumas.DoubleClick += new System.EventHandler(this.lbColumas_DoubleClick);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightGray;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Location = new System.Drawing.Point(180, 49);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 29);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCargar.UseSelectable = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lbTablas
            // 
            this.lbTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lbTablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTablas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTablas.ForeColor = System.Drawing.Color.White;
            this.lbTablas.FormattingEnabled = true;
            this.lbTablas.ItemHeight = 17;
            this.lbTablas.Location = new System.Drawing.Point(12, 129);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(263, 136);
            this.lbTablas.TabIndex = 5;
            this.lbTablas.DoubleClick += new System.EventHandler(this.lbTablas_DoubleClick);
            // 
            // cboDataBases
            // 
            this.cboDataBases.BackColor = System.Drawing.Color.LightGray;
            this.cboDataBases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDataBases.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDataBases.FormattingEnabled = true;
            this.cboDataBases.ItemHeight = 23;
            this.cboDataBases.Location = new System.Drawing.Point(12, 49);
            this.cboDataBases.Name = "cboDataBases";
            this.cboDataBases.Size = new System.Drawing.Size(162, 29);
            this.cboDataBases.TabIndex = 2;
            this.cboDataBases.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.labMin);
            this.panel1.Controls.Add(this.labMax);
            this.panel1.Controls.Add(this.labCantRegistros);
            this.panel1.Controls.Add(this.labTable);
            this.panel1.Controls.Add(this.labEsquema);
            this.panel1.Controls.Add(this.labDataBase);
            this.panel1.Controls.Add(this.dgvInfoRegistros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 513);
            this.panel1.TabIndex = 0;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.LightGray;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton2.Location = new System.Drawing.Point(758, 210);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(159, 29);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "Mostrar Porcentajes";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(415, 93);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(88, 19);
            this.labMin.TabIndex = 18;
            this.labMin.Text = "Data Mínimo:";
            this.labMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Location = new System.Drawing.Point(411, 33);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(92, 19);
            this.labMax.TabIndex = 17;
            this.labMax.Text = "Dato Máximo:";
            this.labMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labCantRegistros
            // 
            this.labCantRegistros.AutoSize = true;
            this.labCantRegistros.Location = new System.Drawing.Point(18, 199);
            this.labCantRegistros.Name = "labCantRegistros";
            this.labCantRegistros.Size = new System.Drawing.Size(141, 19);
            this.labCantRegistros.TabIndex = 14;
            this.labCantRegistros.Text = "Cantidad de Registros:";
            this.labCantRegistros.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labTable
            // 
            this.labTable.AutoSize = true;
            this.labTable.Location = new System.Drawing.Point(18, 140);
            this.labTable.Name = "labTable";
            this.labTable.Size = new System.Drawing.Size(120, 19);
            this.labTable.TabIndex = 13;
            this.labTable.Text = "Tabla seleccionada:";
            this.labTable.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labEsquema
            // 
            this.labEsquema.AutoSize = true;
            this.labEsquema.Location = new System.Drawing.Point(18, 86);
            this.labEsquema.Name = "labEsquema";
            this.labEsquema.Size = new System.Drawing.Size(142, 19);
            this.labEsquema.TabIndex = 12;
            this.labEsquema.Text = "Esquema de  columna:";
            this.labEsquema.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labDataBase
            // 
            this.labDataBase.AutoSize = true;
            this.labDataBase.Location = new System.Drawing.Point(18, 33);
            this.labDataBase.Name = "labDataBase";
            this.labDataBase.Size = new System.Drawing.Size(95, 19);
            this.labDataBase.TabIndex = 12;
            this.labDataBase.Text = "Base de Datos:";
            this.labDataBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvInfoRegistros
            // 
            this.dgvInfoRegistros.AllowUserToAddRows = false;
            this.dgvInfoRegistros.AllowUserToDeleteRows = false;
            this.dgvInfoRegistros.AllowUserToResizeRows = false;
            this.dgvInfoRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoRegistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvInfoRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInfoRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInfoRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfoRegistros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInfoRegistros.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInfoRegistros.Location = new System.Drawing.Point(0, 269);
            this.dgvInfoRegistros.MultiSelect = false;
            this.dgvInfoRegistros.Name = "dgvInfoRegistros";
            this.dgvInfoRegistros.ReadOnly = true;
            this.dgvInfoRegistros.RowHeadersVisible = false;
            this.dgvInfoRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoRegistros.Size = new System.Drawing.Size(935, 244);
            this.dgvInfoRegistros.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 593);
            this.Controls.Add(this.sc);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Esquema de Bases de Datos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private MetroFramework.Controls.MetroComboBox cboDataBases;
        private MetroFramework.Controls.MetroButton btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbColumas;
        private System.Windows.Forms.ListBox lbTablas;
        private System.Windows.Forms.DataGridView dgvInfoRegistros;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labEsquema;
        private MetroFramework.Controls.MetroLabel labDataBase;
        private MetroFramework.Controls.MetroLabel labCantRegistros;
        private MetroFramework.Controls.MetroLabel labTable;
        private MetroFramework.Controls.MetroLabel labMin;
        private MetroFramework.Controls.MetroLabel labMax;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}