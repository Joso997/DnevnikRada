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
    public partial class skladiste_dodaj : Form
    {
        public skladiste_dodaj()
        {
            InitializeComponent();
        }

        private void skladiste_dodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }
    }
}
