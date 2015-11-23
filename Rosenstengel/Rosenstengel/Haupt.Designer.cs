namespace Rosenstengel
{
    partial class Haupt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.btnKontakt = new System.Windows.Forms.Button();
            this.btnTermin = new System.Windows.Forms.Button();
            this.btnVerlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKontakt
            // 
            this.btnKontakt.Location = new System.Drawing.Point(74, 40);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(187, 50);
            this.btnKontakt.TabIndex = 0;
            this.btnKontakt.Text = "Kontakt";
            this.btnKontakt.UseVisualStyleBackColor = true;
            this.btnKontakt.Click += new System.EventHandler(this.btnKontakt_Click);
            // 
            // btnTermin
            // 
            this.btnTermin.Location = new System.Drawing.Point(74, 130);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(187, 50);
            this.btnTermin.TabIndex = 1;
            this.btnTermin.Text = "Termin";
            this.btnTermin.UseVisualStyleBackColor = true;
            this.btnTermin.Click += new System.EventHandler(this.btnTermin_Click);
            // 
            // btnVerlassen
            // 
            this.btnVerlassen.Location = new System.Drawing.Point(74, 226);
            this.btnVerlassen.Name = "btnVerlassen";
            this.btnVerlassen.Size = new System.Drawing.Size(187, 50);
            this.btnVerlassen.TabIndex = 2;
            this.btnVerlassen.Text = "Verlassen";
            this.btnVerlassen.UseVisualStyleBackColor = true;
            this.btnVerlassen.Click += new System.EventHandler(this.btnVerlassen_Click);
            // 
            // Haupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 335);
            this.Controls.Add(this.btnVerlassen);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.btnKontakt);
            this.Name = "Haupt";
            this.Text = "Haupt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Haupt_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKontakt;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.Button btnVerlassen;
    }
}