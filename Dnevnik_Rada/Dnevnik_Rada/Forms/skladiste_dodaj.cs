using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dnevnik_Rada.Klase;

namespace Dnevnik_Rada
{
    public partial class Skladiste_dodaj : Form
    {
        public Skladiste_dodaj()
        {
            InitializeComponent();
        }

        private void Skladiste_dodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void Potvrdi_Click(object sender, EventArgs e)
        {
            Skladiste skladiste = new Skladiste(naziv_materijala.Text, proizvodac.Text, mjerna_jedinica.Text);
        }

        
    }
}
