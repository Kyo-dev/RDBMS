namespace Capa_Vista {
    partial class frmPorcentajes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbChar = new MetroFramework.Controls.MetroLabel();
            this.lbSmallint = new MetroFramework.Controls.MetroLabel();
            this.lbTinyint = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.lbBit = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Location = new System.Drawing.Point(38, 120);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(41, 19);
            this.lbChar.TabIndex = 0;
            this.lbChar.Text = "Char:";
            this.lbChar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbSmallint
            // 
            this.lbSmallint.AutoSize = true;
            this.lbSmallint.Location = new System.Drawing.Point(38, 139);
            this.lbSmallint.Name = "lbSmallint";
            this.lbSmallint.Size = new System.Drawing.Size(58, 19);
            this.lbSmallint.TabIndex = 1;
            this.lbSmallint.Text = "Smallint:";
            this.lbSmallint.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbTinyint
            // 
            this.lbTinyint.AutoSize = true;
            this.lbTinyint.Location = new System.Drawing.Point(38, 158);
            this.lbTinyint.Name = "lbTinyint";
            this.lbTinyint.Size = new System.Drawing.Size(49, 19);
            this.lbTinyint.TabIndex = 2;
            this.lbTinyint.Text = "Tinyint:";
            this.lbTinyint.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightGray;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton1.Location = new System.Drawing.Point(321, 120);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(159, 29);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Cambiar tipo de dato";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(175, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Tipo de dato recomendado:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(38, 177);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(65, 19);
            this.lbDate.TabIndex = 15;
            this.lbDate.Text = "Datetime:";
            this.lbDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbBit
            // 
            this.lbBit.AutoSize = true;
            this.lbBit.Location = new System.Drawing.Point(38, 196);
            this.lbBit.Name = "lbBit";
            this.lbBit.Size = new System.Drawing.Size(24, 19);
            this.lbBit.TabIndex = 16;
            this.lbBit.Text = "Bit";
            this.lbBit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmPorcentajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 314);
            this.Controls.Add(this.lbBit);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbTinyint);
            this.Controls.Add(this.lbSmallint);
            this.Controls.Add(this.lbChar);
            this.Name = "frmPorcentajes";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Porcentajes";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmPorcentajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbChar;
        private MetroFramework.Controls.MetroLabel lbSmallint;
        private MetroFramework.Controls.MetroLabel lbTinyint;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbDate;
        private MetroFramework.Controls.MetroLabel lbBit;
    }
}