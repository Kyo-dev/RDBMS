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
            this.lbTablas = new System.Windows.Forms.ListBox();
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
            this.sc.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel1.Controls.Add(this.lbTablas);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sc.Panel2.Controls.Add(this.dgvInfoTablas);
            this.sc.Size = new System.Drawing.Size(904, 506);
            this.sc.SplitterDistance = 190;
            this.sc.TabIndex = 0;
            // 
            // lbTablas
            // 
            this.lbTablas.FormattingEnabled = true;
            this.lbTablas.Location = new System.Drawing.Point(3, 4);
            this.lbTablas.Name = "lbTablas";
            this.lbTablas.Size = new System.Drawing.Size(184, 498);
            this.lbTablas.TabIndex = 0;
            // 
            // dgvInfoTablas
            // 
            this.dgvInfoTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoTablas.Location = new System.Drawing.Point(13, 22);
            this.dgvInfoTablas.Name = "dgvInfoTablas";
            this.dgvInfoTablas.Size = new System.Drawing.Size(685, 287);
            this.dgvInfoTablas.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 506);
            this.Controls.Add(this.sc);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.DataGridView dgvInfoTablas;
        private System.Windows.Forms.ListBox lbTablas;
    }
}