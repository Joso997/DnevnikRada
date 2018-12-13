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
    public partial class broj_odrzavanja_kroz_vrijeme_2 : Form
    {
        public broj_odrzavanja_kroz_vrijeme_2()
        {
            InitializeComponent();
        }

        private void broj_odrzavanja_kroz_vrijeme_2_FormClosed(object sender, FormClosedEventArgs e)
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
