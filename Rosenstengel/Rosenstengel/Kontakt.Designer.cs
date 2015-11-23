namespace Rosenstengel
{
    partial class Kontakt
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
            this.components = new System.ComponentModel.Container();
            this.cbLoeschen = new System.Windows.Forms.CheckBox();
            this.cbBearbeiten = new System.Windows.Forms.CheckBox();
            this.cbNeu = new System.Windows.Forms.CheckBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontakteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terminplanerDataSet = new Rosenstengel.TerminplanerDataSet();
            this.kontakteTableAdapter = new Rosenstengel.TerminplanerDataSetTableAdapters.KontakteTableAdapter();
            this.tableAdapterManager = new Rosenstengel.TerminplanerDataSetTableAdapters.TableAdapterManager();
            this.lbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminplanerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoeschen
            // 
            this.cbLoeschen.AutoSize = true;
            this.cbLoeschen.Location = new System.Drawing.Point(330, 569);
            this.cbLoeschen.Name = "cbLoeschen";
            this.cbLoeschen.Size = new System.Drawing.Size(87, 17);
            this.cbLoeschen.TabIndex = 33;
            this.cbLoeschen.Text = "Satz löschen";
            this.cbLoeschen.UseVisualStyleBackColor = true;
            this.cbLoeschen.CheckedChanged += new System.EventHandler(this.cbLoeschen_CheckedChanged);
            // 
            // cbBearbeiten
            // 
            this.cbBearbeiten.AutoSize = true;
            this.cbBearbeiten.Location = new System.Drawing.Point(330, 544);
            this.cbBearbeiten.Name = "cbBearbeiten";
            this.cbBearbeiten.Size = new System.Drawing.Size(100, 17);
            this.cbBearbeiten.TabIndex = 32;
            this.cbBearbeiten.Text = "Satz bearbeiten";
            this.cbBearbeiten.UseVisualStyleBackColor = true;
            this.cbBearbeiten.CheckedChanged += new System.EventHandler(this.cbBearbeiten_CheckedChanged);
            // 
            // cbNeu
            // 
            this.cbNeu.AutoSize = true;
            this.cbNeu.Location = new System.Drawing.Point(330, 516);
            this.cbNeu.Name = "cbNeu";
            this.cbNeu.Size = new System.Drawing.Size(121, 17);
            this.cbNeu.TabIndex = 31;
            this.cbNeu.Text = "neuen Satz anlegen";
            this.cbNeu.UseVisualStyleBackColor = true;
            this.cbNeu.CheckedChanged += new System.EventHandler(this.cbNeu_CheckedChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(480, 516);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(117, 70);
            this.btSave.TabIndex = 30;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(418, 289);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(130, 20);
            this.tbEmail.TabIndex = 29;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(418, 238);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(130, 20);
            this.tbTelefon.TabIndex = 28;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(151, 346);
            this.tbAdresse.Multiline = true;
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(130, 159);
            this.tbAdresse.TabIndex = 27;
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(151, 287);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(130, 20);
            this.tbVorname.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bild";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kontaktliste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontakteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(532, 140);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontakteBindingSource
            // 
            this.kontakteBindingSource.DataMember = "Kontakte";
            this.kontakteBindingSource.DataSource = this.terminplanerDataSet;
            // 
            // terminplanerDataSet
            // 
            this.terminplanerDataSet.DataSetName = "TerminplanerDataSet";
            this.terminplanerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontakteTableAdapter
            // 
            this.kontakteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KontakteTableAdapter = this.kontakteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rosenstengel.TerminplanerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbName
            // 
            this.lbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontakteBindingSource, "Nachname", true));
            this.lbName.Location = new System.Drawing.Point(151, 238);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(130, 20);
            this.lbName.TabIndex = 34;
            // 
            // Kontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 638);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbLoeschen);
            this.Controls.Add(this.cbBearbeiten);
            this.Controls.Add(this.cbNeu);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kontakt";
            this.Text = "Kontakt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kontakt_FormClosing);
            this.Load += new System.EventHandler(this.Kontakt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminplanerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbLoeschen;
        private System.Windows.Forms.CheckBox cbBearbeiten;
        private System.Windows.Forms.CheckBox cbNeu;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TerminplanerDataSet terminplanerDataSet;
        private System.Windows.Forms.BindingSource kontakteBindingSource;
        private TerminplanerDataSetTableAdapters.KontakteTableAdapter kontakteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private TerminplanerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lbName;
    }
}