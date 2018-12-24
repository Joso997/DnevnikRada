using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada
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

        

        private void metroButton5_Click(object sender, EventArgs e)
        {
            stanje_poduzeca_2 stanje_poduzeca_2 = new stanje_poduzeca_2();
            this.Hide();
            stanje_poduzeca_2.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            potrosnja_materijala_kroz_vrijeme_2 potrosnja_materijala_kroz_vrijeme_2 = new potrosnja_materijala_kroz_vrijeme_2();
            this.Hide();
            potrosnja_materijala_kroz_vrijeme_2.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            broj_odrzavanja_kroz_vrijeme_2 broj_odrzavanja_kroz_vrijeme_2 = new broj_odrzavanja_kroz_vrijeme_2();
            this.Hide();
            broj_odrzavanja_kroz_vrijeme_2.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            odstupanje_od_normale_2 odstupanje_od_normale_2 = new odstupanje_od_normale_2();
            this.Hide();
            odstupanje_od_normale_2.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            potrosnja_materijala_kroz_vrijeme_2 potrosnja_materijala_kroz_vrijeme_2 = new potrosnja_materijala_kroz_vrijeme_2();
            this.Hide();
            potrosnja_materijala_kroz_vrijeme_2.Show();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            broj_odrzavanja_kroz_vrijeme_2 broj_odrzavanja_kroz_vrijeme_2 = new broj_odrzavanja_kroz_vrijeme_2();
            this.Hide();
            broj_odrzavanja_kroz_vrijeme_2.Show();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            odstupanje_od_normale_2 odstupanje_od_normale_2 = new odstupanje_od_normale_2();
            this.Hide();
            odstupanje_od_normale_2.Show();
        }
    }
}
