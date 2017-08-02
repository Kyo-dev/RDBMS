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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.gb = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbColumas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTablas = new System.Windows.Forms.ListBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cboDataBases = new MetroFramework.Controls.MetroComboBox();
            this.labNomTab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvInfoEsquema = new System.Windows.Forms.DataGridView();
            this.dgvInfoRegistros = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labCantRegistros = new System.Windows.Forms.Label();
            this.labNomRegistros = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labTable = new System.Windows.Forms.Label();
            this.labEsquema = new System.Windows.Forms.Label();
            this.labDataBase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.gb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEsquema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoRegistros)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.sc.Panel1.Controls.Add(this.gb);
            this.sc.Panel1.Controls.Add(this.labNomTab);
            this.sc.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.sc.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sc.Panel2.Controls.Add(this.panel1);
            this.sc.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sc.Size = new System.Drawing.Size(1059, 513);
            this.sc.SplitterDistance = 252;
            this.sc.TabIndex = 0;
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.Transparent;
            this.gb.Controls.Add(this.groupBox2);
            this.gb.Controls.Add(this.groupBox1);
            this.gb.Controls.Add(this.metroPanel1);
            this.gb.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.ForeColor = System.Drawing.Color.White;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(250, 513);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            this.gb.Text = "Seleccionar Base:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbColumas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columnas";
            // 
            // lbColumas
            // 
            this.lbColumas.BackColor = System.Drawing.Color.LightGray;
            this.lbColumas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbColumas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbColumas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbColumas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumas.ForeColor = System.Drawing.Color.Black;
            this.lbColumas.FormattingEnabled = true;
            this.lbColumas.ItemHeight = 17;
            this.lbColumas.Location = new System.Drawing.Point(3, 18);
            this.lbColumas.Name = "lbColumas";
            this.lbColumas.Size = new System.Drawing.Size(238, 189);
            this.lbColumas.TabIndex = 5;
            this.lbColumas.DoubleClick += new System.EventHandler(this.lbColumas_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTablas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas";
            // 
            // lbTablas
            // 
            this.lbTablas.BackColor = System.Drawing.Color.LightGray;
            this.lbTablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTablas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTablas.ForeColor = System.Drawing.Color.Black;
            this.lbTablas.FormattingEnabled = true;
            this.lbTablas.ItemHeight = 17;
            this.lbTablas.Location = new System.Drawing.Point(3, 18);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(238, 167);
            this.lbTablas.TabIndex = 5;
            this.lbTablas.DoubleClick += new System.EventHandler(this.lbTablas_DoubleClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.metroPanel1.Controls.Add(this.btnCargar);
            this.metroPanel1.Controls.Add(this.cboDataBases);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 18);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(244, 94);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightGray;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Location = new System.Drawing.Point(64, 51);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 29);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cboDataBases
            // 
            this.cboDataBases.BackColor = System.Drawing.Color.LightGray;
            this.cboDataBases.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDataBases.FormattingEnabled = true;
            this.cboDataBases.ItemHeight = 23;
            this.cboDataBases.Location = new System.Drawing.Point(12, 16);
            this.cboDataBases.Name = "cboDataBases";
            this.cboDataBases.Size = new System.Drawing.Size(220, 29);
            this.cboDataBases.TabIndex = 2;
            this.cboDataBases.UseSelectable = true;
            // 
            // labNomTab
            // 
            this.labNomTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labNomTab.AutoSize = true;
            this.labNomTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomTab.ForeColor = System.Drawing.Color.White;
            this.labNomTab.Location = new System.Drawing.Point(12, 293);
            this.labNomTab.Name = "labNomTab";
            this.labNomTab.Size = new System.Drawing.Size(0, 16);
            this.labNomTab.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gbInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 513);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvInfoRegistros);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 383);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Esquema de columnas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvInfoEsquema);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(797, 184);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // dgvInfoEsquema
            // 
            this.dgvInfoEsquema.AllowUserToAddRows = false;
            this.dgvInfoEsquema.AllowUserToDeleteRows = false;
            this.dgvInfoEsquema.AllowUserToResizeRows = false;
            this.dgvInfoEsquema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoEsquema.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvInfoEsquema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInfoEsquema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfoEsquema.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoEsquema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfoEsquema.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInfoEsquema.Location = new System.Drawing.Point(3, 18);
            this.dgvInfoEsquema.MultiSelect = false;
            this.dgvInfoEsquema.Name = "dgvInfoEsquema";
            this.dgvInfoEsquema.ReadOnly = true;
            this.dgvInfoEsquema.RowHeadersVisible = false;
            this.dgvInfoEsquema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoEsquema.Size = new System.Drawing.Size(791, 163);
            this.dgvInfoEsquema.TabIndex = 7;
            // 
            // dgvInfoRegistros
            // 
            this.dgvInfoRegistros.AllowUserToAddRows = false;
            this.dgvInfoRegistros.AllowUserToDeleteRows = false;
            this.dgvInfoRegistros.AllowUserToResizeRows = false;
            this.dgvInfoRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoRegistros.BackgroundColor = System.Drawing.Color.Black;
            this.dgvInfoRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInfoRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfoRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfoRegistros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvInfoRegistros.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInfoRegistros.Location = new System.Drawing.Point(3, 18);
            this.dgvInfoRegistros.MultiSelect = false;
            this.dgvInfoRegistros.Name = "dgvInfoRegistros";
            this.dgvInfoRegistros.ReadOnly = true;
            this.dgvInfoRegistros.RowHeadersVisible = false;
            this.dgvInfoRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoRegistros.Size = new System.Drawing.Size(797, 187);
            this.dgvInfoRegistros.TabIndex = 8;
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Black;
            this.gbInfo.Controls.Add(this.groupBox5);
            this.gbInfo.Controls.Add(this.groupBox6);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(0, 383);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(803, 130);
            this.gbInfo.TabIndex = 8;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Información";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labCantRegistros);
            this.groupBox5.Controls.Add(this.labNomRegistros);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(442, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 108);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // labCantRegistros
            // 
            this.labCantRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labCantRegistros.AutoSize = true;
            this.labCantRegistros.BackColor = System.Drawing.Color.Transparent;
            this.labCantRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantRegistros.ForeColor = System.Drawing.Color.White;
            this.labCantRegistros.Location = new System.Drawing.Point(6, 18);
            this.labCantRegistros.Name = "labCantRegistros";
            this.labCantRegistros.Size = new System.Drawing.Size(145, 16);
            this.labCantRegistros.TabIndex = 6;
            this.labCantRegistros.Text = "Cantidad de Registros:";
            // 
            // labNomRegistros
            // 
            this.labNomRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNomRegistros.AutoSize = true;
            this.labNomRegistros.BackColor = System.Drawing.Color.Transparent;
            this.labNomRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomRegistros.ForeColor = System.Drawing.Color.White;
            this.labNomRegistros.Location = new System.Drawing.Point(6, 63);
            this.labNomRegistros.Name = "labNomRegistros";
            this.labNomRegistros.Size = new System.Drawing.Size(156, 16);
            this.labNomRegistros.TabIndex = 3;
            this.labNomRegistros.Text = "Registros de la columna:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labTable);
            this.groupBox6.Controls.Add(this.labEsquema);
            this.groupBox6.Controls.Add(this.labDataBase);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(17, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 108);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // labTable
            // 
            this.labTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTable.AutoSize = true;
            this.labTable.BackColor = System.Drawing.Color.Transparent;
            this.labTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTable.ForeColor = System.Drawing.Color.White;
            this.labTable.Location = new System.Drawing.Point(6, 80);
            this.labTable.Name = "labTable";
            this.labTable.Size = new System.Drawing.Size(132, 16);
            this.labTable.TabIndex = 4;
            this.labTable.Text = "Tabla seleccionada:";
            // 
            // labEsquema
            // 
            this.labEsquema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEsquema.AutoSize = true;
            this.labEsquema.BackColor = System.Drawing.Color.Transparent;
            this.labEsquema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEsquema.ForeColor = System.Drawing.Color.White;
            this.labEsquema.Location = new System.Drawing.Point(6, 50);
            this.labEsquema.Name = "labEsquema";
            this.labEsquema.Size = new System.Drawing.Size(142, 16);
            this.labEsquema.TabIndex = 5;
            this.labEsquema.Text = "Esquema de columna:";
            // 
            // labDataBase
            // 
            this.labDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDataBase.AutoSize = true;
            this.labDataBase.BackColor = System.Drawing.Color.Transparent;
            this.labDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataBase.ForeColor = System.Drawing.Color.White;
            this.labDataBase.Location = new System.Drawing.Point(6, 18);
            this.labDataBase.Name = "labDataBase";
            this.labDataBase.Size = new System.Drawing.Size(104, 16);
            this.labDataBase.TabIndex = 2;
            this.labDataBase.Text = "Base de Datos: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 593);
            this.Controls.Add(this.sc);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Bases de Datos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.gb.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEsquema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoRegistros)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Label labNomTab;
        private System.Windows.Forms.GroupBox gb;
        private MetroFramework.Controls.MetroComboBox cboDataBases;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label labDataBase;
        private System.Windows.Forms.Label labNomRegistros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbColumas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbTablas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvInfoEsquema;
        private System.Windows.Forms.DataGridView dgvInfoRegistros;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label labTable;
        private System.Windows.Forms.Label labEsquema;
        private System.Windows.Forms.Label labCantRegistros;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}