using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosenstengel
{
    public partial class Haupt : Form
    {
        public Haupt()
        {
            InitializeComponent();
        }

        private void Haupt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKontakt_Click(object sender, EventArgs e)
        {
            Kontakt KFrm = new Kontakt();
            KFrm.Show();
            this.Hide();
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            Termin TFrm = new Termin();
            TFrm.Show();
            this.Hide();
        }

        private void btnVerlassen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
