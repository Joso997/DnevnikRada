using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap_za_odrzavanje_i_evidenciju
{
    public partial class odstupanje_od_normale_2 : Form
    {
        public odstupanje_od_normale_2()
        {
            InitializeComponent();
        }

        private void odstupanje_od_normale_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            stanje_poduzeća stanje_poduzeća = new stanje_poduzeća();
            this.Hide();
            stanje_poduzeća.Show();
        }
    }
}
