namespace Rosenstengel
{
    partial class Welcome
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHaupt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHaupt
            // 
            this.btnHaupt.Location = new System.Drawing.Point(71, 276);
            this.btnHaupt.Name = "btnHaupt";
            this.btnHaupt.Size = new System.Drawing.Size(267, 52);
            this.btnHaupt.TabIndex = 0;
            this.btnHaupt.Text = "Willkommen";
            this.btnHaupt.UseVisualStyleBackColor = true;
            this.btnHaupt.Click += new System.EventHandler(this.btnHaupt_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 359);
            this.Controls.Add(this.btnHaupt);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHaupt;
    }
}

