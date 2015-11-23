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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnHaupt_Click(object sender, EventArgs e)
        {
            Haupt frmHaupt = new Haupt();
            frmHaupt.Show();

            this.Hide();
        }
    }
}
