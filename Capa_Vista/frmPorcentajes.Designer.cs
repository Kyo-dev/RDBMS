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
            this.btnEject = new MetroFramework.Controls.MetroButton();
            this.txtConsult = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnEject
            // 
            this.btnEject.BackColor = System.Drawing.Color.LightGray;
            this.btnEject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEject.Location = new System.Drawing.Point(299, 156);
            this.btnEject.Name = "btnEject";
            this.btnEject.Size = new System.Drawing.Size(159, 29);
            this.btnEject.TabIndex = 13;
            this.btnEject.Text = "Ejecutar";
            this.btnEject.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEject.UseSelectable = true;
            this.btnEject.Click += new System.EventHandler(this.btnEject_Click);
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
            this.txtConsult.Location = new System.Drawing.Point(23, 101);
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
            this.ClientSize = new System.Drawing.Size(477, 228);
            this.Controls.Add(this.txtConsult);
            this.Controls.Add(this.btnEject);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPorcentajes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Ejecutar";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmPorcentajes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnEject;
        private MetroFramework.Controls.MetroTextBox txtConsult;
    }
}