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
            this.btnEject = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.lbInt = new MetroFramework.Controls.MetroLabel();
            this.txtConsult = new MetroFramework.Controls.MetroTextBox();
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
            this.lbSmallint.Location = new System.Drawing.Point(38, 154);
            this.lbSmallint.Name = "lbSmallint";
            this.lbSmallint.Size = new System.Drawing.Size(58, 19);
            this.lbSmallint.TabIndex = 1;
            this.lbSmallint.Text = "Smallint:";
            this.lbSmallint.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbTinyint
            // 
            this.lbTinyint.AutoSize = true;
            this.lbTinyint.Location = new System.Drawing.Point(38, 173);
            this.lbTinyint.Name = "lbTinyint";
            this.lbTinyint.Size = new System.Drawing.Size(49, 19);
            this.lbTinyint.TabIndex = 2;
            this.lbTinyint.Text = "Tinyint:";
            this.lbTinyint.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnEject
            // 
            this.btnEject.BackColor = System.Drawing.Color.LightGray;
            this.btnEject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEject.Location = new System.Drawing.Point(314, 366);
            this.btnEject.Name = "btnEject";
            this.btnEject.Size = new System.Drawing.Size(159, 29);
            this.btnEject.TabIndex = 13;
            this.btnEject.Text = "Ejecutar";
            this.btnEject.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEject.UseSelectable = true;
            this.btnEject.Click += new System.EventHandler(this.btnEject_Click);
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
            this.lbDate.Location = new System.Drawing.Point(38, 192);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(65, 19);
            this.lbDate.TabIndex = 15;
            this.lbDate.Text = "Datetime:";
            this.lbDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(38, 139);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(26, 19);
            this.lbInt.TabIndex = 17;
            this.lbInt.Text = "Int:";
            this.lbInt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtConsult
            // 
            // 
            // 
            // 
            this.txtConsult.CustomButton.Image = null;
            this.txtConsult.CustomButton.Location = new System.Drawing.Point(407, 2);
            this.txtConsult.CustomButton.Name = "";
            this.txtConsult.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtConsult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsult.CustomButton.TabIndex = 1;
            this.txtConsult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsult.CustomButton.UseSelectable = true;
            this.txtConsult.CustomButton.Visible = false;
            this.txtConsult.Lines = new string[0];
            this.txtConsult.Location = new System.Drawing.Point(38, 304);
            this.txtConsult.MaxLength = 32767;
            this.txtConsult.Name = "txtConsult";
            this.txtConsult.PasswordChar = '\0';
            this.txtConsult.PromptText = "Ejecutar una consulta";
            this.txtConsult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsult.SelectedText = "";
            this.txtConsult.SelectionLength = 0;
            this.txtConsult.SelectionStart = 0;
            this.txtConsult.ShortcutsEnabled = true;
            this.txtConsult.Size = new System.Drawing.Size(435, 30);
            this.txtConsult.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsult.TabIndex = 18;
            this.txtConsult.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtConsult.UseSelectable = true;
            this.txtConsult.WaterMark = "Ejecutar una consulta";
            this.txtConsult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmPorcentajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 428);
            this.Controls.Add(this.txtConsult);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnEject);
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
        private MetroFramework.Controls.MetroButton btnEject;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbDate;
        private MetroFramework.Controls.MetroLabel lbInt;
        private MetroFramework.Controls.MetroTextBox txtConsult;
    }
}