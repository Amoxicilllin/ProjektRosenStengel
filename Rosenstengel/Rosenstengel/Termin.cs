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
    public partial class Termin : Form
    {
        public Termin()
        {
            InitializeComponent();
        }

        private void Termin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.frmHaupt == null)
            {
                Haupt frmHaupt = new Haupt();
                Program.frmHaupt = frmHaupt;
                frmHaupt.Show();
            }
        }
    }
}
