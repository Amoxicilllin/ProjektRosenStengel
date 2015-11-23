using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rosenstengel
{
    public partial class Kontakt : Form
    {
        public Kontakt()
        {
            InitializeComponent();
        }

        private void Kontakt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.frmHaupt == null)
            {
                Haupt frmHaupt = new Haupt();
                Program.frmHaupt = frmHaupt;
                frmHaupt.Show();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if ((cbLoeschen.Checked == true && cbBearbeiten.Checked == true) || (cbBearbeiten.Checked == true && cbLoeschen.Checked == true) || (cbNeu.Checked == true && cbBearbeiten.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");
            }
            if (cbNeu.Checked == true)
            {
                MessageBox.Show("Der Satz wurde angelegt!");
            }
            else if (cbBearbeiten.Checked == true)
            {
                MessageBox.Show("Der Satz wurde bearbeitet!");
            }
            else if (cbLoeschen.Checked == true)
            {
                MessageBox.Show("Der Satz wurde gelöscht");
            }
        }

        private void cbBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbNeu.Checked == true && cbBearbeiten.Checked == true) || (cbBearbeiten.Checked == true && cbLoeschen.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");
            }
        }

        private void cbLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbLoeschen.Checked == true && cbBearbeiten.Checked == true) || (cbBearbeiten.Checked == true && cbLoeschen.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");
            }
        }

        private void cbNeu_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbNeu.Checked == true && cbBearbeiten.Checked == true) || (cbNeu.Checked == true && cbLoeschen.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");
            }
            if (cbNeu.Checked == true)
            {
                tbAdresse.Text = " ";
                tbEmail.Text = " ";
                lbName.Text = " ";
                tbTelefon.Text = " ";
                tbVorname.Text = " ";
            }
        }

        private void Kontakt_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "terminplanerDataSet.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kontakteTableAdapter.Fill(this.terminplanerDataSet.Kontakte);
            }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                lbName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbVorname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbAdresse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbTelefon.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                lbName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbVorname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbAdresse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbTelefon.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        public void Test()
        {     
        }

    }
}
