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
            this.SuspendLayout();
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Location = new System.Drawing.Point(35, 80);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(41, 19);
            this.lbChar.TabIndex = 0;
            this.lbChar.Text = "Char:";
            this.lbChar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmPorcentajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 369);
            this.Controls.Add(this.lbChar);
            this.Name = "frmPorcentajes";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Porcentajes";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbChar;
    }
}